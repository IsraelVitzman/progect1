using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    internal class Program
    {
        List<int> list = new List<int>();

        
        public void addToList(string add)
        {
            if (isEmpty())
            {
                
                return;
            }
            if (!isNumber(add))
            {
                Console.WriteLine("enter num bitwine 0-9");
                return;
            }

            if (!positiv(add) || !thanThree(add))
            {
                Console.WriteLine("chaek the number if is positiv or biger from 3");
                return;
            }

            
            foreach (char c in add)
            {
                list.Add(int.Parse(c.ToString()));
            }
        }
        public bool isEmpty()
        {
            return list.Count == 0;
        }
       
        public bool isNumber(string str)
        {
            return str.All(char.IsDigit);
        }

        
        public bool thanThree(string add)
        {
            return add.Length > 3;
        }

        
        public bool positiv(string add)
        {
            foreach (char item in add)
            {
                int digit = (int)char.GetNumericValue(item);
                if (digit < 0)
                {
                    return false;
                }
            }
            return true;
        }

        
        public void reversToNumber()
        {
            if (isEmpty()) {
                Console.WriteLine("isEmpty! plese enter number ");
                return;
            }
            Console.WriteLine("revers to number:");
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }

        
        public void sort()
        {
            if (isEmpty())
            {
                Console.WriteLine("isEmpty! plese enter number ");
                return;
            }
            int temp = 0;
            for (int i = 0; i < list.Count -1; i++)
            { 
                for (int j = 0; j<list.Count-1-i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("sort the list:");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        
        public void maxNumber()
        {
            if (isEmpty())
            {
                Console.WriteLine("isEmpty! plese enter number ");
                return;
            }
            int max = 0;
            foreach (int num in list)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"the max: {max}");
        }

        
        public void minNumber()
        {
            if (isEmpty())
            {
                Console.WriteLine("isEmpty! plese enter number ");
                return;
            }
            int min = list[0];
            foreach (int num in list)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine($"the ninimum: {min}");
        }

       
        public void avergeNumber()
        {
            if (isEmpty())
            {
                Console.WriteLine("isEmpty! plese enter number ");
                return;
            }
            int averge=list.Count;
            int som = somNumber();
            double result = 0;

            result = (double)som / averge;
            Console.WriteLine($"Average: {result}");
        }

        
        public void somElements()
        {
            if (isEmpty())
            {
                Console.WriteLine("isEmpty! plese enter number ");
                return;
            }
            Console.WriteLine($"som elements from list: {list.Count}");
        }

       
        public int somNumber()
        {
            if (isEmpty())
            {
                Console.WriteLine("isEmpty! plese enter number ");
                return -1;
            }
            int sum = 0;
            foreach (int num in list)
            {
                sum += num;
            }
            Console.WriteLine($"som number: {sum}");
            return sum;
        }

        
        

        static void Main(string[] args)
        {
           
            Program program = new Program();
            bool continueRunning = true;

            if (args.Length == 0)
            {
                Console.WriteLine("plese enter arg'...");
                return;
            }

            
            string argsInput = string.Join("", args);
            program.addToList(argsInput);


            while (continueRunning)
            {

                Console.WriteLine("\nSelect an action:");
                Console.WriteLine("1 - Add a new series");
                Console.WriteLine("2 - Display the series");
                Console.WriteLine("3 - Reverse the series");
                Console.WriteLine("4 - Sort the series");
                Console.WriteLine("5 - Show the largest number");
                Console.WriteLine("6 - Show the smallest number");
                Console.WriteLine("7 - Show the average");
                Console.WriteLine("8 - Show the number of elements");
                Console.WriteLine("9 - Show the sum of the series");
                Console.WriteLine("10 - Exit");


                var command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                    
                        Console.WriteLine("enter new list:");
                        string newInput = Console.ReadLine();
                        program.list.Clear(); 
                        program.addToList(newInput); 
                        break;


                        

                    case "2":
                        Console.WriteLine("the list ...:");
                        if (program.isEmpty())
                        {
                            Console.WriteLine("is empty");
                            return;
                        }
                        foreach (int item in program.list)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case "3":
                        program.reversToNumber();
                        break;

                    case "4":
                        program.sort();
                        break;

                    case "5":
                        program.maxNumber();
                        break;

                    case "6":
                        program.minNumber();
                        break;

                    case "7":
                        program.avergeNumber();
                        break;

                    case "8":
                        program.somElements();
                        break;

                    case "9":
                        program.somNumber();
                        break;

                    case "10":
                        Console.WriteLine("thenk you!");
                        continueRunning = false;
                        break;

                    default:
                        Console.WriteLine("invalid selction");
                        break;
                }
            }
        }
    }
}
