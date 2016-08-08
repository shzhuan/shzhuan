using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace View.Role {
    public class PropItemList : MonoBehaviour {
        public Object missionPrefab;
        public RectTransform listScope;
        public List<PropItem> itemList = new List<PropItem>();

        private const float m_propItemWidth = 0f;

        public void SetListWidth(int propNum) {
            listScope.sizeDelta = new Vector2(propNum * m_propItemWidth, listScope.sizeDelta.y);
            listScope.anchoredPosition = Vector2.zero;
        }

        public void SetDate(Model.PropDataList dataList) {
            for (int i = 0; i < itemList.Count; ++i) {
                itemList[i].Init(dataList.list[i]);
            }
        }

        public void ListClear() {
            for (int i = 0; i < itemList.Count; ++i) {
                DestroyImmediate(itemList[i]);
            }
            itemList.Clear();
        }

    }
}
