using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class CriarCobrancaImediata {
		public void Exemplo(InterSdk interSdk, string txId, string cpf, string nome, string valorOriginal, string chave, int expiracao) {
			Devedor devedor = Devedor.Builder()
				.SetCpf(cpf)
				.SetNome(nome)
				.Build();
			Valor valor = Valor.Builder()
				.SetOriginal(valorOriginal)
				.Build();
			Calendario calendario = Calendario.Builder()
				.SetExpiracao(expiracao)
				.Build();
			Cobranca cobranca = Cobranca.Builder()
				.SetTxid(txId)
				.SetDevedor(devedor)
				.SetValor(valor)
				.SetChave(chave)
				.SetCalendario(calendario)
				.Build();
			CobrancaDetalhada cobrancaCriada = interSdk.PixSdk().CriarCobrancaImediata(cobranca);
			Console.WriteLine(SdkUtils.Serialize(cobrancaCriada));
			Console.WriteLine("Cobrança criada, status=" + cobrancaCriada.Status);
		}

	}
}
