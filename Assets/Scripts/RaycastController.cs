using UnityEngine;
using UnityEngine.SceneManagement;

public class RaycastController : MonoBehaviour
{
    public float raycastDistance = 10f;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, raycastDistance))
        {
            if (hit.collider != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (hit.collider.gameObject.CompareTag("Cube1"))
                    {
                        OpenScene("Scene1");
                    }
                    else if (hit.collider.gameObject.CompareTag("Sphere"))
                    {
                        OpenScene("Scene2");
                    }
                    else if (hit.collider.gameObject.CompareTag("Cube2"))
                    {
                        OpenScene("Scene3");
                    }
                }
            }
        }
    }

    void OpenScene(string Scene1)
    {
        SceneManager.LoadScene(Scene1);
    }
}