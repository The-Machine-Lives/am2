Shader "UI/BadgeHolofoil" {
	Properties {
		_FlowTex ("Flow Texture", 2D) = "white" {}
		[PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
		_Color ("Tint", Vector) = (1,1,1,1)
		_StencilComp ("Stencil Comparison", Float) = 8
		_Stencil ("Stencil ID", Float) = 0
		_StencilOp ("Stencil Operation", Float) = 0
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		_StencilReadMask ("Stencil Read Mask", Float) = 255
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
			GpuProgramID 25448
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
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _FlowTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					float u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec2 u_xlat1;
					bool u_xlatb1;
					mediump vec2 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					float u_xlat5;
					lowp vec2 u_xlat10_5;
					mediump vec3 u_xlat16_7;
					mediump vec3 u_xlat16_8;
					lowp float u_xlat10_10;
					mediump vec2 u_xlat16_12;
					float u_xlat15;
					void main()
					{
					    u_xlat0 = _Time.x * -0.5;
					    u_xlat0 = fract(u_xlat0);
					    u_xlat5 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat5 * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat10_5.xy = texture2D(_FlowTex, u_xlat1.xy).xy;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_12.xy = u_xlat10_5.xy * vec2(u_xlat0) + u_xlat16_2.xy;
					    u_xlat10_0.x = texture2D(_FlowTex, u_xlat16_12.xy).x;
					    u_xlat15 = _Time.x * -0.5 + 0.5;
					    u_xlat15 = fract(u_xlat15);
					    u_xlat16_2.xy = u_xlat10_5.xy * vec2(u_xlat15) + u_xlat16_2.xy;
					    u_xlat5 = (-u_xlat15) + 0.5;
					    u_xlat5 = u_xlat5 + u_xlat5;
					    u_xlat10_10 = texture2D(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_10) + u_xlat10_0.x;
					    u_xlat16_2.x = abs(u_xlat5) * u_xlat16_2.x + u_xlat10_10;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					    u_xlat16_7.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_12.x = u_xlat16_7.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_12.x + u_xlat16_12.x;
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					    u_xlatb1 = u_xlat16_2.x>=0.5;
					    u_xlat16_3.x = (u_xlatb1) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_3.xxx;
					    u_xlatb1 = 0.5>=u_xlat16_2.x;
					    u_xlat16_2.x = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlat16_3.x = (u_xlatb1) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_8.xyz = u_xlat16_8.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_8.xyz = exp2(u_xlat16_8.xyz);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_8.xyz);
					    u_xlat16_8.xyz = u_xlat16_2.xxx * u_xlat16_4.xyz + u_xlat16_8.xyz;
					    SV_Target0.xyz = u_xlat16_8.xyz * u_xlat16_3.xxx + u_xlat16_7.xyz;
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
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _FlowTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					float u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec2 u_xlat1;
					bool u_xlatb1;
					mediump vec2 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					float u_xlat5;
					lowp vec2 u_xlat10_5;
					mediump vec3 u_xlat16_7;
					mediump vec3 u_xlat16_8;
					lowp float u_xlat10_10;
					mediump vec2 u_xlat16_12;
					float u_xlat15;
					void main()
					{
					    u_xlat0 = _Time.x * -0.5;
					    u_xlat0 = fract(u_xlat0);
					    u_xlat5 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat5 * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat10_5.xy = texture2D(_FlowTex, u_xlat1.xy).xy;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_12.xy = u_xlat10_5.xy * vec2(u_xlat0) + u_xlat16_2.xy;
					    u_xlat10_0.x = texture2D(_FlowTex, u_xlat16_12.xy).x;
					    u_xlat15 = _Time.x * -0.5 + 0.5;
					    u_xlat15 = fract(u_xlat15);
					    u_xlat16_2.xy = u_xlat10_5.xy * vec2(u_xlat15) + u_xlat16_2.xy;
					    u_xlat5 = (-u_xlat15) + 0.5;
					    u_xlat5 = u_xlat5 + u_xlat5;
					    u_xlat10_10 = texture2D(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_10) + u_xlat10_0.x;
					    u_xlat16_2.x = abs(u_xlat5) * u_xlat16_2.x + u_xlat10_10;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					    u_xlat16_7.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_12.x = u_xlat16_7.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_12.x + u_xlat16_12.x;
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					    u_xlatb1 = u_xlat16_2.x>=0.5;
					    u_xlat16_3.x = (u_xlatb1) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_3.xxx;
					    u_xlatb1 = 0.5>=u_xlat16_2.x;
					    u_xlat16_2.x = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlat16_3.x = (u_xlatb1) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_8.xyz = u_xlat16_8.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_8.xyz = exp2(u_xlat16_8.xyz);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_8.xyz);
					    u_xlat16_8.xyz = u_xlat16_2.xxx * u_xlat16_4.xyz + u_xlat16_8.xyz;
					    SV_Target0.xyz = u_xlat16_8.xyz * u_xlat16_3.xxx + u_xlat16_7.xyz;
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
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _FlowTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					float u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec2 u_xlat1;
					bool u_xlatb1;
					mediump vec2 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					float u_xlat5;
					lowp vec2 u_xlat10_5;
					mediump vec3 u_xlat16_7;
					mediump vec3 u_xlat16_8;
					lowp float u_xlat10_10;
					mediump vec2 u_xlat16_12;
					float u_xlat15;
					void main()
					{
					    u_xlat0 = _Time.x * -0.5;
					    u_xlat0 = fract(u_xlat0);
					    u_xlat5 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat5 * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat10_5.xy = texture2D(_FlowTex, u_xlat1.xy).xy;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_12.xy = u_xlat10_5.xy * vec2(u_xlat0) + u_xlat16_2.xy;
					    u_xlat10_0.x = texture2D(_FlowTex, u_xlat16_12.xy).x;
					    u_xlat15 = _Time.x * -0.5 + 0.5;
					    u_xlat15 = fract(u_xlat15);
					    u_xlat16_2.xy = u_xlat10_5.xy * vec2(u_xlat15) + u_xlat16_2.xy;
					    u_xlat5 = (-u_xlat15) + 0.5;
					    u_xlat5 = u_xlat5 + u_xlat5;
					    u_xlat10_10 = texture2D(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_10) + u_xlat10_0.x;
					    u_xlat16_2.x = abs(u_xlat5) * u_xlat16_2.x + u_xlat10_10;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					    u_xlat16_7.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_12.x = u_xlat16_7.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_12.x + u_xlat16_12.x;
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					    u_xlatb1 = u_xlat16_2.x>=0.5;
					    u_xlat16_3.x = (u_xlatb1) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_3.xxx;
					    u_xlatb1 = 0.5>=u_xlat16_2.x;
					    u_xlat16_2.x = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlat16_3.x = (u_xlatb1) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_8.xyz = u_xlat16_8.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_8.xyz = exp2(u_xlat16_8.xyz);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_8.xyz);
					    u_xlat16_8.xyz = u_xlat16_2.xxx * u_xlat16_4.xyz + u_xlat16_8.xyz;
					    SV_Target0.xyz = u_xlat16_8.xyz * u_xlat16_3.xxx + u_xlat16_7.xyz;
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
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _FlowTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					float u_xlat0;
					mediump vec4 u_xlat16_0;
					mediump float u_xlat10_0;
					vec2 u_xlat1;
					bool u_xlatb1;
					mediump vec2 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					float u_xlat5;
					mediump vec2 u_xlat10_5;
					mediump vec3 u_xlat16_7;
					mediump vec3 u_xlat16_8;
					mediump float u_xlat10_10;
					mediump vec2 u_xlat16_12;
					float u_xlat15;
					void main()
					{
					    u_xlat0 = _Time.x * -0.5;
					    u_xlat0 = fract(u_xlat0);
					    u_xlat5 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat5 * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat10_5.xy = texture(_FlowTex, u_xlat1.xy).xy;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_12.xy = u_xlat10_5.xy * vec2(u_xlat0) + u_xlat16_2.xy;
					    u_xlat10_0 = texture(_FlowTex, u_xlat16_12.xy).x;
					    u_xlat15 = _Time.x * -0.5 + 0.5;
					    u_xlat15 = fract(u_xlat15);
					    u_xlat16_2.xy = u_xlat10_5.xy * vec2(u_xlat15) + u_xlat16_2.xy;
					    u_xlat5 = (-u_xlat15) + 0.5;
					    u_xlat5 = u_xlat5 + u_xlat5;
					    u_xlat10_10 = texture(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_10) + u_xlat10_0;
					    u_xlat16_2.x = abs(u_xlat5) * u_xlat16_2.x + u_xlat10_10;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.x = min(max(u_xlat16_2.x, 0.0), 1.0);
					#else
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					#endif
					    u_xlat16_7.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_12.x = u_xlat16_7.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_12.x + u_xlat16_12.x;
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat16_2.x>=0.5);
					#else
					    u_xlatb1 = u_xlat16_2.x>=0.5;
					#endif
					    u_xlat16_3.x = (u_xlatb1) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_3.xxx;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(0.5>=u_xlat16_2.x);
					#else
					    u_xlatb1 = 0.5>=u_xlat16_2.x;
					#endif
					    u_xlat16_2.x = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlat16_3.x = (u_xlatb1) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_8.xyz = u_xlat16_8.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_8.xyz = exp2(u_xlat16_8.xyz);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_8.xyz);
					    u_xlat16_8.xyz = u_xlat16_2.xxx * u_xlat16_4.xyz + u_xlat16_8.xyz;
					    SV_Target0.xyz = u_xlat16_8.xyz * u_xlat16_3.xxx + u_xlat16_7.xyz;
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
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _FlowTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					float u_xlat0;
					mediump vec4 u_xlat16_0;
					mediump float u_xlat10_0;
					vec2 u_xlat1;
					bool u_xlatb1;
					mediump vec2 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					float u_xlat5;
					mediump vec2 u_xlat10_5;
					mediump vec3 u_xlat16_7;
					mediump vec3 u_xlat16_8;
					mediump float u_xlat10_10;
					mediump vec2 u_xlat16_12;
					float u_xlat15;
					void main()
					{
					    u_xlat0 = _Time.x * -0.5;
					    u_xlat0 = fract(u_xlat0);
					    u_xlat5 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat5 * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat10_5.xy = texture(_FlowTex, u_xlat1.xy).xy;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_12.xy = u_xlat10_5.xy * vec2(u_xlat0) + u_xlat16_2.xy;
					    u_xlat10_0 = texture(_FlowTex, u_xlat16_12.xy).x;
					    u_xlat15 = _Time.x * -0.5 + 0.5;
					    u_xlat15 = fract(u_xlat15);
					    u_xlat16_2.xy = u_xlat10_5.xy * vec2(u_xlat15) + u_xlat16_2.xy;
					    u_xlat5 = (-u_xlat15) + 0.5;
					    u_xlat5 = u_xlat5 + u_xlat5;
					    u_xlat10_10 = texture(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_10) + u_xlat10_0;
					    u_xlat16_2.x = abs(u_xlat5) * u_xlat16_2.x + u_xlat10_10;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.x = min(max(u_xlat16_2.x, 0.0), 1.0);
					#else
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					#endif
					    u_xlat16_7.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_12.x = u_xlat16_7.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_12.x + u_xlat16_12.x;
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat16_2.x>=0.5);
					#else
					    u_xlatb1 = u_xlat16_2.x>=0.5;
					#endif
					    u_xlat16_3.x = (u_xlatb1) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_3.xxx;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(0.5>=u_xlat16_2.x);
					#else
					    u_xlatb1 = 0.5>=u_xlat16_2.x;
					#endif
					    u_xlat16_2.x = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlat16_3.x = (u_xlatb1) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_8.xyz = u_xlat16_8.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_8.xyz = exp2(u_xlat16_8.xyz);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_8.xyz);
					    u_xlat16_8.xyz = u_xlat16_2.xxx * u_xlat16_4.xyz + u_xlat16_8.xyz;
					    SV_Target0.xyz = u_xlat16_8.xyz * u_xlat16_3.xxx + u_xlat16_7.xyz;
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
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _FlowTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					float u_xlat0;
					mediump vec4 u_xlat16_0;
					mediump float u_xlat10_0;
					vec2 u_xlat1;
					bool u_xlatb1;
					mediump vec2 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					float u_xlat5;
					mediump vec2 u_xlat10_5;
					mediump vec3 u_xlat16_7;
					mediump vec3 u_xlat16_8;
					mediump float u_xlat10_10;
					mediump vec2 u_xlat16_12;
					float u_xlat15;
					void main()
					{
					    u_xlat0 = _Time.x * -0.5;
					    u_xlat0 = fract(u_xlat0);
					    u_xlat5 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat5 * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat10_5.xy = texture(_FlowTex, u_xlat1.xy).xy;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_12.xy = u_xlat10_5.xy * vec2(u_xlat0) + u_xlat16_2.xy;
					    u_xlat10_0 = texture(_FlowTex, u_xlat16_12.xy).x;
					    u_xlat15 = _Time.x * -0.5 + 0.5;
					    u_xlat15 = fract(u_xlat15);
					    u_xlat16_2.xy = u_xlat10_5.xy * vec2(u_xlat15) + u_xlat16_2.xy;
					    u_xlat5 = (-u_xlat15) + 0.5;
					    u_xlat5 = u_xlat5 + u_xlat5;
					    u_xlat10_10 = texture(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_10) + u_xlat10_0;
					    u_xlat16_2.x = abs(u_xlat5) * u_xlat16_2.x + u_xlat10_10;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.x = min(max(u_xlat16_2.x, 0.0), 1.0);
					#else
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					#endif
					    u_xlat16_7.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_12.x = u_xlat16_7.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_12.x + u_xlat16_12.x;
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat16_2.x>=0.5);
					#else
					    u_xlatb1 = u_xlat16_2.x>=0.5;
					#endif
					    u_xlat16_3.x = (u_xlatb1) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_3.xxx;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(0.5>=u_xlat16_2.x);
					#else
					    u_xlatb1 = 0.5>=u_xlat16_2.x;
					#endif
					    u_xlat16_2.x = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlat16_3.x = (u_xlatb1) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_8.xyz = u_xlat16_8.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_8.xyz = exp2(u_xlat16_8.xyz);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_8.xyz);
					    u_xlat16_8.xyz = u_xlat16_2.xxx * u_xlat16_4.xyz + u_xlat16_8.xyz;
					    SV_Target0.xyz = u_xlat16_8.xyz * u_xlat16_3.xxx + u_xlat16_7.xyz;
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
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _FlowTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					mediump vec2 u_xlat16_1;
					float u_xlat2;
					lowp float u_xlat10_2;
					bool u_xlatb2;
					vec2 u_xlat3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					mediump vec3 u_xlat16_7;
					float u_xlat8;
					lowp vec2 u_xlat10_8;
					mediump vec3 u_xlat16_10;
					mediump vec2 u_xlat16_13;
					lowp float u_xlat10_14;
					float u_xlat20;
					void main()
					{
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_1.x = u_xlat16_0.w * vs_COLOR0.w + -0.00100000005;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlatb2 = u_xlat16_1.x<0.0;
					    if(((int(u_xlatb2) * -1))!=0){discard;}
					    u_xlat2 = _Time.x * -0.5;
					    u_xlat2 = fract(u_xlat2);
					    u_xlat8 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat8 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat10_8.xy = texture2D(_FlowTex, u_xlat3.xy).xy;
					    u_xlat16_1.xy = u_xlat3.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_13.xy = u_xlat10_8.xy * vec2(u_xlat2) + u_xlat16_1.xy;
					    u_xlat10_2 = texture2D(_FlowTex, u_xlat16_13.xy).x;
					    u_xlat20 = _Time.x * -0.5 + 0.5;
					    u_xlat20 = fract(u_xlat20);
					    u_xlat16_1.xy = u_xlat10_8.xy * vec2(u_xlat20) + u_xlat16_1.xy;
					    u_xlat8 = (-u_xlat20) + 0.5;
					    u_xlat8 = u_xlat8 + u_xlat8;
					    u_xlat10_14 = texture2D(_FlowTex, u_xlat16_1.xy).x;
					    u_xlat16_1.x = (-u_xlat10_14) + u_xlat10_2;
					    u_xlat16_1.x = abs(u_xlat8) * u_xlat16_1.x + u_xlat10_14;
					    u_xlat16_1.x = u_xlat16_1.x + -0.419999987;
					    u_xlat16_1.x = u_xlat16_1.x * 3.8461535;
					    u_xlat16_1.x = clamp(u_xlat16_1.x, 0.0, 1.0);
					    u_xlat16_7.x = u_xlat16_1.x * -2.0 + 3.0;
					    u_xlat16_1.x = u_xlat16_1.x * u_xlat16_1.x;
					    u_xlat16_13.x = u_xlat16_7.x * u_xlat16_1.x + -0.5;
					    u_xlat16_1.x = u_xlat16_1.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_13.x + u_xlat16_13.x;
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_5.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_5.xyz + u_xlat16_4.xyz;
					    u_xlatb2 = u_xlat16_1.x>=0.5;
					    u_xlat16_4.x = (u_xlatb2) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_4.xxx;
					    u_xlat16_4.x = u_xlat16_1.x + u_xlat16_1.x;
					    u_xlatb2 = 0.5>=u_xlat16_1.x;
					    u_xlat16_1.x = (u_xlatb2) ? 1.0 : 0.0;
					    u_xlat16_10.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_10.xyz = u_xlat16_10.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_10.xyz = exp2(u_xlat16_10.xyz);
					    u_xlat16_5.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_10.xyz);
					    u_xlat16_4.xyz = u_xlat16_4.xxx * u_xlat16_5.xyz + u_xlat16_10.xyz;
					    SV_Target0.xyz = u_xlat16_4.xyz * u_xlat16_1.xxx + u_xlat16_7.xyz;
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
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _FlowTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					mediump vec2 u_xlat16_1;
					float u_xlat2;
					lowp float u_xlat10_2;
					bool u_xlatb2;
					vec2 u_xlat3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					mediump vec3 u_xlat16_7;
					float u_xlat8;
					lowp vec2 u_xlat10_8;
					mediump vec3 u_xlat16_10;
					mediump vec2 u_xlat16_13;
					lowp float u_xlat10_14;
					float u_xlat20;
					void main()
					{
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_1.x = u_xlat16_0.w * vs_COLOR0.w + -0.00100000005;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlatb2 = u_xlat16_1.x<0.0;
					    if(((int(u_xlatb2) * -1))!=0){discard;}
					    u_xlat2 = _Time.x * -0.5;
					    u_xlat2 = fract(u_xlat2);
					    u_xlat8 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat8 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat10_8.xy = texture2D(_FlowTex, u_xlat3.xy).xy;
					    u_xlat16_1.xy = u_xlat3.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_13.xy = u_xlat10_8.xy * vec2(u_xlat2) + u_xlat16_1.xy;
					    u_xlat10_2 = texture2D(_FlowTex, u_xlat16_13.xy).x;
					    u_xlat20 = _Time.x * -0.5 + 0.5;
					    u_xlat20 = fract(u_xlat20);
					    u_xlat16_1.xy = u_xlat10_8.xy * vec2(u_xlat20) + u_xlat16_1.xy;
					    u_xlat8 = (-u_xlat20) + 0.5;
					    u_xlat8 = u_xlat8 + u_xlat8;
					    u_xlat10_14 = texture2D(_FlowTex, u_xlat16_1.xy).x;
					    u_xlat16_1.x = (-u_xlat10_14) + u_xlat10_2;
					    u_xlat16_1.x = abs(u_xlat8) * u_xlat16_1.x + u_xlat10_14;
					    u_xlat16_1.x = u_xlat16_1.x + -0.419999987;
					    u_xlat16_1.x = u_xlat16_1.x * 3.8461535;
					    u_xlat16_1.x = clamp(u_xlat16_1.x, 0.0, 1.0);
					    u_xlat16_7.x = u_xlat16_1.x * -2.0 + 3.0;
					    u_xlat16_1.x = u_xlat16_1.x * u_xlat16_1.x;
					    u_xlat16_13.x = u_xlat16_7.x * u_xlat16_1.x + -0.5;
					    u_xlat16_1.x = u_xlat16_1.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_13.x + u_xlat16_13.x;
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_5.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_5.xyz + u_xlat16_4.xyz;
					    u_xlatb2 = u_xlat16_1.x>=0.5;
					    u_xlat16_4.x = (u_xlatb2) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_4.xxx;
					    u_xlat16_4.x = u_xlat16_1.x + u_xlat16_1.x;
					    u_xlatb2 = 0.5>=u_xlat16_1.x;
					    u_xlat16_1.x = (u_xlatb2) ? 1.0 : 0.0;
					    u_xlat16_10.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_10.xyz = u_xlat16_10.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_10.xyz = exp2(u_xlat16_10.xyz);
					    u_xlat16_5.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_10.xyz);
					    u_xlat16_4.xyz = u_xlat16_4.xxx * u_xlat16_5.xyz + u_xlat16_10.xyz;
					    SV_Target0.xyz = u_xlat16_4.xyz * u_xlat16_1.xxx + u_xlat16_7.xyz;
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
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _FlowTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					mediump vec2 u_xlat16_1;
					float u_xlat2;
					lowp float u_xlat10_2;
					bool u_xlatb2;
					vec2 u_xlat3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					mediump vec3 u_xlat16_7;
					float u_xlat8;
					lowp vec2 u_xlat10_8;
					mediump vec3 u_xlat16_10;
					mediump vec2 u_xlat16_13;
					lowp float u_xlat10_14;
					float u_xlat20;
					void main()
					{
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_1.x = u_xlat16_0.w * vs_COLOR0.w + -0.00100000005;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlatb2 = u_xlat16_1.x<0.0;
					    if(((int(u_xlatb2) * -1))!=0){discard;}
					    u_xlat2 = _Time.x * -0.5;
					    u_xlat2 = fract(u_xlat2);
					    u_xlat8 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat8 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat10_8.xy = texture2D(_FlowTex, u_xlat3.xy).xy;
					    u_xlat16_1.xy = u_xlat3.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_13.xy = u_xlat10_8.xy * vec2(u_xlat2) + u_xlat16_1.xy;
					    u_xlat10_2 = texture2D(_FlowTex, u_xlat16_13.xy).x;
					    u_xlat20 = _Time.x * -0.5 + 0.5;
					    u_xlat20 = fract(u_xlat20);
					    u_xlat16_1.xy = u_xlat10_8.xy * vec2(u_xlat20) + u_xlat16_1.xy;
					    u_xlat8 = (-u_xlat20) + 0.5;
					    u_xlat8 = u_xlat8 + u_xlat8;
					    u_xlat10_14 = texture2D(_FlowTex, u_xlat16_1.xy).x;
					    u_xlat16_1.x = (-u_xlat10_14) + u_xlat10_2;
					    u_xlat16_1.x = abs(u_xlat8) * u_xlat16_1.x + u_xlat10_14;
					    u_xlat16_1.x = u_xlat16_1.x + -0.419999987;
					    u_xlat16_1.x = u_xlat16_1.x * 3.8461535;
					    u_xlat16_1.x = clamp(u_xlat16_1.x, 0.0, 1.0);
					    u_xlat16_7.x = u_xlat16_1.x * -2.0 + 3.0;
					    u_xlat16_1.x = u_xlat16_1.x * u_xlat16_1.x;
					    u_xlat16_13.x = u_xlat16_7.x * u_xlat16_1.x + -0.5;
					    u_xlat16_1.x = u_xlat16_1.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_13.x + u_xlat16_13.x;
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_5.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_5.xyz + u_xlat16_4.xyz;
					    u_xlatb2 = u_xlat16_1.x>=0.5;
					    u_xlat16_4.x = (u_xlatb2) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_4.xxx;
					    u_xlat16_4.x = u_xlat16_1.x + u_xlat16_1.x;
					    u_xlatb2 = 0.5>=u_xlat16_1.x;
					    u_xlat16_1.x = (u_xlatb2) ? 1.0 : 0.0;
					    u_xlat16_10.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_10.xyz = u_xlat16_10.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_10.xyz = exp2(u_xlat16_10.xyz);
					    u_xlat16_5.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_10.xyz);
					    u_xlat16_4.xyz = u_xlat16_4.xxx * u_xlat16_5.xyz + u_xlat16_10.xyz;
					    SV_Target0.xyz = u_xlat16_4.xyz * u_xlat16_1.xxx + u_xlat16_7.xyz;
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
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _FlowTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					mediump vec2 u_xlat16_1;
					float u_xlat2;
					mediump float u_xlat10_2;
					bool u_xlatb2;
					vec2 u_xlat3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					mediump vec3 u_xlat16_7;
					float u_xlat8;
					mediump vec2 u_xlat10_8;
					mediump vec3 u_xlat16_10;
					mediump vec2 u_xlat16_13;
					mediump float u_xlat10_14;
					float u_xlat20;
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
					    u_xlat2 = _Time.x * -0.5;
					    u_xlat2 = fract(u_xlat2);
					    u_xlat8 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat8 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat10_8.xy = texture(_FlowTex, u_xlat3.xy).xy;
					    u_xlat16_1.xy = u_xlat3.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_13.xy = u_xlat10_8.xy * vec2(u_xlat2) + u_xlat16_1.xy;
					    u_xlat10_2 = texture(_FlowTex, u_xlat16_13.xy).x;
					    u_xlat20 = _Time.x * -0.5 + 0.5;
					    u_xlat20 = fract(u_xlat20);
					    u_xlat16_1.xy = u_xlat10_8.xy * vec2(u_xlat20) + u_xlat16_1.xy;
					    u_xlat8 = (-u_xlat20) + 0.5;
					    u_xlat8 = u_xlat8 + u_xlat8;
					    u_xlat10_14 = texture(_FlowTex, u_xlat16_1.xy).x;
					    u_xlat16_1.x = (-u_xlat10_14) + u_xlat10_2;
					    u_xlat16_1.x = abs(u_xlat8) * u_xlat16_1.x + u_xlat10_14;
					    u_xlat16_1.x = u_xlat16_1.x + -0.419999987;
					    u_xlat16_1.x = u_xlat16_1.x * 3.8461535;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_1.x = min(max(u_xlat16_1.x, 0.0), 1.0);
					#else
					    u_xlat16_1.x = clamp(u_xlat16_1.x, 0.0, 1.0);
					#endif
					    u_xlat16_7.x = u_xlat16_1.x * -2.0 + 3.0;
					    u_xlat16_1.x = u_xlat16_1.x * u_xlat16_1.x;
					    u_xlat16_13.x = u_xlat16_7.x * u_xlat16_1.x + -0.5;
					    u_xlat16_1.x = u_xlat16_1.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_13.x + u_xlat16_13.x;
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_5.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_5.xyz + u_xlat16_4.xyz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb2 = !!(u_xlat16_1.x>=0.5);
					#else
					    u_xlatb2 = u_xlat16_1.x>=0.5;
					#endif
					    u_xlat16_4.x = (u_xlatb2) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_4.xxx;
					    u_xlat16_4.x = u_xlat16_1.x + u_xlat16_1.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb2 = !!(0.5>=u_xlat16_1.x);
					#else
					    u_xlatb2 = 0.5>=u_xlat16_1.x;
					#endif
					    u_xlat16_1.x = (u_xlatb2) ? 1.0 : 0.0;
					    u_xlat16_10.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_10.xyz = u_xlat16_10.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_10.xyz = exp2(u_xlat16_10.xyz);
					    u_xlat16_5.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_10.xyz);
					    u_xlat16_4.xyz = u_xlat16_4.xxx * u_xlat16_5.xyz + u_xlat16_10.xyz;
					    SV_Target0.xyz = u_xlat16_4.xyz * u_xlat16_1.xxx + u_xlat16_7.xyz;
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
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _FlowTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					mediump vec2 u_xlat16_1;
					float u_xlat2;
					mediump float u_xlat10_2;
					bool u_xlatb2;
					vec2 u_xlat3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					mediump vec3 u_xlat16_7;
					float u_xlat8;
					mediump vec2 u_xlat10_8;
					mediump vec3 u_xlat16_10;
					mediump vec2 u_xlat16_13;
					mediump float u_xlat10_14;
					float u_xlat20;
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
					    u_xlat2 = _Time.x * -0.5;
					    u_xlat2 = fract(u_xlat2);
					    u_xlat8 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat8 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat10_8.xy = texture(_FlowTex, u_xlat3.xy).xy;
					    u_xlat16_1.xy = u_xlat3.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_13.xy = u_xlat10_8.xy * vec2(u_xlat2) + u_xlat16_1.xy;
					    u_xlat10_2 = texture(_FlowTex, u_xlat16_13.xy).x;
					    u_xlat20 = _Time.x * -0.5 + 0.5;
					    u_xlat20 = fract(u_xlat20);
					    u_xlat16_1.xy = u_xlat10_8.xy * vec2(u_xlat20) + u_xlat16_1.xy;
					    u_xlat8 = (-u_xlat20) + 0.5;
					    u_xlat8 = u_xlat8 + u_xlat8;
					    u_xlat10_14 = texture(_FlowTex, u_xlat16_1.xy).x;
					    u_xlat16_1.x = (-u_xlat10_14) + u_xlat10_2;
					    u_xlat16_1.x = abs(u_xlat8) * u_xlat16_1.x + u_xlat10_14;
					    u_xlat16_1.x = u_xlat16_1.x + -0.419999987;
					    u_xlat16_1.x = u_xlat16_1.x * 3.8461535;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_1.x = min(max(u_xlat16_1.x, 0.0), 1.0);
					#else
					    u_xlat16_1.x = clamp(u_xlat16_1.x, 0.0, 1.0);
					#endif
					    u_xlat16_7.x = u_xlat16_1.x * -2.0 + 3.0;
					    u_xlat16_1.x = u_xlat16_1.x * u_xlat16_1.x;
					    u_xlat16_13.x = u_xlat16_7.x * u_xlat16_1.x + -0.5;
					    u_xlat16_1.x = u_xlat16_1.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_13.x + u_xlat16_13.x;
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_5.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_5.xyz + u_xlat16_4.xyz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb2 = !!(u_xlat16_1.x>=0.5);
					#else
					    u_xlatb2 = u_xlat16_1.x>=0.5;
					#endif
					    u_xlat16_4.x = (u_xlatb2) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_4.xxx;
					    u_xlat16_4.x = u_xlat16_1.x + u_xlat16_1.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb2 = !!(0.5>=u_xlat16_1.x);
					#else
					    u_xlatb2 = 0.5>=u_xlat16_1.x;
					#endif
					    u_xlat16_1.x = (u_xlatb2) ? 1.0 : 0.0;
					    u_xlat16_10.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_10.xyz = u_xlat16_10.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_10.xyz = exp2(u_xlat16_10.xyz);
					    u_xlat16_5.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_10.xyz);
					    u_xlat16_4.xyz = u_xlat16_4.xxx * u_xlat16_5.xyz + u_xlat16_10.xyz;
					    SV_Target0.xyz = u_xlat16_4.xyz * u_xlat16_1.xxx + u_xlat16_7.xyz;
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
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _FlowTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					mediump vec2 u_xlat16_1;
					float u_xlat2;
					mediump float u_xlat10_2;
					bool u_xlatb2;
					vec2 u_xlat3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					mediump vec3 u_xlat16_7;
					float u_xlat8;
					mediump vec2 u_xlat10_8;
					mediump vec3 u_xlat16_10;
					mediump vec2 u_xlat16_13;
					mediump float u_xlat10_14;
					float u_xlat20;
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
					    u_xlat2 = _Time.x * -0.5;
					    u_xlat2 = fract(u_xlat2);
					    u_xlat8 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat8 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat10_8.xy = texture(_FlowTex, u_xlat3.xy).xy;
					    u_xlat16_1.xy = u_xlat3.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_13.xy = u_xlat10_8.xy * vec2(u_xlat2) + u_xlat16_1.xy;
					    u_xlat10_2 = texture(_FlowTex, u_xlat16_13.xy).x;
					    u_xlat20 = _Time.x * -0.5 + 0.5;
					    u_xlat20 = fract(u_xlat20);
					    u_xlat16_1.xy = u_xlat10_8.xy * vec2(u_xlat20) + u_xlat16_1.xy;
					    u_xlat8 = (-u_xlat20) + 0.5;
					    u_xlat8 = u_xlat8 + u_xlat8;
					    u_xlat10_14 = texture(_FlowTex, u_xlat16_1.xy).x;
					    u_xlat16_1.x = (-u_xlat10_14) + u_xlat10_2;
					    u_xlat16_1.x = abs(u_xlat8) * u_xlat16_1.x + u_xlat10_14;
					    u_xlat16_1.x = u_xlat16_1.x + -0.419999987;
					    u_xlat16_1.x = u_xlat16_1.x * 3.8461535;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_1.x = min(max(u_xlat16_1.x, 0.0), 1.0);
					#else
					    u_xlat16_1.x = clamp(u_xlat16_1.x, 0.0, 1.0);
					#endif
					    u_xlat16_7.x = u_xlat16_1.x * -2.0 + 3.0;
					    u_xlat16_1.x = u_xlat16_1.x * u_xlat16_1.x;
					    u_xlat16_13.x = u_xlat16_7.x * u_xlat16_1.x + -0.5;
					    u_xlat16_1.x = u_xlat16_1.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_13.x + u_xlat16_13.x;
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_5.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_5.xyz + u_xlat16_4.xyz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb2 = !!(u_xlat16_1.x>=0.5);
					#else
					    u_xlatb2 = u_xlat16_1.x>=0.5;
					#endif
					    u_xlat16_4.x = (u_xlatb2) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_4.xxx;
					    u_xlat16_4.x = u_xlat16_1.x + u_xlat16_1.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb2 = !!(0.5>=u_xlat16_1.x);
					#else
					    u_xlatb2 = 0.5>=u_xlat16_1.x;
					#endif
					    u_xlat16_1.x = (u_xlatb2) ? 1.0 : 0.0;
					    u_xlat16_10.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_10.xyz = u_xlat16_10.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_10.xyz = exp2(u_xlat16_10.xyz);
					    u_xlat16_5.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_10.xyz);
					    u_xlat16_4.xyz = u_xlat16_4.xxx * u_xlat16_5.xyz + u_xlat16_10.xyz;
					    SV_Target0.xyz = u_xlat16_4.xyz * u_xlat16_1.xxx + u_xlat16_7.xyz;
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
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _FlowTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					bvec2 u_xlatb1;
					mediump vec2 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					float u_xlat5;
					lowp vec2 u_xlat10_5;
					mediump vec3 u_xlat16_7;
					mediump vec3 u_xlat16_8;
					lowp float u_xlat10_10;
					mediump vec2 u_xlat16_12;
					float u_xlat15;
					void main()
					{
					    u_xlat0.x = _Time.x * -0.5;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat5 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat5 * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat10_5.xy = texture2D(_FlowTex, u_xlat1.xy).xy;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_12.xy = u_xlat10_5.xy * u_xlat0.xx + u_xlat16_2.xy;
					    u_xlat10_0.x = texture2D(_FlowTex, u_xlat16_12.xy).x;
					    u_xlat15 = _Time.x * -0.5 + 0.5;
					    u_xlat15 = fract(u_xlat15);
					    u_xlat16_2.xy = u_xlat10_5.xy * vec2(u_xlat15) + u_xlat16_2.xy;
					    u_xlat5 = (-u_xlat15) + 0.5;
					    u_xlat5 = u_xlat5 + u_xlat5;
					    u_xlat10_10 = texture2D(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_10) + u_xlat10_0.x;
					    u_xlat16_2.x = abs(u_xlat5) * u_xlat16_2.x + u_xlat10_10;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					    u_xlat16_7.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_12.x = u_xlat16_7.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_12.x + u_xlat16_12.x;
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					    u_xlatb1.x = u_xlat16_2.x>=0.5;
					    u_xlat16_3.x = (u_xlatb1.x) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_3.xxx;
					    u_xlatb1.x = 0.5>=u_xlat16_2.x;
					    u_xlat16_2.x = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlat16_3.x = (u_xlatb1.x) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_8.xyz = u_xlat16_8.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_8.xyz = exp2(u_xlat16_8.xyz);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_8.xyz);
					    u_xlat16_8.xyz = u_xlat16_2.xxx * u_xlat16_4.xyz + u_xlat16_8.xyz;
					    SV_Target0.xyz = u_xlat16_8.xyz * u_xlat16_3.xxx + u_xlat16_7.xyz;
					    u_xlatb0.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlatb1.xy = greaterThanEqual(_ClipRect.zwzz, vs_TEXCOORD1.xyxx).xy;
					    u_xlat1.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb1.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat1.xy;
					    u_xlat0.x = u_xlat0.y * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat16_0.w;
					    SV_Target0.w = u_xlat0.x;
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
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _FlowTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					bvec2 u_xlatb1;
					mediump vec2 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					float u_xlat5;
					lowp vec2 u_xlat10_5;
					mediump vec3 u_xlat16_7;
					mediump vec3 u_xlat16_8;
					lowp float u_xlat10_10;
					mediump vec2 u_xlat16_12;
					float u_xlat15;
					void main()
					{
					    u_xlat0.x = _Time.x * -0.5;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat5 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat5 * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat10_5.xy = texture2D(_FlowTex, u_xlat1.xy).xy;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_12.xy = u_xlat10_5.xy * u_xlat0.xx + u_xlat16_2.xy;
					    u_xlat10_0.x = texture2D(_FlowTex, u_xlat16_12.xy).x;
					    u_xlat15 = _Time.x * -0.5 + 0.5;
					    u_xlat15 = fract(u_xlat15);
					    u_xlat16_2.xy = u_xlat10_5.xy * vec2(u_xlat15) + u_xlat16_2.xy;
					    u_xlat5 = (-u_xlat15) + 0.5;
					    u_xlat5 = u_xlat5 + u_xlat5;
					    u_xlat10_10 = texture2D(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_10) + u_xlat10_0.x;
					    u_xlat16_2.x = abs(u_xlat5) * u_xlat16_2.x + u_xlat10_10;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					    u_xlat16_7.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_12.x = u_xlat16_7.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_12.x + u_xlat16_12.x;
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					    u_xlatb1.x = u_xlat16_2.x>=0.5;
					    u_xlat16_3.x = (u_xlatb1.x) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_3.xxx;
					    u_xlatb1.x = 0.5>=u_xlat16_2.x;
					    u_xlat16_2.x = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlat16_3.x = (u_xlatb1.x) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_8.xyz = u_xlat16_8.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_8.xyz = exp2(u_xlat16_8.xyz);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_8.xyz);
					    u_xlat16_8.xyz = u_xlat16_2.xxx * u_xlat16_4.xyz + u_xlat16_8.xyz;
					    SV_Target0.xyz = u_xlat16_8.xyz * u_xlat16_3.xxx + u_xlat16_7.xyz;
					    u_xlatb0.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlatb1.xy = greaterThanEqual(_ClipRect.zwzz, vs_TEXCOORD1.xyxx).xy;
					    u_xlat1.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb1.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat1.xy;
					    u_xlat0.x = u_xlat0.y * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat16_0.w;
					    SV_Target0.w = u_xlat0.x;
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
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _FlowTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					bvec2 u_xlatb1;
					mediump vec2 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					float u_xlat5;
					lowp vec2 u_xlat10_5;
					mediump vec3 u_xlat16_7;
					mediump vec3 u_xlat16_8;
					lowp float u_xlat10_10;
					mediump vec2 u_xlat16_12;
					float u_xlat15;
					void main()
					{
					    u_xlat0.x = _Time.x * -0.5;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat5 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat5 * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat10_5.xy = texture2D(_FlowTex, u_xlat1.xy).xy;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_12.xy = u_xlat10_5.xy * u_xlat0.xx + u_xlat16_2.xy;
					    u_xlat10_0.x = texture2D(_FlowTex, u_xlat16_12.xy).x;
					    u_xlat15 = _Time.x * -0.5 + 0.5;
					    u_xlat15 = fract(u_xlat15);
					    u_xlat16_2.xy = u_xlat10_5.xy * vec2(u_xlat15) + u_xlat16_2.xy;
					    u_xlat5 = (-u_xlat15) + 0.5;
					    u_xlat5 = u_xlat5 + u_xlat5;
					    u_xlat10_10 = texture2D(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_10) + u_xlat10_0.x;
					    u_xlat16_2.x = abs(u_xlat5) * u_xlat16_2.x + u_xlat10_10;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					    u_xlat16_7.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_12.x = u_xlat16_7.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_12.x + u_xlat16_12.x;
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					    u_xlatb1.x = u_xlat16_2.x>=0.5;
					    u_xlat16_3.x = (u_xlatb1.x) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_3.xxx;
					    u_xlatb1.x = 0.5>=u_xlat16_2.x;
					    u_xlat16_2.x = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlat16_3.x = (u_xlatb1.x) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_8.xyz = u_xlat16_8.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_8.xyz = exp2(u_xlat16_8.xyz);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_8.xyz);
					    u_xlat16_8.xyz = u_xlat16_2.xxx * u_xlat16_4.xyz + u_xlat16_8.xyz;
					    SV_Target0.xyz = u_xlat16_8.xyz * u_xlat16_3.xxx + u_xlat16_7.xyz;
					    u_xlatb0.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlatb1.xy = greaterThanEqual(_ClipRect.zwzz, vs_TEXCOORD1.xyxx).xy;
					    u_xlat1.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb1.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat1.xy;
					    u_xlat0.x = u_xlat0.y * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat16_0.w;
					    SV_Target0.w = u_xlat0.x;
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
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _FlowTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec4 u_xlat16_0;
					mediump float u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					bvec2 u_xlatb1;
					mediump vec2 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					float u_xlat5;
					mediump vec2 u_xlat10_5;
					mediump vec3 u_xlat16_7;
					mediump vec3 u_xlat16_8;
					mediump float u_xlat10_10;
					mediump vec2 u_xlat16_12;
					float u_xlat15;
					void main()
					{
					    u_xlat0.x = _Time.x * -0.5;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat5 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat5 * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat10_5.xy = texture(_FlowTex, u_xlat1.xy).xy;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_12.xy = u_xlat10_5.xy * u_xlat0.xx + u_xlat16_2.xy;
					    u_xlat10_0 = texture(_FlowTex, u_xlat16_12.xy).x;
					    u_xlat15 = _Time.x * -0.5 + 0.5;
					    u_xlat15 = fract(u_xlat15);
					    u_xlat16_2.xy = u_xlat10_5.xy * vec2(u_xlat15) + u_xlat16_2.xy;
					    u_xlat5 = (-u_xlat15) + 0.5;
					    u_xlat5 = u_xlat5 + u_xlat5;
					    u_xlat10_10 = texture(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_10) + u_xlat10_0;
					    u_xlat16_2.x = abs(u_xlat5) * u_xlat16_2.x + u_xlat10_10;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.x = min(max(u_xlat16_2.x, 0.0), 1.0);
					#else
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					#endif
					    u_xlat16_7.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_12.x = u_xlat16_7.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_12.x + u_xlat16_12.x;
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1.x = !!(u_xlat16_2.x>=0.5);
					#else
					    u_xlatb1.x = u_xlat16_2.x>=0.5;
					#endif
					    u_xlat16_3.x = (u_xlatb1.x) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_3.xxx;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1.x = !!(0.5>=u_xlat16_2.x);
					#else
					    u_xlatb1.x = 0.5>=u_xlat16_2.x;
					#endif
					    u_xlat16_2.x = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlat16_3.x = (u_xlatb1.x) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_8.xyz = u_xlat16_8.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_8.xyz = exp2(u_xlat16_8.xyz);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_8.xyz);
					    u_xlat16_8.xyz = u_xlat16_2.xxx * u_xlat16_4.xyz + u_xlat16_8.xyz;
					    SV_Target0.xyz = u_xlat16_8.xyz * u_xlat16_3.xxx + u_xlat16_7.xyz;
					    u_xlatb0.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlatb1.xy = greaterThanEqual(_ClipRect.zwzz, vs_TEXCOORD1.xyxx).xy;
					    u_xlat1.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb1.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat1.xy;
					    u_xlat0.x = u_xlat0.y * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat16_0.w;
					    SV_Target0.w = u_xlat0.x;
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
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _FlowTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec4 u_xlat16_0;
					mediump float u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					bvec2 u_xlatb1;
					mediump vec2 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					float u_xlat5;
					mediump vec2 u_xlat10_5;
					mediump vec3 u_xlat16_7;
					mediump vec3 u_xlat16_8;
					mediump float u_xlat10_10;
					mediump vec2 u_xlat16_12;
					float u_xlat15;
					void main()
					{
					    u_xlat0.x = _Time.x * -0.5;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat5 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat5 * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat10_5.xy = texture(_FlowTex, u_xlat1.xy).xy;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_12.xy = u_xlat10_5.xy * u_xlat0.xx + u_xlat16_2.xy;
					    u_xlat10_0 = texture(_FlowTex, u_xlat16_12.xy).x;
					    u_xlat15 = _Time.x * -0.5 + 0.5;
					    u_xlat15 = fract(u_xlat15);
					    u_xlat16_2.xy = u_xlat10_5.xy * vec2(u_xlat15) + u_xlat16_2.xy;
					    u_xlat5 = (-u_xlat15) + 0.5;
					    u_xlat5 = u_xlat5 + u_xlat5;
					    u_xlat10_10 = texture(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_10) + u_xlat10_0;
					    u_xlat16_2.x = abs(u_xlat5) * u_xlat16_2.x + u_xlat10_10;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.x = min(max(u_xlat16_2.x, 0.0), 1.0);
					#else
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					#endif
					    u_xlat16_7.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_12.x = u_xlat16_7.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_12.x + u_xlat16_12.x;
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1.x = !!(u_xlat16_2.x>=0.5);
					#else
					    u_xlatb1.x = u_xlat16_2.x>=0.5;
					#endif
					    u_xlat16_3.x = (u_xlatb1.x) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_3.xxx;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1.x = !!(0.5>=u_xlat16_2.x);
					#else
					    u_xlatb1.x = 0.5>=u_xlat16_2.x;
					#endif
					    u_xlat16_2.x = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlat16_3.x = (u_xlatb1.x) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_8.xyz = u_xlat16_8.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_8.xyz = exp2(u_xlat16_8.xyz);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_8.xyz);
					    u_xlat16_8.xyz = u_xlat16_2.xxx * u_xlat16_4.xyz + u_xlat16_8.xyz;
					    SV_Target0.xyz = u_xlat16_8.xyz * u_xlat16_3.xxx + u_xlat16_7.xyz;
					    u_xlatb0.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlatb1.xy = greaterThanEqual(_ClipRect.zwzz, vs_TEXCOORD1.xyxx).xy;
					    u_xlat1.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb1.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat1.xy;
					    u_xlat0.x = u_xlat0.y * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat16_0.w;
					    SV_Target0.w = u_xlat0.x;
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
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _FlowTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec4 u_xlat16_0;
					mediump float u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					bvec2 u_xlatb1;
					mediump vec2 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					float u_xlat5;
					mediump vec2 u_xlat10_5;
					mediump vec3 u_xlat16_7;
					mediump vec3 u_xlat16_8;
					mediump float u_xlat10_10;
					mediump vec2 u_xlat16_12;
					float u_xlat15;
					void main()
					{
					    u_xlat0.x = _Time.x * -0.5;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat5 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat1.x = u_xlat5 * vs_TEXCOORD2.x;
					    u_xlat1.y = vs_TEXCOORD2.y;
					    u_xlat10_5.xy = texture(_FlowTex, u_xlat1.xy).xy;
					    u_xlat16_2.xy = u_xlat1.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_12.xy = u_xlat10_5.xy * u_xlat0.xx + u_xlat16_2.xy;
					    u_xlat10_0 = texture(_FlowTex, u_xlat16_12.xy).x;
					    u_xlat15 = _Time.x * -0.5 + 0.5;
					    u_xlat15 = fract(u_xlat15);
					    u_xlat16_2.xy = u_xlat10_5.xy * vec2(u_xlat15) + u_xlat16_2.xy;
					    u_xlat5 = (-u_xlat15) + 0.5;
					    u_xlat5 = u_xlat5 + u_xlat5;
					    u_xlat10_10 = texture(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_10) + u_xlat10_0;
					    u_xlat16_2.x = abs(u_xlat5) * u_xlat16_2.x + u_xlat10_10;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.x = min(max(u_xlat16_2.x, 0.0), 1.0);
					#else
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					#endif
					    u_xlat16_7.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_12.x = u_xlat16_7.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_7.x;
					    u_xlat16_7.x = u_xlat16_12.x + u_xlat16_12.x;
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + _TextureSampleAdd;
					    u_xlat16_0 = u_xlat16_0 * vs_COLOR0;
					    u_xlat16_3.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_7.xyz = u_xlat16_7.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1.x = !!(u_xlat16_2.x>=0.5);
					#else
					    u_xlatb1.x = u_xlat16_2.x>=0.5;
					#endif
					    u_xlat16_3.x = (u_xlatb1.x) ? 1.0 : 0.0;
					    u_xlat16_7.xyz = u_xlat16_7.xyz * u_xlat16_3.xxx;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1.x = !!(0.5>=u_xlat16_2.x);
					#else
					    u_xlatb1.x = 0.5>=u_xlat16_2.x;
					#endif
					    u_xlat16_2.x = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlat16_3.x = (u_xlatb1.x) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = log2(u_xlat16_0.xyz);
					    u_xlat16_8.xyz = u_xlat16_8.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_8.xyz = exp2(u_xlat16_8.xyz);
					    u_xlat16_4.xyz = u_xlat16_0.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_8.xyz);
					    u_xlat16_8.xyz = u_xlat16_2.xxx * u_xlat16_4.xyz + u_xlat16_8.xyz;
					    SV_Target0.xyz = u_xlat16_8.xyz * u_xlat16_3.xxx + u_xlat16_7.xyz;
					    u_xlatb0.xy = greaterThanEqual(vs_TEXCOORD1.xyxx, _ClipRect.xyxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlatb1.xy = greaterThanEqual(_ClipRect.zwzz, vs_TEXCOORD1.xyxx).xy;
					    u_xlat1.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb1.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat1.xy;
					    u_xlat0.x = u_xlat0.y * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat16_0.w;
					    SV_Target0.w = u_xlat0.x;
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
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _FlowTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bvec4 u_xlatb0;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					mediump vec2 u_xlat16_2;
					vec2 u_xlat3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					float u_xlat6;
					lowp vec2 u_xlat10_6;
					mediump vec3 u_xlat16_8;
					lowp float u_xlat10_12;
					mediump vec2 u_xlat16_14;
					float u_xlat18;
					mediump float u_xlat16_22;
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
					    u_xlat0.x = _Time.x * -0.5;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat6 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat6 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat10_6.xy = texture2D(_FlowTex, u_xlat3.xy).xy;
					    u_xlat16_2.xy = u_xlat3.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_14.xy = u_xlat10_6.xy * u_xlat0.xx + u_xlat16_2.xy;
					    u_xlat10_0 = texture2D(_FlowTex, u_xlat16_14.xy).x;
					    u_xlat18 = _Time.x * -0.5 + 0.5;
					    u_xlat18 = fract(u_xlat18);
					    u_xlat16_2.xy = u_xlat10_6.xy * vec2(u_xlat18) + u_xlat16_2.xy;
					    u_xlat6 = (-u_xlat18) + 0.5;
					    u_xlat6 = u_xlat6 + u_xlat6;
					    u_xlat10_12 = texture2D(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_12) + u_xlat10_0;
					    u_xlat16_2.x = abs(u_xlat6) * u_xlat16_2.x + u_xlat10_12;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					    u_xlat16_8.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_14.x = u_xlat16_8.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_8.x;
					    u_xlat16_8.x = u_xlat16_14.x + u_xlat16_14.x;
					    u_xlat16_4.xyz = u_xlat16_1.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_5.xyz = u_xlat16_1.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_8.xyz = u_xlat16_8.xxx * u_xlat16_5.xyz + u_xlat16_4.xyz;
					    u_xlatb0.x = u_xlat16_2.x>=0.5;
					    u_xlat16_4.x = (u_xlatb0.x) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = u_xlat16_8.xyz * u_xlat16_4.xxx;
					    u_xlat16_4.xyz = log2(u_xlat16_1.xyz);
					    u_xlat16_4.xyz = u_xlat16_4.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = exp2(u_xlat16_4.xyz);
					    u_xlat16_5.xyz = u_xlat16_1.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_4.xyz);
					    u_xlat16_22 = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlatb0.x = 0.5>=u_xlat16_2.x;
					    u_xlat16_2.x = (u_xlatb0.x) ? 1.0 : 0.0;
					    u_xlat16_4.xyz = vec3(u_xlat16_22) * u_xlat16_5.xyz + u_xlat16_4.xyz;
					    SV_Target0.xyz = u_xlat16_4.xyz * u_xlat16_2.xxx + u_xlat16_8.xyz;
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
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _FlowTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bvec4 u_xlatb0;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					mediump vec2 u_xlat16_2;
					vec2 u_xlat3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					float u_xlat6;
					lowp vec2 u_xlat10_6;
					mediump vec3 u_xlat16_8;
					lowp float u_xlat10_12;
					mediump vec2 u_xlat16_14;
					float u_xlat18;
					mediump float u_xlat16_22;
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
					    u_xlat0.x = _Time.x * -0.5;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat6 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat6 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat10_6.xy = texture2D(_FlowTex, u_xlat3.xy).xy;
					    u_xlat16_2.xy = u_xlat3.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_14.xy = u_xlat10_6.xy * u_xlat0.xx + u_xlat16_2.xy;
					    u_xlat10_0 = texture2D(_FlowTex, u_xlat16_14.xy).x;
					    u_xlat18 = _Time.x * -0.5 + 0.5;
					    u_xlat18 = fract(u_xlat18);
					    u_xlat16_2.xy = u_xlat10_6.xy * vec2(u_xlat18) + u_xlat16_2.xy;
					    u_xlat6 = (-u_xlat18) + 0.5;
					    u_xlat6 = u_xlat6 + u_xlat6;
					    u_xlat10_12 = texture2D(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_12) + u_xlat10_0;
					    u_xlat16_2.x = abs(u_xlat6) * u_xlat16_2.x + u_xlat10_12;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					    u_xlat16_8.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_14.x = u_xlat16_8.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_8.x;
					    u_xlat16_8.x = u_xlat16_14.x + u_xlat16_14.x;
					    u_xlat16_4.xyz = u_xlat16_1.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_5.xyz = u_xlat16_1.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_8.xyz = u_xlat16_8.xxx * u_xlat16_5.xyz + u_xlat16_4.xyz;
					    u_xlatb0.x = u_xlat16_2.x>=0.5;
					    u_xlat16_4.x = (u_xlatb0.x) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = u_xlat16_8.xyz * u_xlat16_4.xxx;
					    u_xlat16_4.xyz = log2(u_xlat16_1.xyz);
					    u_xlat16_4.xyz = u_xlat16_4.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = exp2(u_xlat16_4.xyz);
					    u_xlat16_5.xyz = u_xlat16_1.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_4.xyz);
					    u_xlat16_22 = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlatb0.x = 0.5>=u_xlat16_2.x;
					    u_xlat16_2.x = (u_xlatb0.x) ? 1.0 : 0.0;
					    u_xlat16_4.xyz = vec3(u_xlat16_22) * u_xlat16_5.xyz + u_xlat16_4.xyz;
					    SV_Target0.xyz = u_xlat16_4.xyz * u_xlat16_2.xxx + u_xlat16_8.xyz;
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
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _FlowTex;
					varying mediump vec4 vs_COLOR0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bvec4 u_xlatb0;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					mediump vec2 u_xlat16_2;
					vec2 u_xlat3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					float u_xlat6;
					lowp vec2 u_xlat10_6;
					mediump vec3 u_xlat16_8;
					lowp float u_xlat10_12;
					mediump vec2 u_xlat16_14;
					float u_xlat18;
					mediump float u_xlat16_22;
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
					    u_xlat0.x = _Time.x * -0.5;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat6 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat6 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat10_6.xy = texture2D(_FlowTex, u_xlat3.xy).xy;
					    u_xlat16_2.xy = u_xlat3.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_14.xy = u_xlat10_6.xy * u_xlat0.xx + u_xlat16_2.xy;
					    u_xlat10_0 = texture2D(_FlowTex, u_xlat16_14.xy).x;
					    u_xlat18 = _Time.x * -0.5 + 0.5;
					    u_xlat18 = fract(u_xlat18);
					    u_xlat16_2.xy = u_xlat10_6.xy * vec2(u_xlat18) + u_xlat16_2.xy;
					    u_xlat6 = (-u_xlat18) + 0.5;
					    u_xlat6 = u_xlat6 + u_xlat6;
					    u_xlat10_12 = texture2D(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_12) + u_xlat10_0;
					    u_xlat16_2.x = abs(u_xlat6) * u_xlat16_2.x + u_xlat10_12;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					    u_xlat16_8.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_14.x = u_xlat16_8.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_8.x;
					    u_xlat16_8.x = u_xlat16_14.x + u_xlat16_14.x;
					    u_xlat16_4.xyz = u_xlat16_1.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_5.xyz = u_xlat16_1.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_8.xyz = u_xlat16_8.xxx * u_xlat16_5.xyz + u_xlat16_4.xyz;
					    u_xlatb0.x = u_xlat16_2.x>=0.5;
					    u_xlat16_4.x = (u_xlatb0.x) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = u_xlat16_8.xyz * u_xlat16_4.xxx;
					    u_xlat16_4.xyz = log2(u_xlat16_1.xyz);
					    u_xlat16_4.xyz = u_xlat16_4.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = exp2(u_xlat16_4.xyz);
					    u_xlat16_5.xyz = u_xlat16_1.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_4.xyz);
					    u_xlat16_22 = u_xlat16_2.x + u_xlat16_2.x;
					    u_xlatb0.x = 0.5>=u_xlat16_2.x;
					    u_xlat16_2.x = (u_xlatb0.x) ? 1.0 : 0.0;
					    u_xlat16_4.xyz = vec3(u_xlat16_22) * u_xlat16_5.xyz + u_xlat16_4.xyz;
					    SV_Target0.xyz = u_xlat16_4.xyz * u_xlat16_2.xxx + u_xlat16_8.xyz;
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
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _FlowTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat10_0;
					bvec4 u_xlatb0;
					mediump vec4 u_xlat16_1;
					mediump vec2 u_xlat16_2;
					vec2 u_xlat3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					float u_xlat6;
					mediump vec2 u_xlat10_6;
					mediump vec3 u_xlat16_8;
					mediump float u_xlat10_12;
					mediump vec2 u_xlat16_14;
					float u_xlat18;
					mediump float u_xlat16_22;
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
					    u_xlat0.x = _Time.x * -0.5;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat6 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat6 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat10_6.xy = texture(_FlowTex, u_xlat3.xy).xy;
					    u_xlat16_2.xy = u_xlat3.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_14.xy = u_xlat10_6.xy * u_xlat0.xx + u_xlat16_2.xy;
					    u_xlat10_0 = texture(_FlowTex, u_xlat16_14.xy).x;
					    u_xlat18 = _Time.x * -0.5 + 0.5;
					    u_xlat18 = fract(u_xlat18);
					    u_xlat16_2.xy = u_xlat10_6.xy * vec2(u_xlat18) + u_xlat16_2.xy;
					    u_xlat6 = (-u_xlat18) + 0.5;
					    u_xlat6 = u_xlat6 + u_xlat6;
					    u_xlat10_12 = texture(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_12) + u_xlat10_0;
					    u_xlat16_2.x = abs(u_xlat6) * u_xlat16_2.x + u_xlat10_12;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.x = min(max(u_xlat16_2.x, 0.0), 1.0);
					#else
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					#endif
					    u_xlat16_8.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_14.x = u_xlat16_8.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_8.x;
					    u_xlat16_8.x = u_xlat16_14.x + u_xlat16_14.x;
					    u_xlat16_4.xyz = u_xlat16_1.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_5.xyz = u_xlat16_1.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_8.xyz = u_xlat16_8.xxx * u_xlat16_5.xyz + u_xlat16_4.xyz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(u_xlat16_2.x>=0.5);
					#else
					    u_xlatb0.x = u_xlat16_2.x>=0.5;
					#endif
					    u_xlat16_4.x = (u_xlatb0.x) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = u_xlat16_8.xyz * u_xlat16_4.xxx;
					    u_xlat16_4.xyz = log2(u_xlat16_1.xyz);
					    u_xlat16_4.xyz = u_xlat16_4.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = exp2(u_xlat16_4.xyz);
					    u_xlat16_5.xyz = u_xlat16_1.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_4.xyz);
					    u_xlat16_22 = u_xlat16_2.x + u_xlat16_2.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(0.5>=u_xlat16_2.x);
					#else
					    u_xlatb0.x = 0.5>=u_xlat16_2.x;
					#endif
					    u_xlat16_2.x = (u_xlatb0.x) ? 1.0 : 0.0;
					    u_xlat16_4.xyz = vec3(u_xlat16_22) * u_xlat16_5.xyz + u_xlat16_4.xyz;
					    SV_Target0.xyz = u_xlat16_4.xyz * u_xlat16_2.xxx + u_xlat16_8.xyz;
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
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _FlowTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat10_0;
					bvec4 u_xlatb0;
					mediump vec4 u_xlat16_1;
					mediump vec2 u_xlat16_2;
					vec2 u_xlat3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					float u_xlat6;
					mediump vec2 u_xlat10_6;
					mediump vec3 u_xlat16_8;
					mediump float u_xlat10_12;
					mediump vec2 u_xlat16_14;
					float u_xlat18;
					mediump float u_xlat16_22;
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
					    u_xlat0.x = _Time.x * -0.5;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat6 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat6 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat10_6.xy = texture(_FlowTex, u_xlat3.xy).xy;
					    u_xlat16_2.xy = u_xlat3.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_14.xy = u_xlat10_6.xy * u_xlat0.xx + u_xlat16_2.xy;
					    u_xlat10_0 = texture(_FlowTex, u_xlat16_14.xy).x;
					    u_xlat18 = _Time.x * -0.5 + 0.5;
					    u_xlat18 = fract(u_xlat18);
					    u_xlat16_2.xy = u_xlat10_6.xy * vec2(u_xlat18) + u_xlat16_2.xy;
					    u_xlat6 = (-u_xlat18) + 0.5;
					    u_xlat6 = u_xlat6 + u_xlat6;
					    u_xlat10_12 = texture(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_12) + u_xlat10_0;
					    u_xlat16_2.x = abs(u_xlat6) * u_xlat16_2.x + u_xlat10_12;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.x = min(max(u_xlat16_2.x, 0.0), 1.0);
					#else
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					#endif
					    u_xlat16_8.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_14.x = u_xlat16_8.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_8.x;
					    u_xlat16_8.x = u_xlat16_14.x + u_xlat16_14.x;
					    u_xlat16_4.xyz = u_xlat16_1.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_5.xyz = u_xlat16_1.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_8.xyz = u_xlat16_8.xxx * u_xlat16_5.xyz + u_xlat16_4.xyz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(u_xlat16_2.x>=0.5);
					#else
					    u_xlatb0.x = u_xlat16_2.x>=0.5;
					#endif
					    u_xlat16_4.x = (u_xlatb0.x) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = u_xlat16_8.xyz * u_xlat16_4.xxx;
					    u_xlat16_4.xyz = log2(u_xlat16_1.xyz);
					    u_xlat16_4.xyz = u_xlat16_4.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = exp2(u_xlat16_4.xyz);
					    u_xlat16_5.xyz = u_xlat16_1.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_4.xyz);
					    u_xlat16_22 = u_xlat16_2.x + u_xlat16_2.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(0.5>=u_xlat16_2.x);
					#else
					    u_xlatb0.x = 0.5>=u_xlat16_2.x;
					#endif
					    u_xlat16_2.x = (u_xlatb0.x) ? 1.0 : 0.0;
					    u_xlat16_4.xyz = vec3(u_xlat16_22) * u_xlat16_5.xyz + u_xlat16_4.xyz;
					    SV_Target0.xyz = u_xlat16_4.xyz * u_xlat16_2.xxx + u_xlat16_8.xyz;
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
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _FlowTex;
					in mediump vec4 vs_COLOR0;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat10_0;
					bvec4 u_xlatb0;
					mediump vec4 u_xlat16_1;
					mediump vec2 u_xlat16_2;
					vec2 u_xlat3;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					float u_xlat6;
					mediump vec2 u_xlat10_6;
					mediump vec3 u_xlat16_8;
					mediump float u_xlat10_12;
					mediump vec2 u_xlat16_14;
					float u_xlat18;
					mediump float u_xlat16_22;
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
					    u_xlat0.x = _Time.x * -0.5;
					    u_xlat0.x = fract(u_xlat0.x);
					    u_xlat6 = _ScreenParams.x / _ScreenParams.y;
					    u_xlat3.x = u_xlat6 * vs_TEXCOORD2.x;
					    u_xlat3.y = vs_TEXCOORD2.y;
					    u_xlat10_6.xy = texture(_FlowTex, u_xlat3.xy).xy;
					    u_xlat16_2.xy = u_xlat3.xy * vec2(4.42000008, 4.42000008);
					    u_xlat16_14.xy = u_xlat10_6.xy * u_xlat0.xx + u_xlat16_2.xy;
					    u_xlat10_0 = texture(_FlowTex, u_xlat16_14.xy).x;
					    u_xlat18 = _Time.x * -0.5 + 0.5;
					    u_xlat18 = fract(u_xlat18);
					    u_xlat16_2.xy = u_xlat10_6.xy * vec2(u_xlat18) + u_xlat16_2.xy;
					    u_xlat6 = (-u_xlat18) + 0.5;
					    u_xlat6 = u_xlat6 + u_xlat6;
					    u_xlat10_12 = texture(_FlowTex, u_xlat16_2.xy).x;
					    u_xlat16_2.x = (-u_xlat10_12) + u_xlat10_0;
					    u_xlat16_2.x = abs(u_xlat6) * u_xlat16_2.x + u_xlat10_12;
					    u_xlat16_2.x = u_xlat16_2.x + -0.419999987;
					    u_xlat16_2.x = u_xlat16_2.x * 3.8461535;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_2.x = min(max(u_xlat16_2.x, 0.0), 1.0);
					#else
					    u_xlat16_2.x = clamp(u_xlat16_2.x, 0.0, 1.0);
					#endif
					    u_xlat16_8.x = u_xlat16_2.x * -2.0 + 3.0;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_2.x;
					    u_xlat16_14.x = u_xlat16_8.x * u_xlat16_2.x + -0.5;
					    u_xlat16_2.x = u_xlat16_2.x * u_xlat16_8.x;
					    u_xlat16_8.x = u_xlat16_14.x + u_xlat16_14.x;
					    u_xlat16_4.xyz = u_xlat16_1.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_5.xyz = u_xlat16_1.xyz * vec3(-0.5, -0.5, -0.5);
					    u_xlat16_8.xyz = u_xlat16_8.xxx * u_xlat16_5.xyz + u_xlat16_4.xyz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(u_xlat16_2.x>=0.5);
					#else
					    u_xlatb0.x = u_xlat16_2.x>=0.5;
					#endif
					    u_xlat16_4.x = (u_xlatb0.x) ? 1.0 : 0.0;
					    u_xlat16_8.xyz = u_xlat16_8.xyz * u_xlat16_4.xxx;
					    u_xlat16_4.xyz = log2(u_xlat16_1.xyz);
					    u_xlat16_4.xyz = u_xlat16_4.xyz * vec3(1.5, 1.5, 1.5);
					    u_xlat16_4.xyz = exp2(u_xlat16_4.xyz);
					    u_xlat16_5.xyz = u_xlat16_1.xyz * vec3(1.5, 1.5, 1.5) + (-u_xlat16_4.xyz);
					    u_xlat16_22 = u_xlat16_2.x + u_xlat16_2.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(0.5>=u_xlat16_2.x);
					#else
					    u_xlatb0.x = 0.5>=u_xlat16_2.x;
					#endif
					    u_xlat16_2.x = (u_xlatb0.x) ? 1.0 : 0.0;
					    u_xlat16_4.xyz = vec3(u_xlat16_22) * u_xlat16_5.xyz + u_xlat16_4.xyz;
					    SV_Target0.xyz = u_xlat16_4.xyz * u_xlat16_2.xxx + u_xlat16_8.xyz;
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