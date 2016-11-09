Shader "Nature/Tree Creator Bark" {
Properties {
	_Color ("Main Color", Color) = (0.709,0.6585646,0.543094,1)
	_Shininess ("Shininess", Range (0.01, 1)) = 0.078125
	_MainTex ("Base (RGB) Alpha (A)", 2D) = "white" {}
	_BumpMap ("Normalmap", 2D) = "bump" {}
	_GlossMap ("Gloss (A)", 2D) = "black" {}
	        _barkColor ("barkColor", Color) = (0.709,0.6585646,0.543094,1)
        _ramp ("ramp", 2D) = "white" {}
        _node_9653 ("node_9653", Range(0, 0.1)) = 0.04648411
        _outlineColor ("outlineColor", Color) = (0.5,0.5,0.5,1)
	
	// These are here only to provide default values
	_SpecColor ("Specular Color", Color) = (0.5, 0.5, 0.5, 1)
	[HideInInspector] _TreeInstanceColor ("TreeInstanceColor", Vector) = (1,1,1,1)
	[HideInInspector] _TreeInstanceScale ("TreeInstanceScale", Vector) = (1,1,1,1)
	[HideInInspector] _SquashAmount ("Squash", Float) = 1
}

SubShader { 

//Custom-------------
Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _barkColor;
            uniform sampler2D _ramp; uniform float4 _ramp_ST;
            uniform float _node_9653;
            uniform float4 _outlineColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                UNITY_FOG_COORDS(2)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, float4(v.vertex.xyz + v.normal*_node_9653,1) );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float2 node_5062 = float2((dot(lightDirection,i.normalDir)*0.5+0.5),0.5);
                float4 _ramp_var = tex2D(_ramp,TRANSFORM_TEX(node_5062, _ramp));
                float3 node_5455 = (_ramp_var.rgb*_barkColor.rgb);
                return fixed4((node_5455*_outlineColor.rgb),0);
            }
            ENDCG
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
            uniform float4 _barkColor;
            uniform sampler2D _ramp; uniform float4 _ramp_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                LIGHTING_COORDS(2,3)
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
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
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float node_5586 = 0.0;
                float3 specularColor = float3(node_5586,node_5586,node_5586);
                float3 directSpecular = attenColor * pow(max(0,dot(reflect(-lightDirection, normalDirection),viewDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuseColor = float3(node_5586,node_5586,node_5586);
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float2 node_5062 = float2((dot(lightDirection,i.normalDir)*0.5+0.5),0.5);
                float4 _ramp_var = tex2D(_ramp,TRANSFORM_TEX(node_5062, _ramp));
                float3 node_5455 = (_ramp_var.rgb*_barkColor.rgb);
                float3 emissive = node_5455;
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
			}

		//Custom----------------

/*	Tags { "IgnoreProjector"="True" "RenderType"="TreeBark" }
	LOD 200
		
CGPROGRAM
#pragma surface surf BlinnPhong vertex:TreeVertBark addshadow nolightmap
#include "UnityBuiltin3xTreeLibrary.cginc"

sampler2D _MainTex;
sampler2D _BumpMap;
sampler2D _GlossMap;
half _Shininess;

struct Input {
	float2 uv_MainTex;
	fixed4 color : COLOR;
};

void surf (Input IN, inout SurfaceOutput o) {
	fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
	o.Albedo = c.rgb * IN.color.rgb * IN.color.a;
	o.Gloss = tex2D(_GlossMap, IN.uv_MainTex).a;
	o.Alpha = c.a;
	o.Specular = _Shininess;
	o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_MainTex));
}
ENDCG
*/
}

Dependency "OptimizedShader" = "Hidden/Nature/Tree Creator Bark Optimized"
FallBack "Diffuse"
}
