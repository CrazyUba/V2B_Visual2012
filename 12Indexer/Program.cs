using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary myDic = new MyDictionary();

            myDic["Uli"] = 46;
            myDic["Tanja"] = 43;
            //myDic["Uli"] = 47;

            Console.WriteLine("Alter Uli: " + myDic["Uli"] + " / Alter Tanja: " + myDic["Tanja"] );
            
        }
    }
}
