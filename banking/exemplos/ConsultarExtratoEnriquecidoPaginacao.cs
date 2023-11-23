using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class ConsultarExtratoEnriquecidoPaginacao {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			FiltroConsultarExtratoEnriquecido filtro = null;
			int pagina = 0;
			int n = 0;
			ExtratoEnriquecido extrato;
			do {
				extrato = interSdk.BankingSdk().ConsultarExtratoEnriquecido(dataInicial, dataFinal, filtro, pagina);
				Console.WriteLine(SdkUtils.Serialize(extrato));
				n = n + extrato.Transacoes.Count;
				Console.WriteLine(extrato.Transacoes.Count + " transações retornadas na página");
				pagina = pagina + 1;
			} while (pagina < extrato.TotalPaginas);
			Console.WriteLine(n + " transações retornadas no total");
		}

	}
}
