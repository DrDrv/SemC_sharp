
int numberN = 10;
int j = 1;
int A = 0, B = 0;

 for(int i=1; i<=numberN; i+=j) 
 {
    if (i < numberN)
    {
        A = i;
        B += i-j; 
    } 
   j=i-j;
  }
Console.WriteLine(A);
Console.WriteLine(B+1);
