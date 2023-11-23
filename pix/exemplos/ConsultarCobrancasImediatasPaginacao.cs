using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarCobrancasImediatasPaginacao {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			FiltroConsultarCobrancasImediatas filtro = null;
			int pagina = 0;
			int n = 0;
			PaginaCobrancas paginaCobrancas;
			do {
				paginaCobrancas = interSdk.PixSdk().ConsultarCobrancasImediatas(dataInicial, dataFinal, filtro, pagina);
				Console.WriteLine(SdkUtils.Serialize(paginaCobrancas));
				n = n + paginaCobrancas.Cobrancas.Count;
				Console.WriteLine(paginaCobrancas.Cobrancas.Count + " cobranças retornadas na página");
				pagina = pagina + 1;
			} while (pagina < paginaCobrancas.Parametros.Paginacao.QuantidadeDePaginas);
			Console.WriteLine(n + " cobranças retornadoas no total");
		}

	}
}
