using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Battle {
    public class Enemy : MonoBehaviour {
        public Slider hpBar;

        void Start() {
            hpBar.value = 1;
        }

        void Update() {

        }
    }
}
