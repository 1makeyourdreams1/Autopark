using System;

namespace ДЗ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания");
            Console.WriteLine("1 - 3.1");
            Console.WriteLine("2 - 3.2");
            Console.WriteLine("3 - 3.3");
            int nom = Convert.ToInt32(Console.ReadLine());
            switch(nom)
            {
                case 1:
                    int n = Convert.ToInt32(Console.ReadLine());
                    int p = Convert.ToInt32(Console.ReadLine());
                    double[] array = new double[n]; // Элементы массива вводятся через enter
                    for (int i = 0; i < n; ++i)
                    {
                        array[i] = Convert.ToDouble(Console.ReadLine());
                        
                    }
                    double S = 0;
                    for (int i = 0; i < n; ++i)
                    {
                        S += Math.Pow(array[i], p);
                    }
                    S = Math.Pow(S, Math.Pow(p, -1));
                    Console.WriteLine(S);
                    break;
                case 2:
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    double[] arr = new double[n1]; // Элементы массива вводятся через enter
                    for (int i = 0; i < n1; ++i)
                    {
                        arr[i] = Convert.ToDouble(Console.ReadLine());

                    }
                    int k = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введенный массив:\t");
                    for (int i = 0; i < n1; ++i)
                    {
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine();
                    for (int i = 0; i < n1 - 1; ++i)
                    {
                        for (int j = 0; j < n1 - i - 1; ++j)
                        {
                            if (arr[j] > arr[j + 1])
                            {
                                double t = arr[j];
                                arr[j] = arr[j + 1];
                                arr[j + 1] = t;
                            }
                        }
                    }
                    Console.Write("Отсортированный массив:\t");
                    for (int i = 0; i < n1; ++i)
                    {
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine();
                    Console.Write("Искомый минимум:\t");
                    Console.WriteLine(arr[k - 1]);
                    break;
                case 3:
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    double[] arr2 = new double[n2]; // Элементы массива вводятся через enter
                    for (int i = 0; i < n2; ++i)
                    {
                        arr2[i] = Convert.ToDouble(Console.ReadLine());

                    }
                    string s = Console.ReadLine();
                    string[] r = s.Split(':');
                    int start = Convert.ToInt32(r[0]), finish = Convert.ToInt32(r[1]), step = Convert.ToInt32(r[2]);
                    if (step > 0)
                    {
                        for (int i = start; i <= finish; i += step)
                        {
                            Console.Write(arr2[i] + " ");
                        }
                    }
                    else
                    {
                        for (int i = finish; i >= start; i += step)
                        {
                            Console.Write(arr2[i] + " ");
                        }
                    }
                    break;
            }
        Console.ReadKey();
        }
    }
}
