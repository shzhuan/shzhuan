using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Home {
    public class MissionItem : MonoBehaviour {

        public Image selectImage;
        public Image missionState;
        public Text missionTitle;
        public Text missionDetail;
        public Button btnMisson;

        private string m_missionId = "";
        private bool m_isSelected = false;

        public string MissionID
        {
            get { return m_missionId; }
        }

        public bool IsSelscted
        {
            set {
                m_isSelected = value;
                SetBtnState(m_isSelected);
            }
            get { return m_isSelected; }
        }

        public void Init(Model.Mission.MissionData data) {
            missionState.gameObject.SetActive(false);
            m_missionId = data.id;
            missionTitle.text = data.title;
            missionDetail.text = data.detail;
        }

        public void SetBtnState(bool isSelected) {
            m_isSelected = isSelected;
            if (isSelected) {
                selectImage.color = new Color(selectImage.color.r, selectImage.color.g, selectImage.color.b, 1);
                return;
            }
            selectImage.color = new Color(selectImage.color.r, selectImage.color.g, selectImage.color.b, 0.8f);
        }
        

    }
}
