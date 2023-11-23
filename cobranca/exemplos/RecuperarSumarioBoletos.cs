using System;
using System.Collections.Generic;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class RecuperarSumarioBoletos {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			FiltroRecuperarSumarioBoletos filtro = null;
			Sumario sumario = interSdk.CobrancaSdk().RecuperarSumarioBoletos(dataInicial, dataFinal, filtro);
			Console.WriteLine(SdkUtils.Serialize(sumario));
		}

	}
}
