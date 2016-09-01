using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Battle {
    public class RoleList : MonoBehaviour {
        public RoleItem[] roleList;
        public GridLayoutGroup gridGroup;

        void Start() {
            gridGroup.enabled = true;
        }

        public void SortEnd() {
            gridGroup.enabled = false;
        }

    }
}