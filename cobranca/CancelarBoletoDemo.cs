using System;
using Sdk;
using Sdk.CobrancaApi;

namespace Sdk.Demo.CobrancaApi {
	public class CancelarBoletoDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string nossoNumero = Utils.GetString("nossoNumero");
			string motivoCancelamento = MotivoCancelamento.APEDIDODOCLIENTE;
			Console.WriteLine("Aguarde...");
			new CancelarBoleto().Exemplo(interSdk, nossoNumero, motivoCancelamento);
			Console.WriteLine("POST Url: " + HttpUtils.LastUrl);
			Console.WriteLine("Requisição:");
			Console.WriteLine(HttpUtils.LastRequest);
		}

	}
}
