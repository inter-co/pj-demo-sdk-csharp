using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class RecuperarLocation {
		public void Exemplo(InterSdk interSdk, string id) {
			Location location = interSdk.PixSdk().RecuperarLocation(id);
			Console.WriteLine(SdkUtils.Serialize(location));
			Console.WriteLine("Location recuperada " + location._Location);
		}

	}
}
