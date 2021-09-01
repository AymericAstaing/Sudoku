using UnityEngine;

public class UserPreferences
{
    private static string LEVEL = "userLevel";
    private static string ID = "userId";

    public void storeUserData(UserData u)
    {
        PlayerPrefs.SetInt(LEVEL, u.getLevel());
        PlayerPrefs.SetInt(ID, u.getId());
    }

    public UserData getUserData()
    {
        int level = PlayerPrefs.GetInt(LEVEL, 0);
        int id = PlayerPrefs.GetInt(ID, 0);
        return new UserData(id, level);
    }
};