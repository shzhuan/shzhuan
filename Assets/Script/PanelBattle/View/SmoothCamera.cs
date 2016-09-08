using UnityEngine;
using System.Collections;

public class SmoothCamera : MonoBehaviour {

    public Transform lookAtObject;
    public float smoothSpeed;
    public float rotateSpeed;
    public float unitDistance;
    public bool isSmooth = false;

    private Vector3 positionOffset = Vector3.zero;
    private float m_time = 0f;

    void LateUpdate() {
        float angles = lookAtObject.eulerAngles.y;
        if (isSmooth) {
            if (lookAtObject.eulerAngles.y > 180) {
                angles = 360 - angles;
            } else {
                angles = -angles;
            }
            float angleSin = Mathf.Sin(2 * Mathf.PI * (angles / 360));
            float angleCos = Mathf.Cos(2 * Mathf.PI * (angles / 360));
            positionOffset = new Vector3(angleSin * unitDistance, 3f, -Mathf.Abs(angleCos * unitDistance));
            Vector3 targetPosition = lookAtObject.transform.position + positionOffset;
            Quaternion targetRotation = lookAtObject.transform.rotation;
            m_time += Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotateSpeed);
            if (m_time > 1f) {
                isSmooth = false;
                m_time = 0;
            }
        }
    }

}
