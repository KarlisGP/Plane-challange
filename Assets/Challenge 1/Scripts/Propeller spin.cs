using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    // Adjust this in the Inspector to make it spin faster or slower
    public float spinSpeed = 1000.0f;

    void Update()
    {
        // Vector3.right is the X-axis
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}