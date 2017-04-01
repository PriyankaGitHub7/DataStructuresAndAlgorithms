#include<stdio.h>

char* copystring(char *a,char *b);

void main()
{
   char a[8];
   char b[] = {"Priyanka"};

   char *s = copystring(a,b);
   while(*s != '\0')
   {
      printf("%c",*s);
      s++;
   }
}

char* copystring(char *a, char *b)
{
   char* c = a;

   while((*a++ = *b++) != '\0');

   return c;
}
