using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Encoding_Algorithm
{
    class Algorithm
    {
        static void Main(string[] args)
        {
            string textString = "";
            string[] text = textString.Split(' ');

            string[] finalText = new string[text.Length];

            int textIndex = 0;
            int repeat = 0;

            //Start

            for (int i = 0; i < text.Length; i++)
            {

                string word = text[i];

                for (int j = 0; j < finalText.Length; j++)
                {
                    if (word == finalText[j])
                    {
                        repeat++;
                    }
                }

                if (repeat == 0)
                {
                    finalText[textIndex] = word;
                }
                else
                {
                    finalText[textIndex] = "-";
                }
                textIndex++;
                repeat = 0;
            }

            for (int i = 0; i < finalText.Length; i++)
            {
                Console.Write(finalText[i] + " ");
            }
        }
    }
}
