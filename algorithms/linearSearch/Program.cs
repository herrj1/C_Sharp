using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace linearSearch
{
    class Program
    {
		public static int LinearSearch(ref int[] x, int valueToFind)
		{
			for(int i = 0; i < x.Length; i++){
				if(valueToFind == x[i]){
					return i;
				}
			}
			return -1;
			
		}
		
		public static void DisplayElements(ref int[] xArray, char status, string sortname)
		{
			if(status == 'a')
			{
				Console.WriteLine("After algorithm usage: "+ sortname);
			}else{
				Console.WriteLine("Before sorting.");
			}
			
			for(int i = 0; i <= xArray.Length - 1; i++)
			{
				if((i != 0) && (i % 10 == 0))
				{
					Console.Write("\n");
				}
				Console.Write(xArray[i] + " ");
			}
			Console.ReadLine();
		}
		
		static void MixDataUp(ref int[] x, Random rdn)
		{
			for(int i = 0; i <= x.Length - 1; i++)
			{
				x[i] = (int)(rdn.NextDouble() * x.Length);
			}
		}
		
        static void Main(string[] args)
        {
			const int nItems = 50;
			Random rdn = new Random(nItems);
			int[] xdata = new int[nItems];
			MixDataUp(ref xdata, rdn);
			DisplayElements(ref xdata, 'b', "");
			
            Console.WriteLine("Linear search algorithm: ");
			
			int location = LinearSearch(ref xdata, xdata[5]);
			if(location == -1)
			{
				Console.WriteLine("Value not found.");
			}else{
				Console.WriteLine("Location found = {0}", location);
			}
			location = LinearSearch(ref xdata, 17);
			if(location == -1){
				Console.WriteLine("Value not found.");
			}else{
				Console.WriteLine("Value found {0}", location);
			}
			Console.WriteLine("\n\n");
        }
    }
}
