using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxPoints : MonoBehaviour
{
    public static MaxPoints instance;
    public int maxPoints;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public int getMaxPoints()
    {
        return maxPoints;
    }

    public void setMaxPoints(int maxPoints)
    {
        this.maxPoints = maxPoints;
    }
}
