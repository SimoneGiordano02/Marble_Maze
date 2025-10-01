using UnityEngine;

public class BoardController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotationSpeed = 50f;
    public float maxRotation = 10f;

    // Update is called once per frame
    void Update()
    {
        float rotationX = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        float rotationZ = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime * -1;

        Vector3 currentRotation = transform.localEulerAngles;

        //Convert the range to [-180, 180]
        if (currentRotation.x > 180f) currentRotation.x -= 360f;
        if (currentRotation.z > 180f) currentRotation.z -= 360f;

        float newRotationX = Mathf.Clamp(currentRotation.x + rotationX, -maxRotation, maxRotation);
        float newRotationZ = Mathf.Clamp(currentRotation.z + rotationZ, -maxRotation, maxRotation);

        transform.localEulerAngles = new Vector3(newRotationX, currentRotation.y, newRotationZ);

    }
}
