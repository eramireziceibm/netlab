// See https://aka.ms/new-console-template for more information
int GeneradorLinealCongruente(int _numberiter, int seed){
	// programa PRNG basico, es inutilizable para criptografia.
	// En caso de requerir criptografia, utilizar CSPRNG
    int _A = 7;
    int _B = 5;
    int Xn = seed;
    int M = 11;
    int i = 0;
    while (i<_numberiter){
        Xn = (_A*Xn+_B)%M;
        i++;
        Console.WriteLine(Xn);
    }
    int _res = Xn;
    return _res;
}
int GetMCD(int A, int B){
	// algoritmo de euclides para MCD
	while (B!=0){
		int rest = A%B;
		A = B;
		B = rest;
	}
	return A;
}
Console.WriteLine(GetMCD(4851, 3003));

