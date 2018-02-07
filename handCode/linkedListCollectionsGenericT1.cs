using System;
using System.Collections;
using System.Collections.Generic;

public class linkedListCollectionsGenericT1{
	public static void Main(){
		LinkedList<String> calcTheorems = new LinkedList<String>();
		calcTheorems.AddLast("Limits");
		calcTheorems.AddLast("The Derivative");
		calcTheorems.AddLast("The Chain Rule");
		calcTheorems.AddLast("L'Hopital's Theorem");
		calcTheorems.AddLast("Rolles Theorem");
		calcTheorems.AddLast("The Fundamental Theorem of Calculus");
		
		if(calcTheorems.Count > 0){
			Console.WriteLine("The theorem is {0}.", calcTheorems.First.Value);
			Console.WriteLine("The theorem is {0}.", calcTheorems.Last.Value);
			Console.WriteLine("The theorems in this list are: ");
			foreach(String s in calcTheorems){
				Console.WriteLine("	{0}", s);
			}
		}else{
			Console.WriteLine("There are no theorems in the list.");
		}
	}
}