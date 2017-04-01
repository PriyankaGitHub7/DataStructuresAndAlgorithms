#include<stdio.h>
#include<string.h>

void main()
{
   char s[] = {"Priya"};

   char temp;

   int k = 0;
  
   for(int i = 0, j = strlen(s) - 1; i < j; i++,j--)
   {
      temp = s[i];
      s[i] = s[j];
      s[j] = temp;
   }

   while(s[k] != '\0')
   {  
       printf("%c",s[k]);
       k++;
   }
}
