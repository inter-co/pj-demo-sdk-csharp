using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class DesvincularLocationDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string id = Utils.GetString("id");
			Console.WriteLine("Aguarde...");
			new DesvincularLocation().Exemplo(interSdk, id);
			Console.WriteLine("DELETE Url: " + HttpUtils.LastUrl);
		}

	}
}
