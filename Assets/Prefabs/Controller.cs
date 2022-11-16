using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject topObject;
    public GameObject bottomObject;
    public GameObject leftObject;
    public GameObject rightObject;
    public GameObject frontObject;
    public GameObject backObject;

    Rotator Top,Bottom,Left,Right,Front,Back;


    void Start()
    {
        Top = topObject.GetComponent<Rotator>();
        Bottom = bottomObject.GetComponent<Rotator>();
        Left = leftObject.GetComponent<Rotator>();
        Right = rightObject.GetComponent<Rotator>();
        Front = frontObject.GetComponent<Rotator>();
        Back = backObject.GetComponent<Rotator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && CanRotate())
        {
            Top.Rotate(true);
        }
        if (Input.GetKeyDown(KeyCode.S) && CanRotate())
        {
            Bottom.Rotate(true);
        }
        if (Input.GetKeyDown(KeyCode.A) && CanRotate())
        {
            Left.Rotate(true);
        }
        if (Input.GetKeyDown(KeyCode.D) && CanRotate())
        {
            Right.Rotate(true);
        }
        if (Input.GetKeyDown(KeyCode.Q) && CanRotate())
        {
            Front.Rotate(true);
        }
        if (Input.GetKeyDown(KeyCode.E) && CanRotate())
        {
            Back.Rotate(true);
        }



        if (Input.GetMouseButtonDown(0))
        {
            // Left mouse was pressed 
        }

    }

    bool CanRotate()
    {
        return !Top.rotating
            && !Bottom.rotating
            && !Left.rotating
            && !Right.rotating
            && !Front.rotating
            && !Back.rotating;
    }
}
