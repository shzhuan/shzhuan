using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Ctrl.Battle {
    public class RoleCtrl : MonoBehaviour {
        public View.Battle.Role role;
        public List<GameObject> skillList;

        public void AtkToEnemy(View.Battle.Enemy enemy) { }

        public void SkillToRole(View.Battle.Role role) { }

        public void SkillToEnemy(View.Battle.Enemy enemy) { }

        private void PlaySkillOnRole() {
            GameObject skillObject = Instantiate(role.skillPrefab) as GameObject;
            skillObject.transform.parent = role.transform;
            skillObject.transform.localPosition = Vector3.zero;
            skillObject.transform.localScale = Vector3.one * 100;
            skillObject.GetComponent<View.Battle.SkillAnimation>().isPlay = true;
        }

        private void PlaySkillOnRole(View.Battle.Role role, Vector3 position) {
            GameObject skillObject = Instantiate(this.role.skillPrefab) as GameObject;
            skillObject.transform.parent = role.transform;
            skillObject.transform.localPosition = Vector3.zero;
            skillObject.transform.localScale = Vector3.one * 100;
            skillObject.GetComponent<View.Battle.SkillAnimation>().isPlay = true;
        }

        private void PlaySkillOnEnemy(View.Battle.Enemy enemy, Vector3 position) {
            GameObject skillObject = Instantiate(role.skillPrefab) as GameObject;
            skillObject.transform.parent = enemy.transform;
            skillObject.transform.localPosition = Vector3.zero;
            skillObject.transform.localScale = Vector3.one;
            skillObject.GetComponent<View.Battle.SkillAnimation>().isPlay = true;
        }

    }
}
