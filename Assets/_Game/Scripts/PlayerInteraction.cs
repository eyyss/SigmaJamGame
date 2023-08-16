using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float Distance;
    public LayerMask layerMask;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, Distance,layerMask ))
            { 
              if(hit.collider != null)
              {
                IClickable clickable = hit.collider.GetComponent<IClickable>(); 
                if(clickable != null)
                {
                  clickable.OnClick();
                }
              }
            }
        }
    }
}
