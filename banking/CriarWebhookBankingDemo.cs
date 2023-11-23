using System;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class CriarWebhookBankingDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string webhookUrl = Utils.GetString("webhookUrl");
			Console.WriteLine("Aguarde...");
			new CriarWebhook().Exemplo(interSdk, webhookUrl);
			Console.WriteLine("PUT Url: " + HttpUtils.LastUrl);
			Console.WriteLine("Requisição:");
			Console.WriteLine(HttpUtils.LastRequest);
		}

	}
}
