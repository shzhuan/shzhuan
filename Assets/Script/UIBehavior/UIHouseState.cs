using UnityEngine;
using System.Collections;

namespace BehaviourMachine {
    public class UIHouseState : StateBehaviour {

        public string bgmName = "";
        public bool loop = false;

        void OnEnable() {
            if (bgmName != "") {
                SoundManager.Instance.PlayMusic(bgmName, loop);
            }
        }

    }
}
