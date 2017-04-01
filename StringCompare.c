#include<stdio.h>

int compareString(char* s, char* t);

void main()
{

  char s[5] = {"Priya"};
  char t[5] = {"Priyd"};

  int diff = compareString(s,t);

  printf("%d",diff);

}

int compareString(char *s,char *t)
{
   int j = 0;
   int i = 0;

   for(; *s == *t; s++,t++)
   {
      if(*s == '\0')
      {
	 return 0;
      }
   }
 
   return *s - *t;
}
