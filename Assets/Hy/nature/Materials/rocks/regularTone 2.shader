// Shader created with Shader Forge v1.27 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.27;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:0,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:False,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:33358,y:32946,varname:node_3138,prsc:2|emission-9823-OUT,clip-7911-OUT;n:type:ShaderForge.SFN_Tex2d,id:7779,x:32053,y:33467,ptovrint:False,ptlb:TexLower,ptin:_TexLower,varname:node_7779,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:0169995ee29ad214fb2372c3bb00eed2,ntxv:2,isnm:False;n:type:ShaderForge.SFN_LightVector,id:8290,x:31573,y:33173,varname:node_8290,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:7954,x:31573,y:33303,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:9054,x:31817,y:33212,varname:node_9054,prsc:2,dt:1|A-8290-OUT,B-7954-OUT;n:type:ShaderForge.SFN_RemapRange,id:3432,x:32098,y:33070,varname:node_3432,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-9054-OUT;n:type:ShaderForge.SFN_Append,id:2727,x:32314,y:33070,varname:node_2727,prsc:2|A-5311-OUT,B-6023-OUT;n:type:ShaderForge.SFN_Tex2d,id:8845,x:32476,y:33070,ptovrint:False,ptlb:ramp,ptin:_ramp,varname:node_8845,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ab04cf8dfe921ea4d9bc0b21a443482b,ntxv:0,isnm:False|UVIN-2727-OUT;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:5311,x:32071,y:32868,varname:node_5311,prsc:2|IN-9054-OUT,IMIN-5741-OUT,IMAX-2977-OUT,OMIN-2087-OUT,OMAX-7384-OUT;n:type:ShaderForge.SFN_Slider,id:5741,x:31626,y:32814,ptovrint:False,ptlb:iMin,ptin:_iMin,varname:node_5741,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:-1,max:1;n:type:ShaderForge.SFN_Slider,id:2977,x:31626,y:32901,ptovrint:False,ptlb:iMax,ptin:_iMax,varname:node_2977,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:1,max:1;n:type:ShaderForge.SFN_Slider,id:2087,x:31626,y:32988,ptovrint:False,ptlb:oMin,ptin:_oMin,varname:node_2087,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:7384,x:31626,y:33076,ptovrint:False,ptlb:oMax,ptin:_oMax,varname:node_7384,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Vector1,id:6023,x:32098,y:33266,varname:node_6023,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Color,id:4087,x:32351,y:32813,ptovrint:False,ptlb:shadowColor,ptin:_shadowColor,varname:node_4087,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Blend,id:9427,x:32678,y:32921,varname:node_9427,prsc:2,blmd:7,clmp:True|SRC-4087-RGB,DST-8845-RGB;n:type:ShaderForge.SFN_LightAttenuation,id:6336,x:32693,y:33187,varname:node_6336,prsc:2;n:type:ShaderForge.SFN_LightColor,id:7856,x:32693,y:33338,varname:node_7856,prsc:2;n:type:ShaderForge.SFN_Slider,id:3480,x:32007,y:33692,ptovrint:False,ptlb:Clip,ptin:_Clip,varname:node_3480,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:7911,x:32430,y:33553,varname:node_7911,prsc:2|A-7779-A,B-3480-OUT;n:type:ShaderForge.SFN_Multiply,id:9823,x:32973,y:33071,varname:node_9823,prsc:2|A-9427-OUT,B-7856-RGB,C-7779-RGB;proporder:7779-8845-5741-2977-2087-7384-4087-3480;pass:END;sub:END;*/

