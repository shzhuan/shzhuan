// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.27 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.27;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:0,lgpr:1,limd:0,spmd:1,trmd:0,grmd:1,uamb:True,mssp:False,bkdf:True,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.9087132,fgcg:0.9117647,fgcb:0.6905277,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:0,x:34270,y:30757,varname:node_0,prsc:2|diff-82-RGB,spec-7036-R,gloss-6539-OUT,normal-83-RGB,emission-9141-OUT,lwrap-4956-OUT,amdfl-6373-RGB,custl-4943-OUT,olwid-6631-OUT,olcol-4495-OUT;n:type:ShaderForge.SFN_Tex2d,id:82,x:33127,y:31109,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:_Diffuse,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8993b617f08498f43adcbd90697f1c5d,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:83,x:33697,y:32095,ptovrint:False,ptlb:Normals,ptin:_Normals,varname:_Normals,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c6dfb00dbee6bc044a8a3bb22e56e064,ntxv:3,isnm:True|UVIN-272-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:272,x:33435,y:32222,varname:node_272,prsc:2,uv:0;n:type:ShaderForge.SFN_LightVector,id:9923,x:31683,y:31494,varname:node_9923,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:9443,x:31683,y:31619,prsc:2,pt:True;n:type:ShaderForge.SFN_Dot,id:6893,x:32036,y:31537,varname:node_6893,prsc:2,dt:0|A-9923-OUT,B-9443-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:4757,x:33459,y:31217,varname:node_4757,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:6652,x:32626,y:31098,ptovrint:False,ptlb:LightRamp,ptin:_LightRamp,varname:node_6652,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:6682d31b64eefd2478de4217da6429c9,ntxv:0,isnm:False|UVIN-3198-OUT;n:type:ShaderForge.SFN_Vector1,id:8577,x:32245,y:31706,varname:node_8577,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Append,id:3198,x:32456,y:31537,varname:node_3198,prsc:2|A-9326-OUT,B-8577-OUT;n:type:ShaderForge.SFN_LightColor,id:6762,x:33469,y:31339,varname:node_6762,prsc:2;n:type:ShaderForge.SFN_Multiply,id:4278,x:33760,y:31057,varname:node_4278,prsc:2|A-9762-OUT,B-6127-OUT,C-4757-OUT;n:type:ShaderForge.SFN_RemapRange,id:9326,x:32245,y:31537,varname:node_9326,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-6893-OUT;n:type:ShaderForge.SFN_Add,id:4943,x:33940,y:31000,varname:node_4943,prsc:2|A-9495-OUT,B-4278-OUT;n:type:ShaderForge.SFN_AmbientLight,id:6373,x:33732,y:30627,varname:node_6373,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:7036,x:31835,y:32219,ptovrint:False,ptlb:metalness,ptin:_metalness,varname:node_7036,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-272-UVOUT;n:type:ShaderForge.SFN_HalfVector,id:5853,x:31695,y:31947,varname:node_5853,prsc:2;n:type:ShaderForge.SFN_Power,id:7355,x:32673,y:31739,varname:node_7355,prsc:2|VAL-6428-OUT,EXP-4999-OUT;n:type:ShaderForge.SFN_Dot,id:6428,x:31896,y:31748,varname:node_6428,prsc:2,dt:1|A-9923-OUT,B-3707-OUT;n:type:ShaderForge.SFN_Add,id:9762,x:33469,y:31088,varname:node_9762,prsc:2|A-4306-OUT,B-7050-OUT;n:type:ShaderForge.SFN_Slider,id:8320,x:32054,y:31830,ptovrint:False,ptlb:glossiness,ptin:_glossiness,varname:node_8320,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:30;n:type:ShaderForge.SFN_Multiply,id:1832,x:33016,y:31822,varname:node_1832,prsc:2|A-9976-OUT,B-7036-A;n:type:ShaderForge.SFN_Slider,id:9976,x:32807,y:31672,ptovrint:False,ptlb:specular,ptin:_specular,varname:node_9976,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:2;n:type:ShaderForge.SFN_Multiply,id:7050,x:33239,y:31786,varname:node_7050,prsc:2|A-1832-OUT,B-7355-OUT;n:type:ShaderForge.SFN_Multiply,id:8910,x:32213,y:30806,varname:node_8910,prsc:2|A-6652-RGB,B-811-RGB;n:type:ShaderForge.SFN_Color,id:811,x:32570,y:30782,ptovrint:False,ptlb:shadowIntensity,ptin:_shadowIntensity,varname:node_811,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:6539,x:33982,y:31676,varname:node_6539,prsc:2|A-5210-OUT,B-5759-OUT;n:type:ShaderForge.SFN_Slider,id:5759,x:34107,y:31891,ptovrint:False,ptlb:smoothness,ptin:_smoothness,varname:node_5759,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:2;n:type:ShaderForge.SFN_Tex2d,id:7890,x:34201,y:31331,ptovrint:False,ptlb:transmission,ptin:_transmission,varname:node_7890,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Multiply,id:4956,x:34538,y:31532,varname:node_4956,prsc:2|A-7890-R,B-6580-RGB;n:type:ShaderForge.SFN_Color,id:6580,x:34182,y:31544,ptovrint:False,ptlb:tramsionColor,ptin:_tramsionColor,varname:node_6580,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_OneMinus,id:5210,x:33735,y:31659,varname:node_5210,prsc:2|IN-7036-A;n:type:ShaderForge.SFN_Slider,id:6631,x:34520,y:31084,ptovrint:False,ptlb:outlineWidth,ptin:_outlineWidth,varname:node_6631,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:0.01;n:type:ShaderForge.SFN_ViewReflectionVector,id:3707,x:31660,y:31771,varname:node_3707,prsc:2;n:type:ShaderForge.SFN_RemapRange,id:503,x:32086,y:31958,varname:node_503,prsc:2,frmn:0,frmx:1,tomn:1,tomx:11|IN-7036-R;n:type:ShaderForge.SFN_Multiply,id:4999,x:32432,y:31797,varname:node_4999,prsc:2|A-8320-OUT,B-503-OUT;n:type:ShaderForge.SFN_Add,id:1708,x:33630,y:31906,varname:node_1708,prsc:2|A-7050-OUT,B-7120-OUT;n:type:ShaderForge.SFN_Append,id:8341,x:32828,y:32065,varname:node_8341,prsc:2|A-7355-OUT,B-8577-OUT;n:type:ShaderForge.SFN_Tex2d,id:790,x:33056,y:32030,ptovrint:False,ptlb:highLight,ptin:_highLight,varname:node_790,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-8341-OUT;n:type:ShaderForge.SFN_Color,id:8389,x:33032,y:32273,ptovrint:False,ptlb:highLightColor,ptin:_highLightColor,varname:node_8389,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:7120,x:33266,y:32047,varname:node_7120,prsc:2|A-790-RGB,B-8389-RGB;n:type:ShaderForge.SFN_Blend,id:4874,x:33184,y:30836,varname:node_4874,prsc:2,blmd:2,clmp:True|SRC-5792-OUT,DST-82-RGB;n:type:ShaderForge.SFN_Blend,id:5792,x:32905,y:30746,varname:node_5792,prsc:2,blmd:7,clmp:True|SRC-811-RGB,DST-6652-RGB;n:type:ShaderForge.SFN_Blend,id:8425,x:34538,y:31346,varname:node_8425,prsc:2,blmd:2,clmp:True|SRC-7890-R,DST-6580-RGB;n:type:ShaderForge.SFN_Multiply,id:6127,x:33807,y:31341,varname:node_6127,prsc:2|A-6762-RGB,B-5223-OUT;n:type:ShaderForge.SFN_Slider,id:5223,x:33391,y:31557,ptovrint:False,ptlb:lightIntensity,ptin:_lightIntensity,varname:node_5223,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:3;n:type:ShaderForge.SFN_Multiply,id:9495,x:34026,y:30750,varname:node_9495,prsc:2|A-6373-RGB,B-82-RGB,C-2218-OUT;n:type:ShaderForge.SFN_Slider,id:2218,x:33653,y:30818,ptovrint:False,ptlb:ambient,ptin:_ambient,varname:node_2218,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:3;n:type:ShaderForge.SFN_Blend,id:327,x:33593,y:31825,varname:node_327,prsc:2,blmd:7,clmp:True|SRC-7050-OUT,DST-7120-OUT;n:type:ShaderForge.SFN_Tex2d,id:1604,x:32751,y:31352,ptovrint:False,ptlb:backLightTex,ptin:_backLightTex,varname:node_1604,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-3198-OUT;n:type:ShaderForge.SFN_Color,id:3585,x:32736,y:31552,ptovrint:False,ptlb:backLightintensity,ptin:_backLightintensity,varname:node_3585,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:9141,x:32997,y:31352,varname:node_9141,prsc:2|A-1604-RGB,B-3585-RGB;n:type:ShaderForge.SFN_Add,id:4306,x:33469,y:30876,varname:node_4306,prsc:2|A-4874-OUT,B-9141-OUT;n:type:ShaderForge.SFN_Multiply,id:4495,x:34132,y:31178,varname:node_4495,prsc:2|A-82-RGB,B-2315-OUT;n:type:ShaderForge.SFN_Slider,id:2315,x:33825,y:31546,ptovrint:False,ptlb:outlineDarkness,ptin:_outlineDarkness,varname:node_2315,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;proporder:82-83-6652-811-7036-8320-9976-5759-7890-6580-790-8389-1604-3585-5223-2218-6631-2315;pass:END;sub:END;*/

