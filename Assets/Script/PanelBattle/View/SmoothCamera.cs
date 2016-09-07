using UnityEngine;
using System.Collections;

public class SmoothCamera : MonoBehaviour {

    public Transform lookAtObject;
    public Vector3 positionOffset;
    public float smoothSpeed;
    public float rotateSpeed;
    public bool isSmooth = false;

    private float m_time = 0f;

    void LateUpdate() {
        float angles = lookAtObject.eulerAngles.y;
        if (isSmooth) {
            if (lookAtObject.eulerAngles.y > 180) {
                angles = 360 - angles;
            } else {
                angles = -angles;
            }
            float cornerAngle = Mathf.Tan(2 * Mathf.PI * (angles / 360));
            Debug.Log(cornerAngle);
            float distance = Mathf.Abs(transform.position.z);
            Vector3 targetPosition = lookAtObject.transform.position + positionOffset + new Vector3(cornerAngle * distance, 0f, 0f);
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
