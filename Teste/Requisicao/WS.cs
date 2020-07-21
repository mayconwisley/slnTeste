using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Teste.Requisicao
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
