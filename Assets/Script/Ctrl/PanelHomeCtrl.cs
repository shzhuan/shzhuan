using UnityEngine;
using System.Collections;

namespace Ctrl.Home {
    public class PanelHomeCtrl : MonoBehaviour {

        public View.Home.PanelHome panelHome = null;

        private bool m_isStart = false;
        private float m_timeSecond = 0f;

        void Awake() {
            panelHome.btnTravel.onClick.AddListener( SendTravelCommand );
            panelHome.missionList.missionList[0].btnMisson.onClick.AddListener(() => MissionItemEvent(panelHome.missionList.missionList[0]));
            panelHome.missionList.missionList[1].btnMisson.onClick.AddListener(() => MissionItemEvent(panelHome.missionList.missionList[1]));
            panelHome.roleList.roleList[0].btnRole.onClick.AddListener(() => RoleItemEvent(panelHome.roleList.roleList[0]));
            panelHome.roleList.roleList[1].btnRole.onClick.AddListener(() => RoleItemEvent(panelHome.roleList.roleList[1]));
            panelHome.roleList.btnOK.onClick.AddListener( MissionStart );
        }

        void Start() {
            StartCoroutine("CountDown");
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
            item.SetBtnState(!item.IsSelscted);
            panelHome.roleList.SetActive(item.IsSelscted);
        }

        private void RoleItemEvent(View.Home.RoleItem item) {
            item.BtnState(!item.IsSelscted);
            panelHome.roleList.SetBtnState();
        }

        private void InitMissionList() {
            Object prefab = panelHome.missionList.missionPrefab;
            GameObject mission = Instantiate(prefab) as GameObject;
            mission.transform.localPosition = mission.transform.localPosition;
            mission.transform.localScale = Vector3.one;
            View.Home.MissionItem item = mission.GetComponent<View.Home.MissionItem>();
            item.btnMisson.onClick.AddListener(() => MissionItemEvent(item));
        }

        private void RefreshMissionList() { }

        private void RefreshRoleList() {
            panelHome.roleList.Init();
        }

        private void MissionStart() {
            for (int i = 0; i < panelHome.missionList.missionList.Length; ++i) {
                if (panelHome.missionList.missionList[i].IsSelscted) {
                    panelHome.missionList.missionList[i].btnMisson.interactable = false;
                    break;
                }
            }
            panelHome.roleList.SetActive(false);
            m_timeSecond = 10f;
            m_isStart = true;
        }

        IEnumerator CountDown() {
            Debug.Log("121212");
            while (m_isStart) {
                --m_timeSecond;
                Debug.Log(m_timeSecond);
                yield return new WaitForSeconds(1f);
            }
        }

    }
}