Shader "Shader Forge/stoneTest" {
    Properties {
        _TexLower ("TexLower", 2D) = "black" {}
        _ramp ("ramp", 2D) = "white" {}
        _iMin ("iMin", Range(-1, 1)) = -1
        _iMax ("iMax", Range(-1, 1)) = 1
        _oMin ("oMin", Range(-1, 1)) = 0
        _oMax ("oMax", Range(0, 1)) = 1
        _shadowColor ("shadowColor", Color) = (0,0,0,1)
        _Clip ("Clip", Range(0, 1)) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
_TerrainTex ("Terrain Texture", 2D) = "white" {}
//_TerrainBump ("Terrain Bump Map", 2D) = "bump" {}
//_TerrainGlossiness ("Terrain Smoothness", Range(0,1)) = 0.0
//_UseAlphaSmoothness ("Use alpha smoothness", Range(0,1)) = 0.0
//[Gamma] _TerrainMetallic ("Terrain Metallic", Range(0,1)) = 0.0
_ColorCorrection ("Color correction", Color) = (0.5,0.5,0.5,1)
_Blend ("Blend", Range(0,10)) = 0.5
_BlendOffset ("Blend Offset", Range(-5,5)) = 0.1
[HideInInspector]_Blendmap ("Blendmap", 2D) = "black" {}
[HideInInspector]_Blendnormalmap ("Blendmap normals", 2D) = "bump" {}
[HideInInspector]_terrainmappos ("blendmap pos+scale", Vector) = (0,0,1,1)
[HideInInspector]_terrainmapscale ("terrain size, terrain pos y", Vector) = (500,500,500,0)
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _TexLower; uniform float4 _TexLower_ST;
            uniform sampler2D _ramp; uniform float4 _ramp_ST;
            uniform float _iMin;
            uniform float _iMax;
            uniform float _oMin;
            uniform float _oMax;
            uniform float4 _shadowColor;
            uniform float _Clip;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float4 _TexLower_var = tex2D(_TexLower,TRANSFORM_TEX(i.uv0, _TexLower));
                clip((_TexLower_var.a*_Clip) - 0.5);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
////// Emissive:
                float node_9054 = max(0,dot(lightDirection,i.normalDir));
                float2 node_2727 = float2((_oMin + ( (node_9054 - _iMin) * (_oMax - _oMin) ) / (_iMax - _iMin)),0.5);
                float4 _ramp_var = tex2D(_ramp,TRANSFORM_TEX(node_2727, _ramp));
                float3 emissive = (saturate((_ramp_var.rgb/(1.0-_shadowColor.rgb)))*_LightColor0.rgb*_TexLower_var.rgb);
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _TexLower; uniform float4 _TexLower_ST;
            uniform float _Clip;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 _TexLower_var = tex2D(_TexLower,TRANSFORM_TEX(i.uv0, _TexLower));
                clip((_TexLower_var.a*_Clip) - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
CGPROGRAM
#pragma surface surf Standard vertex:vert fullforwardshadows decal:blend exclude_path:deferred
#pragma multi_compile_fog

#include "Assets/laxer Assets/Terrain Mesh Blending/CGincs/TerrainMeshBlend.cginc"

sampler2D _Blendmap;
sampler2D _Blendnormalmap;
sampler2D _TerrainTex;
sampler2D _TerrainBump;


struct Input {
	float2 uv_Blendmap;
	float2 uv_TerrainTex;
	float2 uv_TerrainBump;
	float3 worldPos;
};

half _Glossiness;
half _Metallic;
half _TerrainGlossiness;
half _TerrainMetallic;
float _Blend;
float _BlendOffset;
float4 _terrainpos;
float4 _terrainmappos;
float4 _terrainmapscale;
float4 _terraintexturepos;
fixed4 _ColorCorrection;
half _UseAlphaSmoothness;


void vert (inout appdata_full v, out Input o) {
    UNITY_INITIALIZE_OUTPUT(Input,o);
    float3 pos = mul(unity_ObjectToWorld, v.vertex).xyz;
    v.texcoord = float4(pos.x - _terrainmappos.x,pos.z -_terrainmappos.y,0,0);
	v.normal = mul (unity_WorldToObject, float4(0,1,0,0));
	v.tangent.xyz = cross(v.normal, mul (unity_WorldToObject,float4(0,0,1,0)));
	v.tangent.w = -1;
}



void surf (Input IN, inout SurfaceOutputStandard o ) {
	float2 blendmapuv = (IN.uv_Blendmap+_terrainmappos.zw*0.5) / (_terrainmapscale.xz+_terrainmappos.zw);
	
	float theight = DecodeFloatRGBA(tex2D (_Blendmap, blendmapuv))*_terrainmapscale.y + _terrainmapscale.w;
	float diff = (IN.worldPos.y - theight) - _BlendOffset;
	fixed4 c = tex2D (_TerrainTex, IN.uv_TerrainTex );
	//o.Smoothness = lerp(_TerrainGlossiness,c.a,_UseAlphaSmoothness);
	c.a = clamp((1 - diff / _Blend),0,1);
	//startPlaying
	o.Emission = (_ColorCorrection.rgb * 2 * _LightColor0.rgb * c.rgb) + UNITY_LIGHTMODEL_AMBIENT.rgb;
	//end playing
	//o.Albedo = 1;
	fixed4 nmap = tex2D (_Blendnormalmap, blendmapuv );
	float3 terrainNormal = float3(nmap.x*2-1,nmap.y*2-1,nmap.z*2-1);
	//o.Normal = combineNormals(normalize(float3(nmap.x*2-1,nmap.y*2-1,nmap.z*2-1)),UnpackNormal(tex2D(_TerrainBump, IN.uv_TerrainBump)));
	//o.Normal = transformNormals(terrainNormal,UnpackNormal(tex2D(_TerrainBump, IN.uv_TerrainBump)),cross(terrainNormal, float3(0,1,0)));
	//o.Metallic = _TerrainMetallic;
	o.Alpha = c.a;
}

ENDCG
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
