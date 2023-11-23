using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ObterWebhookPixDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string chave = Utils.GetString("chave");
			Console.WriteLine("Aguarde...");
			new ObterWebhook().Exemplo(interSdk, chave);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
