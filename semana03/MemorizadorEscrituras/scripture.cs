using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _random = new Random();

        _words = text
            .Split(' ')
            .Select(word => new Word(word))
            .ToList();
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = _words
            .Where(word => !word.IsHidden())
            .ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);

            visibleWords[index].Hide();

            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string wordsText = string.Join(
            " ",
            _words.Select(word => word.GetDisplayText())
        );

        return $"{_reference.GetDisplayText()} - {wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}