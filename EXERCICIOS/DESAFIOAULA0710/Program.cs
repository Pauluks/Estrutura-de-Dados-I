using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Automovel> automoveis =
            new Dictionary<string, Automovel>();

        int opcao = 0;

        do
        {
            Console.WriteLine();
            Console.WriteLine("   SISTEMA DE CONTROLE DE AUTOMÓVEIS");
            Console.WriteLine("1 - Cadastrar automóvel");
            Console.WriteLine("2 - Buscar automóvel pela placa");
            Console.WriteLine("3 - Listar todos os automóveis");
            Console.WriteLine("4 - Buscar automóveis por marca");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            int.TryParse(Console.ReadLine(), out opcao);

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    CadastrarAutomovel(automoveis);
                    break;

                case 2:
                    BuscarPorPlaca(automoveis);
                    break;

                case 3:
                    ListarAutomoveis(automoveis);
                    break;

                case 4:
                    BuscarPorMarca(automoveis);
                    break;

                case 5:
                    Console.WriteLine("Sistema encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 5);
    }

    static void CadastrarAutomovel(
        Dictionary<string, Automovel> automoveis)
    {
        Console.Write("Digite a placa: ");
        string placa = Console.ReadLine();

        if (automoveis.ContainsKey(placa))
        {
            Console.WriteLine(
                "Não é possível cadastrar. " +
                "Essa placa já está cadastrada."
            );

            return;
        }

        Console.Write("Digite a marca: ");
        string marca = Console.ReadLine();

        Console.Write("Digite o modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("Digite o ano: ");
        int.TryParse(Console.ReadLine(), out int ano);

        Console.Write("Digite a cor: ");
        string cor = Console.ReadLine();

        Console.Write("Digite o valor: ");
        double.TryParse(Console.ReadLine(), out double valor);

        Automovel automovel = new Automovel();

        automovel.Placa = placa;
        automovel.Marca = marca;
        automovel.Modelo = modelo;
        automovel.Ano = ano;
        automovel.Cor = cor;
        automovel.Valor = valor;

        automoveis.Add(placa, automovel);

        Console.WriteLine();
        Console.WriteLine("Automóvel cadastrado com sucesso!");
    }

    static void BuscarPorPlaca(
        Dictionary<string, Automovel> automoveis)
    {
        Console.Write("Digite a placa: ");
        string placa = Console.ReadLine();

        if (automoveis.TryGetValue(
            placa,
            out Automovel automovel))
        {
            Console.WriteLine();
            Console.WriteLine("Automóvel encontrado:");
            Console.WriteLine("Placa: " + automovel.Placa);
            Console.WriteLine("Marca: " + automovel.Marca);
            Console.WriteLine("Modelo: " + automovel.Modelo);
            Console.WriteLine("Ano: " + automovel.Ano);
            Console.WriteLine("Cor: " + automovel.Cor);
            Console.WriteLine(
                "Valor: R$ " +
                automovel.Valor.ToString("F2")
            );
        }
        else
        {
            Console.WriteLine(
                "Automóvel não encontrado."
            );
        }
    }

    static void ListarAutomoveis(
        Dictionary<string, Automovel> automoveis)
    {
        if (automoveis.Count == 0)
        {
            Console.WriteLine(
                "Não existem automóveis cadastrados."
            );

            return;
        }

        Console.WriteLine("AUTOMÓVEIS CADASTRADOS");
        Console.WriteLine();

        foreach (
            KeyValuePair<string, Automovel> item
            in automoveis)
        {
            Automovel automovel = item.Value;

            Console.WriteLine("Placa: " + automovel.Placa);
            Console.WriteLine("Marca: " + automovel.Marca);
            Console.WriteLine("Modelo: " + automovel.Modelo);
            Console.WriteLine("Ano: " + automovel.Ano);
            Console.WriteLine("Cor: " + automovel.Cor);
            Console.WriteLine(
                "Valor: R$ " +
                automovel.Valor.ToString("F2")
            );
        }

    }

    static void BuscarPorMarca(
        Dictionary<string, Automovel> automoveis)
    {
        Console.Write("Digite a marca: ");
        string marca = Console.ReadLine();

        bool encontrou = false;

        Console.WriteLine();

        foreach (
            KeyValuePair<string, Automovel> item
            in automoveis)
        {
            Automovel automovel = item.Value;

            if (automovel.Marca.Equals(
                marca,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Placa: " + automovel.Placa);
                Console.WriteLine("Marca: " + automovel.Marca);
                Console.WriteLine("Modelo: " + automovel.Modelo);
                Console.WriteLine("Ano: " + automovel.Ano);
                Console.WriteLine("Cor: " + automovel.Cor);
                Console.WriteLine(
                    "Valor: R$ " +
                    automovel.Valor.ToString("F2")
                );

                encontrou = true;
            }
        }

        if (!encontrou)
        {
            Console.WriteLine(
                "Nenhum automóvel dessa marca foi encontrado."
            );
        }
    }
}