// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.27 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.27;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:0,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:0,nrsp:2,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:False,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:34152,y:32415,varname:node_3138,prsc:2|diff-9687-OUT,custl-7847-OUT,olwid-3781-OUT,olcol-2440-RGB;n:type:ShaderForge.SFN_Tex2dAsset,id:2296,x:31944,y:32560,ptovrint:False,ptlb:Control,ptin:_Control,varname:node_2296,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:8961,x:32144,y:32517,varname:node_8961,prsc:2,ntxv:0,isnm:False|TEX-2296-TEX;n:type:ShaderForge.SFN_Append,id:6993,x:32393,y:32528,varname:node_6993,prsc:2|A-8961-RGB,B-8961-A;n:type:ShaderForge.SFN_Tex2dAsset,id:1073,x:32148,y:32701,ptovrint:False,ptlb:Splat0,ptin:_Splat0,varname:node_1073,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2dAsset,id:5730,x:32148,y:32891,ptovrint:False,ptlb:Splat1,ptin:_Splat1,varname:node_5730,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2dAsset,id:3381,x:32148,y:33088,ptovrint:False,ptlb:Splat2,ptin:_Splat2,varname:node_3381,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2dAsset,id:6158,x:32148,y:33280,ptovrint:False,ptlb:Splat3,ptin:_Splat3,varname:node_6158,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:5506,x:32348,y:32701,varname:node_5506,prsc:2,ntxv:0,isnm:False|TEX-1073-TEX;n:type:ShaderForge.SFN_Tex2d,id:5824,x:32366,y:32879,varname:node_5824,prsc:2,ntxv:0,isnm:False|TEX-5730-TEX;n:type:ShaderForge.SFN_Tex2d,id:9451,x:32366,y:33060,varname:node_9451,prsc:2,ntxv:0,isnm:False|TEX-3381-TEX;n:type:ShaderForge.SFN_Tex2d,id:7765,x:32366,y:33255,varname:node_7765,prsc:2,ntxv:0,isnm:False|TEX-6158-TEX;n:type:ShaderForge.SFN_ChannelBlend,id:4966,x:32614,y:32937,varname:node_4966,prsc:2,chbt:0|M-6993-OUT,R-5506-RGB,G-5824-RGB,B-9451-RGB,A-7765-RGB;n:type:ShaderForge.SFN_Tex2dAsset,id:3567,x:32634,y:32602,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_3567,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:2875,x:32829,y:32566,varname:node_2875,prsc:2,ntxv:0,isnm:False|TEX-3567-TEX;n:type:ShaderForge.SFN_Vector1,id:639,x:32919,y:32937,varname:node_639,prsc:2,v1:0;n:type:ShaderForge.SFN_Lerp,id:3729,x:33059,y:32658,varname:node_3729,prsc:2|A-2875-RGB,B-1244-RGB,T-639-OUT;n:type:ShaderForge.SFN_Color,id:1244,x:32829,y:32733,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_1244,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Lerp,id:9687,x:33270,y:32669,varname:node_9687,prsc:2|A-4966-OUT,B-3729-OUT,T-639-OUT;n:type:ShaderForge.SFN_Slider,id:3781,x:33060,y:33074,ptovrint:False,ptlb:outlineWidth,ptin:_outlineWidth,varname:node_3781,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_LightVector,id:6514,x:32099,y:32088,varname:node_6514,prsc:2;n:type:ShaderForge.SFN_Dot,id:2325,x:32353,y:32170,varname:node_2325,prsc:2,dt:0|A-6514-OUT,B-692-OUT;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:3045,x:32658,y:31989,varname:node_3045,prsc:2|IN-2325-OUT,IMIN-3867-OUT,IMAX-6728-OUT,OMIN-1003-OUT,OMAX-7961-OUT;n:type:ShaderForge.SFN_Slider,id:3867,x:32225,y:31775,ptovrint:False,ptlb:node_3867,ptin:_node_3867,varname:node_3867,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:-1,max:2;n:type:ShaderForge.SFN_Slider,id:6728,x:32225,y:31864,ptovrint:False,ptlb:node_6728,ptin:_node_6728,varname:node_6728,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:2;n:type:ShaderForge.SFN_Slider,id:1003,x:32225,y:31956,ptovrint:False,ptlb:node_1003,ptin:_node_1003,varname:node_1003,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:2;n:type:ShaderForge.SFN_Slider,id:7961,x:32225,y:32044,ptovrint:False,ptlb:node_7961,ptin:_node_7961,varname:node_7961,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:2;n:type:ShaderForge.SFN_Append,id:1210,x:32871,y:32011,varname:node_1210,prsc:2|A-3045-OUT,B-4107-OUT;n:type:ShaderForge.SFN_Vector1,id:4107,x:32658,y:32133,varname:node_4107,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Tex2d,id:5433,x:33176,y:32100,ptovrint:False,ptlb:ramp,ptin:_ramp,varname:node_5433,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ab04cf8dfe921ea4d9bc0b21a443482b,ntxv:0,isnm:False|UVIN-1210-OUT;n:type:ShaderForge.SFN_Multiply,id:9965,x:33559,y:32361,varname:node_9965,prsc:2|A-1156-OUT,B-6466-RGB,C-9687-OUT;n:type:ShaderForge.SFN_LightColor,id:6466,x:33257,y:32487,varname:node_6466,prsc:2;n:type:ShaderForge.SFN_Color,id:2440,x:33380,y:33143,ptovrint:False,ptlb:outlineColor,ptin:_outlineColor,varname:node_2440,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Add,id:7847,x:33843,y:32454,varname:node_7847,prsc:2|A-9965-OUT,B-4741-RGB;n:type:ShaderForge.SFN_AmbientLight,id:4741,x:33541,y:32726,varname:node_4741,prsc:2;n:type:ShaderForge.SFN_FragmentPosition,id:6588,x:31529,y:32167,varname:node_6588,prsc:2;n:type:ShaderForge.SFN_ObjectPosition,id:4283,x:31515,y:32362,varname:node_4283,prsc:2;n:type:ShaderForge.SFN_Subtract,id:28,x:31775,y:32241,varname:node_28,prsc:2|A-6588-XYZ,B-4283-XYZ;n:type:ShaderForge.SFN_LightAttenuation,id:5670,x:33271,y:32341,varname:node_5670,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:692,x:32043,y:32294,prsc:2,pt:False;n:type:ShaderForge.SFN_Blend,id:8661,x:33368,y:32119,varname:node_8661,prsc:2,blmd:18,clmp:True|SRC-5433-RGB,DST-5670-OUT;n:type:ShaderForge.SFN_OneMinus,id:1156,x:33548,y:32119,varname:node_1156,prsc:2|IN-8661-OUT;proporder:2296-1073-5730-3381-6158-3567-1244-3781-3867-6728-1003-7961-5433-2440;pass:END;sub:END;*/

