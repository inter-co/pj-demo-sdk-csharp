using System;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class IncluirPixDadosBancariosDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string cpfCnpj = Utils.GetString("cpfCnpj");
			string nome = Utils.GetTextoCompleto("nome");
			string contaCorrente = Utils.GetString("contaCorrente");
			string agencia = Utils.GetString("agencia");
			double valor = Utils.GetDouble("valor(99.99)");
			string codigoBanco = Utils.GetString("codigoBanco");
			string nomeBanco = Utils.GetTextoCompleto("nomeBanco");
			string ispb = Utils.GetString("ispb");
			Console.WriteLine("Aguarde...");
			new IncluirPixDadosBancarios().Exemplo(interSdk, cpfCnpj, nome, contaCorrente, agencia, valor, codigoBanco, nomeBanco, ispb);
			Console.WriteLine("POST Url: " + HttpUtils.LastUrl);
			Console.WriteLine("Requisição:");
			Console.WriteLine(HttpUtils.LastRequest);
		}

	}
}
