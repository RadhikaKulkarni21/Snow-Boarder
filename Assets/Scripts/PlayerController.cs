using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rbd2;
    [SerializeField] float torqueAmount = 1;
    [SerializeField] float baseSpeed = 30f;
    [SerializeField] float boostSpeed = 20f;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        rbd2 = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
   
    void RotatePlayer()
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
