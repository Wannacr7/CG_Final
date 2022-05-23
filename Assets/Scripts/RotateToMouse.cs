using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
    public Camera cam;
    public float maxLength;

    private Ray rayMouse;
    private Vector3 pos;
    private Vector3 direcction;
    private Quaternion rotation;


    // Update is called once per frame
    void Update()
    {
        if(cam != null)
        {
            RaycastHit hit;
            var mousePos = Input.mousePosition;
            rayMouse = cam.ScreenPointToRay(mousePos);
            if (Physics.Raycast(rayMouse.origin, rayMouse.direction, out hit, maxLength))
            {
                RotateToMouseDirection(gameObject, hit.point);
            }
            else
            {
                var pos = rayMouse.GetPoint(maxLength);
                RotateToMouseDirection(gameObject, pos);
            }
        }
        
    }

    private void RotateToMouseDirection(GameObject obj,Vector3 point)
    {
        direcction = point - obj.transform.position;
        rotation = Quaternion.LookRotation(direcction);
        gameObject.transform.localRotation = Quaternion.Lerp(obj.transform.rotation, rotation, 1);

    }
    public Quaternion GetRotation()
    {
        return rotation;
    }
}
