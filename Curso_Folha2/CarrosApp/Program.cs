using System;
using CarrosApp;

string placa;
string modelo;
string strcilindrada;

bool sair = false;

List<Carro> carros = new List<Carro>();
List<Motor> motores = new List<Motor>();

motores.Add(new Motor() { Cilindrada = "1.0" });
motores.Add(new Motor() { Cilindrada = "1.6" });
motores.Add(new Motor() { Cilindrada = "1.8" });
motores.Add(new Motor() { Cilindrada = "2.0" });


while (!sair)
{
    try
    {
        int opcao;
        Console.Clear();
        Console.WriteLine("Escoha a opcao: ");
        Console.WriteLine("1 - Adicionar carro");
        Console.WriteLine("2 - Editar carro");
        Console.WriteLine("8 - Listar Carros");
        Console.WriteLine("9 - Sair");
        opcao = Convert.ToInt16(Console.ReadLine());

        switch (opcao)
        {

            case 1:
                Console.Clear();
                Console.Write("Placa: ");
                placa = Console.ReadLine();
                Console.Write("Modelo: ");
                modelo = Console.ReadLine();
                Console.Write("Motor: ");
                strcilindrada = (Console.ReadLine());
                if (string.IsNullOrEmpty(strcilindrada))
                {
                    Console.WriteLine("Motor invalido");
                    continue;
                }

                Motor motorAdd = GetMotor(strcilindrada);

                if (motorAdd == null)
                {
                    Console.WriteLine("Motor nao encontrado");
                    continue;
                }
                if (!MotorDisponivel(motorAdd))
                {
                    throw new Exception("Motor ja esta sendo usado");
                }
                Carro carroAdd = new Carro(placa, modelo, motorAdd);

                if (!AddCarro(carroAdd))
                {
                    Console.WriteLine("Carro ja existe");
                    continue;
                }
                break;
            case 2:
                Console.Clear();
                ListarCarros();
                Console.Write("Placa: ");
                placa = Console.ReadLine();

                Carro carroEdit = GetCarro(placa);
                if (carroEdit == null)
                {
                    Console.WriteLine("Carro nao encontrado");
                    continue;
                }
                Console.WriteLine(carroEdit.Modelo);
                Console.WriteLine(carroEdit.Motor?.Cilindrada);

                Console.Write("Motor: ");
                strcilindrada = (Console.ReadLine());
                if (string.IsNullOrEmpty(strcilindrada))
                {
                    Console.WriteLine("Motor invalido");
                    continue;
                }
                Motor motorEdit = GetMotor(strcilindrada);

                if (motorEdit == null)
                {
                    Console.WriteLine("Motor nao encontrado");
                    continue;
                }
                if (!MotorDisponivel(motorEdit))
                {
                    throw new Exception("Motor ja esta sendo usado");
                }

                Console.WriteLine("M");
                carroEdit.Motor = motorEdit;

                break;
            case 8:
                Console.Clear();
                ListarCarros();
                Console.ReadKey();
                break;
            case 9:
                sair = true;
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadKey();
    }
}



Carro GetCarro(string placa)
{
    for (int i = 0; i < carros.Count; i++)
    {
        if (carros[i].Placa.Equals(placa))
        {
            return carros[i];
        }
    }
    return null;
}

Motor GetMotor(string cilindrada)
{
    for (int i = 0; i < motores.Count; i++)
    {
        if (motores[i].Cilindrada.Equals(cilindrada))
        {
            return motores[i];
        }
    }
    return null;
}

bool AddCarro(Carro carro)
{
    for (int i = 0; i < carros.Count; i++)
    {
        if (carros[i].Equals(carro))
        {
            return false;
        }
    }
    carros.Add(carro);
    return true;
}

bool MotorDisponivel(Motor motor)
{
    for (int i = 0; i < carros.Count; i++)
    {
        if (carros[i].Motor.Equals(motor))
        {
            return false;
        }
    }
    return true;
}

void ListarCarros()
{
    Console.WriteLine("");
    foreach (Carro carro in carros)
    {
        Console.WriteLine("Placa     : " + carro.Placa);
        Console.WriteLine("Modelo    : " + carro.Modelo);
        Console.WriteLine("Cilindrada: " + carro.Motor?.Cilindrada);
        switch (carro.Motor?.Cilindrada)
        {
            case "1.0":
                Console.WriteLine("Velocidade Maxima 140km/h");
                break;
            case "1.6":
                Console.WriteLine("Velocidade Maxima 160km/h");
                break;
            case "1.8":
                Console.WriteLine("Velocidade Maxima 180km/h");
                break;
            case "2.0":
                Console.WriteLine("Velocidade Maxima 220km/h");
                break;
            default:
                Console.WriteLine("Carro nao possui motor");
                break;
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");

}



