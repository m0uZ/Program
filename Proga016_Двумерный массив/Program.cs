string[,] table = new string[2, 5];  // 2 это строки 5 столбцы
/* Обращение к столбцам и строкам
table[0,0] первый столбик table[0,1] второй столбик и тд
table[1,0] первая строка table[1,1] вторая строка
table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]столбики
table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]строки
*/


// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

void PrintArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);