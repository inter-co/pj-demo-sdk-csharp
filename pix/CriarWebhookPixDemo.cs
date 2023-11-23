using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class CriarWebhookPixDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string chave = Utils.GetString("chave");
			string webhookUrl = Utils.GetString("webhookUrl");
			Console.WriteLine("Aguarde...");
			new CriarWebhook().Exemplo(interSdk, chave, webhookUrl);
			Console.WriteLine("PUT Url: " + HttpUtils.LastUrl);
			Console.WriteLine("Requisição:");
			Console.WriteLine(HttpUtils.LastRequest);
		}

	}
}
