using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    private UserDataManager userDataManager;

    public void Start()
    {
        getChildsReference();
    }

    private void getChildsReference()
    {
        userDataManager = new UserDataManager();
    }

    public bool gameDataInitialised()
    {
        return userDataManager.getUserData() != null;
    }

    public UserData getUserData()
    {
        return userDataManager.getUserData();
    }

    public void updataUserData(UserData uData)
    {
        userDataManager.updateUserData(uData);
    }
}