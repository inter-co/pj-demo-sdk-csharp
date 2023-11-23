using System;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class CancelarAgendamentoDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string codigoTransacao = Utils.GetString("codigoTransacao");
			Console.WriteLine("Aguarde...");
			new CancelarAgendamento().Exemplo(interSdk, codigoTransacao);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
