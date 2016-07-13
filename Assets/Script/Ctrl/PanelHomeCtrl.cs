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
            for (int i = 0; i < panelHome.roleList.roleList.Length; ++i) {
                panelHome.roleList.roleList[i].btnRole.onClick.AddListener(
                    () => RoleItemEvent(panelHome.roleList.roleList[i]));
            }
        }

        private void SendTravelCommand() {
            UIController.Instance.Command(UICommand.SHAN_TRAVEL);
        }

        private void MissionItemEvent(View.Home.MissionItem item) {
            if (!item.IsSelscted) {
                panelHome.missionList.SetMissionItemState(false);
                panelHome.roleList.Init();
            }
            panelHome.mask.gameObject.SetActive(!item.IsSelscted);
            item.BtnState(!item.IsSelscted);
            panelHome.roleList.SetActive(!item.IsSelscted);
        }

        private void RoleItemEvent(View.Home.RoleItem item) {
            item.BtnState(!item.IsSelscted);
        }

        private void RefreshRoleList() {
            panelHome.roleList.Init();
        }

    }
}
