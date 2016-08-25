using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System;

namespace Model {
    public class GameData : MonoBehaviour {
        private static GameData m_instance;
        public static GameData Instance {
            get { return m_instance; }
        }

        public List<RoleData> roleDataList = new List<RoleData>();
        public List<SkillData> skillDataList = new List<SkillData>();
        public List<MissionData> missionDataList = new List<MissionData>();
        public List<PropData> propDataList = new List<PropData>();

        private const string m_roleDataXMLFileNam = "RoleDataXML";
        private const string m_skillDataXMLFileNam = "SkillDataXML";
        private const string m_missionDataXMLFileNam = "MissionDataXML";
        private const string m_propDataXMLFileNam = "propDataXML";

        void Awake() {
            m_instance = this;
            //LoadSkillDataXml();
            //LoadRoleDataXml();
            Test();
        }

        private void LoadSkillDataXml() {
            string path = Application.dataPath + "/Resources/XML/" + m_skillDataXMLFileNam + ".xml";
            XmlReader skillDataReader = new XmlTextReader(path);
            while (skillDataReader.Read()) {
                if (skillDataReader.LocalName == "SkillData") {
                    SkillData data = new SkillData();
                    for (int i = 0; i < skillDataReader.AttributeCount; ++i) {
                        skillDataReader.MoveToAttribute(i);
                        switch (skillDataReader.LocalName) {
                            case "ID":
                                data.id = skillDataReader.Value;
                                break;
                            case "Name":
                                data.skillName = skillDataReader.Value;
                                break;
                            case "Detail":
                                data.detail = skillDataReader.Value;
                                break;
                            case "HP":
                                data.hpNum = float.Parse(skillDataReader.Value);
                                break;
                            case "MP":
                                data.mpNum = float.Parse(skillDataReader.Value);
                                break;
                            case "ATK":
                                data.atkNum = float.Parse(skillDataReader.Value);
                                break;
                            case "DEF":
                                data.defNum = float.Parse(skillDataReader.Value);
                                break;
                            case "DEX":
                                data.dexNum = float.Parse(skillDataReader.Value);
                                break;
                            case "LUK":
                                data.lukNum = float.Parse(skillDataReader.Value);
                                break;
                        }
                    }
                    skillDataList.Add(data);
                }
            }
        }

        private void LoadRoleDataXml() {
            string path = Application.dataPath + "/Resources/XML/" + m_roleDataXMLFileNam + ".xml";
            XmlReader roleDataReader = new XmlTextReader(path);
            while (roleDataReader.Read()) {
                if (roleDataReader.LocalName == "RoleData") {
                    RoleData data = new RoleData();
                    for (int i = 0; i < roleDataReader.AttributeCount; ++i) {
                        roleDataReader.MoveToAttribute(i);
                        switch (roleDataReader.LocalName) {
                            case "ID":
                                data.id = roleDataReader.Value;
                                break;
                            case "Name":
                                data.roleName = roleDataReader.Value;
                                break;
                            case "Detail":
                                data.detail = roleDataReader.Value;
                                break;
                            case "LV":
                                data.lv = int.Parse(roleDataReader.Value);
                                break;
                            case "HP":
                                data.hpNum = float.Parse(roleDataReader.Value);
                                break;
                            case "MP":
                                data.mpNum = float.Parse(roleDataReader.Value);
                                break;
                            case "ATK":
                                data.atkNum = float.Parse(roleDataReader.Value);
                                break;
                            case "DEF":
                                data.defNum = float.Parse(roleDataReader.Value);
                                break;
                            case "DEX":
                                data.dexNum = float.Parse(roleDataReader.Value);
                                break;
                            case "LUK":
                                data.lukNum = float.Parse(roleDataReader.Value);
                                break;
                            case "SkillID":
                                data.skillId = roleDataReader.Value;
                                break;
                        }
                    }
                    roleDataList.Add(data);
                }
            }
        }

        public RoleData GetRoleData(string id) {
            if (string.IsNullOrEmpty(id)) {
                return null;
            }
            int num = int.Parse(id.Substring(1, 3));
            return roleDataList[num];
        }

        public SkillData GetSkillData(string id) {
            if (string.IsNullOrEmpty(id)) {
                return null;
            }
            int num = int.Parse(id.Substring(1, 3));
            return skillDataList[num];
        }

        public PropData GetPropData(string id){
            if (string.IsNullOrEmpty(id)) {
                return null;
            }
            int num = int.Parse(id.Substring(1, 3));
            return propDataList[num];
        }

        public void Test() {
            for (int i = 0; i < 100; ++i ) {
                Debug.Log((float)Math.Pow(2, i/5)/110*i+5);
            }
        }

    }
}
