using UnityEngine;
using System.Collections;

namespace Model {
    public class RoleDataList : MonoBehaviour {
        public RoleData[] list;

        public RoleData GetRole(string id) {
            if (string.IsNullOrEmpty(id)) {
                return null;
            }
            int num = int.Parse(id.Substring(1, 3));
            return list[num];
        }
    }
}