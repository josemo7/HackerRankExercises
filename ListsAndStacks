// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello Mono World");
        string example = "{{{[[[((()))]]]}}}";
        int counterty1 = 0;
        int counterty2 = 0;
        int counterty3 = 0;
        int counterty4 = 0;
        int counterty5 = 0;
        int counterty6 = 0;
        
        foreach(char c in example)
        {
            if(c == '{')
            {
                counterty1++;
            }
            else if( c == '[')
            {
                counterty2++;
            }
            
            else if(c == '(')
            {
                counterty3++;
            }
            
            else if( c == ')')
            {
                counterty4++;
            }
            
            else if(c == ']')
            {
                counterty5++;
            }
            
            else if(c == '}')
            {
                counterty6++;
            }
            
        }
        
        Console.WriteLine ("Counters: " + counterty1);
        Console.WriteLine ("Counters: " + counterty2);
        Console.WriteLine ("Counters: " + counterty3);
        Console.WriteLine ("Counters: " + counterty4);
        Console.WriteLine ("Counters: " + counterty5);
        Console.WriteLine ("Counters: " + counterty6);
        
        //(counterty1 % 2) == 0
        
        bool num1 = counterty1==counterty4;
        bool num2 = counterty2==counterty5;
        bool num3 = counterty3==counterty6;
        
        if(num1 && num2 && num3)
        {
            Console.WriteLine ("Yes");
        }
        else
        {
            //return "NO";
            Console.WriteLine ("No");
        }
        
    }
}


// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello Mono World");
        string example = "({}([][]))[]()";
        
        if(!((example.Length % 2) == 0))
        {
            //return "NO";
            Console.WriteLine ("NO");
        }
        else
        {
            string part1 = example.Substring(0, example.Length/2);
            string part2 = example.Substring(example.Length/2);
            
            Console.WriteLine (part1);
            Console.WriteLine (part2);
            
            string part2reversed = part2.Replace(')','(').Replace(']','[').Replace('}','{');
            
            Console.WriteLine (part2reversed);
    
           
    // Converting string to character array
    char[] charArray = part2reversed.ToCharArray(); 
    // Declaring an empty string
    string reversedString = String.Empty; 
    int length, index; 
    length = charArray.Length - 1;
    index = length;
    // Iterating the each character from right to left 
    while (index > -1) 
    { 
        // Appending character to the reversedstring.
        reversedString = reversedString + charArray[index]; 
        index--; 
    }
    Console.WriteLine (reversedString);
    
    if(part1 == reversedString)
    {
        Console.WriteLine ("YES");
    }
    else 
    {
        Console.WriteLine ("NO");
    }
    
            
            
            
        }
        
    }
}


// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string example = "[[([]])";   
        Stack<string> stack = new Stack<string>();
        
        foreach(char c in example)
        {
            if(c == '{')
            {
                stack.Push("}");
                Console.WriteLine("Adding: " + stack.Peek());
            }
            if(c == '(')
            {
                stack.Push(")");
                Console.WriteLine("Adding: " + stack.Peek());
            }
            if(c == '[')
            {
                stack.Push("]");
                Console.WriteLine("Adding: " + stack.Peek());
            }
            
            //'}' || c == ']' || c == ')'
            
            else if(c =='}' || c == ']' || c == ')' ){
                Console.WriteLine("POSBLE remove: " + stack.Peek());
                Console.WriteLine("POSBLE removec: " + c);
                if(c.ToString() == stack.Peek())
                {
                    stack.Pop();
                    Console.WriteLine("Removing: " + c);
                    
                }
                else 
                {
                    break;
                }
            }
        }
        
        if(stack.Count == 0)
        {
            Console.WriteLine("YES");
            //return "YES";
        }
        else 
        {
            Console.WriteLine("NO");
            //return "NO"; 
        }
        /*
        foreach(string st in stack)
             {
                 Console.WriteLine("Stack elem: "+ st);
             }
          */   
        
        /*
        marcas.Push("Audi");
        marcas.Push("Opel");
        marcas.Push("BMW");
        
        Console.WriteLine(marcas.Peek()); //BMW
        Console.WriteLine(marcas.Pop()); //BMW
        Console.WriteLine(marcas.Pop()); //Opel
        
        foreach(string marca in marcas)
        {
        Console.WriteLine(marca);
        }
        /*
        
        
        /*
         //Console.WriteLine ("Hello Mono World");
        string example = "{}([][]))[]()";
        string example = "{([][]))[]()";
        string nextString = String.Empty; 
        
        foreach(char c in example)
        {
            if(c == '{')
            {
                nextString = '}' + nextString;
            }
            if(c == '(')
            {
                nextString = ')' + nextString;
            }
            if(c == '[')
            {
                nextString = ']' + nextString;
            }
            
            if(c == nextString)
            {
                nextString = String.Empty;
            }
            
        }
        
        if(!((example.Length % 2) == 0))
        {
            //return "NO";
            Console.WriteLine ("NO");
        }
        else
        {
            string part1 = example.Substring(0, example.Length/2);
            string part2 = example.Substring(example.Length/2);
            
            Console.WriteLine (part1);
            Console.WriteLine (part2);
            
            string part2reversed = part2.Replace(')','(').Replace(']','[').Replace('}','{');
            
            Console.WriteLine (part2reversed);
    
           
    // Converting string to character array
    char[] charArray = part2reversed.ToCharArray(); 
    // Declaring an empty string
    string reversedString = String.Empty; 
    int length, index; 
    length = charArray.Length - 1;
    index = length;
    // Iterating the each character from right to left 
    while (index > -1) 
    { 
        // Appending character to the reversedstring.
        reversedString = reversedString + charArray[index]; 
        index--; 
    }
    Console.WriteLine (reversedString);
    
    if(part1 == reversedString)
    {
        Console.WriteLine ("YES");
    }
    else 
    {
        Console.WriteLine ("NO");
    }
       
        }
    
            */
        }
    
}
