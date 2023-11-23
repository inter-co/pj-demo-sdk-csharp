using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarCobrancaComVencimentoDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string txId = Utils.GetString("txId");
			Console.WriteLine("Aguarde...");
			new ConsultarCobrancaComVencimento().Exemplo(interSdk, txId);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
