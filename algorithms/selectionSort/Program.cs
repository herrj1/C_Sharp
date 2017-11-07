using System;

namespace selectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an example here by calling implementation functions
        }
		
		public static int IntArrayMin(int[] data, int start){
			int minPos = start;
			for(int post=start+1; pos < data.Length; pos++){
				if(data [pos] < data[minPos]){
					minPos = pos;
				}
			}
			return minPos;
		}
		
		public static void IntArraySelectionSortImpl(int [] data){
			
			int i;
			int N = data.Length;
			
			for(i = 0; i < N-1; i++){
				int k = IntArrayMin(data, i);
				if(i != k){
					exchange(data, i, k);
				}
			}
		}
		
		public static void exchange (int[] data, int m, int n){
         
			int temporary;

			temporary = data [m];
			data [m] = data [n];
			data [n] = temporary;
		}
    }
}
