using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class DesvincularLocation {
		public void Exemplo(InterSdk interSdk, string id) {
			Location location = interSdk.PixSdk().DesvincularLocation(id);
			Console.WriteLine(SdkUtils.Serialize(location));
			Console.WriteLine("Location desvinculada " + location._Location);
		}

	}
}
