using System;

class Scripture
{   
    Word Word = new Word();
    private List<string> _updatedScriptureList;
    private List<string> _wordsInScripture;
    private int _scriptureIndex;
    private List<string> _scriptures = new List<string> {"Look unto me in every thought doubt not fear not.",
     "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them",
     "O be wise; what can I say more"};


    public void Initialize()
    {
        Random random = new Random();
        _scriptureIndex = random.Next(0, _scriptures.Count());
        _wordsInScripture = ScripturetoList(_scriptures[_scriptureIndex]);
        _updatedScriptureList = _wordsInScripture;
    }
    public bool UpdateScripture()
    {
        bool _checkBool = Word.CheckWords(_updatedScriptureList);
        if (_checkBool == false)
        {
            _updatedScriptureList = Word.HideRandomWord(_updatedScriptureList);
        }
        return _checkBool;
    }
    public string ReconstructScripture()
    {
        return string.Join(" ", _updatedScriptureList);
    }

    private List<string> ScripturetoList(string Scripture){
        string[] _words = Scripture.Split(' '); 

        return new List<string>(_words);
    }

    public string GetScripture(){
        return _scriptures[_scriptureIndex];
    }

    public string GetUpdatedScripture(){
        return ReconstructScripture();
    }

    public List<string> GetWordsInScipture(){
        return _wordsInScripture;
    }

    public int GetScriptureIndex()
    {
        return _scriptureIndex;
    }
}