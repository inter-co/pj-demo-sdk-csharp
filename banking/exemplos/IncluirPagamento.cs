using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class IncluirPagamento {
		public void Exemplo(InterSdk interSdk, string linhaDigitavel, double valorPago, string dataVencimento) {
			PagamentoBoleto pagamento = PagamentoBoleto.Builder()
				.SetCodBarraLinhaDigitavel(linhaDigitavel)
				.SetValorPagar(valorPago)
				.SetDataVencimento(dataVencimento)
				.Build();
			RespostaIncluirPagamento resposta = interSdk.BankingSdk().IncluirPagamento(pagamento);
			Console.WriteLine("Pagamento efetuado, transacao=" + resposta.CodigoTransacao);
		}

	}
}
