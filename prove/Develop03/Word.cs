class Word
{
    public string Text { get; private set; }
    public bool Hidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public string GetRenderedText()
    {
        if (Hidden)
        {
            return new string('-', Text.Length);
        }
        else
        {
            return Text;
        }
    }
}