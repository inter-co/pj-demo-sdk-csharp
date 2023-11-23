using System;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class ObterWebhookBankingDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			Console.WriteLine("Aguarde...");
			new ObterWebhook().Exemplo(interSdk);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
