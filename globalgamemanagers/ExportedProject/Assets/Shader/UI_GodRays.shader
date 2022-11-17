Shader "UI/GodRays" {
	Properties {
		[PerRendererData] _MainTex ("Fulfilling UI needs", 2D) = "white" {}
		_RayTex ("Ray Band Texture", 2D) = "white" {}
		_RayDensity ("Ray Density", Float) = 1
		_RayGradFalloff ("Ray Falloff", Float) = 7
		_RayGradOffset ("Ray Brightness Offset", Float) = 0
		_RayXScale ("Rays Horizontal Scale", Float) = 1
		_WarpFactor ("Warp Factor", Float) = 0
		_SpinSpeed ("Spin Speed", Float) = 0.5
		_StencilComp ("Stencil Comparison", Float) = 8
		_Stencil ("Stencil ID", Float) = 0
		_StencilOp ("Stencil Operation", Float) = 0
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		_StencilReadMask ("Stencil Read Mask", Float) = 255
		_ColorMask ("Color Mask", Float) = 15
	}
	SubShader {
		Tags { "CanUseSpriteAtlas" = "true" "IGNOREPROJECTOR" = "true" "PreviewType" = "Plane" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
		0 {
			Tags { "CanUseSpriteAtlas" = "true" "IGNOREPROJECTOR" = "true" "PreviewType" = "Plane" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
			Blend OneMinusDstColor One, OneMinusDstColor One
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
			GpuProgramID 35972
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
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
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform lowp sampler2D _RayTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					lowp float u_xlat10_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat10_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).z;
					    u_xlat10_5 = texture2D(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat10_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat10_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
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
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform lowp sampler2D _RayTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					lowp float u_xlat10_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat10_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).z;
					    u_xlat10_5 = texture2D(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat10_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat10_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
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
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform lowp sampler2D _RayTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					lowp float u_xlat10_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat10_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).z;
					    u_xlat10_5 = texture2D(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat10_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat10_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform mediump sampler2D _RayTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_COLOR0;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb7 = !!(abs(u_xlat1.x)<abs(u_xlat0.x));
					#else
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					#endif
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat1.x<(-u_xlat1.x));
					#else
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					#endif
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat16<(-u_xlat16));
					#else
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					#endif
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					#endif
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat16_8>=(-u_xlat16_8));
					#else
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					#endif
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat16_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).z;
					    u_xlat16_5 = texture(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat16_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat16_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform mediump sampler2D _RayTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_COLOR0;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb7 = !!(abs(u_xlat1.x)<abs(u_xlat0.x));
					#else
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					#endif
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat1.x<(-u_xlat1.x));
					#else
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					#endif
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat16<(-u_xlat16));
					#else
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					#endif
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					#endif
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat16_8>=(-u_xlat16_8));
					#else
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					#endif
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat16_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).z;
					    u_xlat16_5 = texture(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat16_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat16_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform mediump sampler2D _RayTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_COLOR0;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb7 = !!(abs(u_xlat1.x)<abs(u_xlat0.x));
					#else
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					#endif
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat1.x<(-u_xlat1.x));
					#else
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					#endif
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat16<(-u_xlat16));
					#else
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					#endif
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					#endif
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat16_8>=(-u_xlat16_8));
					#else
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					#endif
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat16_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).z;
					    u_xlat16_5 = texture(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat16_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat16_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    SV_Target0 = u_xlat0;
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
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
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
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform lowp sampler2D _RayTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					lowp float u_xlat10_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat10_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).z;
					    u_xlat10_5 = texture2D(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat10_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat10_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    SV_Target0 = u_xlat0;
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
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
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
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform lowp sampler2D _RayTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					lowp float u_xlat10_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat10_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).z;
					    u_xlat10_5 = texture2D(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat10_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat10_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    SV_Target0 = u_xlat0;
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
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
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
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform lowp sampler2D _RayTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					lowp float u_xlat10_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat10_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).z;
					    u_xlat10_5 = texture2D(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat10_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat10_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    SV_Target0 = u_xlat0;
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
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform mediump sampler2D _RayTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_COLOR0;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb7 = !!(abs(u_xlat1.x)<abs(u_xlat0.x));
					#else
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					#endif
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat1.x<(-u_xlat1.x));
					#else
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					#endif
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat16<(-u_xlat16));
					#else
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					#endif
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					#endif
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat16_8>=(-u_xlat16_8));
					#else
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					#endif
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat16_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).z;
					    u_xlat16_5 = texture(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat16_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat16_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    SV_Target0 = u_xlat0;
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
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform mediump sampler2D _RayTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_COLOR0;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb7 = !!(abs(u_xlat1.x)<abs(u_xlat0.x));
					#else
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					#endif
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat1.x<(-u_xlat1.x));
					#else
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					#endif
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat16<(-u_xlat16));
					#else
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					#endif
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					#endif
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat16_8>=(-u_xlat16_8));
					#else
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					#endif
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat16_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).z;
					    u_xlat16_5 = texture(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat16_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat16_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    SV_Target0 = u_xlat0;
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
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform mediump sampler2D _RayTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_COLOR0;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb7 = !!(abs(u_xlat1.x)<abs(u_xlat0.x));
					#else
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					#endif
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat1.x<(-u_xlat1.x));
					#else
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					#endif
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat16<(-u_xlat16));
					#else
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					#endif
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					#endif
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat16_8>=(-u_xlat16_8));
					#else
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					#endif
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat16_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).z;
					    u_xlat16_5 = texture(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat16_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat16_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "PIXELSNAP_ON" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
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
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform lowp sampler2D _RayTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					lowp float u_xlat10_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat10_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).z;
					    u_xlat10_5 = texture2D(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat10_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat10_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "PIXELSNAP_ON" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
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
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform lowp sampler2D _RayTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					lowp float u_xlat10_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat10_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).z;
					    u_xlat10_5 = texture2D(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat10_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat10_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "PIXELSNAP_ON" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
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
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform lowp sampler2D _RayTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					lowp float u_xlat10_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat10_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).z;
					    u_xlat10_5 = texture2D(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat10_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat10_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "PIXELSNAP_ON" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform mediump sampler2D _RayTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_COLOR0;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb7 = !!(abs(u_xlat1.x)<abs(u_xlat0.x));
					#else
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					#endif
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat1.x<(-u_xlat1.x));
					#else
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					#endif
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat16<(-u_xlat16));
					#else
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					#endif
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					#endif
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat16_8>=(-u_xlat16_8));
					#else
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					#endif
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat16_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).z;
					    u_xlat16_5 = texture(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat16_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat16_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "PIXELSNAP_ON" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform mediump sampler2D _RayTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_COLOR0;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb7 = !!(abs(u_xlat1.x)<abs(u_xlat0.x));
					#else
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					#endif
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat1.x<(-u_xlat1.x));
					#else
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					#endif
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat16<(-u_xlat16));
					#else
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					#endif
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					#endif
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat16_8>=(-u_xlat16_8));
					#else
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					#endif
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat16_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).z;
					    u_xlat16_5 = texture(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat16_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat16_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "PIXELSNAP_ON" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform mediump sampler2D _RayTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_COLOR0;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb7 = !!(abs(u_xlat1.x)<abs(u_xlat0.x));
					#else
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					#endif
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat1.x<(-u_xlat1.x));
					#else
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					#endif
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat16<(-u_xlat16));
					#else
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					#endif
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					#endif
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat16_8>=(-u_xlat16_8));
					#else
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					#endif
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat16_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).z;
					    u_xlat16_5 = texture(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat16_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat16_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "PIXELSNAP_ON" "UNITY_UI_ALPHACLIP" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
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
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform lowp sampler2D _RayTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					lowp float u_xlat10_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat10_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).z;
					    u_xlat10_5 = texture2D(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat10_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat10_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "PIXELSNAP_ON" "UNITY_UI_ALPHACLIP" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
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
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform lowp sampler2D _RayTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					lowp float u_xlat10_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat10_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).z;
					    u_xlat10_5 = texture2D(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat10_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat10_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "PIXELSNAP_ON" "UNITY_UI_ALPHACLIP" }
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					attribute highp vec4 in_POSITION0;
					attribute highp vec4 in_COLOR0;
					attribute highp vec2 in_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
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
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform lowp sampler2D _RayTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_COLOR0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					lowp float u_xlat10_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat10_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat10_0 = texture2D(_RayTex, u_xlat0.xy).z;
					    u_xlat10_5 = texture2D(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat10_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat10_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "PIXELSNAP_ON" "UNITY_UI_ALPHACLIP" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform mediump sampler2D _RayTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_COLOR0;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb7 = !!(abs(u_xlat1.x)<abs(u_xlat0.x));
					#else
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					#endif
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat1.x<(-u_xlat1.x));
					#else
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					#endif
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat16<(-u_xlat16));
					#else
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					#endif
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					#endif
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat16_8>=(-u_xlat16_8));
					#else
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					#endif
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat16_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).z;
					    u_xlat16_5 = texture(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat16_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat16_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "PIXELSNAP_ON" "UNITY_UI_ALPHACLIP" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform mediump sampler2D _RayTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_COLOR0;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb7 = !!(abs(u_xlat1.x)<abs(u_xlat0.x));
					#else
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					#endif
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat1.x<(-u_xlat1.x));
					#else
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					#endif
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat16<(-u_xlat16));
					#else
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					#endif
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					#endif
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat16_8>=(-u_xlat16_8));
					#else
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					#endif
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat16_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).z;
					    u_xlat16_5 = texture(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat16_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat16_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    SV_Target0 = u_xlat0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "PIXELSNAP_ON" "UNITY_UI_ALPHACLIP" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					in highp vec4 in_POSITION0;
					in highp vec4 in_COLOR0;
					in highp vec2 in_TEXCOORD0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_COLOR0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    vs_COLOR0 = in_COLOR0;
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Time;
					uniform 	mediump float _RayDensity;
					uniform 	mediump float _RayGradFalloff;
					uniform 	mediump float _RayGradOffset;
					uniform 	mediump float _RayXScale;
					uniform 	mediump float _SpinSpeed;
					uniform 	mediump float _WarpFactor;
					uniform mediump sampler2D _RayTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_COLOR0;
					layout(location = 0) out mediump vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec3 u_xlat1;
					float u_xlat2;
					mediump float u_xlat16_3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb7;
					mediump float u_xlat16_8;
					mediump float u_xlat16_9;
					float u_xlat10;
					mediump vec2 u_xlat16_13;
					float u_xlat16;
					bool u_xlatb16;
					void main()
					{
					    u_xlat0 = vs_TEXCOORD0.yxxy + vec4(-0.5, -0.5, -0.5, -0.5);
					    u_xlat1.xy = u_xlat0.yz * vec2(vec2(_RayXScale, _RayXScale));
					    u_xlat5.x = max(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = float(1.0) / u_xlat5.x;
					    u_xlat16 = min(abs(u_xlat0.x), abs(u_xlat1.x));
					    u_xlat5.x = u_xlat5.x * u_xlat16;
					    u_xlat16 = u_xlat5.x * u_xlat5.x;
					    u_xlat2 = u_xlat16 * 0.0208350997 + -0.0851330012;
					    u_xlat2 = u_xlat16 * u_xlat2 + 0.180141002;
					    u_xlat2 = u_xlat16 * u_xlat2 + -0.330299497;
					    u_xlat16 = u_xlat16 * u_xlat2 + 0.999866009;
					    u_xlat2 = u_xlat5.x * u_xlat16;
					    u_xlat2 = u_xlat2 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb7 = !!(abs(u_xlat1.x)<abs(u_xlat0.x));
					#else
					    u_xlatb7 = abs(u_xlat1.x)<abs(u_xlat0.x);
					#endif
					    u_xlat2 = u_xlatb7 ? u_xlat2 : float(0.0);
					    u_xlat5.x = u_xlat5.x * u_xlat16 + u_xlat2;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat1.x<(-u_xlat1.x));
					#else
					    u_xlatb16 = u_xlat1.x<(-u_xlat1.x);
					#endif
					    u_xlat16 = u_xlatb16 ? -3.14159274 : float(0.0);
					    u_xlat5.x = u_xlat5.x + u_xlat16;
					    u_xlat16 = min(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb16 = !!(u_xlat16<(-u_xlat16));
					#else
					    u_xlatb16 = u_xlat16<(-u_xlat16);
					#endif
					    u_xlat0.x = max(u_xlat0.x, u_xlat1.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0 = u_xlat0.x>=(-u_xlat0.x);
					#endif
					    u_xlatb0 = u_xlatb0 && u_xlatb16;
					    u_xlat0.x = (u_xlatb0) ? (-u_xlat5.x) : u_xlat5.x;
					    u_xlat0.x = u_xlat0.x + 3.14159274;
					    u_xlat5.x = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlat1.z = u_xlat0.w;
					    u_xlat5.y = dot(u_xlat1.yz, u_xlat1.yz);
					    u_xlat5.xy = sqrt(u_xlat5.xy);
					    u_xlat10 = min(u_xlat5.y, 1.0);
					    u_xlat10 = (-u_xlat10) + 1.0;
					    u_xlat16_3 = u_xlat10 + _RayGradOffset;
					    u_xlat16_3 = log2(u_xlat16_3);
					    u_xlat16_3 = u_xlat16_3 * _RayGradFalloff;
					    u_xlat16_3 = exp2(u_xlat16_3);
					    u_xlat5.x = u_xlat5.x * _WarpFactor;
					    u_xlat16_8 = u_xlat0.x * 0.159154937 + u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat16_8>=(-u_xlat16_8));
					#else
					    u_xlatb0 = u_xlat16_8>=(-u_xlat16_8);
					#endif
					    u_xlat16_13.xy = (bool(u_xlatb0)) ? vec2(1.0, 1.0) : vec2(-1.0, -1.0);
					    u_xlat16_8 = u_xlat16_13.y * u_xlat16_8;
					    u_xlat16_8 = fract(u_xlat16_8);
					    u_xlat16_9 = u_xlat16_8 * u_xlat16_13.x;
					    u_xlat4.x = u_xlat16_9 * _RayDensity;
					    u_xlat4.y = u_xlat16_9;
					    u_xlat0.x = (-_Time.x) * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat0.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).y;
					    u_xlat16_8 = u_xlat16_3 + u_xlat16_3;
					    u_xlat16_8 = u_xlat16_0 * u_xlat16_8;
					    u_xlat0.x = _Time.x * _SpinSpeed;
					    u_xlat0.y = 0.0;
					    u_xlat1.xy = u_xlat0.xy + u_xlat4.xy;
					    u_xlat0.z = u_xlat0.x * 0.600000024;
					    u_xlat0.xy = u_xlat0.zy + u_xlat4.xy;
					    u_xlat16_0 = texture(_RayTex, u_xlat0.xy).z;
					    u_xlat16_5 = texture(_RayTex, u_xlat1.xy).x;
					    u_xlat16_8 = u_xlat16_5 * u_xlat16_3 + u_xlat16_8;
					    u_xlat16_3 = u_xlat16_3 * 0.5;
					    u_xlat16_3 = u_xlat16_0 * u_xlat16_3 + u_xlat16_8;
					    u_xlat0 = vec4(u_xlat16_3) * vs_COLOR0;
					    u_xlat0 = u_xlat0 * vs_COLOR0.wwww;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    SV_Target0 = u_xlat0;
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
					Keywords { "PIXELSNAP_ON" }
					"!!GLES"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "PIXELSNAP_ON" }
					"!!GLES"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "PIXELSNAP_ON" }
					"!!GLES"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "PIXELSNAP_ON" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "PIXELSNAP_ON" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "PIXELSNAP_ON" }
					"!!GLES3"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "PIXELSNAP_ON" "UNITY_UI_ALPHACLIP" }
					"!!GLES"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "PIXELSNAP_ON" "UNITY_UI_ALPHACLIP" }
					"!!GLES"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "PIXELSNAP_ON" "UNITY_UI_ALPHACLIP" }
					"!!GLES"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "PIXELSNAP_ON" "UNITY_UI_ALPHACLIP" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "PIXELSNAP_ON" "UNITY_UI_ALPHACLIP" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "PIXELSNAP_ON" "UNITY_UI_ALPHACLIP" }
					"!!GLES3"
				}
			}
		}
	}
	Fallback "UI/Default"
}