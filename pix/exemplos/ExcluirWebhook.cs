using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ExcluirWebhook {
		public void Exemplo(InterSdk interSdk, string chave) {
			interSdk.PixSdk().ExcluirWebhook(chave);
			Console.WriteLine("webhook excluído com sucesso");
		}

	}
}
