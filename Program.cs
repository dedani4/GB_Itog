using static System.Console;
Clear();

Write("Enter few words splited with space: ");
OutputArray(CreateResultArray(InputArray(ReadLine()!)));

string[] InputArray(string line)
{
    return line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
}

string[] CreateResultArray(string[] stringArray)
{
    string[] resultArray = new string[CountSrting(stringArray)];
    for (int i = 0, j = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            resultArray[j] = stringArray[i];
            j++;
        }
    }
    return resultArray;
}

int CountSrting(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
            count++;
    }
    return count;
}

void OutputArray(string[] resultArray)
{
    Write("[");
    for (int i = 0; i < resultArray.Length; i++)
    {
        if (i != resultArray.Length - 1)
            Write(resultArray[i] + ", ");
        else
            Write(resultArray[i] + "]");
    }

}


