#include<stdio.h>

void main()
{
   int n;

   unsigned long long factorial = 1; // ull range : 0 to 2 pow 64 -1 ; Range without unsigned -2 pow 63 to 2 pow 63 - 1

   if(n < 0)
   {
      printf("Factorial does not exist for negative numbers");
   }
   else
   {
      for(int i = 2; i <=n; i++)
      {
         factorial *= i;
      }
   }
   
   printf("The factorial is %llu",factorial);
}
