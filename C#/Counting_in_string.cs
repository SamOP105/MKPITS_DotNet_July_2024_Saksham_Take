using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//append method can be used to append a value 
//find the numbers of vowels, consonents, digits and white spaces
//MKPITS Services 1 placement 15 Agencies
namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
                    string s = "MKPITS Services 1 placement 15 Agencies";
                    Console.WriteLine(s);

                    int v = 0, c = 0, d = 0, space = 0;

                    
                    for (int i = 0; i < s.Length; i++)
                    {
                        
                        if (s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U' ||
                            s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                        {
                            v++;
                        }
                
                        else if (s[i] == 'B' || s[i] == 'C' || s[i] == 'D' || s[i] == 'F' || s[i] == 'G' || s[i] == 'H' ||
                         s[i] == 'J' || s[i] == 'K' || s[i] == 'L' || s[i] == 'M' || s[i] == 'N' || s[i] == 'P' ||
                         s[i] == 'Q' || s[i] == 'R' || s[i] == 'S' || s[i] == 'T' || s[i] == 'V' || s[i] == 'W' ||
                         s[i] == 'X' || s[i] == 'Y' || s[i] == 'Z' ||
                         s[i] == 'b' || s[i] == 'c' || s[i] == 'd' || s[i] == 'f' || s[i] == 'g' || s[i] == 'h' ||
                         s[i] == 'j' || s[i] == 'k' || s[i] == 'l' || s[i] == 'm' || s[i] == 'n' || s[i] == 'p' ||
                         s[i] == 'q' || s[i] == 'r' || s[i] == 's' || s[i] == 't' || s[i] == 'v' || s[i] == 'w' ||
                         s[i] == 'x' || s[i] == 'y' || s[i] == 'z'){ 
                                c++;
                            
                        }
                       
                        else if (s[i] >= '0' && s[i] <= '9')
                        {
                            d++;
                        }
                      
                        else if (s[i] == ' ')
                        {
                            space++;
                        }
                    }

                    
                    Console.WriteLine("Vowels: " + v);
                    Console.WriteLine("Consonants: " + c);
                    Console.WriteLine("Digits: " + d);
                    Console.WriteLine("Whitespaces: " + space);

                    Console.ReadLine();
        }
    }
}