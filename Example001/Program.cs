Console.Clear();

// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         int k = i * j;
//         Console.SetCursorPosition(i*5, j);
//         Console.Write(k);
//     }

// }


int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int j = i; j <= n; j++)
    {
        int k = i * j;
        Console.SetCursorPosition(i*5, j);
        Console.Write(k);
        Console.SetCursorPosition(j*5, i);
        Console.Write(k);
    }

}
