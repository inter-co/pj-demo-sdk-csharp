using System;
using System.Collections.Generic;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class RecuperarBoletos {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			FiltroRecuperarBoletos filtro = FiltroRecuperarBoletos.Builder()
				.SetFiltrarDataPor(TipoDataBoleto.VENCIMENTO)
				.Build();
			Ordenacao ordenacao = Ordenacao.Builder()
				.SetOrdenarPor(OrdenadoPor.DATAVENCIMENTO)
				.SetTipoOrdenacao(TipoOrdenacao.DESC)
				.Build();
			List<BoletoDetalhado> boletos = interSdk.CobrancaSdk().RecuperarBoletos(dataInicial, dataFinal, filtro, ordenacao);
			Console.WriteLine(SdkUtils.Serialize(boletos));
			Console.WriteLine(boletos.Count + " boletos retornados");
		}

	}
}
