using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarCobrancasComVencimento {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			FiltroConsultarCobrancasComVencimento filtro = null;
			List<CobrancaVencimentoDetalhada> cobrancas = interSdk.PixSdk().ConsultarCobrancasComVencimento(dataInicial, dataFinal, filtro);
			Console.WriteLine(SdkUtils.Serialize(cobrancas));
			Console.WriteLine(cobrancas.Count + " cobranças retornados");
		}

	}
}
