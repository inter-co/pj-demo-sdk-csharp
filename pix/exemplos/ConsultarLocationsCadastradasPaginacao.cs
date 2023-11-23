using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarLocationsCadastradasPaginacao {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal, string tipoCob) {
			FiltroConsultarLocations filtro = FiltroConsultarLocations.Builder()
				.SetTipoCob(tipoCob)
				.Build();
			int pagina = 0;
			int n = 0;
			PaginaLocations paginaLocations;
			do {
				paginaLocations = interSdk.PixSdk().ConsultarLocationsCadastradas(dataInicial, dataFinal, filtro, pagina);
				Console.WriteLine(SdkUtils.Serialize(paginaLocations));
				n = n + paginaLocations.Locs.Count;
				Console.WriteLine(paginaLocations.Locs.Count + " locations retornadas na página");
				pagina = pagina + 1;
			} while (pagina < paginaLocations.Parametros.Paginacao.QuantidadeDePaginas);
			Console.WriteLine(n + " locations retornados no total");
		}

	}
}
