using System;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class RecuperarExtratoPdfDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string dataInicial = Utils.GetString("dataInicial(YYYY-MM-DD)");
			string dataFinal = Utils.GetString("dataFinal(YYYY-MM-DD)");
			string arquivo = "extrato.pdf";
			Console.WriteLine("Aguarde...");
			new RecuperarExtratoPdf().Exemplo(interSdk, dataInicial, dataFinal, arquivo);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
