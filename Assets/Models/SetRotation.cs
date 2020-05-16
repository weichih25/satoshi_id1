using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRotation : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotateAngle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, this.rotateAngle * Time.deltaTime, 0);
    }
}
