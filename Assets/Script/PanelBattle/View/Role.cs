using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Battle {
    public class Role : MonoBehaviour, IRace {
        public Image roleIcon;
        public Button btnRole;
        public Slider hpBar;
        public Slider mpBar;
        public Text txtHpNum;
        public Text txtMpNum;
        public Transform shakeObject;
        public GameObject commandBtnList;
        public UnityEngine.Object skillPrefab;

        private int m_hp = 0;
        private int m_maxHp = 0;
        private int m_pp = 0;
        private int m_maxPp = 0;
        private string m_skillId = "";
        private float m_shakeTime = 0.5f;
        private float m_shakeRange = 6f;
        private bool m_isShake = false;
        private Vector3 m_position = Vector3.zero;

        public int HpNum {
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

        public int MpNum
        {
            set
            {
                m_pp = value;
                mpBar.value = m_pp / m_maxPp;
                txtMpNum.text = m_pp + "/" + m_maxPp;
                if (m_pp < (int)(m_maxPp * 0.1)) {
                    txtMpNum.color = Color.red;
                } else {
                    txtMpNum.color = Color.green;
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
            m_position = shakeObject.localPosition;
        }

        void Update() {
            if (m_isShake) {
                ShakeWithTime();
            }
        }

        public void InitData(Model.RoleData data) {
            roleIcon.sprite = data.Icon;
            txtHpNum.text = data.hpNum + "/" + data.hpNum;
            txtMpNum.text = data.mpNum + "/" + data.mpNum;
            txtHpNum.color = Color.green;
            txtMpNum.color = Color.green;
            hpBar.value = 1f;
            mpBar.value = 1f;
            skillPrefab = data.SkillPrefab;
            m_hp = (int)data.hpNum;
            m_maxHp = (int)data.hpNum;
            m_pp = (int)data.mpNum;
            m_maxPp = (int)data.mpNum;
            m_skillId = data.skillId;
            m_position = this.transform.localPosition;
        }

        public void AttackAnimation() {
            //To Do
        }

        public void UnderAttackAnimation() {
            m_isShake = true;
        }

        public void CommandStateActive(bool active) {
            btnRole.interactable = active;
        }

        private void ShakeWithTime() {
            if (m_shakeTime > 0) {
                shakeObject.localPosition = m_position + Random.insideUnitSphere * m_shakeRange;
                m_shakeTime -= Time.deltaTime;
            } else {
                m_isShake = false;
                m_shakeTime = 0.5f;
                shakeObject.localPosition = m_position;
            }
        }

    }
}