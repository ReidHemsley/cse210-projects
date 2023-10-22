using System;
using System.Diagnostics.Contracts;

class Reference
{
    
    private List<string> _references = new List<string> {"Doctrine & Covenants 6:36 - ", "1 Nephi 3:7 - ", "Jacob 6:12 - "};

    public string GetReference(int _referenceIndex)
    {
        return _references[_referenceIndex];
    }
}