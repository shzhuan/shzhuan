using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Battle {
    public class RoleList : MonoBehaviour {
        public Role[] roleList;
        public GridLayoutGroup gridGroup;

        void Start() {
            gridGroup.enabled = true;
        }

        public void SortEnd() {
            gridGroup.enabled = false;
        }

        public void ShakeAllRole() {
            for (int i = 0; i < roleList.Length; ++i) {
                if (roleList[i].gameObject.activeSelf) {
                    roleList[i].isShake = true;
                }
            }
        }

    }
}