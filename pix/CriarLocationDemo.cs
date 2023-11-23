using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class CriarLocationDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string tipo = Utils.GetString("Tipo (cob, cobv)");
			string tipoCob = tipo;
			Console.WriteLine("Aguarde...");
			new CriarLocation().Exemplo(interSdk, tipoCob);
			Console.WriteLine("POST Url: " + HttpUtils.LastUrl);
			Console.WriteLine("Requisição:");
			Console.WriteLine(HttpUtils.LastRequest);
		}

	}
}
