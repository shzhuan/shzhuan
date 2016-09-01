using UnityEngine;
using System.Collections;

namespace View {
    public interface IRaceView {
        int HpNum { get; set; }
        int MpNum { get; set; }
        void AttackAnimation();
        void UnderAttackAnimation();
    }
}