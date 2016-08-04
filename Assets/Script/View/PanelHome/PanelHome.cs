using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Home {
    public class PanelHome : MonoBehaviour {
        public MissionItemList missionList;
        public RoleItemList roleList;
        public Button btnTravel;
        public Button btnShop;
        public Image mask;
        public Image testImage;

        void Start() {
            StartCoroutine("TimeLoading");
        }

        IEnumerator TimeLoading() {
            while (true) {
                if (testImage.fillAmount == 0) {
                    testImage.fillClockwise = true;
                } else if (testImage.fillAmount == 1) {
                    testImage.fillClockwise = false;
                }
                if (testImage.fillClockwise) {
                    testImage.fillAmount += 0.05f;
                } else {
                    testImage.fillAmount -= 0.05f;
                }
                yield return new WaitForSeconds(0.1f);
            }
        }

    }
}
