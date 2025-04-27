using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rbd2;
    [SerializeField] float torqueAmount = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbd2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rbd2.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rbd2.AddTorque(-torqueAmount);
        }
    }
}
