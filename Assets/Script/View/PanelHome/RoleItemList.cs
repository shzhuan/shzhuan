using UnityEngine;
using System.Collections;

namespace View.Home {
    public class RoleItemList : MonoBehaviour {
        public RoleItem[] roleList;

        private bool m_isEnable = false;

        public bool Enable
        {
            get { return m_isEnable; }
        }

        public void SetActive(bool value) {
            m_isEnable = value;
            gameObject.SetActive(value);
        } 

    }
}
