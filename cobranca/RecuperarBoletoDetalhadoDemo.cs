using System;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class RecuperarBoletoDetalhadoDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string nossoNumero = Utils.GetString("nossoNumero");
			Console.WriteLine("Aguarde...");
			new RecuperarBoletoDetalhado().Exemplo(interSdk, nossoNumero);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
