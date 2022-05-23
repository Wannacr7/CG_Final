using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Animator modelAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Space works");
            modelAnim.SetTrigger("Spell");
           // parSys2.Play();
        }
    }
    public void startVFX()
    {
        Debug.Log("Start VFX");

    }
}
