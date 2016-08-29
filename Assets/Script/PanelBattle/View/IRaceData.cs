using UnityEngine;
using System.Collections;

namespace Model {
    public interface IRaceData {
        Sprite Icon { get; }
        UnityEngine.Object SkillPrefab { get; }
    }
}
