using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

namespace View.Home {
    public class RoleItemList : MonoBehaviour {
        public Object rolePrefab;
        public RectTransform listScope;
        public List<RoleItem> itemList = new List<RoleItem>();
        public Button btnOK;

        private bool m_isEnable = false;
        private const float m_roleItemWidth = 120f;

        public bool Enable
        {
            get { return m_isEnable; }
        }

        void Awake() {
            gameObject.SetActive(false);
        }

        public void Init() {
            SetRoleItemState(false);
            btnOK.gameObject.SetActive(false);
            listScope.anchoredPosition = Vector2.zero;
        }

        public void SetListWidth(int roleNum) {
            listScope.sizeDelta = new Vector2(roleNum * m_roleItemWidth, listScope.sizeDelta.y);
            listScope.anchoredPosition = Vector2.zero;
        }

        public void SetActive(bool value) {
            m_isEnable = value;
            gameObject.SetActive(value);
        }

        public void SetRoleItemState(bool isSelect) {
            for (int i = 0; i < itemList.Count; ++i) {
                itemList[i].IsSelscted = isSelect;
            }
        }

        public void SetAllRoleItemState(bool isSelect) {
            for (int i = 0; i < itemList.Count; ++i) {
                itemList[i].IsSelscted = isSelect;
            }
        }

        public void SetBtnState() {
            for (int i = 0; i < itemList.Count; ++i) {
                if (itemList[i].IsSelscted) {
                    btnOK.gameObject.SetActive(true);
                    break;
                }
                btnOK.gameObject.SetActive(false);
            }
        }

        public void SetDate(Model.RoleDataList dataList) {
            for (int i = 0; i < itemList.Count; ++i) {
                itemList[i].Init(dataList.list[i], false);
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
