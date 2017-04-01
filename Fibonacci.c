#include<stdio.h>

void main()
{
   int first,second,counter = 0, sum,num; 
 
   printf("Enter the number of times");
   scanf("%d",&num);

   printf("Enter the first element");
   scanf("%d",&first);

   printf("Enter the second element");
   scanf("%d",&second);

   while(counter < num)
   {
     sum = first + second;
     printf("%d ",sum);
     first = second;
     second = sum;
     counter++;
   }
}
