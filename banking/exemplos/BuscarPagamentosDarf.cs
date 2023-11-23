using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class BuscarPagamentosDarf {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			FiltroBuscarPagamentosDarf filtro = new FiltroBuscarPagamentosDarf();
			List<RetornoPagamentoDarf> pagamentos = interSdk.BankingSdk().BuscarPagamentosDarf(dataInicial, dataFinal, filtro);
			Console.WriteLine(SdkUtils.Serialize(pagamentos));
			Console.WriteLine(pagamentos.Count + " pagamentos de DARF retornados");
		}

	}
}
