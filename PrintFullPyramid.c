#include<stdio.h>

void main()
{

  int numOfRows;

  printf("Enter the number of stars");

  scanf("%d",&numOfRows);

  for(int i = 1; i <= numOfRows;i++)
  {
     for(int j = i; j < numOfRows; j++)
     { 
	printf(" ");
     }
 
     for(int k = 1; k < (i * 2);k++)
     {
       printf("* ");
     }
     printf("\n");
  }
} 
