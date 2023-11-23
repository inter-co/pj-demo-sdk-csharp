using System;
using System.Collections.Generic;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class ConsultarCallbacks {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal, FiltroBuscarCallbacks filtro) {
			List<Callback> callbacks = interSdk.CobrancaSdk().ConsultarCallbacks(dataInicial, dataFinal, filtro);
			Console.WriteLine("Lista de callbacks recebida com sucesso");
			Console.WriteLine(SdkUtils.Serialize(callbacks));
			Console.WriteLine(callbacks.Count + " callbacks retornados");
		}

	}
}
