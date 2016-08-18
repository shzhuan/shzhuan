using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

namespace View.Battle {
    [Serializable]
    public class SkillAnimation : MonoBehaviour {
        public enum AnimationType { FRAME_ANIMATION, PARTICLE }
        public enum SpriteType {SPRITERENDERER, IMAGE }
        public AnimationType animationType = AnimationType.FRAME_ANIMATION;
        public SpriteType spriteType = SpriteType.SPRITERENDERER;
        public SpriteRenderer spriteRenderer;
        public Image image;
        public List<Sprite> spriteList = new List<Sprite>();
        public bool isPlay = false;
        public bool isLoop = false;
        public float delayTime = 0f;
        public float frameTime = 0.04f; //0.04=1/24

        private float m_timeCnt = 0;
        private float m_frameCnt = 0;

        void Update() {
            if (isPlay) {
                if (spriteType == SpriteType.SPRITERENDERER) {
                    SpriteRendererFrameAnimation();
                } else if(spriteType == SpriteType.IMAGE) {
                    ImageFrameAnimation();
                }
            }
        }

        private void SpriteRendererFrameAnimation() {
            if (animationType == AnimationType.FRAME_ANIMATION) {
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

        private void ImageFrameAnimation() {
            if (animationType == AnimationType.FRAME_ANIMATION) {
                if (m_timeCnt >= delayTime) {
                    m_frameCnt = (int)((m_timeCnt - delayTime) / frameTime);
                    if (m_frameCnt < spriteList.Count) {
                        image.sprite = spriteList[(int)m_frameCnt];
                    } else {
                        if (isLoop) {
                            image.sprite = spriteList[0];
                        } else {
                            image.sprite = null;
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
