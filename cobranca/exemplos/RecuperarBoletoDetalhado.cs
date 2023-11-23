using System;
using System.Collections.Generic;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class RecuperarBoletoDetalhado {
		public void Exemplo(InterSdk interSdk, string nossoNumero) {
			BoletoDetalhado boleto = interSdk.CobrancaSdk().RecuperarBoletoDetalhado(nossoNumero);
			Console.WriteLine(SdkUtils.Serialize(boleto));
		}

	}
}
