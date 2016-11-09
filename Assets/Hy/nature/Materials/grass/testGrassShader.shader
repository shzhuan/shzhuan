// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.27 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.27;sub:START;pass:START;ps:flbk:,iptp:1,cusa:True,bamd:0,lico:0,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:True,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:False,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.9087132,fgcg:0.9117647,fgcb:0.6905277,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:1873,x:33926,y:32758,varname:node_1873,prsc:2|emission-5348-OUT,clip-3535-OUT,voffset-2756-OUT;n:type:ShaderForge.SFN_Multiply,id:1086,x:32789,y:32879,cmnt:RGB,varname:node_1086,prsc:2|A-2887-OUT,B-5983-RGB;n:type:ShaderForge.SFN_Color,id:5983,x:32323,y:32650,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.1790117,c2:0.5661765,c3:0.3258673,c4:1;n:type:ShaderForge.SFN_VertexColor,id:5376,x:31958,y:32373,varname:node_5376,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1749,x:33087,y:32873,cmnt:Premultiply Alpha,varname:node_1749,prsc:2|A-1086-OUT,B-603-OUT;n:type:ShaderForge.SFN_Multiply,id:603,x:32789,y:33046,cmnt:A,varname:node_603,prsc:2|A-1054-A,B-5983-A;n:type:ShaderForge.SFN_Tex2d,id:1054,x:32369,y:33136,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_1054,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Slider,id:5472,x:32632,y:33233,ptovrint:False,ptlb:alphaClip,ptin:_alphaClip,varname:node_5472,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2,max:20;n:type:ShaderForge.SFN_Multiply,id:3535,x:33014,y:33133,varname:node_3535,prsc:2|A-603-OUT,B-5472-OUT;n:type:ShaderForge.SFN_TexCoord,id:844,x:31737,y:33373,varname:node_844,prsc:2,uv:0;n:type:ShaderForge.SFN_Time,id:5480,x:31934,y:33741,varname:node_5480,prsc:2;n:type:ShaderForge.SFN_Append,id:361,x:33376,y:33566,varname:node_361,prsc:2|A-4012-OUT,B-8371-OUT,C-688-OUT;n:type:ShaderForge.SFN_Vector1,id:8371,x:33090,y:33558,varname:node_8371,prsc:2,v1:0;n:type:ShaderForge.SFN_ComponentMask,id:3092,x:31923,y:33373,varname:node_3092,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-844-V;n:type:ShaderForge.SFN_RemapRange,id:2409,x:32101,y:33373,varname:node_2409,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-3092-OUT;n:type:ShaderForge.SFN_Clamp01,id:9435,x:32268,y:33373,varname:node_9435,prsc:2|IN-2409-OUT;n:type:ShaderForge.SFN_Multiply,id:4012,x:32534,y:33610,varname:node_4012,prsc:2|A-9435-OUT,B-5299-OUT;n:type:ShaderForge.SFN_Cos,id:5299,x:32308,y:33740,varname:node_5299,prsc:2|IN-5480-T;n:type:ShaderForge.SFN_Multiply,id:688,x:33090,y:33412,varname:node_688,prsc:2|A-9435-OUT,B-6409-OUT,C-1297-OUT;n:type:ShaderForge.SFN_Cos,id:6409,x:32831,y:33401,varname:node_6409,prsc:2|IN-8296-OUT;n:type:ShaderForge.SFN_RemapRange,id:8296,x:32632,y:33401,varname:node_8296,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-346-X;n:type:ShaderForge.SFN_Sin,id:1297,x:32318,y:33888,varname:node_1297,prsc:2|IN-5480-TDB;n:type:ShaderForge.SFN_Multiply,id:2756,x:33580,y:33400,varname:node_2756,prsc:2|A-4807-OUT,B-361-OUT;n:type:ShaderForge.SFN_Slider,id:4807,x:33238,y:33329,ptovrint:False,ptlb:Wavestrength,ptin:_Wavestrength,varname:node_4807,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2,max:1;n:type:ShaderForge.SFN_Add,id:5577,x:31171,y:32827,varname:node_5577,prsc:2|A-346-X,B-346-Y,C-346-Z;n:type:ShaderForge.SFN_Sin,id:2433,x:31672,y:32723,varname:node_2433,prsc:2|IN-8628-OUT;n:type:ShaderForge.SFN_Multiply,id:8628,x:31472,y:32723,varname:node_8628,prsc:2|A-8611-OUT,B-7349-OUT,C-5577-OUT;n:type:ShaderForge.SFN_Append,id:9782,x:32044,y:32842,varname:node_9782,prsc:2|A-6546-OUT,B-6546-OUT,C-6546-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:346,x:30951,y:32827,varname:node_346,prsc:2;n:type:ShaderForge.SFN_Slider,id:7349,x:30951,y:32731,ptovrint:False,ptlb:colorVariate,ptin:_colorVariate,varname:node_7349,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:50;n:type:ShaderForge.SFN_RemapRange,id:6546,x:31859,y:32842,varname:node_6546,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-2433-OUT;n:type:ShaderForge.SFN_Tau,id:8611,x:31258,y:32582,varname:node_8611,prsc:2;n:type:ShaderForge.SFN_Blend,id:2887,x:32230,y:32842,varname:node_2887,prsc:2,blmd:10,clmp:True|SRC-9782-OUT,DST-8666-OUT;n:type:ShaderForge.SFN_Color,id:9382,x:31958,y:32545,ptovrint:False,ptlb:node_9382,ptin:_node_9382,varname:node_9382,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2970767,c2:0.4338235,c3:0.1658737,c4:1;n:type:ShaderForge.SFN_Lerp,id:5348,x:33086,y:32613,varname:node_5348,prsc:2|A-5983-RGB,B-9382-RGB,T-2887-OUT;n:type:ShaderForge.SFN_Slider,id:8666,x:31763,y:33119,ptovrint:False,ptlb:node_8666,ptin:_node_8666,varname:node_8666,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3358707,max:1;proporder:5983-1054-5472-4807-7349-9382-8666;pass:END;sub:END;*/

