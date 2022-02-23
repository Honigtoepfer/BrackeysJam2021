using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGObyOKey : MonoBehaviour
{
    
    [SerializeField] private GameObject key;
    [SerializeField] private GameObject obj;
    [SerializeField] private GameObject[] Lights;

    void Start()
    {
        Lights[1].SetActive(false);
        Lights[0].SetActive(true);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject == key)
        {
            obj.SetActive(false);
            Lights[0].SetActive(false);
            Lights[1].SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject == key)
        {
            obj.SetActive(true);
            Lights[1].SetActive(false);
            Lights[0].SetActive(true);
        }
    }

}
