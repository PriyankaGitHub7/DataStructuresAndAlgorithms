using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class InfixToPostFixConversion
    {
        char[] operatorStack;
        int topStack = -1;
        string postfixExp = "";

        public InfixToPostFixConversion(int n)
        {
            operatorStack = new char[n];
        }

        public string ConvertToPostfix(String expression)
        {
            for(int i = 0; i < expression.Length; i++)
            {
                char ch = expression.ToCharArray()[i];

                if (ch == '(')
                {
                    pushElementOntoStack(ch);
                }
               else if (IsOperator(ch))
               {
                  //  int newpointer = topStack;

                    if(topStack == -1)
                    {
                        pushElementOntoStack(ch);
                    }
                    else
                    { 
                        if (isHigherPrecedence(ch, operatorStack[topStack]))
                        {
                           
                        }
                        else
                        {
                            appendToPostfixExpression(operatorStack[topStack--]);
                           
                        }
                        pushElementOntoStack(ch);
                    }
                }
                else if(ch == ')')
                {
                    while(operatorStack[topStack] != '(')
                    {
                        appendToPostfixExpression(operatorStack[topStack--]);
                    }
                }
                else if(IsOperand(ch))
                {
                    appendToPostfixExpression(ch);
                }
            }

            while(topStack != -1)
            {
                if(operatorStack[topStack] != '(')
                {
                    appendToPostfixExpression(operatorStack[topStack]);
                }
                topStack--;
               
            }

            return postfixExp;
        }

        private bool IsOperator(char ch)
        {
            if(ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '^')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsOperand(char ch)
        {
            if((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isHigherPrecedence(char incoming,char existing)
        {
            int[] precedence = {10, 10, 20,20};

            Dictionary<char, int> dictionaryPrecedence = new Dictionary<char, int>();

            dictionaryPrecedence.Add('/', 20);
            dictionaryPrecedence.Add('+', 10);
            dictionaryPrecedence.Add('-', 10);
            dictionaryPrecedence.Add('*', 20);
            dictionaryPrecedence.Add('^', 30);

                if (existing == '(' || dictionaryPrecedence[incoming] >= dictionaryPrecedence[existing])
                {
                    return true;
                }
                else
                {
                    return false;
                }
           
        }

        private void appendToPostfixExpression(char ch)
        {
            postfixExp = postfixExp + ch;
        }

        private void pushElementOntoStack(char ch)
        {
            operatorStack[++topStack] = ch;
        }
    }
}
