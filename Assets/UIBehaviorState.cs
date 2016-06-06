using UnityEngine;
using System.Collections;

namespace BehaviourMachine {
    public class UIBehaviorState : StateBehaviour {

        public string bgmName = "";
        public bool loop = false;

        void OnEnable() {
            if (bgmName != "") {
                SoundManager.Instance.PlayMusic(bgmName, loop);
            }
        }

    }
}
