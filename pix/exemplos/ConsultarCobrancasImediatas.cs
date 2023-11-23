using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarCobrancasImediatas {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			FiltroConsultarCobrancasImediatas filtro = null;
			List<CobrancaDetalhada> cobrancas = interSdk.PixSdk().ConsultarCobrancasImediatas(dataInicial, dataFinal, filtro);
			Console.WriteLine(SdkUtils.Serialize(cobrancas));
			Console.WriteLine(cobrancas.Count + " cobranças retornados");
		}

	}
}
