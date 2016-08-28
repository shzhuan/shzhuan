using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace Ctrl.Battle {
    public class SkillCtrl : MonoBehaviour {

        /*private Dictionary<string, GameObject> m_skillList = new Dictionary<string, GameObject>();

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
        }*/

    }
}
