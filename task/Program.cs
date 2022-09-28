string[] SearchElemets(string[] array)
{
    string[] result = new string[0];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[j] = array[i];
            j++;
        }
    }
    return result;
}


Console.Write("Введите элементы массива разделив их запятой и пробелом: ");
string text = Console.ReadLine() ?? String.Empty;
string[] textArray = text.Split(", ");
string[] resultArray = SearchElemets(textArray);
Console.WriteLine($"[{String.Join(", ", resultArray)}]");