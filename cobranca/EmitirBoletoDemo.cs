using System;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class EmitirBoletoDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			Console.WriteLine("Exemplo para pessoa física!");
			string tipoPessoa = TipoPessoa.FISICA;
			string seuNumero = Utils.GetString("seuNumero");
			string dataVencimento = Utils.GetString("dataVencimento(YYYY-MM-DD)");
			double valor = Utils.GetDouble("valor(99.99)");
			Console.WriteLine("Dados do pagador:");
			string cpfCnpj = Utils.GetString("cpf");
			string nome = Utils.GetTextoCompleto("nome");
			string endereco = Utils.GetTextoCompleto("endereco");
			string cidade = Utils.GetTextoCompleto("cidade");
			string uf = Utils.GetString("uf");
			string cep = Utils.GetString("cep");
			Console.WriteLine("Aguarde...");
			new EmitirBoleto().Exemplo(interSdk, tipoPessoa, cpfCnpj, seuNumero, dataVencimento, valor, nome, endereco, cidade, uf, cep);
			Console.WriteLine("POST Url: " + HttpUtils.LastUrl);
			Console.WriteLine("Requisição:");
			Console.WriteLine(HttpUtils.LastRequest);
		}

	}
}
