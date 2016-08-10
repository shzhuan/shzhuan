using UnityEngine;
using System.Collections;

namespace BehaviourMachine {
    public class UIExitState : InternalActionState {

        public UIExitState() {
            this.onEnable += StateOnEnable;
            this.update += StateOnUpdate;
        }

        void StateOnEnable() {
        }
        void StateOnUpdate() {
            SendEventUpwards(blackboard.GetStringVar("CurrentCommand").Value);
        }

    }

}
