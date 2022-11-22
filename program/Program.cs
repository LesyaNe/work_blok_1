using System;
using static System.Console;
Clear();

WriteLine("Введите элементы массива через пробел: ");
string elements = ReadLine();
string[] baseArray = GetArrayFromString(elements);

WriteLine(String.Join(" ", ResultArray(baseArray)));

string[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string[] res = new string[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = Convert.ToString(nums[i]);
    }
    return res;
}

string[] ResultArray(string[] array)
{
    int size = array.Length;
    int count = 0;
    string[] result = new string[size];
      
    for (int i=0; i<array.Length; i++)
    {
        if (array[i].Length <=3 )
        {
            result[i] = array[i];
            count++;
        }
        
    }
    
    return result;
}

