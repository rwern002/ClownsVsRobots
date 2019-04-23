using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sObj;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Mouse is over: " + hit.collider.name);
            GameObject hitObj = hit.transform.root.gameObject;
            hoverObject(hitObj);
        }

        else
        {
            noSelect();
        }
    }

    void hoverObject(GameObject obj)
    {
        if (sObj != null)
        {
            if (obj = sObj)
            {
                return;
            }

            noSelect();
        }

        sObj = obj;
        Renderer[] rs = sObj.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
        {
            Material m = r.material;
            m.color = Color.green;
            r.material = m;
        }
    }

    void noSelect()
    {
        sObj = null;
    }
}
