using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("1. Bài 1");
            Console.WriteLine("2. Bài 2");
            Console.WriteLine("3. Bài 3");
            Console.Write("\n\n\n\n\n\t\t\t\t\nNhập lựa chọn của bạn: ");
            String s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    b1();
                    break;
                case "2":
                    b2();
                    break;

                case "3":
                    b3();
                    break;

            }
            Console.Clear();
            Console.ReadKey();
        }
        static void b1()
        {
            Console.WriteLine("1. 1 chiều");
            Console.WriteLine("2. 2 chiều");
            Console.Write("\n\n\n\n\n\t\t\t\t\nNhập lựa chọn của bạn: ");
            String s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    Console.WriteLine("nhập số phần tử của mảng ");
                    int so = int.Parse(Console.ReadLine());
                    int[] arr1 = new int[so];
                    for (int i = 0; i < so; i++)
                    {

                        Console.WriteLine("Phan tu - {0}:", i);
                        arr1[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Các phần tử của mảng :");
                    for (int i = 0; i < so; i++)
                        Console.WriteLine("{0} ", arr1[i]);
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("nhập kích cỡ mảng 2 chiều");
                    Console.WriteLine("chiều 1");
                    int c1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("chiều 2");
                    int c2 = int.Parse(Console.ReadLine());
                    int[,] arr2 = new int[c1, c2];
                    for (int i = 0; i < c1; i++)
                    {
                        for (int j = 0; j < c2; j++)
                        {
                            Console.WriteLine("Phần tử số {0},{1}", i, j);
                            arr2[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < c1; i++)
                    {
                        for (int j = 0; j < c2; j++)
                        {
                            Console.WriteLine("phần tử số :[" + i + "][" + j + "] = " + arr2[i, j]);
                        }
                    }

                    Console.ReadKey();
                    break;

            }
        }
        static void b2()
        {
            Console.WriteLine("1. 1 chiều");
            Console.WriteLine("2. 2 chiều");
            Console.Write("\n\n\n\n\n\t\t\t\t\nNhập lựa chọn của bạn: ");
            String s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    Console.WriteLine("nhập số phần tử của mảng ");
                    int so = int.Parse(Console.ReadLine());
                    int[] arr1 = new int[so];
                    Console.WriteLine("Nhập giá trị bé nhất để ngẫu nhiên");
                    int rmin = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập giá trị lớn nhất để ngẫu nhiên");
                    int rmax = int.Parse(Console.ReadLine());
                    Random r = new Random();
                    for (int i = 0; i < so; i++)
                    {
                        int nn = r.Next(rmin, rmax);
                        Console.WriteLine("Phan tu - {0}: {1}", i, nn);
                        arr1[i] = nn;
                    }
                    Console.WriteLine("Các phần tử của mảng :");
                    for (int i = 0; i < so; i++)
                        Console.WriteLine("{0} ", arr1[i]);
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("nhập kích cỡ mảng 2 chiều");
                    Console.WriteLine("chiều 1");
                    int c1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("chiều 2");
                    int c2 = int.Parse(Console.ReadLine());
                    int[,] arr2 = new int[c1, c2];
                    Console.WriteLine("Nhập giá trị bé nhất để ngẫu nhiên");
                    int rmin2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập giá trị lớn nhất để ngẫu nhiên");
                    int rmax2 = int.Parse(Console.ReadLine());
                    Random r2 = new Random();
                    for (int i = 0; i < c1; i++)
                    {
                        for (int j = 0; j < c2; j++)
                        {
                            int nn = r2.Next(rmin2, rmax2);
                            Console.WriteLine("Nhập phần tử - {0}: {1}", i, nn);
                            arr2[i, j] = nn;

                        }
                    }
                    Console.WriteLine("Mảng cừa được tạo là :");
                    for (int i = 0; i < c1; i++)
                    {
                        for (int j = 0; j < c2; j++)
                        {
                            Console.WriteLine("phần tử số :[" + i + "][" + j + "] = " + arr2[i, j]);
                        }
                    }

                    Console.ReadKey();
                    break;



            }
        }
        static void b3()
        {
            Console.WriteLine("1. 1 chiều");
            Console.WriteLine("2. 2 chiều");
            Console.Write("\n\n\n\n\n\t\t\t\t\nNhập lựa chọn của bạn: ");
            String s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    Console.WriteLine("nhập số phần tử của mảng ");
                    int so = int.Parse(Console.ReadLine());
                    int[] arr1 = new int[so];
                    for (int i = 0; i < so; i++)
                    {

                        Console.WriteLine("Phan tu - {0}: ", i);
                        arr1[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Các phần tử của mảng :");
                    for (int i = 0; i < so; i++)
                        Console.WriteLine("{0} ", arr1[i]);
                    Console.ReadKey();
                    int mx = arr1[0];
                    int mn = arr1[0];

                    for (int i = 1; i < so; i++)
                    {
                        if (arr1[i] > mx)
                        {
                            mx = arr1[i];
                        }


                        if (arr1[i] < mn)
                        {
                            mn = arr1[i];
                        }
                    }
                    Console.Write("Phần tử lớn nhất trong mảng là {0}\n", mx);
                    Console.Write("Phần tử nhỏ nhất trong mảng là {0}\n", mn);
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("nhập kích cỡ mảng 2 chiều");
                    Console.WriteLine("chiều 1");
                    int c1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("chiều 2");
                    int c2 = int.Parse(Console.ReadLine());
                    int[,] arr2 = new int[c1, c2];
                    for (int i = 0; i < c1; i++)
                    {
                        for (int j = 0; j < c2; j++)
                        {
                            Console.WriteLine("Phần tử số {0},{1}", i, j);
                            arr2[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < c1; i++)
                    {
                        for (int j = 0; j < c2; j++)
                        {
                            Console.WriteLine("phần tử số :[" + i + "][" + j + "] = " + arr2[i, j]);
                        }
                    }

                    Console.ReadKey();
                    int max = arr2[0,0];
                    int min = arr2[0,0];
                    for (int i = 0; i < c1; i++)
                    {


                        for (int j = 0; j < c2; j++)
                        {
                            if (max < arr2[i, j])
                            max = arr2[i, j];
                            if (min > arr2[i, j])
                                min = arr2[i, j];
                        }
                    }
                    Console.Write("Phần tử lớn nhất trong mảng là {0}\n", max);
                    Console.Write("Phần tử nhỏ nhất trong mảng là {0}\n", min);
                    Console.ReadKey();
                    break;

            }
        }
    }
}
