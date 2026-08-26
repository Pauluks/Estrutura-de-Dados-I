using System.Collections;

// ArrayListas

ArrayList arrayList = new ArrayList();

//Adicionando Itens à Lista
arrayList.Add(5);

//Adcionando quantias de itens a Lista
        arrayList.AddRange(new int[] { 1, 2, 3,});  

//Insere o valor 7.8 na posição 3 da lista      
         arrayList.Insert(3, 7.8);

//Percorrendo itens da lista de forma genérica
foreach (object obj in arrayList)
{
    Console.WriteLine(obj);
}

// LISTAS GENÉRICAS

List<double> numbers = new List<double>();

Console.WriteLine("Digite 'Sair' para encerrar:");

bool run = true;

do
{
   Console.Write("Digite um número: ");
    string numberStr = Console.ReadLine();
    if (numberStr.ToLower() == "sair")
    {
        run = false;
        Console.WriteLine("Processo encerrado.");

        break;   

    }   
    else
    {
        //Validação da entrada do usuário
        // para checar se é de fato um número
        if (!double.TryParse (numberStr, System.Globalization.NumberStyles.Float, 
                                        new System.Globalization.NumberFormatInfo(), 
                                        out double number));
    
    }

}while (run);