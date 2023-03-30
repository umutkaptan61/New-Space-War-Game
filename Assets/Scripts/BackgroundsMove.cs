using UnityEngine;

public class BackgroundsMove : MonoBehaviour
{
    public float moveSpeed;
 
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * moveSpeed, Space.World);
    }
}
