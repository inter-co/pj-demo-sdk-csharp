using System;
using System.Collections.Generic;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class RecuperarBoletoPdf {
		public void Exemplo(InterSdk interSdk, string nossoNumero, string arquivo) {
			interSdk.CobrancaSdk().RecuperarBoletoPdf(nossoNumero, arquivo);
			Console.WriteLine("Arquivo gerado: " + arquivo);
		}

	}
}
