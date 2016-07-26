using UnityEngine;
using System.Collections;

namespace Model {
    public class PropDataList : MonoBehaviour {
        public PropData[] list;

        public PropData GetProp(string id) {
            if (string.IsNullOrEmpty(id)) {
                return null;
            }
            int num = int.Parse(id.Substring(1, 3));
            return list[num];
        }
    }
}
