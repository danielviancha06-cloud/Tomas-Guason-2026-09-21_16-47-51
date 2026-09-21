using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Camara : MonoBehaviour
{

    public Transform XD;
    public float speedCamara = 0.022f;
    public Vector3 displacement;

    private void LateUpdate()
    {
        Vector3 desiredPosition = XD.position + displacement;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, speedCamara);

        transform.position = smoothedPosition;
    }
}
