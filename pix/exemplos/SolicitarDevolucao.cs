using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class SolicitarDevolucao {
		public void Exemplo(InterSdk interSdk, string e2eId, string id, string valor, string natureza, string descricao) {
			Devolucao devolucao = Devolucao.Builder()
				.SetValor(valor)
				.SetNatureza(natureza)
				.SetDescricao(descricao)
				.Build();
			DevolucaoDetalhada devolucaoDetalhada = interSdk.PixSdk().SolicitarDevolucao(e2eId, id, devolucao);
			Console.WriteLine("Devolução efetuata, status=" + devolucaoDetalhada.Status);
		}

	}
}
