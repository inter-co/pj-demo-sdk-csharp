using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class ConsultarSaldo {
		public void Exemplo(InterSdk interSdk) {
			Saldo saldo = interSdk.BankingSdk().ConsultarSaldo();
			Console.WriteLine(SdkUtils.Serialize(saldo));
			Console.WriteLine("Saldo disponível: {0:F}", saldo.Disponivel);
		}

	}
}
