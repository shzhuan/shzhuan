using UnityEngine;
using System.Collections;

namespace View.Home {
    public class MissionItemList : MonoBehaviour {

        public MissionItem[] missionList;

        public void SetMissionItemState(bool isSelect) {
            for (int i = 0; i < missionList.Length; ++i) {
                missionList[i].IsSelscted = isSelect;
            }
        }

    }
}
