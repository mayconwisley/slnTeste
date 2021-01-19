using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TesteWebService.ListaWebServices;
using TesteWebService.Requisicao;
using System.Diagnostics;

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
            int cbxSelectedIndex = 0;
            List<string> listaIntegracoes = null;
            try
            {
                Invoke((Action)(() =>
                              {
                                  BtnTestar.Enabled = false;
                                  LblTeste.Text = "Testando URLs WebServices";
                                  DgvLista.Rows.Clear();
                                  cbxSelectedIndex = CbxOpcaoTeste.SelectedIndex;
                              }));

                switch (cbxSelectedIndex)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CriarGrid(string url, string erro, char opc)
        {
            Invoke((Action)(() =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DgvLista);

                row.Cells[1].Value = url;

                if (opc == 'E')
                {
                    row.Cells[0].Value = "Erro ao carregar";
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.Cells[0].Value = "Web Service OK";
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                row.Cells[2].Value = erro;
                DgvLista.Rows.Add(row);
            }));
        }

        private void SalvarServidor(string servidor)
        {
            Properties.Settings.Default.ServidorJavaEE = servidor;
            Properties.Settings.Default.Save();
        }

        private void BuscarServidor()
        {
            strServidor = Properties.Settings.Default.ServidorJavaEE;
            TxtUrlServidorJavaEE.Text = strServidor;
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
            BtnTestar.Enabled = true;
        }

        private void LnkSeniorDeployTool_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string seniorDeployTool = "SeniorDeployTool/";
            Process.Start(TxtUrlServidorJavaEE.Text + seniorDeployTool);
        }

        private void LnkPainelPadraoGlassfish_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AcessarPadraoGlassfish();
        }

        private void AcessarPadraoGlassfish()
        {
            string novoStrServidor = string.Empty;
            int count = 0;
            foreach (char item in strServidor)
            {
                novoStrServidor += item;
                if (item == ':')
                {
                    count++;

                    if (count == 2)
                    {
                        novoStrServidor += "4848/";
                        break;
                    }
                }
            }
            Process.Start(novoStrServidor);
        }


        private void LnkSolucaoBase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://documentacao.senior.com.br/bancodesolucoes/index.htm#gestao-pessoas/16186.htm");
        }
    }
}
