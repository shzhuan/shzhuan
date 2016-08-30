using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System;
using Newtonsoft.Json;
using System.IO;

namespace Model {
    public class GameData : MonoBehaviour {
        private static GameData m_instance;
        public static GameData Instance {
            get { return m_instance; }
        }
        
        public RoleDataList roleDataList;
        public SkillDataList skillDataList;
        public MissionDataList missionDataList;
        public PropDataList propDataList;

        private const string m_roleDataJsonFileNam = "RoleDataJson";
        private const string m_skillDataJsonFileNam = "SkillDataJson";
        private const string m_missionDataJsonFileNam = "MissionDataJson";
        private const string m_propDataJsonFileNam = "PropDataJson";

        void Awake() {
            m_instance = this;
            DeserializeDataJson();
        }

        public void DeserializeDataJson() {
            DeserializeRoleDataJson();
            DeserializeSkillDataJson();
            DeserializePropDataJson();
            DeserializeMissionDataJson();
        }

        public RoleData GetRoleData(string id) {
            if (string.IsNullOrEmpty(id)) {
                return null;
            }
            int num = int.Parse(id.Substring(1, 3));
            return roleDataList.roleDataList[num];
        }

        public SkillData GetSkillData(string id) {
            if (string.IsNullOrEmpty(id)) {
                return null;
            }
            int num = int.Parse(id.Substring(1, 3));
            return skillDataList.skillDataList[num];
        }

        public PropData GetPropData(string id){
            if (string.IsNullOrEmpty(id)) {
                return null;
            }
            int num = int.Parse(id.Substring(1, 3));
            return propDataList.propDataList[num];
        }

        private void DeserializeRoleDataJson() {
            string path = Application.dataPath + "/Resources/Json/" + m_roleDataJsonFileNam + ".json";
            string json = File.ReadAllText(path);
            roleDataList = JsonConvert.DeserializeObject<RoleDataList>(json);
        }

        private void DeserializeSkillDataJson() {
            string path = Application.dataPath + "/Resources/Json/" + m_skillDataJsonFileNam + ".json";
            string json = File.ReadAllText(path);
            skillDataList = JsonConvert.DeserializeObject<SkillDataList>(json);
        }

        private void DeserializePropDataJson() {
            string path = Application.dataPath + "/Resources/Json/" + m_propDataJsonFileNam + ".json";
            string json = File.ReadAllText(path);
            propDataList = JsonConvert.DeserializeObject<PropDataList>(json);
        }

        private void DeserializeMissionDataJson() {
            string path = Application.dataPath + "/Resources/Json/" + m_missionDataJsonFileNam + ".json";
            string json = File.ReadAllText(path);
            missionDataList = JsonConvert.DeserializeObject<MissionDataList>(json);
        }

        private string SerializePlayerDataJson(object obejct) {
            string serializedString = JsonConvert.SerializeObject(obejct);
            return serializedString;
        }

    }
}
