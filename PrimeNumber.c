#include<stdio.h>

void main()
{
   int n = 0;
   int flag = 0;
   printf("Enter a positive number");
   scanf("%d", &n);

   for(int i = 2; i <= n/2; i++)
   {
	if(n % i == 0)
	{
	   flag = 1;
	   break;
	}
   }

   if(flag == 0)
   {
      printf("The number is prime");
   }
   else
   {
      printf("The number is not prime");
   }
}
