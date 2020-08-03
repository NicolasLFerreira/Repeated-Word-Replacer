using System;
using System.Threading.Tasks.Dataflow;

using Microsoft.VisualBasic.CompilerServices;

namespace Encoding_Algorithm
{
    class Algorithm
    {
        static void Main(string[] args)
        {
            string textString = "aaa abc aaa 123 123 aaa abc"; //Enter the text input
            string[] text = textString.Split(' '); //This array will divide the text word by word

            string[] finalText = new string[text.Length]; //This is where the "processed" text will be saved in

            int textIndex = 0; //Position of the array
            bool repeat = false; //Used to store info if the word is repeated

            //Start

            for (int i = 0; i < text.Length; i++) //Runs through the entire array
            {

                string word = text[i]; //Current word being checked
                int J = 0;

                for (int j = 0; j < finalText.Length; j++) //Checks if current word is in the processed text.
                {
                    if (word == finalText[j]) //Compares both words
                    {
                        repeat = true; //True if word is repeated
                        J = j;
                    }
                }

                if (!repeat) //Only if word isn't repeated
                {
                    finalText[textIndex] = $"{word}"; //Adds current word
                }
                else //If current word is repeated
                {
                    finalText[textIndex] = $"[C:{i + 1}|W:{J + 1}|B:{i - J}>{word}]"; //Pointer
                }
                //Next word
                textIndex++;
                //Resets for next word
                repeat = false; 
            }

            //Console printing and debugging

            for (int i = 0; i < finalText.Length; i++)
            {
                Console.Write($"{finalText[i]} ");
            }
        }
    }
}
