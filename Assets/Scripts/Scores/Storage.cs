using UnityEngine;

public static class Storage
{
    private const string LevelKey = "level_stars_count_{0}";

    public static void SetStars(int starsQuant, int levelNum)
    {
        PlayerPrefs.SetInt(GetLevelKey(levelNum), starsQuant); 
    }

    public static int GetStars(int levelNum)
    {
        return PlayerPrefs.GetInt(GetLevelKey(levelNum));        
    }

    private static string GetLevelKey(int levelNum)
    {
        return string.Format(LevelKey, levelNum);
    }
}
