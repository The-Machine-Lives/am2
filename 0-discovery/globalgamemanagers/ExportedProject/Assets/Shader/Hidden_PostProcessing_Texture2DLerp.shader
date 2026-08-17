Shader "Hidden/PostProcessing/Texture2DLerp" {
	Properties {
	}
	SubShader {
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 50133
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
					uniform 	float _Interp;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _To;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					lowp vec4 u_xlat10_1;
					void main()
					{
					    u_xlat10_0 = texture2D(_To, vs_TEXCOORD0.xy);
					    u_xlat10_1 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + (-u_xlat10_1);
					    SV_Target0 = vec4(_Interp) * u_xlat16_0 + u_xlat10_1;
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
					uniform 	float _Interp;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _To;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					lowp vec4 u_xlat10_1;
					void main()
					{
					    u_xlat10_0 = texture2D(_To, vs_TEXCOORD0.xy);
					    u_xlat10_1 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + (-u_xlat10_1);
					    SV_Target0 = vec4(_Interp) * u_xlat16_0 + u_xlat10_1;
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
					uniform 	float _Interp;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _To;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					mediump vec4 u_xlat16_0;
					lowp vec4 u_xlat10_0;
					lowp vec4 u_xlat10_1;
					void main()
					{
					    u_xlat10_0 = texture2D(_To, vs_TEXCOORD0.xy);
					    u_xlat10_1 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat10_0 + (-u_xlat10_1);
					    SV_Target0 = vec4(_Interp) * u_xlat16_0 + u_xlat10_1;
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
					uniform 	float _Interp;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _To;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					mediump vec4 u_xlat16_1;
					void main()
					{
					    u_xlat16_0 = texture(_To, vs_TEXCOORD0.xy);
					    u_xlat16_1 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + (-u_xlat16_1);
					    SV_Target0 = vec4(_Interp) * u_xlat16_0 + u_xlat16_1;
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
					uniform 	float _Interp;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _To;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					mediump vec4 u_xlat16_1;
					void main()
					{
					    u_xlat16_0 = texture(_To, vs_TEXCOORD0.xy);
					    u_xlat16_1 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + (-u_xlat16_1);
					    SV_Target0 = vec4(_Interp) * u_xlat16_0 + u_xlat16_1;
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
					uniform 	float _Interp;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _To;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					mediump vec4 u_xlat16_1;
					void main()
					{
					    u_xlat16_0 = texture(_To, vs_TEXCOORD0.xy);
					    u_xlat16_1 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat16_0 = u_xlat16_0 + (-u_xlat16_1);
					    SV_Target0 = vec4(_Interp) * u_xlat16_0 + u_xlat16_1;
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
			GpuProgramID 67099
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
					uniform 	float _Interp;
					uniform 	vec4 _TargetColor;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1 = (-u_xlat10_0) + _TargetColor;
					    SV_Target0 = vec4(_Interp) * u_xlat1 + u_xlat10_0;
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
					uniform 	float _Interp;
					uniform 	vec4 _TargetColor;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1 = (-u_xlat10_0) + _TargetColor;
					    SV_Target0 = vec4(_Interp) * u_xlat1 + u_xlat10_0;
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
					uniform 	float _Interp;
					uniform 	vec4 _TargetColor;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1 = (-u_xlat10_0) + _TargetColor;
					    SV_Target0 = vec4(_Interp) * u_xlat1 + u_xlat10_0;
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
					uniform 	float _Interp;
					uniform 	vec4 _TargetColor;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1 = (-u_xlat16_0) + _TargetColor;
					    SV_Target0 = vec4(_Interp) * u_xlat1 + u_xlat16_0;
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
					uniform 	float _Interp;
					uniform 	vec4 _TargetColor;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1 = (-u_xlat16_0) + _TargetColor;
					    SV_Target0 = vec4(_Interp) * u_xlat1 + u_xlat16_0;
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
					uniform 	float _Interp;
					uniform 	vec4 _TargetColor;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1 = (-u_xlat16_0) + _TargetColor;
					    SV_Target0 = vec4(_Interp) * u_xlat1 + u_xlat16_0;
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