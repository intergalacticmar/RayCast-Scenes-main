using UnityEngine;

public class RayCast : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {

                Debug.Log("Objeto seleccionado: " + hit.collider.gameObject.name);
            }
        }
    }
}

