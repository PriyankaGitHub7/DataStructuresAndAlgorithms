#include<stdio.h>
#include<math.h>

void main()
{
   int num,originalNum,currentDigit= 0,result = 0,noOfDigits = 0;

   printf("Enter a number");
   
   scanf("%d",&num);
 
   originalNum = num;

   // Number of digits

   while(originalNum != 0)
   {
      originalNum = originalNum/10;

      noOfDigits++;
   } 

   originalNum = num;

  // check if armstrong number

  while(originalNum != 0)
  {
     currentDigit = originalNum % 10;
       
     result = result + pow(currentDigit,noOfDigits);

     originalNum = originalNum/10;

  }

  if(result == num)
  {
     printf("The number is armstrong");
  }
  else
  {
     printf("The number is not armstrong");
  }
}
