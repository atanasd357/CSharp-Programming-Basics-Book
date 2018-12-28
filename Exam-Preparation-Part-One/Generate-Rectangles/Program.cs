using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 12

namespace Generate_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter minimal area: ");
            int m = int.Parse(Console.ReadLine());

            int count = 0;

            for (int left = -n; left < n; left++)
            {
                for (int top = -n; top < n; top++)
                {
                    for (int right = left+1; right <= n; right++)
                    {
                        for (int bottom = top+1; bottom <= n; bottom++)
                        {
                            int area = Math.Abs(right - left) * Math.Abs(bottom - top);

                            if (area >= m)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", 
                                    left, top, right, bottom, area);
                                count++;
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
