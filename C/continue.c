#include <stdio.h>
int main()
{
  char op;
  int pin=123, cash_d=10000,u_pin,cash_with;
  
  printf("Enter the user atm pin:");
  scanf("%d",&u_pin);
  
  if(pin==u_pin)
  {
      printf("go for futher operation\n");
  }
  else
  {
      printf("terminate the operation\n");
  }
  
  ;
  printf("--State bank of INDIA--\n");
  printf("enter number to perform operation: ");
  scanf("%s",&op);
  
  switch(op)
  {
      case 'a':
      printf("Enter the cash withdrawl amount: ");
      scanf("%d",&cash_with);
      if(cash_with<=cash_d)
      {
          printf("the cash withdrawl amount is %d\n",cash_with);
          printf("the balance amount is %d",cash_d-cash_with);
      }
      else
      {
          printf("did not having sufficient balance");
      }
      break ;
      case 'b':
      printf("the balance amount is %d",cash_d-cash_with);
      
  }
   return 0;
}
