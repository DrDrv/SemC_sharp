Random rnd = new Random();
int numberA = 3;
int numberB = 4;
int numberN = 5;
int temp = 0;
Fibonacci(numberA, numberB, numberN);

void Fibonacci(int A,int B, int N)
{
    if (N == 0) return;
    else
    {
        Console.WriteLine(A);
        temp = A+B;
        A = B;
        B = temp;
        N--;
        Fibonacci(A,B,N);
    }
}