class ScriptureLibrary
{
    
private List<Scripture> scriptures = new List<Scripture>();

    public void AddNewScripture()
    {
        Console.Write("Book: ");
        string book = Console.ReadLine();
        Console.Write("Chapter: ");
        if (int.TryParse(Console.ReadLine(), out int chapter))
        {
            Console.Write("Initial verse: ");
            if (int.TryParse(Console.ReadLine(), out int verseStart))
            {
                Console.Write("Final verse: ");
                if (int.TryParse(Console.ReadLine(), out int verseEnd))
                {
                    Reference reference;
                    if (verseStart == verseEnd)
                    {
                        reference = new Reference(book, chapter, verseStart);
                    }
                    else
                    {
                        reference = new Reference(book, chapter, verseStart, verseEnd);
                    }

                    Console.Write("Enter the text of the Scripture: ");
                    string passageText = Console.ReadLine();

                    Scripture scripture = new Scripture(reference, passageText);

                    scriptures.Add(scripture);
                    Console.WriteLine("Scripture added to library.\n");
                }
                else
                {
                    Console.WriteLine("Invalid final verse");
                }
            }
            else
            {
                Console.WriteLine("Invalid initial verse");
            }
        }
        else
        {
            Console.WriteLine("Invalid chapter");
        }
    }
     public void PracticeRandomScripture()
    {
        Random random = new Random();
        var randomScripture = GetRandomScripture(random);

        if (randomScripture != null)
        {
            Console.Clear();
            Console.WriteLine("Memorize Scripture");
            Console.WriteLine(randomScripture.GetRenderedText());
            int wordsToHide = 3;

            while (!randomScripture.AllWordsHidden())
            {
                Console.ReadLine();
                randomScripture.HideRandomWords(wordsToHide, random);
                Console.Clear();
                Console.WriteLine(randomScripture.GetRenderedText());
            }

            Console.WriteLine("All the words have been hidden. Were you able to memorize it?.\n");
        }
        else
        {
            Console.WriteLine("The Scripture library is empty. Please add the Scriptures first.");
        }
    }

    public ScriptureLibrary()
    {
        scriptures = new List<Scripture>();
    }

    public void AddScripture(Scripture scripture)
    {
        scriptures.Add(scripture);
    }

    public Scripture GetRandomScripture(Random random)
    {
        if (scriptures.Count > 0)
        {
            int index = random.Next(scriptures.Count);
            return scriptures[index];
        }
        return null;
    }
    
}