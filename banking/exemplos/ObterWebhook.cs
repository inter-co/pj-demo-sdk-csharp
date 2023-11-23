using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class ObterWebhook {
		public void Exemplo(InterSdk interSdk) {
			Webhook webhook = interSdk.BankingSdk().ObterWebhook();
			Console.WriteLine(SdkUtils.Serialize(webhook));
		}

	}
}
