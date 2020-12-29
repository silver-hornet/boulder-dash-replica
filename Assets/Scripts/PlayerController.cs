using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    Vector3 pos;

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") < 0 && transform.position == pos)
            pos += Vector3.left;
        if (Input.GetAxisRaw("Horizontal") > 0 && transform.position == pos)
            pos += Vector3.right;
        if (Input.GetAxisRaw("Vertical") > 0 && transform.position == pos)
            pos += Vector3.up;
        if (Input.GetAxisRaw("Vertical") < 0 && transform.position == pos)
            pos += Vector3.down;

        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * moveSpeed);
    }
}