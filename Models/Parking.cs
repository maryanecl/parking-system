class Parking
{
    private decimal initialPrice;
    private decimal pricePerHour;
    private List<string> automobile;

    public Parking(decimal initialPrice, decimal pricePerHour)
    {
        this.initialPrice = initialPrice;
        this.pricePerHour = pricePerHour;
        this.automobile = new List<string>();
    }

    public void AddAutomobile()
    {
        Console.Clear();
        Console.WriteLine("      Estacionamento Avanade      ");
        Console.WriteLine("==================================");

        Console.Write("Digite a placa do veículo para estacionar: ");
        string plate = Console.ReadLine().ToUpper();

        if (!string.IsNullOrWhiteSpace(plate))
        {
            automobile.Add(plate);
            Console.WriteLine($"O veículo com placa {plate} foi estacionado com sucesso!");
        }
        else
        {
            Console.WriteLine("Placa inválida. Tente novamente.");
        }

        Console.ReadLine(); 
    }

    public void RemoveAutomobile()
    {
        Console.Clear();
        Console.WriteLine("      Estacionamento Avanade      ");
        Console.WriteLine("==================================");

        Console.Write("Digite a placa do veículo para remover: ");
        string plate = Console.ReadLine().ToUpper();

        if (automobile.Contains(plate))
        {
            Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
            if (int.TryParse(Console.ReadLine(), out int hours) && hours >= 0)
            {
                decimal totalValue = CalculateTotalValue(hours);
                automobile.Remove(plate);

                Console.WriteLine($"O veículo com placa {plate} foi removido.");
                Console.WriteLine($"O preço total a ser pago é: R$ {totalValue}");
            }
            else
            {
                Console.WriteLine("Quantidade de horas inválida. Operação cancelada.");
            }
        }
        else
        {
            Console.WriteLine("Veículo não encontrado. Verifique a placa e tente novamente.");
        }

        Console.ReadLine(); 
    }

    public void ListAutomobile()
    {
        Console.Clear();
        Console.WriteLine("      Estacionamento Avanade      ");
        Console.WriteLine("==================================");

        if (automobile.Count > 0)
        {
            Console.WriteLine("Veículos estacionados:");
            foreach (var veiculo in automobile)
            {
                Console.WriteLine($"- {veiculo} 🚗");
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }

        Console.ReadLine(); 
    }

    private decimal CalculateTotalValue(int hours)
    {
        if (hours <= 2)
        {
            return initialPrice;
        }
        else
        {
            return initialPrice + pricePerHour * (hours - 2);
        }
    }
}