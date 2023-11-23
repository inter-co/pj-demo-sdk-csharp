using System;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class ObterWebhookCobrancaDemo {
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
