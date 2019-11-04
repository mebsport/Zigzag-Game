using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    private void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Ball")
        {
            Invoke("FallDown", 0.5f);
        }
    }

    void FallDown()
    {
        GetComponentInParent<Rigidbody>().useGravity = true;

        Destroy(transform.parent.gameObject, 3);
    }
}
