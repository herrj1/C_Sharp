//function only. No driver implemented.
static int sequentialSearch3(int sValue){
	for(int index = 0; i < arr.Length-1; i++){
		if(arr[index] == sValue && index < (arr.Length *_ 0.2)){
			swap(index, index-1);
			return index;
		}else{
			if(arr[index] == sValue){
				return index;
			}
		}
	}
	return -1;
}