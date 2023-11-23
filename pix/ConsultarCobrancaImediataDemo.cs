using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarCobrancaImediataDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string txId = Utils.GetString("txId");
			Console.WriteLine("Aguarde...");
			new ConsultarCobrancaImediata().Exemplo(interSdk, txId);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
