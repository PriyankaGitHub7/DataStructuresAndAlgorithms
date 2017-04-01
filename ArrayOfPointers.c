#include<stdio.h>

void main()
{
   char *name[] = {"Pri","Priya","Priyanka"}; // Array of Pointers --> name contains pointers to the strings

   printf("%s\n",*(name+2));
   printf("%s\n",*(name) + 2);
  
   printf("%s\n",*(name + 2) + 7);
   
   // Use array pointers like Multi-dimensional Arrays
   printf("%c\n",name[2][7]);

   // Difference between Multi-Dimensional Arrays

   /*
       Array of pointers gives the chance to have different sized rows and hence save the space 
       which is not possible using multi-dimensional arrays.

   */

}
