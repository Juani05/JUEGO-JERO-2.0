using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playermovement : MonoBehaviour
{
    public Vector3 playerSpeed;
    public float movementSpeed;
    public GameObject myobject;
  
    // Start is called before the first frame update
    void Start()
    {
        myobject.transform.position = playerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
 
       transform.Translate(0, 0, movementSpeed);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(movementSpeed, 0, 0);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(movementSpeed, 0, 0);

        }
    }
}