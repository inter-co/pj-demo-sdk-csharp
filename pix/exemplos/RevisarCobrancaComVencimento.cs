using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class RevisarCobrancaComVencimento {
		public void Exemplo(InterSdk interSdk, string txId, string cpf, string nome, string valorOriginal, string chave, string dataVencimento, string validade, Devedor devedor) {
			int x = int.Parse(validade);
			CobVValor valor = CobVValor.Builder()
				.SetOriginal(valorOriginal)
				.Build();
			CalendarioCobV calendario = CalendarioCobV.Builder()
				.SetDataDeVencimento(dataVencimento)
				.SetValidadeAposVencimento(x)
				.Build();
			CobrancaVencimento cobranca = CobrancaVencimento.Builder()
				.SetDevedor(devedor)
				.SetValor(valor)
				.SetChave(chave)
				.SetCalendario(calendario)
				.Build();
			CobrancaVencimentoDetalhada cobrancaRevisada = interSdk.PixSdk().RevisarCobrancaComVencimento(txId, cobranca);
			Console.WriteLine(SdkUtils.Serialize(cobrancaRevisada));
			Console.WriteLine("Cobrança revisada, status=" + cobrancaRevisada.Status);
		}

	}
}
