using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class CriarWebhook {
		public void Exemplo(InterSdk interSdk, string webhookUrl) {
			interSdk.BankingSdk().CriarWebhook(webhookUrl);
			Console.WriteLine("webhook criado com sucesso");
		}

	}
}
