using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarDevolucaoDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string e2eId = Utils.GetString("e2eId");
			string id = Utils.GetString("id");
			Console.WriteLine("Aguarde...");
			new ConsultarDevolucao().Exemplo(interSdk, e2eId, id);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
