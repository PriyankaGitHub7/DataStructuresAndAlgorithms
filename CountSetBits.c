#include<stdio.h>

void main()
{
   int x = 10;
  
   int count = 0;

   for(int i = 1; x != 0;x >>= 1)
   {
       if(x & i != 0)
       {
          count++;
       }
   }

   printf("%d",count);

}
