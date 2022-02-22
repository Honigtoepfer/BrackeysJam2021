using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGObyOKey : MonoBehaviour
{
    
    [SerializeField] private GameObject key;
    [SerializeField] private GameObject obj;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject == key)
        {
            obj.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject == key)
        {
            obj.SetActive(true);
        }
    }

}
