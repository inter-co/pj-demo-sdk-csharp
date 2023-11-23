using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class CriarCobrancaImediataTxIdDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string cpf = Utils.GetString("cpf");
			string nome = Utils.GetTextoCompleto("nome");
			string valor = Utils.GetString("valor(99.99)");
			string chave = Utils.GetString("chave");
			string txId = Utils.GetString("txId");
			int expiracao = 86400;
			Console.WriteLine("Aguarde...");
			new CriarCobrancaImediata().Exemplo(interSdk, txId, cpf, nome, valor, chave, expiracao);
			Console.WriteLine("PUT Url: " + HttpUtils.LastUrl);
			Console.WriteLine("Requisição:");
			Console.WriteLine(HttpUtils.LastRequest);
		}

	}
}
