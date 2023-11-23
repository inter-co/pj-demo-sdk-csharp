all: App.exe 

clean: 
	rm -f App.exe 

COBRANCA_DEMO= \
cobranca/RecuperarBoletosPaginadoDemo.cs \
cobranca/CancelarBoletoDemo.cs \
cobranca/ConsultarCallbacksDemo.cs \
cobranca/CriarWebhookCobrancaDemo.cs \
cobranca/RecuperarBoletosDemo.cs \
cobranca/RecuperarBoletoPdfDemo.cs \
cobranca/RecuperarBoletoDetalhadoDemo.cs \
cobranca/ExcluirWebhookCobrancaDemo.cs \
cobranca/RecuperarSumarioBoletosDemo.cs \
cobranca/EmitirBoletoDemo.cs \
cobranca/ObterWebhookCobrancaDemo.cs

COBRANCA_EXEMPLOS= \
cobranca/exemplos/ExcluirWebhook.cs \
cobranca/exemplos/CriarWebhook.cs \
cobranca/exemplos/RecuperarBoletos.cs \
cobranca/exemplos/CancelarBoleto.cs \
cobranca/exemplos/ConsultarCallbacks.cs \
cobranca/exemplos/RecuperarBoletoDetalhado.cs \
cobranca/exemplos/ObterWebhook.cs \
cobranca/exemplos/RecuperarBoletosPaginacao.cs \
cobranca/exemplos/RecuperarSumarioBoletos.cs \
cobranca/exemplos/EmitirBoleto.cs \
cobranca/exemplos/RecuperarBoletoPdf.cs

BANKING_DEMO= \
banking/IncluirPagamentoDarfDemo.cs \
banking/BuscarPagamentosDemo.cs \
banking/ConsultarExtratoEnriquecidoDemo.cs \
banking/BuscarLotePagamentosDemo.cs \
banking/IncluirPagamentoDemo.cs \
banking/IncluirPagamentosLoteDemo.cs \
banking/ConsultarExtratoEnriquecidoPaginadoDemo.cs \
banking/BuscarPagamentosDarfDemo.cs \
banking/IncluirPixChaveDemo.cs \
banking/ConsultarExtratoDemo.cs \
banking/RecuperarExtratoPdfDemo.cs \
banking/IncluirPixDadosBancariosDemo.cs \
banking/ConsultarSaldoDemo.cs \
banking/CriarWebhookBankingDemo.cs \
banking/ObterWebhookBankingDemo.cs \
banking/ExcluirWebhookBankingDemo.cs \
banking/CancelarAgendamentoDemo.cs \
banking/ConsultarCallbacksDemo.cs

BANKING_EXEMPLOS= \
banking/exemplos/ConsultarExtrato.cs \
banking/exemplos/ConsultarExtratoEnriquecidoPaginacao.cs \
banking/exemplos/IncluirPagamentosLote.cs \
banking/exemplos/ConsultarSaldo.cs \
banking/exemplos/BuscarPagamentos.cs \
banking/exemplos/ConsultarExtratoEnriquecido.cs \
banking/exemplos/IncluirPagamentoDarf.cs \
banking/exemplos/RecuperarExtratoPdf.cs \
banking/exemplos/BuscarLotePagamentos.cs \
banking/exemplos/IncluirPixChave.cs \
banking/exemplos/IncluirPagamento.cs \
banking/exemplos/IncluirPixDadosBancarios.cs \
banking/exemplos/BuscarPagamentosDarf.cs \
banking/exemplos/CriarWebhook.cs \
banking/exemplos/ObterWebhook.cs \
banking/exemplos/ExcluirWebhook.cs \
banking/exemplos/CancelarAgendamento.cs \
banking/exemplos/ConsultarCallbacks.cs

PIX_DEMO= \
pix/ConsultarCallbacksDemo.cs			 \
pix/ConsultarLocationsCadastradasPaginadoDemo.cs	 \
pix/DesvincularLocationDemo.cs \
pix/ConsultarCobrancaComVencimentoDemo.cs		 \
pix/ConsultarPixDemo.cs				 \
pix/ExcluirWebhookPixDemo.cs \
pix/ConsultarCobrancaImediataDemo.cs		 \
pix/ConsultarPixRecebidosDemo.cs			 \
pix/ObterWebhookPixDemo.cs \
pix/ConsultarCobrancasComVencimentoDemo.cs		 \
pix/ConsultarPixRecebidosPaginadoDemo.cs		 \
pix/RecuperarLocationDemo.cs \
pix/ConsultarCobrancasComVencimentoPaginadoDemo.cs	 \
pix/CriarCobrancaComVencimentoTxIdDemo.cs		 \
pix/RevisarCobrancaComVencimentoDemo.cs \
pix/ConsultarCobrancasImediatasDemo.cs		 \
pix/CriarCobrancaImediataDemo.cs			 \
pix/RevisarCobrancaImediataDemo.cs \
pix/ConsultarCobrancasImediatasPaginadoDemo.cs	 \
pix/CriarCobrancaImediataTxIdDemo.cs		 \
pix/SolicitarDevolucaoDemo.cs \
pix/ConsultarDevolucaoDemo.cs			 \
pix/CriarLocationDemo.cs				 \
pix/ConsultarLocationsCadastradasDemo.cs		 \
pix/CriarWebhookPixDemo.cs


PIX_EXEMPLOS= \
pix/exemplos/ConsultarCallbacks.cs				 \
pix/exemplos/ConsultarLocationsCadastradas.cs		 \
pix/exemplos/CriarWebhook.cs \
pix/exemplos/ConsultarCobrancaComVencimento.cs		 \
pix/exemplos/ConsultarLocationsCadastradasPaginacao.cs	 \
pix/exemplos/DesvincularLocation.cs \
pix/exemplos/ConsultarCobrancaImediata.cs			 \
pix/exemplos/ConsultarPix.cs					 \
pix/exemplos/ExcluirWebhook.cs \
pix/exemplos/ConsultarCobrancasComVencimento.cs		 \
pix/exemplos/ConsultarPixRecebidos.cs			 \
pix/exemplos/ObterWebhook.cs \
pix/exemplos/ConsultarCobrancasComVencimentoPaginacao.cs	 \
pix/exemplos/ConsultarPixRecebidosPaginacao.cs		 \
pix/exemplos/RecuperarLocation.cs \
pix/exemplos/ConsultarCobrancasImediatas.cs			 \
pix/exemplos/CriarCobrancaComVencimento.cs			 \
pix/exemplos/RevisarCobrancaComVencimento.cs \
pix/exemplos/ConsultarCobrancasImediatasPaginacao.cs		 \
pix/exemplos/CriarCobrancaImediata.cs			 \
pix/exemplos/RevisarCobrancaImediata.cs \
pix/exemplos/ConsultarDevolucao.cs				 \
pix/exemplos/CriarLocation.cs				 \
pix/exemplos/SolicitarDevolucao.cs

COBRANCA=$(COBRANCA_EXEMPLOS) $(COBRANCA_DEMO)
BANKING=$(BANKING_EXEMPLOS) $(BANKING_DEMO)
PIX=$(PIX_EXEMPLOS) $(PIX_DEMO)
MENUS=MenuBanking.cs MenuCobranca.cs MenuPix.cs

App.exe: App.cs Utils.cs $(MENUS) $(COBRANCA) $(BANKING) $(PIX) 
	csc -w:0 /out:App.exe App.cs Utils.cs $(MENUS) $(COBRANCA) $(BANKING) $(PIX) /r:inter-sdk-csharp.dll 

run: App.exe
	clear
	mono App.exe

