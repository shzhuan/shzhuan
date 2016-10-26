using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float speedNum = 0f;
    public Rigidbody rbody;
    public Camera cam;

    private float m_xMoveNum = 0f;
    private float m_zMoveNum = 0f;
    private float cameraRotationX = 0f;
    private float currentCameraRotationX = 0f;
    private float cameraRotationLimit = 85f;
    private Vector3 m_moveHorizontal = Vector3.zero;
    private Vector3 m_moveVertical = Vector3.zero;
    private Vector3 m_velocity = Vector3.zero;
    private Vector3 thrusterForce = Vector3.zero;
    private Vector3 rotation = Vector3.zero;

    void Update() {
        m_xMoveNum = Input.GetAxisRaw("Horizontal");
        m_zMoveNum = Input.GetAxisRaw("Vertical");
        m_moveHorizontal = transform.right * m_xMoveNum;
        m_moveVertical = transform.forward * m_zMoveNum;
        m_velocity = (m_moveHorizontal + m_moveVertical) * speedNum;
        float _yRot = Input.GetAxisRaw("Mouse X");
        float _xRot = Input.GetAxisRaw("Mouse Y");
    }

    void FixedUpdate() {
        PerformMovement();
        //PerformRotation();
    }

    private void PerformMovement() {
        if (m_velocity != Vector3.zero) {
            rbody.MovePosition(rbody.position + m_velocity * Time.fixedDeltaTime);
        }
    }
    
    private void PerformRotation() {
        rbody.MoveRotation(rbody.rotation * Quaternion.Euler(rotation));
        if (cam != null) {
            currentCameraRotationX -= cameraRotationX;
            currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);
            cam.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);
        }
    }

}
