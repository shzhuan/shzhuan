// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.27 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.27;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:0,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:False,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:33358,y:32946,varname:node_3138,prsc:2|custl-133-OUT,olwid-2137-OUT,olcol-5523-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:421,x:31421,y:33724,varname:node_421,prsc:2;n:type:ShaderForge.SFN_ObjectPosition,id:1662,x:31421,y:33854,varname:node_1662,prsc:2;n:type:ShaderForge.SFN_Subtract,id:7791,x:31636,y:33724,varname:node_7791,prsc:2|A-421-XYZ,B-1662-XYZ;n:type:ShaderForge.SFN_ComponentMask,id:1836,x:31903,y:33826,varname:node_1836,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-7791-OUT;n:type:ShaderForge.SFN_Lerp,id:4373,x:32678,y:33476,varname:node_4373,prsc:2|A-7779-RGB,B-393-RGB,T-9695-OUT;n:type:ShaderForge.SFN_Tex2d,id:7779,x:32027,y:33366,ptovrint:False,ptlb:TexLower,ptin:_TexLower,varname:node_7779,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:dc26a5b000b9ce345a54edc79e4d864d,ntxv:2,isnm:False;n:type:ShaderForge.SFN_ConstantClamp,id:575,x:32448,y:33837,varname:node_575,prsc:2,min:0,max:1|IN-1012-OUT;n:type:ShaderForge.SFN_Tex2d,id:3088,x:32392,y:34239,ptovrint:False,ptlb:TexTop,ptin:_TexTop,varname:node_3088,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:d89c03cbee179394ba76f8d8bc4ec504,ntxv:0,isnm:False|UVIN-5231-OUT;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:1012,x:32228,y:33982,varname:node_1012,prsc:2|IN-1836-OUT,IMIN-6756-OUT,IMAX-5182-OUT,OMIN-734-OUT,OMAX-597-OUT;n:type:ShaderForge.SFN_Slider,id:6756,x:31805,y:33996,ptovrint:False,ptlb:imin,ptin:_imin,varname:node_6756,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_Slider,id:5182,x:31805,y:34085,ptovrint:False,ptlb:imax,ptin:_imax,varname:node_5182,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Slider,id:597,x:31805,y:34246,ptovrint:False,ptlb:0max,ptin:_0max,varname:node_597,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2,max:10;n:type:ShaderForge.SFN_Vector1,id:734,x:31884,y:34160,varname:node_734,prsc:2,v1:0;n:type:ShaderForge.SFN_LightVector,id:8290,x:31573,y:33173,varname:node_8290,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:7954,x:31573,y:33303,prsc:2,pt:True;n:type:ShaderForge.SFN_Dot,id:9054,x:31817,y:33212,varname:node_9054,prsc:2,dt:0|A-8290-OUT,B-7954-OUT;n:type:ShaderForge.SFN_Multiply,id:276,x:32922,y:33047,varname:node_276,prsc:2|A-9427-OUT,B-4373-OUT,C-6336-OUT,D-7856-RGB;n:type:ShaderForge.SFN_RemapRange,id:3432,x:32098,y:33070,varname:node_3432,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-9054-OUT;n:type:ShaderForge.SFN_Append,id:2727,x:32314,y:33070,varname:node_2727,prsc:2|A-3432-OUT,B-6023-OUT;n:type:ShaderForge.SFN_Tex2d,id:8845,x:32476,y:33070,ptovrint:False,ptlb:ramp,ptin:_ramp,varname:node_8845,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ab04cf8dfe921ea4d9bc0b21a443482b,ntxv:0,isnm:False|UVIN-2727-OUT;n:type:ShaderForge.SFN_Vector1,id:6023,x:32098,y:33266,varname:node_6023,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Color,id:4087,x:32351,y:32813,ptovrint:False,ptlb:shadowColor,ptin:_shadowColor,varname:node_4087,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Blend,id:9427,x:32678,y:32921,varname:node_9427,prsc:2,blmd:7,clmp:True|SRC-4087-RGB,DST-8845-RGB;n:type:ShaderForge.SFN_LightAttenuation,id:6336,x:32678,y:33070,varname:node_6336,prsc:2;n:type:ShaderForge.SFN_Vector1,id:2137,x:32896,y:33257,varname:node_2137,prsc:2,v1:0.01;n:type:ShaderForge.SFN_Multiply,id:5523,x:33027,y:33451,varname:node_5523,prsc:2|A-4373-OUT,B-9405-OUT;n:type:ShaderForge.SFN_Slider,id:9405,x:32644,y:33647,ptovrint:False,ptlb:outlineColor,ptin:_outlineColor,varname:node_9405,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_AmbientLight,id:8342,x:32891,y:32830,varname:node_8342,prsc:2;n:type:ShaderForge.SFN_Add,id:133,x:33131,y:32844,varname:node_133,prsc:2|A-8342-RGB,B-276-OUT;n:type:ShaderForge.SFN_LightColor,id:7856,x:32678,y:33238,varname:node_7856,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:5541,x:31573,y:33482,varname:node_5541,prsc:2,uv:0;n:type:ShaderForge.SFN_Color,id:393,x:32077,y:33573,ptovrint:False,ptlb:topColor,ptin:_topColor,varname:node_393,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.04379326,c2:0.3308824,c3:0.3071232,c4:1;n:type:ShaderForge.SFN_Blend,id:9695,x:32895,y:33872,varname:node_9695,prsc:2,blmd:1,clmp:True|SRC-575-OUT,DST-3665-OUT;n:type:ShaderForge.SFN_Add,id:3665,x:32761,y:34042,varname:node_3665,prsc:2|A-3088-RGB,B-2484-OUT;n:type:ShaderForge.SFN_Slider,id:2484,x:32345,y:34095,ptovrint:False,ptlb:mossStrength,ptin:_mossStrength,varname:node_2484,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Append,id:5231,x:31869,y:34519,varname:node_5231,prsc:2|A-421-X,B-421-Z;n:type:ShaderForge.SFN_Fresnel,id:9488,x:33288,y:32659,varname:node_9488,prsc:2|EXP-903-OUT;n:type:ShaderForge.SFN_Add,id:6757,x:33458,y:32678,varname:node_6757,prsc:2|A-9488-OUT,B-9488-OUT;n:type:ShaderForge.SFN_Slider,id:903,x:32934,y:32682,ptovrint:False,ptlb:node_903,ptin:_node_903,varname:node_903,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:7.948718,max:10;n:type:ShaderForge.SFN_Color,id:2032,x:33321,y:32478,ptovrint:False,ptlb:node_2032,ptin:_node_2032,varname:node_2032,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Lerp,id:5577,x:33747,y:32786,varname:node_5577,prsc:2|B-2032-RGB,T-6757-OUT;proporder:7779-3088-6756-5182-597-8845-4087-9405-393-2484-903-2032;pass:END;sub:END;*/

