using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    Vector2 mousePosition;

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.transform.position = mousePosition;
    }
}
