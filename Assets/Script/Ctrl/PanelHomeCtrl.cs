using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Ctrl.Home {
    public class PanelHomeCtrl : MonoBehaviour {

        public View.Home.PanelHome panelHome = null;
        
        private bool m_isStart = false;
        private float m_timeSecond = 0f;

        private Model.GameData GameData {
            get { return Model.GameData.Instance; }
        }

        void Awake() {
            panelHome.btnTravel.onClick.AddListener( SendTravelCommand );
            panelHome.roleList.btnOK.onClick.AddListener( MissionStart );
        }

        void Start() {
            StartCoroutine("CountDown");
            InitMissionList(GameData.missionDataList);
            InitRoleList(GameData.roleDataList);
        }

        #region Events   
        private void SendTravelCommand() {
            UIController.Instance.Command(UICommand.SHAN_TRAVEL);
        }

        private void MissionStart() {
            for (int i = 0; i < panelHome.missionList.itemList.Count; ++i) {
                if (panelHome.missionList.itemList[i].IsSelscted) {
                    panelHome.missionList.itemList[i].btnMisson.interactable = false;
                    break;
                }
            }
            ChangeRoleState();
            panelHome.roleList.SetActive(false);
            m_timeSecond = 10f;
            m_isStart = true;
        }

        private void MissionItemEvent(View.Home.MissionItem item) {
            if (!item.IsSelscted) {
                panelHome.missionList.SetAllMissionItemState(false);
                panelHome.roleList.Init();
            }
            RefreshRoleList();
            panelHome.mask.gameObject.SetActive(!item.IsSelscted);
            item.SetBtnState(!item.IsSelscted);
            panelHome.roleList.SetActive(item.IsSelscted);
        }

        private void RoleItemEvent(View.Home.RoleItem item) {
            if (!item.IsSelscted) {
                panelHome.roleList.SetAllRoleItemState(false);
            }
            item.SetBtnState(!item.IsSelscted);
            panelHome.roleList.SetBtnState();
        }
        #endregion

        #region Misson
        private void InitMissionList(Model.MissionDataList missionList) {
            int missionItemNum = missionList.list.Length;
            panelHome.missionList.ListClear();
            panelHome.missionList.SetListWidth(missionItemNum);
            for (int i = 0; i < missionItemNum; ++i) {
                InstantiateMissionItem();
            }
            panelHome.missionList.SetDate(missionList);
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
        #endregion

        #region Role
        private void InitRoleList(Model.RoleDataList roleList) {
            int roleItemNum = roleList.list.Length;
            panelHome.roleList.ListClear();
            panelHome.roleList.SetListWidth(roleItemNum);
            for (int i = 0; i < roleItemNum; ++i) {
                InstantiateRoleItem();
            }
            panelHome.roleList.SetDate(roleList);
        }

        private void InstantiateRoleItem() {
            Object prefab = panelHome.roleList.rolePrefab;
            GameObject role = Instantiate(prefab) as GameObject;
            role.transform.parent = ((GameObject)prefab).transform.parent;
            role.transform.localPosition = Vector3.zero;
            role.transform.localScale = Vector3.one;
            View.Home.RoleItem item = role.GetComponent<View.Home.RoleItem>();
            item.btnRole.onClick.AddListener(() => RoleItemEvent(item));
            panelHome.roleList.itemList.Add(item);
            role.SetActive(true);
        }

        private void RefreshRoleList() {
            int activeNum = 0;
            for (int i = 0; i < panelHome.roleList.itemList.Count; ++i) {
                bool active = GameData.roleDataList.list[i].isIdle;
                panelHome.roleList.itemList[i].gameObject.SetActive(active);
                if (active) {
                    ++activeNum;
                }
            }
            panelHome.roleList.SetListWidth(activeNum);
        }

        private void ChangeRoleState() {
            for (int i = 0; i < panelHome.roleList.itemList.Count; ++i) {
                if (panelHome.roleList.itemList[i].IsSelscted) {
                    Model.RoleData role = GameData.roleDataList.GetRole(panelHome.roleList.itemList[i].RoleID);
                    role.isIdle = false;
                }
            }
        }
        #endregion

        IEnumerator CountDown() {
            while (m_isStart) {
                --m_timeSecond;
                Debug.Log(m_timeSecond);
                yield return new WaitForSeconds(1f);
            }
        }

    }
}
