using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class IncluirPixChave {
		public void Exemplo(InterSdk interSdk, string chave, double valor) {
			Destinatario destinatario = Chave.Builder()
				.SetChave(chave)
				.Build();
			Pix pix = Pix.Builder()
				.SetValor(valor)
				.SetDestinatario(destinatario)
				.Build();
			RespostaIncluirPix resposta = interSdk.BankingSdk().IncluirPix(pix);
			Console.WriteLine("Pix enviado, e2eId=" + resposta.EndToEndId);
			Console.WriteLine(SdkUtils.Serialize(resposta));
		}

	}
}
