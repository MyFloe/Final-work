Console.Write("Введите массив данных через ',': ");
string strLine = Console.ReadLine();
string[] firstArr = strLine.Split(",");
string[] secondArr = new string[0];

for (int i = 0; i < firstArr.Length; i++)
{
    if (firstArr[i].Length <= 3)
    {
        Array.Resize(ref secondArr, secondArr.Length + 1);
        secondArr[secondArr.Length-1] = firstArr[i];
    }

}
Console.WriteLine($"[{string.Join(",", firstArr)}]=>[{string.Join(",", secondArr)}]");