Shader "Shader Forge/toonTerrain" {
    Properties {
        _Control ("Control", 2D) = "white" {}
        _Splat0 ("Splat0", 2D) = "white" {}
        _Splat1 ("Splat1", 2D) = "white" {}
        _Splat2 ("Splat2", 2D) = "white" {}
        _Splat3 ("Splat3", 2D) = "white" {}
        _MainTex ("MainTex", 2D) = "white" {}
        _Color ("Color", Color) = (0.5,0.5,0.5,1)
        _outlineWidth ("outlineWidth", Range(0, 1)) = 0
        _node_3867 ("node_3867", Range(-1, 2)) = -1
        _node_6728 ("node_6728", Range(0, 2)) = 1
        _node_1003 ("node_1003", Range(0, 2)) = 0
        _node_7961 ("node_7961", Range(0, 2)) = 1
        _ramp ("ramp", 2D) = "white" {}
        _outlineColor ("outlineColor", Color) = (0.5,0.5,0.5,1)
    }
    SubShader {
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
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float _outlineWidth;
            uniform float4 _outlineColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = mul(UNITY_MATRIX_MVP, float4(v.vertex.xyz + v.normal*_outlineWidth,1) );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                return fixed4(_outlineColor.rgb,0);
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
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _Control; uniform float4 _Control_ST;
            uniform sampler2D _Splat0; uniform float4 _Splat0_ST;
            uniform sampler2D _Splat1; uniform float4 _Splat1_ST;
            uniform sampler2D _Splat2; uniform float4 _Splat2_ST;
            uniform sampler2D _Splat3; uniform float4 _Splat3_ST;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _Color;
            uniform float _node_3867;
            uniform float _node_6728;
            uniform float _node_1003;
            uniform float _node_7961;
            uniform sampler2D _ramp; uniform float4 _ramp_ST;
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
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float2 node_1210 = float2((_node_1003 + ( (dot(lightDirection,i.normalDir) - _node_3867) * (_node_7961 - _node_1003) ) / (_node_6728 - _node_3867)),0.5);
                float4 _ramp_var = tex2D(_ramp,TRANSFORM_TEX(node_1210, _ramp));
                float4 node_8961 = tex2D(_Control,TRANSFORM_TEX(i.uv0, _Control));
                float4 node_6993 = float4(node_8961.rgb,node_8961.a);
                float4 node_5506 = tex2D(_Splat0,TRANSFORM_TEX(i.uv0, _Splat0));
                float4 node_5824 = tex2D(_Splat1,TRANSFORM_TEX(i.uv0, _Splat1));
                float4 node_9451 = tex2D(_Splat2,TRANSFORM_TEX(i.uv0, _Splat2));
                float4 node_7765 = tex2D(_Splat3,TRANSFORM_TEX(i.uv0, _Splat3));
                float4 node_2875 = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float node_639 = 0.0;
                float3 node_9687 = lerp((node_6993.r*node_5506.rgb + node_6993.g*node_5824.rgb + node_6993.b*node_9451.rgb + node_6993.a*node_7765.rgb),lerp(node_2875.rgb,_Color.rgb,node_639),node_639);
                float3 finalColor = (((1.0 - saturate((0.5 - 2.0*(_ramp_var.rgb-0.5)*(attenuation-0.5))))*_LightColor0.rgb*node_9687)+UNITY_LIGHTMODEL_AMBIENT.rgb);
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
