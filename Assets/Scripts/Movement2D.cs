using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0.0f;
    [SerializeField]
    private Vector3 moveDirection = Vector3.zero;

    public float MoveSpeed => moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    public void MoveTo(Vector3  direction)
    {
        moveDirection = direction;
    }    
}
