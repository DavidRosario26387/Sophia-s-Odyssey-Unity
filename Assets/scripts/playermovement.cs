
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float moveSpeed=3;
    public float leftRightSpeed=4;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*moveSpeed,Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x>levelboundary.leftSide)
            {
                transform.Translate(Vector3.left*Time.deltaTime*leftRightSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {   if (this.gameObject.transform.position.x<levelboundary.rightSide)
            {
                transform.Translate(Vector3.left*Time.deltaTime*leftRightSpeed*-1);
            }
        }

    }
}
