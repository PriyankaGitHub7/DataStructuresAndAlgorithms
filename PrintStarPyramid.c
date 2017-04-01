#include<stdio.h>

void main()
{
   int numOfRows = 0;

   printf("Enter the number of rows");   
 
   scanf("%d",&numOfRows);

   for(int i = 0; i < numOfRows;i++)
   {
      for(int j = 0; j <= i; j++)
      {
         printf("* ");
      }
      printf("\n");
   }
}
