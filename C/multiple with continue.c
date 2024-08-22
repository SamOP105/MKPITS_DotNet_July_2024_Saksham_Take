#include<stdio.h>
int main()
{
    int Multiple;
    for(int counter=1;counter<=10;counter++)
    {
       if(counter==5)
       {
           continue;
       }
       Multiple=2*counter;
       printf("%d\n",Multiple);
    }
}