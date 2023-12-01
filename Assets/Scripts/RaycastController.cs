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
                    OpenScene1();
                }
            }
        }
    }

    void OpenScene1()
    {
        SceneManager.LoadScene("Scene1");
    }
}