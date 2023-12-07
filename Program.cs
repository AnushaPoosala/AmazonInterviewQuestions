using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestion1Solution
{
    internal class Program
    {
        public static List<int> getTrucksForItems(List<int> trucks, List<int> items)
        {
            //trucks={4,5,7,2} items={1,2,5} result list={3,0,2}
            Dictionary<int,int> trucksWithIndexCapacity = new Dictionary<int,int>();

            for(int i=0;i<trucks.Count;i++)
            {
                trucksWithIndexCapacity.Add(i, trucks[i]);
            }
            trucksWithIndexCapacity = trucksWithIndexCapacity.OrderBy(x => x.Value)
                                      .ToDictionary(x => x.Key, x => x.Value);

            for(int i=0;i<items.Count;i++)
            {
                foreach(KeyValuePair<int,int> pair in trucksWithIndexCapacity)
                {
                    int index=pair.Key;

                    if (pair.Value > items[i])
                    {
                        trucksWithIndexCapacity[index] = pair.Value - items[i];
                        break;
                    }    

                }
            }

            List<int> result = new List<int>();

            foreach (KeyValuePair<int,int> pair in trucksWithIndexCapacity)
            {
                if (pair.Value != trucks[pair.Key])
                {
                    result.Add(pair.Key); ;
                     
                }
                    
            }


            return result;
        }
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //Console.WriteLine("Enter trucksCount here:");//added by me
            //int trucksCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> trucks = new List<int>() {4,5,7,2};

            //Console.WriteLine("enter trucksitems capacity foreach truck for above trucksCount");//added by me
            //for (int i = 0; i < trucksCount; i++)
            //{
            //    int trucksItem = Convert.ToInt32(Console.ReadLine().Trim());
            //    trucks.Add(trucksItem);
            //}

            Console.WriteLine("enter itemsCount");
            //int itemsCount = Convert.ToInt32(Console.ReadLine().Trim());


            List<int> items = new List<int>() {1,2,5 };

            //Console.WriteLine("enter itemsItem as per above itemsCount");
            //for (int i = 0; i < itemsCount; i++)
            //{
            //    int itemsItem = Convert.ToInt32(Console.ReadLine().Trim());
            //    items.Add(itemsItem);
            //}

            List<int> result = Program.getTrucksForItems(trucks, items);

            //textWriter.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
            Console.WriteLine(String.Join("\n", result)); ; 
        }
    }
}
///*
// Question1 :
//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;


//class Result
//{

//    /*
//     * Complete the 'getTrucksForItems' function below.
//     *
//     * The function is expected to return an INTEGER_ARRAY.
//     * The function accepts following parameters:
//     *  1. INTEGER_ARRAY trucks
//     *  2. INTEGER_ARRAY items
//     */

//public static List<int> getTrucksForItems(List<int> trucks, List<int> items)
//{

//}

//}
//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int trucksCount = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> trucks = new List<int>();

//        for (int i = 0; i < trucksCount; i++)
//        {
//            int trucksItem = Convert.ToInt32(Console.ReadLine().Trim());
//            trucks.Add(trucksItem);
//        }

//        int itemsCount = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> items = new List<int>();

//        for (int i = 0; i < itemsCount; i++)
//        {
//            int itemsItem = Convert.ToInt32(Console.ReadLine().Trim());
//            items.Add(itemsItem);
//        }

//        List<int> result = Result.getTrucksForItems(trucks, items);

//        textWriter.WriteLine(String.Join("\n", result));

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}




