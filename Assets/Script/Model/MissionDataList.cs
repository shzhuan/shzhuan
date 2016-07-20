using UnityEngine;
using System.Collections;

namespace Model.Mission {
    public class MissionDataList : MonoBehaviour {
        public MissionData[] list;

        public MissionData getMission(string id) {
            if (string.IsNullOrEmpty(id)) {
                return null;
            }
            int num = int.Parse(id.Substring(1, 3));
            return list[num];
        }
    }
}
