using System;
using Sdk;
using Sdk.PixApi;

namespace Sdk.Demo.PixApi {
	public class ConsultarCallbacksDemo {
		public void Execute(InterSdk interSdk) {
			interSdk.SetDebug(true);
			foreach (string item in interSdk.ListaAvisos()) {
				Console.WriteLine(item);
			}
			FiltroBuscarCallbacks filtro = null;
			string dataHoraInicial = Utils.GetString("dataHoraInicial(YYYY-MM-DDTHH:MM:SSZ ex:2022-04-01T10:30:00Z)");
			string dataHoraFinal = Utils.GetString("dataHoraFinal(YYYY-MM-DDTHH:MM:SSZ ex:2022-04-01T10:30:00Z)");
			Console.WriteLine("Aguarde...");
			new ConsultarCallbacks().Exemplo(interSdk, dataHoraInicial, dataHoraFinal, filtro);
			Console.WriteLine("GET Url: " + HttpUtils.LastUrl);
		}

	}
}
