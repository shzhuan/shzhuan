using UnityEngine;
using System.Collections;

public class SmoothCamera : MonoBehaviour {

    public Transform lookAtObject;
    public float moveTime;
    public float moveDelayTime;
    public float rotateTime;
    public float rotateDelayTime;
    public float unitDistance;
    public bool isSmooth = false;
    public EaseType moveType = EaseType.linearTween;

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
            Vector3 targetRotation = lookAtObject.eulerAngles;
            m_time += Time.deltaTime;
            if (moveType == EaseType.linearTween) {
                gameObject.MoveTo(targetPosition, moveTime, moveDelayTime);
                gameObject.RotateTo(targetRotation, rotateTime, rotateDelayTime);
            } else {
                gameObject.MoveTo(targetPosition, moveTime, moveDelayTime, moveType);
                gameObject.RotateTo(targetRotation, rotateTime, rotateDelayTime, moveType);
            }
            if (m_time > 1f) {
                isSmooth = false;
                m_time = 0;
            }
        }
    }

}
