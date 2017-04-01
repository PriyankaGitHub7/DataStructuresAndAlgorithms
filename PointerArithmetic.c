#include<stdio.h>

void main()
{
   int *p,*q;
   int a[5] = {1,2,3,4,5};
	
   p = (int*)&a[3];
   q = (int*)&a[1];
 
   if(q < p)
   {
     printf("ptr p comes after ptr q");
   }

   printf("First's value : %d",a);
   printf("P's value : %d",p);
   printf("Q's value : %d",q);

   int count = p - q + 1;
   printf("Number of elements between p and q : %d",count);

}
