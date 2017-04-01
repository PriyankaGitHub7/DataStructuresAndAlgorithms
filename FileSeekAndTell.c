#include<stdio.h>

void main()
{
  FILE *fp;
  fp = fopen("FileTest.txt","r");

  if(fp == NULL)
  {
     printf("Error opening file");
  }
  
  fseek(fp,0,SEEK_END); // SEEK_SET,SEEK_CUR,SEEK_END

  int len = ftell(fp);

  printf("Total size of file = %d bytes",len);

}
