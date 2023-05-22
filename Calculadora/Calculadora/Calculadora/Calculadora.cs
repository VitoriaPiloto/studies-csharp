using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Calculadora
    {
        public int Num1 { get; set; }  
        public int Num2 { get; set; } 
        public string Operation { get; set; }
      
        public int Sum(int n1, int n2) { return n1 + n2; }
        public int Sub(int n1, int n2) {  return n1 - n2; }
        public int Div (int n1, int n2) { return n1 / n2; }
        public int Multi (int n1, int n2) { return n1 * n2; }
    }
}
