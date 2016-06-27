using UnityEngine;
using System.Collections;

namespace Ctrl.Home {
    public class PanelHomeCtrl : MonoBehaviour {

        public View.Home.PanelHome panelHome = null;

        void Awake() {
            panelHome.btn_travel.onClick.AddListener( SendTravelCommand );
        }

        public void SendTravelCommand() {
            UIController.Instance.Command(UICommand.SHAN_TRAVEL);
        }

    }
}
