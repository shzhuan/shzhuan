using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Ctrl.Battle {
    public class RoleCtrl : MonoBehaviour {
        public View.Battle.RoleItem role;
        public List<GameObject> skillList;

        public void SkillToRole(View.Battle.RoleItem role) { }

        private void InstantiateSkillOnRole() {
            GameObject skillObject = Instantiate(role.skillPrefab) as GameObject;
            skillObject.transform.parent = role.transform;
            skillObject.transform.localPosition = Vector3.zero;
            skillObject.transform.localScale = Vector3.one;
        }

    }
}
