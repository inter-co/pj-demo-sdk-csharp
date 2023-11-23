using System;
using System.Collections.Generic;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class CriarWebhook {
		public void Exemplo(InterSdk interSdk, string webhookUrl) {
			interSdk.CobrancaSdk().CriarWebhook(webhookUrl);
			Console.WriteLine("webhook criado com sucesso");
		}

	}
}
