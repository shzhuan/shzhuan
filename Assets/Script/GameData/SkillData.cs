using UnityEngine;
using System.Collections;
using System;

namespace Model {
    [Serializable]
    public class SkillData {
        public string id;
        public string skillName = "";
        public string detail = "";
        public float hpNum = 0;
        public float mpNum = 0;
        public float atkNum = 0;
        public float defNum = 0;
        public float dexNum = 0;
        public float lukNum = 0;
    }
}
