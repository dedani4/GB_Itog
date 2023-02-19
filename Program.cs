using static System.Console;
Clear();

Write("Enter few words splited with space: ");
string[] stringArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int count = 0;
for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length < 4)
        count++;
}

string[] resultArray = new string[count];

for (int i = 0, j = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length < 4)
    {
        resultArray[j] = stringArray[i];
        j++;
    }
}

Write("[");
for (int i = 0; i < resultArray.Length; i++)
{
    if (i != resultArray.Length - 1)
        Write(resultArray[i] + ", ");
    else
        Write(resultArray[i] + "]");
}




