#include<stdio.h>

char* concatString(char s[], char t[]);

void main()
{

  char s[8] = {"Priy"};
  char t[] = {"anka"};

  char* final = concatString(s,t);

  while(*final != '\0')
  {
     printf("%c",*final);
     final++;
  }

}

char* concatString(char s[],char t[])
{
   int j = 0;
   int i = 0;

   char* a = s;

   while(s[i] != '\0')
   {
      i++;
   }

   while((s[i++] = t[j++]) != '\0');

   return a;

}
