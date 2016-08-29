using UnityEngine;
using System.Collections;

namespace View {
    public interface IRace {
        int HpNum { get; set; }
        int MpNum { get; set; }
        void AttackAnimation();
        void UnderAttackAnimation();
    }
}