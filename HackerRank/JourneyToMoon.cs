using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // JourenyTestCaller();
            //QSortClass.QSortTestCaller();
          //  HashTableClass.HashTableTestCaller();
          GraphClass.GraphTestCaller();
        }
        public static void JourenyTestCaller()
        {
            long x = 0;
            // plusMinus(new List<int> { -4, 3, -9, 0, 4, 1 });
            List<List<int>> t1 = new List<List<int>>();
            t1.Add((new int[] { 5, 3 }).ToList());
            t1.Add((new int[] { 0, 1 }).ToList());
            t1.Add((new int[] { 2, 3 }).ToList());
            t1.Add((new int[] { 0, 4 }).ToList());
            x = journeyToMoon2(5, t1);
            Console.WriteLine(x);
            t1 = new List<List<int>>();
            t1.Add((new int[] { 10, 7 }).ToList());
            t1.Add((new int[] { 0, 2 }).ToList());
            t1.Add((new int[] { 1, 8 }).ToList());
            t1.Add((new int[] { 1, 4 }).ToList());
            t1.Add((new int[] { 2, 8 }).ToList());
            t1.Add((new int[] { 2, 6 }).ToList());
            t1.Add((new int[] { 3, 5 }).ToList());
            t1.Add((new int[] { 6, 9 }).ToList());
            x = journeyToMoon2(10, t1);
            Console.WriteLine(x);


            t1 = new List<List<int>>();
            t1.Add((new int[] { 100, 70 }).ToList());
            t1.Add((new int[] { 0, 11 }).ToList());
            t1.Add((new int[] { 2, 4 }).ToList());
            t1.Add((new int[] { 2, 95 }).ToList());
            t1.Add((new int[] { 3, 48 }).ToList());
            t1.Add((new int[] { 4, 85 }).ToList());
            t1.Add((new int[] { 4, 95 }).ToList());
            t1.Add((new int[] { 5, 67 }).ToList());
            t1.Add((new int[] { 5, 83 }).ToList());
            t1.Add((new int[] { 5, 42 }).ToList());
            t1.Add((new int[] { 6, 76 }).ToList());
            t1.Add((new int[] { 9, 31 }).ToList());
            t1.Add((new int[] { 9, 22 }).ToList());
            t1.Add((new int[] { 9, 55 }).ToList());
            t1.Add((new int[] { 10, 61 }).ToList());
            t1.Add((new int[] { 10, 38 }).ToList());
            t1.Add((new int[] { 11, 96 }).ToList());
            t1.Add((new int[] { 11, 41 }).ToList());
            t1.Add((new int[] { 12, 60 }).ToList());
            t1.Add((new int[] { 12, 69 }).ToList());
            t1.Add((new int[] { 14, 80 }).ToList());
            t1.Add((new int[] { 14, 99 }).ToList());
            t1.Add((new int[] { 14, 46 }).ToList());
            t1.Add((new int[] { 15, 42 }).ToList());
            t1.Add((new int[] { 15, 75 }).ToList());
            t1.Add((new int[] { 16, 87 }).ToList());
            t1.Add((new int[] { 16, 71 }).ToList());
            t1.Add((new int[] { 18, 99 }).ToList());
            t1.Add((new int[] { 18, 44 }).ToList());
            t1.Add((new int[] { 19, 26 }).ToList());
            t1.Add((new int[] { 19, 59 }).ToList());
            t1.Add((new int[] { 19, 60 }).ToList());
            t1.Add((new int[] { 20, 89 }).ToList());
            t1.Add((new int[] { 21, 69 }).ToList());
            t1.Add((new int[] { 22, 96 }).ToList());
            t1.Add((new int[] { 22, 60 }).ToList());
            t1.Add((new int[] { 23, 88 }).ToList());
            t1.Add((new int[] { 24, 73 }).ToList());
            t1.Add((new int[] { 27, 29 }).ToList());
            t1.Add((new int[] { 30, 32 }).ToList());
            t1.Add((new int[] { 31, 62 }).ToList());
            t1.Add((new int[] { 32, 71 }).ToList());
            t1.Add((new int[] { 33, 43 }).ToList());
            t1.Add((new int[] { 33, 47 }).ToList());
            t1.Add((new int[] { 35, 51 }).ToList());
            t1.Add((new int[] { 35, 75 }).ToList());
            t1.Add((new int[] { 37, 89 }).ToList());
            t1.Add((new int[] { 37, 95 }).ToList());
            t1.Add((new int[] { 38, 83 }).ToList());
            t1.Add((new int[] { 39, 53 }).ToList());
            t1.Add((new int[] { 41, 84 }).ToList());
            t1.Add((new int[] { 42, 76 }).ToList());
            t1.Add((new int[] { 44, 85 }).ToList());
            t1.Add((new int[] { 45, 47 }).ToList());
            t1.Add((new int[] { 46, 65 }).ToList());
            t1.Add((new int[] { 47, 49 }).ToList());
            t1.Add((new int[] { 47, 94 }).ToList());
            t1.Add((new int[] { 50, 55 }).ToList());
            t1.Add((new int[] { 51, 99 }).ToList());
            t1.Add((new int[] { 53, 99 }).ToList());
            t1.Add((new int[] { 56, 78 }).ToList());
            t1.Add((new int[] { 66, 99 }).ToList());
            t1.Add((new int[] { 71, 78 }).ToList());
            t1.Add((new int[] { 73, 98 }).ToList());
            t1.Add((new int[] { 76, 88 }).ToList());
            t1.Add((new int[] { 78, 97 }).ToList());
            t1.Add((new int[] { 80, 90 }).ToList());
            t1.Add((new int[] { 83, 95 }).ToList());
            t1.Add((new int[] { 85, 92 }).ToList());
            t1.Add((new int[] { 88, 99 }).ToList());
            t1.Add((new int[] { 88, 94 }).ToList());
            x = journeyToMoon2(100, t1);
            Console.WriteLine(x);

            t1 = new List<List<int>>();
            t1.Add((new int[] { 10, 20 }).ToList());
            t1.Add((new int[] { 0, 1 }).ToList());
            t1.Add((new int[] { 0, 3 }).ToList());
            t1.Add((new int[] { 0, 4 }).ToList());
            t1.Add((new int[] { 1, 2 }).ToList());
            t1.Add((new int[] { 1, 3 }).ToList());
            t1.Add((new int[] { 1, 5 }).ToList());
            t1.Add((new int[] { 1, 7 }).ToList());
            t1.Add((new int[] { 1, 8 }).ToList());
            t1.Add((new int[] { 1, 9 }).ToList());
            t1.Add((new int[] { 2, 8 }).ToList());
            t1.Add((new int[] { 2, 7 }).ToList());
            t1.Add((new int[] { 3, 5 }).ToList());
            t1.Add((new int[] { 3, 8 }).ToList());
            t1.Add((new int[] { 3, 7 }).ToList());
            t1.Add((new int[] { 4, 9 }).ToList());
            t1.Add((new int[] { 4, 5 }).ToList());
            t1.Add((new int[] { 4, 6 }).ToList());
            t1.Add((new int[] { 4, 7 }).ToList());
            t1.Add((new int[] { 6, 8 }).ToList());
            t1.Add((new int[] { 6, 7 }).ToList());
            x = journeyToMoon2(10, t1);
            Console.WriteLine(x);


            t1 = new List<List<int>>();
            t1.Add((new int[] { 100000, 2 }).ToList());
            t1.Add((new int[] { 1, 2 }).ToList());
            t1.Add((new int[] { 3, 4 }).ToList());
            x = journeyToMoon2(100000, t1);
            Console.WriteLine(x);

        }
        public static void plusMinus(List<int> arr)
        {
            int zeroCount = 0, postiveCount = 0, negativeCount = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == 0)
                {
                    zeroCount++;
                }
                else if (arr[i] > 0)
                {
                    postiveCount++;
                    //postive
                }
                else
                {
                    negativeCount++;
                    //negative

                }
            }
            Console.WriteLine(((decimal)postiveCount / arr.Count).ToString("N6"));
            Console.WriteLine(((decimal)negativeCount / arr.Count).ToString("N6"));
            Console.WriteLine(((decimal)zeroCount / arr.Count).ToString("N6"));
        }
        public static int journeyToMoon(int n, List<List<int>> astronaut)
        {
            astronaut.RemoveAt(0);
            List<List<int>> tempSameCountry = new List<List<int>>();
            foreach (var item in astronaut)
            {
                //c.SelectMany(x => x).Any(p => p == 2);
                var tempFirst = tempSameCountry.FirstOrDefault(c => c.Any(cc => cc == item[0]));
                var tempSecond = tempSameCountry.FirstOrDefault(c => c.Any(cc => cc == item[1]));
                if (tempFirst == null && tempSecond == null)
                {
                    //Not exist before 
                    tempSameCountry.Add(item);
                }
                else if (tempFirst == null)
                {
                    //First not exist
                    int index = tempSameCountry.IndexOf(tempSecond);
                    tempSecond.Add(item[0]);
                    tempSameCountry[index] = tempSecond;
                }
                else if (tempSecond == null)
                {
                    //Second not exist
                    int index = tempSameCountry.IndexOf(tempFirst);
                    tempFirst.Add(item[1]);
                    tempSameCountry[index] = tempFirst;
                }
                else if (tempFirst.Count > 0 && tempSecond.Count > 0)
                {
                    //two exist in sperate we need to merge
                    int index = tempSameCountry.IndexOf(tempFirst);
                    //remove
                    int index1 = tempSameCountry.IndexOf(tempSecond);
                    //check if not in the same row
                    if (index == index1)
                        continue;
                    tempFirst.AddRange(tempSecond);
                    tempSameCountry[index] = tempFirst;


                    tempSameCountry.RemoveAt(index1);
                }

            }
            /*

            foreach (var item in tempSameCountry)
            {
                Console.WriteLine(string.Join(",", item.Select(n => n.ToString()).ToArray()));
            }
            */
            int pairCount = 0;
            for (int i = 0; i < n; i++)
            {
                for (int ii = 0; ii < i; ii++)
                {
                    if (i <= ii)
                    {
                        //max sure 5,0 not with 0,5
                        continue;
                    }
                    var tempFirst = tempSameCountry.FirstOrDefault(c => c.FindAll(cc => cc == i || cc == ii).Count > 1);
                    //tempSameCountry.FindAll(c => c.FindAll(cc => cc == i || cc == ii).Count > 1);
                    if (tempFirst == null)
                    {
                        // Console.WriteLine(i.ToString() + "," + ii.ToString());
                        pairCount++;

                    }
                    else if (tempFirst.Count > 1)
                    {
                        //pairCount++;
                    }

                }
            }
            return pairCount;
        }

        public static long journeyToMoon2(int n, List<List<int>> astronaut)
        {
            astronaut.RemoveAt(0);
            List<List<int>> tempSameCountry = new List<List<int>>();
            foreach (var item in astronaut)
            {
                //c.SelectMany(x => x).Any(p => p == 2);
                var tempFirst = tempSameCountry.FirstOrDefault(c => c.Any(cc => cc == item[0]));
                var tempSecond = tempSameCountry.FirstOrDefault(c => c.Any(cc => cc == item[1]));
                if (tempFirst == null && tempSecond == null)
                {
                    //Not exist before 
                    tempSameCountry.Add(item);
                }
                else if (tempFirst == null)
                {
                    //First not exist
                    int index = tempSameCountry.IndexOf(tempSecond);
                    tempSecond.Add(item[0]);
                    tempSameCountry[index] = tempSecond;
                }
                else if (tempSecond == null)
                {
                    //Second not exist
                    int index = tempSameCountry.IndexOf(tempFirst);
                    tempFirst.Add(item[1]);
                    tempSameCountry[index] = tempFirst;
                }
                else if (tempFirst.Count > 0 && tempSecond.Count > 0)
                {
                    //two exist in sperate we need to merge
                    int index = tempSameCountry.IndexOf(tempFirst);
                    //remove
                    int index1 = tempSameCountry.IndexOf(tempSecond);
                    //check if not in the same row
                    if (index == index1)
                        continue;
                    tempFirst.AddRange(tempSecond);
                    tempSameCountry[index] = tempFirst;


                    tempSameCountry.RemoveAt(index1);
                }

            }

            BigInteger totalCombination = Combination(n);
            BigInteger lostedCombination = 0;
            foreach (var item in tempSameCountry)
            {
                lostedCombination += Combination(item.Count);
            }
            return (long)(totalCombination - lostedCombination);
        }
        public static BigInteger Factorial(int f)
        {
            if (f == 0)
                return 1;
            else
                return f * Factorial(f - 1);
        }
        public static BigInteger Combination(BigInteger f)
        {
            if (f == 1)
                return 1;
            else
                return f * (f - 1) / 2;
        }

    }
}

