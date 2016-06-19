using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class UIPropWidget : Graphic {

    public List<Vector2> maxPropVector;
    public List<int> testProp;
    public bool withAnimation = true;

    private const int VERTEX_SIZE = 8;                  // 必须为4的倍数  通过绘制两个四边形组成一个五边形
    private const float ANIMATION_TIME = 0.8f;
    private const float MAX_PROP_VALUE = 100.0f;

    private List<Vector2> m_propList = new List<Vector2>();
    private List<Vector2> m_currentList = new List<Vector2>();
    private List<UIVertex> m_vertexList = new List<UIVertex>();

    private bool m_isStartAnimation = false;
    private bool m_isAnimationFinish = false;
    private bool m_isSetValue = false;
    private float m_startTime = 0;
    private float m_currentTime = 0;

    protected void Awake() {
        m_isStartAnimation = false;
        m_isAnimationFinish = false;
        m_isSetValue = false;

        for (int i = 0; i < VERTEX_SIZE; ++i) {
            m_propList.Add(Vector2.zero);
            m_currentList.Add(Vector2.zero);
        }
    }

    // 设置五个属性值
    public void SetPropList(List<int> list, bool withAnimation = false) {
        if (list.Count < 5) {
            return;
        }

        // 给每个属性顶点赋值
        m_propList[0] = (maxPropVector[0] - Vector2.zero) * list[2] / MAX_PROP_VALUE;
        m_propList[2] = (maxPropVector[2] - Vector2.zero) * list[0] / MAX_PROP_VALUE;
        m_propList[3] = (maxPropVector[3] - Vector2.zero) * list[1] / MAX_PROP_VALUE;
        m_propList[4] = (maxPropVector[4] - Vector2.zero) * list[3] / MAX_PROP_VALUE;
        m_propList[6] = (maxPropVector[6] - Vector2.zero) * list[0] / MAX_PROP_VALUE;
        m_propList[7] = (maxPropVector[7] - Vector2.zero) * list[4] / MAX_PROP_VALUE;

        // 1 5值是一样的，根据0 4位置连线取中点获取
        m_propList[1] = (m_propList[0] + m_propList[4]) / 2;
        m_propList[5] = (m_propList[0] + m_propList[4]) / 2;

        m_isSetValue = true;

        if (withAnimation) {
            PlayAnimation();
        } else {
            for (int i = 0; i < VERTEX_SIZE; ++i) {
                m_currentList[i] = m_propList[i];
            }
        }

        SetVerticesDirty();
    }

    // 开始播放动画
    public void PlayAnimation() {
        m_isAnimationFinish = false;
        m_isStartAnimation = true;
        m_startTime = Time.time;
    }

    void Update() {
        if (m_isAnimationFinish || !m_isSetValue || !m_isStartAnimation) {
            return;
        }

        // 动画播放完毕
        if (Time.time - m_startTime >= ANIMATION_TIME) {
            for (int i = 0; i < VERTEX_SIZE; ++i) {
                m_currentList[i] = m_propList[i];
            }
            m_isAnimationFinish = true;
            return;
        }

        // 更新当前动画的数据
        float percent = (Time.time - m_startTime) / ANIMATION_TIME;
        for (int i = 0; i < VERTEX_SIZE; ++i) {
            m_currentList[i] = m_propList[i] * percent;
        }
        SetVerticesDirty();
    }

    private void UpdateVertex(List<UIVertex> vbo, List<Vector2> list) {
        // 必须要保证填充的是4的倍数
        for (int i = 0; i < VERTEX_SIZE; ++i) {
            var vert = UIVertex.simpleVert;
            vert.color = color;
            if (i < list.Count) {
                vert.position = list[i];
            } else {
                vert.position = list[list.Count - 1];
            }
            vbo.Add(vert);
        }
    }

    protected override void OnFillVBO(List<UIVertex> vbo) {
        if (!m_isSetValue) {
            return;
        }
        UpdateVertex(vbo, m_currentList);
    }

}
