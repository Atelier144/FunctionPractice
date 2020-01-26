using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTweenPathWay : MonoBehaviour
{
    [SerializeField] Vector3[] waypoints;

    [SerializeField] GameObject gameObjectChildren;
    [SerializeField] GameObject gameObjectMotionColliderDetector;

    DOTweenMotionColliderDetector motionColliderDetector;

    Tween tween;
    // Start is called before the first frame update
    void Start()
    {
        motionColliderDetector = gameObjectMotionColliderDetector.GetComponent<DOTweenMotionColliderDetector>();
        tween = transform.DOPath(waypoints, 10.0f, PathType.Linear, PathMode.Full3D).SetLookAt(0.01f, Vector3.forward).SetEase(Ease.Linear).SetLoops(-1).Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObjectChildren.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            if (!motionColliderDetector.IsCollition())
            {
                tween.PlayForward();
            }
            else
            {
                tween.Pause();
            }

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObjectChildren.transform.localRotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
            if (!motionColliderDetector.IsCollition())
            {
                tween.PlayBackwards();
            }
            else
            {
                tween.Pause();
            }
        }
        else
        {
            tween.Pause();
        }
    }
}
