using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] shapePrefab;
    private Vector3 spawnPosition = new Vector3(0, 4, 0);

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(shapePrefab[DataManager.Instance.ObjectType], spawnPosition, shapePrefab[DataManager.Instance.ObjectType].transform.rotation);
    }

}
