// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Dear User, pls intup your number, using (,) to separate digits ");
string inputData=Convert.ToString(Console.ReadLine());

 if (CheckData(inputData)=true)
    {


    }  

bool CheckData(string inputData)
    {
    int size = inputData.Length;    //количество символов в строке
    //Console.WriteLine(size);      //проверка 
    bool check= true;
    for (int i=0; i<size;i++)       //цикло проверки на корректность ввода
        {
        int digit=Convert.ToInt32(inputData[i]);
           if(digit==44 || digit==45 || ((digit>47) && (digit < 58)))
           {
           Console.WriteLine("Data corret");
           }
           else
           {
            Console.WriteLine("Data incorret, pls try againe");
            i=size;
            check = false;
            }
        }
        if (check=true) return true;
        else return false;
    }
int QuontityOfNums(string inputData)
    {
    int qty =1;
    int size = inputData.Length; 
        for(int i=0; i<size; i++)
            {
                 if(inputData[i]==44) 
                 {qty+=1;}
            }

    return qty;
    }
int [] StringToNum(string Data)
    {
    int [] number = new int [QuontityOfNums(Data)];
    int index=0;
    string temp =string.Empty;
     inputData=inputData+",";
    int size = inputData.Length;
    Console.WriteLine(inputData);
        for(int i=0; i<size;i++)
            {
                if (inputData[i] != 44)
                {
                        temp=temp+inputData[i].ToString();
                }
                else
                {
                   number[index]=Convert.ToInt32(temp);
                   index++;
                   temp=string.Empty;
                }
            }
    return number;    
    }
// void ShowArray(int [] array)
//     {
//         for (int i=0; i<array.Length; i++)
//         {
//             Console.Write(array[i] + " ");
//         }
//         Console.WriteLine();
//     }
// Console.Write("Введите числа через запятую: ");
// int[] numbers = StringToNum(Console.ReadLine());
// PrintArray(numbers);
// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"количество значений больше 0 = {sum}");


// int[] StringToNum(string input)
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//         {
//             count++;
//         }
//     }

//     int[] numbers = new int [count];
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input [i] != ',')
//         {
//         if(i != input.Length - 1)
//         {
//             temp += input [i].ToString();
//             i++;
//         }
//         else
//         {
//             temp += input [i].ToString();
//             break;
//         }
//         }
//         numbers[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return numbers;
// }


// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }