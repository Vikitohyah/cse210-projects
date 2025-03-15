public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }


    public void DisplayAllEntry()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // Save using a delimiter that won’t interfere
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }

    }

    public void LoadFromFile(string file)
    {
         _entries.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry entry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };
            _entries.Add(entry);
        }
    }
}