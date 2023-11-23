using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class IncluirPixDadosBancarios {
		public void Exemplo(InterSdk interSdk, string cpfCnpj, string nome, string contaCorrente, string agencia, double valor, string codigoBanco, string nomeBanco, string ispb) {
			InstituicaoFinanceira instituicaoFinanceira = InstituicaoFinanceira.Builder()
				.SetCodigo(codigoBanco)
				.SetNome(nomeBanco)
				.SetIspb(ispb)
				.Build();
			Destinatario destinatario = DadosBancarios.Builder()
				.SetCpfCnpj(cpfCnpj)
				.SetNome(nome)
				.SetContaCorrente(contaCorrente)
				.SetTipoConta(TipoConta.CONTA_CORRENTE)
				.SetAgencia(agencia)
				.SetInstituicaoFinanceira(instituicaoFinanceira)
				.Build();
			Pix pix = Pix.Builder()
				.SetValor(valor)
				.SetDestinatario(destinatario)
				.Build();
			RespostaIncluirPix resposta = interSdk.BankingSdk().IncluirPix(pix);
			Console.WriteLine("Pix enviado, e2eId=" + resposta.EndToEndId);
		}

	}
}
