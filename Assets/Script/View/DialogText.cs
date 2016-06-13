using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View {
    public class DialogText : MonoBehaviour {

        public Text textBox = null;
        public string dialogTxt = null;
        public float waitTime = 0f;

        void Awake() {
            textBox.text = "";
            StartCoroutine("PlayText");
        }

        IEnumerator PlayText() {
            foreach (char c in dialogTxt) {
                textBox.text += c;
                yield return new WaitForSeconds(waitTime);
            }
        }

    }
}
