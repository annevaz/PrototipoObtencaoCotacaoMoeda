using System;
using System.Net;
using Newtonsoft.Json;
using PrototipoObtencaoCotacaoMoeda.Domain.HGFinance;

namespace PrototipoObtencaoCotacaoMoeda.ApiTerceiros
{
    public class HGFinanceApi
    {
        private const string BaseURL = "https://api.hgbrasil.com/finance";

        public static HGFinance ObterCotacao()
        {
            var webClient = new WebClient();
            
            var json = webClient.DownloadString(BaseURL);
            
            return (HGFinance)JsonConvert.DeserializeObject(json, typeof(HGFinance)); 
        }
    }
}