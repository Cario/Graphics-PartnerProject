using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
   void OnTriggerStay(Collider other)
    {
        Debug.Log("EnteredCollider");
        Destroy(gameObject);
    }
}
