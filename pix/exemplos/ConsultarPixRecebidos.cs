using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarPixRecebidos {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			FiltroConsultarPixRecebidos filtro = null;
			List<Pix> lista = interSdk.PixSdk().ConsultarPixRecebidos(dataInicial, dataFinal, filtro);
			Console.WriteLine(SdkUtils.Serialize(lista));
			Console.WriteLine(lista.Count + " pix retornados");
		}

	}
}
