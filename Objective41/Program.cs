Console.Write("Введите колличество чисел: ");
int sizeM = Convert.ToInt32(Console.ReadLine());
int[] numbersM = new int[sizeM];
int count = 0;
for (int i = 0; i < numbersM.Length; i++)
{
    Console.Write("Введите число: ");
    numbersM[i] = Convert.ToInt32(Console.ReadLine());
}

int Comparison(int[] numbersM)
{
    for (int i = 0; i < numbersM.Length; i++)
    {
        if (numbersM[i] > 0) count += 1;
        
    }
return count;
}

Console.WriteLine($"Колличество цифр больше 0: {Comparison(numbersM)}");