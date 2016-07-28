using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Home {
    public class RoleItem : MonoBehaviour {
        public Image roleIcon;
        public Image selectImage;
        public Image recommendedImage;
        public Text roleName;
        public Button btnRole;

        private string m_Id;
        private bool m_isSelected = false;
        private bool m_recommended = false;

        public string RoleID
        {
            get { return m_Id; }
        }

        public bool IsSelscted
        {
            set {
                m_isSelected = value;
                SetBtnState(m_isSelected);
            }
            get { return m_isSelected; }
        }

        public bool IsRecommended
        {
            get { return m_recommended; }
        }

        public void Init(Model.RoleData data, bool isRecommended) {
            m_Id = data.id;
            roleName.text = data.roleName;
            roleIcon.sprite = data.icon;
            m_recommended = isRecommended;
            SetBtnState(false);
        }

        public void SetBtnState(bool isSelected) {
            m_isSelected = isSelected;
            if (isSelected) {
                selectImage.gameObject.SetActive(true);
                return;
            }
            selectImage.gameObject.SetActive(false);
        }

    }
}
