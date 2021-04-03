using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigTransformController : MonoBehaviour
{
    [Header("KeyPointOfHandLandmarks")] 
    public Transform leftPoint0;
    public Transform leftPoint4;
    public Transform leftPoint8;
    public Transform leftPoint12;
    public Transform leftPoint16;
    public Transform leftPoint20;
    public Transform rightPoint0;
    public Transform rightPoint4;
    public Transform rightPoint8;
    public Transform rightPoint12;
    public Transform rightPoint16;
    public Transform rightPoint20;

    [Header("RigTransforms")] 
    public Transform leftWrist;
    public Transform leftThumb;
    public Transform leftIndex;
    public Transform leftMiddle;
    public Transform leftRing;
    public Transform leftPinky;
    public Transform rightWrist;
    public Transform rightThumb;
    public Transform rightIndex;
    public Transform rightMiddle;
    public Transform rightRing;
    public Transform rightPinky;

    // Update is called once per frame
    void Update()
    {
        leftWrist.SetPositionAndRotation(leftPoint0.position, leftPoint0.rotation);
        leftThumb.SetPositionAndRotation(leftPoint4.position, leftPoint4.rotation);
        leftIndex.SetPositionAndRotation(leftPoint8.position, leftPoint8.rotation);
        leftMiddle.SetPositionAndRotation(leftPoint12.position, leftPoint12.rotation);
        leftRing.SetPositionAndRotation(leftPoint16.position, leftPoint16.rotation);
        leftPinky.SetPositionAndRotation(leftPoint20.position, leftPoint20.rotation);
        
        rightWrist.SetPositionAndRotation(rightPoint0.position, rightPoint0.rotation);
        rightThumb.SetPositionAndRotation(rightPoint4.position, rightPoint4.rotation);
        rightIndex.SetPositionAndRotation(rightPoint8.position, rightPoint8.rotation);
        rightMiddle.SetPositionAndRotation(rightPoint12.position, rightPoint12.rotation);
        rightRing.SetPositionAndRotation(rightPoint16.position, rightPoint16.rotation);
        rightPinky.SetPositionAndRotation(rightPoint20.position, rightPoint20.rotation);
    }
}
