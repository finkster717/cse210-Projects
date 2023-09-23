using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        // Add all stored entries into the created file
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string line = $"{entry._date} | {entry._prompt} | {entry._entry}";
                outputFile.WriteLine(line);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine(); // Whitespace

        string fileName = file;
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] newEntry = line.Split("|");

            string loadedDate = newEntry[0];
            string loadedPrompt = newEntry[1];
            string loadedEntry = newEntry[2];

            Entry entry = new Entry();
            entry._date = loadedDate;
            entry._prompt = loadedPrompt;
            entry._entry = loadedEntry;
            _entries.Add(entry);
        }
        Console.WriteLine($"Your file ({fileName}) has been loaded.");
        Console.WriteLine(); // Whitespace
    }
}