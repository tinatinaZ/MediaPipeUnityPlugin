using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class CharacterAnimController : MonoBehaviour
{
    public int id = -1;
    //public CharacterManager characterManager;
    public CharachterState bodyState; //TODO: delete this and change to characterManager.bodyState
    public bool rotateHeadByFaceConsume = true;
    public Transform headTransform = null;
    public GameObject animationRigController;
    
    [Header("IK Handlers")]
    public Transform rootAnchor = null;
    public Transform headAnchor = null;
    public Transform lookAtTarget = null;
    public Transform leftHandAnchor = null;
    public Transform rightHandAnchor = null;
    public Transform leftFootAnchor = null;
    public Transform rightFootAnchor = null;

    protected Animator bodyAnimator;
    protected Animation bodyAnimation;
    private Quaternion faceRotation = Quaternion.identity;
    
    /*
    // IK Handler of hands
    private const float LeftHandX = -0.1f, LeftHandZ = 0.1f;
    private const float RightHandX = 0.1f, RightHandZ = 0.1f;
    private const float HandY = 0.85f;
    private Vector3 leftHandIdleStandPos = new Vector3(-0.2f, 0.75f, 0.0f);
    private Vector3 rightHandIdleStandPos = new Vector3(0.2f, 0.75f, 0.0f);
    private Vector3 leftHandIdleSitPos = new Vector3(-0.1f, 0.45f, -0.15f);
    private Vector3 rightHandIdleSitPos = new Vector3(0.1f, 0.45f, -0.15f);
    private Vector3 leftHandIdleRot = new Vector3(90.0f, 0.0f, 90.0f);
    private Vector3 rightHandIdleRot = new Vector3(90.0f, 0.0f, -90.0f);
    // IK Handler of root
    private Vector3 sitRootPos = new Vector3(0.0f, 0.7f, -0.35f);
    private Vector3 standRootPos = new Vector3(0.0f, 1.0f, 0.0f);
    // IK Handler of feet
    private Vector3 leftFootPos = new Vector3(-0.1f, 0.1f, 0.0f);
    private Vector3 rightFootPos = new Vector3(0.1f, 0.1f, 0.0f);
    // IK Handler of head
    private const float LookAtX = 0.5f, LookAtY = 0.0f, LookAtZ = 0.0f;
    */

    public enum CharachterState
    {
        SitStill,
        Stand,
        Work,
        Walk,
    }

    void Start()
    {
        bodyAnimator = gameObject.GetComponent<Animator>();
        
        bodyAnimation = gameObject.GetComponent<Animation>();
    }

    private void Update()
    {
        headAnchor.position = headTransform.position;

        switch (bodyState)
        {
            case CharachterState.Stand:
                bodyAnimation.Play("Stand");
                animationRigController.GetComponent<AnimationRigController>().usingGestureData = false;
                break;
            case CharachterState.Walk:
                bodyAnimation.Play("Walk");
                animationRigController.GetComponent<AnimationRigController>().usingGestureData = false;
                break;
            case CharachterState.Work:
                bodyAnimation.Play("Work");
                animationRigController.GetComponent<AnimationRigController>().usingGestureData = true;
                break;
            default:
                bodyAnimation.Play("Sit");
                animationRigController.GetComponent<AnimationRigController>().usingGestureData = false;
                break;
        }
    }
} 