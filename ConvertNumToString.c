#include<stdio.h>
#include<string.h>

char* convertToCharArray(int n, char* c);

void main()
{
   int n = -123;

   char s[8];
 
   char *point = convertToCharArray(n,s);
   
   while(*point != '\0')
   {
      printf("%c",*point);
      point++;
   }

}

char* convertToCharArray(int n,char s[])
{
   int sign;

   int i = 0;  

  // char *string;

   if((sign = n) < 0)
   {
 	n = -n;
   }
  
   do
   {
     s[i++] = n % 10 + '0';

   } while((n = n/10) > 0);

   if(sign < 0)
   {
      s[i++] = '-';
   }

   s[i] = '\0';

  // string =  strrev(s);
 
   return s;
}
