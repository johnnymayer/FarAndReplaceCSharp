using Microsoft.AspNetCore.Mvc;

namespace Far.Models
{
  public class FarInputs
  {
    private string _phrase;
    private string _find;
    private string _replace;


    public FarInputs(string phrase, string find, string replace)
    {
      _phrase = phrase;
      _find = find;
      _replace = replace;
    }

    public string GetPhrase()
    {
      return _phrase;
    }

    public string GetFind()
    {
      return _find;
    }

    public string GetReplace()
    {
      return _replace;
    }

    public string FindAndReplace()
    {
      string replacer = _phrase.Replace(_find, _replace);
      return replacer;
    }

  }
}
