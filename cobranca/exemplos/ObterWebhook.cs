using System;
using System.Collections.Generic;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class ObterWebhook {
		public void Exemplo(InterSdk interSdk) {
			Webhook webhook = interSdk.CobrancaSdk().ObterWebhook();
			Console.WriteLine(SdkUtils.Serialize(webhook));
		}

	}
}
