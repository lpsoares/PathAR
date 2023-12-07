using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject objPrefab;
    public GameObject target;
    public float lifetime;
    private GameObject newObj;


    void Update()
    {
        //print(newObj);
        if (newObj == null)
        {
            Spawn();
        }
    }


    void Spawn()
    {
        objPrefab.GetComponent<NavigationScript>().player = target.transform;
        newObj = Instantiate(objPrefab, transform.position, transform.rotation);
        Destroy(newObj, lifetime);
    }
    
}
