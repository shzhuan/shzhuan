using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Home {
    public class RoleItemList : MonoBehaviour {
        public RoleItem[] roleList;
        public Button btnOK;

        private bool m_isEnable = false;

        public bool Enable
        {
            get { return m_isEnable; }
        }

        public void Init() {
            SetRoleItemState(false);
            btnOK.gameObject.SetActive(false);
        }

        public void SetActive(bool value) {
            m_isEnable = value;
            gameObject.SetActive(value);
        }

        public void SetRoleItemState(bool isSelect) {
            for (int i = 0; i < roleList.Length; ++i) {
                roleList[i].IsSelscted = isSelect;
            }
        }

    }
}
