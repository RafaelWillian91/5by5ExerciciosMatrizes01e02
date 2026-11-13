using System.Security.Cryptography;


Console.WriteLine("******** BOLETIM ESCOLAR ********");

string[] materias = { "C#", "JAva", "Html", "CSS", "IA" };

double[,] notas = new double[5, 5];

string[] situacoes = new string[5];



void PreencherNotas()
{
    for (int i = 0; i < materias.Length; i++)
    {
        //populei a matriz até a penultima posicao
        for (int j = 0; j < 4; j++)
        {
            notas[i, j] = RandomNumberGenerator.GetInt32(1, 10);
        }
    }
}

void CalcularMedias()
{
    //linha
    for (int i = 0; i < materias.Length; i++)
    {
        double soma = 0;

        //coluna
        for (int j = 0; j < 4; j++)
        {
            soma += notas[i, j];
        }

        //Ultima posicao da matriz
        notas[i, 4] = soma / 4;
    }
}

void VerificarSituacao()
{
    for (int i = 0; i < materias.Length; i++)
    {
        double media = notas[i, 4];

        if (media < 4)
        {
            situacoes[i] = "Reprovado";
        }
        else if (media < 7)
        {
            situacoes[i] = "Recuperação";
        }
        else
        {
            situacoes[i] = "Aprovado";
        }
    }
}

void ImprimirBoletim()
{
    // Percorre cada matéria do vetor.
    // O índice "i" representa a linha da matriz (matéria).
    for (int i = 0; i < materias.Length; i++)
    {
        // Exibe o nome da matéria.
        // -15: reserva 15 caracteres, alinhando à esquerda.
        Console.Write($"{materias[i],-15}");

        // Percorre as 5 colunas da matriz:
        // 4 notas bimestrais + 1 média final.
        // O índice "j" representa a coluna.
        for (int j = 0; j < 5; j++)
        {
            // Exibe a nota correspondente à matéria e ao bimestre.
            // -10: reserva 10 caracteres, alinhando à esquerda.
            // F2: formata o número com 2 casas decimais.
            Console.Write($"{notas[i, j],-10:F2}");
        }

        // Exibe a situação da matéria (Aprovado, Recuperação ou Reprovado).
        // -12: reserva 12 caracteres, alinhando à esquerda.
        // WriteLine: quebra a linha para imprimir a próxima matéria.
        Console.WriteLine($"{situacoes[i],-12}");
    }
}

PreencherNotas();
CalcularMedias();
VerificarSituacao();
ImprimirBoletim();
