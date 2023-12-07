using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestion2
{
    class Result
    {
        /*
         * Complete the 'countMaximumProfitableGroups' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts INTEGER_ARRAY stockPrice as parameter.
         */

        public static long countMaximumProfitableGroups(List<int> stockPrice)
        {
            long count = 0;
            List<List<int>> subArrayList=new List<List<int>>();

            for (int i = 0; i < stockPrice.Count; i++)
            {
                List<int> subList = new List<int>();
                for (int j=i;j< stockPrice.Count;j++)
                {
                    subList.Add(stockPrice[j]);
                    subArrayList.Add(new List<int>(subList));
                }
            }

            count = subArrayList.Count;
            foreach (List<int> list in subArrayList)
            {
                if(list.Count > 2)
                {
                    int maxEle=Math.Max(list.ElementAt(0), list.ElementAt(list.Count-1));
                    for(int i=1;i<list.Count-1;i++) 
                    { 
                        if(list.ElementAt(i)>maxEle)
                        {
                            count--;break;
                        }
                    }
                }
            }
            return count;

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int stockPriceCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> stockPrice = new List<int>() { 3,1,3,5 };

            //for (int i = 0; i < stockPriceCount; i++)
            //{
            //    int stockPriceItem = Convert.ToInt32(Console.ReadLine().Trim());
            //    stockPrice.Add(stockPriceItem);
            //}

            long result = Result.countMaximumProfitableGroups(stockPrice);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
