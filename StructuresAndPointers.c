#include<stdio.h>

struct node
{
    int i;
    int *c;
};

void main()
{
  int x = 0;
 
  struct node a[2],*p;

  int b[2] = {30,40};

  p = &a[0];
  
  a[0].i = 10;
  a[1].i = 20;

  a[0].c = b;

  x = (++p)->i;
  printf("%d\n",x);

  p = &a[0];
  x = (p++)->i;
  printf("%d\n",x);

  p = &a[0];
  x = *p -> c;
  printf("%d\n",x);

  p = &a[0]; 
  x = *p -> c++;
  printf("%d\n",x);
   
  p = &a[0];
  x = (*p -> c)++;
  printf("%d\n",x);

  p = &a[0];
  x = *p++ -> c;
  printf("%d\n",x);

}
