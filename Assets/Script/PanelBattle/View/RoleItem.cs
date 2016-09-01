using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Battle {
    public class RoleItem : MonoBehaviour {
        public Image roleIcon;
        public Button btnRole;
        public Text txtHpNum;
        public Text txtMpNum;
        public Transform shakeObject;
        public GameObject commandBtnList;
        public UnityEngine.Object skillPrefab;

        private int m_hp = 0;
        private int m_maxHp = 0;
        private int m_mp = 0;
        private int m_maxMp = 0;
        //private float m_shakeTime = 0.5f;
        //private float m_shakeRange = 6f;
        //private bool m_isShake = false;
        private float m_duration = 0.5f;
        private Vector3 m_position = Vector3.zero;
        private Vector3 m_from = Vector3.zero;
        private Vector3 m_to = new Vector3(220f, 0f, 0f);

        public int HpNum {
            set {
                m_hp = value;
                if (m_hp < (int)(m_maxHp * 0.2)) {
                    txtHpNum.color = Color.red;
                } else {
                    txtHpNum.color = Color.green;
                }
                txtHpNum.text = m_hp.ToString();
            }
            get {
                return m_hp;
            }
        }

        public int MpNum
        {
            set
            {
                m_mp = value;
                if (m_mp < (int)(m_maxMp * 0.2)) {
                    txtMpNum.color = Color.red;
                } else {
                    txtMpNum.color = Color.green;
                }
                txtMpNum.text = m_mp.ToString();
            }
            get
            {
                return m_mp;
            }
        }
        
        void Start() {
            m_position = shakeObject.localPosition;
        }

        void Update() {
            //if (m_isShake) {
                //ShakeWithTime();
            //}
        }

        public void InitData(Model.RoleData data) {
            roleIcon.sprite = data.Icon;
            txtHpNum.text = data.hpNum.ToString();
            txtMpNum.text = data.mpNum.ToString();
            txtHpNum.color = Color.green;
            txtMpNum.color = Color.green;
            skillPrefab = data.SkillPrefab;
            m_hp = (int)data.hpNum;
            m_maxHp = (int)data.hpNum;
            m_mp = (int)data.mpNum;
            m_maxMp = (int)data.mpNum;
            m_position = this.transform.localPosition;
        }

        public void AttackAnimation() {
            //To Do
        }

        public void UnderAttackAnimation() {
            //m_isShake = true;
        }

        public void CommandStateActive(bool active) {
            btnRole.interactable = active;
        }

        public void ItemMoveAnimation() {
            float distance = m_from.x - m_to.x;
            float unitDistance = distance / (m_duration / Time.deltaTime);
        }

        public void ItemBackAnimation() { }

        private void HorizontalMoveAnimation() {
            this.m_position += new Vector3();
        }

        /*private void ShakeWithTime() {
            if (m_shakeTime > 0) {
                shakeObject.localPosition = m_position + Random.insideUnitSphere * m_shakeRange;
                m_shakeTime -= Time.deltaTime;
            } else {
                m_isShake = false;
                m_shakeTime = 0.5f;
                shakeObject.localPosition = m_position;
            }
        }*/

    }
}