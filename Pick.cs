using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : MonoBehaviour
{
     public float RotationSpeed = 5;
     
     void Update () 
     {
     float rotX = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;     //tryng to limit limitation
     rotX = (Mathf.Clamp(rotX, -45.0f, 45.0f);                         //tryng to limit limitation
     transform.RotateAround(Vector3.forward, -rotX);                   //tryng to limit limitation
     Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
     transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
     }
     
}
