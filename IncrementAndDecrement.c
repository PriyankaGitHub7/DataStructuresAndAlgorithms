#include <stdio.h>

void main(void)
{
  int x; 
  
  int n = 10;
 
  x = n++;

   printf("%d\n",x);

  x = ++n;

  printf("%d",x);
 
}

