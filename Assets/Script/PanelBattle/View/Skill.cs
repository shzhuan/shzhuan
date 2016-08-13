﻿using UnityEngine;
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
        public float frameTime = 0.04f; //0.04=1/24

        private float m_timeCnt = 0;
        private float m_frameCnt = 0;

        void Update() {
            if (isPlay && SkillType == Type.FRAME_ANIMATION) {
                if (m_timeCnt >= delayTime) {
                    m_frameCnt = (int)((m_timeCnt - delayTime) / frameTime);
                    if (m_frameCnt < spriteList.Count) {
                        spriteRenderer.sprite = spriteList[(int)m_frameCnt];
                    } else {
                        if (isLoop) {
                            spriteRenderer.sprite = spriteList[0];
                        } else {
                            spriteRenderer.sprite = null;
                            isPlay = false;
                        }
                        m_frameCnt = 0f;
                        m_timeCnt = 0;
                    }
                }
                m_timeCnt += Time.deltaTime;
            }
        }

    }
}
