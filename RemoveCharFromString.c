#include<stdio.h>

void main()
{
   char s[] = {"Priyanka"};

   char c = 'a';

   int j = 0;

   for(int i = 0; s[i] != '\0'; i++)
   {
        if(s[i] != c)
        {
           s[j++] = s[i];
        }
   }

   s[j] = '\0';

   printf("%s",s);
}
