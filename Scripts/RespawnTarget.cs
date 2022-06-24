using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTarget : MonoBehaviour
{ 
    public int points = 0;

    //public GameObject target;
    //private Transform trans;
    //Vector3 randomPos;

    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Target")
        {
            Debug.Log("Target Hit");
            points += 1;
            Col.gameObject.SetActive(false);
        }
    }
}