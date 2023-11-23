using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class ConsultarExtratoEnriquecido {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			FiltroConsultarExtratoEnriquecido filtro = null;
			List<TransacaoEnriquecida> transacoes = interSdk.BankingSdk().ConsultarExtratoEnriquecido(dataInicial, dataFinal, filtro);
			Console.WriteLine(SdkUtils.Serialize(transacoes));
			Console.WriteLine(transacoes.Count + " transações retornadas");
		}

	}
}
