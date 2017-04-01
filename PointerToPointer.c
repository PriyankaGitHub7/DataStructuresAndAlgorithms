#include<stdio.h>

void main()
{
   int a[] = {10,20,30,40,50,60};
   int *p[] = {a,a+1,a+2,a+3,a+4,a+5};

   int **pp = p;
  
   pp++;

   // * and ++ are unary operators with same priority and right to left associativity

   printf("%d %d %d",pp - p,*pp - a,**pp); // 1 1 20
   
   *pp++;// evaluate ++ first and * then
 
   printf("%d %d %d",pp - p,*pp - a,**pp); // 2 2 30

   ++*pp;
 
   printf("%d %d %d",pp - p,*pp - a,**pp); // 2 3 40

   ++**pp;

   printf("%d %d %d",pp - p,*pp - a,**pp); // 2 3 41

}
