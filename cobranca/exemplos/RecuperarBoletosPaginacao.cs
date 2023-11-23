using System;
using System.Collections.Generic;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class RecuperarBoletosPaginacao {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			FiltroRecuperarBoletos filtro = null;
			Ordenacao ordenacao = null;
			int pagina = 0;
			int n = 0;
			PaginaBoletos paginaBoletos;
			do {
				paginaBoletos = interSdk.CobrancaSdk().RecuperarBoletos(dataInicial, dataFinal, filtro, ordenacao, pagina);
				Console.WriteLine(SdkUtils.Serialize(paginaBoletos));
				n = n + paginaBoletos.Boletos.Count;
				Console.WriteLine(paginaBoletos.Boletos.Count + " boletos retornados na página");
				pagina = pagina + 1;
			} while (pagina < paginaBoletos.TotalPaginas);
			Console.WriteLine(n + " boletos retornados no total");
		}

	}
}
