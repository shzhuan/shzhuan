using UnityEngine;
using System.Collections.Generic;

namespace View.Home {
    public class MissionItemList : MonoBehaviour {

        public Object missionPrefab;
        public RectTransform listScope;
        public List<MissionItem> itemList = new List<MissionItem>();

        private const float m_missionItemWidth = 286f;

        public void SetListWidth(int missionNum) {
            listScope.sizeDelta = new Vector2 (missionNum * m_missionItemWidth, listScope.sizeDelta.y);
            listScope.localPosition = Vector3.zero;
        }

        public void SetMissionItemState(bool isSelect) {
            for (int i = 0; i < itemList.Count; ++i) {
                itemList[i].IsSelscted = isSelect;
            }
        }

        public void SetDate(Model.MissionDataList dataList) {
            for (int i = 0; i < itemList.Count; ++i) {
                itemList[i].Init(dataList.list[i]);
            }
        }

    }
}
