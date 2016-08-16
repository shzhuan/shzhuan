﻿using UnityEngine;
using System.Collections;
using System;

namespace Model {
    [Serializable]
    public class RoleData : MonoBehaviour {
        public string id = "";
        public string type = "";
        public string roleName = "";
        public string description = "";
        public float favorNum = 0f;
        public float loyaltyNum = 0f;
        public float forceNum = 0f;
        public float mentalityNum = 0f;
        public float charismaNum = 0f;
        public bool isIdle = true;
        public Sprite icon = null;

        public int hpNum = 0;
        public int ppNum = 0;
        public int agilityNum = 0;
        public string skillId = "";
    }
}
