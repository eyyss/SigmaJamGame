using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float Distance;
    public LayerMask layerMask;
    public TextMeshProUGUI infoText;
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, Distance, layerMask))
        {
            if (hit.collider != null)
            {
                IClickable clickable = hit.collider.GetComponent<IClickable>();
                if (clickable != null)
                {
                    infoText.text = clickable.GetInfo();
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        clickable.OnClick();
                    }
                }
            }
        }
        else
        {
            infoText.text = string.Empty;
        }
    }
    
}
