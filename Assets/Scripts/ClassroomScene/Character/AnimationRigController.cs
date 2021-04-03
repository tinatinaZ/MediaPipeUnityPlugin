using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class AnimationRigController : MonoBehaviour
{
    public bool usingGestureData = false;

    [Header("HandRigs")] 
    public GameObject leftHand;
    public GameObject leftHandNoGesture;
    public GameObject rightHand;
    public GameObject rightHandNoGesture;

    private void Update()
    {
        if (usingGestureData)
        {
            leftHand.GetComponent<TwoBoneIKConstraint>().weight = 1;
            foreach (ChainIKConstraint finger in leftHand.GetComponentsInChildren<ChainIKConstraint>())
            {
                finger.weight = 1;
            }
            rightHand.GetComponent<TwoBoneIKConstraint>().weight = 1;
            foreach (ChainIKConstraint finger in rightHand.GetComponentsInChildren<ChainIKConstraint>())
            {
                finger.weight = 1;
            }
            leftHandNoGesture.GetComponent<TwoBoneIKConstraint>().weight = 0;
            rightHandNoGesture.GetComponent<TwoBoneIKConstraint>().weight = 0;
        }
        else
        {
            leftHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
            foreach (ChainIKConstraint finger in leftHand.GetComponentsInChildren<ChainIKConstraint>())
            {
                finger.weight = 0;
            }
            rightHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
            foreach (ChainIKConstraint finger in rightHand.GetComponentsInChildren<ChainIKConstraint>())
            {
                finger.weight = 0;
            }
            leftHandNoGesture.GetComponent<TwoBoneIKConstraint>().weight = 1;
            rightHandNoGesture.GetComponent<TwoBoneIKConstraint>().weight = 1;
        }
    }
}
