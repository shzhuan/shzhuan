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

    }
}