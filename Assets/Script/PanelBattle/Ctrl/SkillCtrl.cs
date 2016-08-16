using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Ctrl.Battle {
    public class SkillCtrl : MonoBehaviour {

        private Dictionary<string, GameObject> m_skillList = new Dictionary<string, GameObject>();

        public void BattleEnd() {
            m_skillList.Clear();
        }

        public void PlayEffect(View.Battle.Role source, Transform target) {
            if (m_skillList.ContainsKey(source.SkillID)) {
                m_skillList[source.SkillID].GetComponent<View.Battle.SkillAnimation>().isPlay = true;
                return; 
            }
            Object skillPrefab = null;//To Do
            GameObject skillObject = Instantiate(skillPrefab) as GameObject;
            skillObject.transform.parent = target;
            skillObject.transform.localPosition = Vector3.zero;
            skillObject.transform.localScale = Vector3.one;
            m_skillList.Add(source.SkillID, skillObject);
            skillObject.GetComponent<View.Battle.SkillAnimation>().isPlay = true;
        }

        private void SkillEffect(Model.SkillData skill) {
            switch (skill.skillType) {
                case Model.SkillData.SkillType.DAMAGE:
                    SkillDamage();
                    break;
                case Model.SkillData.SkillType.BUFF:
                    SkillBuff();
                    break;
                case Model.SkillData.SkillType.DEBUFF:
                    SkillDeBuff();
                    break;
                default:
                    break;
            }
        }

        private void SkillDamage() { }

        private void SkillBuff() { }

        private void SkillDeBuff() { }

    }
}
