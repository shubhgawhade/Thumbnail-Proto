using System.Collections.Generic;

[System.Serializable]
public class PlayerData
{
    public Dictionary<string, string> login;
    public string username;
    public string email;
    public bool isCreator;
    public int coins;

    public PlayerData()
    {
        login = AppManager.Login;
        username = AppManager.UserName;
        isCreator = AppManager.IsCreator;
        coins = AppManager.Coins;
    }
}