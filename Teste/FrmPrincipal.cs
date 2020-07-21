using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.MCWFU;
using System.Net.Http.Headers;
using Teste.SyncConsultaColaborador;
using Teste.Requisicao;

namespace Teste
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        WS ws = new WS();

        private void Lista()
        {
            consultarColaboradorConsultarColaboradorIn parameters = new consultarColaboradorConsultarColaboradorIn();
            consultarColaboradorConsultarColaboradorOut outCol = new consultarColaboradorConsultarColaboradorOut();
            rubi_Synccom_senior_g5_rh_fp_consultarColaboradorClient te = new rubi_Synccom_senior_g5_rh_fp_consultarColaboradorClient();

            try
            {
                parameters.numEmpSpecified = true;
                parameters.numEmp = 1;
                parameters.tipColSpecified = true;
                parameters.tipCol = 1;
                parameters.numCadSpecified = true;
                parameters.numCad = 2;

                List<string> testel = new List<string>();

                outCol = te.ConsultarColaborador("senior", "senior", 0, parameters);

                //DgvTeste.DataSource = outCol.TMCSColaboradores;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void BtnTestar_Click(object sender, EventArgs e)
        {
            ws.Acessar("http://localhost:8080/g5-senior-services/rubi_AsyncMCWFUsers?wsdl");
        }
    }
}
