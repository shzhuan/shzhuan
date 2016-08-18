using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Battle {
    public class Role : Person {
        public Image roleIcon;
        public Button btnRole;
        public Slider hpBar;
        public Slider ppBar;
        public Text txtHpNum;
        public Text txtPpNum;
        public GameObject commandBtnList;
        public GameObject skillPrefab;

        private int m_hp = 0;
        private int m_maxHp = 0;
        private int m_pp = 0;
        private int m_maxPp = 0;
        private string m_skillId = "";

        public int HPNum {
            set {
                m_hp = value;
                hpBar.value = m_hp / m_maxHp;
                txtHpNum.text = m_hp + "/" + m_maxHp;
                if (m_hp < (int)(m_maxHp * 0.1)) {
                    txtHpNum.color = Color.red;
                } else {
                    txtHpNum.color = Color.green;
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
                txtPpNum.text = m_pp + "/" + m_maxPp;
                if (m_pp < (int)(m_maxPp * 0.1)) {
                    txtPpNum.color = Color.red;
                } else {
                    txtPpNum.color = Color.green;
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
            m_position = shakeObject.localPosition;
        }

        void Update() {
            if (isShake) {
                ShakeWithTime();
            }
        }

        public void Init(Model.RoleData data) {
            roleIcon.sprite = data.icon;
            txtHpNum.text = data.hpNum + "/" + data.hpNum;
            txtPpNum.text = data.ppNum + "/" + data.ppNum;
            txtHpNum.color = Color.green;
            txtPpNum.color = Color.green;
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

    }
}