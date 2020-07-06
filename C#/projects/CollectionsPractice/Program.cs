using System.Collections.Generic;
using System;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringarray;
            stringarray=new string[]{"tim","martin","nikki","sara"};

            int[] numarray;
            numarray=new int[]{0,1,2,3,4,5,6,7,8,9};

            bool[] boolarray;
            boolarray=new bool[]{true,false,true,false,true,false,true,false,true,false};
            Console.WriteLine(numarray[3]);
            Console.WriteLine(stringarray[3]);

            List<string> iceCreamFlavors = new List<string>();
            iceCreamFlavors.Add("chocolate");
            iceCreamFlavors.Add("vanilla");
            iceCreamFlavors.Add("mint n chip");
            iceCreamFlavors.Add("black cherry");
            iceCreamFlavors.Add("snikers");
            iceCreamFlavors.RemoveAt(3);
            Console.WriteLine(iceCreamFlavors[3]);
            foreach(string flavor in iceCreamFlavors)
            {
                Console.WriteLine(flavor);
            }
        }
    }
}
