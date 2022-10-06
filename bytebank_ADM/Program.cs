using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;
using bytebank_ADM.ParceriaComercial;
using System.Globalization;

CalcularBonificacao();
Console.WriteLine("");
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
  

    Designer pedro = new Designer("123.215.665-96");
    pedro.Nome = "Pedr";

    Desenvolvedor samya = new Desenvolvedor("123.255.667.96");
    samya.Nome = "samya";
        
    Diretor paula = new Diretor("456.545.859-99");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("215.569.874-33");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("124.455.666-55");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(samya);

    Console.WriteLine("Total de Bonificação R$" + gerenciador.getBonificacao());
}



void UsarSistema()
{
    SistemaInterno sistemainterno = new SistemaInterno();

    Diretor roberta = new Diretor("125.254.655-99");
    roberta.Nome = "Roberta";
    roberta.Login = "rbt";
    roberta.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("458.855.555-85");
    ursula.Nome = "Ursula";
    ursula.Login = "ursula123";
    ursula.Senha = "321";
   
    sistemainterno.Logar(roberta,roberta.Login, roberta.Senha);
    sistemainterno.Logar(ursula, "ursula12", ursula.Senha) ;

    ParceiroComercial joao = new ParceiroComercial();
    joao.Login = "joao";
    joao.Senha = "123";
    sistemainterno.Logar(joao, joao.Login, joao.Senha);
}


Console.ReadKey();
