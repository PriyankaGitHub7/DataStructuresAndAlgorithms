#include <stdio.h>

void main()
{
   int linecount = 1;
   
   char ch;

   while((ch = getchar()) != EOF)
   {
	if(ch == '\n')
	{
	   ++linecount;
   	}
   }

   printf("%d",linecount);
}
