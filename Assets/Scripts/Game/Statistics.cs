public static class Statistics
{
    public static float _timeInGameTotal;
    public static int _coinsCollectedTotal;
    public static int _enemiesKilledTotal;
    public static int _starsforLevel;

    public static float _timeInGame;
    public static int _coinsCollected;
    public static int _enemiesKilled;


    public static void RefreshStats()
    {
        _timeInGameTotal += _timeInGame;
        _coinsCollectedTotal += _coinsCollected;
        _enemiesKilledTotal += _enemiesKilled;

        _timeInGame = 0;
        _coinsCollected = 0;
        _enemiesKilled = 0;
    }

    public static void ResetStatsOnLevel()
    {
        _timeInGame = 0;
        _coinsCollected = 0;
        _enemiesKilled = 0;
    }
}
