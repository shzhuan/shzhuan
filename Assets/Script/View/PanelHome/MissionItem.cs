using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MissionItem : MonoBehaviour {

    public Image btnImage;
    public Text missionDetail;
    public Button button;

    private bool m_isSelected = false;

    public bool IsSelscted
    {
        get { return m_isSelected; }
    }

    public void BtnState(bool isSelected) {
        m_isSelected = isSelected;
        if (isSelected) {
            btnImage.color = new Color(btnImage.color.r, btnImage.color.g, btnImage.color.b, 1);
            return;
        }
        btnImage.color = new Color(btnImage.color.r, btnImage.color.g, btnImage.color.b, 0.8f);
    }

    public void SetMissionDetail(string detail) {
        missionDetail.text = detail;
    }

}
