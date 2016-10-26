#if UNITY_EDITOR

using UnityEngine;
using System.Collections;
using UnityEditor;

[ExecuteInEditMode]
public class TerrainBlendMapGenerator : MonoBehaviour {
	TerrainData terraindata;
	//public TerrainBlendData terrainblenddata;
	public Texture2D blendmap;
	public Texture2D blendnormalmap;
	public Material[] blend_materials;
	public bool debug = false;
	public int debug_downscale = 1;
	//public Vector4 terraintexturepos;

	void Update(){ // draw every frame
		if(debug)
		drawDebug();
	}

	void drawDebug(){
		for (int ctx = 0; ctx < blendmap.width; ctx++) {
			for (int cty = 0; cty < blendmap.height; cty++) {
				if(ctx%debug_downscale == 0 && cty%debug_downscale == 0){
					Color np = blendnormalmap.GetPixel(ctx,cty);
					Color hp = blendmap.GetPixel(ctx,cty);
					float h = hp.r*1.0f+hp.g* 1f/255.0f+hp.b* 1f/65025.0f+hp.a* 1f/16581375.0f;
					Vector3 n = new Vector3(np.r*2f-1f,np.b*2f-1f,np.g*2f-1f);
					Debug.DrawRay(transform.position + new Vector3(ctx/(float)(blendmap.width-1)*terraindata.size.x,h*terraindata.size.y,cty/(float)(blendmap.height-1)*terraindata.size.z),n,new Color(hp.r,hp.g,hp.b));
				}
			}
		}
	}

