using System;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class ExcluirWebhookCobrancaDemo {
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
