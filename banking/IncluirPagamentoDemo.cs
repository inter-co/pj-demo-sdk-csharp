using System;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class IncluirPagamentoDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string linhaDigitavel = Utils.GetString("linhaDigitavel");
			double valor = Utils.GetDouble("valor(99.99)");
			string dataVencimento = Utils.GetString("dataVencimento(YYYY-MM-DD)");
			Console.WriteLine("Aguarde...");
			new IncluirPagamento().Exemplo(interSdk, linhaDigitavel, valor, dataVencimento);
			Console.WriteLine("POST Url: " + HttpUtils.LastUrl);
			Console.WriteLine("Requisição:");
			Console.WriteLine(HttpUtils.LastRequest);
		}

	}
}
