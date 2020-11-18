using System;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            string gelo = "";
            Console.WriteLine("Menu de Opções");
            Console.WriteLine("Escolha uma opção de bebida abaixo");
            Console.WriteLine("1 - Coca Cola");
            Console.WriteLine("2 - Pepsi");
            Console.WriteLine("3 - Coca Fanta");
            Console.WriteLine("4 - Água");
            int resposta = int.Parse(Console.ReadLine());
            if(resposta > 0 || resposta <5){
                Console.WriteLine("Você gostaria com gelo? Sim ou Não");
                gelo = Console.ReadLine();
            }
            switch(resposta)
            {
                case 1:
                    if(gelo == "sim"){
                        Console.WriteLine("Será enviado uma COCA-COLA para sua mesa com gelo");
                    }else{
                        Console.WriteLine("Será enviado uma COCA-COLA para sua mesa sem cubos de gelo");
                    }
                break;
                case 2:
                Console.WriteLine("Será enviado uma PEPSI para sua mesa");
                break;
                case 3:
                Console.WriteLine("Será enviado uma Fanta para sua mesa");
                break;
                case 4:
                Console.WriteLine("Será enviado uma Água para sua mesa");
                break;
            } //fim do switch
        }
    }
}
