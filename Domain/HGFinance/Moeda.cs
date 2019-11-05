using Newtonsoft.Json;

namespace PrototipoObtencaoCotacaoMoeda.Domain.HGFinance
{
    public class Moeda
    {
        [JsonProperty(PropertyName = "name")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "buy")]
        public double ValorCompra { get; set; }

        [JsonProperty(PropertyName = "sell")]
        public double ValorVenda { get; set; }

        [JsonProperty(PropertyName = "variation")]
        public double VariacaoPercentual { get; set; }
    }
}