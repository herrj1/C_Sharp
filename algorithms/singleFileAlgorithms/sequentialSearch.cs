//Function only. Driver program needs to be added
bool sequentialSearch(int[] arr, int sValue){
	for(index = 0; index < arr.Length - 1; index++){
		if(arr[index] == sValue){
			return true;
		}
	}
	return false;
}