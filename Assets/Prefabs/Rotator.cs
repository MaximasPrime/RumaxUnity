using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public bool rotating = false;
    private bool clockwise;
    private Quaternion fromAngle, toAngle;
    private float alpha =0;
    List<GameObject> cubes = new List<GameObject>() { };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        if (rotating)
        {
            alpha += Time.deltaTime*3;
            transform.rotation=Quaternion.Slerp(fromAngle, toAngle, alpha );
        }        

        if (alpha>=1)
        {
            rotating = false;
            alpha = 0;
        }        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Cube>())
            cubes.Add(other.gameObject);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Cube>())
            cubes.Remove(other.gameObject);
    }
  

    public void Rotate(bool Clockwise)
    {
        rotating = true;
        foreach (GameObject cube in cubes)
        {
            cube.transform.parent = this.transform;
        }
        gameObject.GetComponent<BoxCollider>();
        fromAngle = gameObject.transform.rotation;
        if (clockwise)
          toAngle = Quaternion.Euler(fromAngle.eulerAngles + new Vector3(0, 0, 90));
        else
          toAngle = Quaternion.Euler(fromAngle.eulerAngles + new Vector3(0, 0, -90));
    }

}
