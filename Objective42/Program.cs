Console.Write("Введите десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
int[] arraybinaryNumber = new int[10]; 
int binaryNumber = 0; 

Console.Write("Заданное десятичное число преобразованное в двоичное: ");
for (int i = 0; decimalNumber >= 1; i++)
{
    binaryNumber = decimalNumber % 2;
    decimalNumber = decimalNumber / 2;
    Console.Write(binaryNumber);
}