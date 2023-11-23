using System;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class ExcluirWebhookBankingDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			Console.WriteLine("Aguarde...");
			new ExcluirWebhook().Exemplo(interSdk);
			Console.WriteLine("DELETE Url: " + HttpUtils.LastUrl);
		}

	}
}
