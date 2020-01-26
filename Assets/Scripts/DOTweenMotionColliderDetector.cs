using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOTweenMotionColliderDetector : MonoBehaviour
{
    public bool isCollition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        isCollition = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isCollition = false;
    }

    public bool IsCollition()
    {
        return isCollition;
    }
}
