#include<stdio.h>

void main()
{
   char s[] = {"-123"};

   int i;

   int n = 0; // Negative number case to be handled

   for(i = 0; s[i] >= '0' && s[i] <= '9';i++)
   {
       n = 10 * n + (s[i] - '0');  
   }

   printf("%d",n);
   
}
