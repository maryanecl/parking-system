class Program
{
    static void Main()
    {
        Parking parking = new Parking(initialPrice: 10, pricePerHour: 1);
        bool continued = true;

        while (continued)
        {
            Console.Clear();
            Console.WriteLine("  _______   _______   _______");
            Console.WriteLine(" |       | |       | |       |");
            Console.WriteLine(" |   X   | |   X   | |   X   |");
            Console.WriteLine(" |_______| |_______| |_______|");
            Console.WriteLine("   Vaga 1    Vaga 2    Vaga 3\n");
            Console.WriteLine("Bem-vindo ao Estacionamento Avanade");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Cadastrar veículo");
            Console.WriteLine("2. Remover veículo");
            Console.WriteLine("3. Listar veículos");
            Console.WriteLine("4. Encerrar");

            Console.Write("Escolha uma opção (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    parking.AddAutomobile();
                    break;
                case "2":
                    parking.RemoveAutomobile();
                    break;
                case "3":
                    parking.ListAutomobile();
                    break;
                case "4":
                    continued = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.ReadLine();
                    break;
            }
            
        }
        
        Console.WriteLine("\nSistema finalizado com sucesso!");
    }
}

