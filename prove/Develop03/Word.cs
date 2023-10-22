using System;
using System.ComponentModel;

class Word
{
    private List<string> _updatedScriptureList = new List<string>();
    private List<int> _visibleWords = new List<int>();


    public List<string> HideRandomWord(List<string> _wordsInScripture)
    {
        _updatedScriptureList = _wordsInScripture;
        Random random = new Random();
        int _randomIndex = random.Next(0, _visibleWords.Count());
        int _indexRandomVis = _visibleWords[_randomIndex];
        _updatedScriptureList[_indexRandomVis] = "_____";
        return _updatedScriptureList;
    }

    public bool CheckWords(List<string> _wordsInScripture)
    {
        _visibleWords.Clear();

        foreach (string _word in _wordsInScripture)
        {
            if (_word != "_____")
            {
                int _index = _wordsInScripture.IndexOf(_word);
                _visibleWords.Add(_index);
            }
        }
        if (_visibleWords.Count() == 0)
        {
            return true;
        }
        return false;
    }
}