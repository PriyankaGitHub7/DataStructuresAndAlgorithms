#include<stdio.h>

int isCommon(int [], int[],int m, int n); 

void main()
{
   int a[] = {1,2,3,4,5};
   int b[] = {8,9,6,7,8};
   int hasCommon = isCommon(a,b,5,5);
   if(hasCommon == 1)
   {
      printf("There are common elements");
   }
   else
   { 
      printf("There are no common elements");
   }
}

int isCommon(int a[],int b[], int m, int n)
{
    for(int i = 0; i < n;i++)
    {
       for(int j = 0; j < m;j++)
       {
          if(a[i] == b[j])
          {
   	     return 1;
          }
       }

    }
   return 0;
}
