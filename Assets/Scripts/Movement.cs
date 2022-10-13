using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;

    private float HorizontalBound = 10f;
    private float TopBound = -4f;
    private float BottomBound = -11f;

    private float horizontal;
    private float vertical;

    void Update()
    {
        if (transform.position.x > HorizontalBound)
            transform.position = new Vector3(HorizontalBound, transform.position.y, transform.position.z);
        if (transform.position.x < -HorizontalBound)
            transform.position = new Vector3(-HorizontalBound, transform.position.y, transform.position.z);
        if (transform.position.z > TopBound)
            transform.position = new Vector3(transform.position.x, transform.position.y, TopBound);
        if (transform.position.z < BottomBound)
            transform.position = new Vector3(transform.position.x, transform.position.y, BottomBound);

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.forward * vertical * speed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
    }
}
