using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ObterWebhook {
		public void Exemplo(InterSdk interSdk, string chave) {
			Webhook webhook = interSdk.PixSdk().ObterWebhook(chave);
			Console.WriteLine(SdkUtils.Serialize(webhook));
		}

	}
}
