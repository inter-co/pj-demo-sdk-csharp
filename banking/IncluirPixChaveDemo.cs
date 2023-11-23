using System;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class IncluirPixChaveDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string chave = Utils.GetString("chave");
			double valor = Utils.GetDouble("valor(99.99)");
			Console.WriteLine("Aguarde...");
			new IncluirPixChave().Exemplo(interSdk, chave, valor);
			Console.WriteLine("POST Url: " + HttpUtils.LastUrl);
			Console.WriteLine("Requisição:");
			Console.WriteLine(HttpUtils.LastRequest);
		}

	}
}
