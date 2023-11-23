using System;
using System.Collections.Generic;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class EmitirBoleto {
		public void Exemplo(InterSdk interSdk, string tipoPessoa, string cpfCnpj, string seuNumero, string dataVencimento, double valor, string nome, string endereco, string cidade, string uf, string cep) {
			Pessoa pagador = Pessoa.Builder()
				.SetCpfCnpj(cpfCnpj)
				.SetTipoPessoa(tipoPessoa)
				.SetNome(nome)
				.SetEndereco(endereco)
				.SetCidade(cidade)
				.SetUf(uf)
				.SetCep(cep)
				.Build();
			Boleto boleto = Boleto.Builder()
				.SetSeuNumero(seuNumero)
				.SetValorNominal(valor)
				.SetDataVencimento(dataVencimento)
				.SetNumDiasAgenda(0)
				.SetPagador(pagador)
				.Build();
			RespostaEmitirBoleto resposta = interSdk.CobrancaSdk().EmitirBoleto(boleto);
			Console.WriteLine("Boleto gerado com sucesso, nossoNumero=" + resposta.NossoNumero);
		}

	}
}
