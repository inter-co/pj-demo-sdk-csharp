using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarCobrancaImediata {
		public void Exemplo(InterSdk interSdk, string txId) {
			CobrancaDetalhada cobranca = interSdk.PixSdk().ConsultarCobrancaImediata(txId);
			Console.WriteLine(SdkUtils.Serialize(cobranca));
			Console.WriteLine("Cobrança recuperada: " + cobranca.Status);
		}

	}
}
