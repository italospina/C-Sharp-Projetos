using Projeto_Hospedagem.Models;
using Projeto_Hospedagem.Construtores;
using Newtonsoft.Json;

bool running = true;

while (running)
{
    MenuPrincipal menuPrincipal = new MenuPrincipal();
    menuPrincipal.MostrarMenuPrincipal();
    int opcao;
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            SuiteConstructor serializarSuite = new SuiteConstructor();
            serializarSuite.SerializacaoSuite();
            serializarSuite.ApresentarDesserializacaoSuite();

            menuPrincipal.VoltaMenuPrincipal();

            break;
        case 2:
            HospedesConstructor hospedesConstructor1 = new HospedesConstructor();
            hospedesConstructor1.ApresentarDesserializacaoHospedes();

            break;
        case 3:
            Reserva reserva = new Reserva();

            reserva.EscolheSuite();

            reserva.EscolhaDiasReservados();

            reserva.AdicionarHospede();

            break;
        case 4:
            HospedesConstructor hospedesConstructor2 = new HospedesConstructor();
            //hospedesConstructor2.LimparHospedes();

            return;
    }

}




