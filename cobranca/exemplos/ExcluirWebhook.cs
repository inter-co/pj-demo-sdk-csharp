using System;
using System.Collections.Generic;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class ExcluirWebhook {
		public void Exemplo(InterSdk interSdk) {
			interSdk.CobrancaSdk().ExcluirWebhook();
			Console.WriteLine("webhook excluído com sucesso");
		}

	}
}
