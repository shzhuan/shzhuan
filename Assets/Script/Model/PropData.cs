using UnityEngine;
using System.Collections;
using System;

namespace Model {
    [Serializable]
    public class PropData : MonoBehaviour {
        public string id = "";
        public string type = "";
        public string propName = "";
        public string description = "";
        public float favorNum = 0f;
        public float loyaltyNum = 0f;
        public float forceNum = 0f;
        public float mentalityNum = 0f;
        public float charismaNum = 0f;
        public Sprite icon = null;
    }
}
