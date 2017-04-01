#include<stdio.h>

void swap(int *x,int *y);

void main()
{
   int a = 3;
   int b = 4;

   swap(&a,&b);

   printf("%d %d",a,b);

}

void swap(int *x, int *y)
{
   int temp = *x;
   *x = *y;
   *y = temp;
}
