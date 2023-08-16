using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        Stack<int> stacks = new Stack<int>();
        //Stack<int> output = new Stack<int>();
        
        Queue<int> cola = new Queue<int>();
        
        int queries = int.Parse(Console.ReadLine());
        
        while(queries > 0){
            
            string[] splits = Console.ReadLine().Split(' ');
            int type = int.Parse(splits[0]);
            
            if(type == 1){
                var aver = int.Parse(splits[1]);
                //stacks.Push(int.Parse(splits[1]));  
                cola.Enqueue(int.Parse(splits[1])); 
                //Console.WriteLine("Agregando: "+aver);
            }
            else if(type == 2){
                if(cola.Count < 1){
                    break;
                    //string smthg = "0";
                }
                else
                {
                    //var aver2 = stacks.Pop();
                    var aver2 = cola.Dequeue();
                    
                    //cola.Enqueue(int.Parse(splits[1])); 
                    //Console.WriteLine("Quitando: "+aver2);
                }
            }
            
            else if(type == 3){
                if(cola.Count < 1){
                    break;
                    //string smthg2 = "0";
                }
                else{
                //Console.WriteLine("Imprimiendo: "+cola.Peek());
                    
                //Console.WriteLine("Imprimiendo: "+stacks.Peek());
                Console.WriteLine(cola.Peek());
                
                }
            }
            
            queries--;
        }
        
        
        
    } 
  
    
}
