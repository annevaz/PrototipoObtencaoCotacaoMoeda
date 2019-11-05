using Newtonsoft.Json;

namespace PrototipoObtencaoCotacaoMoeda.Domain.HGFinance
{
    public class HGFinance
    {
        [JsonProperty(PropertyName = "results")]
        public HGFinanceResultado Resultado { get; set; }
    }
}