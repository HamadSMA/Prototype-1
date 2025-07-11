using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public GameObject TPSCamera;
    public GameObject FPSCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FPSCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal1");
        forwardInput = Input.GetAxis("Vertical1");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TPSCamera.SetActive(!TPSCamera.activeSelf);
            FPSCamera.SetActive(!FPSCamera.activeSelf);
        }
        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotate vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}