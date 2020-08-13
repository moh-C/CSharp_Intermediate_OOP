using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxUnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Mammad");
            arrayList.Add(DateTime.Today);
            // arraList.Add(object obj) so it's getting downcasted and well, boxed!
            // Which is not a good thing
            // int nameInt = (int) arrayList[1] which is an exception

            var nameList = new List<string>();
            nameList.Add("MC");
            nameList.Add("Moh");

        }
    }
}
