//naive recursive
static int fibonacciNaiveRecursive(int n){
	if(n == 0) return 0;
	if(n == 1) return 1;
	return fibonacciNaiveRecursive(n - 1) + fibonacciNaiveRecursive(n - 2);
}