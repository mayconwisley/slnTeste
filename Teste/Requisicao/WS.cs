using System;
using System.Net;

namespace TesteWebService.Requisicao
{
    public class WS
    {
        WebClient webClient;

        public bool Acessar(string url)
        {
            webClient = new WebClient();

            try
            {

                webClient.DownloadString(url);

                return webClient.IsBusy;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
