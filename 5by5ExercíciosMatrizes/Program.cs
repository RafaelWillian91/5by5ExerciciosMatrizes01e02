using System.Security.Cryptography;

Console.WriteLine("*********  Matriz   ***********");

Console.WriteLine("Informe o tamanho da Matriz:");
int tamanhoMatriz = int.Parse(Console.ReadLine()!);

int[,] matriz = new int[tamanhoMatriz, tamanhoMatriz];

void PreencherMatriz() { 

    for (int i = 0; i < tamanhoMatriz; i++)
    {
        for (int j = 0; j < tamanhoMatriz; j++)
        {
            matriz[i, j] = RandomNumberGenerator.GetInt32(1, 45);
        }
    }
}

void MostrarMatriz()
{
    
    for (int i = 0; i < tamanhoMatriz; i++)
    {
        for (int j = 0; j < tamanhoMatriz; j++)
        {
            Console.Write(matriz[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

void somarLinha()
{
    for (int i = 0; i < tamanhoMatriz; i++)
{
        int soma = 0;

        for (int j = 0; j < tamanhoMatriz; j++)
        {
            soma += matriz[i, j];
        }

        Console.WriteLine($"Soma da linha {i}: {soma}");
    }
}

void somarColuna()
{
    for (int j = 0; j < tamanhoMatriz; j++)
    {
        int soma = 0;

        for (int i = 0; i < tamanhoMatriz; i++)
        {
            soma += matriz[i, j];
        }

        Console.WriteLine($"Soma coluna {j}: {soma}");
    }
}

void somarDiagonal (){

    int somaPrincipal = 0;
    int somaInversa = 0;

    for (int i = 0; i < tamanhoMatriz; i++)
    {
        somaPrincipal += matriz[i, i];
        somaInversa += matriz[i, tamanhoMatriz - 1 - i];
    }
    
    //Soma em X
    Console.WriteLine($"Diagonal principal: {somaPrincipal}");
    Console.WriteLine($"Diagonal invertida: {somaInversa}");

}

PreencherMatriz();
MostrarMatriz();
somarLinha();
somarColuna();
somarDiagonal();