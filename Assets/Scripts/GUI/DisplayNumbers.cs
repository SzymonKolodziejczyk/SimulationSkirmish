using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class DisplayNumbers : MonoBehaviour
{

    public string Generate (int minNumber, int maxNumber) {

        StringBuilder GenerateNumbers = new StringBuilder();

        for (int TheNumber = minNumber; TheNumber <= maxNumber; TheNumber++)
        {
            //Check if number is able to be divided by 3 and 5 simultaneously
            if (IsDivisible(TheNumber, 15))
            {
                GenerateNumbers.Append("MarkoPolo");
            }
            else
            {
                //Check if number is able to be divided by 3
                if (IsDivisible(TheNumber, 3))
                    GenerateNumbers.Append("Marko");
                //Check if number is able to be divided by 5
                else if (IsDivisible(TheNumber, 5))
                    GenerateNumbers.Append("Polo");
                //If number can't be divided by above numbers, do this
                else
                    GenerateNumbers.Append(TheNumber.ToString());;
            }
            
            //If there is more than one generated number, add line break
            if(TheNumber != maxNumber)
                GenerateNumbers.Append("\n");
        }
        
        //Printing to console output
        Debug.Log(GenerateNumbers);
        
        return GenerateNumbers.ToString();
    }
    public static bool IsDivisible(int dividend, int divisor)
    {
        return dividend % divisor == 0;
    }
}