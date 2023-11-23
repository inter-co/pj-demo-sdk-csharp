using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class BuscarPagamentos {
		public void Exemplo(InterSdk interSdk, string dataInicial, string dataFinal) {
			FiltroBuscarPagamentos filtro = null;
			List<Pagamento> pagamentos = interSdk.BankingSdk().BuscarPagamentos(dataInicial, dataFinal, filtro);
			Console.WriteLine(SdkUtils.Serialize(pagamentos));
			Console.WriteLine(pagamentos.Count + " pagamentos retornados");
		}

	}
}
