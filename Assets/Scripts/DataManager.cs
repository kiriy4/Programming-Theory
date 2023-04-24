using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public int ObjectType { get; private set; }
    public int ColorType { get; private set; }
    public int SizeType { get; private set; }
    public bool PhysicsStatus{ get; private set; }
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void GetDataToUse(int objectType, int colorType, int sizeType, bool physicsStatus)
    {
        ObjectType = objectType;
        ColorType = colorType;
        SizeType = sizeType;
        PhysicsStatus = physicsStatus;
    }
}
