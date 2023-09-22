using System;
using System.Net.WebSockets;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        List<int> positives =  new List<int>();
        int new_number = -1;
        
        
        while (new_number!=0) 
        {

            Console.WriteLine("Please input a list of numbers if you don't want to just type '0' to stop.");
            new_number = int.Parse(Console.ReadLine());

            if (new_number== 0)
            {
                Console.WriteLine("Good bye!!");
                return;
                
            }

            else 
            {
                while (new_number != 0 )
                {
                    if (new_number !=0)
                    {
                        numbers.Add(new_number);

                        if (new_number>0)
                        {
                            positives.Add(new_number);
                        }

                    }
                Console.WriteLine("Enter a new numbers, if you don't want to just type '0' to stop.");
                new_number = int.Parse(Console.ReadLine());
                }
            }

            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    
                    max = number;
                }
            }

            Console.WriteLine($"The max is: {max}");


            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");

            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");


            int min = numbers[0];

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    
                    min = number;
                }
            }

            Console.WriteLine($"The min is: {min}");

            foreach (int number in numbers)
            {
            Console.WriteLine(number);
            }
        }   



    }

}