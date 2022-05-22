using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreController : MonoBehaviour
{
    [SerializeField] GameObject[] hands;
    [SerializeField] GameObject[] cores;
    // Start is called before the first frame update
    void Start()
    {
        StopCore();
    }

    // Update is called once per frame
    void Update()
    {
        cores[0].transform.position = hands[0].transform.position;
        cores[1].transform.position = hands[1].transform.position;

    }
    public void StartCore()
    {
        foreach (var core in cores)
        {
            core.SetActive(true);
        }
    }
    public void StopCore()
    {
        foreach (var core in cores)
        {
            core.SetActive(false);
        }
    }
}
