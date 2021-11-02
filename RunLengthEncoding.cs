using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;



public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        string c;
        char lastChar;
        
        if (input.Length == 0) return "";

        lastChar = input[0];
        int contador = 1;

        string result = "";

        for (int i = 1; i < input.Length; i++)
        {
            if (lastChar == input[i])
            {
                contador++;
            }
            else
            {
                if (contador > 1) result += contador.ToString();
                result += lastChar.ToString();
                contador = 1;
                lastChar = input[i];
            }
          
        }
        if (contador > 1) result += contador.ToString();
        result += lastChar;
        return result;


    }

    public static string Decode(string input)
    {
        char lastchar;
        int cont=1;
        string result="";
        string digitos = "";
        if (input.Length<1) return result;


       for (int i = 0; i < input.Length; i++)
       {
           lastchar = input[i];
           if (char.IsDigit(lastchar))
           {
               digitos += lastchar.ToString();
               cont = int.Parse(digitos.ToString());
           }
           else
           {
               digitos = "";
               result += RepeatChar(lastchar, cont);
               cont = 1;
           }
       }

       return result;
    }

    public static string RepeatChar(char c, int ntimes)
    {
        string result = "";
        for (int i = 0; i < ntimes; i++)
        {
            result += c;
        }

        return result;
    }
}
