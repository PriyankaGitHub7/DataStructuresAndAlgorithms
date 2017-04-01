#include<stdio.h>
#include<stdlib.h>
#define DEFAULT_SIZE 10

char* resize(char *p,int capacity);

void main()
{
   int count = 0;

   int capacity = DEFAULT_SIZE;

   char *input;

   input = (char *)malloc(DEFAULT_SIZE);

   if(input == NULL)
   {
      printf("Error creating space");
   }

   char ch;

   while((ch = getchar()) != EOF)
   { 
      if(count == capacity)
      {
         input = resize(input,capacity);

	 if(input != NULL)
         {
	    capacity = capacity + DEFAULT_SIZE;
         }
      }

      input[count++] = ch;
   }

   if(count == capacity)
   {
	input = resize(input,1);
   }

   input[count] = '\0';

   puts(input);
}

char* resize(char *p,int capacity)
{
  return realloc(p,capacity + DEFAULT_SIZE);
}
