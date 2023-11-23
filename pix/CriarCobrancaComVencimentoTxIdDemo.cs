using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class CriarCobrancaComVencimentoTxIdDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string cpf = Utils.GetString("cpf devedor");
			string nome = Utils.GetTextoCompleto("nome devedor");
			string cidade = Utils.GetString("cidade devedor");
			string logradouro = Utils.GetString("logradouro devedor");
			string cep = Utils.GetString("cep devedor");
			string email = Utils.GetString("email devedor");
			string uf = Utils.GetString("uf devedor");
			string valor = Utils.GetString("valor(99.99)");
			string chave = Utils.GetString("chave");
			string txId = Utils.GetString("txId");
			string dataVencimento = Utils.GetString("Data de vencimento (yyyy-MM-dd)");
			string validade = Utils.GetString("Validade (dias)");
			Devedor devedor = Devedor.Builder()
				.SetCpf(cpf)
				.SetNome(nome)
				.SetCidade(cidade)
				.SetLogradouro(logradouro)
				.SetCep(cep)
				.SetUf(uf)
				.SetEmail(email)
				.Build();
			Console.WriteLine("Aguarde...");
			new CriarCobrancaComVencimento().Exemplo(interSdk, txId, cpf, nome, valor, chave, dataVencimento, validade, devedor);
			Console.WriteLine("PUT Url: " + HttpUtils.LastUrl);
			Console.WriteLine("Requisição:");
			Console.WriteLine(HttpUtils.LastRequest);
		}

	}
}
