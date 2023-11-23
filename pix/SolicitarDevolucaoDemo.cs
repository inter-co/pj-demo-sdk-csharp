using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class SolicitarDevolucaoDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string e2eId = Utils.GetString("e2eId");
			string id = Utils.GetString("id");
			string valor = Utils.GetString("valor(99.99)");
			string descricao = Utils.GetTextoCompleto("descricao");
			string naturezaDevolucao = NaturezaDevolucao.ORIGINAL;
			Console.WriteLine("Aguarde...");
			new SolicitarDevolucao().Exemplo(interSdk, e2eId, id, valor, naturezaDevolucao, descricao);
			Console.WriteLine("PUT Url: " + HttpUtils.LastUrl);
			Console.WriteLine("Requisição:");
			Console.WriteLine(HttpUtils.LastRequest);
		}

	}
}
