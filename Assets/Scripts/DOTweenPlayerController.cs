using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTweenPlayerController : MonoBehaviour
{
    Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rbody.velocity += new Vector3(0.0f, 10.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.F9))
        {
            Debug.Log("LocalPositionX:" + transform.localPosition.x + " PositionX:" + transform.position.x);
        }
        transform.localPosition = new Vector3(0.0f, transform.position.y, 0.0f);
    }
}
