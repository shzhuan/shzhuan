using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Ctrl.Home {
    public class PanelHomeCtrl : MonoBehaviour {

        public View.Home.PanelHome panelHome = null;

        private bool m_isStart = false;
        private float m_timeSecond = 0f;
        //private List<View.Home.MissionItem> m_missionList = new List<View.Home.MissionItem>();

        void Awake() {
            panelHome.btnTravel.onClick.AddListener( SendTravelCommand );
            panelHome.roleList.roleList[0].btnRole.onClick.AddListener(() => RoleItemEvent(panelHome.roleList.roleList[0]));
            panelHome.roleList.roleList[1].btnRole.onClick.AddListener(() => RoleItemEvent(panelHome.roleList.roleList[1]));
            panelHome.roleList.btnOK.onClick.AddListener( MissionStart );
        }

        void Start() {
            StartCoroutine("CountDown");
            InitMissionList(Model.GameData.Instance.missionDataList.list.Length);
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

        private void InitMissionList(int missionItemNum) {
            panelHome.missionList.itemList.Clear();
            panelHome.missionList.SetListWidth(missionItemNum);
            for (int i = 0; i < missionItemNum; ++i) {
                InstantiateMissionItem();
            }
        }

        private void InstantiateMissionItem() {
            Object prefab = panelHome.missionList.missionPrefab;
            GameObject mission = Instantiate(prefab) as GameObject;
            mission.transform.parent = ((GameObject)prefab).transform.parent;
            mission.transform.localPosition = mission.transform.localPosition;
            mission.transform.localScale = Vector3.one;
            View.Home.MissionItem item = mission.GetComponent<View.Home.MissionItem>();
            item.btnMisson.onClick.AddListener(() => MissionItemEvent(item));
            panelHome.missionList.itemList.Add(item);
            mission.SetActive(true);
        }

        private void RefreshMissionList() { }

        private void RefreshRoleList() {
            panelHome.roleList.Init();
        }

        private void MissionStart() {
            for (int i = 0; i < panelHome.missionList.itemList.Count; ++i) {
                if (panelHome.missionList.itemList[i].IsSelscted) {
                    panelHome.missionList.itemList[i].btnMisson.interactable = false;
                    break;
                }
            }
            panelHome.roleList.SetActive(false);
            m_timeSecond = 10f;
            m_isStart = true;
        }

        IEnumerator CountDown() {
            while (m_isStart) {
                --m_timeSecond;
                Debug.Log(m_timeSecond);
                yield return new WaitForSeconds(1f);
            }
        }

    }
}
