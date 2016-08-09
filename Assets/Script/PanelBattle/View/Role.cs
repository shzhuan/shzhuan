using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Battle {
    public class Role : MonoBehaviour {
        public Image roleIcon;
        public Button btnRole;
        public Slider hpBar;
        public Slider ppBar;
        public Text hpNum;
        public Text ppNum;
        public GameObject commandBtnList;
        public float shakeTime = 0.5f;
        public float shakeRange = 10f;
        public bool isShake = false;

        private int m_hp = 0;
        private int m_maxHp = 0;
        private int m_pp = 0;
        private int m_maxPp = 0;
        private Vector3 m_position = Vector3.zero;

        public int HPNum {
            set {
                m_hp = value;
                hpBar.value = m_hp / m_maxHp;
                hpNum.text = m_hp + "/" + m_maxHp;
            }
            get {
                return m_hp;
            }
        }

        public int PPNum
        {
            set
            {
                m_pp = value;
                ppBar.value = m_pp / m_maxHp;
                ppNum.text = m_pp + "/" + m_maxPp;
            }
            get
            {
                return m_pp;
            }
        }

        void Update() {
            if (isShake) {
                ShakeWithTime();
            }
        }

        public void Init(Model.RoleData data) {
            roleIcon.sprite = data.icon;
            hpNum.text = data.hpNum + "/" + data.hpNum;
            ppNum.text = data.ppNum + "/" + data.ppNum;
            hpBar.value = 1f;
            ppBar.value = 1f;
            m_hp = data.hpNum;
            m_maxHp = data.hpNum;
            m_pp = data.ppNum;
            m_maxPp = data.ppNum;
            m_position = this.transform.localPosition;
        }

        private void ShakeWithTime() {
            if (shakeTime > 0) {
                this.transform.localPosition = m_position + Random.insideUnitSphere * shakeRange;
                shakeTime -= Time.deltaTime;
            } else {
                shakeTime = 0;
                isShake = false;
                this.transform.localPosition = m_position;
            }
        }

    }
}