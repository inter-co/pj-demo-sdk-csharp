using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarPixDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string e2eId = Utils.GetString("e2eId");
			Console.WriteLine("Aguarde...");
			new ConsultarPix().Exemplo(interSdk, e2eId);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
