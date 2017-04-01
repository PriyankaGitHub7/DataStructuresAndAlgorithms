#include<stdio.h>

void main()
{
   FILE *fp;

   fp = fopen("test.txt","w");

   char ch;

   printf("Enter data:");

   while((ch = getchar()) != EOF)
   {
      putc(ch,fp);
   }

   fclose(fp);

   fp = fopen("test.txt","r");
 
   while((ch = getc(fp)) != EOF)
   {
      printf("%c",ch);
   }
}
