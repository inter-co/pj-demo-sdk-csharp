using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarLocationsCadastradas {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal, string tipoCob) {
			FiltroConsultarLocations filtro = FiltroConsultarLocations.Builder()
				.SetTipoCob(tipoCob)
				.Build();
			List<Location> lista = interSdk.PixSdk().ConsultarLocationsCadastradas(dataInicial, dataFinal, filtro);
			Console.WriteLine(SdkUtils.Serialize(lista));
			Console.WriteLine(lista.Count + " locations retornadas");
		}

	}
}
