////Тема 17. Урок 2

//int[][] mas = new int[3][];
//Random random = new Random();
//double all_sum = 0;
//int count = 0;
//for (int i = 0; i < 3; i++) 
//{ 
//    int a= random.Next(1,11);
//    mas[i]=new int[a];
//    int sum = 0;
//	for (int j = 0; j < a; j++)
//	{
//        count++;
//		mas[i][j] = random.Next(11);
//        sum += mas[i][j];
//        all_sum += mas[i][j];
//        Console.Write(mas[i][j]+" " );
//    }
//    Console.Write("    |||Сумма = "+sum);
//    Console.WriteLine();
//}
//all_sum = all_sum / count;
//Console.WriteLine($"Среднее арифметическое всех значений = {all_sum:f2}");

//Тема 17. Урок 1.

int[][] mas = new int[5][];
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    int a = random.Next(1, 11);
    mas[i] = new int[a];
   int sum = 0;
    for (int j = 0; j < a; j++)
    {
        mas[i][j] = random.Next(11);
        Console.Write(mas[i][j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Ведите новое число");
int n;
int.TryParse(Console.ReadLine(), out n);
int index=random.Next(0, 5);
Console.WriteLine("строка = "+index);
int index1=random.Next(0, mas[index].Length);
Console.WriteLine("столбец = "+index1);
mas[index][index1] = n;
for (int i = 0; i < 5; i++)
{
    
    for (int j = 0; j < mas[i].Length; j++)
    {
        Console.Write(mas[i][j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();