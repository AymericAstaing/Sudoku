using UnityEngine;

public class UserData
{
    private int _level = 0;
    private int _id = -1;

    public UserData(int id, int level)
    {
        _id = id;
        _level = level;
    }

    public UserData(UserData uData)
    {
        _id = uData.getId();
        _level = uData.getLevel();
    }

    public void resetVariables()
    {
        _id = -1;
        _level = 0;
    }

    public int getLevel()
    {
        return _level;
    }

    public int getId()
    {
        return _id;
    }

    public void setId(int id)
    {
        _id = id;
    }

    public void setLevel(int level)
    {
        _level = level;
    }
};