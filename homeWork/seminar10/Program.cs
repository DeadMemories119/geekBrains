// Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.


string[] CreateRandomStringArray(int size, int maxLength)
{
    Random random = new Random();
    string[] array = new string[size];
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    
    for (int i = 0; i < size; i++)
    {
        int length = random.Next(1,maxLength);
        char[] charArray = new char[length];
        
        for (int j = 0; j < length; j++)
        {
            charArray[j] = chars[random.Next(chars.Length)];
        }

        array[i] = new string(charArray);
    }

    return array;
}

string[] ShrinkStringArray(string[] array)
{
    Random random = new Random();
    int length = random.Next(0,3);
    string[] newArray = new string[length];
   
    for (int i = 0; i < length; i++)
    {
       int index = random.Next(0,array.Length);
       if (newArray.Contains(array[index]) && newArray[i] != null)
       {
        i--;
       }
        else
        {
            newArray[i] = array[index];
        }
    }
    return newArray;
}

string[] regularStringArray = CreateRandomStringArray(4,5);
Console.WriteLine(String.Join(",", regularStringArray));

string[] shrinkedStringArray = ShrinkStringArray(regularStringArray);
Console.WriteLine(String.Join(",", shrinkedStringArray));