Shader "Shader Forge/stoneTest" {
    Properties {
        _TexLower ("TexLower", 2D) = "black" {}
        _TexTop ("TexTop", 2D) = "white" {}
        _imin ("imin", Range(0, 1)) = 0.5
        _imax ("imax", Range(0, 1)) = 1
        _0max ("0max", Range(0, 10)) = 2
        _ramp ("ramp", 2D) = "white" {}
        _shadowColor ("shadowColor", Color) = (0,0,0,1)
        _outlineColor ("outlineColor", Range(0, 1)) = 0.5
        _topColor ("topColor", Color) = (0.04379326,0.3308824,0.3071232,1)
        _mossStrength ("mossStrength", Range(0, 1)) = 0
        _node_903 ("node_903", Range(0, 10)) = 7.948718
        _node_2032 ("node_2032", Color) = (0,0,0,1)
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
            uniform sampler2D _TexLower; uniform float4 _TexLower_ST;
            uniform sampler2D _TexTop; uniform float4 _TexTop_ST;
            uniform float _imin;
            uniform float _imax;
            uniform float _0max;
            uniform float _outlineColor;
            uniform float4 _topColor;
            uniform float _mossStrength;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, float4(v.vertex.xyz + v.normal*0.01,1) );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float4 _TexLower_var = tex2D(_TexLower,TRANSFORM_TEX(i.uv0, _TexLower));
                float node_734 = 0.0;
                float2 node_5231 = float2(i.posWorld.r,i.posWorld.b);
                float4 _TexTop_var = tex2D(_TexTop,TRANSFORM_TEX(node_5231, _TexTop));
                float3 node_4373 = lerp(_TexLower_var.rgb,_topColor.rgb,saturate((clamp((node_734 + ( ((i.posWorld.rgb-objPos.rgb).g - _imin) * (_0max - node_734) ) / (_imax - _imin)),0,1)*(_TexTop_var.rgb+_mossStrength))));
                return fixed4((node_4373*_outlineColor),0);
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
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _TexLower; uniform float4 _TexLower_ST;
            uniform sampler2D _TexTop; uniform float4 _TexTop_ST;
            uniform float _imin;
            uniform float _imax;
            uniform float _0max;
            uniform sampler2D _ramp; uniform float4 _ramp_ST;
            uniform float4 _shadowColor;
            uniform float4 _topColor;
            uniform float _mossStrength;
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
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float node_9054 = dot(lightDirection,normalDirection);
                float2 node_2727 = float2((node_9054*0.5+0.5),0.5);
                float4 _ramp_var = tex2D(_ramp,TRANSFORM_TEX(node_2727, _ramp));
                float4 _TexLower_var = tex2D(_TexLower,TRANSFORM_TEX(i.uv0, _TexLower));
                float node_734 = 0.0;
                float2 node_5231 = float2(i.posWorld.r,i.posWorld.b);
                float4 _TexTop_var = tex2D(_TexTop,TRANSFORM_TEX(node_5231, _TexTop));
                float3 node_4373 = lerp(_TexLower_var.rgb,_topColor.rgb,saturate((clamp((node_734 + ( ((i.posWorld.rgb-objPos.rgb).g - _imin) * (_0max - node_734) ) / (_imax - _imin)),0,1)*(_TexTop_var.rgb+_mossStrength))));
                float3 finalColor = (UNITY_LIGHTMODEL_AMBIENT.rgb+(saturate((_ramp_var.rgb/(1.0-_shadowColor.rgb)))*node_4373*attenuation*_LightColor0.rgb));
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
