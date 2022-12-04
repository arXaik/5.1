// Петросян 5.1 Средний уровень 16 вар
Console.WriteLine("Введите строку");
string str = Console.ReadLine();
int L = str.Length;
int i;
for (i = 0;i < L;i++)
    {
        str = str.Replace("  ", " ");
    }
Console.WriteLine(str);