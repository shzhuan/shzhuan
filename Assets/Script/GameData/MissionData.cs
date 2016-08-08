using UnityEngine;
using System.Collections;
using System;

namespace Model{
    [Serializable]
    public class MissionData : MonoBehaviour {
        public string id = "";
        public string type = "";
        public string title = "";
        public string detail = "";
        public int timeSecond = 0;
    }
}
