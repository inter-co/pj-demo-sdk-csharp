using System;
using Sdk;
using Sdk.Demo.CobrancaApi;

public static class MenuCobranca {
	const int EMITIR_BOLETO = 1;
	const int RECUPERAR_BOLETOS = 2;
	const int RECUPERAR_BOLETOS_PAGINACAO = 3;
	const int RECUPERAR_SUMARIO_BOLETOS = 4;
	const int RECUPERAR_BOLETO_DETALHADO = 5;
	const int RECUPERAR_BOLETO_PDF = 6;
	const int CANCELAR_BOLETO = 7;
	const int CRIAR_WEBHOOK_COBRANCA = 8;
	const int OBTER_WEBHOOK_COBRANCA = 9;
	const int EXCLUIR_WEBHOOK_COBRANCA = 10;
	const int CALLBACKS_CONSULTAR = 11;
	public static int ShowMenu(string ambiente) {
		Console.WriteLine("AMBIENTE " + ambiente);
		Console.WriteLine(EMITIR_BOLETO + " - Emitir Boleto");
		Console.WriteLine(RECUPERAR_BOLETOS + " - Recuperar Boletos");
		Console.WriteLine(RECUPERAR_BOLETOS_PAGINACAO + " - Recuperar Boletos com paginação");
		Console.WriteLine(RECUPERAR_SUMARIO_BOLETOS + " - Recuperar Sumário Boletos");
		Console.WriteLine(RECUPERAR_BOLETO_DETALHADO + " - Recuperar Boleto Detalhado");
		Console.WriteLine(RECUPERAR_BOLETO_PDF + " - Recuperar Boleto PDF");
		Console.WriteLine(CANCELAR_BOLETO + " - Cancelar Boleto");
		Console.WriteLine(CRIAR_WEBHOOK_COBRANCA + " - Criar Webhook");
		Console.WriteLine(OBTER_WEBHOOK_COBRANCA + " - Obter Webhook");
		Console.WriteLine(EXCLUIR_WEBHOOK_COBRANCA + " - Excluir Webhook");
		Console.WriteLine(CALLBACKS_CONSULTAR + " - Consultar callbacks");
		Console.WriteLine("0 - Sair");
		Console.Write("=> ");
		return Utils.GetInt("");
	}

	public static void Execute(int op, InterSdk interSdk) {
		switch (op) {
			case EMITIR_BOLETO:
				new EmitirBoletoDemo().Execute(interSdk);
				break;
			case RECUPERAR_BOLETOS:
				new RecuperarBoletosDemo().Execute(interSdk);
				break;
			case RECUPERAR_BOLETOS_PAGINACAO:
				new RecuperarBoletosPaginadoDemo().Execute(interSdk);
				break;
			case RECUPERAR_SUMARIO_BOLETOS:
				new RecuperarSumarioBoletosDemo().Execute(interSdk);
				break;
			case RECUPERAR_BOLETO_DETALHADO:
				new RecuperarBoletoDetalhadoDemo().Execute(interSdk);
				break;
			case RECUPERAR_BOLETO_PDF:
				new RecuperarBoletoPdfDemo().Execute(interSdk);
				break;
			case CANCELAR_BOLETO:
				new CancelarBoletoDemo().Execute(interSdk);
				break;
			case CRIAR_WEBHOOK_COBRANCA:
				new CriarWebhookCobrancaDemo().Execute(interSdk);
				break;
			case OBTER_WEBHOOK_COBRANCA:
				new ObterWebhookCobrancaDemo().Execute(interSdk);
				break;
			case EXCLUIR_WEBHOOK_COBRANCA:
				new ExcluirWebhookCobrancaDemo().Execute(interSdk);
				break;
			case CALLBACKS_CONSULTAR:
				new ConsultarCallbacksDemo().Execute(interSdk);
				break;
		}
		Console.WriteLine();
	}

}
