using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPooling : MonoBehaviour {

    public GameObject prefab;

    private List<GameObject> objectPool = new List<GameObject>();

    void Start()
    {
        Spawn();
    }
    void Spawn()
    {
        GameObject g = objectPool.Find(IsInactiveObject);

        if (g == null)
        {
            g = Object.Instantiate(prefab) as GameObject;
        }
        else
        {
            g.SetActive(true);
        }
    }

    bool IsInactiveObject(GameObject g)
    {
       return !g.activeSelf;
    }
}
