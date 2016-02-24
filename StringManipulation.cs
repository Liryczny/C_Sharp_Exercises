using System;
using System.Text.RegularExpressions;
    public class StringManipulation
    {
        public static void Main(string[] args)
        {
            String _optionStr, _word, _word2;
            String _conosants = "bcdfghjklmnpqrstvwxyz";
            String _vowels = "aeiou";
            String _row1 = "qwertyuiop";
            String _row2 = "asdfghjkl";
            String _row3 = "zxcvbnm";
            int _option;
            bool isAllLetters = false;

            PrintMenu();

            Console.Write("Please enter your option in a range from 1-4: ");
            _optionStr = Console.ReadLine();
            Console.WriteLine();

            if (int.TryParse(_optionStr, out _option) && _option < 5 && _option > 0)
                {
                    switch (_option)
                    {
                        case 1:
                            Console.Write("Please enter first word: ");
                            _word = Console.ReadLine();
                            Console.Write("Please enter second word: ");
                            _word2 = Console.ReadLine();
                            isAllLetters = Regex.IsMatch(_word, @"^[a-zA-Z ]+$");
                            isAllLetters = Regex.IsMatch(_word2,@"^[a-zA-Z ]+$");
                            Console.WriteLine();
                            if(isAllLetters){
                                 Anagram(_word,_word2);
                            }
                            else{
                            Console.WriteLine("The word that you have entered is invalid!");
                            }
                         break;    
                        case 2:
                            Console.Write("Please enter your word: ");
                            _word = Console.ReadLine();
                            isAllLetters = Regex.IsMatch(_word, @"^[a-zA-Z ]+$");
                            if(isAllLetters){
                                 Palindrome(_word);
                            }
                            else{
                            Console.WriteLine("The word that you have entered is invalid!");
                            }
                            break;
                        case 3:
                            Console.Write("Please enter your word: ");
                            _word = Console.ReadLine();
                            isAllLetters = Regex.IsMatch(_word, @"^[a-zA-Z ]+$");
                            if(isAllLetters){
                                ConosantsAndVowels(_word, _conosants, _vowels);
                            }
                            else{
                            Console.WriteLine("The word that you have entered is invalid!");
                            }                          
                            break;
                        case 4:
                            Console.Write("Please enter your word: ");
                            _word = Console.ReadLine();
                            isAllLetters = Regex.IsMatch(_word, @"^[a-zA-Z ]+$");
                            if(isAllLetters){
                                RowOfKeyboard(_word, _row1, _row2, _row3);
                            }
                            else{
                            Console.WriteLine("The word that you have entered is invalid!");
                            }            
                            break;
                        default:
                            break;
                    }
                }
            else
            {
                Console.WriteLine("The number that you have entered is invalid!");
            }
        }     
        public static void Anagram(String word, String word2)
        {
            word.ToLower();
            word2.ToLower();
            word.Trim();
            word2.Trim();
            char[] letters = word.ToCharArray();
            char[] letters2 = word2.ToCharArray();
            bool isAnagram = false;

            if (letters.Length == letters2.Length)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    for (int j = 0; j < letters2.Length; j++)
                    {
                        if (letters[i] == letters2[j])
                        {
                            letters2[j] = ' ';
                        }
                    }
                }
                for (int k = 0; k < letters.Length; k++)
                {
                    if (letters2[k] != ' ')
                    {
                        isAnagram = false;
                    }
                    else
                    {
                        isAnagram = true;
                    }
                }
            }
            if (isAnagram == true)
            {
                Console.WriteLine("{0} and {1} are Anagrams",word,word2);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not Anagrams", word,word2);
            }   
        }
        public static void Palindrome(String word)
        {
            word.ToLower();
            word.Trim();
            char[] letters = word.ToCharArray();
            bool palindrome = true;
            
            for(int start = 0, end = letters.Length - 1; start <= end; start++, end--){
                if (!letters[start].Equals(letters[end]) && palindrome)
                {
                    palindrome = false;
                    break;
                } 

            }
            if (palindrome)
            {
                Console.WriteLine("\"{0}\"" + " is a palindrome",word.ToUpper());
            }
            else
            {
                Console.WriteLine("\"{0}\"" + " is not a palindrome",word.ToUpper());
            }
        }
        public static void ConosantsAndVowels(String word, String conosants, String vowels)
        {
            int counterConosants = 0;
            int counterVowels = 0;
            word.ToLower();
            word.Trim();

            char[] letters = word.ToCharArray();
            char[] conosantsChar = conosants.ToCharArray();
            char[] vowelsChar = vowels.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < conosants.Length; j++)
                {
             
                    if (letters[i].Equals(conosantsChar[j]))
                    {
                        counterConosants++;
                    }
                    else if(j < 5 && letters[i].Equals(vowelsChar[j]) )
                    {
                        counterVowels++;
                    }

                }
            }

            Console.WriteLine("There are {0} Conosants and {1} Vowels", counterConosants, counterVowels);
        }        
        public static void RowOfKeyboard(String word, String row1, String row2, String row3)
        {
            word.ToLower();
            word.Trim();
            char[] letters = word.ToCharArray();
            char[] row1Char = row1.ToCharArray();
            char[] row2Char = row2.ToCharArray();
            char[] row3Char = row3.ToCharArray();

            int row1Counter = 0;
            int row2Counter = 0;
            int row3Counter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < row1Char.Length; j++)
                {
                    if (letters[i].Equals(row1Char[j]))
                    {
                        row1Counter++;
                    }
                    else if (j < 9 && letters[i].Equals(row2Char[j]))
                    {
                        row2Counter++;
                    }
                    else if (j < 7 && letters[i].Equals(row3Char[j]))
                    {
                        row3Counter++;
                    }
                }
            }

            Console.WriteLine("There are {0} letters in row 1\nThere are {1} letters in row 2\nThere are {2} letters in row 3", row1Counter, row2Counter, row3Counter);
        }
        public static void PrintMenu()
        {
            Console.WriteLine("\nPlease choose your option:\n________________________________________________________\n1.Anagram\n2.Palindrome\n3.Check how many Consonant and Vowels are in the word\n4.How many letters in a row of Keyboard\n________________________________________________________");
        }
    }

