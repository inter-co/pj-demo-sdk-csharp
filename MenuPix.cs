using System;
using Sdk;
using Sdk.Demo.PixApi;

public static class MenuPix {
	const int COBRANCA_IMEDIATA_CRIAR = 1;
	const int COBRANCA_IMEDIATA_CRIAR_TXID = 2;
	const int COBRANCA_IMEDIATA_REVISAR = 3;
	const int COBRANCA_IMEDIATA_CONSULTAR = 4;
	const int COBRANCAS_IMEDIATAS_CONSULTAR = 5;
	const int COBRANCAS_IMEDIATAS_CONSULTAR_PAGINACAO = 6;
	const int COBRANCA_COM_VENCIMENTO_CRIAR_TXID = 7;
	const int COBRANCA_COM_VENCIMENTO_REVISAR = 8;
	const int COBRANCA_COM_VENCIMENTO_CONSULTAR = 9;
	const int COBRANCAS_COM_VENCIMENTO_CONSULTAR = 10;
	const int COBRANCAS_COM_VENCIMENTO_CONSULTAR_PAGINACAO = 11;
	const int LOCATION_CRIAR = 12;
	const int LOCATION_RECUPERAR = 13;
	const int LOCATION_DESVINCULAR = 14;
	const int LOCATIONS_CADASTRADAS_CONSULTAR = 15;
	const int LOCATIONS_CADASTRADAS_CONSULTAR_PAGINACAO = 16;
	const int PIX_CONSULTAR = 17;
	const int PIX_RECEBIDOS_CONSULTAR = 18;
	const int PIX_RECEBIDOS_CONSULTAR_PAGINACAO = 19;
	const int PIX_DEVOLUCAO_SOLICITAR = 20;
	const int PIX_DEVOLUCAO_CONSULTAR = 21;
	const int WEBHOOK_CRIAR = 22;
	const int WEBHOOK_OBTER = 23;
	const int WEBHOOK_EXCLUIR = 24;
	const int CALLBACKS_CONSULTAR = 25;
	public static int ShowMenu(string ambiente) {
		Console.WriteLine("AMBIENTE " + ambiente);
		Console.WriteLine(COBRANCA_IMEDIATA_CRIAR + " - Criar Cobrança Imediata");
		Console.WriteLine(COBRANCA_IMEDIATA_CRIAR_TXID + " - Criar Cobrança Imediata TxId");
		Console.WriteLine(COBRANCA_IMEDIATA_REVISAR + " - Revisar Cobrança Imediata");
		Console.WriteLine(COBRANCA_IMEDIATA_CONSULTAR + " - Consultar Cobrança Imediata por TxId");
		Console.WriteLine(COBRANCAS_IMEDIATAS_CONSULTAR + " - Consultar Cobranças Imediatas");
		Console.WriteLine(COBRANCAS_IMEDIATAS_CONSULTAR_PAGINACAO + " - Consultar Cobranças Imediatas com paginação");
		Console.WriteLine(COBRANCA_COM_VENCIMENTO_CRIAR_TXID + " - Criar Cobrança com vencimento com txId");
		Console.WriteLine(COBRANCA_COM_VENCIMENTO_REVISAR + " - Revisar Cobrança com vencimento");
		Console.WriteLine(COBRANCA_COM_VENCIMENTO_CONSULTAR + " - Consultar Cobrança com vencimento por TxId");
		Console.WriteLine(COBRANCAS_COM_VENCIMENTO_CONSULTAR + " - Consultar Cobranças com vencimento");
		Console.WriteLine(COBRANCAS_COM_VENCIMENTO_CONSULTAR_PAGINACAO + " - Consultar Cobranças com vencimento com paginação");
		Console.WriteLine(LOCATION_CRIAR + " - Criar Location");
		Console.WriteLine(LOCATION_RECUPERAR + " - Recuperar Location");
		Console.WriteLine(LOCATION_DESVINCULAR + " - Desvincular Location");
		Console.WriteLine(LOCATIONS_CADASTRADAS_CONSULTAR + " - Consultar Locations Cadastradas");
		Console.WriteLine(LOCATIONS_CADASTRADAS_CONSULTAR_PAGINACAO + " - Consultar Locations Cadastradas com paginação");
		Console.WriteLine(PIX_CONSULTAR + " - Consultar Pix");
		Console.WriteLine(PIX_RECEBIDOS_CONSULTAR + " - Consultar Pix Recebidos");
		Console.WriteLine(PIX_RECEBIDOS_CONSULTAR_PAGINACAO + " - Consultar Pix Recebidos com paginação");
		Console.WriteLine(PIX_DEVOLUCAO_SOLICITAR + " - Solicitar Devolução");
		Console.WriteLine(PIX_DEVOLUCAO_CONSULTAR + " - Consultar Devolução");
		Console.WriteLine(WEBHOOK_CRIAR + " - Criar Webhook");
		Console.WriteLine(WEBHOOK_OBTER + " - Obter Webhook");
		Console.WriteLine(WEBHOOK_EXCLUIR + " - Excluir Webhook");
		Console.WriteLine(CALLBACKS_CONSULTAR + " - Consultar callbacks");
		Console.WriteLine("0 - Sair");
		Console.Write("=> ");
		return Utils.GetInt("");
	}

