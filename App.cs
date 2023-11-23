using Sdk;
using System;

class App {
    public static void Main(string[] args) {
        Console.WriteLine(InterSdk.GetVersion());
        Console.WriteLine("demo-sdk-csharp v1.0.0.2023-09-26");
        Console.WriteLine("**************************************************************************************************");
        Console.WriteLine("ATENÇÃO - APESAR DE SER UM PROJETO DEMO, AS AÇÕES SÃO REALIZADAS NO AMBIENTE DE PRODUÇÃO DO INTER!");
        Console.WriteLine("**************************************************************************************************\n");

        string ambiente = "bancointer";

        if (args.Length == 1) {
            ambiente = args[0];
        }

        Console.WriteLine("Configuração do InterSdk:");
        string clientId = Utils.GetString("clientId de sua aplicação");
        string clientSecret = Utils.GetString("clientSecret de sua aplicação");
        string certificado = Utils.GetString("nome do arquivo com o certificado pfx");
        string chave = Utils.GetString("senha do arquivo com o certificado pfx");
        string conta = Utils.GetString("conta corrente da aplicação (caso tenha múltiplas contas)");

        InterSdk interSdk = new InterSdk(ambiente, certificado, chave, clientId, clientSecret);
        interSdk.SetDebug(true);
        if (conta != null && !conta.Equals("")) {
            interSdk.SetContaCorrente(conta);
        }

        while(true) {
            int op = Menu();
            if (op == 0) {
                break;
            }
            try {
                Execute(op, ambiente, interSdk);
            } catch (SdkException e) {
                Console.WriteLine("Titulo: {0}", e.Erro.Title);
                Console.WriteLine("Detalhes: {0}", e.Erro.Detail);
                foreach (Violacao violacao in e.Erro.Violacoes) {
                    Console.WriteLine("Violacao Razao: {0}", violacao.Razao);
                    Console.WriteLine("Violacao Propriedade: {0}", violacao.Propriedade);
                    Console.WriteLine("Violacao Valor: {0}", violacao.Valor);
                }
                Console.WriteLine(new System.Diagnostics.StackTrace().ToString());
            }
        }
    }


    private static void Execute(int op, string ambiente, InterSdk interSdk) {
        switch (op) {
        case 0:
            return;
        case 1:
            while ((op = MenuCobranca.ShowMenu(ambiente)) != 0) {
                MenuCobranca.Execute(op, interSdk);
            }
            break;
        case 2:
            while ((op = MenuBanking.ShowMenu(ambiente)) != 0) {
                MenuBanking.Execute(op, interSdk);
            }
            break;
        case 3:
            while ((op = MenuPix.ShowMenu(ambiente)) != 0) {
                MenuPix.Execute(op, interSdk);
            }
            break;
        default:
            Console.WriteLine("opcao invalida");
            break;
        }
    }

    private static int Menu() {
        Console.WriteLine("1 - Cobranca");
        Console.WriteLine("2 - Banking");
        Console.WriteLine("3 - Pix");
        Console.WriteLine("0 - Sair");
        Console.Write("opcao: ");
        return int.Parse(Console.ReadLine());
    }
}
