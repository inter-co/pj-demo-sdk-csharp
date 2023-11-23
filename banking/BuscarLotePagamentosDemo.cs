using System;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class BuscarLotePagamentosDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string idLote = Utils.GetString("idLote");
			Console.WriteLine("Aguarde...");
			new BuscarLotePagamentos().Exemplo(interSdk, idLote);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
