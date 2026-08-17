Shader "UI/BadgeSparkle" {
	Properties {
		_SparkleTex ("Sheen Texture", 2D) = "black" {}
		[PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
		_Color ("Tint", Vector) = (1,1,1,1)
		_StencilComp ("Stencil Comparison", Float) = 8
		_Stencil ("Stencil ID", Float) = 0
		_StencilOp ("Stencil Operation", Float) = 0
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		_StencilReadMask ("Stencil Read Mask", Float) = 255
		_SparkleSpeed ("Sparkle Speed", Float) = 1
		_ColorMask ("Color Mask", Float) = 15
		[Toggle(UNITY_UI_ALPHACLIP)] _UseUIAlphaClip ("Use Alpha Clip", Float) = 0
	}
	SubShader {
		Tags { "CanUseSpriteAtlas" = "true" "IGNOREPROJECTOR" = "true" "PreviewType" = "Plane" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
		0 {
			Name "Default"
			Tags { "CanUseSpriteAtlas" = "true" "IGNOREPROJECTOR" = "true" "PreviewType" = "Plane" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
			Blend SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
			ColorMask 0 -1
			ZWrite Off
			Cull Off
			Stencil {
				ReadMask 0
				WriteMask 0
				Comp Disabled
				Pass Keep
				Fail Keep
				ZFail Keep
			}
			GpuProgramID 26588
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 100
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	mediump float _SparkleSpeed;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SparkleTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec2 u_xlat1;
					lowp float u_xlat10_1;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp float u_xlat10_5;
					mediump vec3 u_xlat16_6;
					lowp float u_xlat10_9;
					mediump vec2 u_xlat16_10;
					void main()
					{
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat1.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat1.x * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat1.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_10.xy = u_xlat1.xy * vec2(12.0, 12.0);
					    u_xlat10_1 = texture2D(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_5 = texture2D(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_9 = texture2D(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_9 * 5.0;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat10_5;
					    u_xlat1.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_10.xy = u_xlat1.xy * vec2(_SparkleSpeed) + u_xlat16_10.xy;
					    u_xlat10_1 = texture2D(_SparkleTex, u_xlat16_10.xy).x;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat16_6.x;
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_6.xyz = u_xlat16_6.xxx * u_xlat16_3.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_6.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    SV_Target0.w = u_xlat16_0.w;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 100
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	mediump float _SparkleSpeed;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SparkleTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec2 u_xlat1;
					lowp float u_xlat10_1;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp float u_xlat10_5;
					mediump vec3 u_xlat16_6;
					lowp float u_xlat10_9;
					mediump vec2 u_xlat16_10;
					void main()
					{
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat1.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat1.x * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat1.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_10.xy = u_xlat1.xy * vec2(12.0, 12.0);
					    u_xlat10_1 = texture2D(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_5 = texture2D(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_9 = texture2D(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_9 * 5.0;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat10_5;
					    u_xlat1.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_10.xy = u_xlat1.xy * vec2(_SparkleSpeed) + u_xlat16_10.xy;
					    u_xlat10_1 = texture2D(_SparkleTex, u_xlat16_10.xy).x;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat16_6.x;
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_6.xyz = u_xlat16_6.xxx * u_xlat16_3.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_6.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    SV_Target0.w = u_xlat16_0.w;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 100
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	mediump float _SparkleSpeed;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SparkleTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec2 u_xlat1;
					lowp float u_xlat10_1;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp float u_xlat10_5;
					mediump vec3 u_xlat16_6;
					lowp float u_xlat10_9;
					mediump vec2 u_xlat16_10;
					void main()
					{
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat1.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat1.x * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat1.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_10.xy = u_xlat1.xy * vec2(12.0, 12.0);
					    u_xlat10_1 = texture2D(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_5 = texture2D(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_9 = texture2D(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_9 * 5.0;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat10_5;
					    u_xlat1.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_10.xy = u_xlat1.xy * vec2(_SparkleSpeed) + u_xlat16_10.xy;
					    u_xlat10_1 = texture2D(_SparkleTex, u_xlat16_10.xy).x;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat16_6.x;
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_6.xyz = u_xlat16_6.xxx * u_xlat16_3.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_6.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    SV_Target0.w = u_xlat16_0.w;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out mediump vec4 vs_COLOR0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	mediump float _SparkleSpeed;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SparkleTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec2 u_xlat1;
					mediump float u_xlat10_1;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump float u_xlat10_5;
					mediump vec3 u_xlat16_6;
					mediump float u_xlat10_9;
					mediump vec2 u_xlat16_10;
					void main()
					{
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat1.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat1.x * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat1.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_10.xy = u_xlat1.xy * vec2(12.0, 12.0);
					    u_xlat10_1 = texture(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_5 = texture(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_9 = texture(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_9 * 5.0;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat10_5;
					    u_xlat1.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_10.xy = u_xlat1.xy * vec2(_SparkleSpeed) + u_xlat16_10.xy;
					    u_xlat10_1 = texture(_SparkleTex, u_xlat16_10.xy).x;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat16_6.x;
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_6.xyz = u_xlat16_6.xxx * u_xlat16_3.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_6.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.xyz = min(max(u_xlat16_2.xyz, 0.0), 1.0);
					#else
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					#endif
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    SV_Target0.w = u_xlat16_0.w;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out mediump vec4 vs_COLOR0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	mediump float _SparkleSpeed;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SparkleTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec2 u_xlat1;
					mediump float u_xlat10_1;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump float u_xlat10_5;
					mediump vec3 u_xlat16_6;
					mediump float u_xlat10_9;
					mediump vec2 u_xlat16_10;
					void main()
					{
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat1.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat1.x * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat1.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_10.xy = u_xlat1.xy * vec2(12.0, 12.0);
					    u_xlat10_1 = texture(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_5 = texture(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_9 = texture(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_9 * 5.0;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat10_5;
					    u_xlat1.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_10.xy = u_xlat1.xy * vec2(_SparkleSpeed) + u_xlat16_10.xy;
					    u_xlat10_1 = texture(_SparkleTex, u_xlat16_10.xy).x;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat16_6.x;
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_6.xyz = u_xlat16_6.xxx * u_xlat16_3.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_6.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.xyz = min(max(u_xlat16_2.xyz, 0.0), 1.0);
					#else
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					#endif
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    SV_Target0.w = u_xlat16_0.w;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out mediump vec4 vs_COLOR0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	mediump float _SparkleSpeed;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SparkleTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec2 u_xlat1;
					mediump float u_xlat10_1;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump float u_xlat10_5;
					mediump vec3 u_xlat16_6;
					mediump float u_xlat10_9;
					mediump vec2 u_xlat16_10;
					void main()
					{
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat1.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat1.x * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat1.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_10.xy = u_xlat1.xy * vec2(12.0, 12.0);
					    u_xlat10_1 = texture(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_5 = texture(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_9 = texture(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_9 * 5.0;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat10_5;
					    u_xlat1.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_10.xy = u_xlat1.xy * vec2(_SparkleSpeed) + u_xlat16_10.xy;
					    u_xlat10_1 = texture(_SparkleTex, u_xlat16_10.xy).x;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat16_6.x;
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_6.xyz = u_xlat16_6.xxx * u_xlat16_3.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_6.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.xyz = min(max(u_xlat16_2.xyz, 0.0), 1.0);
					#else
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					#endif
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    SV_Target0.w = u_xlat16_0.w;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "UNITY_UI_ALPHACLIP" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 100
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	mediump float _SparkleSpeed;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SparkleTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec2 u_xlat2;
					lowp float u_xlat10_2;
					bool u_xlatb2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					lowp float u_xlat10_7;
					mediump vec3 u_xlat16_8;
					lowp float u_xlat10_12;
					mediump vec2 u_xlat16_13;
					void main()
					{
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_1.x = u_xlat16_0.w * vs_COLOR0.w + -0.00100000005;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlatb2 = u_xlat16_1.x<0.0;
					    if(((int(u_xlatb2) * -1))!=0){discard;}
					    u_xlat1 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat1 = u_xlat1 * vec4(_SparkleSpeed);
					    u_xlat2.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat2.x = u_xlat2.x * vs_TEXCOORD2.x;
					    u_xlat2.y = vs_TEXCOORD2.y;
					    u_xlat16_3.xy = u_xlat2.xy * vec2(5.0, 5.0) + u_xlat1.ww;
					    u_xlat16_1 = u_xlat2.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat1.xxyz;
					    u_xlat16_13.xy = u_xlat2.xy * vec2(12.0, 12.0);
					    u_xlat10_2 = texture2D(_SparkleTex, u_xlat16_3.xy).x;
					    u_xlat10_7 = texture2D(_SparkleTex, u_xlat16_1.xy).x;
					    u_xlat10_12 = texture2D(_SparkleTex, u_xlat16_1.zw).x;
					    u_xlat16_3.x = u_xlat10_12 * 5.0;
					    u_xlat16_8.x = u_xlat10_2 + u_xlat10_7;
					    u_xlat2.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_13.xy = u_xlat2.xy * vec2(_SparkleSpeed) + u_xlat16_13.xy;
					    u_xlat10_2 = texture2D(_SparkleTex, u_xlat16_13.xy).x;
					    u_xlat16_8.x = u_xlat10_2 + u_xlat16_8.x;
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_8.xyz = u_xlat16_8.xxx * u_xlat16_4.xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xxx * u_xlat16_8.xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz * vec3(5.0, 5.0, 5.0);
					    u_xlat16_3.xyz = clamp(u_xlat16_3.xyz, 0.0, 1.0);
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_3.xyz;
					    SV_Target0.w = u_xlat16_0.w;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "UNITY_UI_ALPHACLIP" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 100
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	mediump float _SparkleSpeed;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SparkleTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec2 u_xlat2;
					lowp float u_xlat10_2;
					bool u_xlatb2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					lowp float u_xlat10_7;
					mediump vec3 u_xlat16_8;
					lowp float u_xlat10_12;
					mediump vec2 u_xlat16_13;
					void main()
					{
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_1.x = u_xlat16_0.w * vs_COLOR0.w + -0.00100000005;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlatb2 = u_xlat16_1.x<0.0;
					    if(((int(u_xlatb2) * -1))!=0){discard;}
					    u_xlat1 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat1 = u_xlat1 * vec4(_SparkleSpeed);
					    u_xlat2.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat2.x = u_xlat2.x * vs_TEXCOORD2.x;
					    u_xlat2.y = vs_TEXCOORD2.y;
					    u_xlat16_3.xy = u_xlat2.xy * vec2(5.0, 5.0) + u_xlat1.ww;
					    u_xlat16_1 = u_xlat2.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat1.xxyz;
					    u_xlat16_13.xy = u_xlat2.xy * vec2(12.0, 12.0);
					    u_xlat10_2 = texture2D(_SparkleTex, u_xlat16_3.xy).x;
					    u_xlat10_7 = texture2D(_SparkleTex, u_xlat16_1.xy).x;
					    u_xlat10_12 = texture2D(_SparkleTex, u_xlat16_1.zw).x;
					    u_xlat16_3.x = u_xlat10_12 * 5.0;
					    u_xlat16_8.x = u_xlat10_2 + u_xlat10_7;
					    u_xlat2.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_13.xy = u_xlat2.xy * vec2(_SparkleSpeed) + u_xlat16_13.xy;
					    u_xlat10_2 = texture2D(_SparkleTex, u_xlat16_13.xy).x;
					    u_xlat16_8.x = u_xlat10_2 + u_xlat16_8.x;
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_8.xyz = u_xlat16_8.xxx * u_xlat16_4.xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xxx * u_xlat16_8.xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz * vec3(5.0, 5.0, 5.0);
					    u_xlat16_3.xyz = clamp(u_xlat16_3.xyz, 0.0, 1.0);
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_3.xyz;
					    SV_Target0.w = u_xlat16_0.w;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "UNITY_UI_ALPHACLIP" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 100
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	mediump float _SparkleSpeed;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SparkleTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec2 u_xlat2;
					lowp float u_xlat10_2;
					bool u_xlatb2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					lowp float u_xlat10_7;
					mediump vec3 u_xlat16_8;
					lowp float u_xlat10_12;
					mediump vec2 u_xlat16_13;
					void main()
					{
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_1.x = u_xlat16_0.w * vs_COLOR0.w + -0.00100000005;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlatb2 = u_xlat16_1.x<0.0;
					    if(((int(u_xlatb2) * -1))!=0){discard;}
					    u_xlat1 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat1 = u_xlat1 * vec4(_SparkleSpeed);
					    u_xlat2.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat2.x = u_xlat2.x * vs_TEXCOORD2.x;
					    u_xlat2.y = vs_TEXCOORD2.y;
					    u_xlat16_3.xy = u_xlat2.xy * vec2(5.0, 5.0) + u_xlat1.ww;
					    u_xlat16_1 = u_xlat2.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat1.xxyz;
					    u_xlat16_13.xy = u_xlat2.xy * vec2(12.0, 12.0);
					    u_xlat10_2 = texture2D(_SparkleTex, u_xlat16_3.xy).x;
					    u_xlat10_7 = texture2D(_SparkleTex, u_xlat16_1.xy).x;
					    u_xlat10_12 = texture2D(_SparkleTex, u_xlat16_1.zw).x;
					    u_xlat16_3.x = u_xlat10_12 * 5.0;
					    u_xlat16_8.x = u_xlat10_2 + u_xlat10_7;
					    u_xlat2.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_13.xy = u_xlat2.xy * vec2(_SparkleSpeed) + u_xlat16_13.xy;
					    u_xlat10_2 = texture2D(_SparkleTex, u_xlat16_13.xy).x;
					    u_xlat16_8.x = u_xlat10_2 + u_xlat16_8.x;
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_8.xyz = u_xlat16_8.xxx * u_xlat16_4.xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xxx * u_xlat16_8.xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz * vec3(5.0, 5.0, 5.0);
					    u_xlat16_3.xyz = clamp(u_xlat16_3.xyz, 0.0, 1.0);
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_3.xyz;
					    SV_Target0.w = u_xlat16_0.w;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "UNITY_UI_ALPHACLIP" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out mediump vec4 vs_COLOR0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	mediump float _SparkleSpeed;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SparkleTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec2 u_xlat2;
					mediump float u_xlat10_2;
					bool u_xlatb2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					mediump float u_xlat10_7;
					mediump vec3 u_xlat16_8;
					mediump float u_xlat10_12;
					mediump vec2 u_xlat16_13;
					void main()
					{
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_1.x = u_xlat16_0.w * vs_COLOR0.w + -0.00100000005;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb2 = !!(u_xlat16_1.x<0.0);
					#else
					    u_xlatb2 = u_xlat16_1.x<0.0;
					#endif
					    if(((int(u_xlatb2) * int(0xffffffffu)))!=0){discard;}
					    u_xlat1 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat1 = u_xlat1 * vec4(_SparkleSpeed);
					    u_xlat2.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat2.x = u_xlat2.x * vs_TEXCOORD2.x;
					    u_xlat2.y = vs_TEXCOORD2.y;
					    u_xlat16_3.xy = u_xlat2.xy * vec2(5.0, 5.0) + u_xlat1.ww;
					    u_xlat16_1 = u_xlat2.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat1.xxyz;
					    u_xlat16_13.xy = u_xlat2.xy * vec2(12.0, 12.0);
					    u_xlat10_2 = texture(_SparkleTex, u_xlat16_3.xy).x;
					    u_xlat10_7 = texture(_SparkleTex, u_xlat16_1.xy).x;
					    u_xlat10_12 = texture(_SparkleTex, u_xlat16_1.zw).x;
					    u_xlat16_3.x = u_xlat10_12 * 5.0;
					    u_xlat16_8.x = u_xlat10_2 + u_xlat10_7;
					    u_xlat2.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_13.xy = u_xlat2.xy * vec2(_SparkleSpeed) + u_xlat16_13.xy;
					    u_xlat10_2 = texture(_SparkleTex, u_xlat16_13.xy).x;
					    u_xlat16_8.x = u_xlat10_2 + u_xlat16_8.x;
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_8.xyz = u_xlat16_8.xxx * u_xlat16_4.xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xxx * u_xlat16_8.xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz * vec3(5.0, 5.0, 5.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_3.xyz = min(max(u_xlat16_3.xyz, 0.0), 1.0);
					#else
					    u_xlat16_3.xyz = clamp(u_xlat16_3.xyz, 0.0, 1.0);
					#endif
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_3.xyz;
					    SV_Target0.w = u_xlat16_0.w;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "UNITY_UI_ALPHACLIP" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out mediump vec4 vs_COLOR0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	mediump float _SparkleSpeed;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SparkleTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec2 u_xlat2;
					mediump float u_xlat10_2;
					bool u_xlatb2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					mediump float u_xlat10_7;
					mediump vec3 u_xlat16_8;
					mediump float u_xlat10_12;
					mediump vec2 u_xlat16_13;
					void main()
					{
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_1.x = u_xlat16_0.w * vs_COLOR0.w + -0.00100000005;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb2 = !!(u_xlat16_1.x<0.0);
					#else
					    u_xlatb2 = u_xlat16_1.x<0.0;
					#endif
					    if(((int(u_xlatb2) * int(0xffffffffu)))!=0){discard;}
					    u_xlat1 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat1 = u_xlat1 * vec4(_SparkleSpeed);
					    u_xlat2.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat2.x = u_xlat2.x * vs_TEXCOORD2.x;
					    u_xlat2.y = vs_TEXCOORD2.y;
					    u_xlat16_3.xy = u_xlat2.xy * vec2(5.0, 5.0) + u_xlat1.ww;
					    u_xlat16_1 = u_xlat2.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat1.xxyz;
					    u_xlat16_13.xy = u_xlat2.xy * vec2(12.0, 12.0);
					    u_xlat10_2 = texture(_SparkleTex, u_xlat16_3.xy).x;
					    u_xlat10_7 = texture(_SparkleTex, u_xlat16_1.xy).x;
					    u_xlat10_12 = texture(_SparkleTex, u_xlat16_1.zw).x;
					    u_xlat16_3.x = u_xlat10_12 * 5.0;
					    u_xlat16_8.x = u_xlat10_2 + u_xlat10_7;
					    u_xlat2.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_13.xy = u_xlat2.xy * vec2(_SparkleSpeed) + u_xlat16_13.xy;
					    u_xlat10_2 = texture(_SparkleTex, u_xlat16_13.xy).x;
					    u_xlat16_8.x = u_xlat10_2 + u_xlat16_8.x;
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_8.xyz = u_xlat16_8.xxx * u_xlat16_4.xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xxx * u_xlat16_8.xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz * vec3(5.0, 5.0, 5.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_3.xyz = min(max(u_xlat16_3.xyz, 0.0), 1.0);
					#else
					    u_xlat16_3.xyz = clamp(u_xlat16_3.xyz, 0.0, 1.0);
					#endif
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_3.xyz;
					    SV_Target0.w = u_xlat16_0.w;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "UNITY_UI_ALPHACLIP" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out mediump vec4 vs_COLOR0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	mediump float _SparkleSpeed;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SparkleTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec2 u_xlat2;
					mediump float u_xlat10_2;
					bool u_xlatb2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					mediump float u_xlat10_7;
					mediump vec3 u_xlat16_8;
					mediump float u_xlat10_12;
					mediump vec2 u_xlat16_13;
					void main()
					{
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_1.x = u_xlat16_0.w * vs_COLOR0.w + -0.00100000005;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb2 = !!(u_xlat16_1.x<0.0);
					#else
					    u_xlatb2 = u_xlat16_1.x<0.0;
					#endif
					    if(((int(u_xlatb2) * int(0xffffffffu)))!=0){discard;}
					    u_xlat1 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat1 = u_xlat1 * vec4(_SparkleSpeed);
					    u_xlat2.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat2.x = u_xlat2.x * vs_TEXCOORD2.x;
					    u_xlat2.y = vs_TEXCOORD2.y;
					    u_xlat16_3.xy = u_xlat2.xy * vec2(5.0, 5.0) + u_xlat1.ww;
					    u_xlat16_1 = u_xlat2.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat1.xxyz;
					    u_xlat16_13.xy = u_xlat2.xy * vec2(12.0, 12.0);
					    u_xlat10_2 = texture(_SparkleTex, u_xlat16_3.xy).x;
					    u_xlat10_7 = texture(_SparkleTex, u_xlat16_1.xy).x;
					    u_xlat10_12 = texture(_SparkleTex, u_xlat16_1.zw).x;
					    u_xlat16_3.x = u_xlat10_12 * 5.0;
					    u_xlat16_8.x = u_xlat10_2 + u_xlat10_7;
					    u_xlat2.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_13.xy = u_xlat2.xy * vec2(_SparkleSpeed) + u_xlat16_13.xy;
					    u_xlat10_2 = texture(_SparkleTex, u_xlat16_13.xy).x;
					    u_xlat16_8.x = u_xlat10_2 + u_xlat16_8.x;
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_8.xyz = u_xlat16_8.xxx * u_xlat16_4.xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xxx * u_xlat16_8.xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz * vec3(5.0, 5.0, 5.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_3.xyz = min(max(u_xlat16_3.xyz, 0.0), 1.0);
					#else
					    u_xlat16_3.xyz = clamp(u_xlat16_3.xyz, 0.0, 1.0);
					#endif
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_3.xyz;
					    SV_Target0.w = u_xlat16_0.w;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "UNITY_UI_CLIP_RECT" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 100
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	vec4 _ClipRect;
					uniform 	mediump float _SparkleSpeed;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SparkleTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					lowp float u_xlat10_1;
					bvec4 u_xlatb1;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp float u_xlat10_5;
					mediump vec3 u_xlat16_6;
					lowp float u_xlat10_9;
					mediump vec2 u_xlat16_10;
					void main()
					{
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat1.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat1.x * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat1.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_10.xy = u_xlat1.xy * vec2(12.0, 12.0);
					    u_xlat10_1 = texture2D(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_5 = texture2D(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_9 = texture2D(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_9 * 5.0;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat10_5;
					    u_xlat1.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_10.xy = u_xlat1.xy * vec2(_SparkleSpeed) + u_xlat16_10.xy;
					    u_xlat10_1 = texture2D(_SparkleTex, u_xlat16_10.xy).x;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat16_6.x;
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_6.xyz = u_xlat16_6.xxx * u_xlat16_3.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_6.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    u_xlatb1.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlatb1.zw = greaterThanEqual(_ClipRect.zzzw, vs_TEXCOORD1.xxxy).zw;
					    u_xlat1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(u_xlatb1));
					    u_xlat1.xy = u_xlat1.zw * u_xlat1.xy;
					    u_xlat1.x = u_xlat1.y * u_xlat1.x;
					    u_xlat1.x = u_xlat16_0.w * u_xlat1.x;
					    SV_Target0.w = u_xlat1.x;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "UNITY_UI_CLIP_RECT" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 100
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	vec4 _ClipRect;
					uniform 	mediump float _SparkleSpeed;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SparkleTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					lowp float u_xlat10_1;
					bvec4 u_xlatb1;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp float u_xlat10_5;
					mediump vec3 u_xlat16_6;
					lowp float u_xlat10_9;
					mediump vec2 u_xlat16_10;
					void main()
					{
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat1.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat1.x * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat1.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_10.xy = u_xlat1.xy * vec2(12.0, 12.0);
					    u_xlat10_1 = texture2D(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_5 = texture2D(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_9 = texture2D(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_9 * 5.0;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat10_5;
					    u_xlat1.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_10.xy = u_xlat1.xy * vec2(_SparkleSpeed) + u_xlat16_10.xy;
					    u_xlat10_1 = texture2D(_SparkleTex, u_xlat16_10.xy).x;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat16_6.x;
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_6.xyz = u_xlat16_6.xxx * u_xlat16_3.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_6.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    u_xlatb1.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlatb1.zw = greaterThanEqual(_ClipRect.zzzw, vs_TEXCOORD1.xxxy).zw;
					    u_xlat1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(u_xlatb1));
					    u_xlat1.xy = u_xlat1.zw * u_xlat1.xy;
					    u_xlat1.x = u_xlat1.y * u_xlat1.x;
					    u_xlat1.x = u_xlat16_0.w * u_xlat1.x;
					    SV_Target0.w = u_xlat1.x;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "UNITY_UI_CLIP_RECT" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 100
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	vec4 _ClipRect;
					uniform 	mediump float _SparkleSpeed;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SparkleTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					lowp float u_xlat10_1;
					bvec4 u_xlatb1;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp float u_xlat10_5;
					mediump vec3 u_xlat16_6;
					lowp float u_xlat10_9;
					mediump vec2 u_xlat16_10;
					void main()
					{
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat1.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat1.x * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat1.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_10.xy = u_xlat1.xy * vec2(12.0, 12.0);
					    u_xlat10_1 = texture2D(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_5 = texture2D(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_9 = texture2D(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_9 * 5.0;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat10_5;
					    u_xlat1.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_10.xy = u_xlat1.xy * vec2(_SparkleSpeed) + u_xlat16_10.xy;
					    u_xlat10_1 = texture2D(_SparkleTex, u_xlat16_10.xy).x;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat16_6.x;
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_6.xyz = u_xlat16_6.xxx * u_xlat16_3.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_6.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    u_xlatb1.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlatb1.zw = greaterThanEqual(_ClipRect.zzzw, vs_TEXCOORD1.xxxy).zw;
					    u_xlat1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(u_xlatb1));
					    u_xlat1.xy = u_xlat1.zw * u_xlat1.xy;
					    u_xlat1.x = u_xlat1.y * u_xlat1.x;
					    u_xlat1.x = u_xlat16_0.w * u_xlat1.x;
					    SV_Target0.w = u_xlat1.x;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "UNITY_UI_CLIP_RECT" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out mediump vec4 vs_COLOR0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	vec4 _ClipRect;
					uniform 	mediump float _SparkleSpeed;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SparkleTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump float u_xlat10_1;
					bvec4 u_xlatb1;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump float u_xlat10_5;
					mediump vec3 u_xlat16_6;
					mediump float u_xlat10_9;
					mediump vec2 u_xlat16_10;
					void main()
					{
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat1.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat1.x * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat1.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_10.xy = u_xlat1.xy * vec2(12.0, 12.0);
					    u_xlat10_1 = texture(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_5 = texture(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_9 = texture(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_9 * 5.0;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat10_5;
					    u_xlat1.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_10.xy = u_xlat1.xy * vec2(_SparkleSpeed) + u_xlat16_10.xy;
					    u_xlat10_1 = texture(_SparkleTex, u_xlat16_10.xy).x;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat16_6.x;
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_6.xyz = u_xlat16_6.xxx * u_xlat16_3.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_6.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.xyz = min(max(u_xlat16_2.xyz, 0.0), 1.0);
					#else
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					#endif
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    u_xlatb1.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlatb1.zw = greaterThanEqual(_ClipRect.zzzw, vs_TEXCOORD1.xxxy).zw;
					    u_xlat1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(u_xlatb1));
					    u_xlat1.xy = u_xlat1.zw * u_xlat1.xy;
					    u_xlat1.x = u_xlat1.y * u_xlat1.x;
					    u_xlat1.x = u_xlat16_0.w * u_xlat1.x;
					    SV_Target0.w = u_xlat1.x;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "UNITY_UI_CLIP_RECT" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out mediump vec4 vs_COLOR0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	vec4 _ClipRect;
					uniform 	mediump float _SparkleSpeed;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SparkleTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump float u_xlat10_1;
					bvec4 u_xlatb1;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump float u_xlat10_5;
					mediump vec3 u_xlat16_6;
					mediump float u_xlat10_9;
					mediump vec2 u_xlat16_10;
					void main()
					{
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat1.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat1.x * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat1.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_10.xy = u_xlat1.xy * vec2(12.0, 12.0);
					    u_xlat10_1 = texture(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_5 = texture(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_9 = texture(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_9 * 5.0;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat10_5;
					    u_xlat1.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_10.xy = u_xlat1.xy * vec2(_SparkleSpeed) + u_xlat16_10.xy;
					    u_xlat10_1 = texture(_SparkleTex, u_xlat16_10.xy).x;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat16_6.x;
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_6.xyz = u_xlat16_6.xxx * u_xlat16_3.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_6.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.xyz = min(max(u_xlat16_2.xyz, 0.0), 1.0);
					#else
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					#endif
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    u_xlatb1.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlatb1.zw = greaterThanEqual(_ClipRect.zzzw, vs_TEXCOORD1.xxxy).zw;
					    u_xlat1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(u_xlatb1));
					    u_xlat1.xy = u_xlat1.zw * u_xlat1.xy;
					    u_xlat1.x = u_xlat1.y * u_xlat1.x;
					    u_xlat1.x = u_xlat16_0.w * u_xlat1.x;
					    SV_Target0.w = u_xlat1.x;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "UNITY_UI_CLIP_RECT" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out mediump vec4 vs_COLOR0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	vec4 _ClipRect;
					uniform 	mediump float _SparkleSpeed;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SparkleTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump float u_xlat10_1;
					bvec4 u_xlatb1;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump float u_xlat10_5;
					mediump vec3 u_xlat16_6;
					mediump float u_xlat10_9;
					mediump vec2 u_xlat16_10;
					void main()
					{
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat1.x = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat1.x * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat1.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_10.xy = u_xlat1.xy * vec2(12.0, 12.0);
					    u_xlat10_1 = texture(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_5 = texture(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_9 = texture(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_9 * 5.0;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat10_5;
					    u_xlat1.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_10.xy = u_xlat1.xy * vec2(_SparkleSpeed) + u_xlat16_10.xy;
					    u_xlat10_1 = texture(_SparkleTex, u_xlat16_10.xy).x;
					    u_xlat16_6.x = u_xlat10_1 + u_xlat16_6.x;
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_6.xyz = u_xlat16_6.xxx * u_xlat16_3.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_6.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.xyz = min(max(u_xlat16_2.xyz, 0.0), 1.0);
					#else
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					#endif
					    SV_Target0.xyz = u_xlat16_0.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    u_xlatb1.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlatb1.zw = greaterThanEqual(_ClipRect.zzzw, vs_TEXCOORD1.xxxy).zw;
					    u_xlat1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(u_xlatb1));
					    u_xlat1.xy = u_xlat1.zw * u_xlat1.xy;
					    u_xlat1.x = u_xlat1.y * u_xlat1.x;
					    u_xlat1.x = u_xlat16_0.w * u_xlat1.x;
					    SV_Target0.w = u_xlat1.x;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "UNITY_UI_CLIP_RECT" "UNITY_UI_ALPHACLIP" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 100
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	vec4 _ClipRect;
					uniform 	mediump float _SparkleSpeed;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SparkleTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					bvec4 u_xlatb0;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					mediump vec3 u_xlat16_2;
					vec2 u_xlat3;
					lowp float u_xlat10_3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_7;
					lowp float u_xlat10_8;
					mediump vec2 u_xlat16_12;
					float u_xlat16;
					lowp float u_xlat10_16;
					void main()
					{
					    u_xlatb0.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlatb0.zw = greaterThanEqual(_ClipRect.zzzw, vs_TEXCOORD1.xxxy).zw;
					    u_xlat0 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(u_xlatb0));
					    u_xlat0.xy = u_xlat0.zw * u_xlat0.xy;
					    u_xlat0.x = u_xlat0.y * u_xlat0.x;
					    u_xlat10_1 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_1 = u_xlat10_1 + _TextureSampleAdd;
					    u_xlat16_1 = u_xlat16_1 * vs_COLOR0;
					    u_xlat16_2.x = u_xlat16_1.w * u_xlat0.x + -0.00100000005;
					    u_xlat0.x = u_xlat0.x * u_xlat16_1.w;
					    SV_Target0.w = u_xlat0.x;
					    u_xlatb0.x = u_xlat16_2.x<0.0;
					    if(((int(u_xlatb0.x) * -1))!=0){discard;}
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat16 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat16 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat3.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat3.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_12.xy = u_xlat3.xy * vec2(12.0, 12.0);
					    u_xlat10_16 = texture2D(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_3 = texture2D(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_8 = texture2D(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_8 * 5.0;
					    u_xlat16_7.x = u_xlat10_16 + u_xlat10_3;
					    u_xlat3.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_12.xy = u_xlat3.xy * vec2(_SparkleSpeed) + u_xlat16_12.xy;
					    u_xlat10_16 = texture2D(_SparkleTex, u_xlat16_12.xy).x;
					    u_xlat16_7.x = u_xlat10_16 + u_xlat16_7.x;
					    u_xlat16_4.xyz = u_xlat16_1.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_7.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					    SV_Target0.xyz = u_xlat16_1.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "UNITY_UI_CLIP_RECT" "UNITY_UI_ALPHACLIP" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 100
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	vec4 _ClipRect;
					uniform 	mediump float _SparkleSpeed;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SparkleTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					bvec4 u_xlatb0;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					mediump vec3 u_xlat16_2;
					vec2 u_xlat3;
					lowp float u_xlat10_3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_7;
					lowp float u_xlat10_8;
					mediump vec2 u_xlat16_12;
					float u_xlat16;
					lowp float u_xlat10_16;
					void main()
					{
					    u_xlatb0.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlatb0.zw = greaterThanEqual(_ClipRect.zzzw, vs_TEXCOORD1.xxxy).zw;
					    u_xlat0 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(u_xlatb0));
					    u_xlat0.xy = u_xlat0.zw * u_xlat0.xy;
					    u_xlat0.x = u_xlat0.y * u_xlat0.x;
					    u_xlat10_1 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_1 = u_xlat10_1 + _TextureSampleAdd;
					    u_xlat16_1 = u_xlat16_1 * vs_COLOR0;
					    u_xlat16_2.x = u_xlat16_1.w * u_xlat0.x + -0.00100000005;
					    u_xlat0.x = u_xlat0.x * u_xlat16_1.w;
					    SV_Target0.w = u_xlat0.x;
					    u_xlatb0.x = u_xlat16_2.x<0.0;
					    if(((int(u_xlatb0.x) * -1))!=0){discard;}
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat16 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat16 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat3.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat3.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_12.xy = u_xlat3.xy * vec2(12.0, 12.0);
					    u_xlat10_16 = texture2D(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_3 = texture2D(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_8 = texture2D(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_8 * 5.0;
					    u_xlat16_7.x = u_xlat10_16 + u_xlat10_3;
					    u_xlat3.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_12.xy = u_xlat3.xy * vec2(_SparkleSpeed) + u_xlat16_12.xy;
					    u_xlat10_16 = texture2D(_SparkleTex, u_xlat16_12.xy).x;
					    u_xlat16_7.x = u_xlat10_16 + u_xlat16_7.x;
					    u_xlat16_4.xyz = u_xlat16_1.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_7.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					    SV_Target0.xyz = u_xlat16_1.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "UNITY_UI_CLIP_RECT" "UNITY_UI_ALPHACLIP" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 100
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	vec4 _ClipRect;
					uniform 	mediump float _SparkleSpeed;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SparkleTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					bvec4 u_xlatb0;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					mediump vec3 u_xlat16_2;
					vec2 u_xlat3;
					lowp float u_xlat10_3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_7;
					lowp float u_xlat10_8;
					mediump vec2 u_xlat16_12;
					float u_xlat16;
					lowp float u_xlat10_16;
					void main()
					{
					    u_xlatb0.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlatb0.zw = greaterThanEqual(_ClipRect.zzzw, vs_TEXCOORD1.xxxy).zw;
					    u_xlat0 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(u_xlatb0));
					    u_xlat0.xy = u_xlat0.zw * u_xlat0.xy;
					    u_xlat0.x = u_xlat0.y * u_xlat0.x;
					    u_xlat10_1 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_1 = u_xlat10_1 + _TextureSampleAdd;
					    u_xlat16_1 = u_xlat16_1 * vs_COLOR0;
					    u_xlat16_2.x = u_xlat16_1.w * u_xlat0.x + -0.00100000005;
					    u_xlat0.x = u_xlat0.x * u_xlat16_1.w;
					    SV_Target0.w = u_xlat0.x;
					    u_xlatb0.x = u_xlat16_2.x<0.0;
					    if(((int(u_xlatb0.x) * -1))!=0){discard;}
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat16 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat16 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat3.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat3.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_12.xy = u_xlat3.xy * vec2(12.0, 12.0);
					    u_xlat10_16 = texture2D(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_3 = texture2D(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_8 = texture2D(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_8 * 5.0;
					    u_xlat16_7.x = u_xlat10_16 + u_xlat10_3;
					    u_xlat3.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_12.xy = u_xlat3.xy * vec2(_SparkleSpeed) + u_xlat16_12.xy;
					    u_xlat10_16 = texture2D(_SparkleTex, u_xlat16_12.xy).x;
					    u_xlat16_7.x = u_xlat10_16 + u_xlat16_7.x;
					    u_xlat16_4.xyz = u_xlat16_1.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_7.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					    SV_Target0.xyz = u_xlat16_1.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "UNITY_UI_CLIP_RECT" "UNITY_UI_ALPHACLIP" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out mediump vec4 vs_COLOR0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	vec4 _ClipRect;
					uniform 	mediump float _SparkleSpeed;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SparkleTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					bvec4 u_xlatb0;
					mediump vec4 u_xlat16_1;
					mediump vec3 u_xlat16_2;
					vec2 u_xlat3;
					mediump float u_xlat10_3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_7;
					mediump float u_xlat10_8;
					mediump vec2 u_xlat16_12;
					float u_xlat16;
					mediump float u_xlat10_16;
					void main()
					{
					    u_xlatb0.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlatb0.zw = greaterThanEqual(_ClipRect.zzzw, vs_TEXCOORD1.xxxy).zw;
					    u_xlat0 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(u_xlatb0));
					    u_xlat0.xy = u_xlat0.zw * u_xlat0.xy;
					    u_xlat0.x = u_xlat0.y * u_xlat0.x;
					    u_xlat16_1 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_1 = u_xlat16_1 + _TextureSampleAdd;
					    u_xlat16_1 = u_xlat16_1 * vs_COLOR0;
					    u_xlat16_2.x = u_xlat16_1.w * u_xlat0.x + -0.00100000005;
					    u_xlat0.x = u_xlat0.x * u_xlat16_1.w;
					    SV_Target0.w = u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(u_xlat16_2.x<0.0);
					#else
					    u_xlatb0.x = u_xlat16_2.x<0.0;
					#endif
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))!=0){discard;}
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat16 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat16 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat3.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat3.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_12.xy = u_xlat3.xy * vec2(12.0, 12.0);
					    u_xlat10_16 = texture(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_3 = texture(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_8 = texture(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_8 * 5.0;
					    u_xlat16_7.x = u_xlat10_16 + u_xlat10_3;
					    u_xlat3.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_12.xy = u_xlat3.xy * vec2(_SparkleSpeed) + u_xlat16_12.xy;
					    u_xlat10_16 = texture(_SparkleTex, u_xlat16_12.xy).x;
					    u_xlat16_7.x = u_xlat10_16 + u_xlat16_7.x;
					    u_xlat16_4.xyz = u_xlat16_1.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_7.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.xyz = min(max(u_xlat16_2.xyz, 0.0), 1.0);
					#else
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					#endif
					    SV_Target0.xyz = u_xlat16_1.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "UNITY_UI_CLIP_RECT" "UNITY_UI_ALPHACLIP" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out mediump vec4 vs_COLOR0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	vec4 _ClipRect;
					uniform 	mediump float _SparkleSpeed;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SparkleTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					bvec4 u_xlatb0;
					mediump vec4 u_xlat16_1;
					mediump vec3 u_xlat16_2;
					vec2 u_xlat3;
					mediump float u_xlat10_3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_7;
					mediump float u_xlat10_8;
					mediump vec2 u_xlat16_12;
					float u_xlat16;
					mediump float u_xlat10_16;
					void main()
					{
					    u_xlatb0.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlatb0.zw = greaterThanEqual(_ClipRect.zzzw, vs_TEXCOORD1.xxxy).zw;
					    u_xlat0 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(u_xlatb0));
					    u_xlat0.xy = u_xlat0.zw * u_xlat0.xy;
					    u_xlat0.x = u_xlat0.y * u_xlat0.x;
					    u_xlat16_1 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_1 = u_xlat16_1 + _TextureSampleAdd;
					    u_xlat16_1 = u_xlat16_1 * vs_COLOR0;
					    u_xlat16_2.x = u_xlat16_1.w * u_xlat0.x + -0.00100000005;
					    u_xlat0.x = u_xlat0.x * u_xlat16_1.w;
					    SV_Target0.w = u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(u_xlat16_2.x<0.0);
					#else
					    u_xlatb0.x = u_xlat16_2.x<0.0;
					#endif
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))!=0){discard;}
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat16 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat16 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat3.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat3.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_12.xy = u_xlat3.xy * vec2(12.0, 12.0);
					    u_xlat10_16 = texture(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_3 = texture(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_8 = texture(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_8 * 5.0;
					    u_xlat16_7.x = u_xlat10_16 + u_xlat10_3;
					    u_xlat3.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_12.xy = u_xlat3.xy * vec2(_SparkleSpeed) + u_xlat16_12.xy;
					    u_xlat10_16 = texture(_SparkleTex, u_xlat16_12.xy).x;
					    u_xlat16_7.x = u_xlat10_16 + u_xlat16_7.x;
					    u_xlat16_4.xyz = u_xlat16_1.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_7.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.xyz = min(max(u_xlat16_2.xyz, 0.0), 1.0);
					#else
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					#endif
					    SV_Target0.xyz = u_xlat16_1.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "UNITY_UI_CLIP_RECT" "UNITY_UI_ALPHACLIP" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					uniform 	mediump vec4 _Color;
					uniform 	vec4 _MainTex_ST;
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out mediump vec4 vs_COLOR0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    gl_Position = u_xlat0;
					    u_xlat1 = in_COLOR0 * _Color;
					    vs_COLOR0 = u_xlat1;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD1 = in_POSITION0;
					    u_xlat0.y = u_xlat0.y * _ProjectionParams.x;
					    u_xlat1.xzw = u_xlat0.xwy * vec3(0.5, 0.5, 0.5);
					    vs_TEXCOORD2.zw = u_xlat0.zw;
					    vs_TEXCOORD2.xy = u_xlat1.zz + u_xlat1.xw;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	vec4 _ScreenParams;
					uniform 	mediump vec4 _TextureSampleAdd;
					uniform 	vec4 _ClipRect;
					uniform 	mediump float _SparkleSpeed;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SparkleTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					bvec4 u_xlatb0;
					mediump vec4 u_xlat16_1;
					mediump vec3 u_xlat16_2;
					vec2 u_xlat3;
					mediump float u_xlat10_3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_7;
					mediump float u_xlat10_8;
					mediump vec2 u_xlat16_12;
					float u_xlat16;
					mediump float u_xlat10_16;
					void main()
					{
					    u_xlatb0.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlatb0.zw = greaterThanEqual(_ClipRect.zzzw, vs_TEXCOORD1.xxxy).zw;
					    u_xlat0 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(u_xlatb0));
					    u_xlat0.xy = u_xlat0.zw * u_xlat0.xy;
					    u_xlat0.x = u_xlat0.y * u_xlat0.x;
					    u_xlat16_1 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_1 = u_xlat16_1 + _TextureSampleAdd;
					    u_xlat16_1 = u_xlat16_1 * vs_COLOR0;
					    u_xlat16_2.x = u_xlat16_1.w * u_xlat0.x + -0.00100000005;
					    u_xlat0.x = u_xlat0.x * u_xlat16_1.w;
					    SV_Target0.w = u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(u_xlat16_2.x<0.0);
					#else
					    u_xlatb0.x = u_xlat16_2.x<0.0;
					#endif
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))!=0){discard;}
					    u_xlat0 = _Time.xxxx * vec4(0.100000001, 0.0419999994, -0.0500000007, -0.219999999);
					    u_xlat0 = u_xlat0 * vec4(_SparkleSpeed);
					    u_xlat16 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat16 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat16_2.xy = u_xlat3.xy * vec2(5.0, 5.0) + u_xlat0.ww;
					    u_xlat16_0 = u_xlat3.xyxy * vec4(3.0, 3.0, 4.0, 4.0) + u_xlat0.xxyz;
					    u_xlat16_12.xy = u_xlat3.xy * vec2(12.0, 12.0);
					    u_xlat10_16 = texture(_SparkleTex, u_xlat16_2.xy).x;
					    u_xlat10_3 = texture(_SparkleTex, u_xlat16_0.xy).x;
					    u_xlat10_8 = texture(_SparkleTex, u_xlat16_0.zw).x;
					    u_xlat16_2.x = u_xlat10_8 * 5.0;
					    u_xlat16_7.x = u_xlat10_16 + u_xlat10_3;
					    u_xlat3.xy = _Time.xx * vec2(-0.200000003, -0.899999976);
					    u_xlat16_12.xy = u_xlat3.xy * vec2(_SparkleSpeed) + u_xlat16_12.xy;
					    u_xlat10_16 = texture(_SparkleTex, u_xlat16_12.xy).x;
					    u_xlat16_7.x = u_xlat10_16 + u_xlat16_7.x;
					    u_xlat16_4.xyz = u_xlat16_1.xyz * vec3(2.4000001, 2.4000001, 2.4000001);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xxx * u_xlat16_7.xyz;
					    u_xlat16_2.xyz = u_xlat16_2.xyz * vec3(5.0, 5.0, 5.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.xyz = min(max(u_xlat16_2.xyz, 0.0), 1.0);
					#else
					    u_xlat16_2.xyz = clamp(u_xlat16_2.xyz, 0.0, 1.0);
					#endif
					    SV_Target0.xyz = u_xlat16_1.xyz * vec3(1.20000005, 1.20000005, 1.20000005) + u_xlat16_2.xyz;
					    return;
					}
					
					#endif"
				}
			}
			Program "fp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "UNITY_UI_ALPHACLIP" }
					"!!GLES"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "UNITY_UI_ALPHACLIP" }
					"!!GLES"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "UNITY_UI_ALPHACLIP" }
					"!!GLES"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "UNITY_UI_ALPHACLIP" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "UNITY_UI_ALPHACLIP" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "UNITY_UI_ALPHACLIP" }
					"!!GLES3"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "UNITY_UI_CLIP_RECT" }
					"!!GLES"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "UNITY_UI_CLIP_RECT" }
					"!!GLES"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "UNITY_UI_CLIP_RECT" }
					"!!GLES"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "UNITY_UI_CLIP_RECT" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "UNITY_UI_CLIP_RECT" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "UNITY_UI_CLIP_RECT" }
					"!!GLES3"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "UNITY_UI_CLIP_RECT" "UNITY_UI_ALPHACLIP" }
					"!!GLES"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "UNITY_UI_CLIP_RECT" "UNITY_UI_ALPHACLIP" }
					"!!GLES"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "UNITY_UI_CLIP_RECT" "UNITY_UI_ALPHACLIP" }
					"!!GLES"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "UNITY_UI_CLIP_RECT" "UNITY_UI_ALPHACLIP" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "UNITY_UI_CLIP_RECT" "UNITY_UI_ALPHACLIP" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "UNITY_UI_CLIP_RECT" "UNITY_UI_ALPHACLIP" }
					"!!GLES3"
				}
			}
		}
	}
}