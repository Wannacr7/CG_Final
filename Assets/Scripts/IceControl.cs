using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class IceControl : MonoBehaviour
{
    [SerializeField] VisualEffect vfxIce;


    public void StartIceAttack()
    {
        vfxIce.SendEvent("OnPlay");
    }
}
