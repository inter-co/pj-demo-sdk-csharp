using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ExcluirWebhookPixDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string chave = Utils.GetString("chave");
			Console.WriteLine("Aguarde...");
			new ExcluirWebhook().Exemplo(interSdk, chave);
			Console.WriteLine("DELETE Url: " + HttpUtils.LastUrl);
		}

	}
}
