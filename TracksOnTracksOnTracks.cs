public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        return new List<string> { "C#", "Clojure", "Elm" };
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        for (int i = 0; i < languages.Count; i++)
        {
            if (languages[i] == language)
            {
                return true;
            }
        }
        return false;
    }

    public static List<string> ReverseList(List<string> languages)
    {
        List<string> result = new List<string>(languages);
        result.Reverse();
        return result;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count != 0)
        {
            if (languages[0] == "C#" || (languages[1]=="C#"&&languages.Count<=3))
            return true;
            else return false;
        }
        else { return false; }
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        List<string> values = new List<string>();
        for (int i = 0;i < languages.Count;i++)
        {
            if (languages[i] != language)
            {
                values.Add(languages[i]);
            }
        }
        return values;
    }

    public static bool IsUnique(List<string> languages)
    {
        for (int i = 0; i < languages.Count;i++)
        {
            for (int j = 0; j < languages.Count; j++)
            {
                if (languages[i] == languages[j]&& i!=j)
                {
                    return false;
                }                     
            }
        }
        return true;
    }
}
