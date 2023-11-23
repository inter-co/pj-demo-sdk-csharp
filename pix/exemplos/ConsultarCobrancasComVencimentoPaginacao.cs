using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarCobrancasComVencimentoPaginacao {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			FiltroConsultarCobrancasComVencimento filtro = null;
			int pagina = 0;
			int n = 0;
			PaginaCobrancasVencimento paginaCobrancas;
			do {
				paginaCobrancas = interSdk.PixSdk().ConsultarCobrancasComVencimento(dataInicial, dataFinal, filtro, pagina);
				Console.WriteLine(SdkUtils.Serialize(paginaCobrancas));
				n = n + paginaCobrancas.Cobrancas.Count;
				Console.WriteLine(paginaCobrancas.Cobrancas.Count + " cobranças retornadas na página");
				pagina = pagina + 1;
			} while (pagina < paginaCobrancas.Parametros.Paginacao.QuantidadeDePaginas);
			Console.WriteLine(n + " cobranças retornadoas no total");
		}

	}
}
