using System;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class RecuperarBoletosDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string dataInicial = Utils.GetString("dataInicial(YYYY-MM-DD)");
			string dataFinal = Utils.GetString("dataFinal(YYYY-MM-DD)");
			Console.WriteLine("Aguarde...");
			new RecuperarBoletos().Exemplo(interSdk, dataInicial, dataFinal);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
