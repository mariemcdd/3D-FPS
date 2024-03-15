using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            //add points to the score
            if(this.gameObject.tag == "Floating Target")
            {
                Destroy(this.gameObject);
            }
            //add grayscale to standing target later on
        }
    }
}
