// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("Dear User, pls intup your number, using (,) to separate digits ");
string inputData=Convert.ToString(Console.ReadLine());

 if (CheckData(inputData)==true)
    {
    Sum(StringToNum(inputData));
    }else{
    Console.WriteLine("Data incorret, pls try againe");
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
           //Console.WriteLine("Data corret");
           }
           else
           {
            //Console.WriteLine("Data incorret, pls try againe");
            i=size;
            check = false;
            }
        }
        if (check==true) return true;
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
void Sum (int [] array)
    {
    int sum= 0;
    for(int i=0; i<array.Length; i++)
        {
            if(array[i]>0)
            {
                sum+=array[i];
            }    
        }
    Console.WriteLine($"Sun of positive numbers {sum}");    
    }
    */

    //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    //y = k1 * x + b1, y = k2 * x + b2

Console.WriteLine(" Ill try to find cross point of two lines. y = k1 * x + b1 and  y = k2 * x + b2");
    Console.WriteLine("Pls input k1");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Pls input b1");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Pls input k2");
    int k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Pls input b2");
    int b2 = Convert.ToInt32(Console.ReadLine());
    CrossCor(k1,b1,k2,b2);

void CrossCor(int k1,int b1,int k2,int b2)
{
int [] Result = new int  [2];  
if (k1==k2)
    {
        Console.WriteLine("Lines is parallel");
    }
    else
    {
        Result[0]=(b2-b1)/(k2-k1);
        Result[1]=k1*Result[0]+b1;
        Console.WriteLine($"Coordinate of cross ({Result[0]},{Result[1]})");
    }    
}