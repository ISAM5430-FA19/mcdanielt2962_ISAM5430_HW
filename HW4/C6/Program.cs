using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;//C6
            int vowelcount = 0;//C7
            int constcount = 0;//C7
            int i = 0;//C9
            char prvletter = 'A';
            bool increase = true;
            bool instrument = true;
            bool secondhalf = true;
            int prvlettervow = 2;
            int currentletter = 1;
            bool prvlettervowcheck = true;
            char smoothletter = 'A';
            bool smooth = true;
            bool alternating = true;
            char letter1 = 'A';//f
            char letter2 = 'A';//f
            char letter3 = 'A';//f

           


            WriteLine("Enter a squence of letters.");

            while (true)
            {
                
                var keyInfo = ReadKey();
                char letter = char.ToUpperInvariant(keyInfo.KeyChar);
                if (!char.IsLetter(letter)) break;
                {
                    bool vowels = letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y';
                    int vow = (vowels ? 1 : 0);
                    if (i == 0)
                    {
                        prvletter = letter;
                        smoothletter = letter;
                        letter1 = letter;
                        

                    }
                    else if(i==1)
                    {
                        letter2 = letter;
                        
                    }
                    else if(i==2)
                    {
                        letter3 = letter;
                        
                    }
                    else if (letter <= prvletter)
                    {
                        increase = false;

                    }
                    else
                    {
                        prvletter = letter;

                    }
                    if (letter > 'G')
                    {
                        instrument = false;
                    }
                    if (letter < 'N')
                    {
                        secondhalf = false;
                    }
                    count += 1;
                    
                    //bool vowels = letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y';
                    //int vow = (vowels ? 1 : 0);

                    if (vow == 1)
                    {
                        vowelcount += 1;
                        currentletter = 1;
                    }
                    else
                    {
                        constcount += 1;
                        currentletter = 0;
                        

                    }
                    if (prvlettervow == currentletter)
                    {
                        prvlettervowcheck = false;   
                    }
                    if(smoothletter!=letter && smoothletter != letter+1 && smoothletter != letter-1)
                    {
                        smooth = false;
                        
                    }
                    if(i>=3)
                    {
                        if(letter1==letter2 || letter1==letter3 || letter2==letter3 || letter==letter3)
                        {
                            alternating = false;
                        }
                        if (letter2 >= letter1 && letter3 >= letter2)
                        {
                            alternating = false;
                        }
                        else if (letter2 <= letter1 && letter3 <= letter2)
                        {
                            alternating = false;
                        }
                        
                        letter1 = letter2;
                        letter2 = letter3;
                        letter3 = letter;
                    }
                    
                    i += 1;
                    prvlettervow=currentletter;
                    smoothletter = letter;
                    
                    



                }

            }
            


            WriteLine($"There are {count} letters.");
            WriteLine($"There are {vowelcount} vowels.");
            WriteLine($"There are {constcount} consonants.");
            WriteLine($"There are {vowelcount} syllables.");//this will not work for words with 2 vowels next to each other as they make a single syllable i.e. look Would need to count syllables as
                                                            //vowels that have at least one consonant in between.
            
            if (increase==true)
            {
                WriteLine($"The letters were in increasing order.");
            }            
            if(instrument==true)
            {
                WriteLine("You can play the word on a musical instrument.");
            }
            if(secondhalf==true)
            {
                WriteLine("All the letters are in the second half of the alphabet.");
            }
            if(prvlettervowcheck==true)
            {
                WriteLine("Letters alternated between vowel and consonent.");
            }
            if (smooth==true)
            {
                WriteLine("The letters have a smooth transition");
            }
            if(alternating==true)
            {
                WriteLine("The letters have alternation order.");
            }
        }
    }
}
