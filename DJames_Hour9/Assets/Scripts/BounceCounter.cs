using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    float BallBounce = 0f;

    void OnCollisionEnter(Collision collision)
    {
        BallBounce = BallBounce + 1f;

        Debug.Log("BallBounces = " + BallBounce);
    }

    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {

       

    }
}
