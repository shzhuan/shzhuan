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

    }
}
