using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CurlEf : MonoBehaviour {

    public Transform front;
    public Transform mask;
    public Transform gradOutter;
    public Vector3 pos = new Vector3(-240.0f, -470.0f, 0.0f) * 0.01f;

    void LateUpdate()
    {
        transform.position = this.pos;
        transform.eulerAngles = Vector3.zero;

        Vector3 pos = front.localPosition;
        float theta = Mathf.Atan2(pos.y, pos.x) * 180.0f / Mathf.PI;

        if (theta <= 0.0f || theta >= 90.0f) return;

        float deg = -(90.0f - theta) * 2.0f;
        front.eulerAngles = new Vector3(0.0f, 0.0f, deg);

        mask.position = (transform.position + front.position) * 0.5f;
        mask.eulerAngles = new Vector3(0.0f, 0.0f, deg*0.5f);

        gradOutter.position = mask.position;
        gradOutter.eulerAngles = new Vector3(0.0f, 0.0f, deg * 0.5f + 90.0f);

        transform.position = this.pos;
        transform.eulerAngles = Vector3.zero;
    }
}
