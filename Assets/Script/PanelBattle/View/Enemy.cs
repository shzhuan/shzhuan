using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Battle {
    public class Enemy : MonoBehaviour {
        public Image enemyImage;
        public Slider hpBar;
        public bool isShake = false;
        public bool isFlash = false;

        private int m_hp = 0;
        private int m_maxHp = 0;
        private int m_pp = 0;
        private int m_maxPp = 0;
        private Vector3 m_position = Vector3.zero;
        private float m_shakeTime = 0.5f;
        private float m_shakeRange = 6f;
        private float m_flashTime = 0.3f;
        private float m_repeatTime = 0.05f;
        private bool m_isFlash = false;

        void Start() {
            hpBar.value = 1;
        }

        void Update() {
            if (isShake) {
                ShakeWithTime();
            }
        }

        public void Init(Model.RoleData data) {
            enemyImage.sprite = data.icon;
            hpBar.value = 1f;
            m_hp = data.hpNum;
            m_maxHp = data.hpNum;
            m_pp = data.ppNum;
            m_maxPp = data.ppNum;
            m_position = this.transform.localPosition;
        }

        private void ShakeWithTime() {
            if (m_shakeTime > 0) {
                this.transform.localPosition = m_position + Random.insideUnitSphere * m_shakeRange;
                m_shakeTime -= Time.deltaTime;
            } else {
                isShake = false;
                m_shakeTime = 0.5f;
                this.transform.localPosition = m_position;
            }
        }

        //Start invoke
        private void RoleFlash() {
            if (isFlash) {
                if (m_flashTime > 0) {
                    m_isFlash = !m_isFlash;
                    enemyImage.gameObject.SetActive(m_isFlash);
                    m_flashTime -= Time.deltaTime;
                } else {
                    isFlash = false;
                    m_flashTime = 0.3f;
                    enemyImage.gameObject.SetActive(true);
                }
            }
        }

    }
}
