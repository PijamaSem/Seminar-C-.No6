// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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
    Console.WriteLine($"Сумма положительных чисел {sum}");    
    }