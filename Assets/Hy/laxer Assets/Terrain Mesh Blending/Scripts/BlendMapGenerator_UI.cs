#if UNITY_EDITOR
using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(TerrainBlendMapGenerator))]
public class BlendMapGenerator_UI : Editor {

	public override void OnInspectorGUI(){
		TerrainBlendMapGenerator bgen = (TerrainBlendMapGenerator)target;

		if (bgen.gameObject.GetComponent<Terrain> () == null) {
			EditorGUILayout.HelpBox ("Terrain Missing!\nThis script must be attached to a terrain!", MessageType.Error);
		} else if (bgen.blend_materials == null) {
			EditorGUILayout.HelpBox ("Materials Missing!\nYou have to assign the materials you want to blend with this terrain.\nMaterials must use one of the included terrain blending shaders!", MessageType.Warning);
		} else if (bgen.blend_materials != null && bgen.blend_materials.Length == 0) {
			EditorGUILayout.HelpBox ("Materials Missing!\nYou have to assign the materials you want to blend with this terrain.\nMaterials must use one of the included terrain blending shaders!", MessageType.Warning);
		} 
		else {
			EditorGUILayout.HelpBox ("Click \"create / update blendmap\" to refresh the blending maps", MessageType.Info);
		}
		if (bgen.blend_materials != null) {
			for (int ctm = 0; ctm < bgen.blend_materials.Length; ctm++) {
				if (bgen.blend_materials [ctm] == null) {
					EditorGUILayout.HelpBox ("Empty Material Slot!\nMaterial " + ctm.ToString () + " is not assigned!\nEmpty slots will be ignored.", MessageType.Info);
					break;
				}
			}
		}
		DrawDefaultInspector ();
		//bgen.terraintexturepos = EditorGUILayout.Vector4Field("texture offset.x, offset.y + size.x, size.y", bgen.terraintexturepos);
		if(GUILayout.Button("create / update blendmap")){
			bgen.create_blendmap();
		}

	}
}
#endif