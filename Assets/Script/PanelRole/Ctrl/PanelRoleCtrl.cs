using UnityEngine;
using System.Collections;

namespace Ctrl.Role {
    public class PanelRoleCtrl : MonoBehaviour {

        public View.Role.PanelRole panelRole = null;

        private Model.GameData GameData
        {
            get { return Model.GameData.Instance; }
        }

        private void PropItemEvent(View.Role.PropItem item) {
            Model.PropData data = GameData.GetPropData(item.PropID);
            panelRole.changeInfo.SetData(data);
            panelRole.changeInfo.gameObject.SetActive(true);
        }

    }
}
