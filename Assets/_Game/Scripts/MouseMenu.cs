using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMenu : MonoBehaviour
{
    public float sensitivity = 1.0f; // Hassasiyet ayarı
    public float maxRotation = 15.0f; // Maksimum rotasyon miktarı

    private Vector2 rotation = Vector2.zero;
    


    private void Update()
    {
        rotation += new Vector2(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X")) * sensitivity;

        rotation.x = Mathf.Clamp(rotation.x, -maxRotation, maxRotation);
        rotation.y = Mathf.Clamp(rotation.y,-maxRotation, maxRotation);

        transform.localRotation = Quaternion.Lerp(transform.localRotation, 
            Quaternion.Euler(rotation.x, rotation.y, 0),Time.deltaTime*5);
    }
}
