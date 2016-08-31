using UnityEngine;
using System.Collections;
using System.Collections.Generic;
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
        public PlayerData playerData;
        
        private const string m_roleDataJsonFileName = "RoleDataJson";
        private const string m_skillDataJsonFileName = "SkillDataJson";
        private const string m_missionDataJsonFileName = "MissionDataJson";
        private const string m_propDataJsonFileName = "PropDataJson";

        void Awake() {
            m_instance = this;
            DeserializeDataJson();
            CreateData();
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

        private void DeserializeDataJson() {
            DeserializeRoleDataJson();
            DeserializeSkillDataJson();
            DeserializePropDataJson();
            DeserializeMissionDataJson();
        }

        private void DeserializePlayerDataJson() {
            string path = Application.persistentDataPath + "/Save/GameData.json";
            string json = File.ReadAllText(path);
            playerData = JsonConvert.DeserializeObject<PlayerData>(json);
        }

        private void DeserializeRoleDataJson() {
            string path = Application.dataPath + "/Resources/Json/" + m_roleDataJsonFileName + ".json";
            string json = File.ReadAllText(path);
            roleDataList = JsonConvert.DeserializeObject<RoleDataList>(json);
        }

        private void DeserializeSkillDataJson() {
            string path = Application.dataPath + "/Resources/Json/" + m_skillDataJsonFileName + ".json";
            string json = File.ReadAllText(path);
            skillDataList = JsonConvert.DeserializeObject<SkillDataList>(json);
        }

        private void DeserializePropDataJson() {
            string path = Application.dataPath + "/Resources/Json/" + m_propDataJsonFileName + ".json";
            string json = File.ReadAllText(path);
            propDataList = JsonConvert.DeserializeObject<PropDataList>(json);
        }

        private void DeserializeMissionDataJson() {
            string path = Application.dataPath + "/Resources/Json/" + m_missionDataJsonFileName + ".json";
            string json = File.ReadAllText(path);
            missionDataList = JsonConvert.DeserializeObject<MissionDataList>(json);
        }

        public void SaveData() {
            string path = Application.persistentDataPath + "/Save/GameData.json";
            string data = SerializePlayerDataJson(playerData);
            File.WriteAllText(path, data);
        }

        private void CreateData() {
            string directoryPath = Application.persistentDataPath + "/Save";
            string jsonPath = Application.persistentDataPath + "/Save/GameData.json";
            if (!Directory.Exists(directoryPath)) {
                string data = "";
                Directory.CreateDirectory(directoryPath);
                File.WriteAllText(jsonPath, data);
            }
        }

        private string SerializePlayerDataJson(object obejct) {
            string serializedString = JsonConvert.SerializeObject(obejct);
            return serializedString;
        }

    }
}
