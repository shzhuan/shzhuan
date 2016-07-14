using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Home {
    public class RoleItem : MonoBehaviour {
        public Image roleIcon;
        public Image selectImage;
        public Image recommendedImage;
        public Button btnRole;

        private int m_roleId;
        private bool m_isSelected = false;
        private bool m_recommended = false;

        public int RoleID
        {
            get { return m_roleId; }
        }

        public bool IsSelscted
        {
            set {
                m_isSelected = value;
                BtnState(m_isSelected);
            }
            get { return m_isSelected; }
        }

        public bool IsRecommended
        {
            get { return m_recommended; }
        }

        public void Init(int id, Sprite icon, bool isRecommended) {
            m_roleId = id;
            roleIcon.sprite = icon;
            m_recommended = isRecommended;
            BtnState(false);
        }

        public void BtnState(bool isSelected) {
            m_isSelected = isSelected;
            if (isSelected) {
                selectImage.gameObject.SetActive(true);
                return;
            }
            selectImage.gameObject.SetActive(false);
        }

    }
}
