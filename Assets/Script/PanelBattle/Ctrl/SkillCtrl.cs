using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Ctrl.Battle {
    public class SkillCtrl : MonoBehaviour {

        private Dictionary<string, GameObject> m_skillList = new Dictionary<string, GameObject>();

        void Start() {
        }

        public void BattleEnd() {
            m_skillList.Clear();
        }

        public void SkillAtk() {

        }

        private void PlayEffect(string skillId, Transform target) {
            if (m_skillList.ContainsKey(skillId)) {
                m_skillList[skillId].GetComponent<View.Battle.SkillAnimation>().isPlay = true;
                return; 
            }
            Object skillPrefab = Resources.Load("Prefab/Skill/" + skillId);
            GameObject skillObject = Instantiate(skillPrefab) as GameObject;
            skillObject.transform.parent = target;
            skillObject.transform.localPosition = Vector3.zero;
            skillObject.transform.localScale = Vector3.one;
            m_skillList.Add(skillId, skillObject);
            skillObject.GetComponent<View.Battle.SkillAnimation>().isPlay = true;
        }

        private void SkillEffectToRole(View.Battle.Role role, Model.SkillData skill) {
            switch (skill.skillType) {
                case Model.SkillData.SkillType.DAMAGE:
                    SkillDamageToRole(role, skill);
                    break;
                case Model.SkillData.SkillType.BUFF:
                    SkillBuffToRole(role, skill);
                    break;
                case Model.SkillData.SkillType.DEBUFF:
                    SkillDeBuffToRole(role, skill);
                    break;
                default:
                    break;
            }
        }

        private void SkillEffectToEnemy(View.Battle.Role enemy, Model.SkillData skill) {
            switch (skill.skillType) {
                case Model.SkillData.SkillType.DAMAGE:
                    SkillDamageToEnemy(enemy, skill);
                    break;
                case Model.SkillData.SkillType.BUFF:
                    SkillBuffToEnemy(enemy, skill);
                    break;
                case Model.SkillData.SkillType.DEBUFF:
                    SkillDeBuffToEnemy(enemy, skill);
                    break;
                default:
                    break;
            }
        }

        private void SkillDamageToRole(View.Battle.Role role, Model.SkillData skill) {
            role.HPNum -= skill.damageNum;
        }

        private void SkillBuffToRole(View.Battle.Role role, Model.SkillData skill) { }

        private void SkillDeBuffToRole(View.Battle.Role role, Model.SkillData skill) { }

        private void SkillDamageToEnemy(View.Battle.Role enemy, Model.SkillData skill) {
            enemy.HPNum -= skill.damageNum;
        }

        private void SkillBuffToEnemy(View.Battle.Role enemy, Model.SkillData skill) { }

        private void SkillDeBuffToEnemy(View.Battle.Role enemy, Model.SkillData skill) { }

    }
}
