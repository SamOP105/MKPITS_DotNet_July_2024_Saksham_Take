#include <stdio.h>

int main() {
  char op;
  int num1,num2;
  
  printf("enter any two numbers: ");
  scanf("%d%d",&num1,&num2);
  printf("enter any operator to perform operation: ");
  scanf("%s",&op);
  
  switch(op)
  {
      case 'a':
      printf("addition : %d",num1+num2);
      break;
      
      case 'b':
      printf("subtraction: %d",num1-num2);
      break;
      
      case 'c':
      printf("Division: %d",num1/num2);
      break;
      
      case 'd':
      printf("Multiplication: %d",num1*num2);
      break;
      
      case 'e':
      printf("modulus: %d",num1%num2);
      break;

  }

    return 0;
}#include <stdio.h>

int main() {
  char op;
  int num1,num2;
  
  printf("enter any two numbers: ");
  scanf("%d%d",&num1,&num2);
  printf("enter any operator to perform operation: ");
  scanf("%s",&op);
  
  switch(op)
  {
      case 'a':
      printf("addition : %d",num1+num2);
      break;
      
      case 'b':
      printf("subtraction: %d",num1-num2);
      break;
      
      case 'c':
      printf("Division: %d",num1/num2);
      break;
      
      case 'd':
      printf("Multiplication: %d",num1*num2);
      break;
      
      case 'e':
      printf("modulus: %d",num1%num2);
      break;

  }

    return 0;
}