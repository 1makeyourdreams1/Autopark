using System;

namespace ДЗ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания");
            Console.WriteLine("1.1 - 1 ");
            Console.WriteLine("1.2 - 2 ");
            Console.WriteLine("1.3 - 3 не сделал :(  ");
            Console.WriteLine("1.4 - 4 ");
            Console.WriteLine("2.1 - 5 ");
            Console.WriteLine("2.2 - 6 ");
            Console.WriteLine("2.3 - 7 ");
            Console.WriteLine("2.4 - 8 ");
            Console.WriteLine("2.5 - 9 ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    for (int i = 4; i < 10; ++i)
                    {
                        for (int j = i - 1; j >= 0; --j)
                        {
                            for (int k = j - 1; k >= 0; --k)
                            {
                                for (int l = k - 1; l >= 0; --l)
                                {
                                    Console.WriteLine(i * 1000 + j * 100 + k * 10 + l);
                                }
                            }
                        }
                    }
                    break;
                case 2:
                    int n = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < n; ++i)
                    {
                        for (int j = n - i; j <= n; ++j)
                        {
                            Console.Write(j + " ");
                        }
                        for (int k = n - 1; k > i; --k)
                            Console.Write(k + " ");
                        Console.WriteLine();

                    }
                    break;
                case 3:
                    int x1 = Convert.ToInt32(Console.Read()), y1 = Convert.ToInt32(Console.ReadLine());
                    int x2 = Convert.ToInt32(Console.Read()), y2 = Convert.ToInt32(Console.ReadLine());
                    int x3 = Convert.ToInt32(Console.Read()), y3 = Convert.ToInt32(Console.ReadLine());

                    break;
                case 4:
                    int p = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < p; ++i)
                    {
                        long c = 1;
                        for (int k = 0; k <= i; k++)
                        {
                            Console.Write(c + " ");
                            c = c * (i - k) / (k + 1);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 5:
                    int a = Convert.ToInt32(Console.ReadLine());
                    string s = "";
                    while (a != 0)
                    {
                        s = (a & 1) + s;
                        a >>= 1;
                    }
                    Console.WriteLine(s);
                    break;
                case 6:
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    int n3 = n1 + n2;
                    string s1 = "", s2 = "", s3 = "";
                    while (n1 != 0)
                    {
                        s1 = (n1 & 1) + s1;
                        n1 >>= 1;
                    }
                    while (n2 != 0)
                    {
                        s2 = (n2 & 1) + s2;
                        n2 >>= 1;
                    }
                    while (n3 != 0)
                    {
                        s3 = (n3 & 1) + s3;
                        n3 >>= 1;
                    }
                    int l1 = s3.Length - s1.Length;
                    int l2 = s3.Length - s2.Length;

                    for (int i = 0; i < l2; ++i)
                    {
                        s2 = '0' + s2;
                    }
                    for (int i = 0; i < l1; ++i)
                    {
                        s1 = '0' + s1;
                    }
                    Console.WriteLine(s1);
                    Console.WriteLine(s2);
                    for (int i = 0; i < s3.Length; ++i)
                    {
                        Console.Write('.');
                    }
                    Console.WriteLine();
                    Console.WriteLine(Convert.ToInt64(s3));
                    break;
                case 7:
                    short r1 = Convert.ToInt16(Console.ReadLine());
                    short r2 = Convert.ToInt16(Console.ReadLine());
                    short r3 = Convert.ToInt16(Console.ReadLine());
                    short r4 = Convert.ToInt16(Console.ReadLine());
                    string str1 = "", str2 = "", str3 = "", str4 = "";
                    while (r1 != 0)
                    {
                        str1 = (r1 & 1) + str1;
                        r1 >>= 1;
                    }
                    while (r2 != 0)
                    {
                        str2 = (r2 & 1) + str2;
                        r2 >>= 1;
                    }
                    while (r3 != 0)
                    {
                        str3 = (r3 & 1) + str3;
                        r3 >>= 1;
                    }
                    while (r4 != 0)
                    {
                        str4 = (r4 & 1) + str4;
                        r4 >>= 1;
                    }
                    int len1 = 8 - str1.Length;
                    int len2 = 8 - str2.Length;
                    int len3 = 8 - str3.Length;
                    for (int i = 0; i < len1; ++i)
                    {
                        str1 = '0' + str1;
                    }
                    for (int i = 0; i < len2; ++i)
                    {
                        str2 = '0' + str2;
                    }
                    for (int i = 0; i < len3; ++i)
                    {
                        str3 = '0' + str3;
                    }
                    long ans = Convert.ToInt64(str4 + str3 + str2 + str1, 2);

                    Console.WriteLine(ans);
                    break;
                case 8:
                    long num1 = Convert.ToInt64(Console.ReadLine());
                    string ss = "";
                    while (num1 != 0)
                    {
                        ss = (num1 & 1) + ss;
                        num1 >>= 1;
                    }
                    while (ss.Length > 8)
                    {
                        Console.Write(Convert.ToInt32(ss.Substring(ss.Length - 8, 8), 2));
                        Console.Write(" ");
                        ss = ss.Substring(0, ss.Length - 8);
                    }
                    Console.Write(Convert.ToInt16(ss, 2));
                    break;
                case 9:
                    int[] mas = new int[5];
                    long num2 = Convert.ToInt64(Console.ReadLine()); // Символы считываются не в одну строчку
                    short m1 = Convert.ToInt16(Console.ReadLine());
                    short k1 = Convert.ToInt16(Console.ReadLine());
                    string sss = "", pr = "";
                    long h;
                    while (num2 != 0)
                    {
                        h = num2 >> 4 << 4;
                        for (int i = 0; i <= 15; ++i)
                        {
                            if ((num2 ^ i)  ==  h)
                            {
                                pr = i + pr;
                            }
                        }
                        num2 = num2 >> 4;
                    }
                    pr = '0' + pr;
                    char[] b = pr.ToCharArray();
                    char t = b[m1 - 1];
                    b[m1 - 1] = b[k1 - 1];
                    b[k1 - 1] = t;
                    int u;
                    string per = "";
                    for (int i = 0; i < b.Length; ++i)
                    {
                        per = "";
                        u = Convert.ToInt32(b[i]) - '0';
                        while (u != 0)
                        {
                            per = (u & 1) + per;
                            u >>= 1;
                        }
                        while (per.Length < 4)
                        {
                            per = '0' + per;
                        }
                        sss += per;
                    }
                    Console.WriteLine(Convert.ToInt64(sss, 2));
                    break;
            }
            Console.ReadKey();
        }
    }
}
