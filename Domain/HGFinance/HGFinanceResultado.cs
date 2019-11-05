using Newtonsoft.Json;

namespace PrototipoObtencaoCotacaoMoeda.Domain.HGFinance
{
    public class HGFinanceResultado
    {
        [JsonProperty(PropertyName = "currencies")]
        public CotacaoMoeda CotacaoMoeda { get; set; }
    }
}