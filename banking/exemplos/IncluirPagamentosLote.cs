using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class IncluirPagamentosLote {
		public void Exemplo(InterSdk interSdk, string meuIdentificador, BoletoLote boleto, DarfLote darf) {
			List<ItemLote> pagamentos = new List<ItemLote>();
			pagamentos.Add(boleto);
			pagamentos.Add(darf);
			RespostaIncluirPagamentosLote resposta = interSdk.BankingSdk().IncluirPagamentosLote(meuIdentificador, pagamentos);
			Console.WriteLine(SdkUtils.Serialize(resposta));
		}

	}
}
