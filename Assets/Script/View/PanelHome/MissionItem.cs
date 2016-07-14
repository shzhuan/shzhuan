using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Home {
    public class MissionItem : MonoBehaviour {

        public Image selectImage;
        public Image missionState; 
        public Text missionDetail;
        public Button btnMisson;

        private int m_missionId = 0;
        private bool m_isSelected = false;

        public int MissionID
        {
            get { return m_missionId; }
        }

        public bool IsSelscted
        {
            set {
                m_isSelected = value;
                BtnState(m_isSelected);
            }
            get { return m_isSelected; }
        }

        public void Init(int id, string detail) {
            missionState.gameObject.SetActive(false);
            m_missionId = id;
            SetMissionDetail(detail);
        }

        public void BtnState(bool isSelected) {
            m_isSelected = isSelected;
            if (isSelected) {
                selectImage.color = new Color(selectImage.color.r, selectImage.color.g, selectImage.color.b, 1);
                return;
            }
            selectImage.color = new Color(selectImage.color.r, selectImage.color.g, selectImage.color.b, 0.8f);
        }

        private void SetMissionDetail(string detail) {
            missionDetail.text = detail;
        }

    }
}
