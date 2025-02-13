using UnityEngine;

public class BillBoard : MonoBehaviour
{
    void Update()
    {
        Vector3 direction = Camera.main.transform.position - transform.position;
        direction.y = 0;

        transform.rotation = Quaternion.LookRotation(-direction);
    }
}