	public static void Execute(int op, InterSdk interSdk) {
		switch (op) {
			case COBRANCA_IMEDIATA_CRIAR:
				new CriarCobrancaImediataDemo().Execute(interSdk);
				break;
			case COBRANCA_IMEDIATA_REVISAR:
				new RevisarCobrancaImediataDemo().Execute(interSdk);
				break;
			case COBRANCA_IMEDIATA_CONSULTAR:
				new ConsultarCobrancaImediataDemo().Execute(interSdk);
				break;
			case COBRANCA_IMEDIATA_CRIAR_TXID:
				new CriarCobrancaImediataTxIdDemo().Execute(interSdk);
				break;
			case COBRANCAS_IMEDIATAS_CONSULTAR:
				new ConsultarCobrancasImediatasDemo().Execute(interSdk);
				break;
			case COBRANCAS_IMEDIATAS_CONSULTAR_PAGINACAO:
				new ConsultarCobrancasImediatasPaginadoDemo().Execute(interSdk);
				break;
			case COBRANCA_COM_VENCIMENTO_CRIAR_TXID:
				new CriarCobrancaComVencimentoTxIdDemo().Execute(interSdk);
				break;
			case COBRANCA_COM_VENCIMENTO_REVISAR:
				new RevisarCobrancaComVencimentoDemo().Execute(interSdk);
				break;
			case COBRANCA_COM_VENCIMENTO_CONSULTAR:
				new ConsultarCobrancaComVencimentoDemo().Execute(interSdk);
				break;
			case COBRANCAS_COM_VENCIMENTO_CONSULTAR:
				new ConsultarCobrancasComVencimentoDemo().Execute(interSdk);
				break;
			case COBRANCAS_COM_VENCIMENTO_CONSULTAR_PAGINACAO:
				new ConsultarCobrancasComVencimentoPaginadoDemo().Execute(interSdk);
				break;
			case LOCATION_CRIAR:
				new CriarLocationDemo().Execute(interSdk);
				break;
			case LOCATIONS_CADASTRADAS_CONSULTAR:
				new ConsultarLocationsCadastradasDemo().Execute(interSdk);
				break;
			case LOCATIONS_CADASTRADAS_CONSULTAR_PAGINACAO:
				new ConsultarLocationsCadastradasPaginadoDemo().Execute(interSdk);
				break;
			case LOCATION_RECUPERAR:
				new RecuperarLocationDemo().Execute(interSdk);
				break;
			case LOCATION_DESVINCULAR:
				new DesvincularLocationDemo().Execute(interSdk);
				break;
			case PIX_CONSULTAR:
				new ConsultarPixDemo().Execute(interSdk);
				break;
			case PIX_RECEBIDOS_CONSULTAR:
				new ConsultarPixRecebidosDemo().Execute(interSdk);
				break;
			case PIX_RECEBIDOS_CONSULTAR_PAGINACAO:
				new ConsultarPixRecebidosPaginadoDemo().Execute(interSdk);
				break;
			case PIX_DEVOLUCAO_SOLICITAR:
				new SolicitarDevolucaoDemo().Execute(interSdk);
				break;
			case PIX_DEVOLUCAO_CONSULTAR:
				new ConsultarDevolucaoDemo().Execute(interSdk);
				break;
			case WEBHOOK_CRIAR:
				new CriarWebhookPixDemo().Execute(interSdk);
				break;
			case WEBHOOK_OBTER:
				new ObterWebhookPixDemo().Execute(interSdk);
				break;
			case WEBHOOK_EXCLUIR:
				new ExcluirWebhookPixDemo().Execute(interSdk);
				break;
			case CALLBACKS_CONSULTAR:
				new ConsultarCallbacksDemo().Execute(interSdk);
				break;
		}
		Console.WriteLine();
	}

}
