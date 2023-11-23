using System;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class IncluirPagamentosLoteDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string linhaDigitavel = Utils.GetString("linhaDigitavel");
			double valorBoleto = Utils.GetDouble("valorBoleto");
			string dataVencimentoBoleto = Utils.GetString("dataVencimentoBoleto(YYYY-MM-DD)");
			string cnpjCpf = Utils.GetString("cnpjCpf");
			string codigoReceita = Utils.GetString("codigoReceita");
			string dataVencimentoDarf = Utils.GetString("dataVencimentoDarf(YYYY-MM-DD)");
			string descricao = Utils.GetTextoCompleto("descricao");
			string nomeEmpresa = Utils.GetTextoCompleto("nomeEmpresa");
			string periodoApuracao = Utils.GetString("periodoApuracao");
			string valorDarf = Utils.GetString("valorDarf(99.99)");
			string referencia = Utils.GetString("referencia");
			string meuIdentificador = Utils.GetString("meuIdentificador");
			BoletoLote boletoLote = BoletoLote.Builder()
				.SetCodBarraLinhaDigitavel(linhaDigitavel)
				.SetValorPagar(valorBoleto)
				.SetDataVencimento(dataVencimentoBoleto)
				.Build();
			DarfLote darfLote = DarfLote.Builder()
				.SetCnpjCpf(cnpjCpf)
				.SetCodigoReceita(codigoReceita)
				.SetDataVencimento(dataVencimentoDarf)
				.SetDescricao(descricao)
				.SetNomeEmpresa(nomeEmpresa)
				.SetPeriodoApuracao(periodoApuracao)
				.SetValorPrincipal(valorDarf)
				.SetReferencia(referencia)
				.Build();
			Console.WriteLine("Aguarde...");
			new IncluirPagamentosLote().Exemplo(interSdk, meuIdentificador, boletoLote, darfLote);
			Console.WriteLine("POST Url: " + HttpUtils.LastUrl);
			Console.WriteLine("Requisição:");
			Console.WriteLine(HttpUtils.LastRequest);
		}

	}
}
