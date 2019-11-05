using Newtonsoft.Json;

namespace PrototipoObtencaoCotacaoMoeda.Domain.HGFinance
{
    public class CotacaoMoeda
    {
        [JsonProperty(PropertyName = "USD")]
        public Moeda Dolar { get; set; }
        
        [JsonProperty(PropertyName = "EUR")]
        public Moeda Euro { get; set; }

        [JsonProperty(PropertyName = "BTC")]
        public Moeda Bitcoin { get; set; }
    }
}