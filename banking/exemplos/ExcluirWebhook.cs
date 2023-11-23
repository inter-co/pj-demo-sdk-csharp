using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class ExcluirWebhook {
		public void Exemplo(InterSdk interSdk) {
			interSdk.BankingSdk().ExcluirWebhook();
			Console.WriteLine("webhook excluído com sucesso");
		}

	}
}
