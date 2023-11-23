using System;
using System.Collections.Generic;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class CancelarBoleto {
		public void Exemplo(InterSdk interSdk, string nossoNumero, string motivoCancelamento) {
			interSdk.CobrancaSdk().CancelarBoleto(nossoNumero, motivoCancelamento);
			Console.WriteLine("boleto cancelado com sucesso: " + nossoNumero);
		}

	}
}
