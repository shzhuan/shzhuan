using UnityEngine;
using System.Collections;
using System;

namespace Model {
    [Serializable]
    public class SkillData : MonoBehaviour {
        public string id;
        public enum SkillType {DAMAGE, BUFF, DEBUFF};
        public SkillType skillType = SkillType.DAMAGE;
        public string skillName;
        public string skilldetail;
        public int damageNum;
        public int buffNum;
        public int deBuffNum;
        public float continueTime;
        public View.Battle.SkillAnimation skillAnimation;
    }
}
