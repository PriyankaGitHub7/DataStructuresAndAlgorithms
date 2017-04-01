#include<stdio.h>

void main()
{
  int n,currDigit;
  
  printf("Enter a number:");

  scanf("%d",&n);

  int originalNum = n;

  int reverse = 0;

  while(originalNum != 0)
  {
     currDigit = originalNum % 10;
  
     reverse = currDigit + reverse * 10;

     originalNum = originalNum/10;
  }

  if(reverse == n)
  {
    printf("The number is a palindrome");
  }  
  else
  {
    printf("The number is not a palindrome");
  }
} 
