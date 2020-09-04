using System;

namespace Task_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[0];
            int sum = 0;            
            bool enterOrExit = true;
            string userInput;

            while (enterOrExit)
            {
                Console.WriteLine("add - добавить число");
                Console.WriteLine("sum - выводит сумму всех добавленых чисел");
                Console.WriteLine("info - выводит все добавленые числа");
                Console.WriteLine("exit - выход");

                switch (Console.ReadLine())
                {
                    case "add":
                        int[] tempArray = new int[array.Length + 1];

                        for (int i = 0; i < array.Length; i++)
                        {
                            tempArray[i] = array[i]; 
                        }                        
                        Console.Write("Введите желаемое число : ");
                        tempArray[tempArray.Length - 1] = Convert.ToInt32(Console.ReadLine());
                        array = tempArray;
                        break;
                    case "sum":                        
                        for (int i = 0; i < array.Length; i++)
                        {
                            sum += array[i];
                        }
                        Console.WriteLine($"Сумма всех введеных чисел : {sum}");
                        Console.ReadKey();                        
                        break;
                    case "info":
                        if (array.Length > 0)
                        {
                            for (int i = 0; i < array.Length; i++)
                            {
                                Console.Write(array[i] + " | ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("У вас нет добавленых чисел");
                        }
                        Console.ReadKey();
                        break;
                    case "exit":
                        enterOrExit = false;
                        break;
                }
                sum = 0;
                Console.Clear();
            }
        }
    }
}
