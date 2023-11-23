using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class ConsultarExtrato {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			Extrato extrato = interSdk.BankingSdk().ConsultarExtrato(dataInicial, dataFinal);
			Console.WriteLine(SdkUtils.Serialize(extrato));
			Console.WriteLine(extrato.Transacoes.Count + " transações retornadas");
		}

	}
}
