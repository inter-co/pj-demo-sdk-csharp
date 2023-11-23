using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class CriarWebhook {
		public void Exemplo(InterSdk interSdk, string chave, string webhookUrl) {
			interSdk.PixSdk().CriarWebhook(webhookUrl, chave);
			Console.WriteLine("webhook criado com sucesso");
		}

	}
}
