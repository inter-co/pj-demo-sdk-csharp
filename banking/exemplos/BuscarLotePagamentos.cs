using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class BuscarLotePagamentos {
		public void Exemplo(InterSdk interSdk, string idLote) {
			ProcessamentoLote resposta = interSdk.BankingSdk().BuscarLotePagamentos(idLote);
			Console.WriteLine(SdkUtils.Serialize(resposta));
			Console.WriteLine(resposta.Pagamentos.Count + " pagamentos retornados");
		}

	}
}
