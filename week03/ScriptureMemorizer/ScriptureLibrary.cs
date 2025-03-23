using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();

    public void AddScripture(Reference reference, string text)
    {
        _scriptures.Add(new Scripture(reference, text));
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0) return null;

        Random rand = new Random();
        return _scriptures[rand.Next(_scriptures.Count)];
    }
}
