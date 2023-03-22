

class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter a word: ");
                string word = Console.ReadLine().ToLower();

                int[] count = new int[2];

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLetter(word[i]))
                    {
                        int index = word[i] - 'a';
                        count[index]++;
                    }
                }

                for (int i = 0; i < count.Length; i++)
                {
                    if (count[i] != 0)
                    {
                        Console.WriteLine((char)(i + 'a') + ": " + count[i]);
                    }
                }
            }
        }







    }
}   
}