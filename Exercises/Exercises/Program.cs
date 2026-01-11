// See https://aka.ms/new-console-template for more information
// Ausführung der programme
// RomNumbers();
//MatMult();
//printStars();
//calcEclid()

/* Aufgabe 1 Dreieck aus Stern */
void printStars()
{
    Console.WriteLine("Enter Number of Stars: ");
    string stringOfStars = Console.ReadLine();
    int numberOfStars = int.Parse(stringOfStars);
    for (int i = 0; i < numberOfStars; i++)
    {
        string s = "";
        for (int j = 0; j <= i; j++)
        {
            s = s + "*";
        }
        Console.WriteLine(s);
    }
}


/* Aufgabe 2 Euklidischer Algorithmus */
void calcEclid()
{
    Console.WriteLine("Enter number a:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter number b:");
    int b = int.Parse(Console.ReadLine());
    while (a != b)
    {
        if (a > b)
        {
            a = a - b;
        }
        else
        {
            b = b - a;
        }
    }
    Console.WriteLine($"GGT ist {a}");
}

/* Aufgabe 3 Römische Zahlen */
void RomNumbers()
{
    int countM;
    int countD;
    int countC;
    int countL;
    int countX;
    int countV;
    int countI;
    Console.WriteLine("Enter number to be transformed in romanic numbers:");
    int number = int.Parse(Console.ReadLine());
    countM = number / 1000;
    number = number % 1000;
    countD = number / 500;
    number = number % 500;
    countC = number / 100;
    number = number % 100;
    countL = number / 50;
    number = number % 50;
    countX = number / 10;
    number = number % 10;
    countV = number / 5;
    number = number % 5;
    countI = number;

    for (int i = 0; i < countM; i++)
    {
        Console.Write("M");
    }
    for (int i = 0; i < countD; i++)
    {
        Console.Write("D");
    }
    for (int i = 0; i < countC; i++)
    {
        Console.Write("C");
    }
    for (int i = 0; i < countL; i++)
    {
        Console.Write("L");
    }
    for (int i = 0; i < countX; i++)
    {
        Console.Write("X");
    }
    for (int i = 0; i < countV; i++)
    {
        Console.Write("V");
    }
    for (int i = 0; i < countI; i++)
    {
        Console.Write("I");
    }
}

void MatMult()
{
    Console.WriteLine("Enter Matrix a in Format: Line1 = number number number, number number number");
    string readA = Console.ReadLine();
    Console.WriteLine("Enter Matrix b in Format number number number, number number number");
    string readB = Console.ReadLine();
    int[,] matrixA = generateMatrix(readA);
    int[,] matrixB = generateMatrix(readB);
    int rowsCount = matrixA.GetLength(1);
    int columnCount = matrixB.GetLength(0);
    if (matrixA.GetLength(0) != matrixB.GetLength(1))
    {
        Console.WriteLine("ungültiges MatrixFormat! Bedenke a = NxJ, b = JxF");
        return;
    }
    int[,] resultMatrix = new int[columnCount, rowsCount];
    for (int i = 0; i < columnCount; i++)
    {
        for (int j = 0; j < rowsCount; j++)
        {
            int value = 0;
            for (int index = 0; index < matrixA.GetLength(0); index++)
            {
                value += matrixA[index, j] * matrixB[i, index];
            }
            resultMatrix[i, j] = value;
        }
    }

    PrintResult(resultMatrix);
}
int[,] generateMatrix(string input)
{
    string[] rowsInput = input.Split(",");
    string[] coloumnInput = rowsInput[0].Split(" ");
    int[,] matrixInput = new int[coloumnInput.Length, rowsInput.Length];
    for (int i = 0; i < rowsInput.Length; i++)
    {
        coloumnInput = rowsInput[i].Split(" ");
        for (int j = 0; j < coloumnInput.Length; j++)
        {
            matrixInput[j, i] = int.Parse(coloumnInput[j]);
        }
    }
    return matrixInput;
}
void PrintResult(int[,] input)
{
    Console.Write("____");
    for (int j = 0; j < input.GetLength(0); j++)
    {
        Console.Write("__");
    }
    Console.Write("\n");
    for (int i = 0; i < input.GetLength(1); i++)
    {
        string result = "";
        for (int j = 0; j < input.GetLength(0); j++)
        {
            result += input[j, i] + " ";
        }
        Console.WriteLine("| " + result + " |");
    }
    Console.Write("____");
    for (int j = 0; j < input.GetLength(0); j++)
    {
        Console.Write("__");
    }
}