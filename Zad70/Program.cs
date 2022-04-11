Random rnd = new Random();
int numberA = 3;
int numberB = 4;
int numberN = 5;

Fibonacci(numberA, numberB, numberN);

void Fibonacci(int A,int B, int N)
{
    if (N == 0) return;
    else
    {
        Console.WriteLine(A);
        (A,B) = (B, A+B);

        Fibonacci(A,B,--N);
    }
}