using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDropItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    public Transform parent = null;
    public Transform substituteParent = null;

    private GameObject m_substitute = null;
    private Vector3 m_position = Vector3.zero;

    public void OnBeginDrag(PointerEventData eventData) {
        this.gameObject.GetComponent<CanvasGroup>().blocksRaycasts = false;
        m_substitute = new GameObject();
        substituteParent = this.transform.parent;
        m_substitute.transform.SetParent(substituteParent);
        LayoutElement le = m_substitute.AddComponent<LayoutElement>();
        le.preferredHeight = this.GetComponent<LayoutElement>().preferredHeight;
        le.preferredWidth = this.GetComponent<LayoutElement>().preferredWidth;
        le.flexibleHeight = 0;
        le.flexibleWidth = 0;
        m_substitute.transform.SetSiblingIndex(this.transform.GetSiblingIndex());
        this.transform.SetParent(parent.parent);
    }

    public void OnDrag(PointerEventData eventData) {
        m_position = Camera.main.ScreenToWorldPoint(eventData.position);
        m_position.z = 0f;
        this.transform.position = m_position;
        for (int i = 0; i < parent.childCount; ++i) {
            if (this.transform.position.x < parent.GetChild(i).position.x) {
                m_substitute.transform.SetSiblingIndex(i);
                break;
            }
        }
        m_substitute.transform.SetParent(substituteParent);
    }

    public void OnEndDrag(PointerEventData eventData) {
        this.gameObject.GetComponent<CanvasGroup>().blocksRaycasts = true;
        this.transform.SetParent(parent.transform);
        this.transform.SetSiblingIndex(m_substitute.transform.GetSiblingIndex());
        if (m_substitute != null) {
            DestroyObject(m_substitute);
        }
    }

}