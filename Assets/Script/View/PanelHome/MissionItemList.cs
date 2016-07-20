using UnityEngine;
using System.Collections.Generic;

namespace View.Home {
    public class MissionItemList : MonoBehaviour {

        public Object missionPrefab;
        //public MissionItem[] missionList;
        public List<View.Home.MissionItem> itemList = new List<MissionItem>();

        public void SetMissionItemState(bool isSelect) {
            for (int i = 0; i < itemList.Count; ++i) {
                itemList[i].IsSelscted = isSelect;
            }
        }

        public void SetDate(Model.Mission.MissionDataList dataList) {
            for (int i = 0; i < itemList.Count; ++i) {
                itemList[i].Init(dataList.list[i]);
            }
        }

    }
}
