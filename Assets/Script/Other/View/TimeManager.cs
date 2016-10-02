using UnityEngine;
using System.Collections;

public class TimeManager {
    
    private bool m_isRun;
    private float m_curTime;
    private float m_triggerTime;
    
    public delegate void EventHandler();
    public event EventHandler eventList;    //事件列表内的事件使用完一定要移除

    public TimeManager(float second) {
        m_curTime = 0.0f;
        m_triggerTime = second;
    }
    
    public void Start() {
        m_isRun = true;
    }
    
    public void Update(float deltaTime) {
        if (m_isRun) {
            m_curTime += deltaTime;
            if (m_curTime > m_triggerTime) {
                m_isRun = false;
                m_curTime = 0.0f;
                eventList();
            }
        }
    }
    
    public void Stop() {
        m_isRun = false;
    }
    
    public void Continue() {
        m_isRun = true;
    }
    
    public void Restart() {
        m_isRun = true;
        m_curTime = 0.0f;
    }
    
    public void ResetTriggerTime(float second) {
        m_triggerTime = second;
    }
    
}
