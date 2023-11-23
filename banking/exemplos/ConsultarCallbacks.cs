using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class ConsultarCallbacks {
		public void Exemplo(InterSdk interSdk, string tipo, string dataInicial, string dataFinal, FiltroBuscarCallbacks filtro) {
			List<Callback> callbacks = interSdk.BankingSdk().ConsultarCallbacks(tipo, dataInicial, dataFinal, filtro);
			Console.WriteLine("Lista de callbacks recebida com sucesso");
			Console.WriteLine(SdkUtils.Serialize(callbacks));
			Console.WriteLine(callbacks.Count + " callbacks retornados");
		}

	}
}
