using System;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class IncluirPagamentoDarfDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string cnpjCpf = Utils.GetString("cnpjCpf");
			string codigoReceita = Utils.GetString("codigoReceita");
			string dataVencimento = Utils.GetString("dataVencimento(YYYY-MM-DD)");
			string descricao = Utils.GetString("descricao");
			string nomeEmpresa = Utils.GetTextoCompleto("nomeEmpresa");
			string periodoApuracao = Utils.GetString("periodoApuracao");
			string valorPrincipal = Utils.GetString("valorPrincipal(99.99)");
			string referencia = Utils.GetString("referencia");
			Console.WriteLine("Aguarde...");
			new IncluirPagamentoDarf().Exemplo(interSdk, cnpjCpf, codigoReceita, dataVencimento, descricao, nomeEmpresa, periodoApuracao, valorPrincipal, referencia);
			Console.WriteLine("POST Url: " + HttpUtils.LastUrl);
			Console.WriteLine("Requisição:");
			Console.WriteLine(HttpUtils.LastRequest);
		}

	}
}
