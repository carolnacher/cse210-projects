record Reference(string Book, int Chapter, int VerseStart, int VerseEnd)
{

    public string Book { get; private set; } = Book;
    public int Chapter { get; private set; } = Chapter;
    public int VerseStart { get; private set; } = VerseStart;
    public int VerseEnd { get; private set; } = VerseEnd;

    
    public Reference(string book, int chapter, int verse) : this(book, chapter, verse, verse)
    {
    }
}