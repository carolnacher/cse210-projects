class Scripture
{
    public Reference Reference { get; }
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.Reference = reference;
        this.words = InitializeWords(text);
    }

    private List<Word> InitializeWords(string text)
    {
        string[] wordArray = text.Split(' ');
        return wordArray.Select(word => new Word(word)).ToList();
    }

    public string GetRenderedText()
{
    List<string> renderedWords = words.Select(word => word.GetRenderedText()).ToList();
    string verseRange = Reference.VerseStart == Reference.VerseEnd
        ? $"{Reference.Chapter}:{Reference.VerseStart}"
        : $"{Reference.Chapter}:{Reference.VerseStart}-{Reference.VerseEnd}";
    return $"{Reference.Book} {verseRange}: {string.Join(" ", renderedWords)}";
}
    public void HideRandomWords(int wordsToHide, Random random)
    {
        List<Word> visibleWords = words.Where(word => !word.Hidden).ToList();
        int wordsHidden = 0;
        while (wordsHidden < wordsToHide && visibleWords.Count > 0)
        {
            int indexToHide = random.Next(visibleWords.Count);
            visibleWords[indexToHide].Hide();
            wordsHidden++;
            visibleWords.RemoveAt(indexToHide);
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.Hidden);
    }
    
}