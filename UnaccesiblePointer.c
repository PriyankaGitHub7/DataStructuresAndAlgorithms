#include<stdio.h>

char* getString();

void main()
{
    printf("%s",getString());
}

char* getString()
{
   char s[] = {"Priyanka"};

   return s;

}
