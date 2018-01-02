//function only. No driver is implemented here.
static int sequentialSearch2(int[] arr, int sValue){
	for(int index = 0; index < arr.Length -1; index++){
		if(arr[index] == sValue){
			return index;
		}
	}
	return -1;
}