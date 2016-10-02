using UnityEngine;
using System.Collections;

public class ShowFPSOnScene : MonoBehaviour {
    
    private int m_frames = 0;
    private float m_oldTime = 0f;
    private float m_fps;

    public const float m_intervalTime = 0.5F;

    void Awake() {
        Application.targetFrameRate = 30;
    }

    void Start() {
        m_oldTime = Time.realtimeSinceStartup;
        m_frames = 0;
    }

    void Update() {
        ++m_frames;
        if (Time.realtimeSinceStartup > m_oldTime + m_intervalTime) {
            m_fps = m_frames / (Time.realtimeSinceStartup - m_oldTime);
            m_frames = 0;
            m_oldTime = Time.realtimeSinceStartup;
        }
    }

    void OnGUI() {
        GUILayout.Label("FPS:" + m_fps.ToString("0.00"));
    }

}
