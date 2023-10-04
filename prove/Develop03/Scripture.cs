public class Scripture
{
    private Reference _reference;
    private string[] _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' '); 
    }

    public string HideRandomWords(int numberToHide)
    {
        int counter = 0;
        string[] newHiddenWords = _words;
        string newString = "";
        while (counter < numberToHide)
        {
            Random random = new Random();
            int wordIndex = random.Next(_words.Count());
            while (_words[wordIndex].Contains('_') == true)
            {
                wordIndex = random.Next(_words.Count());
            }
            string randomWord = _words[wordIndex];
            string hiddenWord = "_____";
            foreach (string word in newHiddenWords)
            {
                if (word == randomWord)
                {
                    newHiddenWords[wordIndex] = hiddenWord + " ";
                }
            }
            counter += 1;
        }
        foreach (string word in newHiddenWords)
        {
            newString += word + " ";
        }
        return newString;
    }

    public bool IsCompletelyHidden()
    {
        bool wordIsHidden = false;
        foreach (string word in _words)
        {
            
            if (word.Contains("_") == true)
            {
                wordIsHidden = true;
            }
            else
            {
                wordIsHidden = false;
                break;
            }
        }
        return wordIsHidden;
    }

    public string GetDisplayText()
    {
        string wordsInList = "";
        foreach (string word in _words)
        {
            wordsInList += word + " ";
        }
        return wordsInList;
    }
}