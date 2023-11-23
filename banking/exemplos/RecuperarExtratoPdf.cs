using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class RecuperarExtratoPdf {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal, string arquivo) {
			interSdk.BankingSdk().RecuperarExtratoPdf(dataInicial, dataFinal, arquivo);
			Console.WriteLine("Arquivo gerado: " + arquivo);
		}

	}
}
