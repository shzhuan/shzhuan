using UnityEngine;
using System;

namespace BehaviourMachine {
    public class UIBehaviorState : StateBehaviour {

        public string bgmName = "";
        public bool loop = false;
        public UIActiveState[] activeObject;
        public UIActiveState[] inactiveObject;

        void OnEnable() {
            PlaySound();
            StateOnEnable();
        }

        void OnDisable() {
            StateOnDisable();
        }

        void PlaySound() {
            if (bgmName != "") {
                SoundManager.Instance.PlayMusic(bgmName, loop);
            }
        }

        void StateOnEnable() {
            for (int i = 0; i < activeObject.Length; i++) {
                if (activeObject[i] != null &&
                    activeObject[i].executeType == UIActiveState.ExecuteTimeType.Awake && 
                    activeObject[i].time == 0) {
                    activeObject[i].target.SetActive(true);
                }
            }
            for (int i = 0; i < inactiveObject.Length; i++) {
                if (inactiveObject[i] != null && 
                    inactiveObject[i].executeType == UIActiveState.ExecuteTimeType.Awake && 
                    inactiveObject[i].time == 0) {
                    inactiveObject[i].target.SetActive(false);
                }
            }
        }

        void StateOnDisable() {
            for (int i = 0; i < activeObject.Length; i++) {
                if (activeObject[i] != null &&
                    activeObject[i].executeType == UIActiveState.ExecuteTimeType.End &&
                    activeObject[i].time == 0) {
                    activeObject[i].target.SetActive(true);
                }
            }
            for (int i = 0; i < inactiveObject.Length; i++) {
                if (inactiveObject[i] != null &&
                    inactiveObject[i].executeType == UIActiveState.ExecuteTimeType.End &&
                    inactiveObject[i].time == 0) {
                    inactiveObject[i].target.SetActive(false);
                }
            }
        }

    }
}
