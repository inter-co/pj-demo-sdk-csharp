using System;
using System.Collections.Generic;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarPix {
		public void Exemplo(InterSdk interSdk, string e2eId) {
			Pix pix = interSdk.PixSdk().ConsultarPix(e2eId);
			Console.WriteLine(SdkUtils.Serialize(pix));
			Console.WriteLine("Pix recuperado, chave=" + pix.Chave);
		}

	}
}
