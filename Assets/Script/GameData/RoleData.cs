using UnityEngine;
using System.Collections;
using System;

namespace Model {
    [Serializable]
    public class RoleData {
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
        public Sprite icon = null;

        public string skillId = "";
    }
}
