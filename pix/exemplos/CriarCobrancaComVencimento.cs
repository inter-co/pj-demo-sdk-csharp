using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class CriarCobrancaComVencimento {
		public void Exemplo(InterSdk interSdk, string txId, string cpf, string nome, string valorOriginal, string chave, string dataVencimento, string validade, Devedor devedor) {
			int validadeAposVencimento = int.Parse(validade);
			CobVValor valor = CobVValor.Builder()
				.SetOriginal(valorOriginal)
				.Build();
			CalendarioCobV calendario = CalendarioCobV.Builder()
				.SetDataDeVencimento(dataVencimento)
				.SetValidadeAposVencimento(validadeAposVencimento)
				.Build();
			CobrancaVencimento cobranca = CobrancaVencimento.Builder()
				.SetDevedor(devedor)
				.SetValor(valor)
				.SetChave(chave)
				.SetCalendario(calendario)
				.Build();
			CobrancaVencimentoDetalhada cobrancaCriada = interSdk.PixSdk().CriarCobrancaComVencimentoTxId(txId, cobranca);
			Console.WriteLine(SdkUtils.Serialize(cobrancaCriada));
			Console.WriteLine("Cobrança criada, status=" + cobrancaCriada.Status);
		}

	}
}
