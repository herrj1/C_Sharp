//optimized recursive with dictionary
static Dictionary<int> result = new Dictionary<int>();

static int fibonacciRecursiveDict(int n){
	if(n == 0) return 0;
	if(n == 1) return 1;
	if(result.ContainsKey(n)){
		return result[n];
	}
	
	int resultFib = fibonacciRecursiveDict(n - 1) + fibonacciRecursiveDict(n - 2);
	result[n] = resultFib;
	
	return result;
}