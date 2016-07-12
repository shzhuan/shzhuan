using UnityEngine;
using System.Collections;

namespace Ctrl.Home {
    public class PanelHomeCtrl : MonoBehaviour {

        public View.Home.PanelHome panelHome = null;

        void Awake() {
            panelHome.btnTravel.onClick.AddListener( SendTravelCommand );
            for (int i = 0; i < panelHome.missionList.missionList.Length; ++i) {
                panelHome.missionList.missionList[i].btnMisson.onClick.AddListener(
                    () => MissionItemEvent(panelHome.missionList.missionList[i]));
            }
        }

        private void SendTravelCommand() {
            UIController.Instance.Command(UICommand.SHAN_TRAVEL);
        }

        private void MissionItemEvent(View.Home.MissionItem item) {
            item.BtnState(!item.IsSelscted);
            panelHome.roleList.SetActive(!item.IsSelscted);
        }

    }
}
