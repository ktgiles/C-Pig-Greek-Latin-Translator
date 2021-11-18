using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Giles_Lab6
{
    interface ITranslator
    {
        string translate(string english); //interface method (accepts and returns string)
    }

    class PigLatinTranslator : ITranslator
    {
        public string translate(string english) {
            string latin;
            int capital;
            var regexAlpha = new Regex("^[a-zA-Z']*$"); //check if every letter is alpha or apostrophe 
            var regexEndPunc = new Regex(@"\p{P}$"); //check if final letter is punctuation
            var regexStartVowel = new Regex("(?i)^[aeiou]"); //check if first letter is vowel regardless of case
            var regexCons = new Regex("(?i)[^aeiouy]"); //check if single letter is not vowel regardless of case
            var regexCapital = new Regex("[A-Z]"); //check if single letter is capitalized
            
            if (String.IsNullOrEmpty(english))
            {
                latin = "No English text entered.";
            }
            else {
                string[] words = english.Split(' '); //split english string into string array of words
                for (int i = 0; i < words.Length; i++) //for every word
                {
                   string currentword = words[i];
                    capital = 0;
                    List<char> charList = currentword.ToList(); //charList holds all characters of current word
                    for (int j = 0; j < currentword.Length; j++)
                    {
                        if (regexCapital.IsMatch(charList[j].ToString())){
                            capital++;
                        }
                    }

                    if (regexAlpha.IsMatch(words[i])) //word contains only letters and apostrophe
                    {
                        if (regexStartVowel.IsMatch(words[i])) //word starts with vowel
                        {
                            words[i] = words[i] + "way"; //add "way" to end of word
                            if (capital == 1)
                            {
                                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                                words[i] = ti.ToTitleCase(words[i]);
                            }
                            if (capital > 1)
                            {
                                words[i] = words[i].ToUpper();
                            }
                        }

                        else //word starts with consonant
                        {
                            string end = "";
                            for (int k = 0; k < currentword.Length; k++) //iterate through charList
                            {
                                if (regexCons.IsMatch(currentword[k].ToString())) // letter is consonant
                                {
                                    end = end + currentword[k].ToString(); //add letter to "end" string
                                    charList.RemoveAt(0); //remove letter from charList
                                }
                                else //letter is vowel
                                {
                                    break; //exit for loop, stop examining letters
                                }
                            }
                            string beginning = string.Join("", charList); // characters remaining in charList are beginning of new word
                            words[i] = beginning + end + "ay";
                            if (capital == 1)
                            {
                                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                                words[i] = ti.ToTitleCase(words[i]);
                            }
                            if (capital > 1)
                            {
                                words[i] = words[i].ToUpper();
                            }
                        }
                    }
                    else if (regexEndPunc.IsMatch(words[i])) //has punctuation at end
                    {
                        //chop off end character and test against regex alpha
                        string chomped = words[i].Remove(words[i].Length - 1, 1);
                        if (regexAlpha.IsMatch(chomped)) //if all but end punctuation is alpha/apostrophe
                        {
                            string punctuation = "";
                            string end = "";
                            string beginning = "";

                            if (regexStartVowel.IsMatch(words[i])) //word starts with vowel
                            {
                                punctuation = charList[currentword.Length - 1].ToString(); // set punctuation variable to whatever punctuation is the last character in charList
                                charList.RemoveAt(currentword.Length - 1); //remove punctuation (last character in charList)
                                beginning = string.Join("", charList); // all characters remaining in charList are beginning of new word
                                words[i] = beginning + "way" + punctuation;
                                if (capital == 1)
                                {
                                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                                    words[i] = ti.ToTitleCase(words[i]);
                                }
                                if (capital > 1)
                                {
                                    words[i] = words[i].ToUpper();
                                }
                            }

                            else //word starts with consonant
                            {
                                punctuation = charList[currentword.Length - 1].ToString(); // set punctuation variable to whatever punctuation is the last character in charList
                                charList.RemoveAt(currentword.Length - 1); //remove punctuation (last character in charList)

                                for (int k = 0; k < currentword.Length; k++) //iterate through charList
                                {
                                    if (regexCons.IsMatch(currentword[k].ToString())) // letter is consonant
                                    {
                                        end = end + currentword[k].ToString(); //add letter to "end" string
                                        charList.RemoveAt(0); //remove letter from charList
                                    }
                                    else //letter is vowel
                                    {
                                        break; //exit for loop, stop examining letters
                                    }
                                }
                                beginning = string.Join("", charList); // characters remaining in charList are beginning of new word
                                words[i] = beginning + end + "ay" + punctuation;
                                if (capital == 1)
                                {
                                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                                    words[i] = ti.ToTitleCase(words[i]);
                                }
                                if (capital > 1)
                                {
                                    words[i] = words[i].ToUpper();
                                }
                            }
                        }
                        else
                        {
                            //word contains other than alpha/apostrophe so leave it alone
                        }                       
                    }
                    else //word contains numbers or symbols
                    {
                        //don't make any changes to word
                    }
                }
                string sep = " ";
                latin = String.Join(sep, words);
            }
            return latin;
        }
    }

    class PigGreekTranslator : ITranslator
    {
        public string translate(string english)
        {

            string greek;
            var regexAlpha = new Regex("^[a-zA-Z']*$");
            var regexEndPunc = new Regex(@"\p{P}$");
            var regexStartVowel = new Regex("(?i)^[aeiou]");
            var regexCons = new Regex("(?i)[^aeiouy]");
            var regexCapital = new Regex("[A-Z]"); //check if single letter is capitalized
            int capital;

            if (String.IsNullOrEmpty(english))
            {
                greek = "No English text entered.";
            }
            else
            {
                string[] words = english.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    string currentword = words[i];
                    capital = 0;
                    List<char> charList = currentword.ToList(); //charList holds all characters of current word
                    for (int j = 0; j < currentword.Length; j++)
                        
                    {
                        if (regexCapital.IsMatch(charList[j].ToString()))
                        {
                            capital++;
                        }
                    }
                    if (regexAlpha.IsMatch(words[i])) //word contains only letters and apostrophe
                    {
                        if (regexStartVowel.IsMatch(words[i])) //word starts with vowel
                        {
                            words[i] = words[i] + "oi"; //add "oi" to end of word
                            if (capital == 1)
                            {
                                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                                words[i] = ti.ToTitleCase(words[i]);
                            }
                            if (capital > 1)
                            {
                                words[i] = words[i].ToUpper();
                            }
                        }

                        else //word starts with consonant
                        {
                            string end = "";
                            currentword = words[i];

                            //List<char> charList = currentword.ToList(); //charList holds all characters of current word

                            for (int k = 0; k < currentword.Length; k++) //iterate through charList
                            {
                                if (regexCons.IsMatch(currentword[k].ToString())) // letter is consonant
                                {
                                    end = end + currentword[k].ToString(); //add letter to "end" string
                                    charList.RemoveAt(0); //remove letter from charList
                                }
                                else //letter is vowel
                                {
                                    break; //exit for loop, stop examining letters
                                }
                            }
                            string beginning = string.Join("", charList); // characters remaining in charList are beginning of new word
                            words[i] = beginning + end + "omatos";
                            if (capital == 1)
                            {
                                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                                words[i] = ti.ToTitleCase(words[i]);
                            }
                            if (capital > 1)
                            {
                                words[i] = words[i].ToUpper();
                            }
                        }
                    }
                    else if (regexEndPunc.IsMatch(words[i])) //has punctuation at end
                    {
                        //chop off end character and test against regex alpha
                        string chomped = words[i].Remove(words[i].Length - 1, 1);
                        if (regexAlpha.IsMatch(chomped)) //if all but end punctuation is alpha/apostrophe
                        {
                            string punctuation = "";
                            string end = "";
                            string beginning = "";
                            currentword = words[i];
                            //List<char> charList = currentword.ToList(); //charList holds all characters of current word

                            if (regexStartVowel.IsMatch(words[i])) //word starts with vowel
                            {
                                punctuation = charList[currentword.Length - 1].ToString(); // set punctuation variable to whatever punctuation is the last character in charList
                                charList.RemoveAt(currentword.Length - 1); //remove punctuation (last character in charList)
                                beginning = string.Join("", charList); // all characters remaining in charList are beginning of new word
                                words[i] = beginning + "oi" + punctuation;
                                if (capital == 1)
                                {
                                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                                    words[i] = ti.ToTitleCase(words[i]);
                                }
                                if (capital > 1)
                                {
                                    words[i] = words[i].ToUpper();
                                }
                            }

                            else //word starts with consonant
                            {
                                punctuation = charList[currentword.Length - 1].ToString(); // set punctuation variable to whatever punctuation is the last character in charList
                                charList.RemoveAt(currentword.Length - 1); //remove punctuation (last character in charList)

                                for (int k = 0; k < currentword.Length; k++) //iterate through charList
                                {
                                    if (regexCons.IsMatch(currentword[k].ToString())) // letter is consonant
                                    {
                                        end = end + currentword[k].ToString(); //add letter to "end" string
                                        charList.RemoveAt(0); //remove letter from charList
                                    }
                                    else //letter is vowel
                                    {
                                        break; //exit for loop, stop examining letters
                                    }
                                }
                                beginning = string.Join("", charList); // characters remaining in charList are beginning of new word
                                words[i] = beginning + end + "omatos" + punctuation;
                                if (capital == 1)
                                {
                                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                                    words[i] = ti.ToTitleCase(words[i]);
                                }
                                if (capital > 1)
                                {
                                    words[i] = words[i].ToUpper();
                                }
                            }
                        }
                        else
                        {
                            //word contains other than alpha/apostrophe so leave it alone
                        }
                    }
                    else //word contains numbers or symbols
                    {
                        //don't make any changes to word
                    }
                }
                string sep = " ";
                greek = String.Join(sep, words);
            }
            return greek;
        }
    }
}
