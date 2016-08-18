using UnityEngine;
using System.Collections;

namespace View.Battle {
    public class Person : MonoBehaviour {
        public GameObject flashObject;
        public Transform shakeObject;
        public bool isShake = false;
        public bool isFlash = false;

        protected Vector3 m_position = Vector3.zero;
        protected float m_shakeTime = 0.5f;
        protected float m_shakeRange = 6f;
        protected float m_flashTime = 0.3f;
        protected float m_repeatTime = 0.05f;
        protected bool m_isFlash = false;

        protected void ShakeWithTime() {
            if (m_shakeTime > 0) {
                shakeObject.localPosition = m_position + Random.insideUnitSphere * m_shakeRange;
                m_shakeTime -= Time.deltaTime;
            } else {
                isShake = false;
                m_shakeTime = 0.5f;
                shakeObject.localPosition = m_position;
            }
        }

        //Start invoke
        protected void RoleFlash() {
            if (isFlash) {
                if (m_flashTime > 0) {
                    m_isFlash = !m_isFlash;
                    flashObject.SetActive(m_isFlash);
                    m_flashTime -= Time.deltaTime;
                } else {
                    isFlash = false;
                    m_flashTime = 0.3f;
                    flashObject.SetActive(true);
                }
            }
        }

    }
}