Shader "Shader Forge/Examples/Custom Lighting" {
    Properties {
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Normals ("Normals", 2D) = "bump" {}
        _LightRamp ("LightRamp", 2D) = "white" {}
        _shadowIntensity ("shadowIntensity", Color) = (1,1,1,1)
        _metalness ("metalness", 2D) = "white" {}
        _glossiness ("glossiness", Range(0, 30)) = 1
        _specular ("specular", Range(0, 2)) = 1
        _smoothness ("smoothness", Range(0, 2)) = 1
        _transmission ("transmission", 2D) = "black" {}
        _tramsionColor ("tramsionColor", Color) = (0,0,0,1)
        _highLight ("highLight", 2D) = "white" {}
        _highLightColor ("highLightColor", Color) = (0.5,0.5,0.5,1)
        _backLightTex ("backLightTex", 2D) = "white" {}
        _backLightintensity ("backLightintensity", Color) = (0.5,0.5,0.5,1)
        _lightIntensity ("lightIntensity", Range(0, 3)) = 1
        _ambient ("ambient", Range(0, 3)) = 1
        _outlineWidth ("outlineWidth", Range(0, 0.01)) = 0
        _outlineDarkness ("outlineDarkness", Range(0, 1)) = 0
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
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform float _outlineWidth;
            uniform float _outlineDarkness;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, float4(v.vertex.xyz + v.normal*_outlineWidth,1) );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                return fixed4((_Diffuse_var.rgb*_outlineDarkness),0);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform sampler2D _Normals; uniform float4 _Normals_ST;
            uniform sampler2D _LightRamp; uniform float4 _LightRamp_ST;
            uniform sampler2D _metalness; uniform float4 _metalness_ST;
            uniform float _glossiness;
            uniform float _specular;
            uniform float4 _shadowIntensity;
            uniform float _smoothness;
            uniform sampler2D _transmission; uniform float4 _transmission_ST;
            uniform float4 _tramsionColor;
            uniform float _lightIntensity;
            uniform float _ambient;
            uniform sampler2D _backLightTex; uniform float4 _backLightTex_ST;
            uniform float4 _backLightintensity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _Normals_var = UnpackNormal(tex2D(_Normals,TRANSFORM_TEX(i.uv0, _Normals)));
                float3 normalLocal = _Normals_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
////// Emissive:
                float node_8577 = 0.5;
                float2 node_3198 = float2((dot(lightDirection,normalDirection)*0.5+0.5),node_8577);
                float4 _backLightTex_var = tex2D(_backLightTex,TRANSFORM_TEX(node_3198, _backLightTex));
                float3 node_9141 = (_backLightTex_var.rgb*_backLightintensity.rgb);
                float3 emissive = node_9141;
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float4 _LightRamp_var = tex2D(_LightRamp,TRANSFORM_TEX(node_3198, _LightRamp));
                float4 _metalness_var = tex2D(_metalness,TRANSFORM_TEX(i.uv0, _metalness));
                float node_7355 = pow(max(0,dot(lightDirection,viewReflectDirection)),(_glossiness*(_metalness_var.r*10.0+1.0)));
                float node_7050 = ((_specular*_metalness_var.a)*node_7355);
                float3 finalColor = emissive + ((UNITY_LIGHTMODEL_AMBIENT.rgb*_Diffuse_var.rgb*_ambient)+(((saturate((1.0-((1.0-_Diffuse_var.rgb)/saturate((_LightRamp_var.rgb/(1.0-_shadowIntensity.rgb))))))+node_9141)+node_7050)*(_LightColor0.rgb*_lightIntensity)*attenuation));
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #include "UnityCG.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform sampler2D _metalness; uniform float4 _metalness_ST;
            uniform float _smoothness;
            uniform sampler2D _backLightTex; uniform float4 _backLightTex_ST;
            uniform float4 _backLightintensity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : SV_Target {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float node_8577 = 0.5;
                float2 node_3198 = float2((dot(lightDirection,normalDirection)*0.5+0.5),node_8577);
                float4 _backLightTex_var = tex2D(_backLightTex,TRANSFORM_TEX(node_3198, _backLightTex));
                float3 node_9141 = (_backLightTex_var.rgb*_backLightintensity.rgb);
                o.Emission = node_9141;
                
                float3 diffColor = float3(0,0,0);
                o.Albedo = diffColor;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
