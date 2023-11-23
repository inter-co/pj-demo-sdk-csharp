using System;
using Sdk;
using Sdk.Demo.BankingApi;

public static class MenuBanking {
	const int CONSULTAR_EXTRATO = 1;
	const int CONSULTAR_EXTRATO_PDF = 2;
	const int CONSULTAR_EXTRATO_ENRIQUECIDO = 3;
	const int CONSULTAR_EXTRATO_ENRIQUECIDO_PAGINACAO = 4;
	const int CONSULTAR_SALDO = 5;
	const int INCLUIR_PAGAMENTO = 6;
	const int BUSCAR_PAGAMENTOS = 7;
	const int INCLUIR_PAGAMENTO_DARF = 8;
	const int BUSCAR_PAGAMENTOS_DARF = 9;
	const int INCLUIR_PAGAMENTOS_LOTE = 10;
	const int BUSCAR_LOTE_PAGAMENTOS = 11;
	const int CANCELAR_AGENDAMENTO = 12;
	const int INCLUIR_PIX_CHAVE = 13;
	const int INCLUIR_PIX_DADOS_BANCARIOS = 14;
	const int CRIAR_WEBHOOK_BANKING = 15;
	const int OBTER_WEBHOOK_BANKING = 16;
	const int EXCLUIR_WEBHOOK_BANKING = 17;
	const int CALLBACKS_CONSULTAR = 18;
	public static int ShowMenu(string ambiente) {
		Console.WriteLine("AMBIENTE " + ambiente);
		Console.WriteLine(CONSULTAR_EXTRATO + " - Consultar Extrato");
		Console.WriteLine(CONSULTAR_EXTRATO_PDF + " - Recuperar Extrato PDF");
		Console.WriteLine(CONSULTAR_EXTRATO_ENRIQUECIDO + " - Consultar Extrato Enriquecido");
		Console.WriteLine(CONSULTAR_EXTRATO_ENRIQUECIDO_PAGINACAO + " - Consultar Extrato Enriquecido com paginação");
		Console.WriteLine(CONSULTAR_SALDO + " - Consultar Saldo");
		Console.WriteLine(INCLUIR_PAGAMENTO + " - Incluir Pagamento");
		Console.WriteLine(BUSCAR_PAGAMENTOS + " - Buscar Pagamentos");
		Console.WriteLine(INCLUIR_PAGAMENTO_DARF + " - Incluir Pagamento de DARF");
		Console.WriteLine(BUSCAR_PAGAMENTOS_DARF + " - Buscar Pagamentos de DARF");
		Console.WriteLine(INCLUIR_PAGAMENTOS_LOTE + " - Incluir Pagamentos em Lote");
		Console.WriteLine(BUSCAR_LOTE_PAGAMENTOS + " - Buscar Lote Pagamentos");
		Console.WriteLine(CANCELAR_AGENDAMENTO + " - Cancelar agendamento de pagamento");
		Console.WriteLine(INCLUIR_PIX_CHAVE + " - Incluir Pix Chave");
		Console.WriteLine(INCLUIR_PIX_DADOS_BANCARIOS + " - Incluir Pix Dados Bancários");
		Console.WriteLine(CRIAR_WEBHOOK_BANKING + " - Criar Webhook");
		Console.WriteLine(OBTER_WEBHOOK_BANKING + " - Obter Webhook");
		Console.WriteLine(EXCLUIR_WEBHOOK_BANKING + " - Excluir Webhook");
		Console.WriteLine(CALLBACKS_CONSULTAR + " - Consultar callbacks");
		Console.WriteLine("0 - Sair");
		Console.Write("=> ");
		return Utils.GetInt("");
	}

	public static void Execute(int op, InterSdk interSdk) {
		switch (op) {
			case CONSULTAR_EXTRATO:
				new ConsultarExtratoDemo().Execute(interSdk);
				break;
			case CONSULTAR_EXTRATO_PDF:
				new RecuperarExtratoPdfDemo().Execute(interSdk);
				break;
			case CONSULTAR_EXTRATO_ENRIQUECIDO:
				new ConsultarExtratoEnriquecidoDemo().Execute(interSdk);
				break;
			case CONSULTAR_EXTRATO_ENRIQUECIDO_PAGINACAO:
				new ConsultarExtratoEnriquecidoPaginadoDemo().Execute(interSdk);
				break;
			case CONSULTAR_SALDO:
				new ConsultarSaldoDemo().Execute(interSdk);
				break;
			case INCLUIR_PAGAMENTO:
				new IncluirPagamentoDemo().Execute(interSdk);
				break;
			case BUSCAR_PAGAMENTOS:
				new BuscarPagamentosDemo().Execute(interSdk);
				break;
			case INCLUIR_PAGAMENTO_DARF:
				new IncluirPagamentoDarfDemo().Execute(interSdk);
				break;
			case BUSCAR_PAGAMENTOS_DARF:
				new BuscarPagamentosDarfDemo().Execute(interSdk);
				break;
			case INCLUIR_PAGAMENTOS_LOTE:
				new IncluirPagamentosLoteDemo().Execute(interSdk);
				break;
			case BUSCAR_LOTE_PAGAMENTOS:
				new BuscarLotePagamentosDemo().Execute(interSdk);
				break;
			case INCLUIR_PIX_CHAVE:
				new IncluirPixChaveDemo().Execute(interSdk);
				break;
			case INCLUIR_PIX_DADOS_BANCARIOS:
				new IncluirPixDadosBancariosDemo().Execute(interSdk);
				break;
			case CRIAR_WEBHOOK_BANKING:
				new CriarWebhookBankingDemo().Execute(interSdk);
				break;
			case OBTER_WEBHOOK_BANKING:
				new ObterWebhookBankingDemo().Execute(interSdk);
				break;
			case EXCLUIR_WEBHOOK_BANKING:
				new ExcluirWebhookBankingDemo().Execute(interSdk);
				break;
			case CANCELAR_AGENDAMENTO:
				new CancelarAgendamentoDemo().Execute(interSdk);
				break;
			case CALLBACKS_CONSULTAR:
				new ConsultarCallbacksDemo().Execute(interSdk);
				break;
		}
		Console.WriteLine();
	}

}
