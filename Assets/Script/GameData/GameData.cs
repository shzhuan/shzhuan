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

        void Awake() {
            m_instance = this;
        }

        private Dictionary<string, Model.SkillData> LoadXml() {
            string name = "Skill";
            string path = Application.dataPath + "/Resources/XML/" + name + ".xml";
            XmlReader reader = new XmlTextReader(path);
            Dictionary<string, Model.SkillData> skillDic = new Dictionary<string, Model.SkillData>();
            while (reader.Read()) {
                if (reader.NodeType == XmlNodeType.Element) {
                    if (reader.LocalName == "SKILL") {
                        Model.SkillData data = new Model.SkillData();
                        for (int i = 0; i < reader.AttributeCount; i++) {
                            reader.MoveToAttribute(i);
                            if (reader.Name == "ID") {
                                data.id = reader.Value;
                            } else if (reader.Name == "Type") {
                                data.skillTypeId = reader.Value;
                            } else if (reader.Name == "Num") {
                                data.buffNum = int.Parse(reader.Value);
                            }
                        }
                        if (!skillDic.ContainsKey(data.id)) {
                            skillDic.Add(data.id, data);
                        }
                    }
                }
            }
            return skillDic;
        }

        private void loadXmlPlist() {
            string name = "Skill";
            string filePath = Application.dataPath + "/Resources/XML/" + name + ".xml";
            /*if (File.Exists(filePath)) {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);
                XmlNodeList node = xmlDoc.SelectSingleNode("plist").ChildNodes;
                foreach (XmlElement nodeList in node) {
                    foreach (XmlElement xe in nodeList) {
                        if (xe.Name == "array") {
                            int i = 0;
                            _tips = new string[xe.ChildNodes.Count];
                            foreach (XmlElement xe1 in xe.ChildNodes) {
                                //                          Debug.Log(xe1.InnerText);  
                                _tips[i] = xe1.InnerText;
                                i++;
                            }
                            break;
                        }
                    }
                }
            }
            */
        }

    }
}
