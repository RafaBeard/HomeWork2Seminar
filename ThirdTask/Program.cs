Console.Write("Введи цифру, обозначающую день недели: ");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num == 6 || Num == 7)
{
    Console.WriteLine("Да, это выходной день.");
}
else
{
    Console.WriteLine("Нет, это невыходной день.");
}