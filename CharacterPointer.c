#include<stdio.h>

void custom(char *s,char *t);

void main()
{
   char source[] = "Priyanka"; // can be modified a[0]
   char *p = "Priyanka"; // read only. cannot be altered

   char dest[8];

   custom(dest,source);
}

void custom(char *s,char *t)
{

   while(*s++ = *t++);

}