Shader "Hidden/TerrainEngine/Details/WavingDoublePass" {
    Properties {
        _Color ("Color", Color) = (0.1790117,0.5661765,0.3258673,1)
        _MainTex ("MainTex", 2D) = "white" {}
        _alphaClip ("alphaClip", Range(0, 20)) = 2
        _Wavestrength ("Wavestrength", Range(0, 1)) = 0.2
        _colorVariate ("colorVariate", Range(0, 50)) = 1
        _node_9382 ("node_9382", Color) = (0.2970767,0.4338235,0.1658737,1)
        _node_8666 ("node_8666", Range(0, 1)) = 0.3358707
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
        [MaterialToggle] PixelSnap ("Pixel snap", Float) = 0
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
            "CanUseSpriteAtlas"="True"
            "PreviewType"="Plane"
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
            #pragma multi_compile _ PIXELSNAP_ON
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float _alphaClip;
            uniform float _Wavestrength;
            uniform float _colorVariate;
            uniform float4 _node_9382;
            uniform float _node_8666;
            struct VertexInput {
                float4 vertex : POSITION;
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
                float node_9435 = saturate((o.uv0.g.r*2.0+-1.0));
                float4 node_5480 = _Time + _TimeEditor;
                v.vertex.xyz += (_Wavestrength*float3((node_9435*cos(node_5480.g)),0.0,(node_9435*cos((mul(unity_ObjectToWorld, v.vertex).r*0.5+0.5))*sin(node_5480.b))));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                #ifdef PIXELSNAP_ON
                    o.pos = UnityPixelSnap(o.pos);
                #endif
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float node_603 = (_MainTex_var.a*_Color.a); // A
                clip((node_603*_alphaClip) - 0.5);
////// Lighting:
////// Emissive:
                float node_6546 = (sin((6.28318530718*_colorVariate*(i.posWorld.r+i.posWorld.g+i.posWorld.b)))*0.5+0.5);
                float3 node_2887 = saturate(( _node_8666 > 0.5 ? (1.0-(1.0-2.0*(_node_8666-0.5))*(1.0-float3(node_6546,node_6546,node_6546))) : (2.0*_node_8666*float3(node_6546,node_6546,node_6546)) ));
                float3 emissive = lerp(_Color.rgb,_node_9382.rgb,node_2887);
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
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
            #pragma multi_compile _ PIXELSNAP_ON
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float _alphaClip;
            uniform float _Wavestrength;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float node_9435 = saturate((o.uv0.g.r*2.0+-1.0));
                float4 node_5480 = _Time + _TimeEditor;
                v.vertex.xyz += (_Wavestrength*float3((node_9435*cos(node_5480.g)),0.0,(node_9435*cos((mul(unity_ObjectToWorld, v.vertex).r*0.5+0.5))*sin(node_5480.b))));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                #ifdef PIXELSNAP_ON
                    o.pos = UnityPixelSnap(o.pos);
                #endif
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float node_603 = (_MainTex_var.a*_Color.a); // A
                clip((node_603*_alphaClip) - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
