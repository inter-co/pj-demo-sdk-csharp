using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarPixRecebidosPaginacao {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			FiltroConsultarPixRecebidos filtro = null;
			int pagina = 0;
			int n = 0;
			PaginaPix paginaPix;
			do {
				paginaPix = interSdk.PixSdk().ConsultarPixRecebidos(dataInicial, dataFinal, filtro, pagina);
				Console.WriteLine(SdkUtils.Serialize(paginaPix));
				n = n + paginaPix.ListaPix.Count;
				Console.WriteLine(paginaPix.ListaPix.Count + " pix retornados na página");
				pagina = pagina + 1;
			} while (pagina < paginaPix.Parametros.Paginacao.QuantidadeDePaginas);
			Console.WriteLine(n + " pix retornados no total");
		}

	}
}
