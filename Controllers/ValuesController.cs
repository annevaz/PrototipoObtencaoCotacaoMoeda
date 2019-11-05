using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PrototipoObtencaoCotacaoMoeda.Domain.HGFinance;
using PrototipoObtencaoCotacaoMoeda.ApiTerceiros;

namespace PrototipoObtencaoCotacaoMoeda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return ConsumirApiHGFinance();
        }

        private ActionResult<IEnumerable<string>> ConsumirApiHGFinance()
        {
            var hgFinance = HGFinanceApi.ObterCotacao();

            return new string[] {
                hgFinance.Resultado.CotacaoMoeda.Dolar.Nome,
                Convert.ToString(hgFinance.Resultado.CotacaoMoeda.Dolar.ValorCompra),
                Convert.ToString(hgFinance.Resultado.CotacaoMoeda.Dolar.ValorVenda),
                Convert.ToString(hgFinance.Resultado.CotacaoMoeda.Dolar.VariacaoPercentual),
                hgFinance.Resultado.CotacaoMoeda.Euro.Nome,
                Convert.ToString(hgFinance.Resultado.CotacaoMoeda.Euro.ValorCompra),
                Convert.ToString(hgFinance.Resultado.CotacaoMoeda.Euro.ValorVenda),
                Convert.ToString(hgFinance.Resultado.CotacaoMoeda.Euro.VariacaoPercentual),
                hgFinance.Resultado.CotacaoMoeda.Bitcoin.Nome,
                Convert.ToString(hgFinance.Resultado.CotacaoMoeda.Bitcoin.ValorCompra),
                Convert.ToString(hgFinance.Resultado.CotacaoMoeda.Bitcoin.ValorVenda),
                Convert.ToString(hgFinance.Resultado.CotacaoMoeda.Bitcoin.VariacaoPercentual)
            };
        }
    }
}