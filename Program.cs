using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Davaleba
{
    public class Node
    {

      public int data;
        public Node next;
        public Node previous;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }

       
        public void print()
        {
            Console.Write(data+" ");
            if(next!=null)
            {
                next.print();
            }

        }
        public void AddToEnd(int data)
        {
            if (next==null)
            {
                next = new Node(data);
            }
            else
                {
                next.AddToEnd(data);
            }
        }

           

    }
    class Program
    {
        //Davaleba 1
       static  bool isPolindrome(string name)
        {
            name = name.ToLower();
            bool tf = true;
            for (int i = 0; i < name.Length / 2; i++)
            {
                if (name[i] != name[name.Length - i - 1])
                {
                    tf = false;
                    break;
                }
            }
            return tf;
        }
       static int minSplit(int amount)
        {
            int number = 0;
            if (amount >= 50)
            {
                number += amount / 50;
                amount = amount % 50;
            }
            if (amount >= 20)
            {
                number += amount / 20;
                amount = amount % 20;
            }
            if (amount >= 10)
            {
                number += amount / 10;
                amount = amount % 10;

            }
            if (amount >= 5)
            {
                number += amount / 5;
                amount = amount % 5;
            }
            if (amount >= 1)
            {
                number += amount;
            }


            return number;
        }
        static int notContains(int[] array)
        {
            int maxelement = array[0];
            int i;
            for (i = 1; i < array.Length; i++)
            {
                if (maxelement < array[i])
                {
                    maxelement = array[i];
                }
            }


            int minelement = 0;
            for (i = 1; i < maxelement; i++)
            {

                int j = 0;
                for (j = 0; j < array.Length; j++)
                {
                    if (i == array[j])
                    {
                        break;
                    }


                }
                if (j == array.Length)
                {
                    minelement = i;
                    break;
                }

            }
            if (i == maxelement)
            {
                minelement = maxelement + 1;
            }


            return minelement;
        }
        static bool isProperly(string sequence)
        {
            int bracket1 = 0;
            int bracket2 = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                switch (sequence[i])
                {
                    case '(':
                        bracket1++;
                        break;
                    case ')':
                        bracket2++;
                        break;
                    default:
                        break;
                }
            }
            bool tf = true;
            if (bracket1 != bracket2) { tf = false; }

            return tf;
        }
        static int fib(int n)
        {
            if (n <= 1)
                return n;
            return fib(n - 1) + fib(n - 2);
        }
        static int countWays(int s)
        {
            return fib(s + 1);
        }
        static void Main(string[] args)
        {

            //====================== Davavaleba 1 ========================
            string word = "Ana";
            if(isPolindrome(word))
            {
                Console.WriteLine("Word is Polindrom");
            }
            else { Console.WriteLine("Word is not polindrome"); }


            //====================== Davavaleba 2 ========================

            int amount = 75;
            int number = minSplit(amount);
            Console.WriteLine("Min split="+number);

            //====================== Davavaleba 3 ========================


            int[] msv = { 3, 4, 1, 5, 6, 7 };
            int n = notContains(msv);
            Console.WriteLine("notContains="+n);

            //====================== Davavaleba 4 ========================

            string info = "Elnur(Aliev";
            if(isProperly(info))
            {
                Console.WriteLine("Number of breackts is correct");
            }
            else
            { Console.WriteLine("Number of breackts is not correct"); }


            //====================== Davavaleba 5 ========================

            int s = 15;
            Console.WriteLine("Number of ways = " + countWays(s));


            //====================== Davavaleba 6 ========================

            Node nd = new Node(1);
             nd.AddToEnd(2);
             nd.AddToEnd(3);
             nd.AddToEnd(4);
             nd.AddToEnd(5);
             nd.print();          




            Console.Read();
        }
    }
}
