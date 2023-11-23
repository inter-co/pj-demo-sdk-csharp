using System;
using System.Collections.Generic;
using Sdk;
using Sdk.BankingApi;

namespace Sdk.Demo.BankingApi {
	public class CancelarAgendamento {
		public void Exemplo(InterSdk interSdk, string codigoTransacao) {
			interSdk.BankingSdk().CancelarAgendamento(codigoTransacao);
			Console.WriteLine("Cancelamento do agendamento efetuado");
		}

	}
}
