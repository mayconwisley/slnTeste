using System.Collections.Generic;

namespace TesteWebService.ListaWebServices
{
    public class Integracao
    {
        List<string> lstWebService;
        public List<string> Financeira(string servidor)
        {
            lstWebService = new List<string>
            {
                servidor + @"g5-senior-services/rubi_Asynccom_senior_g5_rh_fp_integracaoFinanceiraERP?wsdl",
                servidor + @"g5-senior-services/rubi_Scheduledcom_senior_g5_rh_fp_integracaoFinanceiraERP?wsdl",
                servidor + @"g5-senior-services/sapiens_Synccom_senior_g5_co_int_vetorh_titulos?wsdl",
                servidor + @"g5-senior-services/sapiens_Synccom_senior_g5_co_mfi_cpa_titulos?wsdl",
                servidor + @"g5-senior-services/sapiens_Synccom_senior_g5_co_mfi_cpa_alteratituloscp?wsdl",
                servidor + @"g5-senior-services/sapiens_Synccom_senior_g5_co_mct_imp_excluirnotafiscalentrada?wsdl",
                servidor + @"g5-senior-services/sapiens_Synccom_senior_g5_co_mct_imp_gravarnotafiscalentrada?wsdl"
            };
            return lstWebService;
        }
        public List<string> Contabil(string servidor)
        {
            lstWebService = new List<string>
            {
                servidor + @"g5-senior-services/sapiens_Synccom_senior_g5_co_mct_ctb_gerarlotectb?wsdl",
                servidor + @"g5-senior-services/sapiens_Synccom_senior_g5_co_mct_ctb_importacaolctctb?wsdl",
                servidor + @"g5-senior-services/sapiens_Synccom_senior_g5_co_mct_ctb_processarlotectb?wsdl",
                servidor + @"g5-senior-services/sapiens_Synccom_senior_g5_co_int_vetorh_complementohistoricopadrao?wsdl"
            };

            return lstWebService;
        }
        public List<string> Fornecedor(string servidor)
        {
            lstWebService = new List<string>
            {
                servidor + @"g5-senior-services/sapiens_Synccom_senior_g5_co_ger_cad_fornecedor?wsdl",
                servidor + @"g5-senior-services/sapiens_Synccom_senior_g5_co_int_vetorh_fornecedores?wsdl"
            };

            return lstWebService;
        }
        public List<string> Pesquisas(string servidor)
        {
            lstWebService = new List<string>
            {
                servidor + @"g5-senior-services/sapiens_Synccom_senior_g5_co_int_vetorh_abrangencia?wsdl"
            };
            return lstWebService;
        }
        public List<string> CentroCusto(string servidor)
        {
            lstWebService = new List<string>
            {
                servidor + @"g5-senior-services/sapiens_Synccom_senior_g5_co_int_vetorh_centrodecustos?wsdl"
            };
            return lstWebService;
        }
    }
}
