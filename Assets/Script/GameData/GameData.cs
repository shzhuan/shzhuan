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
        public RoleDataList roleDataList;
        public PropDataList propDataList;
        public List<SkillData> skillDataList = new List<SkillData>();

        private const string m_roleDataXMLFileNam = "RoleDataXML";
        private const string m_skillDataXMLFileNam = "SkillDataXML";

        void Awake() {
            m_instance = this;
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

    }
}
