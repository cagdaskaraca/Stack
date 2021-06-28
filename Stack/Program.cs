using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{

    public class Stack
    {
        private int[] Stack_Max_Size;
        private int top;
        private int max;
        public Stack(int size)
        {
            Stack_Max_Size = new int[size]; // Yığın max Boyutu
            top = -1;
            max = size;
        }

        public void push(int item) //Yığına değer eklemek için kullanılır.
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                Stack_Max_Size[++top] = item;
            }
        }

        public int pop() //Yığından değer çıkarmak için kullanılır.
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty"); //Yığının boş olup olmadığını kontrol etmek kullanılır.
                return -1;
            }
            else
            {
                Console.WriteLine("{0} popped from stack ", Stack_Max_Size[top]);//Çıkarılan değeri ekrana yazdırmak için kullanılır.
                return Stack_Max_Size[top--];
            }
        }

        public int peek()// Yığındaki en üstteki değeri döndürmek için kullanılır.
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");// Yığının boş olup olmadığını kontrol etmek kullanılır.
                return -1;
            }
            else
            {
                Console.WriteLine("{0} popped from stack ", Stack_Max_Size[top]);//Yığının en üstünde bulundan değeri yazdırır.
                return Stack_Max_Size[top];
            }
        }

        public void printStack() //Yığındaki tüm verileri yazdırmak için kullanılır.
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");// Yığının boş olup olmadığını kontrol etmek kullanılır.
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("{0} pushed into stack", Stack_Max_Size[i]);
                }
            }
        }
    }


    public class Program
    {
        static void Main()
        {
            Stack Stack = new Stack(3);

            Stack.push(10);
            Stack.push(20);
            Stack.push(30);
            Stack.printStack();
            Stack.pop();
            Stack.pop();
            Stack.pop();
            Stack.pop();
            Console.ReadKey();
        }
    }
}




