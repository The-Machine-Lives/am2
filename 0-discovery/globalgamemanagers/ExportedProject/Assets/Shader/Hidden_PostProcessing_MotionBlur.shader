Shader "Hidden/PostProcessing/MotionBlur" {
	Properties {
	}
	SubShader {
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 5798
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
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _CameraMotionVectorsTexture_TexelSize;
					uniform 	float _VelocityScale;
					uniform 	float _RcpMaxBlurRadius;
					uniform lowp sampler2D _CameraMotionVectorsTexture;
					uniform highp sampler2D _CameraDepthTexture;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					float u_xlat1;
					float u_xlat2;
					lowp vec2 u_xlat10_2;
					void main()
					{
					    u_xlat0.x = _VelocityScale * 0.5;
					    u_xlat0.xy = u_xlat0.xx * _CameraMotionVectorsTexture_TexelSize.zw;
					    u_xlat10_2.xy = texture2D(_CameraMotionVectorsTexture, vs_TEXCOORD0.xy).xy;
					    u_xlat0.xy = u_xlat0.xy * u_xlat10_2.xy;
					    u_xlat2 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat2 = sqrt(u_xlat2);
					    u_xlat2 = u_xlat2 * _RcpMaxBlurRadius;
					    u_xlat2 = max(u_xlat2, 1.0);
					    u_xlat0.xy = u_xlat0.xy / vec2(u_xlat2);
					    u_xlat0.xy = u_xlat0.xy * vec2(vec2(_RcpMaxBlurRadius, _RcpMaxBlurRadius)) + vec2(1.0, 1.0);
					    SV_Target0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    u_xlat0.x = (-unity_OrthoParams.w) + 1.0;
					    u_xlat1 = texture2D(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
					    u_xlat1 = u_xlat1 * _ZBufferParams.x;
					    u_xlat0.x = u_xlat0.x * u_xlat1 + _ZBufferParams.y;
					    u_xlat1 = (-unity_OrthoParams.w) * u_xlat1 + 1.0;
					    SV_Target0.z = u_xlat1 / u_xlat0.x;
					    SV_Target0.w = 0.0;
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
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _CameraMotionVectorsTexture_TexelSize;
					uniform 	float _VelocityScale;
					uniform 	float _RcpMaxBlurRadius;
					uniform lowp sampler2D _CameraMotionVectorsTexture;
					uniform highp sampler2D _CameraDepthTexture;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					float u_xlat1;
					float u_xlat2;
					lowp vec2 u_xlat10_2;
					void main()
					{
					    u_xlat0.x = _VelocityScale * 0.5;
					    u_xlat0.xy = u_xlat0.xx * _CameraMotionVectorsTexture_TexelSize.zw;
					    u_xlat10_2.xy = texture2D(_CameraMotionVectorsTexture, vs_TEXCOORD0.xy).xy;
					    u_xlat0.xy = u_xlat0.xy * u_xlat10_2.xy;
					    u_xlat2 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat2 = sqrt(u_xlat2);
					    u_xlat2 = u_xlat2 * _RcpMaxBlurRadius;
					    u_xlat2 = max(u_xlat2, 1.0);
					    u_xlat0.xy = u_xlat0.xy / vec2(u_xlat2);
					    u_xlat0.xy = u_xlat0.xy * vec2(vec2(_RcpMaxBlurRadius, _RcpMaxBlurRadius)) + vec2(1.0, 1.0);
					    SV_Target0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    u_xlat0.x = (-unity_OrthoParams.w) + 1.0;
					    u_xlat1 = texture2D(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
					    u_xlat1 = u_xlat1 * _ZBufferParams.x;
					    u_xlat0.x = u_xlat0.x * u_xlat1 + _ZBufferParams.y;
					    u_xlat1 = (-unity_OrthoParams.w) * u_xlat1 + 1.0;
					    SV_Target0.z = u_xlat1 / u_xlat0.x;
					    SV_Target0.w = 0.0;
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
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _CameraMotionVectorsTexture_TexelSize;
					uniform 	float _VelocityScale;
					uniform 	float _RcpMaxBlurRadius;
					uniform lowp sampler2D _CameraMotionVectorsTexture;
					uniform highp sampler2D _CameraDepthTexture;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					float u_xlat1;
					float u_xlat2;
					lowp vec2 u_xlat10_2;
					void main()
					{
					    u_xlat0.x = _VelocityScale * 0.5;
					    u_xlat0.xy = u_xlat0.xx * _CameraMotionVectorsTexture_TexelSize.zw;
					    u_xlat10_2.xy = texture2D(_CameraMotionVectorsTexture, vs_TEXCOORD0.xy).xy;
					    u_xlat0.xy = u_xlat0.xy * u_xlat10_2.xy;
					    u_xlat2 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat2 = sqrt(u_xlat2);
					    u_xlat2 = u_xlat2 * _RcpMaxBlurRadius;
					    u_xlat2 = max(u_xlat2, 1.0);
					    u_xlat0.xy = u_xlat0.xy / vec2(u_xlat2);
					    u_xlat0.xy = u_xlat0.xy * vec2(vec2(_RcpMaxBlurRadius, _RcpMaxBlurRadius)) + vec2(1.0, 1.0);
					    SV_Target0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    u_xlat0.x = (-unity_OrthoParams.w) + 1.0;
					    u_xlat1 = texture2D(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
					    u_xlat1 = u_xlat1 * _ZBufferParams.x;
					    u_xlat0.x = u_xlat0.x * u_xlat1 + _ZBufferParams.y;
					    u_xlat1 = (-unity_OrthoParams.w) * u_xlat1 + 1.0;
					    SV_Target0.z = u_xlat1 / u_xlat0.x;
					    SV_Target0.w = 0.0;
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
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _CameraMotionVectorsTexture_TexelSize;
					uniform 	float _VelocityScale;
					uniform 	float _RcpMaxBlurRadius;
					uniform mediump sampler2D _CameraMotionVectorsTexture;
					uniform highp sampler2D _CameraDepthTexture;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					float u_xlat1;
					float u_xlat2;
					mediump vec2 u_xlat16_2;
					void main()
					{
					    u_xlat0.x = _VelocityScale * 0.5;
					    u_xlat0.xy = u_xlat0.xx * _CameraMotionVectorsTexture_TexelSize.zw;
					    u_xlat16_2.xy = texture(_CameraMotionVectorsTexture, vs_TEXCOORD0.xy).xy;
					    u_xlat0.xy = u_xlat0.xy * u_xlat16_2.xy;
					    u_xlat2 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat2 = sqrt(u_xlat2);
					    u_xlat2 = u_xlat2 * _RcpMaxBlurRadius;
					    u_xlat2 = max(u_xlat2, 1.0);
					    u_xlat0.xy = u_xlat0.xy / vec2(u_xlat2);
					    u_xlat0.xy = u_xlat0.xy * vec2(vec2(_RcpMaxBlurRadius, _RcpMaxBlurRadius)) + vec2(1.0, 1.0);
					    SV_Target0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    u_xlat0.x = (-unity_OrthoParams.w) + 1.0;
					    u_xlat1 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
					    u_xlat1 = u_xlat1 * _ZBufferParams.x;
					    u_xlat0.x = u_xlat0.x * u_xlat1 + _ZBufferParams.y;
					    u_xlat1 = (-unity_OrthoParams.w) * u_xlat1 + 1.0;
					    SV_Target0.z = u_xlat1 / u_xlat0.x;
					    SV_Target0.w = 0.0;
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
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _CameraMotionVectorsTexture_TexelSize;
					uniform 	float _VelocityScale;
					uniform 	float _RcpMaxBlurRadius;
					uniform mediump sampler2D _CameraMotionVectorsTexture;
					uniform highp sampler2D _CameraDepthTexture;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					float u_xlat1;
					float u_xlat2;
					mediump vec2 u_xlat16_2;
					void main()
					{
					    u_xlat0.x = _VelocityScale * 0.5;
					    u_xlat0.xy = u_xlat0.xx * _CameraMotionVectorsTexture_TexelSize.zw;
					    u_xlat16_2.xy = texture(_CameraMotionVectorsTexture, vs_TEXCOORD0.xy).xy;
					    u_xlat0.xy = u_xlat0.xy * u_xlat16_2.xy;
					    u_xlat2 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat2 = sqrt(u_xlat2);
					    u_xlat2 = u_xlat2 * _RcpMaxBlurRadius;
					    u_xlat2 = max(u_xlat2, 1.0);
					    u_xlat0.xy = u_xlat0.xy / vec2(u_xlat2);
					    u_xlat0.xy = u_xlat0.xy * vec2(vec2(_RcpMaxBlurRadius, _RcpMaxBlurRadius)) + vec2(1.0, 1.0);
					    SV_Target0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    u_xlat0.x = (-unity_OrthoParams.w) + 1.0;
					    u_xlat1 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
					    u_xlat1 = u_xlat1 * _ZBufferParams.x;
					    u_xlat0.x = u_xlat0.x * u_xlat1 + _ZBufferParams.y;
					    u_xlat1 = (-unity_OrthoParams.w) * u_xlat1 + 1.0;
					    SV_Target0.z = u_xlat1 / u_xlat0.x;
					    SV_Target0.w = 0.0;
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
					uniform 	vec4 unity_OrthoParams;
					uniform 	vec4 _ZBufferParams;
					uniform 	vec4 _CameraMotionVectorsTexture_TexelSize;
					uniform 	float _VelocityScale;
					uniform 	float _RcpMaxBlurRadius;
					uniform mediump sampler2D _CameraMotionVectorsTexture;
					uniform highp sampler2D _CameraDepthTexture;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					float u_xlat1;
					float u_xlat2;
					mediump vec2 u_xlat16_2;
					void main()
					{
					    u_xlat0.x = _VelocityScale * 0.5;
					    u_xlat0.xy = u_xlat0.xx * _CameraMotionVectorsTexture_TexelSize.zw;
					    u_xlat16_2.xy = texture(_CameraMotionVectorsTexture, vs_TEXCOORD0.xy).xy;
					    u_xlat0.xy = u_xlat0.xy * u_xlat16_2.xy;
					    u_xlat2 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat2 = sqrt(u_xlat2);
					    u_xlat2 = u_xlat2 * _RcpMaxBlurRadius;
					    u_xlat2 = max(u_xlat2, 1.0);
					    u_xlat0.xy = u_xlat0.xy / vec2(u_xlat2);
					    u_xlat0.xy = u_xlat0.xy * vec2(vec2(_RcpMaxBlurRadius, _RcpMaxBlurRadius)) + vec2(1.0, 1.0);
					    SV_Target0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    u_xlat0.x = (-unity_OrthoParams.w) + 1.0;
					    u_xlat1 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
					    u_xlat1 = u_xlat1 * _ZBufferParams.x;
					    u_xlat0.x = u_xlat0.x * u_xlat1 + _ZBufferParams.y;
					    u_xlat1 = (-unity_OrthoParams.w) * u_xlat1 + 1.0;
					    SV_Target0.z = u_xlat1 / u_xlat0.x;
					    SV_Target0.w = 0.0;
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
			GpuProgramID 122084
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _MaxBlurRadius;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp vec2 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec2 u_xlat10_1;
					bool u_xlatb1;
					float u_xlat3;
					float u_xlat4;
					lowp vec2 u_xlat10_4;
					bool u_xlatb4;
					lowp vec2 u_xlat10_5;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat10_0.xy = texture2D(_MainTex, u_xlat0.xy).xy;
					    u_xlat10_4.xy = texture2D(_MainTex, u_xlat0.zw).xy;
					    u_xlat0.zw = u_xlat10_4.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0.xy = u_xlat10_0.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0 = u_xlat0 * vec4(_MaxBlurRadius);
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat3 = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlatb1 = u_xlat1.x<u_xlat3;
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat0.zw : u_xlat0.xy;
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat10_1.xy = texture2D(_MainTex, u_xlat1.xy).xy;
					    u_xlat10_5.xy = texture2D(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.zw = u_xlat10_5.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1.xy = u_xlat10_1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1 = u_xlat1 * vec4(_MaxBlurRadius);
					    u_xlat6 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb4 = u_xlat4<u_xlat6;
					    u_xlat0.xy = (bool(u_xlatb4)) ? u_xlat1.xy : u_xlat0.xy;
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat6 = dot(u_xlat1.zw, u_xlat1.zw);
					    u_xlatb4 = u_xlat4<u_xlat6;
					    SV_Target0.xy = (bool(u_xlatb4)) ? u_xlat1.zw : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _MaxBlurRadius;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp vec2 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec2 u_xlat10_1;
					bool u_xlatb1;
					float u_xlat3;
					float u_xlat4;
					lowp vec2 u_xlat10_4;
					bool u_xlatb4;
					lowp vec2 u_xlat10_5;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat10_0.xy = texture2D(_MainTex, u_xlat0.xy).xy;
					    u_xlat10_4.xy = texture2D(_MainTex, u_xlat0.zw).xy;
					    u_xlat0.zw = u_xlat10_4.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0.xy = u_xlat10_0.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0 = u_xlat0 * vec4(_MaxBlurRadius);
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat3 = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlatb1 = u_xlat1.x<u_xlat3;
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat0.zw : u_xlat0.xy;
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat10_1.xy = texture2D(_MainTex, u_xlat1.xy).xy;
					    u_xlat10_5.xy = texture2D(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.zw = u_xlat10_5.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1.xy = u_xlat10_1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1 = u_xlat1 * vec4(_MaxBlurRadius);
					    u_xlat6 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb4 = u_xlat4<u_xlat6;
					    u_xlat0.xy = (bool(u_xlatb4)) ? u_xlat1.xy : u_xlat0.xy;
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat6 = dot(u_xlat1.zw, u_xlat1.zw);
					    u_xlatb4 = u_xlat4<u_xlat6;
					    SV_Target0.xy = (bool(u_xlatb4)) ? u_xlat1.zw : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _MaxBlurRadius;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp vec2 u_xlat10_0;
					vec4 u_xlat1;
					lowp vec2 u_xlat10_1;
					bool u_xlatb1;
					float u_xlat3;
					float u_xlat4;
					lowp vec2 u_xlat10_4;
					bool u_xlatb4;
					lowp vec2 u_xlat10_5;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat10_0.xy = texture2D(_MainTex, u_xlat0.xy).xy;
					    u_xlat10_4.xy = texture2D(_MainTex, u_xlat0.zw).xy;
					    u_xlat0.zw = u_xlat10_4.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0.xy = u_xlat10_0.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0 = u_xlat0 * vec4(_MaxBlurRadius);
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat3 = dot(u_xlat0.zw, u_xlat0.zw);
					    u_xlatb1 = u_xlat1.x<u_xlat3;
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat0.zw : u_xlat0.xy;
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat10_1.xy = texture2D(_MainTex, u_xlat1.xy).xy;
					    u_xlat10_5.xy = texture2D(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.zw = u_xlat10_5.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1.xy = u_xlat10_1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1 = u_xlat1 * vec4(_MaxBlurRadius);
					    u_xlat6 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb4 = u_xlat4<u_xlat6;
					    u_xlat0.xy = (bool(u_xlatb4)) ? u_xlat1.xy : u_xlat0.xy;
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat6 = dot(u_xlat1.zw, u_xlat1.zw);
					    u_xlatb4 = u_xlat4<u_xlat6;
					    SV_Target0.xy = (bool(u_xlatb4)) ? u_xlat1.zw : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _MaxBlurRadius;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec2 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec2 u_xlat16_1;
					bool u_xlatb1;
					float u_xlat3;
					float u_xlat4;
					mediump vec2 u_xlat16_4;
					bool u_xlatb4;
					mediump vec2 u_xlat16_5;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat16_0.xy = texture(_MainTex, u_xlat0.xy).xy;
					    u_xlat16_4.xy = texture(_MainTex, u_xlat0.zw).xy;
					    u_xlat0.zw = u_xlat16_4.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0.xy = u_xlat16_0.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0 = u_xlat0 * vec4(_MaxBlurRadius);
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat3 = dot(u_xlat0.zw, u_xlat0.zw);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat1.x<u_xlat3);
					#else
					    u_xlatb1 = u_xlat1.x<u_xlat3;
					#endif
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat0.zw : u_xlat0.xy;
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat16_1.xy = texture(_MainTex, u_xlat1.xy).xy;
					    u_xlat16_5.xy = texture(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.zw = u_xlat16_5.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1.xy = u_xlat16_1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1 = u_xlat1 * vec4(_MaxBlurRadius);
					    u_xlat6 = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4<u_xlat6);
					#else
					    u_xlatb4 = u_xlat4<u_xlat6;
					#endif
					    u_xlat0.xy = (bool(u_xlatb4)) ? u_xlat1.xy : u_xlat0.xy;
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat6 = dot(u_xlat1.zw, u_xlat1.zw);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4<u_xlat6);
					#else
					    u_xlatb4 = u_xlat4<u_xlat6;
					#endif
					    SV_Target0.xy = (bool(u_xlatb4)) ? u_xlat1.zw : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _MaxBlurRadius;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec2 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec2 u_xlat16_1;
					bool u_xlatb1;
					float u_xlat3;
					float u_xlat4;
					mediump vec2 u_xlat16_4;
					bool u_xlatb4;
					mediump vec2 u_xlat16_5;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat16_0.xy = texture(_MainTex, u_xlat0.xy).xy;
					    u_xlat16_4.xy = texture(_MainTex, u_xlat0.zw).xy;
					    u_xlat0.zw = u_xlat16_4.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0.xy = u_xlat16_0.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0 = u_xlat0 * vec4(_MaxBlurRadius);
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat3 = dot(u_xlat0.zw, u_xlat0.zw);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat1.x<u_xlat3);
					#else
					    u_xlatb1 = u_xlat1.x<u_xlat3;
					#endif
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat0.zw : u_xlat0.xy;
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat16_1.xy = texture(_MainTex, u_xlat1.xy).xy;
					    u_xlat16_5.xy = texture(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.zw = u_xlat16_5.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1.xy = u_xlat16_1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1 = u_xlat1 * vec4(_MaxBlurRadius);
					    u_xlat6 = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4<u_xlat6);
					#else
					    u_xlatb4 = u_xlat4<u_xlat6;
					#endif
					    u_xlat0.xy = (bool(u_xlatb4)) ? u_xlat1.xy : u_xlat0.xy;
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat6 = dot(u_xlat1.zw, u_xlat1.zw);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4<u_xlat6);
					#else
					    u_xlatb4 = u_xlat4<u_xlat6;
					#endif
					    SV_Target0.xy = (bool(u_xlatb4)) ? u_xlat1.zw : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	float _MaxBlurRadius;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec2 u_xlat16_0;
					vec4 u_xlat1;
					mediump vec2 u_xlat16_1;
					bool u_xlatb1;
					float u_xlat3;
					float u_xlat4;
					mediump vec2 u_xlat16_4;
					bool u_xlatb4;
					mediump vec2 u_xlat16_5;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat16_0.xy = texture(_MainTex, u_xlat0.xy).xy;
					    u_xlat16_4.xy = texture(_MainTex, u_xlat0.zw).xy;
					    u_xlat0.zw = u_xlat16_4.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0.xy = u_xlat16_0.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat0 = u_xlat0 * vec4(_MaxBlurRadius);
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat3 = dot(u_xlat0.zw, u_xlat0.zw);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat1.x<u_xlat3);
					#else
					    u_xlatb1 = u_xlat1.x<u_xlat3;
					#endif
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat0.zw : u_xlat0.xy;
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat16_1.xy = texture(_MainTex, u_xlat1.xy).xy;
					    u_xlat16_5.xy = texture(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.zw = u_xlat16_5.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1.xy = u_xlat16_1.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat1 = u_xlat1 * vec4(_MaxBlurRadius);
					    u_xlat6 = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4<u_xlat6);
					#else
					    u_xlatb4 = u_xlat4<u_xlat6;
					#endif
					    u_xlat0.xy = (bool(u_xlatb4)) ? u_xlat1.xy : u_xlat0.xy;
					    u_xlat4 = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat6 = dot(u_xlat1.zw, u_xlat1.zw);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4<u_xlat6);
					#else
					    u_xlatb4 = u_xlat4<u_xlat6;
					#endif
					    SV_Target0.xy = (bool(u_xlatb4)) ? u_xlat1.zw : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
			GpuProgramID 195533
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					float u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat5;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat0.xy = texture2D(_MainTex, u_xlat0.xy).xy;
					    u_xlat4.xy = texture2D(_MainTex, u_xlat0.zw).xy;
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat3 = dot(u_xlat4.xy, u_xlat4.xy);
					    u_xlatb1 = u_xlat1.x<u_xlat3;
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat4.xy : u_xlat0.xy;
					    u_xlat4.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1.xy = texture2D(_MainTex, u_xlat1.xy).xy;
					    u_xlat5.xy = texture2D(_MainTex, u_xlat1.zw).xy;
					    u_xlat6 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb4 = u_xlat4.x<u_xlat6;
					    u_xlat0.xy = (bool(u_xlatb4)) ? u_xlat1.xy : u_xlat0.xy;
					    u_xlat4.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat6 = dot(u_xlat5.xy, u_xlat5.xy);
					    u_xlatb4 = u_xlat4.x<u_xlat6;
					    SV_Target0.xy = (bool(u_xlatb4)) ? u_xlat5.xy : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					float u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat5;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat0.xy = texture2D(_MainTex, u_xlat0.xy).xy;
					    u_xlat4.xy = texture2D(_MainTex, u_xlat0.zw).xy;
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat3 = dot(u_xlat4.xy, u_xlat4.xy);
					    u_xlatb1 = u_xlat1.x<u_xlat3;
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat4.xy : u_xlat0.xy;
					    u_xlat4.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1.xy = texture2D(_MainTex, u_xlat1.xy).xy;
					    u_xlat5.xy = texture2D(_MainTex, u_xlat1.zw).xy;
					    u_xlat6 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb4 = u_xlat4.x<u_xlat6;
					    u_xlat0.xy = (bool(u_xlatb4)) ? u_xlat1.xy : u_xlat0.xy;
					    u_xlat4.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat6 = dot(u_xlat5.xy, u_xlat5.xy);
					    u_xlatb4 = u_xlat4.x<u_xlat6;
					    SV_Target0.xy = (bool(u_xlatb4)) ? u_xlat5.xy : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					float u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat5;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat0.xy = texture2D(_MainTex, u_xlat0.xy).xy;
					    u_xlat4.xy = texture2D(_MainTex, u_xlat0.zw).xy;
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat3 = dot(u_xlat4.xy, u_xlat4.xy);
					    u_xlatb1 = u_xlat1.x<u_xlat3;
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat4.xy : u_xlat0.xy;
					    u_xlat4.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1.xy = texture2D(_MainTex, u_xlat1.xy).xy;
					    u_xlat5.xy = texture2D(_MainTex, u_xlat1.zw).xy;
					    u_xlat6 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb4 = u_xlat4.x<u_xlat6;
					    u_xlat0.xy = (bool(u_xlatb4)) ? u_xlat1.xy : u_xlat0.xy;
					    u_xlat4.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat6 = dot(u_xlat5.xy, u_xlat5.xy);
					    u_xlatb4 = u_xlat4.x<u_xlat6;
					    SV_Target0.xy = (bool(u_xlatb4)) ? u_xlat5.xy : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					float u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat5;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat0.xy = texture(_MainTex, u_xlat0.xy).xy;
					    u_xlat4.xy = texture(_MainTex, u_xlat0.zw).xy;
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat3 = dot(u_xlat4.xy, u_xlat4.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat1.x<u_xlat3);
					#else
					    u_xlatb1 = u_xlat1.x<u_xlat3;
					#endif
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat4.xy : u_xlat0.xy;
					    u_xlat4.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1.xy = texture(_MainTex, u_xlat1.xy).xy;
					    u_xlat5.xy = texture(_MainTex, u_xlat1.zw).xy;
					    u_xlat6 = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4.x<u_xlat6);
					#else
					    u_xlatb4 = u_xlat4.x<u_xlat6;
					#endif
					    u_xlat0.xy = (bool(u_xlatb4)) ? u_xlat1.xy : u_xlat0.xy;
					    u_xlat4.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat6 = dot(u_xlat5.xy, u_xlat5.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4.x<u_xlat6);
					#else
					    u_xlatb4 = u_xlat4.x<u_xlat6;
					#endif
					    SV_Target0.xy = (bool(u_xlatb4)) ? u_xlat5.xy : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					float u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat5;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat0.xy = texture(_MainTex, u_xlat0.xy).xy;
					    u_xlat4.xy = texture(_MainTex, u_xlat0.zw).xy;
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat3 = dot(u_xlat4.xy, u_xlat4.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat1.x<u_xlat3);
					#else
					    u_xlatb1 = u_xlat1.x<u_xlat3;
					#endif
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat4.xy : u_xlat0.xy;
					    u_xlat4.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1.xy = texture(_MainTex, u_xlat1.xy).xy;
					    u_xlat5.xy = texture(_MainTex, u_xlat1.zw).xy;
					    u_xlat6 = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4.x<u_xlat6);
					#else
					    u_xlatb4 = u_xlat4.x<u_xlat6;
					#endif
					    u_xlat0.xy = (bool(u_xlatb4)) ? u_xlat1.xy : u_xlat0.xy;
					    u_xlat4.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat6 = dot(u_xlat5.xy, u_xlat5.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4.x<u_xlat6);
					#else
					    u_xlatb4 = u_xlat4.x<u_xlat6;
					#endif
					    SV_Target0.xy = (bool(u_xlatb4)) ? u_xlat5.xy : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					float u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat5;
					float u_xlat6;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.5, -0.5, 0.5, -0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat0.xy = texture(_MainTex, u_xlat0.xy).xy;
					    u_xlat4.xy = texture(_MainTex, u_xlat0.zw).xy;
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat3 = dot(u_xlat4.xy, u_xlat4.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat1.x<u_xlat3);
					#else
					    u_xlatb1 = u_xlat1.x<u_xlat3;
					#endif
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat4.xy : u_xlat0.xy;
					    u_xlat4.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-0.5, 0.5, 0.5, 0.5) + vs_TEXCOORD0.xyxy;
					    u_xlat1.xy = texture(_MainTex, u_xlat1.xy).xy;
					    u_xlat5.xy = texture(_MainTex, u_xlat1.zw).xy;
					    u_xlat6 = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4.x<u_xlat6);
					#else
					    u_xlatb4 = u_xlat4.x<u_xlat6;
					#endif
					    u_xlat0.xy = (bool(u_xlatb4)) ? u_xlat1.xy : u_xlat0.xy;
					    u_xlat4.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat6 = dot(u_xlat5.xy, u_xlat5.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4.x<u_xlat6);
					#else
					    u_xlatb4 = u_xlat4.x<u_xlat6;
					#endif
					    SV_Target0.xy = (bool(u_xlatb4)) ? u_xlat5.xy : u_xlat0.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
			GpuProgramID 216613
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	int _TileMaxLoop;
					uniform 	vec2 _TileMaxOffs;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					vec4 u_xlat1;
					int u_xlati2;
					vec2 u_xlat3;
					float u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat7;
					bool u_xlatb7;
					float u_xlat9;
					vec2 u_xlat10;
					vec2 u_xlat13;
					bool u_xlatb13;
					int u_xlati17;
					void main()
					{
					    u_xlat0.xy = _MainTex_TexelSize.xy * vec2(_TileMaxOffs.x, _TileMaxOffs.y) + vs_TEXCOORD0.xy;
					    u_xlat1.y = float(0.0);
					    u_xlat1.z = float(0.0);
					    u_xlat1.xw = _MainTex_TexelSize.xy;
					    u_xlat10.x = float(0.0);
					    u_xlat10.y = float(0.0);
					    for(int u_xlati_loop_1 = 0 ; u_xlati_loop_1<_TileMaxLoop ; u_xlati_loop_1++)
					    {
					        u_xlat7.x = float(u_xlati_loop_1);
					        u_xlat7.xy = u_xlat1.xy * u_xlat7.xx + u_xlat0.xy;
					        u_xlat3.xy = u_xlat10.xy;
					        for(int u_xlati_loop_2 = 0 ; u_xlati_loop_2<_TileMaxLoop ; u_xlati_loop_2++)
					        {
					            u_xlat13.x = float(u_xlati_loop_2);
					            u_xlat13.xy = u_xlat1.zw * u_xlat13.xx + u_xlat7.xy;
					            u_xlat13.xy = texture2D(_MainTex, u_xlat13.xy).xy;
					            u_xlat4 = dot(u_xlat3.xy, u_xlat3.xy);
					            u_xlat9 = dot(u_xlat13.xy, u_xlat13.xy);
					            u_xlatb4 = u_xlat4<u_xlat9;
					            u_xlat3.xy = (bool(u_xlatb4)) ? u_xlat13.xy : u_xlat3.xy;
					        }
					        u_xlat10.xy = u_xlat3.xy;
					    }
					    SV_Target0.xy = u_xlat10.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	int _TileMaxLoop;
					uniform 	vec2 _TileMaxOffs;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					vec4 u_xlat1;
					int u_xlati2;
					vec2 u_xlat3;
					float u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat7;
					bool u_xlatb7;
					float u_xlat9;
					vec2 u_xlat10;
					vec2 u_xlat13;
					bool u_xlatb13;
					int u_xlati17;
					void main()
					{
					    u_xlat0.xy = _MainTex_TexelSize.xy * vec2(_TileMaxOffs.x, _TileMaxOffs.y) + vs_TEXCOORD0.xy;
					    u_xlat1.y = float(0.0);
					    u_xlat1.z = float(0.0);
					    u_xlat1.xw = _MainTex_TexelSize.xy;
					    u_xlat10.x = float(0.0);
					    u_xlat10.y = float(0.0);
					    for(int u_xlati_loop_1 = 0 ; u_xlati_loop_1<_TileMaxLoop ; u_xlati_loop_1++)
					    {
					        u_xlat7.x = float(u_xlati_loop_1);
					        u_xlat7.xy = u_xlat1.xy * u_xlat7.xx + u_xlat0.xy;
					        u_xlat3.xy = u_xlat10.xy;
					        for(int u_xlati_loop_2 = 0 ; u_xlati_loop_2<_TileMaxLoop ; u_xlati_loop_2++)
					        {
					            u_xlat13.x = float(u_xlati_loop_2);
					            u_xlat13.xy = u_xlat1.zw * u_xlat13.xx + u_xlat7.xy;
					            u_xlat13.xy = texture2D(_MainTex, u_xlat13.xy).xy;
					            u_xlat4 = dot(u_xlat3.xy, u_xlat3.xy);
					            u_xlat9 = dot(u_xlat13.xy, u_xlat13.xy);
					            u_xlatb4 = u_xlat4<u_xlat9;
					            u_xlat3.xy = (bool(u_xlatb4)) ? u_xlat13.xy : u_xlat3.xy;
					        }
					        u_xlat10.xy = u_xlat3.xy;
					    }
					    SV_Target0.xy = u_xlat10.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	int _TileMaxLoop;
					uniform 	vec2 _TileMaxOffs;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					vec4 u_xlat1;
					int u_xlati2;
					vec2 u_xlat3;
					float u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat7;
					bool u_xlatb7;
					float u_xlat9;
					vec2 u_xlat10;
					vec2 u_xlat13;
					bool u_xlatb13;
					int u_xlati17;
					void main()
					{
					    u_xlat0.xy = _MainTex_TexelSize.xy * vec2(_TileMaxOffs.x, _TileMaxOffs.y) + vs_TEXCOORD0.xy;
					    u_xlat1.y = float(0.0);
					    u_xlat1.z = float(0.0);
					    u_xlat1.xw = _MainTex_TexelSize.xy;
					    u_xlat10.x = float(0.0);
					    u_xlat10.y = float(0.0);
					    for(int u_xlati_loop_1 = 0 ; u_xlati_loop_1<_TileMaxLoop ; u_xlati_loop_1++)
					    {
					        u_xlat7.x = float(u_xlati_loop_1);
					        u_xlat7.xy = u_xlat1.xy * u_xlat7.xx + u_xlat0.xy;
					        u_xlat3.xy = u_xlat10.xy;
					        for(int u_xlati_loop_2 = 0 ; u_xlati_loop_2<_TileMaxLoop ; u_xlati_loop_2++)
					        {
					            u_xlat13.x = float(u_xlati_loop_2);
					            u_xlat13.xy = u_xlat1.zw * u_xlat13.xx + u_xlat7.xy;
					            u_xlat13.xy = texture2D(_MainTex, u_xlat13.xy).xy;
					            u_xlat4 = dot(u_xlat3.xy, u_xlat3.xy);
					            u_xlat9 = dot(u_xlat13.xy, u_xlat13.xy);
					            u_xlatb4 = u_xlat4<u_xlat9;
					            u_xlat3.xy = (bool(u_xlatb4)) ? u_xlat13.xy : u_xlat3.xy;
					        }
					        u_xlat10.xy = u_xlat3.xy;
					    }
					    SV_Target0.xy = u_xlat10.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	int _TileMaxLoop;
					uniform 	vec2 _TileMaxOffs;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					vec4 u_xlat1;
					int u_xlati2;
					vec2 u_xlat3;
					float u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat7;
					bool u_xlatb7;
					float u_xlat9;
					vec2 u_xlat10;
					vec2 u_xlat13;
					bool u_xlatb13;
					int u_xlati17;
					void main()
					{
					    u_xlat0.xy = _MainTex_TexelSize.xy * vec2(_TileMaxOffs.x, _TileMaxOffs.y) + vs_TEXCOORD0.xy;
					    u_xlat1.y = float(0.0);
					    u_xlat1.z = float(0.0);
					    u_xlat1.xw = _MainTex_TexelSize.xy;
					    u_xlat10.x = float(0.0);
					    u_xlat10.y = float(0.0);
					    for(int u_xlati_loop_1 = 0 ; u_xlati_loop_1<_TileMaxLoop ; u_xlati_loop_1++)
					    {
					        u_xlat7.x = float(u_xlati_loop_1);
					        u_xlat7.xy = u_xlat1.xy * u_xlat7.xx + u_xlat0.xy;
					        u_xlat3.xy = u_xlat10.xy;
					        for(int u_xlati_loop_2 = 0 ; u_xlati_loop_2<_TileMaxLoop ; u_xlati_loop_2++)
					        {
					            u_xlat13.x = float(u_xlati_loop_2);
					            u_xlat13.xy = u_xlat1.zw * u_xlat13.xx + u_xlat7.xy;
					            u_xlat13.xy = texture(_MainTex, u_xlat13.xy).xy;
					            u_xlat4 = dot(u_xlat3.xy, u_xlat3.xy);
					            u_xlat9 = dot(u_xlat13.xy, u_xlat13.xy);
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb4 = !!(u_xlat4<u_xlat9);
					#else
					            u_xlatb4 = u_xlat4<u_xlat9;
					#endif
					            u_xlat3.xy = (bool(u_xlatb4)) ? u_xlat13.xy : u_xlat3.xy;
					        }
					        u_xlat10.xy = u_xlat3.xy;
					    }
					    SV_Target0.xy = u_xlat10.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	int _TileMaxLoop;
					uniform 	vec2 _TileMaxOffs;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					vec4 u_xlat1;
					int u_xlati2;
					vec2 u_xlat3;
					float u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat7;
					bool u_xlatb7;
					float u_xlat9;
					vec2 u_xlat10;
					vec2 u_xlat13;
					bool u_xlatb13;
					int u_xlati17;
					void main()
					{
					    u_xlat0.xy = _MainTex_TexelSize.xy * vec2(_TileMaxOffs.x, _TileMaxOffs.y) + vs_TEXCOORD0.xy;
					    u_xlat1.y = float(0.0);
					    u_xlat1.z = float(0.0);
					    u_xlat1.xw = _MainTex_TexelSize.xy;
					    u_xlat10.x = float(0.0);
					    u_xlat10.y = float(0.0);
					    for(int u_xlati_loop_1 = 0 ; u_xlati_loop_1<_TileMaxLoop ; u_xlati_loop_1++)
					    {
					        u_xlat7.x = float(u_xlati_loop_1);
					        u_xlat7.xy = u_xlat1.xy * u_xlat7.xx + u_xlat0.xy;
					        u_xlat3.xy = u_xlat10.xy;
					        for(int u_xlati_loop_2 = 0 ; u_xlati_loop_2<_TileMaxLoop ; u_xlati_loop_2++)
					        {
					            u_xlat13.x = float(u_xlati_loop_2);
					            u_xlat13.xy = u_xlat1.zw * u_xlat13.xx + u_xlat7.xy;
					            u_xlat13.xy = texture(_MainTex, u_xlat13.xy).xy;
					            u_xlat4 = dot(u_xlat3.xy, u_xlat3.xy);
					            u_xlat9 = dot(u_xlat13.xy, u_xlat13.xy);
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb4 = !!(u_xlat4<u_xlat9);
					#else
					            u_xlatb4 = u_xlat4<u_xlat9;
					#endif
					            u_xlat3.xy = (bool(u_xlatb4)) ? u_xlat13.xy : u_xlat3.xy;
					        }
					        u_xlat10.xy = u_xlat3.xy;
					    }
					    SV_Target0.xy = u_xlat10.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	int _TileMaxLoop;
					uniform 	vec2 _TileMaxOffs;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					vec4 u_xlat1;
					int u_xlati2;
					vec2 u_xlat3;
					float u_xlat4;
					bool u_xlatb4;
					vec2 u_xlat7;
					bool u_xlatb7;
					float u_xlat9;
					vec2 u_xlat10;
					vec2 u_xlat13;
					bool u_xlatb13;
					int u_xlati17;
					void main()
					{
					    u_xlat0.xy = _MainTex_TexelSize.xy * vec2(_TileMaxOffs.x, _TileMaxOffs.y) + vs_TEXCOORD0.xy;
					    u_xlat1.y = float(0.0);
					    u_xlat1.z = float(0.0);
					    u_xlat1.xw = _MainTex_TexelSize.xy;
					    u_xlat10.x = float(0.0);
					    u_xlat10.y = float(0.0);
					    for(int u_xlati_loop_1 = 0 ; u_xlati_loop_1<_TileMaxLoop ; u_xlati_loop_1++)
					    {
					        u_xlat7.x = float(u_xlati_loop_1);
					        u_xlat7.xy = u_xlat1.xy * u_xlat7.xx + u_xlat0.xy;
					        u_xlat3.xy = u_xlat10.xy;
					        for(int u_xlati_loop_2 = 0 ; u_xlati_loop_2<_TileMaxLoop ; u_xlati_loop_2++)
					        {
					            u_xlat13.x = float(u_xlati_loop_2);
					            u_xlat13.xy = u_xlat1.zw * u_xlat13.xx + u_xlat7.xy;
					            u_xlat13.xy = texture(_MainTex, u_xlat13.xy).xy;
					            u_xlat4 = dot(u_xlat3.xy, u_xlat3.xy);
					            u_xlat9 = dot(u_xlat13.xy, u_xlat13.xy);
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb4 = !!(u_xlat4<u_xlat9);
					#else
					            u_xlatb4 = u_xlat4<u_xlat9;
					#endif
					            u_xlat3.xy = (bool(u_xlatb4)) ? u_xlat13.xy : u_xlat3.xy;
					        }
					        u_xlat10.xy = u_xlat3.xy;
					    }
					    SV_Target0.xy = u_xlat10.xy;
					    SV_Target0.zw = vec2(0.0, 0.0);
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
			GpuProgramID 295994
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					vec4 u_xlat2;
					float u_xlat4;
					vec2 u_xlat6;
					bool u_xlatb6;
					vec2 u_xlat7;
					lowp vec2 u_xlat10_7;
					float u_xlat8;
					float u_xlat9;
					bool u_xlatb9;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.yyxy * vec4(0.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat0.xy = texture2D(_MainTex, u_xlat0.xy).xy;
					    u_xlat6.xy = texture2D(_MainTex, u_xlat0.zw).xy;
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat4 = dot(u_xlat6.xy, u_xlat6.xy);
					    u_xlatb1 = u_xlat1.x<u_xlat4;
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat6.xy : u_xlat0.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, -1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture2D(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.xy = texture2D(_MainTex, u_xlat1.xy).xy;
					    u_xlat9 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat7.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat10_7.xy = texture2D(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlat7.xy = u_xlat10_7.xy * vec2(1.00999999, 1.00999999);
					    u_xlat2.x = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlatb9 = u_xlat2.x<u_xlat9;
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat1.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat2 = (-_MainTex_TexelSize.xyxy) * vec4(-1.0, 1.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture2D(_MainTex, u_xlat2.zw).xy;
					    u_xlat2.xy = texture2D(_MainTex, u_xlat2.xy).xy;
					    u_xlat8 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlatb9 = u_xlat8<u_xlat9;
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat1.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat1.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat1 = (-_MainTex_TexelSize.xyyy) * vec4(1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture2D(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.xy = texture2D(_MainTex, u_xlat1.xy).xy;
					    u_xlat8 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlatb9 = u_xlat8<u_xlat9;
					    u_xlat7.xy = (bool(u_xlatb9)) ? u_xlat2.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlat2.x = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb9 = u_xlat2.x<u_xlat9;
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat7.xy : u_xlat1.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat1.xy;
					    SV_Target0.xy = u_xlat0.xy * vec2(0.990099013, 0.990099013);
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					vec4 u_xlat2;
					float u_xlat4;
					vec2 u_xlat6;
					bool u_xlatb6;
					vec2 u_xlat7;
					lowp vec2 u_xlat10_7;
					float u_xlat8;
					float u_xlat9;
					bool u_xlatb9;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.yyxy * vec4(0.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat0.xy = texture2D(_MainTex, u_xlat0.xy).xy;
					    u_xlat6.xy = texture2D(_MainTex, u_xlat0.zw).xy;
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat4 = dot(u_xlat6.xy, u_xlat6.xy);
					    u_xlatb1 = u_xlat1.x<u_xlat4;
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat6.xy : u_xlat0.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, -1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture2D(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.xy = texture2D(_MainTex, u_xlat1.xy).xy;
					    u_xlat9 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat7.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat10_7.xy = texture2D(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlat7.xy = u_xlat10_7.xy * vec2(1.00999999, 1.00999999);
					    u_xlat2.x = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlatb9 = u_xlat2.x<u_xlat9;
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat1.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat2 = (-_MainTex_TexelSize.xyxy) * vec4(-1.0, 1.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture2D(_MainTex, u_xlat2.zw).xy;
					    u_xlat2.xy = texture2D(_MainTex, u_xlat2.xy).xy;
					    u_xlat8 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlatb9 = u_xlat8<u_xlat9;
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat1.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat1.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat1 = (-_MainTex_TexelSize.xyyy) * vec4(1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture2D(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.xy = texture2D(_MainTex, u_xlat1.xy).xy;
					    u_xlat8 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlatb9 = u_xlat8<u_xlat9;
					    u_xlat7.xy = (bool(u_xlatb9)) ? u_xlat2.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlat2.x = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb9 = u_xlat2.x<u_xlat9;
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat7.xy : u_xlat1.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat1.xy;
					    SV_Target0.xy = u_xlat0.xy * vec2(0.990099013, 0.990099013);
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					vec4 u_xlat2;
					float u_xlat4;
					vec2 u_xlat6;
					bool u_xlatb6;
					vec2 u_xlat7;
					lowp vec2 u_xlat10_7;
					float u_xlat8;
					float u_xlat9;
					bool u_xlatb9;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.yyxy * vec4(0.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat0.xy = texture2D(_MainTex, u_xlat0.xy).xy;
					    u_xlat6.xy = texture2D(_MainTex, u_xlat0.zw).xy;
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat4 = dot(u_xlat6.xy, u_xlat6.xy);
					    u_xlatb1 = u_xlat1.x<u_xlat4;
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat6.xy : u_xlat0.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, -1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture2D(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.xy = texture2D(_MainTex, u_xlat1.xy).xy;
					    u_xlat9 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat7.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat10_7.xy = texture2D(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlat7.xy = u_xlat10_7.xy * vec2(1.00999999, 1.00999999);
					    u_xlat2.x = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlatb9 = u_xlat2.x<u_xlat9;
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat1.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat2 = (-_MainTex_TexelSize.xyxy) * vec4(-1.0, 1.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture2D(_MainTex, u_xlat2.zw).xy;
					    u_xlat2.xy = texture2D(_MainTex, u_xlat2.xy).xy;
					    u_xlat8 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlatb9 = u_xlat8<u_xlat9;
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat1.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat1.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat1 = (-_MainTex_TexelSize.xyyy) * vec4(1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture2D(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.xy = texture2D(_MainTex, u_xlat1.xy).xy;
					    u_xlat8 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlatb9 = u_xlat8<u_xlat9;
					    u_xlat7.xy = (bool(u_xlatb9)) ? u_xlat2.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlat2.x = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb9 = u_xlat2.x<u_xlat9;
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat7.xy : u_xlat1.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat1.xy;
					    SV_Target0.xy = u_xlat0.xy * vec2(0.990099013, 0.990099013);
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					vec4 u_xlat2;
					float u_xlat4;
					vec2 u_xlat6;
					bool u_xlatb6;
					vec2 u_xlat7;
					mediump vec2 u_xlat16_7;
					float u_xlat8;
					float u_xlat9;
					bool u_xlatb9;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.yyxy * vec4(0.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat0.xy = texture(_MainTex, u_xlat0.xy).xy;
					    u_xlat6.xy = texture(_MainTex, u_xlat0.zw).xy;
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat4 = dot(u_xlat6.xy, u_xlat6.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat1.x<u_xlat4);
					#else
					    u_xlatb1 = u_xlat1.x<u_xlat4;
					#endif
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat6.xy : u_xlat0.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, -1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.xy = texture(_MainTex, u_xlat1.xy).xy;
					    u_xlat9 = dot(u_xlat7.xy, u_xlat7.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(u_xlat9<u_xlat6.x);
					#else
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					#endif
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat7.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat16_7.xy = texture(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlat7.xy = u_xlat16_7.xy * vec2(1.00999999, 1.00999999);
					    u_xlat2.x = dot(u_xlat7.xy, u_xlat7.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb9 = !!(u_xlat2.x<u_xlat9);
					#else
					    u_xlatb9 = u_xlat2.x<u_xlat9;
					#endif
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat1.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat2 = (-_MainTex_TexelSize.xyxy) * vec4(-1.0, 1.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture(_MainTex, u_xlat2.zw).xy;
					    u_xlat2.xy = texture(_MainTex, u_xlat2.xy).xy;
					    u_xlat8 = dot(u_xlat7.xy, u_xlat7.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb9 = !!(u_xlat8<u_xlat9);
					#else
					    u_xlatb9 = u_xlat8<u_xlat9;
					#endif
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat1.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(u_xlat9<u_xlat6.x);
					#else
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					#endif
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat1.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat1 = (-_MainTex_TexelSize.xyyy) * vec4(1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.xy = texture(_MainTex, u_xlat1.xy).xy;
					    u_xlat8 = dot(u_xlat7.xy, u_xlat7.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb9 = !!(u_xlat8<u_xlat9);
					#else
					    u_xlatb9 = u_xlat8<u_xlat9;
					#endif
					    u_xlat7.xy = (bool(u_xlatb9)) ? u_xlat2.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlat2.x = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb9 = !!(u_xlat2.x<u_xlat9);
					#else
					    u_xlatb9 = u_xlat2.x<u_xlat9;
					#endif
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat7.xy : u_xlat1.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(u_xlat9<u_xlat6.x);
					#else
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					#endif
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat1.xy;
					    SV_Target0.xy = u_xlat0.xy * vec2(0.990099013, 0.990099013);
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					vec4 u_xlat2;
					float u_xlat4;
					vec2 u_xlat6;
					bool u_xlatb6;
					vec2 u_xlat7;
					mediump vec2 u_xlat16_7;
					float u_xlat8;
					float u_xlat9;
					bool u_xlatb9;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.yyxy * vec4(0.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat0.xy = texture(_MainTex, u_xlat0.xy).xy;
					    u_xlat6.xy = texture(_MainTex, u_xlat0.zw).xy;
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat4 = dot(u_xlat6.xy, u_xlat6.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat1.x<u_xlat4);
					#else
					    u_xlatb1 = u_xlat1.x<u_xlat4;
					#endif
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat6.xy : u_xlat0.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, -1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.xy = texture(_MainTex, u_xlat1.xy).xy;
					    u_xlat9 = dot(u_xlat7.xy, u_xlat7.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(u_xlat9<u_xlat6.x);
					#else
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					#endif
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat7.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat16_7.xy = texture(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlat7.xy = u_xlat16_7.xy * vec2(1.00999999, 1.00999999);
					    u_xlat2.x = dot(u_xlat7.xy, u_xlat7.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb9 = !!(u_xlat2.x<u_xlat9);
					#else
					    u_xlatb9 = u_xlat2.x<u_xlat9;
					#endif
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat1.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat2 = (-_MainTex_TexelSize.xyxy) * vec4(-1.0, 1.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture(_MainTex, u_xlat2.zw).xy;
					    u_xlat2.xy = texture(_MainTex, u_xlat2.xy).xy;
					    u_xlat8 = dot(u_xlat7.xy, u_xlat7.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb9 = !!(u_xlat8<u_xlat9);
					#else
					    u_xlatb9 = u_xlat8<u_xlat9;
					#endif
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat1.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(u_xlat9<u_xlat6.x);
					#else
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					#endif
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat1.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat1 = (-_MainTex_TexelSize.xyyy) * vec4(1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.xy = texture(_MainTex, u_xlat1.xy).xy;
					    u_xlat8 = dot(u_xlat7.xy, u_xlat7.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb9 = !!(u_xlat8<u_xlat9);
					#else
					    u_xlatb9 = u_xlat8<u_xlat9;
					#endif
					    u_xlat7.xy = (bool(u_xlatb9)) ? u_xlat2.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlat2.x = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb9 = !!(u_xlat2.x<u_xlat9);
					#else
					    u_xlatb9 = u_xlat2.x<u_xlat9;
					#endif
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat7.xy : u_xlat1.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(u_xlat9<u_xlat6.x);
					#else
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					#endif
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat1.xy;
					    SV_Target0.xy = u_xlat0.xy * vec2(0.990099013, 0.990099013);
					    SV_Target0.zw = vec2(0.0, 0.0);
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					bool u_xlatb1;
					vec4 u_xlat2;
					float u_xlat4;
					vec2 u_xlat6;
					bool u_xlatb6;
					vec2 u_xlat7;
					mediump vec2 u_xlat16_7;
					float u_xlat8;
					float u_xlat9;
					bool u_xlatb9;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.yyxy * vec4(0.0, 1.0, 1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat0.xy = texture(_MainTex, u_xlat0.xy).xy;
					    u_xlat6.xy = texture(_MainTex, u_xlat0.zw).xy;
					    u_xlat1.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat4 = dot(u_xlat6.xy, u_xlat6.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat1.x<u_xlat4);
					#else
					    u_xlatb1 = u_xlat1.x<u_xlat4;
					#endif
					    u_xlat0.xy = (bool(u_xlatb1)) ? u_xlat6.xy : u_xlat0.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, -1.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.xy = texture(_MainTex, u_xlat1.xy).xy;
					    u_xlat9 = dot(u_xlat7.xy, u_xlat7.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(u_xlat9<u_xlat6.x);
					#else
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					#endif
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat7.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat16_7.xy = texture(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlat7.xy = u_xlat16_7.xy * vec2(1.00999999, 1.00999999);
					    u_xlat2.x = dot(u_xlat7.xy, u_xlat7.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb9 = !!(u_xlat2.x<u_xlat9);
					#else
					    u_xlatb9 = u_xlat2.x<u_xlat9;
					#endif
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat1.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat2 = (-_MainTex_TexelSize.xyxy) * vec4(-1.0, 1.0, 1.0, 0.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture(_MainTex, u_xlat2.zw).xy;
					    u_xlat2.xy = texture(_MainTex, u_xlat2.xy).xy;
					    u_xlat8 = dot(u_xlat7.xy, u_xlat7.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb9 = !!(u_xlat8<u_xlat9);
					#else
					    u_xlatb9 = u_xlat8<u_xlat9;
					#endif
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat1.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(u_xlat9<u_xlat6.x);
					#else
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					#endif
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat1.xy;
					    u_xlat6.x = dot(u_xlat0.xy, u_xlat0.xy);
					    u_xlat9 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat1 = (-_MainTex_TexelSize.xyyy) * vec4(1.0, 1.0, 0.0, 1.0) + vs_TEXCOORD0.xyxy;
					    u_xlat7.xy = texture(_MainTex, u_xlat1.zw).xy;
					    u_xlat1.xy = texture(_MainTex, u_xlat1.xy).xy;
					    u_xlat8 = dot(u_xlat7.xy, u_xlat7.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb9 = !!(u_xlat8<u_xlat9);
					#else
					    u_xlatb9 = u_xlat8<u_xlat9;
					#endif
					    u_xlat7.xy = (bool(u_xlatb9)) ? u_xlat2.xy : u_xlat7.xy;
					    u_xlat9 = dot(u_xlat7.xy, u_xlat7.xy);
					    u_xlat2.x = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb9 = !!(u_xlat2.x<u_xlat9);
					#else
					    u_xlatb9 = u_xlat2.x<u_xlat9;
					#endif
					    u_xlat1.xy = (bool(u_xlatb9)) ? u_xlat7.xy : u_xlat1.xy;
					    u_xlat9 = dot(u_xlat1.xy, u_xlat1.xy);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(u_xlat9<u_xlat6.x);
					#else
					    u_xlatb6 = u_xlat9<u_xlat6.x;
					#endif
					    u_xlat0.xy = (bool(u_xlatb6)) ? u_xlat0.xy : u_xlat1.xy;
					    SV_Target0.xy = u_xlat0.xy * vec2(0.990099013, 0.990099013);
					    SV_Target0.zw = vec2(0.0, 0.0);
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
			GpuProgramID 354576
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					#if !defined(GL_EXT_shader_texture_lod)
					#define texture1DLodEXT texture1D
					#define texture2DLodEXT texture2D
					#define texture2DProjLodEXT texture2DProj
					#define texture3DLodEXT texture3D
					#define textureCubeLodEXT textureCube
					#endif
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _ScreenParams;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec2 _VelocityTex_TexelSize;
					uniform 	vec2 _NeighborMaxTex_TexelSize;
					uniform 	float _MaxBlurRadius;
					uniform 	float _LoopCount;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _VelocityTex;
					uniform lowp sampler2D _NeighborMaxTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					mediump vec2 u_xlat16_2;
					lowp vec3 u_xlat10_2;
					vec3 u_xlat3;
					float u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec3 u_xlat7;
					mediump vec3 u_xlat16_7;
					bvec2 u_xlatb7;
					vec2 u_xlat8;
					mediump float u_xlat16_8;
					lowp vec3 u_xlat10_8;
					float u_xlat13;
					float u_xlat19;
					vec2 u_xlat21;
					float u_xlat22;
					float u_xlat25;
					float u_xlat28;
					mediump float u_xlat16_28;
					bool u_xlatb28;
					float u_xlat29;
					bool u_xlatb29;
					float u_xlat31;
					float u_xlat34;
					void main()
					{
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1.xy = vs_TEXCOORD0.xy + vec2(2.0, 0.0);
					    u_xlat1.xy = u_xlat1.xy * _ScreenParams.xy;
					    u_xlat1.xy = floor(u_xlat1.xy);
					    u_xlat1.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat1.xy);
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 52.9829178;
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 6.28318548;
					    u_xlat2.x = cos(u_xlat1.x);
					    u_xlat1.x = sin(u_xlat1.x);
					    u_xlat2.y = u_xlat1.x;
					    u_xlat1.xy = u_xlat2.xy * vec2(_NeighborMaxTex_TexelSize.x, _NeighborMaxTex_TexelSize.y);
					    u_xlat1.xy = u_xlat1.xy * vec2(0.25, 0.25) + vs_TEXCOORD0.xy;
					    u_xlat1.xy = texture2D(_NeighborMaxTex, u_xlat1.xy).xy;
					    u_xlat19 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat19 = sqrt(u_xlat19);
					    u_xlatb28 = u_xlat19<2.0;
					    if(u_xlatb28){
					        SV_Target0 = u_xlat10_0;
					        return;
					    //ENDIF
					    }
					    u_xlat10_2.xyz = texture2DLodEXT(_VelocityTex, vs_TEXCOORD0.xy, 0.0).xyz;
					    u_xlat16_2.xy = u_xlat10_2.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat2.xy = u_xlat16_2.xy * vec2(_MaxBlurRadius);
					    u_xlat28 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat28 = sqrt(u_xlat28);
					    u_xlat3.xy = max(vec2(u_xlat28), vec2(0.5, 1.0));
					    u_xlat16_28 = float(1.0) / u_xlat10_2.z;
					    u_xlat29 = u_xlat3.x + u_xlat3.x;
					    u_xlatb29 = u_xlat19<u_xlat29;
					    u_xlat3.x = u_xlat19 / u_xlat3.x;
					    u_xlat2.xy = u_xlat2.xy * u_xlat3.xx;
					    u_xlat2.xy = (bool(u_xlatb29)) ? u_xlat2.xy : u_xlat1.xy;
					    u_xlat29 = u_xlat19 * 0.5;
					    u_xlat29 = min(u_xlat29, _LoopCount);
					    u_xlat29 = floor(u_xlat29);
					    u_xlat3.x = float(1.0) / u_xlat29;
					    u_xlat21.xy = vs_TEXCOORD0.xy * _ScreenParams.xy;
					    u_xlat21.xy = floor(u_xlat21.xy);
					    u_xlat21.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat21.xy);
					    u_xlat3.z = fract(u_xlat21.x);
					    u_xlat21.xy = u_xlat3.zx * vec2(52.9829178, 0.25);
					    u_xlat21.x = fract(u_xlat21.x);
					    u_xlat21.x = u_xlat21.x + -0.5;
					    u_xlat4 = (-u_xlat3.x) * 0.5 + 1.0;
					    u_xlat5.w = 1.0;
					    u_xlat6.x = float(0.0);
					    u_xlat6.y = float(0.0);
					    u_xlat6.z = float(0.0);
					    u_xlat6.w = float(0.0);
					    u_xlat13 = u_xlat4;
					    u_xlat22 = 0.0;
					    u_xlat31 = u_xlat3.y;
					    for(int u_xlati_while_true_0 = 0 ; u_xlati_while_true_0 < 0x7FFF ; u_xlati_while_true_0++){
					        u_xlatb7.x = u_xlat21.y>=u_xlat13;
					        if(u_xlatb7.x){break;}
					        u_xlat7.xy = vec2(u_xlat22) * vec2(0.25, 0.5);
					        u_xlat7.xy = fract(u_xlat7.xy);
					        u_xlatb7.xy = lessThan(vec4(0.499000013, 0.499000013, 0.0, 0.0), u_xlat7.xyxx).xy;
					        u_xlat7.xz = (u_xlatb7.x) ? u_xlat2.xy : u_xlat1.xy;
					        u_xlat34 = (u_xlatb7.y) ? (-u_xlat13) : u_xlat13;
					        u_xlat34 = u_xlat21.x * u_xlat3.x + u_xlat34;
					        u_xlat7.xz = vec2(u_xlat34) * u_xlat7.xz;
					        u_xlat8.xy = u_xlat7.xz * _MainTex_TexelSize.xy + vs_TEXCOORD0.xy;
					        u_xlat7.xz = u_xlat7.xz * _VelocityTex_TexelSize.xy + vs_TEXCOORD0.xy;
					        u_xlat5.xyz = texture2DLodEXT(_MainTex, u_xlat8.xy, 0.0).xyz;
					        u_xlat10_8.xyz = texture2DLodEXT(_VelocityTex, u_xlat7.xz, 0.0).xyz;
					        u_xlat16_7.xz = u_xlat10_8.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					        u_xlat7.xz = u_xlat16_7.xz * vec2(_MaxBlurRadius);
					        u_xlat16_8 = u_xlat10_2.z + (-u_xlat10_8.z);
					        u_xlat16_8 = u_xlat16_28 * u_xlat16_8;
					        u_xlat16_8 = u_xlat16_8 * 20.0;
					        u_xlat16_8 = clamp(u_xlat16_8, 0.0, 1.0);
					        u_xlat7.x = dot(u_xlat7.xz, u_xlat7.xz);
					        u_xlat7.x = sqrt(u_xlat7.x);
					        u_xlat7.x = (-u_xlat31) + u_xlat7.x;
					        u_xlat7.x = u_xlat16_8 * u_xlat7.x + u_xlat31;
					        u_xlat25 = (-u_xlat19) * abs(u_xlat34) + u_xlat7.x;
					        u_xlat25 = clamp(u_xlat25, 0.0, 1.0);
					        u_xlat25 = u_xlat25 / u_xlat7.x;
					        u_xlat34 = (-u_xlat13) + 1.20000005;
					        u_xlat25 = u_xlat34 * u_xlat25;
					        u_xlat6 = u_xlat5 * vec4(u_xlat25) + u_xlat6;
					        u_xlat31 = max(u_xlat31, u_xlat7.x);
					        u_xlat5.x = (-u_xlat3.x) + u_xlat13;
					        u_xlat13 = (u_xlatb7.y) ? u_xlat5.x : u_xlat13;
					        u_xlat22 = u_xlat22 + 1.0;
					    }
					    u_xlat1.x = dot(vec2(u_xlat31), vec2(u_xlat29));
					    u_xlat1.x = 1.20000005 / u_xlat1.x;
					    u_xlat2.xyz = u_xlat10_0.xyz;
					    u_xlat2.w = 1.0;
					    u_xlat1 = u_xlat2 * u_xlat1.xxxx + u_xlat6;
					    SV_Target0.xyz = u_xlat1.xyz / u_xlat1.www;
					    SV_Target0.w = u_xlat10_0.w;
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					#if !defined(GL_EXT_shader_texture_lod)
					#define texture1DLodEXT texture1D
					#define texture2DLodEXT texture2D
					#define texture2DProjLodEXT texture2DProj
					#define texture3DLodEXT texture3D
					#define textureCubeLodEXT textureCube
					#endif
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _ScreenParams;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec2 _VelocityTex_TexelSize;
					uniform 	vec2 _NeighborMaxTex_TexelSize;
					uniform 	float _MaxBlurRadius;
					uniform 	float _LoopCount;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _VelocityTex;
					uniform lowp sampler2D _NeighborMaxTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					mediump vec2 u_xlat16_2;
					lowp vec3 u_xlat10_2;
					vec3 u_xlat3;
					float u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec3 u_xlat7;
					mediump vec3 u_xlat16_7;
					bvec2 u_xlatb7;
					vec2 u_xlat8;
					mediump float u_xlat16_8;
					lowp vec3 u_xlat10_8;
					float u_xlat13;
					float u_xlat19;
					vec2 u_xlat21;
					float u_xlat22;
					float u_xlat25;
					float u_xlat28;
					mediump float u_xlat16_28;
					bool u_xlatb28;
					float u_xlat29;
					bool u_xlatb29;
					float u_xlat31;
					float u_xlat34;
					void main()
					{
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1.xy = vs_TEXCOORD0.xy + vec2(2.0, 0.0);
					    u_xlat1.xy = u_xlat1.xy * _ScreenParams.xy;
					    u_xlat1.xy = floor(u_xlat1.xy);
					    u_xlat1.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat1.xy);
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 52.9829178;
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 6.28318548;
					    u_xlat2.x = cos(u_xlat1.x);
					    u_xlat1.x = sin(u_xlat1.x);
					    u_xlat2.y = u_xlat1.x;
					    u_xlat1.xy = u_xlat2.xy * vec2(_NeighborMaxTex_TexelSize.x, _NeighborMaxTex_TexelSize.y);
					    u_xlat1.xy = u_xlat1.xy * vec2(0.25, 0.25) + vs_TEXCOORD0.xy;
					    u_xlat1.xy = texture2D(_NeighborMaxTex, u_xlat1.xy).xy;
					    u_xlat19 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat19 = sqrt(u_xlat19);
					    u_xlatb28 = u_xlat19<2.0;
					    if(u_xlatb28){
					        SV_Target0 = u_xlat10_0;
					        return;
					    //ENDIF
					    }
					    u_xlat10_2.xyz = texture2DLodEXT(_VelocityTex, vs_TEXCOORD0.xy, 0.0).xyz;
					    u_xlat16_2.xy = u_xlat10_2.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat2.xy = u_xlat16_2.xy * vec2(_MaxBlurRadius);
					    u_xlat28 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat28 = sqrt(u_xlat28);
					    u_xlat3.xy = max(vec2(u_xlat28), vec2(0.5, 1.0));
					    u_xlat16_28 = float(1.0) / u_xlat10_2.z;
					    u_xlat29 = u_xlat3.x + u_xlat3.x;
					    u_xlatb29 = u_xlat19<u_xlat29;
					    u_xlat3.x = u_xlat19 / u_xlat3.x;
					    u_xlat2.xy = u_xlat2.xy * u_xlat3.xx;
					    u_xlat2.xy = (bool(u_xlatb29)) ? u_xlat2.xy : u_xlat1.xy;
					    u_xlat29 = u_xlat19 * 0.5;
					    u_xlat29 = min(u_xlat29, _LoopCount);
					    u_xlat29 = floor(u_xlat29);
					    u_xlat3.x = float(1.0) / u_xlat29;
					    u_xlat21.xy = vs_TEXCOORD0.xy * _ScreenParams.xy;
					    u_xlat21.xy = floor(u_xlat21.xy);
					    u_xlat21.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat21.xy);
					    u_xlat3.z = fract(u_xlat21.x);
					    u_xlat21.xy = u_xlat3.zx * vec2(52.9829178, 0.25);
					    u_xlat21.x = fract(u_xlat21.x);
					    u_xlat21.x = u_xlat21.x + -0.5;
					    u_xlat4 = (-u_xlat3.x) * 0.5 + 1.0;
					    u_xlat5.w = 1.0;
					    u_xlat6.x = float(0.0);
					    u_xlat6.y = float(0.0);
					    u_xlat6.z = float(0.0);
					    u_xlat6.w = float(0.0);
					    u_xlat13 = u_xlat4;
					    u_xlat22 = 0.0;
					    u_xlat31 = u_xlat3.y;
					    for(int u_xlati_while_true_0 = 0 ; u_xlati_while_true_0 < 0x7FFF ; u_xlati_while_true_0++){
					        u_xlatb7.x = u_xlat21.y>=u_xlat13;
					        if(u_xlatb7.x){break;}
					        u_xlat7.xy = vec2(u_xlat22) * vec2(0.25, 0.5);
					        u_xlat7.xy = fract(u_xlat7.xy);
					        u_xlatb7.xy = lessThan(vec4(0.499000013, 0.499000013, 0.0, 0.0), u_xlat7.xyxx).xy;
					        u_xlat7.xz = (u_xlatb7.x) ? u_xlat2.xy : u_xlat1.xy;
					        u_xlat34 = (u_xlatb7.y) ? (-u_xlat13) : u_xlat13;
					        u_xlat34 = u_xlat21.x * u_xlat3.x + u_xlat34;
					        u_xlat7.xz = vec2(u_xlat34) * u_xlat7.xz;
					        u_xlat8.xy = u_xlat7.xz * _MainTex_TexelSize.xy + vs_TEXCOORD0.xy;
					        u_xlat7.xz = u_xlat7.xz * _VelocityTex_TexelSize.xy + vs_TEXCOORD0.xy;
					        u_xlat5.xyz = texture2DLodEXT(_MainTex, u_xlat8.xy, 0.0).xyz;
					        u_xlat10_8.xyz = texture2DLodEXT(_VelocityTex, u_xlat7.xz, 0.0).xyz;
					        u_xlat16_7.xz = u_xlat10_8.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					        u_xlat7.xz = u_xlat16_7.xz * vec2(_MaxBlurRadius);
					        u_xlat16_8 = u_xlat10_2.z + (-u_xlat10_8.z);
					        u_xlat16_8 = u_xlat16_28 * u_xlat16_8;
					        u_xlat16_8 = u_xlat16_8 * 20.0;
					        u_xlat16_8 = clamp(u_xlat16_8, 0.0, 1.0);
					        u_xlat7.x = dot(u_xlat7.xz, u_xlat7.xz);
					        u_xlat7.x = sqrt(u_xlat7.x);
					        u_xlat7.x = (-u_xlat31) + u_xlat7.x;
					        u_xlat7.x = u_xlat16_8 * u_xlat7.x + u_xlat31;
					        u_xlat25 = (-u_xlat19) * abs(u_xlat34) + u_xlat7.x;
					        u_xlat25 = clamp(u_xlat25, 0.0, 1.0);
					        u_xlat25 = u_xlat25 / u_xlat7.x;
					        u_xlat34 = (-u_xlat13) + 1.20000005;
					        u_xlat25 = u_xlat34 * u_xlat25;
					        u_xlat6 = u_xlat5 * vec4(u_xlat25) + u_xlat6;
					        u_xlat31 = max(u_xlat31, u_xlat7.x);
					        u_xlat5.x = (-u_xlat3.x) + u_xlat13;
					        u_xlat13 = (u_xlatb7.y) ? u_xlat5.x : u_xlat13;
					        u_xlat22 = u_xlat22 + 1.0;
					    }
					    u_xlat1.x = dot(vec2(u_xlat31), vec2(u_xlat29));
					    u_xlat1.x = 1.20000005 / u_xlat1.x;
					    u_xlat2.xyz = u_xlat10_0.xyz;
					    u_xlat2.w = 1.0;
					    u_xlat1 = u_xlat2 * u_xlat1.xxxx + u_xlat6;
					    SV_Target0.xyz = u_xlat1.xyz / u_xlat1.www;
					    SV_Target0.w = u_xlat10_0.w;
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					#if !defined(GL_EXT_shader_texture_lod)
					#define texture1DLodEXT texture1D
					#define texture2DLodEXT texture2D
					#define texture2DProjLodEXT texture2DProj
					#define texture3DLodEXT texture3D
					#define textureCubeLodEXT textureCube
					#endif
					
					#ifdef GL_FRAGMENT_PRECISION_HIGH
					    precision highp float;
					#else
					    precision mediump float;
					#endif
					precision highp int;
					uniform 	vec4 _ScreenParams;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec2 _VelocityTex_TexelSize;
					uniform 	vec2 _NeighborMaxTex_TexelSize;
					uniform 	float _MaxBlurRadius;
					uniform 	float _LoopCount;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _VelocityTex;
					uniform lowp sampler2D _NeighborMaxTex;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					lowp vec4 u_xlat10_0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					mediump vec2 u_xlat16_2;
					lowp vec3 u_xlat10_2;
					vec3 u_xlat3;
					float u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec3 u_xlat7;
					mediump vec3 u_xlat16_7;
					bvec2 u_xlatb7;
					vec2 u_xlat8;
					mediump float u_xlat16_8;
					lowp vec3 u_xlat10_8;
					float u_xlat13;
					float u_xlat19;
					vec2 u_xlat21;
					float u_xlat22;
					float u_xlat25;
					float u_xlat28;
					mediump float u_xlat16_28;
					bool u_xlatb28;
					float u_xlat29;
					bool u_xlatb29;
					float u_xlat31;
					float u_xlat34;
					void main()
					{
					    u_xlat10_0 = texture2D(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1.xy = vs_TEXCOORD0.xy + vec2(2.0, 0.0);
					    u_xlat1.xy = u_xlat1.xy * _ScreenParams.xy;
					    u_xlat1.xy = floor(u_xlat1.xy);
					    u_xlat1.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat1.xy);
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 52.9829178;
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 6.28318548;
					    u_xlat2.x = cos(u_xlat1.x);
					    u_xlat1.x = sin(u_xlat1.x);
					    u_xlat2.y = u_xlat1.x;
					    u_xlat1.xy = u_xlat2.xy * vec2(_NeighborMaxTex_TexelSize.x, _NeighborMaxTex_TexelSize.y);
					    u_xlat1.xy = u_xlat1.xy * vec2(0.25, 0.25) + vs_TEXCOORD0.xy;
					    u_xlat1.xy = texture2D(_NeighborMaxTex, u_xlat1.xy).xy;
					    u_xlat19 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat19 = sqrt(u_xlat19);
					    u_xlatb28 = u_xlat19<2.0;
					    if(u_xlatb28){
					        SV_Target0 = u_xlat10_0;
					        return;
					    //ENDIF
					    }
					    u_xlat10_2.xyz = texture2DLodEXT(_VelocityTex, vs_TEXCOORD0.xy, 0.0).xyz;
					    u_xlat16_2.xy = u_xlat10_2.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat2.xy = u_xlat16_2.xy * vec2(_MaxBlurRadius);
					    u_xlat28 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat28 = sqrt(u_xlat28);
					    u_xlat3.xy = max(vec2(u_xlat28), vec2(0.5, 1.0));
					    u_xlat16_28 = float(1.0) / u_xlat10_2.z;
					    u_xlat29 = u_xlat3.x + u_xlat3.x;
					    u_xlatb29 = u_xlat19<u_xlat29;
					    u_xlat3.x = u_xlat19 / u_xlat3.x;
					    u_xlat2.xy = u_xlat2.xy * u_xlat3.xx;
					    u_xlat2.xy = (bool(u_xlatb29)) ? u_xlat2.xy : u_xlat1.xy;
					    u_xlat29 = u_xlat19 * 0.5;
					    u_xlat29 = min(u_xlat29, _LoopCount);
					    u_xlat29 = floor(u_xlat29);
					    u_xlat3.x = float(1.0) / u_xlat29;
					    u_xlat21.xy = vs_TEXCOORD0.xy * _ScreenParams.xy;
					    u_xlat21.xy = floor(u_xlat21.xy);
					    u_xlat21.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat21.xy);
					    u_xlat3.z = fract(u_xlat21.x);
					    u_xlat21.xy = u_xlat3.zx * vec2(52.9829178, 0.25);
					    u_xlat21.x = fract(u_xlat21.x);
					    u_xlat21.x = u_xlat21.x + -0.5;
					    u_xlat4 = (-u_xlat3.x) * 0.5 + 1.0;
					    u_xlat5.w = 1.0;
					    u_xlat6.x = float(0.0);
					    u_xlat6.y = float(0.0);
					    u_xlat6.z = float(0.0);
					    u_xlat6.w = float(0.0);
					    u_xlat13 = u_xlat4;
					    u_xlat22 = 0.0;
					    u_xlat31 = u_xlat3.y;
					    for(int u_xlati_while_true_0 = 0 ; u_xlati_while_true_0 < 0x7FFF ; u_xlati_while_true_0++){
					        u_xlatb7.x = u_xlat21.y>=u_xlat13;
					        if(u_xlatb7.x){break;}
					        u_xlat7.xy = vec2(u_xlat22) * vec2(0.25, 0.5);
					        u_xlat7.xy = fract(u_xlat7.xy);
					        u_xlatb7.xy = lessThan(vec4(0.499000013, 0.499000013, 0.0, 0.0), u_xlat7.xyxx).xy;
					        u_xlat7.xz = (u_xlatb7.x) ? u_xlat2.xy : u_xlat1.xy;
					        u_xlat34 = (u_xlatb7.y) ? (-u_xlat13) : u_xlat13;
					        u_xlat34 = u_xlat21.x * u_xlat3.x + u_xlat34;
					        u_xlat7.xz = vec2(u_xlat34) * u_xlat7.xz;
					        u_xlat8.xy = u_xlat7.xz * _MainTex_TexelSize.xy + vs_TEXCOORD0.xy;
					        u_xlat7.xz = u_xlat7.xz * _VelocityTex_TexelSize.xy + vs_TEXCOORD0.xy;
					        u_xlat5.xyz = texture2DLodEXT(_MainTex, u_xlat8.xy, 0.0).xyz;
					        u_xlat10_8.xyz = texture2DLodEXT(_VelocityTex, u_xlat7.xz, 0.0).xyz;
					        u_xlat16_7.xz = u_xlat10_8.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					        u_xlat7.xz = u_xlat16_7.xz * vec2(_MaxBlurRadius);
					        u_xlat16_8 = u_xlat10_2.z + (-u_xlat10_8.z);
					        u_xlat16_8 = u_xlat16_28 * u_xlat16_8;
					        u_xlat16_8 = u_xlat16_8 * 20.0;
					        u_xlat16_8 = clamp(u_xlat16_8, 0.0, 1.0);
					        u_xlat7.x = dot(u_xlat7.xz, u_xlat7.xz);
					        u_xlat7.x = sqrt(u_xlat7.x);
					        u_xlat7.x = (-u_xlat31) + u_xlat7.x;
					        u_xlat7.x = u_xlat16_8 * u_xlat7.x + u_xlat31;
					        u_xlat25 = (-u_xlat19) * abs(u_xlat34) + u_xlat7.x;
					        u_xlat25 = clamp(u_xlat25, 0.0, 1.0);
					        u_xlat25 = u_xlat25 / u_xlat7.x;
					        u_xlat34 = (-u_xlat13) + 1.20000005;
					        u_xlat25 = u_xlat34 * u_xlat25;
					        u_xlat6 = u_xlat5 * vec4(u_xlat25) + u_xlat6;
					        u_xlat31 = max(u_xlat31, u_xlat7.x);
					        u_xlat5.x = (-u_xlat3.x) + u_xlat13;
					        u_xlat13 = (u_xlatb7.y) ? u_xlat5.x : u_xlat13;
					        u_xlat22 = u_xlat22 + 1.0;
					    }
					    u_xlat1.x = dot(vec2(u_xlat31), vec2(u_xlat29));
					    u_xlat1.x = 1.20000005 / u_xlat1.x;
					    u_xlat2.xyz = u_xlat10_0.xyz;
					    u_xlat2.w = 1.0;
					    u_xlat1 = u_xlat2 * u_xlat1.xxxx + u_xlat6;
					    SV_Target0.xyz = u_xlat1.xyz / u_xlat1.www;
					    SV_Target0.w = u_xlat10_0.w;
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _ScreenParams;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec2 _VelocityTex_TexelSize;
					uniform 	vec2 _NeighborMaxTex_TexelSize;
					uniform 	float _MaxBlurRadius;
					uniform 	float _LoopCount;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _VelocityTex;
					uniform mediump sampler2D _NeighborMaxTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					mediump vec3 u_xlat16_2;
					vec3 u_xlat3;
					float u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec3 u_xlat7;
					mediump vec3 u_xlat16_7;
					bvec2 u_xlatb7;
					vec2 u_xlat8;
					mediump vec3 u_xlat16_8;
					float u_xlat13;
					float u_xlat19;
					vec2 u_xlat21;
					float u_xlat22;
					float u_xlat25;
					float u_xlat28;
					mediump float u_xlat16_28;
					bool u_xlatb28;
					float u_xlat29;
					bool u_xlatb29;
					float u_xlat31;
					float u_xlat34;
					void main()
					{
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1.xy = vs_TEXCOORD0.xy + vec2(2.0, 0.0);
					    u_xlat1.xy = u_xlat1.xy * _ScreenParams.xy;
					    u_xlat1.xy = floor(u_xlat1.xy);
					    u_xlat1.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat1.xy);
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 52.9829178;
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 6.28318548;
					    u_xlat2.x = cos(u_xlat1.x);
					    u_xlat1.x = sin(u_xlat1.x);
					    u_xlat2.y = u_xlat1.x;
					    u_xlat1.xy = u_xlat2.xy * vec2(_NeighborMaxTex_TexelSize.x, _NeighborMaxTex_TexelSize.y);
					    u_xlat1.xy = u_xlat1.xy * vec2(0.25, 0.25) + vs_TEXCOORD0.xy;
					    u_xlat1.xy = texture(_NeighborMaxTex, u_xlat1.xy).xy;
					    u_xlat19 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat19 = sqrt(u_xlat19);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb28 = !!(u_xlat19<2.0);
					#else
					    u_xlatb28 = u_xlat19<2.0;
					#endif
					    if(u_xlatb28){
					        SV_Target0 = u_xlat16_0;
					        return;
					    //ENDIF
					    }
					    u_xlat16_2.xyz = textureLod(_VelocityTex, vs_TEXCOORD0.xy, 0.0).xyz;
					    u_xlat16_2.xy = u_xlat16_2.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat2.xy = u_xlat16_2.xy * vec2(_MaxBlurRadius);
					    u_xlat28 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat28 = sqrt(u_xlat28);
					    u_xlat3.xy = max(vec2(u_xlat28), vec2(0.5, 1.0));
					    u_xlat16_28 = float(1.0) / u_xlat16_2.z;
					    u_xlat29 = u_xlat3.x + u_xlat3.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb29 = !!(u_xlat19<u_xlat29);
					#else
					    u_xlatb29 = u_xlat19<u_xlat29;
					#endif
					    u_xlat3.x = u_xlat19 / u_xlat3.x;
					    u_xlat2.xy = u_xlat2.xy * u_xlat3.xx;
					    u_xlat2.xy = (bool(u_xlatb29)) ? u_xlat2.xy : u_xlat1.xy;
					    u_xlat29 = u_xlat19 * 0.5;
					    u_xlat29 = min(u_xlat29, _LoopCount);
					    u_xlat29 = floor(u_xlat29);
					    u_xlat3.x = float(1.0) / u_xlat29;
					    u_xlat21.xy = vs_TEXCOORD0.xy * _ScreenParams.xy;
					    u_xlat21.xy = floor(u_xlat21.xy);
					    u_xlat21.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat21.xy);
					    u_xlat3.z = fract(u_xlat21.x);
					    u_xlat21.xy = u_xlat3.zx * vec2(52.9829178, 0.25);
					    u_xlat21.x = fract(u_xlat21.x);
					    u_xlat21.x = u_xlat21.x + -0.5;
					    u_xlat4 = (-u_xlat3.x) * 0.5 + 1.0;
					    u_xlat5.w = 1.0;
					    u_xlat6.x = float(0.0);
					    u_xlat6.y = float(0.0);
					    u_xlat6.z = float(0.0);
					    u_xlat6.w = float(0.0);
					    u_xlat13 = u_xlat4;
					    u_xlat22 = 0.0;
					    u_xlat31 = u_xlat3.y;
					    while(true){
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb7.x = !!(u_xlat21.y>=u_xlat13);
					#else
					        u_xlatb7.x = u_xlat21.y>=u_xlat13;
					#endif
					        if(u_xlatb7.x){break;}
					        u_xlat7.xy = vec2(u_xlat22) * vec2(0.25, 0.5);
					        u_xlat7.xy = fract(u_xlat7.xy);
					        u_xlatb7.xy = lessThan(vec4(0.499000013, 0.499000013, 0.0, 0.0), u_xlat7.xyxx).xy;
					        u_xlat7.xz = (u_xlatb7.x) ? u_xlat2.xy : u_xlat1.xy;
					        u_xlat34 = (u_xlatb7.y) ? (-u_xlat13) : u_xlat13;
					        u_xlat34 = u_xlat21.x * u_xlat3.x + u_xlat34;
					        u_xlat7.xz = vec2(u_xlat34) * u_xlat7.xz;
					        u_xlat8.xy = u_xlat7.xz * _MainTex_TexelSize.xy + vs_TEXCOORD0.xy;
					        u_xlat7.xz = u_xlat7.xz * _VelocityTex_TexelSize.xy + vs_TEXCOORD0.xy;
					        u_xlat5.xyz = textureLod(_MainTex, u_xlat8.xy, 0.0).xyz;
					        u_xlat16_8.xyz = textureLod(_VelocityTex, u_xlat7.xz, 0.0).xyz;
					        u_xlat16_7.xz = u_xlat16_8.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					        u_xlat7.xz = u_xlat16_7.xz * vec2(_MaxBlurRadius);
					        u_xlat16_8.x = u_xlat16_2.z + (-u_xlat16_8.z);
					        u_xlat16_8.x = u_xlat16_28 * u_xlat16_8.x;
					        u_xlat16_8.x = u_xlat16_8.x * 20.0;
					#ifdef UNITY_ADRENO_ES3
					        u_xlat16_8.x = min(max(u_xlat16_8.x, 0.0), 1.0);
					#else
					        u_xlat16_8.x = clamp(u_xlat16_8.x, 0.0, 1.0);
					#endif
					        u_xlat7.x = dot(u_xlat7.xz, u_xlat7.xz);
					        u_xlat7.x = sqrt(u_xlat7.x);
					        u_xlat7.x = (-u_xlat31) + u_xlat7.x;
					        u_xlat7.x = u_xlat16_8.x * u_xlat7.x + u_xlat31;
					        u_xlat25 = (-u_xlat19) * abs(u_xlat34) + u_xlat7.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlat25 = min(max(u_xlat25, 0.0), 1.0);
					#else
					        u_xlat25 = clamp(u_xlat25, 0.0, 1.0);
					#endif
					        u_xlat25 = u_xlat25 / u_xlat7.x;
					        u_xlat34 = (-u_xlat13) + 1.20000005;
					        u_xlat25 = u_xlat34 * u_xlat25;
					        u_xlat6 = u_xlat5 * vec4(u_xlat25) + u_xlat6;
					        u_xlat31 = max(u_xlat31, u_xlat7.x);
					        u_xlat5.x = (-u_xlat3.x) + u_xlat13;
					        u_xlat13 = (u_xlatb7.y) ? u_xlat5.x : u_xlat13;
					        u_xlat22 = u_xlat22 + 1.0;
					    }
					    u_xlat1.x = dot(vec2(u_xlat31), vec2(u_xlat29));
					    u_xlat1.x = 1.20000005 / u_xlat1.x;
					    u_xlat2.xyz = u_xlat16_0.xyz;
					    u_xlat2.w = 1.0;
					    u_xlat1 = u_xlat2 * u_xlat1.xxxx + u_xlat6;
					    SV_Target0.xyz = u_xlat1.xyz / u_xlat1.www;
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _ScreenParams;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec2 _VelocityTex_TexelSize;
					uniform 	vec2 _NeighborMaxTex_TexelSize;
					uniform 	float _MaxBlurRadius;
					uniform 	float _LoopCount;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _VelocityTex;
					uniform mediump sampler2D _NeighborMaxTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					mediump vec3 u_xlat16_2;
					vec3 u_xlat3;
					float u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec3 u_xlat7;
					mediump vec3 u_xlat16_7;
					bvec2 u_xlatb7;
					vec2 u_xlat8;
					mediump vec3 u_xlat16_8;
					float u_xlat13;
					float u_xlat19;
					vec2 u_xlat21;
					float u_xlat22;
					float u_xlat25;
					float u_xlat28;
					mediump float u_xlat16_28;
					bool u_xlatb28;
					float u_xlat29;
					bool u_xlatb29;
					float u_xlat31;
					float u_xlat34;
					void main()
					{
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1.xy = vs_TEXCOORD0.xy + vec2(2.0, 0.0);
					    u_xlat1.xy = u_xlat1.xy * _ScreenParams.xy;
					    u_xlat1.xy = floor(u_xlat1.xy);
					    u_xlat1.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat1.xy);
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 52.9829178;
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 6.28318548;
					    u_xlat2.x = cos(u_xlat1.x);
					    u_xlat1.x = sin(u_xlat1.x);
					    u_xlat2.y = u_xlat1.x;
					    u_xlat1.xy = u_xlat2.xy * vec2(_NeighborMaxTex_TexelSize.x, _NeighborMaxTex_TexelSize.y);
					    u_xlat1.xy = u_xlat1.xy * vec2(0.25, 0.25) + vs_TEXCOORD0.xy;
					    u_xlat1.xy = texture(_NeighborMaxTex, u_xlat1.xy).xy;
					    u_xlat19 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat19 = sqrt(u_xlat19);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb28 = !!(u_xlat19<2.0);
					#else
					    u_xlatb28 = u_xlat19<2.0;
					#endif
					    if(u_xlatb28){
					        SV_Target0 = u_xlat16_0;
					        return;
					    //ENDIF
					    }
					    u_xlat16_2.xyz = textureLod(_VelocityTex, vs_TEXCOORD0.xy, 0.0).xyz;
					    u_xlat16_2.xy = u_xlat16_2.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat2.xy = u_xlat16_2.xy * vec2(_MaxBlurRadius);
					    u_xlat28 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat28 = sqrt(u_xlat28);
					    u_xlat3.xy = max(vec2(u_xlat28), vec2(0.5, 1.0));
					    u_xlat16_28 = float(1.0) / u_xlat16_2.z;
					    u_xlat29 = u_xlat3.x + u_xlat3.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb29 = !!(u_xlat19<u_xlat29);
					#else
					    u_xlatb29 = u_xlat19<u_xlat29;
					#endif
					    u_xlat3.x = u_xlat19 / u_xlat3.x;
					    u_xlat2.xy = u_xlat2.xy * u_xlat3.xx;
					    u_xlat2.xy = (bool(u_xlatb29)) ? u_xlat2.xy : u_xlat1.xy;
					    u_xlat29 = u_xlat19 * 0.5;
					    u_xlat29 = min(u_xlat29, _LoopCount);
					    u_xlat29 = floor(u_xlat29);
					    u_xlat3.x = float(1.0) / u_xlat29;
					    u_xlat21.xy = vs_TEXCOORD0.xy * _ScreenParams.xy;
					    u_xlat21.xy = floor(u_xlat21.xy);
					    u_xlat21.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat21.xy);
					    u_xlat3.z = fract(u_xlat21.x);
					    u_xlat21.xy = u_xlat3.zx * vec2(52.9829178, 0.25);
					    u_xlat21.x = fract(u_xlat21.x);
					    u_xlat21.x = u_xlat21.x + -0.5;
					    u_xlat4 = (-u_xlat3.x) * 0.5 + 1.0;
					    u_xlat5.w = 1.0;
					    u_xlat6.x = float(0.0);
					    u_xlat6.y = float(0.0);
					    u_xlat6.z = float(0.0);
					    u_xlat6.w = float(0.0);
					    u_xlat13 = u_xlat4;
					    u_xlat22 = 0.0;
					    u_xlat31 = u_xlat3.y;
					    while(true){
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb7.x = !!(u_xlat21.y>=u_xlat13);
					#else
					        u_xlatb7.x = u_xlat21.y>=u_xlat13;
					#endif
					        if(u_xlatb7.x){break;}
					        u_xlat7.xy = vec2(u_xlat22) * vec2(0.25, 0.5);
					        u_xlat7.xy = fract(u_xlat7.xy);
					        u_xlatb7.xy = lessThan(vec4(0.499000013, 0.499000013, 0.0, 0.0), u_xlat7.xyxx).xy;
					        u_xlat7.xz = (u_xlatb7.x) ? u_xlat2.xy : u_xlat1.xy;
					        u_xlat34 = (u_xlatb7.y) ? (-u_xlat13) : u_xlat13;
					        u_xlat34 = u_xlat21.x * u_xlat3.x + u_xlat34;
					        u_xlat7.xz = vec2(u_xlat34) * u_xlat7.xz;
					        u_xlat8.xy = u_xlat7.xz * _MainTex_TexelSize.xy + vs_TEXCOORD0.xy;
					        u_xlat7.xz = u_xlat7.xz * _VelocityTex_TexelSize.xy + vs_TEXCOORD0.xy;
					        u_xlat5.xyz = textureLod(_MainTex, u_xlat8.xy, 0.0).xyz;
					        u_xlat16_8.xyz = textureLod(_VelocityTex, u_xlat7.xz, 0.0).xyz;
					        u_xlat16_7.xz = u_xlat16_8.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					        u_xlat7.xz = u_xlat16_7.xz * vec2(_MaxBlurRadius);
					        u_xlat16_8.x = u_xlat16_2.z + (-u_xlat16_8.z);
					        u_xlat16_8.x = u_xlat16_28 * u_xlat16_8.x;
					        u_xlat16_8.x = u_xlat16_8.x * 20.0;
					#ifdef UNITY_ADRENO_ES3
					        u_xlat16_8.x = min(max(u_xlat16_8.x, 0.0), 1.0);
					#else
					        u_xlat16_8.x = clamp(u_xlat16_8.x, 0.0, 1.0);
					#endif
					        u_xlat7.x = dot(u_xlat7.xz, u_xlat7.xz);
					        u_xlat7.x = sqrt(u_xlat7.x);
					        u_xlat7.x = (-u_xlat31) + u_xlat7.x;
					        u_xlat7.x = u_xlat16_8.x * u_xlat7.x + u_xlat31;
					        u_xlat25 = (-u_xlat19) * abs(u_xlat34) + u_xlat7.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlat25 = min(max(u_xlat25, 0.0), 1.0);
					#else
					        u_xlat25 = clamp(u_xlat25, 0.0, 1.0);
					#endif
					        u_xlat25 = u_xlat25 / u_xlat7.x;
					        u_xlat34 = (-u_xlat13) + 1.20000005;
					        u_xlat25 = u_xlat34 * u_xlat25;
					        u_xlat6 = u_xlat5 * vec4(u_xlat25) + u_xlat6;
					        u_xlat31 = max(u_xlat31, u_xlat7.x);
					        u_xlat5.x = (-u_xlat3.x) + u_xlat13;
					        u_xlat13 = (u_xlatb7.y) ? u_xlat5.x : u_xlat13;
					        u_xlat22 = u_xlat22 + 1.0;
					    }
					    u_xlat1.x = dot(vec2(u_xlat31), vec2(u_xlat29));
					    u_xlat1.x = 1.20000005 / u_xlat1.x;
					    u_xlat2.xyz = u_xlat16_0.xyz;
					    u_xlat2.w = 1.0;
					    u_xlat1 = u_xlat2 * u_xlat1.xxxx + u_xlat6;
					    SV_Target0.xyz = u_xlat1.xyz / u_xlat1.www;
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _ScreenParams;
					uniform 	vec4 _MainTex_TexelSize;
					uniform 	vec2 _VelocityTex_TexelSize;
					uniform 	vec2 _NeighborMaxTex_TexelSize;
					uniform 	float _MaxBlurRadius;
					uniform 	float _LoopCount;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _VelocityTex;
					uniform mediump sampler2D _NeighborMaxTex;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					mediump vec4 u_xlat16_0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					mediump vec3 u_xlat16_2;
					vec3 u_xlat3;
					float u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec3 u_xlat7;
					mediump vec3 u_xlat16_7;
					bvec2 u_xlatb7;
					vec2 u_xlat8;
					mediump vec3 u_xlat16_8;
					float u_xlat13;
					float u_xlat19;
					vec2 u_xlat21;
					float u_xlat22;
					float u_xlat25;
					float u_xlat28;
					mediump float u_xlat16_28;
					bool u_xlatb28;
					float u_xlat29;
					bool u_xlatb29;
					float u_xlat31;
					float u_xlat34;
					void main()
					{
					    u_xlat16_0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1.xy = vs_TEXCOORD0.xy + vec2(2.0, 0.0);
					    u_xlat1.xy = u_xlat1.xy * _ScreenParams.xy;
					    u_xlat1.xy = floor(u_xlat1.xy);
					    u_xlat1.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat1.xy);
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 52.9829178;
					    u_xlat1.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat1.x * 6.28318548;
					    u_xlat2.x = cos(u_xlat1.x);
					    u_xlat1.x = sin(u_xlat1.x);
					    u_xlat2.y = u_xlat1.x;
					    u_xlat1.xy = u_xlat2.xy * vec2(_NeighborMaxTex_TexelSize.x, _NeighborMaxTex_TexelSize.y);
					    u_xlat1.xy = u_xlat1.xy * vec2(0.25, 0.25) + vs_TEXCOORD0.xy;
					    u_xlat1.xy = texture(_NeighborMaxTex, u_xlat1.xy).xy;
					    u_xlat19 = dot(u_xlat1.xy, u_xlat1.xy);
					    u_xlat19 = sqrt(u_xlat19);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb28 = !!(u_xlat19<2.0);
					#else
					    u_xlatb28 = u_xlat19<2.0;
					#endif
					    if(u_xlatb28){
					        SV_Target0 = u_xlat16_0;
					        return;
					    //ENDIF
					    }
					    u_xlat16_2.xyz = textureLod(_VelocityTex, vs_TEXCOORD0.xy, 0.0).xyz;
					    u_xlat16_2.xy = u_xlat16_2.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					    u_xlat2.xy = u_xlat16_2.xy * vec2(_MaxBlurRadius);
					    u_xlat28 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat28 = sqrt(u_xlat28);
					    u_xlat3.xy = max(vec2(u_xlat28), vec2(0.5, 1.0));
					    u_xlat16_28 = float(1.0) / u_xlat16_2.z;
					    u_xlat29 = u_xlat3.x + u_xlat3.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb29 = !!(u_xlat19<u_xlat29);
					#else
					    u_xlatb29 = u_xlat19<u_xlat29;
					#endif
					    u_xlat3.x = u_xlat19 / u_xlat3.x;
					    u_xlat2.xy = u_xlat2.xy * u_xlat3.xx;
					    u_xlat2.xy = (bool(u_xlatb29)) ? u_xlat2.xy : u_xlat1.xy;
					    u_xlat29 = u_xlat19 * 0.5;
					    u_xlat29 = min(u_xlat29, _LoopCount);
					    u_xlat29 = floor(u_xlat29);
					    u_xlat3.x = float(1.0) / u_xlat29;
					    u_xlat21.xy = vs_TEXCOORD0.xy * _ScreenParams.xy;
					    u_xlat21.xy = floor(u_xlat21.xy);
					    u_xlat21.x = dot(vec2(0.0671105608, 0.00583714992), u_xlat21.xy);
					    u_xlat3.z = fract(u_xlat21.x);
					    u_xlat21.xy = u_xlat3.zx * vec2(52.9829178, 0.25);
					    u_xlat21.x = fract(u_xlat21.x);
					    u_xlat21.x = u_xlat21.x + -0.5;
					    u_xlat4 = (-u_xlat3.x) * 0.5 + 1.0;
					    u_xlat5.w = 1.0;
					    u_xlat6.x = float(0.0);
					    u_xlat6.y = float(0.0);
					    u_xlat6.z = float(0.0);
					    u_xlat6.w = float(0.0);
					    u_xlat13 = u_xlat4;
					    u_xlat22 = 0.0;
					    u_xlat31 = u_xlat3.y;
					    while(true){
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb7.x = !!(u_xlat21.y>=u_xlat13);
					#else
					        u_xlatb7.x = u_xlat21.y>=u_xlat13;
					#endif
					        if(u_xlatb7.x){break;}
					        u_xlat7.xy = vec2(u_xlat22) * vec2(0.25, 0.5);
					        u_xlat7.xy = fract(u_xlat7.xy);
					        u_xlatb7.xy = lessThan(vec4(0.499000013, 0.499000013, 0.0, 0.0), u_xlat7.xyxx).xy;
					        u_xlat7.xz = (u_xlatb7.x) ? u_xlat2.xy : u_xlat1.xy;
					        u_xlat34 = (u_xlatb7.y) ? (-u_xlat13) : u_xlat13;
					        u_xlat34 = u_xlat21.x * u_xlat3.x + u_xlat34;
					        u_xlat7.xz = vec2(u_xlat34) * u_xlat7.xz;
					        u_xlat8.xy = u_xlat7.xz * _MainTex_TexelSize.xy + vs_TEXCOORD0.xy;
					        u_xlat7.xz = u_xlat7.xz * _VelocityTex_TexelSize.xy + vs_TEXCOORD0.xy;
					        u_xlat5.xyz = textureLod(_MainTex, u_xlat8.xy, 0.0).xyz;
					        u_xlat16_8.xyz = textureLod(_VelocityTex, u_xlat7.xz, 0.0).xyz;
					        u_xlat16_7.xz = u_xlat16_8.xy * vec2(2.0, 2.0) + vec2(-1.0, -1.0);
					        u_xlat7.xz = u_xlat16_7.xz * vec2(_MaxBlurRadius);
					        u_xlat16_8.x = u_xlat16_2.z + (-u_xlat16_8.z);
					        u_xlat16_8.x = u_xlat16_28 * u_xlat16_8.x;
					        u_xlat16_8.x = u_xlat16_8.x * 20.0;
					#ifdef UNITY_ADRENO_ES3
					        u_xlat16_8.x = min(max(u_xlat16_8.x, 0.0), 1.0);
					#else
					        u_xlat16_8.x = clamp(u_xlat16_8.x, 0.0, 1.0);
					#endif
					        u_xlat7.x = dot(u_xlat7.xz, u_xlat7.xz);
					        u_xlat7.x = sqrt(u_xlat7.x);
					        u_xlat7.x = (-u_xlat31) + u_xlat7.x;
					        u_xlat7.x = u_xlat16_8.x * u_xlat7.x + u_xlat31;
					        u_xlat25 = (-u_xlat19) * abs(u_xlat34) + u_xlat7.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlat25 = min(max(u_xlat25, 0.0), 1.0);
					#else
					        u_xlat25 = clamp(u_xlat25, 0.0, 1.0);
					#endif
					        u_xlat25 = u_xlat25 / u_xlat7.x;
					        u_xlat34 = (-u_xlat13) + 1.20000005;
					        u_xlat25 = u_xlat34 * u_xlat25;
					        u_xlat6 = u_xlat5 * vec4(u_xlat25) + u_xlat6;
					        u_xlat31 = max(u_xlat31, u_xlat7.x);
					        u_xlat5.x = (-u_xlat3.x) + u_xlat13;
					        u_xlat13 = (u_xlatb7.y) ? u_xlat5.x : u_xlat13;
					        u_xlat22 = u_xlat22 + 1.0;
					    }
					    u_xlat1.x = dot(vec2(u_xlat31), vec2(u_xlat29));
					    u_xlat1.x = 1.20000005 / u_xlat1.x;
					    u_xlat2.xyz = u_xlat16_0.xyz;
					    u_xlat2.w = 1.0;
					    u_xlat1 = u_xlat2 * u_xlat1.xxxx + u_xlat6;
					    SV_Target0.xyz = u_xlat1.xyz / u_xlat1.www;
					    SV_Target0.w = u_xlat16_0.w;
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