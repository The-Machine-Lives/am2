Shader "Hidden/PostProcessing/Bloom" {
	Properties {
	}
	SubShader {
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 24493
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _AutoExposureTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					lowp vec4 u_xlat10_2;
					vec2 u_xlat3;
					lowp vec4 u_xlat10_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					lowp vec4 u_xlat10_4;
					mediump vec4 u_xlat16_5;
					lowp vec4 u_xlat10_5;
					float u_xlat7;
					float u_xlat19;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat10_0 + u_xlat10_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + (-_MainTex_TexelSize.xy);
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat2 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat2.xy);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat2.zw);
					    u_xlat16_2 = u_xlat10_2 + u_xlat10_3;
					    u_xlat16_1 = u_xlat10_1 + u_xlat10_3;
					    u_xlat3.xy = vs_TEXCOORD0.xy;
					    u_xlat3.xy = clamp(u_xlat3.xy, 0.0, 1.0);
					    u_xlat3.xy = u_xlat3.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat3.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_3;
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_5 = texture2D(_MainTex, u_xlat4.xy);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat4.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_5;
					    u_xlat16_5 = u_xlat10_3 + u_xlat10_5;
					    u_xlat16_1 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125);
					    u_xlat16_0 = u_xlat16_0 * vec4(0.125, 0.125, 0.125, 0.125) + u_xlat16_1;
					    u_xlat16_1 = u_xlat16_2 + u_xlat10_4;
					    u_xlat16_2 = u_xlat10_3 + u_xlat10_4;
					    u_xlat16_1 = u_xlat10_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat16_4 = u_xlat10_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat10_1 + u_xlat16_4;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + _MainTex_TexelSize.xy;
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = u_xlat10_1 + u_xlat16_2;
					    u_xlat16_1 = u_xlat10_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat16_0 = min(u_xlat16_0, vec4(65504.0, 65504.0, 65504.0, 65504.0));
					    u_xlat10_1.x = texture2D(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0 = u_xlat16_0 * u_xlat10_1.xxxx;
					    u_xlat0 = min(u_xlat16_0, _Params.xxxx);
					    u_xlat1.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat1.x = max(u_xlat0.z, u_xlat1.x);
					    u_xlat1.yz = u_xlat1.xx + (-_Threshold.yx);
					    u_xlat1.xy = max(u_xlat1.xy, vec2(9.99999975e-05, 0.0));
					    u_xlat7 = min(u_xlat1.y, _Threshold.z);
					    u_xlat19 = u_xlat7 * _Threshold.w;
					    u_xlat7 = u_xlat7 * u_xlat19;
					    u_xlat7 = max(u_xlat1.z, u_xlat7);
					    u_xlat1.x = u_xlat7 / u_xlat1.x;
					    SV_Target0 = u_xlat0 * u_xlat1.xxxx;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _AutoExposureTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					lowp vec4 u_xlat10_2;
					vec2 u_xlat3;
					lowp vec4 u_xlat10_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					lowp vec4 u_xlat10_4;
					mediump vec4 u_xlat16_5;
					lowp vec4 u_xlat10_5;
					float u_xlat7;
					float u_xlat19;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat10_0 + u_xlat10_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + (-_MainTex_TexelSize.xy);
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat2 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat2.xy);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat2.zw);
					    u_xlat16_2 = u_xlat10_2 + u_xlat10_3;
					    u_xlat16_1 = u_xlat10_1 + u_xlat10_3;
					    u_xlat3.xy = vs_TEXCOORD0.xy;
					    u_xlat3.xy = clamp(u_xlat3.xy, 0.0, 1.0);
					    u_xlat3.xy = u_xlat3.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat3.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_3;
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_5 = texture2D(_MainTex, u_xlat4.xy);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat4.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_5;
					    u_xlat16_5 = u_xlat10_3 + u_xlat10_5;
					    u_xlat16_1 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125);
					    u_xlat16_0 = u_xlat16_0 * vec4(0.125, 0.125, 0.125, 0.125) + u_xlat16_1;
					    u_xlat16_1 = u_xlat16_2 + u_xlat10_4;
					    u_xlat16_2 = u_xlat10_3 + u_xlat10_4;
					    u_xlat16_1 = u_xlat10_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat16_4 = u_xlat10_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat10_1 + u_xlat16_4;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + _MainTex_TexelSize.xy;
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = u_xlat10_1 + u_xlat16_2;
					    u_xlat16_1 = u_xlat10_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat16_0 = min(u_xlat16_0, vec4(65504.0, 65504.0, 65504.0, 65504.0));
					    u_xlat10_1.x = texture2D(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0 = u_xlat16_0 * u_xlat10_1.xxxx;
					    u_xlat0 = min(u_xlat16_0, _Params.xxxx);
					    u_xlat1.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat1.x = max(u_xlat0.z, u_xlat1.x);
					    u_xlat1.yz = u_xlat1.xx + (-_Threshold.yx);
					    u_xlat1.xy = max(u_xlat1.xy, vec2(9.99999975e-05, 0.0));
					    u_xlat7 = min(u_xlat1.y, _Threshold.z);
					    u_xlat19 = u_xlat7 * _Threshold.w;
					    u_xlat7 = u_xlat7 * u_xlat19;
					    u_xlat7 = max(u_xlat1.z, u_xlat7);
					    u_xlat1.x = u_xlat7 / u_xlat1.x;
					    SV_Target0 = u_xlat0 * u_xlat1.xxxx;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _AutoExposureTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					lowp vec4 u_xlat10_2;
					vec2 u_xlat3;
					lowp vec4 u_xlat10_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					lowp vec4 u_xlat10_4;
					mediump vec4 u_xlat16_5;
					lowp vec4 u_xlat10_5;
					float u_xlat7;
					float u_xlat19;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat10_0 + u_xlat10_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + (-_MainTex_TexelSize.xy);
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat2 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat2.xy);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat2.zw);
					    u_xlat16_2 = u_xlat10_2 + u_xlat10_3;
					    u_xlat16_1 = u_xlat10_1 + u_xlat10_3;
					    u_xlat3.xy = vs_TEXCOORD0.xy;
					    u_xlat3.xy = clamp(u_xlat3.xy, 0.0, 1.0);
					    u_xlat3.xy = u_xlat3.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat3.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_3;
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_5 = texture2D(_MainTex, u_xlat4.xy);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat4.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_5;
					    u_xlat16_5 = u_xlat10_3 + u_xlat10_5;
					    u_xlat16_1 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125);
					    u_xlat16_0 = u_xlat16_0 * vec4(0.125, 0.125, 0.125, 0.125) + u_xlat16_1;
					    u_xlat16_1 = u_xlat16_2 + u_xlat10_4;
					    u_xlat16_2 = u_xlat10_3 + u_xlat10_4;
					    u_xlat16_1 = u_xlat10_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat16_4 = u_xlat10_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat10_1 + u_xlat16_4;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + _MainTex_TexelSize.xy;
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = u_xlat10_1 + u_xlat16_2;
					    u_xlat16_1 = u_xlat10_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat16_0 = min(u_xlat16_0, vec4(65504.0, 65504.0, 65504.0, 65504.0));
					    u_xlat10_1.x = texture2D(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0 = u_xlat16_0 * u_xlat10_1.xxxx;
					    u_xlat0 = min(u_xlat16_0, _Params.xxxx);
					    u_xlat1.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat1.x = max(u_xlat0.z, u_xlat1.x);
					    u_xlat1.yz = u_xlat1.xx + (-_Threshold.yx);
					    u_xlat1.xy = max(u_xlat1.xy, vec2(9.99999975e-05, 0.0));
					    u_xlat7 = min(u_xlat1.y, _Threshold.z);
					    u_xlat19 = u_xlat7 * _Threshold.w;
					    u_xlat7 = u_xlat7 * u_xlat19;
					    u_xlat7 = max(u_xlat1.z, u_xlat7);
					    u_xlat1.x = u_xlat7 / u_xlat1.x;
					    SV_Target0 = u_xlat0 * u_xlat1.xxxx;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _AutoExposureTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec2 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					mediump vec4 u_xlat16_5;
					float u_xlat7;
					float u_xlat19;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + (-_MainTex_TexelSize.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat2 = min(max(u_xlat2, 0.0), 1.0);
					#else
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					#endif
					    u_xlat2 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat2.xy);
					    u_xlat16_2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat16_2 = u_xlat16_2 + u_xlat16_3;
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_3;
					    u_xlat3.xy = vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat3.xy = min(max(u_xlat3.xy, 0.0), 1.0);
					#else
					    u_xlat3.xy = clamp(u_xlat3.xy, 0.0, 1.0);
					#endif
					    u_xlat3.xy = u_xlat3.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat3.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_3;
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4 = min(max(u_xlat4, 0.0), 1.0);
					#else
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					#endif
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_5 = texture(_MainTex, u_xlat4.xy);
					    u_xlat16_4 = texture(_MainTex, u_xlat4.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_5;
					    u_xlat16_5 = u_xlat16_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125);
					    u_xlat16_0 = u_xlat16_0 * vec4(0.125, 0.125, 0.125, 0.125) + u_xlat16_1;
					    u_xlat16_1 = u_xlat16_2 + u_xlat16_4;
					    u_xlat16_2 = u_xlat16_3 + u_xlat16_4;
					    u_xlat16_1 = u_xlat16_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_4 = u_xlat16_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_4;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + _MainTex_TexelSize.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_2;
					    u_xlat16_1 = u_xlat16_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat16_0 = min(u_xlat16_0, vec4(65504.0, 65504.0, 65504.0, 65504.0));
					    u_xlat16_1.x = texture(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0 = u_xlat16_0 * u_xlat16_1.xxxx;
					    u_xlat0 = min(u_xlat16_0, _Params.xxxx);
					    u_xlat1.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat1.x = max(u_xlat0.z, u_xlat1.x);
					    u_xlat1.yz = u_xlat1.xx + (-_Threshold.yx);
					    u_xlat1.xy = max(u_xlat1.xy, vec2(9.99999975e-05, 0.0));
					    u_xlat7 = min(u_xlat1.y, _Threshold.z);
					    u_xlat19 = u_xlat7 * _Threshold.w;
					    u_xlat7 = u_xlat7 * u_xlat19;
					    u_xlat7 = max(u_xlat1.z, u_xlat7);
					    u_xlat1.x = u_xlat7 / u_xlat1.x;
					    SV_Target0 = u_xlat0 * u_xlat1.xxxx;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _AutoExposureTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec2 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					mediump vec4 u_xlat16_5;
					float u_xlat7;
					float u_xlat19;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + (-_MainTex_TexelSize.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat2 = min(max(u_xlat2, 0.0), 1.0);
					#else
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					#endif
					    u_xlat2 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat2.xy);
					    u_xlat16_2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat16_2 = u_xlat16_2 + u_xlat16_3;
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_3;
					    u_xlat3.xy = vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat3.xy = min(max(u_xlat3.xy, 0.0), 1.0);
					#else
					    u_xlat3.xy = clamp(u_xlat3.xy, 0.0, 1.0);
					#endif
					    u_xlat3.xy = u_xlat3.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat3.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_3;
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4 = min(max(u_xlat4, 0.0), 1.0);
					#else
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					#endif
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_5 = texture(_MainTex, u_xlat4.xy);
					    u_xlat16_4 = texture(_MainTex, u_xlat4.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_5;
					    u_xlat16_5 = u_xlat16_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125);
					    u_xlat16_0 = u_xlat16_0 * vec4(0.125, 0.125, 0.125, 0.125) + u_xlat16_1;
					    u_xlat16_1 = u_xlat16_2 + u_xlat16_4;
					    u_xlat16_2 = u_xlat16_3 + u_xlat16_4;
					    u_xlat16_1 = u_xlat16_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_4 = u_xlat16_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_4;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + _MainTex_TexelSize.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_2;
					    u_xlat16_1 = u_xlat16_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat16_0 = min(u_xlat16_0, vec4(65504.0, 65504.0, 65504.0, 65504.0));
					    u_xlat16_1.x = texture(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0 = u_xlat16_0 * u_xlat16_1.xxxx;
					    u_xlat0 = min(u_xlat16_0, _Params.xxxx);
					    u_xlat1.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat1.x = max(u_xlat0.z, u_xlat1.x);
					    u_xlat1.yz = u_xlat1.xx + (-_Threshold.yx);
					    u_xlat1.xy = max(u_xlat1.xy, vec2(9.99999975e-05, 0.0));
					    u_xlat7 = min(u_xlat1.y, _Threshold.z);
					    u_xlat19 = u_xlat7 * _Threshold.w;
					    u_xlat7 = u_xlat7 * u_xlat19;
					    u_xlat7 = max(u_xlat1.z, u_xlat7);
					    u_xlat1.x = u_xlat7 / u_xlat1.x;
					    SV_Target0 = u_xlat0 * u_xlat1.xxxx;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _AutoExposureTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec2 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					mediump vec4 u_xlat16_5;
					float u_xlat7;
					float u_xlat19;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + (-_MainTex_TexelSize.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat2 = min(max(u_xlat2, 0.0), 1.0);
					#else
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					#endif
					    u_xlat2 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat2.xy);
					    u_xlat16_2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat16_2 = u_xlat16_2 + u_xlat16_3;
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_3;
					    u_xlat3.xy = vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat3.xy = min(max(u_xlat3.xy, 0.0), 1.0);
					#else
					    u_xlat3.xy = clamp(u_xlat3.xy, 0.0, 1.0);
					#endif
					    u_xlat3.xy = u_xlat3.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat3.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_3;
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4 = min(max(u_xlat4, 0.0), 1.0);
					#else
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					#endif
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_5 = texture(_MainTex, u_xlat4.xy);
					    u_xlat16_4 = texture(_MainTex, u_xlat4.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_5;
					    u_xlat16_5 = u_xlat16_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125);
					    u_xlat16_0 = u_xlat16_0 * vec4(0.125, 0.125, 0.125, 0.125) + u_xlat16_1;
					    u_xlat16_1 = u_xlat16_2 + u_xlat16_4;
					    u_xlat16_2 = u_xlat16_3 + u_xlat16_4;
					    u_xlat16_1 = u_xlat16_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_4 = u_xlat16_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_4;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + _MainTex_TexelSize.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_2;
					    u_xlat16_1 = u_xlat16_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat16_0 = min(u_xlat16_0, vec4(65504.0, 65504.0, 65504.0, 65504.0));
					    u_xlat16_1.x = texture(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0 = u_xlat16_0 * u_xlat16_1.xxxx;
					    u_xlat0 = min(u_xlat16_0, _Params.xxxx);
					    u_xlat1.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat1.x = max(u_xlat0.z, u_xlat1.x);
					    u_xlat1.yz = u_xlat1.xx + (-_Threshold.yx);
					    u_xlat1.xy = max(u_xlat1.xy, vec2(9.99999975e-05, 0.0));
					    u_xlat7 = min(u_xlat1.y, _Threshold.z);
					    u_xlat19 = u_xlat7 * _Threshold.w;
					    u_xlat7 = u_xlat7 * u_xlat19;
					    u_xlat7 = max(u_xlat1.z, u_xlat7);
					    u_xlat1.x = u_xlat7 / u_xlat1.x;
					    SV_Target0 = u_xlat0 * u_xlat1.xxxx;
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
			}
		}
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 80263
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _AutoExposureTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec4 u_xlat10_1;
					lowp vec4 u_xlat10_2;
					float u_xlat4;
					float u_xlat10;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat10_0 + u_xlat10_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    u_xlat16_0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25);
					    u_xlat16_0 = min(u_xlat16_0, vec4(65504.0, 65504.0, 65504.0, 65504.0));
					    u_xlat10_1.x = texture2D(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0 = u_xlat16_0 * u_xlat10_1.xxxx;
					    u_xlat0 = min(u_xlat16_0, _Params.xxxx);
					    u_xlat1.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat1.x = max(u_xlat0.z, u_xlat1.x);
					    u_xlat1.yz = u_xlat1.xx + (-_Threshold.yx);
					    u_xlat1.xy = max(u_xlat1.xy, vec2(9.99999975e-05, 0.0));
					    u_xlat4 = min(u_xlat1.y, _Threshold.z);
					    u_xlat10 = u_xlat4 * _Threshold.w;
					    u_xlat4 = u_xlat4 * u_xlat10;
					    u_xlat4 = max(u_xlat1.z, u_xlat4);
					    u_xlat1.x = u_xlat4 / u_xlat1.x;
					    SV_Target0 = u_xlat0 * u_xlat1.xxxx;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _AutoExposureTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec4 u_xlat10_1;
					lowp vec4 u_xlat10_2;
					float u_xlat4;
					float u_xlat10;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat10_0 + u_xlat10_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    u_xlat16_0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25);
					    u_xlat16_0 = min(u_xlat16_0, vec4(65504.0, 65504.0, 65504.0, 65504.0));
					    u_xlat10_1.x = texture2D(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0 = u_xlat16_0 * u_xlat10_1.xxxx;
					    u_xlat0 = min(u_xlat16_0, _Params.xxxx);
					    u_xlat1.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat1.x = max(u_xlat0.z, u_xlat1.x);
					    u_xlat1.yz = u_xlat1.xx + (-_Threshold.yx);
					    u_xlat1.xy = max(u_xlat1.xy, vec2(9.99999975e-05, 0.0));
					    u_xlat4 = min(u_xlat1.y, _Threshold.z);
					    u_xlat10 = u_xlat4 * _Threshold.w;
					    u_xlat4 = u_xlat4 * u_xlat10;
					    u_xlat4 = max(u_xlat1.z, u_xlat4);
					    u_xlat1.x = u_xlat4 / u_xlat1.x;
					    SV_Target0 = u_xlat0 * u_xlat1.xxxx;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _AutoExposureTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec4 u_xlat10_1;
					lowp vec4 u_xlat10_2;
					float u_xlat4;
					float u_xlat10;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat10_0 + u_xlat10_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    u_xlat16_0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25);
					    u_xlat16_0 = min(u_xlat16_0, vec4(65504.0, 65504.0, 65504.0, 65504.0));
					    u_xlat10_1.x = texture2D(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0 = u_xlat16_0 * u_xlat10_1.xxxx;
					    u_xlat0 = min(u_xlat16_0, _Params.xxxx);
					    u_xlat1.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat1.x = max(u_xlat0.z, u_xlat1.x);
					    u_xlat1.yz = u_xlat1.xx + (-_Threshold.yx);
					    u_xlat1.xy = max(u_xlat1.xy, vec2(9.99999975e-05, 0.0));
					    u_xlat4 = min(u_xlat1.y, _Threshold.z);
					    u_xlat10 = u_xlat4 * _Threshold.w;
					    u_xlat4 = u_xlat4 * u_xlat10;
					    u_xlat4 = max(u_xlat1.z, u_xlat4);
					    u_xlat1.x = u_xlat4 / u_xlat1.x;
					    SV_Target0 = u_xlat0 * u_xlat1.xxxx;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _AutoExposureTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					mediump vec4 u_xlat16_2;
					float u_xlat4;
					float u_xlat10;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    u_xlat16_0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25);
					    u_xlat16_0 = min(u_xlat16_0, vec4(65504.0, 65504.0, 65504.0, 65504.0));
					    u_xlat16_1.x = texture(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0 = u_xlat16_0 * u_xlat16_1.xxxx;
					    u_xlat0 = min(u_xlat16_0, _Params.xxxx);
					    u_xlat1.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat1.x = max(u_xlat0.z, u_xlat1.x);
					    u_xlat1.yz = u_xlat1.xx + (-_Threshold.yx);
					    u_xlat1.xy = max(u_xlat1.xy, vec2(9.99999975e-05, 0.0));
					    u_xlat4 = min(u_xlat1.y, _Threshold.z);
					    u_xlat10 = u_xlat4 * _Threshold.w;
					    u_xlat4 = u_xlat4 * u_xlat10;
					    u_xlat4 = max(u_xlat1.z, u_xlat4);
					    u_xlat1.x = u_xlat4 / u_xlat1.x;
					    SV_Target0 = u_xlat0 * u_xlat1.xxxx;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _AutoExposureTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					mediump vec4 u_xlat16_2;
					float u_xlat4;
					float u_xlat10;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    u_xlat16_0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25);
					    u_xlat16_0 = min(u_xlat16_0, vec4(65504.0, 65504.0, 65504.0, 65504.0));
					    u_xlat16_1.x = texture(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0 = u_xlat16_0 * u_xlat16_1.xxxx;
					    u_xlat0 = min(u_xlat16_0, _Params.xxxx);
					    u_xlat1.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat1.x = max(u_xlat0.z, u_xlat1.x);
					    u_xlat1.yz = u_xlat1.xx + (-_Threshold.yx);
					    u_xlat1.xy = max(u_xlat1.xy, vec2(9.99999975e-05, 0.0));
					    u_xlat4 = min(u_xlat1.y, _Threshold.z);
					    u_xlat10 = u_xlat4 * _Threshold.w;
					    u_xlat4 = u_xlat4 * u_xlat10;
					    u_xlat4 = max(u_xlat1.z, u_xlat4);
					    u_xlat1.x = u_xlat4 / u_xlat1.x;
					    SV_Target0 = u_xlat0 * u_xlat1.xxxx;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _AutoExposureTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					mediump vec4 u_xlat16_2;
					float u_xlat4;
					float u_xlat10;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    u_xlat16_0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25);
					    u_xlat16_0 = min(u_xlat16_0, vec4(65504.0, 65504.0, 65504.0, 65504.0));
					    u_xlat16_1.x = texture(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0 = u_xlat16_0 * u_xlat16_1.xxxx;
					    u_xlat0 = min(u_xlat16_0, _Params.xxxx);
					    u_xlat1.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat1.x = max(u_xlat0.z, u_xlat1.x);
					    u_xlat1.yz = u_xlat1.xx + (-_Threshold.yx);
					    u_xlat1.xy = max(u_xlat1.xy, vec2(9.99999975e-05, 0.0));
					    u_xlat4 = min(u_xlat1.y, _Threshold.z);
					    u_xlat10 = u_xlat4 * _Threshold.w;
					    u_xlat4 = u_xlat4 * u_xlat10;
					    u_xlat4 = max(u_xlat1.z, u_xlat4);
					    u_xlat1.x = u_xlat4 / u_xlat1.x;
					    SV_Target0 = u_xlat0 * u_xlat1.xxxx;
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
			}
		}
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 192913
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					lowp vec4 u_xlat10_2;
					vec2 u_xlat3;
					lowp vec4 u_xlat10_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					lowp vec4 u_xlat10_4;
					mediump vec4 u_xlat16_5;
					lowp vec4 u_xlat10_5;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat10_0 + u_xlat10_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + (-_MainTex_TexelSize.xy);
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat2 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat2.xy);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat2.zw);
					    u_xlat16_2 = u_xlat10_2 + u_xlat10_3;
					    u_xlat16_1 = u_xlat10_1 + u_xlat10_3;
					    u_xlat3.xy = vs_TEXCOORD0.xy;
					    u_xlat3.xy = clamp(u_xlat3.xy, 0.0, 1.0);
					    u_xlat3.xy = u_xlat3.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat3.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_3;
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_5 = texture2D(_MainTex, u_xlat4.xy);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat4.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_5;
					    u_xlat16_5 = u_xlat10_3 + u_xlat10_5;
					    u_xlat16_1 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125);
					    u_xlat16_0 = u_xlat16_0 * vec4(0.125, 0.125, 0.125, 0.125) + u_xlat16_1;
					    u_xlat16_1 = u_xlat16_2 + u_xlat10_4;
					    u_xlat16_2 = u_xlat10_3 + u_xlat10_4;
					    u_xlat16_1 = u_xlat10_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat16_4 = u_xlat10_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat10_1 + u_xlat16_4;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + _MainTex_TexelSize.xy;
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = u_xlat10_1 + u_xlat16_2;
					    u_xlat16_1 = u_xlat10_3 + u_xlat16_1;
					    SV_Target0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					lowp vec4 u_xlat10_2;
					vec2 u_xlat3;
					lowp vec4 u_xlat10_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					lowp vec4 u_xlat10_4;
					mediump vec4 u_xlat16_5;
					lowp vec4 u_xlat10_5;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat10_0 + u_xlat10_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + (-_MainTex_TexelSize.xy);
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat2 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat2.xy);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat2.zw);
					    u_xlat16_2 = u_xlat10_2 + u_xlat10_3;
					    u_xlat16_1 = u_xlat10_1 + u_xlat10_3;
					    u_xlat3.xy = vs_TEXCOORD0.xy;
					    u_xlat3.xy = clamp(u_xlat3.xy, 0.0, 1.0);
					    u_xlat3.xy = u_xlat3.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat3.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_3;
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_5 = texture2D(_MainTex, u_xlat4.xy);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat4.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_5;
					    u_xlat16_5 = u_xlat10_3 + u_xlat10_5;
					    u_xlat16_1 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125);
					    u_xlat16_0 = u_xlat16_0 * vec4(0.125, 0.125, 0.125, 0.125) + u_xlat16_1;
					    u_xlat16_1 = u_xlat16_2 + u_xlat10_4;
					    u_xlat16_2 = u_xlat10_3 + u_xlat10_4;
					    u_xlat16_1 = u_xlat10_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat16_4 = u_xlat10_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat10_1 + u_xlat16_4;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + _MainTex_TexelSize.xy;
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = u_xlat10_1 + u_xlat16_2;
					    u_xlat16_1 = u_xlat10_3 + u_xlat16_1;
					    SV_Target0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					lowp vec4 u_xlat10_2;
					vec2 u_xlat3;
					lowp vec4 u_xlat10_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					lowp vec4 u_xlat10_4;
					mediump vec4 u_xlat16_5;
					lowp vec4 u_xlat10_5;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat10_0 + u_xlat10_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + (-_MainTex_TexelSize.xy);
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat2 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat2.xy);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat2.zw);
					    u_xlat16_2 = u_xlat10_2 + u_xlat10_3;
					    u_xlat16_1 = u_xlat10_1 + u_xlat10_3;
					    u_xlat3.xy = vs_TEXCOORD0.xy;
					    u_xlat3.xy = clamp(u_xlat3.xy, 0.0, 1.0);
					    u_xlat3.xy = u_xlat3.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat3.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_3;
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_5 = texture2D(_MainTex, u_xlat4.xy);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat4.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_5;
					    u_xlat16_5 = u_xlat10_3 + u_xlat10_5;
					    u_xlat16_1 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125);
					    u_xlat16_0 = u_xlat16_0 * vec4(0.125, 0.125, 0.125, 0.125) + u_xlat16_1;
					    u_xlat16_1 = u_xlat16_2 + u_xlat10_4;
					    u_xlat16_2 = u_xlat10_3 + u_xlat10_4;
					    u_xlat16_1 = u_xlat10_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat16_4 = u_xlat10_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat10_1 + u_xlat16_4;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + _MainTex_TexelSize.xy;
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = u_xlat10_1 + u_xlat16_2;
					    u_xlat16_1 = u_xlat10_3 + u_xlat16_1;
					    SV_Target0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec2 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					mediump vec4 u_xlat16_5;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + (-_MainTex_TexelSize.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat2 = min(max(u_xlat2, 0.0), 1.0);
					#else
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					#endif
					    u_xlat2 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat2.xy);
					    u_xlat16_2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat16_2 = u_xlat16_2 + u_xlat16_3;
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_3;
					    u_xlat3.xy = vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat3.xy = min(max(u_xlat3.xy, 0.0), 1.0);
					#else
					    u_xlat3.xy = clamp(u_xlat3.xy, 0.0, 1.0);
					#endif
					    u_xlat3.xy = u_xlat3.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat3.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_3;
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4 = min(max(u_xlat4, 0.0), 1.0);
					#else
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					#endif
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_5 = texture(_MainTex, u_xlat4.xy);
					    u_xlat16_4 = texture(_MainTex, u_xlat4.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_5;
					    u_xlat16_5 = u_xlat16_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125);
					    u_xlat16_0 = u_xlat16_0 * vec4(0.125, 0.125, 0.125, 0.125) + u_xlat16_1;
					    u_xlat16_1 = u_xlat16_2 + u_xlat16_4;
					    u_xlat16_2 = u_xlat16_3 + u_xlat16_4;
					    u_xlat16_1 = u_xlat16_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_4 = u_xlat16_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_4;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + _MainTex_TexelSize.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_2;
					    u_xlat16_1 = u_xlat16_3 + u_xlat16_1;
					    SV_Target0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec2 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					mediump vec4 u_xlat16_5;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + (-_MainTex_TexelSize.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat2 = min(max(u_xlat2, 0.0), 1.0);
					#else
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					#endif
					    u_xlat2 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat2.xy);
					    u_xlat16_2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat16_2 = u_xlat16_2 + u_xlat16_3;
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_3;
					    u_xlat3.xy = vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat3.xy = min(max(u_xlat3.xy, 0.0), 1.0);
					#else
					    u_xlat3.xy = clamp(u_xlat3.xy, 0.0, 1.0);
					#endif
					    u_xlat3.xy = u_xlat3.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat3.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_3;
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4 = min(max(u_xlat4, 0.0), 1.0);
					#else
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					#endif
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_5 = texture(_MainTex, u_xlat4.xy);
					    u_xlat16_4 = texture(_MainTex, u_xlat4.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_5;
					    u_xlat16_5 = u_xlat16_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125);
					    u_xlat16_0 = u_xlat16_0 * vec4(0.125, 0.125, 0.125, 0.125) + u_xlat16_1;
					    u_xlat16_1 = u_xlat16_2 + u_xlat16_4;
					    u_xlat16_2 = u_xlat16_3 + u_xlat16_4;
					    u_xlat16_1 = u_xlat16_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_4 = u_xlat16_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_4;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + _MainTex_TexelSize.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_2;
					    u_xlat16_1 = u_xlat16_3 + u_xlat16_1;
					    SV_Target0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec2 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					mediump vec4 u_xlat16_5;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + (-_MainTex_TexelSize.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat2 = _MainTex_TexelSize.xyxy * vec4(0.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat2 = min(max(u_xlat2, 0.0), 1.0);
					#else
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					#endif
					    u_xlat2 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat2.xy);
					    u_xlat16_2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat16_2 = u_xlat16_2 + u_xlat16_3;
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_3;
					    u_xlat3.xy = vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat3.xy = min(max(u_xlat3.xy, 0.0), 1.0);
					#else
					    u_xlat3.xy = clamp(u_xlat3.xy, 0.0, 1.0);
					#endif
					    u_xlat3.xy = u_xlat3.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat3.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_3;
					    u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4 = min(max(u_xlat4, 0.0), 1.0);
					#else
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					#endif
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_5 = texture(_MainTex, u_xlat4.xy);
					    u_xlat16_4 = texture(_MainTex, u_xlat4.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_5;
					    u_xlat16_5 = u_xlat16_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125);
					    u_xlat16_0 = u_xlat16_0 * vec4(0.125, 0.125, 0.125, 0.125) + u_xlat16_1;
					    u_xlat16_1 = u_xlat16_2 + u_xlat16_4;
					    u_xlat16_2 = u_xlat16_3 + u_xlat16_4;
					    u_xlat16_1 = u_xlat16_3 + u_xlat16_1;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_3 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_4 = u_xlat16_3 + u_xlat16_5;
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_4;
					    u_xlat16_0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
					    u_xlat1.xy = vs_TEXCOORD0.xy + _MainTex_TexelSize.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_2;
					    u_xlat16_1 = u_xlat16_3 + u_xlat16_1;
					    SV_Target0 = u_xlat16_1 * vec4(0.03125, 0.03125, 0.03125, 0.03125) + u_xlat16_0;
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
			}
		}
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 211309
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec4 u_xlat10_1;
					lowp vec4 u_xlat10_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat10_0 + u_xlat10_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    SV_Target0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25);
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec4 u_xlat10_1;
					lowp vec4 u_xlat10_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat10_0 + u_xlat10_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    SV_Target0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25);
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec4 u_xlat10_1;
					lowp vec4 u_xlat10_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat10_0 + u_xlat10_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    SV_Target0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25);
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					mediump vec4 u_xlat16_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    SV_Target0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25);
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					mediump vec4 u_xlat16_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    SV_Target0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25);
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					mediump vec4 u_xlat16_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1 = min(max(u_xlat1, 0.0), 1.0);
					#else
					    u_xlat1 = clamp(u_xlat1, 0.0, 1.0);
					#endif
					    u_xlat1 = u_xlat1 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    SV_Target0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25);
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
			}
		}
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 265764
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _BloomTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec4 u_xlat10_2;
					vec4 u_xlat3;
					mediump vec4 u_xlat16_3;
					lowp vec4 u_xlat10_3;
					vec4 u_xlat4;
					lowp vec4 u_xlat10_4;
					vec4 u_xlat5;
					lowp vec4 u_xlat10_5;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy;
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat1.x = 1.0;
					    u_xlat1.z = _SampleScale;
					    u_xlat1 = u_xlat1.xxzz * _MainTex_TexelSize.xyxy;
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.0);
					    u_xlat2.x = _SampleScale;
					    u_xlat3 = (-u_xlat1.xywy) * u_xlat2.xxwx + vs_TEXCOORD0.xyxy;
					    u_xlat3 = clamp(u_xlat3, 0.0, 1.0);
					    u_xlat3 = u_xlat3 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat3.xy);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat3.zw);
					    u_xlat16_3 = u_xlat10_3 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat10_4;
					    u_xlat4.xy = (-u_xlat1.zy) * u_xlat2.zx + vs_TEXCOORD0.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.xy = u_xlat4.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat4.xy);
					    u_xlat16_3 = u_xlat16_3 + u_xlat10_4;
					    u_xlat4 = u_xlat1.zwxw * u_xlat2.zwxw + vs_TEXCOORD0.xyxy;
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					    u_xlat5 = u_xlat1.zywy * u_xlat2.zxwx + vs_TEXCOORD0.xyxy;
					    u_xlat5 = clamp(u_xlat5, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * u_xlat2.xx + vs_TEXCOORD0.xy;
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat2 = u_xlat5 * vec4(_RenderViewportScaleFactor);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_5 = texture2D(_MainTex, u_xlat4.xy);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat4.zw);
					    u_xlat16_3 = u_xlat10_5 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_3;
					    u_xlat16_0 = u_xlat10_0 * vec4(4.0, 4.0, 4.0, 4.0) + u_xlat16_3;
					    u_xlat16_0 = u_xlat10_4 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_0;
					    u_xlat10_3 = texture2D(_MainTex, u_xlat2.xy);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat2.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_3;
					    u_xlat16_0 = u_xlat10_2 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_0;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    u_xlat10_1 = texture2D(_BloomTex, vs_TEXCOORD1.xy);
					    SV_Target0 = u_xlat16_0 * vec4(0.0625, 0.0625, 0.0625, 0.0625) + u_xlat10_1;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _BloomTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec4 u_xlat10_2;
					vec4 u_xlat3;
					mediump vec4 u_xlat16_3;
					lowp vec4 u_xlat10_3;
					vec4 u_xlat4;
					lowp vec4 u_xlat10_4;
					vec4 u_xlat5;
					lowp vec4 u_xlat10_5;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy;
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat1.x = 1.0;
					    u_xlat1.z = _SampleScale;
					    u_xlat1 = u_xlat1.xxzz * _MainTex_TexelSize.xyxy;
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.0);
					    u_xlat2.x = _SampleScale;
					    u_xlat3 = (-u_xlat1.xywy) * u_xlat2.xxwx + vs_TEXCOORD0.xyxy;
					    u_xlat3 = clamp(u_xlat3, 0.0, 1.0);
					    u_xlat3 = u_xlat3 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat3.xy);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat3.zw);
					    u_xlat16_3 = u_xlat10_3 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat10_4;
					    u_xlat4.xy = (-u_xlat1.zy) * u_xlat2.zx + vs_TEXCOORD0.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.xy = u_xlat4.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat4.xy);
					    u_xlat16_3 = u_xlat16_3 + u_xlat10_4;
					    u_xlat4 = u_xlat1.zwxw * u_xlat2.zwxw + vs_TEXCOORD0.xyxy;
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					    u_xlat5 = u_xlat1.zywy * u_xlat2.zxwx + vs_TEXCOORD0.xyxy;
					    u_xlat5 = clamp(u_xlat5, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * u_xlat2.xx + vs_TEXCOORD0.xy;
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat2 = u_xlat5 * vec4(_RenderViewportScaleFactor);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_5 = texture2D(_MainTex, u_xlat4.xy);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat4.zw);
					    u_xlat16_3 = u_xlat10_5 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_3;
					    u_xlat16_0 = u_xlat10_0 * vec4(4.0, 4.0, 4.0, 4.0) + u_xlat16_3;
					    u_xlat16_0 = u_xlat10_4 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_0;
					    u_xlat10_3 = texture2D(_MainTex, u_xlat2.xy);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat2.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_3;
					    u_xlat16_0 = u_xlat10_2 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_0;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    u_xlat10_1 = texture2D(_BloomTex, vs_TEXCOORD1.xy);
					    SV_Target0 = u_xlat16_0 * vec4(0.0625, 0.0625, 0.0625, 0.0625) + u_xlat10_1;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _BloomTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec4 u_xlat10_2;
					vec4 u_xlat3;
					mediump vec4 u_xlat16_3;
					lowp vec4 u_xlat10_3;
					vec4 u_xlat4;
					lowp vec4 u_xlat10_4;
					vec4 u_xlat5;
					lowp vec4 u_xlat10_5;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy;
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat1.x = 1.0;
					    u_xlat1.z = _SampleScale;
					    u_xlat1 = u_xlat1.xxzz * _MainTex_TexelSize.xyxy;
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.0);
					    u_xlat2.x = _SampleScale;
					    u_xlat3 = (-u_xlat1.xywy) * u_xlat2.xxwx + vs_TEXCOORD0.xyxy;
					    u_xlat3 = clamp(u_xlat3, 0.0, 1.0);
					    u_xlat3 = u_xlat3 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat3.xy);
					    u_xlat10_3 = texture2D(_MainTex, u_xlat3.zw);
					    u_xlat16_3 = u_xlat10_3 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat10_4;
					    u_xlat4.xy = (-u_xlat1.zy) * u_xlat2.zx + vs_TEXCOORD0.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.xy = u_xlat4.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat4.xy);
					    u_xlat16_3 = u_xlat16_3 + u_xlat10_4;
					    u_xlat4 = u_xlat1.zwxw * u_xlat2.zwxw + vs_TEXCOORD0.xyxy;
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					    u_xlat5 = u_xlat1.zywy * u_xlat2.zxwx + vs_TEXCOORD0.xyxy;
					    u_xlat5 = clamp(u_xlat5, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * u_xlat2.xx + vs_TEXCOORD0.xy;
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat2 = u_xlat5 * vec4(_RenderViewportScaleFactor);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_5 = texture2D(_MainTex, u_xlat4.xy);
					    u_xlat10_4 = texture2D(_MainTex, u_xlat4.zw);
					    u_xlat16_3 = u_xlat10_5 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_3;
					    u_xlat16_0 = u_xlat10_0 * vec4(4.0, 4.0, 4.0, 4.0) + u_xlat16_3;
					    u_xlat16_0 = u_xlat10_4 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_0;
					    u_xlat10_3 = texture2D(_MainTex, u_xlat2.xy);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat2.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat10_3;
					    u_xlat16_0 = u_xlat10_2 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_0;
					    u_xlat16_0 = u_xlat10_1 + u_xlat16_0;
					    u_xlat10_1 = texture2D(_BloomTex, vs_TEXCOORD1.xy);
					    SV_Target0 = u_xlat16_0 * vec4(0.0625, 0.0625, 0.0625, 0.0625) + u_xlat10_1;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _BloomTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec4 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					vec4 u_xlat5;
					mediump vec4 u_xlat16_5;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xy = min(max(u_xlat0.xy, 0.0), 1.0);
					#else
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					#endif
					    u_xlat0.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.xy);
					    u_xlat1.x = 1.0;
					    u_xlat1.z = _SampleScale;
					    u_xlat1 = u_xlat1.xxzz * _MainTex_TexelSize.xyxy;
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.0);
					    u_xlat2.x = _SampleScale;
					    u_xlat3 = (-u_xlat1.xywy) * u_xlat2.xxwx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat3 = min(max(u_xlat3, 0.0), 1.0);
					#else
					    u_xlat3 = clamp(u_xlat3, 0.0, 1.0);
					#endif
					    u_xlat3 = u_xlat3 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_4 = texture(_MainTex, u_xlat3.xy);
					    u_xlat16_3 = texture(_MainTex, u_xlat3.zw);
					    u_xlat16_3 = u_xlat16_3 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_4;
					    u_xlat4.xy = (-u_xlat1.zy) * u_xlat2.zx + vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.xy = u_xlat4.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_4 = texture(_MainTex, u_xlat4.xy);
					    u_xlat16_3 = u_xlat16_3 + u_xlat16_4;
					    u_xlat4 = u_xlat1.zwxw * u_xlat2.zwxw + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4 = min(max(u_xlat4, 0.0), 1.0);
					#else
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					#endif
					    u_xlat5 = u_xlat1.zywy * u_xlat2.zxwx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5 = min(max(u_xlat5, 0.0), 1.0);
					#else
					    u_xlat5 = clamp(u_xlat5, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * u_xlat2.xx + vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat2 = u_xlat5 * vec4(_RenderViewportScaleFactor);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_5 = texture(_MainTex, u_xlat4.xy);
					    u_xlat16_4 = texture(_MainTex, u_xlat4.zw);
					    u_xlat16_3 = u_xlat16_5 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_3;
					    u_xlat16_0 = u_xlat16_0 * vec4(4.0, 4.0, 4.0, 4.0) + u_xlat16_3;
					    u_xlat16_0 = u_xlat16_4 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_0;
					    u_xlat16_3 = texture(_MainTex, u_xlat2.xy);
					    u_xlat16_2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_3;
					    u_xlat16_0 = u_xlat16_2 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_0;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    u_xlat16_1 = texture(_BloomTex, vs_TEXCOORD1.xy);
					    SV_Target0 = u_xlat16_0 * vec4(0.0625, 0.0625, 0.0625, 0.0625) + u_xlat16_1;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _BloomTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec4 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					vec4 u_xlat5;
					mediump vec4 u_xlat16_5;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xy = min(max(u_xlat0.xy, 0.0), 1.0);
					#else
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					#endif
					    u_xlat0.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.xy);
					    u_xlat1.x = 1.0;
					    u_xlat1.z = _SampleScale;
					    u_xlat1 = u_xlat1.xxzz * _MainTex_TexelSize.xyxy;
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.0);
					    u_xlat2.x = _SampleScale;
					    u_xlat3 = (-u_xlat1.xywy) * u_xlat2.xxwx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat3 = min(max(u_xlat3, 0.0), 1.0);
					#else
					    u_xlat3 = clamp(u_xlat3, 0.0, 1.0);
					#endif
					    u_xlat3 = u_xlat3 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_4 = texture(_MainTex, u_xlat3.xy);
					    u_xlat16_3 = texture(_MainTex, u_xlat3.zw);
					    u_xlat16_3 = u_xlat16_3 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_4;
					    u_xlat4.xy = (-u_xlat1.zy) * u_xlat2.zx + vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.xy = u_xlat4.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_4 = texture(_MainTex, u_xlat4.xy);
					    u_xlat16_3 = u_xlat16_3 + u_xlat16_4;
					    u_xlat4 = u_xlat1.zwxw * u_xlat2.zwxw + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4 = min(max(u_xlat4, 0.0), 1.0);
					#else
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					#endif
					    u_xlat5 = u_xlat1.zywy * u_xlat2.zxwx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5 = min(max(u_xlat5, 0.0), 1.0);
					#else
					    u_xlat5 = clamp(u_xlat5, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * u_xlat2.xx + vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat2 = u_xlat5 * vec4(_RenderViewportScaleFactor);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_5 = texture(_MainTex, u_xlat4.xy);
					    u_xlat16_4 = texture(_MainTex, u_xlat4.zw);
					    u_xlat16_3 = u_xlat16_5 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_3;
					    u_xlat16_0 = u_xlat16_0 * vec4(4.0, 4.0, 4.0, 4.0) + u_xlat16_3;
					    u_xlat16_0 = u_xlat16_4 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_0;
					    u_xlat16_3 = texture(_MainTex, u_xlat2.xy);
					    u_xlat16_2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_3;
					    u_xlat16_0 = u_xlat16_2 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_0;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    u_xlat16_1 = texture(_BloomTex, vs_TEXCOORD1.xy);
					    SV_Target0 = u_xlat16_0 * vec4(0.0625, 0.0625, 0.0625, 0.0625) + u_xlat16_1;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _BloomTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec4 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					vec4 u_xlat5;
					mediump vec4 u_xlat16_5;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xy = min(max(u_xlat0.xy, 0.0), 1.0);
					#else
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					#endif
					    u_xlat0.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.xy);
					    u_xlat1.x = 1.0;
					    u_xlat1.z = _SampleScale;
					    u_xlat1 = u_xlat1.xxzz * _MainTex_TexelSize.xyxy;
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.0);
					    u_xlat2.x = _SampleScale;
					    u_xlat3 = (-u_xlat1.xywy) * u_xlat2.xxwx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat3 = min(max(u_xlat3, 0.0), 1.0);
					#else
					    u_xlat3 = clamp(u_xlat3, 0.0, 1.0);
					#endif
					    u_xlat3 = u_xlat3 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_4 = texture(_MainTex, u_xlat3.xy);
					    u_xlat16_3 = texture(_MainTex, u_xlat3.zw);
					    u_xlat16_3 = u_xlat16_3 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_4;
					    u_xlat4.xy = (-u_xlat1.zy) * u_xlat2.zx + vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.xy = u_xlat4.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_4 = texture(_MainTex, u_xlat4.xy);
					    u_xlat16_3 = u_xlat16_3 + u_xlat16_4;
					    u_xlat4 = u_xlat1.zwxw * u_xlat2.zwxw + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4 = min(max(u_xlat4, 0.0), 1.0);
					#else
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					#endif
					    u_xlat5 = u_xlat1.zywy * u_xlat2.zxwx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5 = min(max(u_xlat5, 0.0), 1.0);
					#else
					    u_xlat5 = clamp(u_xlat5, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * u_xlat2.xx + vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat2 = u_xlat5 * vec4(_RenderViewportScaleFactor);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_5 = texture(_MainTex, u_xlat4.xy);
					    u_xlat16_4 = texture(_MainTex, u_xlat4.zw);
					    u_xlat16_3 = u_xlat16_5 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_3;
					    u_xlat16_0 = u_xlat16_0 * vec4(4.0, 4.0, 4.0, 4.0) + u_xlat16_3;
					    u_xlat16_0 = u_xlat16_4 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_0;
					    u_xlat16_3 = texture(_MainTex, u_xlat2.xy);
					    u_xlat16_2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_3;
					    u_xlat16_0 = u_xlat16_2 * vec4(2.0, 2.0, 2.0, 2.0) + u_xlat16_0;
					    u_xlat16_0 = u_xlat16_1 + u_xlat16_0;
					    u_xlat16_1 = texture(_BloomTex, vs_TEXCOORD1.xy);
					    SV_Target0 = u_xlat16_0 * vec4(0.0625, 0.0625, 0.0625, 0.0625) + u_xlat16_1;
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
			}
		}
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 369434
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _BloomTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec4 u_xlat10_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, 1.0);
					    u_xlat1.x = _SampleScale * 0.5;
					    u_xlat2 = u_xlat0.xyzy * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat0 = u_xlat0.xwzw * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat1 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_1 = u_xlat10_1 + u_xlat10_2;
					    u_xlat10_2 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_0 + u_xlat16_1;
					    u_xlat10_1 = texture2D(_BloomTex, vs_TEXCOORD1.xy);
					    SV_Target0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25) + u_xlat10_1;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _BloomTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec4 u_xlat10_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, 1.0);
					    u_xlat1.x = _SampleScale * 0.5;
					    u_xlat2 = u_xlat0.xyzy * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat0 = u_xlat0.xwzw * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat1 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_1 = u_xlat10_1 + u_xlat10_2;
					    u_xlat10_2 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_0 + u_xlat16_1;
					    u_xlat10_1 = texture2D(_BloomTex, vs_TEXCOORD1.xy);
					    SV_Target0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25) + u_xlat10_1;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _BloomTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec4 u_xlat10_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, 1.0);
					    u_xlat1.x = _SampleScale * 0.5;
					    u_xlat2 = u_xlat0.xyzy * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat0 = u_xlat0.xwzw * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat1 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2 = texture2D(_MainTex, u_xlat1.xy);
					    u_xlat10_1 = texture2D(_MainTex, u_xlat1.zw);
					    u_xlat16_1 = u_xlat10_1 + u_xlat10_2;
					    u_xlat10_2 = texture2D(_MainTex, u_xlat0.xy);
					    u_xlat10_0 = texture2D(_MainTex, u_xlat0.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat10_2;
					    u_xlat16_0 = u_xlat10_0 + u_xlat16_1;
					    u_xlat10_1 = texture2D(_BloomTex, vs_TEXCOORD1.xy);
					    SV_Target0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25) + u_xlat10_1;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _BloomTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, 1.0);
					    u_xlat1.x = _SampleScale * 0.5;
					    u_xlat2 = u_xlat0.xyzy * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat2 = min(max(u_xlat2, 0.0), 1.0);
					#else
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0.xwzw * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat1 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_2;
					    u_xlat16_2 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat16_1 = texture(_BloomTex, vs_TEXCOORD1.xy);
					    SV_Target0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25) + u_xlat16_1;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _BloomTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, 1.0);
					    u_xlat1.x = _SampleScale * 0.5;
					    u_xlat2 = u_xlat0.xyzy * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat2 = min(max(u_xlat2, 0.0), 1.0);
					#else
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0.xwzw * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat1 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_2;
					    u_xlat16_2 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat16_1 = texture(_BloomTex, vs_TEXCOORD1.xy);
					    SV_Target0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25) + u_xlat16_1;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _BloomTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, 1.0);
					    u_xlat1.x = _SampleScale * 0.5;
					    u_xlat2 = u_xlat0.xyzy * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat2 = min(max(u_xlat2, 0.0), 1.0);
					#else
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0.xwzw * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat1 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat16_1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_2;
					    u_xlat16_2 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat16_1 = u_xlat16_1 + u_xlat16_2;
					    u_xlat16_0 = u_xlat16_0 + u_xlat16_1;
					    u_xlat16_1 = texture(_BloomTex, vs_TEXCOORD1.xy);
					    SV_Target0 = u_xlat16_0 * vec4(0.25, 0.25, 0.25, 0.25) + u_xlat16_1;
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
			}
		}
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 435568
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _AutoExposureTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec3 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					vec2 u_xlat1;
					float u_xlat5;
					float u_xlat6;
					lowp float u_xlat10_6;
					void main()
					{
					    u_xlat10_0.xyz = texture2D(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_0.xyz = min(u_xlat10_0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat10_6 = texture2D(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0.xyz = vec3(u_xlat10_6) * u_xlat16_0.xyz;
					    u_xlat0.xyz = min(u_xlat16_0.xyz, _Params.xxx);
					    u_xlat6 = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6 = max(u_xlat0.z, u_xlat6);
					    u_xlat1.xy = vec2(u_xlat6) + (-_Threshold.yx);
					    u_xlat6 = max(u_xlat6, 9.99999975e-05);
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = min(u_xlat1.x, _Threshold.z);
					    u_xlat5 = u_xlat1.x * _Threshold.w;
					    u_xlat1.x = u_xlat1.x * u_xlat5;
					    u_xlat1.x = max(u_xlat1.y, u_xlat1.x);
					    u_xlat6 = u_xlat1.x / u_xlat6;
					    SV_Target0.xyz = vec3(u_xlat6) * u_xlat0.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _AutoExposureTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec3 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					vec2 u_xlat1;
					float u_xlat5;
					float u_xlat6;
					lowp float u_xlat10_6;
					void main()
					{
					    u_xlat10_0.xyz = texture2D(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_0.xyz = min(u_xlat10_0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat10_6 = texture2D(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0.xyz = vec3(u_xlat10_6) * u_xlat16_0.xyz;
					    u_xlat0.xyz = min(u_xlat16_0.xyz, _Params.xxx);
					    u_xlat6 = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6 = max(u_xlat0.z, u_xlat6);
					    u_xlat1.xy = vec2(u_xlat6) + (-_Threshold.yx);
					    u_xlat6 = max(u_xlat6, 9.99999975e-05);
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = min(u_xlat1.x, _Threshold.z);
					    u_xlat5 = u_xlat1.x * _Threshold.w;
					    u_xlat1.x = u_xlat1.x * u_xlat5;
					    u_xlat1.x = max(u_xlat1.y, u_xlat1.x);
					    u_xlat6 = u_xlat1.x / u_xlat6;
					    SV_Target0.xyz = vec3(u_xlat6) * u_xlat0.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _AutoExposureTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec3 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					vec2 u_xlat1;
					float u_xlat5;
					float u_xlat6;
					lowp float u_xlat10_6;
					void main()
					{
					    u_xlat10_0.xyz = texture2D(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_0.xyz = min(u_xlat10_0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat10_6 = texture2D(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0.xyz = vec3(u_xlat10_6) * u_xlat16_0.xyz;
					    u_xlat0.xyz = min(u_xlat16_0.xyz, _Params.xxx);
					    u_xlat6 = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6 = max(u_xlat0.z, u_xlat6);
					    u_xlat1.xy = vec2(u_xlat6) + (-_Threshold.yx);
					    u_xlat6 = max(u_xlat6, 9.99999975e-05);
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = min(u_xlat1.x, _Threshold.z);
					    u_xlat5 = u_xlat1.x * _Threshold.w;
					    u_xlat1.x = u_xlat1.x * u_xlat5;
					    u_xlat1.x = max(u_xlat1.y, u_xlat1.x);
					    u_xlat6 = u_xlat1.x / u_xlat6;
					    SV_Target0.xyz = vec3(u_xlat6) * u_xlat0.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _AutoExposureTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec3 u_xlat0;
					mediump vec3 u_xlat16_0;
					vec2 u_xlat1;
					float u_xlat5;
					float u_xlat6;
					mediump float u_xlat16_6;
					void main()
					{
					    u_xlat16_0.xyz = texture(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_0.xyz = min(u_xlat16_0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat16_6 = texture(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0.xyz = vec3(u_xlat16_6) * u_xlat16_0.xyz;
					    u_xlat0.xyz = min(u_xlat16_0.xyz, _Params.xxx);
					    u_xlat6 = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6 = max(u_xlat0.z, u_xlat6);
					    u_xlat1.xy = vec2(u_xlat6) + (-_Threshold.yx);
					    u_xlat6 = max(u_xlat6, 9.99999975e-05);
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = min(u_xlat1.x, _Threshold.z);
					    u_xlat5 = u_xlat1.x * _Threshold.w;
					    u_xlat1.x = u_xlat1.x * u_xlat5;
					    u_xlat1.x = max(u_xlat1.y, u_xlat1.x);
					    u_xlat6 = u_xlat1.x / u_xlat6;
					    SV_Target0.xyz = vec3(u_xlat6) * u_xlat0.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _AutoExposureTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec3 u_xlat0;
					mediump vec3 u_xlat16_0;
					vec2 u_xlat1;
					float u_xlat5;
					float u_xlat6;
					mediump float u_xlat16_6;
					void main()
					{
					    u_xlat16_0.xyz = texture(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_0.xyz = min(u_xlat16_0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat16_6 = texture(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0.xyz = vec3(u_xlat16_6) * u_xlat16_0.xyz;
					    u_xlat0.xyz = min(u_xlat16_0.xyz, _Params.xxx);
					    u_xlat6 = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6 = max(u_xlat0.z, u_xlat6);
					    u_xlat1.xy = vec2(u_xlat6) + (-_Threshold.yx);
					    u_xlat6 = max(u_xlat6, 9.99999975e-05);
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = min(u_xlat1.x, _Threshold.z);
					    u_xlat5 = u_xlat1.x * _Threshold.w;
					    u_xlat1.x = u_xlat1.x * u_xlat5;
					    u_xlat1.x = max(u_xlat1.y, u_xlat1.x);
					    u_xlat6 = u_xlat1.x / u_xlat6;
					    SV_Target0.xyz = vec3(u_xlat6) * u_xlat0.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Threshold;
					uniform 	vec4 _Params;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _AutoExposureTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec3 u_xlat0;
					mediump vec3 u_xlat16_0;
					vec2 u_xlat1;
					float u_xlat5;
					float u_xlat6;
					mediump float u_xlat16_6;
					void main()
					{
					    u_xlat16_0.xyz = texture(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_0.xyz = min(u_xlat16_0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat16_6 = texture(_AutoExposureTex, vs_TEXCOORD0.xy).x;
					    u_xlat16_0.xyz = vec3(u_xlat16_6) * u_xlat16_0.xyz;
					    u_xlat0.xyz = min(u_xlat16_0.xyz, _Params.xxx);
					    u_xlat6 = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6 = max(u_xlat0.z, u_xlat6);
					    u_xlat1.xy = vec2(u_xlat6) + (-_Threshold.yx);
					    u_xlat6 = max(u_xlat6, 9.99999975e-05);
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = min(u_xlat1.x, _Threshold.z);
					    u_xlat5 = u_xlat1.x * _Threshold.w;
					    u_xlat1.x = u_xlat1.x * u_xlat5;
					    u_xlat1.x = max(u_xlat1.y, u_xlat1.x);
					    u_xlat6 = u_xlat1.x / u_xlat6;
					    SV_Target0.xyz = vec3(u_xlat6) * u_xlat0.xyz;
					    SV_Target0.w = 1.0;
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
			}
		}
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 496315
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform 	vec4 _ColorIntensity;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec3 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec3 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec3 u_xlat10_2;
					vec4 u_xlat3;
					mediump vec3 u_xlat16_3;
					lowp vec3 u_xlat10_3;
					vec4 u_xlat4;
					lowp vec3 u_xlat10_4;
					vec4 u_xlat5;
					lowp vec3 u_xlat10_5;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy;
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_0.xyz = texture2D(_MainTex, u_xlat0.xy).xyz;
					    u_xlat1.x = 1.0;
					    u_xlat1.z = _SampleScale;
					    u_xlat1 = u_xlat1.xxzz * _MainTex_TexelSize.xyxy;
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.0);
					    u_xlat2.x = _SampleScale;
					    u_xlat3 = (-u_xlat1.xywy) * u_xlat2.xxwx + vs_TEXCOORD0.xyxy;
					    u_xlat3 = clamp(u_xlat3, 0.0, 1.0);
					    u_xlat3 = u_xlat3 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_4.xyz = texture2D(_MainTex, u_xlat3.xy).xyz;
					    u_xlat10_3.xyz = texture2D(_MainTex, u_xlat3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_3.xyz * vec3(2.0, 2.0, 2.0) + u_xlat10_4.xyz;
					    u_xlat4.xy = (-u_xlat1.zy) * u_xlat2.zx + vs_TEXCOORD0.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.xy = u_xlat4.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_4.xyz = texture2D(_MainTex, u_xlat4.xy).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + u_xlat10_4.xyz;
					    u_xlat4 = u_xlat1.zwxw * u_xlat2.zwxw + vs_TEXCOORD0.xyxy;
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					    u_xlat5 = u_xlat1.zywy * u_xlat2.zxwx + vs_TEXCOORD0.xyxy;
					    u_xlat5 = clamp(u_xlat5, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * u_xlat2.xx + vs_TEXCOORD0.xy;
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1.xyz = texture2D(_MainTex, u_xlat1.xy).xyz;
					    u_xlat2 = u_xlat5 * vec4(_RenderViewportScaleFactor);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_5.xyz = texture2D(_MainTex, u_xlat4.xy).xyz;
					    u_xlat10_4.xyz = texture2D(_MainTex, u_xlat4.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_5.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz * vec3(4.0, 4.0, 4.0) + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat10_4.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_0.xyz;
					    u_xlat10_3.xyz = texture2D(_MainTex, u_xlat2.xy).xyz;
					    u_xlat10_2.xyz = texture2D(_MainTex, u_xlat2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + u_xlat10_3.xyz;
					    u_xlat16_0.xyz = u_xlat10_2.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_0.xyz;
					    u_xlat16_0.xyz = u_xlat10_1.xyz + u_xlat16_0.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(0.0625, 0.0625, 0.0625);
					    u_xlat0.xyz = u_xlat16_0.xyz * _ColorIntensity.www;
					    SV_Target0.xyz = u_xlat0.xyz * _ColorIntensity.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform 	vec4 _ColorIntensity;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec3 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec3 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec3 u_xlat10_2;
					vec4 u_xlat3;
					mediump vec3 u_xlat16_3;
					lowp vec3 u_xlat10_3;
					vec4 u_xlat4;
					lowp vec3 u_xlat10_4;
					vec4 u_xlat5;
					lowp vec3 u_xlat10_5;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy;
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_0.xyz = texture2D(_MainTex, u_xlat0.xy).xyz;
					    u_xlat1.x = 1.0;
					    u_xlat1.z = _SampleScale;
					    u_xlat1 = u_xlat1.xxzz * _MainTex_TexelSize.xyxy;
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.0);
					    u_xlat2.x = _SampleScale;
					    u_xlat3 = (-u_xlat1.xywy) * u_xlat2.xxwx + vs_TEXCOORD0.xyxy;
					    u_xlat3 = clamp(u_xlat3, 0.0, 1.0);
					    u_xlat3 = u_xlat3 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_4.xyz = texture2D(_MainTex, u_xlat3.xy).xyz;
					    u_xlat10_3.xyz = texture2D(_MainTex, u_xlat3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_3.xyz * vec3(2.0, 2.0, 2.0) + u_xlat10_4.xyz;
					    u_xlat4.xy = (-u_xlat1.zy) * u_xlat2.zx + vs_TEXCOORD0.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.xy = u_xlat4.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_4.xyz = texture2D(_MainTex, u_xlat4.xy).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + u_xlat10_4.xyz;
					    u_xlat4 = u_xlat1.zwxw * u_xlat2.zwxw + vs_TEXCOORD0.xyxy;
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					    u_xlat5 = u_xlat1.zywy * u_xlat2.zxwx + vs_TEXCOORD0.xyxy;
					    u_xlat5 = clamp(u_xlat5, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * u_xlat2.xx + vs_TEXCOORD0.xy;
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1.xyz = texture2D(_MainTex, u_xlat1.xy).xyz;
					    u_xlat2 = u_xlat5 * vec4(_RenderViewportScaleFactor);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_5.xyz = texture2D(_MainTex, u_xlat4.xy).xyz;
					    u_xlat10_4.xyz = texture2D(_MainTex, u_xlat4.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_5.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz * vec3(4.0, 4.0, 4.0) + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat10_4.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_0.xyz;
					    u_xlat10_3.xyz = texture2D(_MainTex, u_xlat2.xy).xyz;
					    u_xlat10_2.xyz = texture2D(_MainTex, u_xlat2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + u_xlat10_3.xyz;
					    u_xlat16_0.xyz = u_xlat10_2.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_0.xyz;
					    u_xlat16_0.xyz = u_xlat10_1.xyz + u_xlat16_0.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(0.0625, 0.0625, 0.0625);
					    u_xlat0.xyz = u_xlat16_0.xyz * _ColorIntensity.www;
					    SV_Target0.xyz = u_xlat0.xyz * _ColorIntensity.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform 	vec4 _ColorIntensity;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec3 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec3 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec3 u_xlat10_2;
					vec4 u_xlat3;
					mediump vec3 u_xlat16_3;
					lowp vec3 u_xlat10_3;
					vec4 u_xlat4;
					lowp vec3 u_xlat10_4;
					vec4 u_xlat5;
					lowp vec3 u_xlat10_5;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy;
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_0.xyz = texture2D(_MainTex, u_xlat0.xy).xyz;
					    u_xlat1.x = 1.0;
					    u_xlat1.z = _SampleScale;
					    u_xlat1 = u_xlat1.xxzz * _MainTex_TexelSize.xyxy;
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.0);
					    u_xlat2.x = _SampleScale;
					    u_xlat3 = (-u_xlat1.xywy) * u_xlat2.xxwx + vs_TEXCOORD0.xyxy;
					    u_xlat3 = clamp(u_xlat3, 0.0, 1.0);
					    u_xlat3 = u_xlat3 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_4.xyz = texture2D(_MainTex, u_xlat3.xy).xyz;
					    u_xlat10_3.xyz = texture2D(_MainTex, u_xlat3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_3.xyz * vec3(2.0, 2.0, 2.0) + u_xlat10_4.xyz;
					    u_xlat4.xy = (-u_xlat1.zy) * u_xlat2.zx + vs_TEXCOORD0.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.xy = u_xlat4.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_4.xyz = texture2D(_MainTex, u_xlat4.xy).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + u_xlat10_4.xyz;
					    u_xlat4 = u_xlat1.zwxw * u_xlat2.zwxw + vs_TEXCOORD0.xyxy;
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					    u_xlat5 = u_xlat1.zywy * u_xlat2.zxwx + vs_TEXCOORD0.xyxy;
					    u_xlat5 = clamp(u_xlat5, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * u_xlat2.xx + vs_TEXCOORD0.xy;
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat10_1.xyz = texture2D(_MainTex, u_xlat1.xy).xyz;
					    u_xlat2 = u_xlat5 * vec4(_RenderViewportScaleFactor);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_5.xyz = texture2D(_MainTex, u_xlat4.xy).xyz;
					    u_xlat10_4.xyz = texture2D(_MainTex, u_xlat4.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_5.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz * vec3(4.0, 4.0, 4.0) + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat10_4.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_0.xyz;
					    u_xlat10_3.xyz = texture2D(_MainTex, u_xlat2.xy).xyz;
					    u_xlat10_2.xyz = texture2D(_MainTex, u_xlat2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + u_xlat10_3.xyz;
					    u_xlat16_0.xyz = u_xlat10_2.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_0.xyz;
					    u_xlat16_0.xyz = u_xlat10_1.xyz + u_xlat16_0.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(0.0625, 0.0625, 0.0625);
					    u_xlat0.xyz = u_xlat16_0.xyz * _ColorIntensity.www;
					    SV_Target0.xyz = u_xlat0.xyz * _ColorIntensity.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform 	vec4 _ColorIntensity;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec3 u_xlat0;
					mediump vec3 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec3 u_xlat16_2;
					vec4 u_xlat3;
					mediump vec3 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec3 u_xlat16_4;
					vec4 u_xlat5;
					mediump vec3 u_xlat16_5;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xy = min(max(u_xlat0.xy, 0.0), 1.0);
					#else
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					#endif
					    u_xlat0.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_0.xyz = texture(_MainTex, u_xlat0.xy).xyz;
					    u_xlat1.x = 1.0;
					    u_xlat1.z = _SampleScale;
					    u_xlat1 = u_xlat1.xxzz * _MainTex_TexelSize.xyxy;
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.0);
					    u_xlat2.x = _SampleScale;
					    u_xlat3 = (-u_xlat1.xywy) * u_xlat2.xxwx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat3 = min(max(u_xlat3, 0.0), 1.0);
					#else
					    u_xlat3 = clamp(u_xlat3, 0.0, 1.0);
					#endif
					    u_xlat3 = u_xlat3 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_4.xyz = texture(_MainTex, u_xlat3.xy).xyz;
					    u_xlat16_3.xyz = texture(_MainTex, u_xlat3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_4.xyz;
					    u_xlat4.xy = (-u_xlat1.zy) * u_xlat2.zx + vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.xy = u_xlat4.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_4.xyz = texture(_MainTex, u_xlat4.xy).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + u_xlat16_4.xyz;
					    u_xlat4 = u_xlat1.zwxw * u_xlat2.zwxw + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4 = min(max(u_xlat4, 0.0), 1.0);
					#else
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					#endif
					    u_xlat5 = u_xlat1.zywy * u_xlat2.zxwx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5 = min(max(u_xlat5, 0.0), 1.0);
					#else
					    u_xlat5 = clamp(u_xlat5, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * u_xlat2.xx + vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1.xyz = texture(_MainTex, u_xlat1.xy).xyz;
					    u_xlat2 = u_xlat5 * vec4(_RenderViewportScaleFactor);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_5.xyz = texture(_MainTex, u_xlat4.xy).xyz;
					    u_xlat16_4.xyz = texture(_MainTex, u_xlat4.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_5.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(4.0, 4.0, 4.0) + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat16_4.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_0.xyz;
					    u_xlat16_3.xyz = texture(_MainTex, u_xlat2.xy).xyz;
					    u_xlat16_2.xyz = texture(_MainTex, u_xlat2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat16_2.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_0.xyz;
					    u_xlat16_0.xyz = u_xlat16_1.xyz + u_xlat16_0.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(0.0625, 0.0625, 0.0625);
					    u_xlat0.xyz = u_xlat16_0.xyz * _ColorIntensity.www;
					    SV_Target0.xyz = u_xlat0.xyz * _ColorIntensity.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform 	vec4 _ColorIntensity;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec3 u_xlat0;
					mediump vec3 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec3 u_xlat16_2;
					vec4 u_xlat3;
					mediump vec3 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec3 u_xlat16_4;
					vec4 u_xlat5;
					mediump vec3 u_xlat16_5;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xy = min(max(u_xlat0.xy, 0.0), 1.0);
					#else
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					#endif
					    u_xlat0.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_0.xyz = texture(_MainTex, u_xlat0.xy).xyz;
					    u_xlat1.x = 1.0;
					    u_xlat1.z = _SampleScale;
					    u_xlat1 = u_xlat1.xxzz * _MainTex_TexelSize.xyxy;
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.0);
					    u_xlat2.x = _SampleScale;
					    u_xlat3 = (-u_xlat1.xywy) * u_xlat2.xxwx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat3 = min(max(u_xlat3, 0.0), 1.0);
					#else
					    u_xlat3 = clamp(u_xlat3, 0.0, 1.0);
					#endif
					    u_xlat3 = u_xlat3 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_4.xyz = texture(_MainTex, u_xlat3.xy).xyz;
					    u_xlat16_3.xyz = texture(_MainTex, u_xlat3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_4.xyz;
					    u_xlat4.xy = (-u_xlat1.zy) * u_xlat2.zx + vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.xy = u_xlat4.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_4.xyz = texture(_MainTex, u_xlat4.xy).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + u_xlat16_4.xyz;
					    u_xlat4 = u_xlat1.zwxw * u_xlat2.zwxw + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4 = min(max(u_xlat4, 0.0), 1.0);
					#else
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					#endif
					    u_xlat5 = u_xlat1.zywy * u_xlat2.zxwx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5 = min(max(u_xlat5, 0.0), 1.0);
					#else
					    u_xlat5 = clamp(u_xlat5, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * u_xlat2.xx + vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1.xyz = texture(_MainTex, u_xlat1.xy).xyz;
					    u_xlat2 = u_xlat5 * vec4(_RenderViewportScaleFactor);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_5.xyz = texture(_MainTex, u_xlat4.xy).xyz;
					    u_xlat16_4.xyz = texture(_MainTex, u_xlat4.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_5.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(4.0, 4.0, 4.0) + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat16_4.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_0.xyz;
					    u_xlat16_3.xyz = texture(_MainTex, u_xlat2.xy).xyz;
					    u_xlat16_2.xyz = texture(_MainTex, u_xlat2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat16_2.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_0.xyz;
					    u_xlat16_0.xyz = u_xlat16_1.xyz + u_xlat16_0.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(0.0625, 0.0625, 0.0625);
					    u_xlat0.xyz = u_xlat16_0.xyz * _ColorIntensity.www;
					    SV_Target0.xyz = u_xlat0.xyz * _ColorIntensity.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform 	vec4 _ColorIntensity;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec3 u_xlat0;
					mediump vec3 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec3 u_xlat16_2;
					vec4 u_xlat3;
					mediump vec3 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec3 u_xlat16_4;
					vec4 u_xlat5;
					mediump vec3 u_xlat16_5;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xy = min(max(u_xlat0.xy, 0.0), 1.0);
					#else
					    u_xlat0.xy = clamp(u_xlat0.xy, 0.0, 1.0);
					#endif
					    u_xlat0.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_0.xyz = texture(_MainTex, u_xlat0.xy).xyz;
					    u_xlat1.x = 1.0;
					    u_xlat1.z = _SampleScale;
					    u_xlat1 = u_xlat1.xxzz * _MainTex_TexelSize.xyxy;
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.0);
					    u_xlat2.x = _SampleScale;
					    u_xlat3 = (-u_xlat1.xywy) * u_xlat2.xxwx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat3 = min(max(u_xlat3, 0.0), 1.0);
					#else
					    u_xlat3 = clamp(u_xlat3, 0.0, 1.0);
					#endif
					    u_xlat3 = u_xlat3 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_4.xyz = texture(_MainTex, u_xlat3.xy).xyz;
					    u_xlat16_3.xyz = texture(_MainTex, u_xlat3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_4.xyz;
					    u_xlat4.xy = (-u_xlat1.zy) * u_xlat2.zx + vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.xy = u_xlat4.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_4.xyz = texture(_MainTex, u_xlat4.xy).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + u_xlat16_4.xyz;
					    u_xlat4 = u_xlat1.zwxw * u_xlat2.zwxw + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4 = min(max(u_xlat4, 0.0), 1.0);
					#else
					    u_xlat4 = clamp(u_xlat4, 0.0, 1.0);
					#endif
					    u_xlat5 = u_xlat1.zywy * u_xlat2.zxwx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5 = min(max(u_xlat5, 0.0), 1.0);
					#else
					    u_xlat5 = clamp(u_xlat5, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * u_xlat2.xx + vs_TEXCOORD0.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xy = min(max(u_xlat1.xy, 0.0), 1.0);
					#else
					    u_xlat1.xy = clamp(u_xlat1.xy, 0.0, 1.0);
					#endif
					    u_xlat1.xy = u_xlat1.xy * vec2(_RenderViewportScaleFactor);
					    u_xlat16_1.xyz = texture(_MainTex, u_xlat1.xy).xyz;
					    u_xlat2 = u_xlat5 * vec4(_RenderViewportScaleFactor);
					    u_xlat4 = u_xlat4 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_5.xyz = texture(_MainTex, u_xlat4.xy).xyz;
					    u_xlat16_4.xyz = texture(_MainTex, u_xlat4.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_5.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(4.0, 4.0, 4.0) + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat16_4.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_0.xyz;
					    u_xlat16_3.xyz = texture(_MainTex, u_xlat2.xy).xyz;
					    u_xlat16_2.xyz = texture(_MainTex, u_xlat2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + u_xlat16_3.xyz;
					    u_xlat16_0.xyz = u_xlat16_2.xyz * vec3(2.0, 2.0, 2.0) + u_xlat16_0.xyz;
					    u_xlat16_0.xyz = u_xlat16_1.xyz + u_xlat16_0.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(0.0625, 0.0625, 0.0625);
					    u_xlat0.xyz = u_xlat16_0.xyz * _ColorIntensity.www;
					    SV_Target0.xyz = u_xlat0.xyz * _ColorIntensity.xyz;
					    SV_Target0.w = 1.0;
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
			}
		}
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 566604
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform 	vec4 _ColorIntensity;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec3 u_xlat16_1;
					lowp vec3 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec3 u_xlat10_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, 1.0);
					    u_xlat1.x = _SampleScale * 0.5;
					    u_xlat2 = u_xlat0.xyzy * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat0 = u_xlat0.xwzw * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat1 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2.xyz = texture2D(_MainTex, u_xlat1.xy).xyz;
					    u_xlat10_1.xyz = texture2D(_MainTex, u_xlat1.zw).xyz;
					    u_xlat16_1.xyz = u_xlat10_1.xyz + u_xlat10_2.xyz;
					    u_xlat10_2.xyz = texture2D(_MainTex, u_xlat0.xy).xyz;
					    u_xlat10_0.xyz = texture2D(_MainTex, u_xlat0.zw).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + u_xlat10_2.xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz + u_xlat16_1.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(0.25, 0.25, 0.25);
					    u_xlat0.xyz = u_xlat16_0.xyz * _ColorIntensity.www;
					    SV_Target0.xyz = u_xlat0.xyz * _ColorIntensity.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform 	vec4 _ColorIntensity;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec3 u_xlat16_1;
					lowp vec3 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec3 u_xlat10_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, 1.0);
					    u_xlat1.x = _SampleScale * 0.5;
					    u_xlat2 = u_xlat0.xyzy * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat0 = u_xlat0.xwzw * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat1 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2.xyz = texture2D(_MainTex, u_xlat1.xy).xyz;
					    u_xlat10_1.xyz = texture2D(_MainTex, u_xlat1.zw).xyz;
					    u_xlat16_1.xyz = u_xlat10_1.xyz + u_xlat10_2.xyz;
					    u_xlat10_2.xyz = texture2D(_MainTex, u_xlat0.xy).xyz;
					    u_xlat10_0.xyz = texture2D(_MainTex, u_xlat0.zw).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + u_xlat10_2.xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz + u_xlat16_1.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(0.25, 0.25, 0.25);
					    u_xlat0.xyz = u_xlat16_0.xyz * _ColorIntensity.www;
					    SV_Target0.xyz = u_xlat0.xyz * _ColorIntensity.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	float _RenderViewportScaleFactor;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform 	vec4 _ColorIntensity;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					vec4 u_xlat1;
					mediump vec3 u_xlat16_1;
					lowp vec3 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec3 u_xlat10_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, 1.0);
					    u_xlat1.x = _SampleScale * 0.5;
					    u_xlat2 = u_xlat0.xyzy * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					    u_xlat0 = u_xlat0.xwzw * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat1 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat10_2.xyz = texture2D(_MainTex, u_xlat1.xy).xyz;
					    u_xlat10_1.xyz = texture2D(_MainTex, u_xlat1.zw).xyz;
					    u_xlat16_1.xyz = u_xlat10_1.xyz + u_xlat10_2.xyz;
					    u_xlat10_2.xyz = texture2D(_MainTex, u_xlat0.xy).xyz;
					    u_xlat10_0.xyz = texture2D(_MainTex, u_xlat0.zw).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + u_xlat10_2.xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz + u_xlat16_1.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(0.25, 0.25, 0.25);
					    u_xlat0.xyz = u_xlat16_0.xyz * _ColorIntensity.www;
					    SV_Target0.xyz = u_xlat0.xyz * _ColorIntensity.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform 	vec4 _ColorIntensity;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec3 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec3 u_xlat16_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, 1.0);
					    u_xlat1.x = _SampleScale * 0.5;
					    u_xlat2 = u_xlat0.xyzy * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat2 = min(max(u_xlat2, 0.0), 1.0);
					#else
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0.xwzw * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat1 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2.xyz = texture(_MainTex, u_xlat1.xy).xyz;
					    u_xlat16_1.xyz = texture(_MainTex, u_xlat1.zw).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + u_xlat16_2.xyz;
					    u_xlat16_2.xyz = texture(_MainTex, u_xlat0.xy).xyz;
					    u_xlat16_0.xyz = texture(_MainTex, u_xlat0.zw).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + u_xlat16_2.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + u_xlat16_1.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(0.25, 0.25, 0.25);
					    u_xlat0.xyz = u_xlat16_0.xyz * _ColorIntensity.www;
					    SV_Target0.xyz = u_xlat0.xyz * _ColorIntensity.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform 	vec4 _ColorIntensity;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec3 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec3 u_xlat16_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, 1.0);
					    u_xlat1.x = _SampleScale * 0.5;
					    u_xlat2 = u_xlat0.xyzy * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat2 = min(max(u_xlat2, 0.0), 1.0);
					#else
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0.xwzw * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat1 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2.xyz = texture(_MainTex, u_xlat1.xy).xyz;
					    u_xlat16_1.xyz = texture(_MainTex, u_xlat1.zw).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + u_xlat16_2.xyz;
					    u_xlat16_2.xyz = texture(_MainTex, u_xlat0.xy).xyz;
					    u_xlat16_0.xyz = texture(_MainTex, u_xlat0.zw).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + u_xlat16_2.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + u_xlat16_1.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(0.25, 0.25, 0.25);
					    u_xlat0.xyz = u_xlat16_0.xyz * _ColorIntensity.www;
					    SV_Target0.xyz = u_xlat0.xyz * _ColorIntensity.xyz;
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	float _RenderViewportScaleFactor;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.xy * vec2(_RenderViewportScaleFactor);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform 	float _RenderViewportScaleFactor;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _SampleScale;
					uniform 	vec4 _ColorIntensity;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec3 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec3 u_xlat16_2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, 1.0);
					    u_xlat1.x = _SampleScale * 0.5;
					    u_xlat2 = u_xlat0.xyzy * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat2 = min(max(u_xlat2, 0.0), 1.0);
					#else
					    u_xlat2 = clamp(u_xlat2, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0.xwzw * u_xlat1.xxxx + vs_TEXCOORD0.xyxy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0 = min(max(u_xlat0, 0.0), 1.0);
					#else
					    u_xlat0 = clamp(u_xlat0, 0.0, 1.0);
					#endif
					    u_xlat0 = u_xlat0 * vec4(_RenderViewportScaleFactor);
					    u_xlat1 = u_xlat2 * vec4(_RenderViewportScaleFactor);
					    u_xlat16_2.xyz = texture(_MainTex, u_xlat1.xy).xyz;
					    u_xlat16_1.xyz = texture(_MainTex, u_xlat1.zw).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + u_xlat16_2.xyz;
					    u_xlat16_2.xyz = texture(_MainTex, u_xlat0.xy).xyz;
					    u_xlat16_0.xyz = texture(_MainTex, u_xlat0.zw).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + u_xlat16_2.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + u_xlat16_1.xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz * vec3(0.25, 0.25, 0.25);
					    u_xlat0.xyz = u_xlat16_0.xyz * _ColorIntensity.www;
					    SV_Target0.xyz = u_xlat0.xyz * _ColorIntensity.xyz;
					    SV_Target0.w = 1.0;
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
			}
		}
	}
}