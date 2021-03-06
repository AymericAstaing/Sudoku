using UnityEngine;

public class UserDataManager
{
    private UserData userData;
    public UserPreferences userPreferences;
    private static int MIN_ID_NBR = 1000000;
    private static int MAX_ID_NBR = 999999999;

    public UserDataManager()
    {
        getChildsReference();
        checkUserFistLog();
    }

    public UserData getUserData()
    {
        return userData;
    }

    private void getChildsReference()
    {
        userPreferences = new UserPreferences();
        userData = userPreferences.getUserData();
    }

    private void checkUserFistLog()
    {
        if (userData.getId() == 0)
            updateUserData(new UserData(Random.Range(MIN_ID_NBR, MAX_ID_NBR), userData.getLevel()));
    }

    public void updateUserData(UserData uData)
    {
        userPreferences.storeUserData(uData);
        userData = uData;
    }
};