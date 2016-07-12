using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Home {
    public class RoleItem : MonoBehaviour {
        public Image roleIcon;
        public Image selectImage;
        public Image stateImage;
        public Image recommendedImage;

        private int m_roleId;
        private bool m_isSelected;
        private bool m_recommended;

        public int RoleID
        {
            get { return m_roleId; }
        }

        public bool IsSelscted
        {
            get { return m_isSelected; }
        }

        public void Init(int id, Sprite roleIcon) {
            m_roleId = id;

        }

    }
}
