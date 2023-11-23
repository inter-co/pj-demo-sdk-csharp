using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class IncluirPagamentoDarf {
		public void Exemplo(InterSdk interSdk, string cnpjCpf, string codigoReceita, string dataVencimento, string descricao, string nomeEmpresa, string periodoApuracao, string valorPrincipal, string referencia) {
			PagamentoDarf pagamento = PagamentoDarf.Builder()
				.SetCnpjCpf(cnpjCpf)
				.SetCodigoReceita(codigoReceita)
				.SetDataVencimento(dataVencimento)
				.SetDescricao(descricao)
				.SetNomeEmpresa(nomeEmpresa)
				.SetPeriodoApuracao(periodoApuracao)
				.SetValorPrincipal(valorPrincipal)
				.SetReferencia(referencia)
				.Build();
			RespostaIncluirPagamentoDarf resposta = interSdk.BankingSdk().IncluirPagamentoDarf(pagamento);
			Console.WriteLine("Pagamento DARF efetuado, transacao=" + resposta.CodigoTransacao);
		}

	}
}
