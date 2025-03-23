using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> _words;
    public Reference Reference { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWord()
    {
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count > 0)
        {
            Random rand = new Random();
            visibleWords[rand.Next(visibleWords.Count)].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden);
    }

    public string Display()
    {
        var wordDisplay = string.Join(" ", _words.Select(w => w.ToString()));
        return $"{Reference.GetFormatted()} ::: {wordDisplay}";
    }
}
