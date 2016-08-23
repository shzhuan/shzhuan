using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace Model {
    public class GameData : MonoBehaviour {
        private static GameData m_instance;
        public static GameData Instance {
            get { return m_instance; }
        }

        public MissionDataList missionDataList;
        public List<RoleData> roleDataList;
        public PropDataList propDataList;
        public List<SkillData> skillDataList = new List<SkillData>();

        private const string m_roleDataXMLFileNam = "RoleDataXML";
        private const string m_skillDataXMLFileNam = "SkillDataXML";

        void Awake() {
            m_instance = this;
            //LoadSkillDataXml();
            //LoadRoleDataXml();
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

    }
}
