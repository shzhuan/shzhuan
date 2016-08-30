using UnityEngine;
using System.Collections;
using System;

namespace Model {
    [Serializable]
    public class PropData {
        public string id = "";
        public string type = "";
        public string propName = "";
        public string detail = "";
        public float hpNum = 0;
        public float mpNum = 0;
        public float atkNum = 0;
        public float defNum = 0;
        public float dexNum = 0;
        public float lukNum = 0;

        private Sprite m_icon = null;

        public Sprite Icon
        {
            get
            {
                m_icon = Resources.Load("RoleIcon/" + id) as Sprite;
                return m_icon;
            }
        }
    }
}
