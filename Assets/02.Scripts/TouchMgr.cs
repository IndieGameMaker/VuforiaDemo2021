using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMgr : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    private GameObject canvasObj;

    void Start()
    {
        
    }

    bool isVisible = false;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10.0f, Color.green);

        if (Physics.Raycast(ray, out hit, 10.0f, 1<<6))
        {
            canvasObj = hit.transform.Find("Canvas").gameObject;

            if (Input.GetMouseButtonDown(0))
            {
                isVisible = !isVisible;
                canvasObj.SetActive(isVisible);
            }
        }
    }
}
