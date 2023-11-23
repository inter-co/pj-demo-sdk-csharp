using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class CriarLocation {
		public void Exemplo(InterSdk interSdk, string tipoCob) {
			Location location = interSdk.PixSdk().CriarLocation(tipoCob);
			Console.WriteLine(SdkUtils.Serialize(location));
			Console.WriteLine("Location criada: " + location._Location);
		}

	}
}
