using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarDevolucao {
		public void Exemplo(InterSdk interSdk, string e2eId, string id) {
			DevolucaoDetalhada devolucao = interSdk.PixSdk().ConsultarDevolucao(e2eId, id);
			Console.WriteLine(SdkUtils.Serialize(devolucao));
			Console.WriteLine("Devolução recuperada, status=" + devolucao.Status);
		}

	}
}
