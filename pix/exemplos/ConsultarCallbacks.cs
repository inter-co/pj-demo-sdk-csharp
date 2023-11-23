using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarCallbacks {
		public void Exemplo(InterSdk interSdk, string dataHoraInicial, string dataHoraFinal, FiltroBuscarCallbacks filtro) {
			List<Callback> callbacks = interSdk.PixSdk().ConsultarCallbacks(dataHoraInicial, dataHoraFinal, filtro);
			Console.WriteLine("Lista de callbacks recebida com sucesso");
			Console.WriteLine(SdkUtils.Serialize(callbacks));
			Console.WriteLine(callbacks.Count + " callbacks retornados");
		}

	}
}