	// Update is called once per frame
	public void create_blendmap () {

		if(!blendmap)
			blendmap = new Texture2D(512,512);
		if(!blendnormalmap)
			blendnormalmap = new Texture2D(512,512);
		if (GetComponent<Terrain>() == null) {
			EditorUtility.DisplayDialog("Terrain missing", "Unable to get Terrain. Make sure this script is attached to a terrain. Make sure that terrain is set up properly.", "OK");
			return;
		}
		terraindata = GetComponent<Terrain>().terrainData;
		if (terraindata == null) {
			EditorUtility.DisplayDialog("TerrainData missing", "Unable to get TerrainData component of Terrain. Make sure this script is attached to a terrain. Make sure that terrain is set up properly.", "mKAY");
			return;
		}

		float[,] heightmap = terraindata.GetHeights(0,0,terraindata.heightmapWidth,terraindata.heightmapHeight);
		blendmap.Resize(terraindata.heightmapWidth,terraindata.heightmapHeight);
		blendnormalmap.Resize(terraindata.heightmapWidth,terraindata.heightmapHeight);
		for(int cty = 0; cty < blendmap.height;cty++){
			for(int ctx = 0; ctx < blendmap.width;ctx++){
				Color hgt = encode_float_rgba(heightmap[ctx,cty]);
				if(UnityEditor.PlayerSettings.colorSpace == ColorSpace.Linear){
					hgt.r = Mathf.LinearToGammaSpace(hgt.r);
					hgt.g = Mathf.LinearToGammaSpace(hgt.g);
					hgt.b = Mathf.LinearToGammaSpace(hgt.b);
					hgt.a = Mathf.LinearToGammaSpace(hgt.a);

				}
				blendmap.SetPixel(cty,ctx,hgt);
				Vector3 tn = terraindata.GetInterpolatedNormal((float)ctx/(float)blendmap.width,(float)cty/(float)blendmap.height);
				//Vector3 tng =  Vector3.Cross(tn,new Vector3(0,1,0));
				//Vector3 btng =  Vector3.Cross(tn, tng);
				//Matrix4x4 nmatrix = new Matrix4x4();
				//nmatrix.SetColumn(3, new Vector4(tng.x,tng.y,tng.z,0));
				//nmatrix.SetColumn(2, new Vector4(btng.x,btng.y,btng.z,0));
				//nmatrix.SetColumn(1, new Vector4(tn.x,tn.y,tn.z,0));
				//nmatrix.SetColumn(0, new Vector4(0,0,0,0));
				//tn = nmatrix*Vector3.up;
				Color n = new Color(tn.x/ 2 + 0.5f,tn.z / 2 + 0.5f,tn.y/ 2 + 0.5f,1);
				//n.r = n.g;
				//n.b = n.a;
				if(UnityEditor.PlayerSettings.colorSpace == ColorSpace.Linear){
					n.r = Mathf.LinearToGammaSpace(n.r);
					n.g = Mathf.LinearToGammaSpace(n.g);
					n.b = Mathf.LinearToGammaSpace(n.b);
					n.a = Mathf.LinearToGammaSpace(n.a);
					
				}
				blendnormalmap.SetPixel(ctx,cty,n);
			}
		}
		//blendmap.anisoLevel = 16;
		blendmap.Apply();
		blendnormalmap.Apply();
		/*
		 * Shader.SetGlobalTexture("_blendmap", blendmap);
		Shader.SetGlobalTexture("_blendnormalmap", blendnormalmap);
		Shader.SetGlobalFloat("_terrainheight", terraindata.size.y);
		Shader.SetGlobalFloat("_terrainposy", transform.position.y);
		Shader.SetGlobalVector("_terrainmappos", new Vector4(transform.position.x,transform.position.z ,1.0f/(terraindata.size.x),1.0f/(terraindata.size.z)));
		 */
		//Shader.SetGlobalVector("_terraintexturepos", terraintexturepos - new Vector4(0f,0f,0,0));

		/*AssetDatabase.GenerateUniqueAssetPath("Assets/Terrain Blending/textures");

		AssetDatabase.CreateAsset(blendmap, "Assets/Terrain Blending/textures/" + terraindata."blendmap" + ".asset" );
		AssetDatabase.CreateAsset(blendnormalmap, "Assets/Terrain Blending/textures/" + "blendnormaltest" + ".asset" );
		AssetDatabase.SaveAssets();*/

		/*if(!terrainblenddata){
			terrainblenddata = ScriptableObject.CreateInstance<TerrainBlendData>();

			AssetDatabase.CreateAsset(terrainblenddata, AssetDatabase.GenerateUniqueAssetPath("Assets/TerrainBlendData.asset"));
			AssetDatabase.AddObjectToAsset(blendmap,terrainblenddata);
			AssetDatabase.AddObjectToAsset(blendnormalmap,terrainblenddata);
			AssetDatabase.SaveAssets();
			terrainblenddata.blendmap = blendmap;
			terrainblenddata.blendnormalmap = blendnormalmap;
			
		}
		else{
			terrainblenddata.blendmap = blendmap;
			terrainblenddata.blendnormalmap = blendnormalmap;
			EditorUtility.SetDirty(terrainblenddata);
		}
		*/
		if (AssetDatabase.GetAssetPath (blendmap)!= "") {
			EditorUtility.SetDirty(blendmap);//AssetDatabase.CreateAsset (blendmap, AssetDatabase.GetAssetPath (blendmap));
		} else {
			AssetDatabase.CreateAsset(blendmap, AssetDatabase.GenerateUniqueAssetPath("Assets/TerrainBlendMap.asset"));
		}
		if (AssetDatabase.GetAssetPath(blendnormalmap)!= "") {
			EditorUtility.SetDirty(blendnormalmap);//AssetDatabase.CreateAsset(blendnormalmap, AssetDatabase.GetAssetPath(blendnormalmap));
		} else {
			AssetDatabase.CreateAsset(blendnormalmap, AssetDatabase.GenerateUniqueAssetPath("Assets/TerrainBlendNormalMap.asset"));
		}
		for(int ctm = 0;ctm < blend_materials.Length;ctm++){
			if(blend_materials[ctm] != null){
				blend_materials[ctm].SetTexture("_Blendmap", blendmap);
				blend_materials[ctm].SetTexture("_Blendnormalmap", blendnormalmap);
				//blend_materials[ctm].SetFloat("_terrainheight", terraindata.size.y);
				//blend_materials[ctm].SetFloat("_terrainposy", transform.position.y);
				Vector2 texel = new Vector2(terraindata.size.x/(blendmap.width-1),terraindata.size.z/(blendmap.height-1));
				blend_materials[ctm].SetVector("_terrainmappos", new Vector4(transform.position.x,transform.position.z,texel.x,texel.y));
				blend_materials[ctm].SetVector("_terrainmapscale", new Vector4(terraindata.size.x,terraindata.size.y,terraindata.size.z,transform.position.y));
			}
		}
	}

	Color encode_float_rgba(float input){
		Vector4 kEncodeMul = new Vector4(1.0f, 255.0f, 65025.0f, 160581375.0f);
		Vector4 col = kEncodeMul * input;
		col = new Vector4(frac(col.x),frac(col.y),frac(col.z),frac(col.w));
		float kEncodeBit = 1.0f / 255.0f;
		col -= new Vector4(col.y, col.z, col.w, col.w) * kEncodeBit;
		return new Color(col.x,col.y,col.z,col.w);
	}
	float frac(float x){
		return(x - Mathf.Floor(x));
	}
}
#endif