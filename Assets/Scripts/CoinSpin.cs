using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(1, 0, 0); //Make coins spin clockwise
    }
}
