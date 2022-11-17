Shader "Hidden/PostProcessing/DeferredFog" {
	Properties {
	}
	SubShader {
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 3737
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
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _FogColor;
					uniform 	vec3 _FogParams;
					uniform lowp sampler2D _MainTex;
					uniform highp sampler2D _CameraDepthTexture;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					float u_xlat0;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					float u_xlat3;
					void main()
					{
					    u_xlat0 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat3 = texture2D(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					    u_xlat3 = u_xlat3 * _ZBufferParams.x;
					    u_xlat0 = u_xlat0 * u_xlat3 + _ZBufferParams.y;
					    u_xlat3 = (-unity_OrthoParams.w) * u_xlat3 + 1.0;
					    u_xlat0 = u_xlat3 / u_xlat0;
					    u_xlat0 = u_xlat0 * _ProjectionParams.z + (-_ProjectionParams.y);
					    u_xlat0 = u_xlat0 * _FogParams.x;
					    u_xlat0 = u_xlat0 * (-u_xlat0);
					    u_xlat0 = exp2(u_xlat0);
					    u_xlat0 = (-u_xlat0) + 1.0;
					    u_xlat10_1 = texture2D(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat2 = (-u_xlat10_1) + _FogColor;
					    SV_Target0 = vec4(u_xlat0) * u_xlat2 + u_xlat10_1;
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
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _FogColor;
					uniform 	vec3 _FogParams;
					uniform lowp sampler2D _MainTex;
					uniform highp sampler2D _CameraDepthTexture;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					float u_xlat0;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					float u_xlat3;
					void main()
					{
					    u_xlat0 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat3 = texture2D(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					    u_xlat3 = u_xlat3 * _ZBufferParams.x;
					    u_xlat0 = u_xlat0 * u_xlat3 + _ZBufferParams.y;
					    u_xlat3 = (-unity_OrthoParams.w) * u_xlat3 + 1.0;
					    u_xlat0 = u_xlat3 / u_xlat0;
					    u_xlat0 = u_xlat0 * _ProjectionParams.z + (-_ProjectionParams.y);
					    u_xlat0 = u_xlat0 * _FogParams.x;
					    u_xlat0 = u_xlat0 * (-u_xlat0);
					    u_xlat0 = exp2(u_xlat0);
					    u_xlat0 = (-u_xlat0) + 1.0;
					    u_xlat10_1 = texture2D(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat2 = (-u_xlat10_1) + _FogColor;
					    SV_Target0 = vec4(u_xlat0) * u_xlat2 + u_xlat10_1;
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
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _FogColor;
					uniform 	vec3 _FogParams;
					uniform lowp sampler2D _MainTex;
					uniform highp sampler2D _CameraDepthTexture;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					float u_xlat0;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					float u_xlat3;
					void main()
					{
					    u_xlat0 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat3 = texture2D(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					    u_xlat3 = u_xlat3 * _ZBufferParams.x;
					    u_xlat0 = u_xlat0 * u_xlat3 + _ZBufferParams.y;
					    u_xlat3 = (-unity_OrthoParams.w) * u_xlat3 + 1.0;
					    u_xlat0 = u_xlat3 / u_xlat0;
					    u_xlat0 = u_xlat0 * _ProjectionParams.z + (-_ProjectionParams.y);
					    u_xlat0 = u_xlat0 * _FogParams.x;
					    u_xlat0 = u_xlat0 * (-u_xlat0);
					    u_xlat0 = exp2(u_xlat0);
					    u_xlat0 = (-u_xlat0) + 1.0;
					    u_xlat10_1 = texture2D(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat2 = (-u_xlat10_1) + _FogColor;
					    SV_Target0 = vec4(u_xlat0) * u_xlat2 + u_xlat10_1;
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
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _FogColor;
					uniform 	vec3 _FogParams;
					uniform mediump sampler2D _MainTex;
					uniform highp sampler2D _CameraDepthTexture;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					float u_xlat0;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					float u_xlat3;
					void main()
					{
					    u_xlat0 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat3 = texture(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					    u_xlat3 = u_xlat3 * _ZBufferParams.x;
					    u_xlat0 = u_xlat0 * u_xlat3 + _ZBufferParams.y;
					    u_xlat3 = (-unity_OrthoParams.w) * u_xlat3 + 1.0;
					    u_xlat0 = u_xlat3 / u_xlat0;
					    u_xlat0 = u_xlat0 * _ProjectionParams.z + (-_ProjectionParams.y);
					    u_xlat0 = u_xlat0 * _FogParams.x;
					    u_xlat0 = u_xlat0 * (-u_xlat0);
					    u_xlat0 = exp2(u_xlat0);
					    u_xlat0 = (-u_xlat0) + 1.0;
					    u_xlat16_1 = texture(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat2 = (-u_xlat16_1) + _FogColor;
					    SV_Target0 = vec4(u_xlat0) * u_xlat2 + u_xlat16_1;
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
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _FogColor;
					uniform 	vec3 _FogParams;
					uniform mediump sampler2D _MainTex;
					uniform highp sampler2D _CameraDepthTexture;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					float u_xlat0;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					float u_xlat3;
					void main()
					{
					    u_xlat0 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat3 = texture(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					    u_xlat3 = u_xlat3 * _ZBufferParams.x;
					    u_xlat0 = u_xlat0 * u_xlat3 + _ZBufferParams.y;
					    u_xlat3 = (-unity_OrthoParams.w) * u_xlat3 + 1.0;
					    u_xlat0 = u_xlat3 / u_xlat0;
					    u_xlat0 = u_xlat0 * _ProjectionParams.z + (-_ProjectionParams.y);
					    u_xlat0 = u_xlat0 * _FogParams.x;
					    u_xlat0 = u_xlat0 * (-u_xlat0);
					    u_xlat0 = exp2(u_xlat0);
					    u_xlat0 = (-u_xlat0) + 1.0;
					    u_xlat16_1 = texture(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat2 = (-u_xlat16_1) + _FogColor;
					    SV_Target0 = vec4(u_xlat0) * u_xlat2 + u_xlat16_1;
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
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _FogColor;
					uniform 	vec3 _FogParams;
					uniform mediump sampler2D _MainTex;
					uniform highp sampler2D _CameraDepthTexture;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					float u_xlat0;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					float u_xlat3;
					void main()
					{
					    u_xlat0 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat3 = texture(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					    u_xlat3 = u_xlat3 * _ZBufferParams.x;
					    u_xlat0 = u_xlat0 * u_xlat3 + _ZBufferParams.y;
					    u_xlat3 = (-unity_OrthoParams.w) * u_xlat3 + 1.0;
					    u_xlat0 = u_xlat3 / u_xlat0;
					    u_xlat0 = u_xlat0 * _ProjectionParams.z + (-_ProjectionParams.y);
					    u_xlat0 = u_xlat0 * _FogParams.x;
					    u_xlat0 = u_xlat0 * (-u_xlat0);
					    u_xlat0 = exp2(u_xlat0);
					    u_xlat0 = (-u_xlat0) + 1.0;
					    u_xlat16_1 = texture(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat2 = (-u_xlat16_1) + _FogColor;
					    SV_Target0 = vec4(u_xlat0) * u_xlat2 + u_xlat16_1;
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
			GpuProgramID 123110
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
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _FogColor;
					uniform 	vec3 _FogParams;
					uniform lowp sampler2D _MainTex;
					uniform highp sampler2D _CameraDepthTexture;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					float u_xlat0;
					bool u_xlatb0;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					float u_xlat3;
					void main()
					{
					    u_xlat0 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat3 = texture2D(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					    u_xlat3 = u_xlat3 * _ZBufferParams.x;
					    u_xlat0 = u_xlat0 * u_xlat3 + _ZBufferParams.y;
					    u_xlat3 = (-unity_OrthoParams.w) * u_xlat3 + 1.0;
					    u_xlat0 = u_xlat3 / u_xlat0;
					    u_xlat3 = u_xlat0 * _ProjectionParams.z + (-_ProjectionParams.y);
					    u_xlatb0 = u_xlat0<0.999899983;
					    u_xlat0 = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat3 = u_xlat3 * _FogParams.x;
					    u_xlat3 = u_xlat3 * (-u_xlat3);
					    u_xlat3 = exp2(u_xlat3);
					    u_xlat3 = (-u_xlat3) + 1.0;
					    u_xlat0 = u_xlat0 * u_xlat3;
					    u_xlat10_1 = texture2D(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat2 = (-u_xlat10_1) + _FogColor;
					    SV_Target0 = vec4(u_xlat0) * u_xlat2 + u_xlat10_1;
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
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _FogColor;
					uniform 	vec3 _FogParams;
					uniform lowp sampler2D _MainTex;
					uniform highp sampler2D _CameraDepthTexture;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					float u_xlat0;
					bool u_xlatb0;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					float u_xlat3;
					void main()
					{
					    u_xlat0 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat3 = texture2D(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					    u_xlat3 = u_xlat3 * _ZBufferParams.x;
					    u_xlat0 = u_xlat0 * u_xlat3 + _ZBufferParams.y;
					    u_xlat3 = (-unity_OrthoParams.w) * u_xlat3 + 1.0;
					    u_xlat0 = u_xlat3 / u_xlat0;
					    u_xlat3 = u_xlat0 * _ProjectionParams.z + (-_ProjectionParams.y);
					    u_xlatb0 = u_xlat0<0.999899983;
					    u_xlat0 = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat3 = u_xlat3 * _FogParams.x;
					    u_xlat3 = u_xlat3 * (-u_xlat3);
					    u_xlat3 = exp2(u_xlat3);
					    u_xlat3 = (-u_xlat3) + 1.0;
					    u_xlat0 = u_xlat0 * u_xlat3;
					    u_xlat10_1 = texture2D(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat2 = (-u_xlat10_1) + _FogColor;
					    SV_Target0 = vec4(u_xlat0) * u_xlat2 + u_xlat10_1;
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
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _FogColor;
					uniform 	vec3 _FogParams;
					uniform lowp sampler2D _MainTex;
					uniform highp sampler2D _CameraDepthTexture;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					float u_xlat0;
					bool u_xlatb0;
					lowp vec4 u_xlat10_1;
					vec4 u_xlat2;
					float u_xlat3;
					void main()
					{
					    u_xlat0 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat3 = texture2D(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					    u_xlat3 = u_xlat3 * _ZBufferParams.x;
					    u_xlat0 = u_xlat0 * u_xlat3 + _ZBufferParams.y;
					    u_xlat3 = (-unity_OrthoParams.w) * u_xlat3 + 1.0;
					    u_xlat0 = u_xlat3 / u_xlat0;
					    u_xlat3 = u_xlat0 * _ProjectionParams.z + (-_ProjectionParams.y);
					    u_xlatb0 = u_xlat0<0.999899983;
					    u_xlat0 = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat3 = u_xlat3 * _FogParams.x;
					    u_xlat3 = u_xlat3 * (-u_xlat3);
					    u_xlat3 = exp2(u_xlat3);
					    u_xlat3 = (-u_xlat3) + 1.0;
					    u_xlat0 = u_xlat0 * u_xlat3;
					    u_xlat10_1 = texture2D(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat2 = (-u_xlat10_1) + _FogColor;
					    SV_Target0 = vec4(u_xlat0) * u_xlat2 + u_xlat10_1;
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
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _FogColor;
					uniform 	vec3 _FogParams;
					uniform mediump sampler2D _MainTex;
					uniform highp sampler2D _CameraDepthTexture;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					float u_xlat0;
					bool u_xlatb0;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					float u_xlat3;
					void main()
					{
					    u_xlat0 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat3 = texture(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					    u_xlat3 = u_xlat3 * _ZBufferParams.x;
					    u_xlat0 = u_xlat0 * u_xlat3 + _ZBufferParams.y;
					    u_xlat3 = (-unity_OrthoParams.w) * u_xlat3 + 1.0;
					    u_xlat0 = u_xlat3 / u_xlat0;
					    u_xlat3 = u_xlat0 * _ProjectionParams.z + (-_ProjectionParams.y);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0<0.999899983);
					#else
					    u_xlatb0 = u_xlat0<0.999899983;
					#endif
					    u_xlat0 = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat3 = u_xlat3 * _FogParams.x;
					    u_xlat3 = u_xlat3 * (-u_xlat3);
					    u_xlat3 = exp2(u_xlat3);
					    u_xlat3 = (-u_xlat3) + 1.0;
					    u_xlat0 = u_xlat0 * u_xlat3;
					    u_xlat16_1 = texture(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat2 = (-u_xlat16_1) + _FogColor;
					    SV_Target0 = vec4(u_xlat0) * u_xlat2 + u_xlat16_1;
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
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _FogColor;
					uniform 	vec3 _FogParams;
					uniform mediump sampler2D _MainTex;
					uniform highp sampler2D _CameraDepthTexture;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					float u_xlat0;
					bool u_xlatb0;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					float u_xlat3;
					void main()
					{
					    u_xlat0 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat3 = texture(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					    u_xlat3 = u_xlat3 * _ZBufferParams.x;
					    u_xlat0 = u_xlat0 * u_xlat3 + _ZBufferParams.y;
					    u_xlat3 = (-unity_OrthoParams.w) * u_xlat3 + 1.0;
					    u_xlat0 = u_xlat3 / u_xlat0;
					    u_xlat3 = u_xlat0 * _ProjectionParams.z + (-_ProjectionParams.y);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0<0.999899983);
					#else
					    u_xlatb0 = u_xlat0<0.999899983;
					#endif
					    u_xlat0 = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat3 = u_xlat3 * _FogParams.x;
					    u_xlat3 = u_xlat3 * (-u_xlat3);
					    u_xlat3 = exp2(u_xlat3);
					    u_xlat3 = (-u_xlat3) + 1.0;
					    u_xlat0 = u_xlat0 * u_xlat3;
					    u_xlat16_1 = texture(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat2 = (-u_xlat16_1) + _FogColor;
					    SV_Target0 = vec4(u_xlat0) * u_xlat2 + u_xlat16_1;
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
					uniform 	vec4 _ProjectionParams;
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _FogColor;
					uniform 	vec3 _FogParams;
					uniform mediump sampler2D _MainTex;
					uniform highp sampler2D _CameraDepthTexture;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					float u_xlat0;
					bool u_xlatb0;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					float u_xlat3;
					void main()
					{
					    u_xlat0 = (-unity_OrthoParams.w) + 1.0;
					    u_xlat3 = texture(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					    u_xlat3 = u_xlat3 * _ZBufferParams.x;
					    u_xlat0 = u_xlat0 * u_xlat3 + _ZBufferParams.y;
					    u_xlat3 = (-unity_OrthoParams.w) * u_xlat3 + 1.0;
					    u_xlat0 = u_xlat3 / u_xlat0;
					    u_xlat3 = u_xlat0 * _ProjectionParams.z + (-_ProjectionParams.y);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat0<0.999899983);
					#else
					    u_xlatb0 = u_xlat0<0.999899983;
					#endif
					    u_xlat0 = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat3 = u_xlat3 * _FogParams.x;
					    u_xlat3 = u_xlat3 * (-u_xlat3);
					    u_xlat3 = exp2(u_xlat3);
					    u_xlat3 = (-u_xlat3) + 1.0;
					    u_xlat0 = u_xlat0 * u_xlat3;
					    u_xlat16_1 = texture(_MainTex, vs_TEXCOORD1.xy);
					    u_xlat2 = (-u_xlat16_1) + _FogColor;
					    SV_Target0 = vec4(u_xlat0) * u_xlat2 + u_xlat16_1;
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