using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TesteWebService.ListaWebServices;
using TesteWebService.Requisicao;

namespace TesteWebService
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        WS ws;
        Integracao integracao;
        string strServidor = null;
        private void Acessar()
        {
            ws = new WS();
            integracao = new Integracao();
            strServidor = TxtUrlServidorJavaEE.Text.Trim();
            List<string> listaIntegracoes = null;
            try
            {

                Invoke((Action)(() =>
                {
                    LblTeste.Text = "Testando URLs WebServices";
                }));


                Invoke((Action)(() =>
                {
                    DgvLista.Rows.Clear();
                    switch (CbxOpcaoTeste.SelectedIndex)
                    {
                        case 0:
                            listaIntegracoes = new List<string>();
                            listaIntegracoes = integracao.Financeira(strServidor);

                            break;
                        case 1:
                            listaIntegracoes = new List<string>();
                            listaIntegracoes = integracao.Contabil(strServidor);

                            break;
                        case 2:
                            listaIntegracoes = new List<string>();
                            listaIntegracoes = integracao.Fornecedor(strServidor);

                            break;
                        case 3:
                            listaIntegracoes = new List<string>();
                            listaIntegracoes = integracao.Pesquisas(strServidor);

                            break;
                        case 4:
                            listaIntegracoes = new List<string>();
                            listaIntegracoes = integracao.CentroCusto(strServidor);

                            break;
                        default:
                            break;
                    }

                    foreach (string item in listaIntegracoes.ToList())
                    {
                        try
                        {
                            ws.Acessar(item);
                            CriarGrid(item, null, 'C');
                        }
                        catch (Exception ex)
                        {
                            CriarGrid(item, ex.Message, 'E');
                        }
                    }
                }));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CriarGrid(string url, string erro, char opc)
        {

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(DgvLista);

            row.Cells[1].Value = url;

            if (opc == 'E')
            {
                row.Cells[0].Value = "Erro ao carregar";
            }
            else
            {
                row.Cells[0].Value = "Web Service OK";
            }
            row.Cells[2].Value = erro;
            DgvLista.Rows.Add(row);
        }

        private void SalvarServidor(string servidor)
        {
            Properties.Settings.Default.ServidorJavaEE = servidor;
            Properties.Settings.Default.Save();
        }

        private void BuscarServidor()
        {
            TxtUrlServidorJavaEE.Text = Properties.Settings.Default.ServidorJavaEE;
        }
        private void BtnTestar_Click(object sender, EventArgs e)
        {
            SalvarServidor(TxtUrlServidorJavaEE.Text.Trim());
            BwProcesso.RunWorkerAsync();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            BuscarServidor();
        }

        private void BwProcesso_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Acessar();
        }

        private void BwProcesso_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            LblTeste.Text = "Testes Concluidos!";
        }
    }
}
