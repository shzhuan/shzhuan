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
        public GameObject skillPrefab;
        public bool isShake = false;
        public bool isFlash = false;

        private int m_hp = 0;
        private int m_maxHp = 0;
        private int m_pp = 0;
        private int m_maxPp = 0;
        private string m_skillId = "";
        private Vector3 m_position = Vector3.zero;
        private float m_shakeTime = 0.5f;
        private float m_shakeRange = 6f;
        private float m_flashTime = 0.3f;
        private float m_repeatTime = 0.05f;
        private bool m_isFlash = false;

        public int HPNum {
            set {
                m_hp = value;
                hpBar.value = m_hp / m_maxHp;
                hpNum.text = m_hp + "/" + m_maxHp;
                if (m_hp < (int)(m_maxHp * 0.1)) {
                    hpNum.color = Color.red;
                } else {
                    hpNum.color = Color.green;
                }
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
                ppBar.value = m_pp / m_maxPp;
                ppNum.text = m_pp + "/" + m_maxPp;
                if (m_pp < (int)(m_maxPp * 0.1)) {
                    ppNum.color = Color.red;
                } else {
                    ppNum.color = Color.green;
                }
            }
            get
            {
                return m_pp;
            }
        }

        public string SkillID {
            get { return m_skillId; }
        }

        void Start() {
            InvokeRepeating("RoleFlash", 0f, m_repeatTime);
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
            hpNum.color = Color.green;
            ppNum.color = Color.green;
            hpBar.value = 1f;
            ppBar.value = 1f;
            m_hp = data.hpNum;
            m_maxHp = data.hpNum;
            m_pp = data.ppNum;
            m_maxPp = data.ppNum;
            m_skillId = data.skillId;
            m_position = this.transform.localPosition;
        }

        public void CommandStateActive(bool active) {
            btnRole.interactable = active;
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
                    btnRole.gameObject.SetActive(m_isFlash);
                    m_flashTime -= Time.deltaTime;
                } else {
                    isFlash = false;
                    m_flashTime = 0.3f;
                    btnRole.gameObject.SetActive(true);
                }
            }
        }

    }
}