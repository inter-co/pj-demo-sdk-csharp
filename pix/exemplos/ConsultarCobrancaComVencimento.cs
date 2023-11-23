using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarCobrancaComVencimento {
		public void Exemplo(InterSdk interSdk, string txId) {
			CobrancaVencimentoDetalhada cobranca = interSdk.PixSdk().ConsultarCobrancaComVencimento(txId);
			Console.WriteLine(SdkUtils.Serialize(cobranca));
			Console.WriteLine("Cobrança recuperada: " + cobranca.Status);
		}

	}
}
