 using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Role {
    public class PropItem : MonoBehaviour {
        public Image icon;
        public Text propName;
        public Text num;

        private string m_Id = "";

        public string PropID
        {
            get { return m_Id; }
        }

        public void Init(Model.PropData data) {
            m_Id = data.id;
            propName.text = data.propName;
            icon.sprite = data.Icon;
            //num.text = data.num.ToString();
        }

    }
}
