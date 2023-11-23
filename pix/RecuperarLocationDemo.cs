using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class RecuperarLocationDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string id = Utils.GetString("id");
			Console.WriteLine("Aguarde...");
			new RecuperarLocation().Exemplo(interSdk, id);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
