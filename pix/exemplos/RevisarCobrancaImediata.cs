using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class RevisarCobrancaImediata {
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
			CobrancaDetalhada cobrancaRevisada = interSdk.PixSdk().RevisarCobrancaImediata(cobranca);
			Console.WriteLine(SdkUtils.Serialize(cobrancaRevisada));
			Console.WriteLine("Cobrança revisada, status=" + cobrancaRevisada.Status);
		}

	}
}
