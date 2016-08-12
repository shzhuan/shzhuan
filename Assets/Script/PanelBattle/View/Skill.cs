using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace View.Battle {
    public class Skill : MonoBehaviour {
        public enum Type { FRAME_ANIMATION, PARTICLE }
        public Type SkillType = Type.FRAME_ANIMATION;
        public SpriteRenderer spriteRenderer;
        public List<Sprite> spriteList = new List<Sprite>();
        public bool isPlay = false;
        public bool isLoop = false;
        public float delayTime = 0f;
        public int frameTime = 24;

        private float m_timeCnt = 0;
        
        void Update() {
            if (isPlay && SkillType == Type.FRAME_ANIMATION) {
                if (m_timeCnt >= delayTime) {
                    int frameCnt = (int)((m_timeCnt - delayTime) / frameTime);
                    if (frameCnt < spriteList.Count) {
                        spriteRenderer.sprite = spriteList[frameCnt];
                    }
                    if (isLoop) {
                        spriteRenderer.sprite = spriteList[frameCnt % spriteList.Count];
                    } else {
                        spriteRenderer.sprite = null;
                        isPlay = false;
                        m_timeCnt = 0;
                    }
                } else {
                    m_timeCnt += Time.deltaTime;
                }
            }
        }

    }
}
