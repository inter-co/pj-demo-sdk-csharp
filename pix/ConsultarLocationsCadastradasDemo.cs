using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarLocationsCadastradasDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			string dataInicial = Utils.GetString("dataInicial(YYYY-MM-DDTHH:MM:SSZ ex:2022-04-01T10:30:00Z)");
			string dataFinal = Utils.GetString("dataFinal(YYYY-MM-DDTHH:MM:SSZ ex:2022-04-01T10:30:00Z)");
			string tipo = Utils.GetStringOrNull("Tipo (cob,cobv)");
			string tipoCob = null;
			tipoCob = tipo;
			Console.WriteLine("Aguarde...");
			new ConsultarLocationsCadastradas().Exemplo(interSdk, dataInicial, dataFinal, tipoCob);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
