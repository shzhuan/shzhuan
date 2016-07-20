using UnityEngine;
using System.Collections;

namespace Model { 
    public class GameData : MonoBehaviour {
        private static GameData m_instance;
        public static GameData Instance {
            get { return m_instance; }
        }

        public Mission.MissionDataList missionDataList;

        void Awake() {
            m_instance = this;
        }

    }
}
