using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Billboard : MonoBehaviour
{
    private Transform camTr;

    // Start is called before the first frame update
    void Start()
    {
        camTr = Camera.main.transform;
    }

    void LateUpdate()
    {
        transform.LookAt(camTr.position);
    }
}
