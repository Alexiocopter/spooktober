using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    public GameObject stuff;
    public GameObject stuff2;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("F1", 3f);
    }

    // Update is called once per frame
    void F1()
    {
        stuff.SetActive(false);
        stuff2.SetActive(false);
        Invoke("F2", Random.Range(0.03f, 0.1f));
    }
    void F2()
    {
        stuff.SetActive(true);
        stuff2.SetActive(true);
        Invoke("F1", Random.Range(0f, 4f));
    }
}
