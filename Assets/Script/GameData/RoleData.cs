using UnityEngine;
using System.Collections;
using System;

namespace Model {
    [Serializable]
    public class RoleData: IRaceData {
        public string id = "";
        public string type = "";
        public string roleName = "";
        public string detail = "";
        public int lv = 0;
        public float hpNum = 0;
        public float mpNum = 0;
        public float atkNum = 0;
        public float defNum = 0;
        public float dexNum = 0;
        public float lukNum = 0;
        public bool isIdle = true;
        public string skillId = "";

        private Sprite m_icon = null;
        private UnityEngine.Object m_skillPrefab = null;

        public Sprite Icon {
            get {
                m_icon = Resources.Load("RoleIcon/" + id) as Sprite;
                return m_icon;
            }
        }

        public UnityEngine.Object SkillPrefab {
            get {
                m_skillPrefab = Resources.Load("SkillPrefab" + id);
                return m_skillPrefab;
            }
        }

    }
}
