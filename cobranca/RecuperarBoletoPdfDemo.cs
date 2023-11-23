using System;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class RecuperarBoletoPdfDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string nossoNumero = Utils.GetString("nossoNumero");
			string arquivo = "boleto.pdf";
			Console.WriteLine("Aguarde...");
			new RecuperarBoletoPdf().Exemplo(interSdk, nossoNumero, arquivo);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
