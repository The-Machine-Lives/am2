Shader "Hidden/PostProcessing/TemporalAntialiasing" {
	Properties {
	}
	SubShader {
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 23159
			Program "vp" {
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
					uniform 	vec4 _CameraDepthTexture_TexelSize;
					uniform 	vec2 _Jitter;
					uniform 	vec4 _FinalBlendParameters;
					uniform 	float _Sharpness;
					uniform highp sampler2D _CameraDepthTexture;
					uniform mediump sampler2D _CameraMotionVectorsTexture;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _HistoryTex;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					layout(location = 1) out highp vec4 SV_Target1;
					vec4 u_xlat0;
					mediump vec2 u_xlat16_0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec3 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					vec3 u_xlat5;
					mediump vec4 u_xlat16_5;
					vec4 u_xlat6;
					mediump vec4 u_xlat16_6;
					vec3 u_xlat7;
					mediump float u_xlat16_7;
					vec2 u_xlat14;
					mediump float u_xlat16_14;
					bool u_xlatb14;
					float u_xlat21;
					bool u_xlatb21;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD1.xy + (-_CameraDepthTexture_TexelSize.xy);
					    u_xlat0.xy = max(u_xlat0.xy, vec2(0.0, 0.0));
					    u_xlat0.xy = min(u_xlat0.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat0.z = texture(_CameraDepthTexture, u_xlat0.xy).x;
					    u_xlat1.z = texture(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb21 = !!(u_xlat0.z>=u_xlat1.z);
					#else
					    u_xlatb21 = u_xlat0.z>=u_xlat1.z;
					#endif
					    u_xlat21 = u_xlatb21 ? 1.0 : float(0.0);
					    u_xlat0.x = float(-1.0);
					    u_xlat0.y = float(-1.0);
					    u_xlat1.x = float(0.0);
					    u_xlat1.y = float(0.0);
					    u_xlat0.xyz = u_xlat0.xyz + (-u_xlat1.yyz);
					    u_xlat0.xyz = vec3(u_xlat21) * u_xlat0.xyz + u_xlat1.xyz;
					    u_xlat1.x = float(1.0);
					    u_xlat1.y = float(-1.0);
					    u_xlat2 = _CameraDepthTexture_TexelSize.xyxy * vec4(1.0, -1.0, -1.0, 1.0) + vs_TEXCOORD1.xyxy;
					    u_xlat2 = max(u_xlat2, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat2 = min(u_xlat2, vec4(_RenderViewportScaleFactor));
					    u_xlat1.z = texture(_CameraDepthTexture, u_xlat2.xy).x;
					    u_xlat2.z = texture(_CameraDepthTexture, u_xlat2.zw).x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb21 = !!(u_xlat1.z>=u_xlat0.z);
					#else
					    u_xlatb21 = u_xlat1.z>=u_xlat0.z;
					#endif
					    u_xlat21 = u_xlatb21 ? 1.0 : float(0.0);
					    u_xlat1.xyz = (-u_xlat0.yyz) + u_xlat1.xyz;
					    u_xlat0.xyz = vec3(u_xlat21) * u_xlat1.xyz + u_xlat0.xyz;
					    u_xlat2.x = float(-1.0);
					    u_xlat2.y = float(1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb21 = !!(u_xlat2.z>=u_xlat0.z);
					#else
					    u_xlatb21 = u_xlat2.z>=u_xlat0.z;
					#endif
					    u_xlat21 = u_xlatb21 ? 1.0 : float(0.0);
					    u_xlat1.xyz = (-u_xlat0.xyz) + u_xlat2.xyz;
					    u_xlat0.xyz = vec3(u_xlat21) * u_xlat1.xyz + u_xlat0.xyz;
					    u_xlat1.xy = vs_TEXCOORD1.xy + _CameraDepthTexture_TexelSize.xy;
					    u_xlat1.xy = max(u_xlat1.xy, vec2(0.0, 0.0));
					    u_xlat1.xy = min(u_xlat1.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat21 = texture(_CameraDepthTexture, u_xlat1.xy).x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb14 = !!(u_xlat21>=u_xlat0.z);
					#else
					    u_xlatb14 = u_xlat21>=u_xlat0.z;
					#endif
					    u_xlat14.x = u_xlatb14 ? 1.0 : float(0.0);
					    u_xlat1.xy = (-u_xlat0.xy) + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat14.xx * u_xlat1.xy + u_xlat0.xy;
					    u_xlat0.xy = u_xlat0.xy * _CameraDepthTexture_TexelSize.xy + vs_TEXCOORD1.xy;
					    u_xlat16_0.xy = texture(_CameraMotionVectorsTexture, u_xlat0.xy).xy;
					    u_xlat16_14 = dot(u_xlat16_0.xy, u_xlat16_0.xy);
					    u_xlat0.xy = (-u_xlat16_0.xy) + vs_TEXCOORD1.xy;
					    u_xlat0.xy = max(u_xlat0.xy, vec2(0.0, 0.0));
					    u_xlat0.xy = min(u_xlat0.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat1 = texture(_HistoryTex, u_xlat0.xy);
					    u_xlat16_0.x = sqrt(u_xlat16_14);
					    u_xlat16_7 = u_xlat16_0.x * 100.0;
					    u_xlat0.x = u_xlat16_0.x * _FinalBlendParameters.z;
					    u_xlat16_7 = min(u_xlat16_7, 1.0);
					    u_xlat16_7 = u_xlat16_7 * -3.75 + 4.0;
					    u_xlat14.xy = vs_TEXCOORD1.xy + (-_Jitter.xy);
					    u_xlat14.xy = max(u_xlat14.xy, vec2(0.0, 0.0));
					    u_xlat14.xy = min(u_xlat14.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat2.xy = (-_MainTex_TexelSize.xy) * vec2(0.5, 0.5) + u_xlat14.xy;
					    u_xlat2.xy = max(u_xlat2.xy, vec2(0.0, 0.0));
					    u_xlat2.xy = min(u_xlat2.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat16_2 = texture(_MainTex, u_xlat2.xy);
					    u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.5, 0.5) + u_xlat14.xy;
					    u_xlat16_4 = texture(_MainTex, u_xlat14.xy);
					    u_xlat14.xy = max(u_xlat3.xy, vec2(0.0, 0.0));
					    u_xlat14.xy = min(u_xlat14.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat16_3 = texture(_MainTex, u_xlat14.xy);
					    u_xlat16_5 = u_xlat16_2 + u_xlat16_3;
					    u_xlat16_6 = u_xlat16_4 + u_xlat16_4;
					    u_xlat16_5 = u_xlat16_5 * vec4(4.0, 4.0, 4.0, 4.0) + (-u_xlat16_6);
					    u_xlat16_6 = (-u_xlat16_5) * vec4(0.166666999, 0.166666999, 0.166666999, 0.166666999) + u_xlat16_4;
					    u_xlat6 = u_xlat16_6 * vec4(_Sharpness);
					    u_xlat4 = u_xlat6 * vec4(2.71828198, 2.71828198, 2.71828198, 2.71828198) + u_xlat16_4;
					    u_xlat4 = max(u_xlat4, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat4 = min(u_xlat4, vec4(65472.0, 65472.0, 65472.0, 65472.0));
					    u_xlat5.xyz = u_xlat4.xyz + u_xlat16_5.xyz;
					    u_xlat5.xyz = u_xlat5.xyz * vec3(0.142857, 0.142857, 0.142857);
					    u_xlat14.x = dot(u_xlat5.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat21 = dot(u_xlat4.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat14.x = (-u_xlat21) + u_xlat14.x;
					    u_xlat16_5.xyz = min(u_xlat16_2.xyz, u_xlat16_3.xyz);
					    u_xlat16_2.xyz = max(u_xlat16_2.xyz, u_xlat16_3.xyz);
					    u_xlat2.xyz = vec3(u_xlat16_7) * abs(u_xlat14.xxx) + u_xlat16_2.xyz;
					    u_xlat7.xyz = (-vec3(u_xlat16_7)) * abs(u_xlat14.xxx) + u_xlat16_5.xyz;
					    u_xlat3.xyz = (-u_xlat7.xyz) + u_xlat2.xyz;
					    u_xlat7.xyz = u_xlat7.xyz + u_xlat2.xyz;
					    u_xlat2.xyz = u_xlat3.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat3.xyz = (-u_xlat7.xyz) * vec3(0.5, 0.5, 0.5) + u_xlat1.xyz;
					    u_xlat7.xyz = u_xlat7.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat5.xyz = u_xlat3.xyz + vec3(9.99999975e-05, 9.99999975e-05, 9.99999975e-05);
					    u_xlat2.xyz = u_xlat2.xyz / u_xlat5.xyz;
					    u_xlat2.x = min(abs(u_xlat2.y), abs(u_xlat2.x));
					    u_xlat2.x = min(abs(u_xlat2.z), u_xlat2.x);
					    u_xlat2.x = min(u_xlat2.x, 1.0);
					    u_xlat1.xyz = u_xlat3.xyz * u_xlat2.xxx + u_xlat7.xyz;
					    u_xlat1 = (-u_xlat4) + u_xlat1;
					    u_xlat7.x = (-_FinalBlendParameters.x) + _FinalBlendParameters.y;
					    u_xlat0.x = u_xlat0.x * u_xlat7.x + _FinalBlendParameters.x;
					    u_xlat0.x = max(u_xlat0.x, _FinalBlendParameters.y);
					    u_xlat0.x = min(u_xlat0.x, _FinalBlendParameters.x);
					    u_xlat0 = u_xlat0.xxxx * u_xlat1 + u_xlat4;
					    u_xlat0 = max(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat0 = min(u_xlat0, vec4(65472.0, 65472.0, 65472.0, 65472.0));
					    SV_Target0 = u_xlat0;
					    SV_Target1 = u_xlat0;
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
					uniform 	vec4 _CameraDepthTexture_TexelSize;
					uniform 	vec2 _Jitter;
					uniform 	vec4 _FinalBlendParameters;
					uniform 	float _Sharpness;
					uniform highp sampler2D _CameraDepthTexture;
					uniform mediump sampler2D _CameraMotionVectorsTexture;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _HistoryTex;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					layout(location = 1) out highp vec4 SV_Target1;
					vec4 u_xlat0;
					mediump vec2 u_xlat16_0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec3 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					vec3 u_xlat5;
					mediump vec4 u_xlat16_5;
					vec4 u_xlat6;
					mediump vec4 u_xlat16_6;
					vec3 u_xlat7;
					mediump float u_xlat16_7;
					vec2 u_xlat14;
					mediump float u_xlat16_14;
					bool u_xlatb14;
					float u_xlat21;
					bool u_xlatb21;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD1.xy + (-_CameraDepthTexture_TexelSize.xy);
					    u_xlat0.xy = max(u_xlat0.xy, vec2(0.0, 0.0));
					    u_xlat0.xy = min(u_xlat0.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat0.z = texture(_CameraDepthTexture, u_xlat0.xy).x;
					    u_xlat1.z = texture(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb21 = !!(u_xlat0.z>=u_xlat1.z);
					#else
					    u_xlatb21 = u_xlat0.z>=u_xlat1.z;
					#endif
					    u_xlat21 = u_xlatb21 ? 1.0 : float(0.0);
					    u_xlat0.x = float(-1.0);
					    u_xlat0.y = float(-1.0);
					    u_xlat1.x = float(0.0);
					    u_xlat1.y = float(0.0);
					    u_xlat0.xyz = u_xlat0.xyz + (-u_xlat1.yyz);
					    u_xlat0.xyz = vec3(u_xlat21) * u_xlat0.xyz + u_xlat1.xyz;
					    u_xlat1.x = float(1.0);
					    u_xlat1.y = float(-1.0);
					    u_xlat2 = _CameraDepthTexture_TexelSize.xyxy * vec4(1.0, -1.0, -1.0, 1.0) + vs_TEXCOORD1.xyxy;
					    u_xlat2 = max(u_xlat2, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat2 = min(u_xlat2, vec4(_RenderViewportScaleFactor));
					    u_xlat1.z = texture(_CameraDepthTexture, u_xlat2.xy).x;
					    u_xlat2.z = texture(_CameraDepthTexture, u_xlat2.zw).x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb21 = !!(u_xlat1.z>=u_xlat0.z);
					#else
					    u_xlatb21 = u_xlat1.z>=u_xlat0.z;
					#endif
					    u_xlat21 = u_xlatb21 ? 1.0 : float(0.0);
					    u_xlat1.xyz = (-u_xlat0.yyz) + u_xlat1.xyz;
					    u_xlat0.xyz = vec3(u_xlat21) * u_xlat1.xyz + u_xlat0.xyz;
					    u_xlat2.x = float(-1.0);
					    u_xlat2.y = float(1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb21 = !!(u_xlat2.z>=u_xlat0.z);
					#else
					    u_xlatb21 = u_xlat2.z>=u_xlat0.z;
					#endif
					    u_xlat21 = u_xlatb21 ? 1.0 : float(0.0);
					    u_xlat1.xyz = (-u_xlat0.xyz) + u_xlat2.xyz;
					    u_xlat0.xyz = vec3(u_xlat21) * u_xlat1.xyz + u_xlat0.xyz;
					    u_xlat1.xy = vs_TEXCOORD1.xy + _CameraDepthTexture_TexelSize.xy;
					    u_xlat1.xy = max(u_xlat1.xy, vec2(0.0, 0.0));
					    u_xlat1.xy = min(u_xlat1.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat21 = texture(_CameraDepthTexture, u_xlat1.xy).x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb14 = !!(u_xlat21>=u_xlat0.z);
					#else
					    u_xlatb14 = u_xlat21>=u_xlat0.z;
					#endif
					    u_xlat14.x = u_xlatb14 ? 1.0 : float(0.0);
					    u_xlat1.xy = (-u_xlat0.xy) + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat14.xx * u_xlat1.xy + u_xlat0.xy;
					    u_xlat0.xy = u_xlat0.xy * _CameraDepthTexture_TexelSize.xy + vs_TEXCOORD1.xy;
					    u_xlat16_0.xy = texture(_CameraMotionVectorsTexture, u_xlat0.xy).xy;
					    u_xlat16_14 = dot(u_xlat16_0.xy, u_xlat16_0.xy);
					    u_xlat0.xy = (-u_xlat16_0.xy) + vs_TEXCOORD1.xy;
					    u_xlat0.xy = max(u_xlat0.xy, vec2(0.0, 0.0));
					    u_xlat0.xy = min(u_xlat0.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat1 = texture(_HistoryTex, u_xlat0.xy);
					    u_xlat16_0.x = sqrt(u_xlat16_14);
					    u_xlat16_7 = u_xlat16_0.x * 100.0;
					    u_xlat0.x = u_xlat16_0.x * _FinalBlendParameters.z;
					    u_xlat16_7 = min(u_xlat16_7, 1.0);
					    u_xlat16_7 = u_xlat16_7 * -3.75 + 4.0;
					    u_xlat14.xy = vs_TEXCOORD1.xy + (-_Jitter.xy);
					    u_xlat14.xy = max(u_xlat14.xy, vec2(0.0, 0.0));
					    u_xlat14.xy = min(u_xlat14.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat2.xy = (-_MainTex_TexelSize.xy) * vec2(0.5, 0.5) + u_xlat14.xy;
					    u_xlat2.xy = max(u_xlat2.xy, vec2(0.0, 0.0));
					    u_xlat2.xy = min(u_xlat2.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat16_2 = texture(_MainTex, u_xlat2.xy);
					    u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.5, 0.5) + u_xlat14.xy;
					    u_xlat16_4 = texture(_MainTex, u_xlat14.xy);
					    u_xlat14.xy = max(u_xlat3.xy, vec2(0.0, 0.0));
					    u_xlat14.xy = min(u_xlat14.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat16_3 = texture(_MainTex, u_xlat14.xy);
					    u_xlat16_5 = u_xlat16_2 + u_xlat16_3;
					    u_xlat16_6 = u_xlat16_4 + u_xlat16_4;
					    u_xlat16_5 = u_xlat16_5 * vec4(4.0, 4.0, 4.0, 4.0) + (-u_xlat16_6);
					    u_xlat16_6 = (-u_xlat16_5) * vec4(0.166666999, 0.166666999, 0.166666999, 0.166666999) + u_xlat16_4;
					    u_xlat6 = u_xlat16_6 * vec4(_Sharpness);
					    u_xlat4 = u_xlat6 * vec4(2.71828198, 2.71828198, 2.71828198, 2.71828198) + u_xlat16_4;
					    u_xlat4 = max(u_xlat4, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat4 = min(u_xlat4, vec4(65472.0, 65472.0, 65472.0, 65472.0));
					    u_xlat5.xyz = u_xlat4.xyz + u_xlat16_5.xyz;
					    u_xlat5.xyz = u_xlat5.xyz * vec3(0.142857, 0.142857, 0.142857);
					    u_xlat14.x = dot(u_xlat5.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat21 = dot(u_xlat4.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat14.x = (-u_xlat21) + u_xlat14.x;
					    u_xlat16_5.xyz = min(u_xlat16_2.xyz, u_xlat16_3.xyz);
					    u_xlat16_2.xyz = max(u_xlat16_2.xyz, u_xlat16_3.xyz);
					    u_xlat2.xyz = vec3(u_xlat16_7) * abs(u_xlat14.xxx) + u_xlat16_2.xyz;
					    u_xlat7.xyz = (-vec3(u_xlat16_7)) * abs(u_xlat14.xxx) + u_xlat16_5.xyz;
					    u_xlat3.xyz = (-u_xlat7.xyz) + u_xlat2.xyz;
					    u_xlat7.xyz = u_xlat7.xyz + u_xlat2.xyz;
					    u_xlat2.xyz = u_xlat3.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat3.xyz = (-u_xlat7.xyz) * vec3(0.5, 0.5, 0.5) + u_xlat1.xyz;
					    u_xlat7.xyz = u_xlat7.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat5.xyz = u_xlat3.xyz + vec3(9.99999975e-05, 9.99999975e-05, 9.99999975e-05);
					    u_xlat2.xyz = u_xlat2.xyz / u_xlat5.xyz;
					    u_xlat2.x = min(abs(u_xlat2.y), abs(u_xlat2.x));
					    u_xlat2.x = min(abs(u_xlat2.z), u_xlat2.x);
					    u_xlat2.x = min(u_xlat2.x, 1.0);
					    u_xlat1.xyz = u_xlat3.xyz * u_xlat2.xxx + u_xlat7.xyz;
					    u_xlat1 = (-u_xlat4) + u_xlat1;
					    u_xlat7.x = (-_FinalBlendParameters.x) + _FinalBlendParameters.y;
					    u_xlat0.x = u_xlat0.x * u_xlat7.x + _FinalBlendParameters.x;
					    u_xlat0.x = max(u_xlat0.x, _FinalBlendParameters.y);
					    u_xlat0.x = min(u_xlat0.x, _FinalBlendParameters.x);
					    u_xlat0 = u_xlat0.xxxx * u_xlat1 + u_xlat4;
					    u_xlat0 = max(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat0 = min(u_xlat0, vec4(65472.0, 65472.0, 65472.0, 65472.0));
					    SV_Target0 = u_xlat0;
					    SV_Target1 = u_xlat0;
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
					uniform 	vec4 _CameraDepthTexture_TexelSize;
					uniform 	vec2 _Jitter;
					uniform 	vec4 _FinalBlendParameters;
					uniform 	float _Sharpness;
					uniform highp sampler2D _CameraDepthTexture;
					uniform mediump sampler2D _CameraMotionVectorsTexture;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _HistoryTex;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					layout(location = 1) out highp vec4 SV_Target1;
					vec4 u_xlat0;
					mediump vec2 u_xlat16_0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec3 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					vec3 u_xlat5;
					mediump vec4 u_xlat16_5;
					vec4 u_xlat6;
					mediump vec4 u_xlat16_6;
					vec3 u_xlat7;
					mediump float u_xlat16_7;
					vec2 u_xlat14;
					mediump float u_xlat16_14;
					bool u_xlatb14;
					float u_xlat21;
					bool u_xlatb21;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD1.xy + (-_CameraDepthTexture_TexelSize.xy);
					    u_xlat0.xy = max(u_xlat0.xy, vec2(0.0, 0.0));
					    u_xlat0.xy = min(u_xlat0.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat0.z = texture(_CameraDepthTexture, u_xlat0.xy).x;
					    u_xlat1.z = texture(_CameraDepthTexture, vs_TEXCOORD1.xy).x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb21 = !!(u_xlat0.z>=u_xlat1.z);
					#else
					    u_xlatb21 = u_xlat0.z>=u_xlat1.z;
					#endif
					    u_xlat21 = u_xlatb21 ? 1.0 : float(0.0);
					    u_xlat0.x = float(-1.0);
					    u_xlat0.y = float(-1.0);
					    u_xlat1.x = float(0.0);
					    u_xlat1.y = float(0.0);
					    u_xlat0.xyz = u_xlat0.xyz + (-u_xlat1.yyz);
					    u_xlat0.xyz = vec3(u_xlat21) * u_xlat0.xyz + u_xlat1.xyz;
					    u_xlat1.x = float(1.0);
					    u_xlat1.y = float(-1.0);
					    u_xlat2 = _CameraDepthTexture_TexelSize.xyxy * vec4(1.0, -1.0, -1.0, 1.0) + vs_TEXCOORD1.xyxy;
					    u_xlat2 = max(u_xlat2, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat2 = min(u_xlat2, vec4(_RenderViewportScaleFactor));
					    u_xlat1.z = texture(_CameraDepthTexture, u_xlat2.xy).x;
					    u_xlat2.z = texture(_CameraDepthTexture, u_xlat2.zw).x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb21 = !!(u_xlat1.z>=u_xlat0.z);
					#else
					    u_xlatb21 = u_xlat1.z>=u_xlat0.z;
					#endif
					    u_xlat21 = u_xlatb21 ? 1.0 : float(0.0);
					    u_xlat1.xyz = (-u_xlat0.yyz) + u_xlat1.xyz;
					    u_xlat0.xyz = vec3(u_xlat21) * u_xlat1.xyz + u_xlat0.xyz;
					    u_xlat2.x = float(-1.0);
					    u_xlat2.y = float(1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb21 = !!(u_xlat2.z>=u_xlat0.z);
					#else
					    u_xlatb21 = u_xlat2.z>=u_xlat0.z;
					#endif
					    u_xlat21 = u_xlatb21 ? 1.0 : float(0.0);
					    u_xlat1.xyz = (-u_xlat0.xyz) + u_xlat2.xyz;
					    u_xlat0.xyz = vec3(u_xlat21) * u_xlat1.xyz + u_xlat0.xyz;
					    u_xlat1.xy = vs_TEXCOORD1.xy + _CameraDepthTexture_TexelSize.xy;
					    u_xlat1.xy = max(u_xlat1.xy, vec2(0.0, 0.0));
					    u_xlat1.xy = min(u_xlat1.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat21 = texture(_CameraDepthTexture, u_xlat1.xy).x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb14 = !!(u_xlat21>=u_xlat0.z);
					#else
					    u_xlatb14 = u_xlat21>=u_xlat0.z;
					#endif
					    u_xlat14.x = u_xlatb14 ? 1.0 : float(0.0);
					    u_xlat1.xy = (-u_xlat0.xy) + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat14.xx * u_xlat1.xy + u_xlat0.xy;
					    u_xlat0.xy = u_xlat0.xy * _CameraDepthTexture_TexelSize.xy + vs_TEXCOORD1.xy;
					    u_xlat16_0.xy = texture(_CameraMotionVectorsTexture, u_xlat0.xy).xy;
					    u_xlat16_14 = dot(u_xlat16_0.xy, u_xlat16_0.xy);
					    u_xlat0.xy = (-u_xlat16_0.xy) + vs_TEXCOORD1.xy;
					    u_xlat0.xy = max(u_xlat0.xy, vec2(0.0, 0.0));
					    u_xlat0.xy = min(u_xlat0.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat1 = texture(_HistoryTex, u_xlat0.xy);
					    u_xlat16_0.x = sqrt(u_xlat16_14);
					    u_xlat16_7 = u_xlat16_0.x * 100.0;
					    u_xlat0.x = u_xlat16_0.x * _FinalBlendParameters.z;
					    u_xlat16_7 = min(u_xlat16_7, 1.0);
					    u_xlat16_7 = u_xlat16_7 * -3.75 + 4.0;
					    u_xlat14.xy = vs_TEXCOORD1.xy + (-_Jitter.xy);
					    u_xlat14.xy = max(u_xlat14.xy, vec2(0.0, 0.0));
					    u_xlat14.xy = min(u_xlat14.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat2.xy = (-_MainTex_TexelSize.xy) * vec2(0.5, 0.5) + u_xlat14.xy;
					    u_xlat2.xy = max(u_xlat2.xy, vec2(0.0, 0.0));
					    u_xlat2.xy = min(u_xlat2.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat16_2 = texture(_MainTex, u_xlat2.xy);
					    u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.5, 0.5) + u_xlat14.xy;
					    u_xlat16_4 = texture(_MainTex, u_xlat14.xy);
					    u_xlat14.xy = max(u_xlat3.xy, vec2(0.0, 0.0));
					    u_xlat14.xy = min(u_xlat14.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat16_3 = texture(_MainTex, u_xlat14.xy);
					    u_xlat16_5 = u_xlat16_2 + u_xlat16_3;
					    u_xlat16_6 = u_xlat16_4 + u_xlat16_4;
					    u_xlat16_5 = u_xlat16_5 * vec4(4.0, 4.0, 4.0, 4.0) + (-u_xlat16_6);
					    u_xlat16_6 = (-u_xlat16_5) * vec4(0.166666999, 0.166666999, 0.166666999, 0.166666999) + u_xlat16_4;
					    u_xlat6 = u_xlat16_6 * vec4(_Sharpness);
					    u_xlat4 = u_xlat6 * vec4(2.71828198, 2.71828198, 2.71828198, 2.71828198) + u_xlat16_4;
					    u_xlat4 = max(u_xlat4, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat4 = min(u_xlat4, vec4(65472.0, 65472.0, 65472.0, 65472.0));
					    u_xlat5.xyz = u_xlat4.xyz + u_xlat16_5.xyz;
					    u_xlat5.xyz = u_xlat5.xyz * vec3(0.142857, 0.142857, 0.142857);
					    u_xlat14.x = dot(u_xlat5.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat21 = dot(u_xlat4.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat14.x = (-u_xlat21) + u_xlat14.x;
					    u_xlat16_5.xyz = min(u_xlat16_2.xyz, u_xlat16_3.xyz);
					    u_xlat16_2.xyz = max(u_xlat16_2.xyz, u_xlat16_3.xyz);
					    u_xlat2.xyz = vec3(u_xlat16_7) * abs(u_xlat14.xxx) + u_xlat16_2.xyz;
					    u_xlat7.xyz = (-vec3(u_xlat16_7)) * abs(u_xlat14.xxx) + u_xlat16_5.xyz;
					    u_xlat3.xyz = (-u_xlat7.xyz) + u_xlat2.xyz;
					    u_xlat7.xyz = u_xlat7.xyz + u_xlat2.xyz;
					    u_xlat2.xyz = u_xlat3.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat3.xyz = (-u_xlat7.xyz) * vec3(0.5, 0.5, 0.5) + u_xlat1.xyz;
					    u_xlat7.xyz = u_xlat7.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat5.xyz = u_xlat3.xyz + vec3(9.99999975e-05, 9.99999975e-05, 9.99999975e-05);
					    u_xlat2.xyz = u_xlat2.xyz / u_xlat5.xyz;
					    u_xlat2.x = min(abs(u_xlat2.y), abs(u_xlat2.x));
					    u_xlat2.x = min(abs(u_xlat2.z), u_xlat2.x);
					    u_xlat2.x = min(u_xlat2.x, 1.0);
					    u_xlat1.xyz = u_xlat3.xyz * u_xlat2.xxx + u_xlat7.xyz;
					    u_xlat1 = (-u_xlat4) + u_xlat1;
					    u_xlat7.x = (-_FinalBlendParameters.x) + _FinalBlendParameters.y;
					    u_xlat0.x = u_xlat0.x * u_xlat7.x + _FinalBlendParameters.x;
					    u_xlat0.x = max(u_xlat0.x, _FinalBlendParameters.y);
					    u_xlat0.x = min(u_xlat0.x, _FinalBlendParameters.x);
					    u_xlat0 = u_xlat0.xxxx * u_xlat1 + u_xlat4;
					    u_xlat0 = max(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat0 = min(u_xlat0, vec4(65472.0, 65472.0, 65472.0, 65472.0));
					    SV_Target0 = u_xlat0;
					    SV_Target1 = u_xlat0;
					    return;
					}
					
					#endif"
				}
			}
			Program "fp" {
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
			GpuProgramID 75562
			Program "vp" {
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
					uniform 	vec2 _Jitter;
					uniform 	vec4 _FinalBlendParameters;
					uniform 	float _Sharpness;
					uniform mediump sampler2D _CameraMotionVectorsTexture;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _HistoryTex;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					layout(location = 1) out highp vec4 SV_Target1;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec2 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec3 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					vec3 u_xlat5;
					vec3 u_xlat7;
					mediump float u_xlat16_7;
					vec2 u_xlat12;
					mediump float u_xlat16_13;
					float u_xlat18;
					float u_xlat19;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD1.xy + (-_Jitter.xy);
					    u_xlat0.xy = max(u_xlat0.xy, vec2(0.0, 0.0));
					    u_xlat0.xy = min(u_xlat0.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat12.xy = (-_MainTex_TexelSize.xy) * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat12.xy = max(u_xlat12.xy, vec2(0.0, 0.0));
					    u_xlat12.xy = min(u_xlat12.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat16_1 = texture(_MainTex, u_xlat12.xy);
					    u_xlat12.xy = _MainTex_TexelSize.xy * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat16_2 = texture(_MainTex, u_xlat0.xy);
					    u_xlat0.xy = max(u_xlat12.xy, vec2(0.0, 0.0));
					    u_xlat0.xy = min(u_xlat0.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat16_0 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_3 = u_xlat16_0 + u_xlat16_1;
					    u_xlat16_4 = u_xlat16_2 + u_xlat16_2;
					    u_xlat16_3 = u_xlat16_3 * vec4(4.0, 4.0, 4.0, 4.0) + (-u_xlat16_4);
					    u_xlat16_4 = (-u_xlat16_3) * vec4(0.166666999, 0.166666999, 0.166666999, 0.166666999) + u_xlat16_2;
					    u_xlat4 = u_xlat16_4 * vec4(_Sharpness);
					    u_xlat2 = u_xlat4 * vec4(2.71828198, 2.71828198, 2.71828198, 2.71828198) + u_xlat16_2;
					    u_xlat2 = max(u_xlat2, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat2 = min(u_xlat2, vec4(65472.0, 65472.0, 65472.0, 65472.0));
					    u_xlat3.xyz = u_xlat2.xyz + u_xlat16_3.xyz;
					    u_xlat3.xyz = u_xlat3.xyz * vec3(0.142857, 0.142857, 0.142857);
					    u_xlat18 = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat19 = dot(u_xlat2.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat18 = u_xlat18 + (-u_xlat19);
					    u_xlat16_3.xyz = min(u_xlat16_1.xyz, u_xlat16_0.xyz);
					    u_xlat16_0.xyz = max(u_xlat16_0.xyz, u_xlat16_1.xyz);
					    u_xlat16_1.xy = texture(_CameraMotionVectorsTexture, vs_TEXCOORD1.xy).xy;
					    u_xlat16_13 = dot(u_xlat16_1.xy, u_xlat16_1.xy);
					    u_xlat1.xy = (-u_xlat16_1.xy) + vs_TEXCOORD1.xy;
					    u_xlat1.xy = max(u_xlat1.xy, vec2(0.0, 0.0));
					    u_xlat1.xy = min(u_xlat1.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat4 = texture(_HistoryTex, u_xlat1.xy);
					    u_xlat16_1.x = sqrt(u_xlat16_13);
					    u_xlat16_7 = u_xlat16_1.x * 100.0;
					    u_xlat1.x = u_xlat16_1.x * _FinalBlendParameters.z;
					    u_xlat16_7 = min(u_xlat16_7, 1.0);
					    u_xlat16_7 = u_xlat16_7 * -3.75 + 4.0;
					    u_xlat3.xyz = (-vec3(u_xlat16_7)) * abs(vec3(u_xlat18)) + u_xlat16_3.xyz;
					    u_xlat0.xyz = vec3(u_xlat16_7) * abs(vec3(u_xlat18)) + u_xlat16_0.xyz;
					    u_xlat7.xyz = (-u_xlat3.xyz) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat3.xyz + u_xlat0.xyz;
					    u_xlat7.xyz = u_xlat7.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat3.xyz = (-u_xlat0.xyz) * vec3(0.5, 0.5, 0.5) + u_xlat4.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat5.xyz = u_xlat3.xyz + vec3(9.99999975e-05, 9.99999975e-05, 9.99999975e-05);
					    u_xlat7.xyz = u_xlat7.xyz / u_xlat5.xyz;
					    u_xlat18 = min(abs(u_xlat7.y), abs(u_xlat7.x));
					    u_xlat18 = min(abs(u_xlat7.z), u_xlat18);
					    u_xlat18 = min(u_xlat18, 1.0);
					    u_xlat4.xyz = u_xlat3.xyz * vec3(u_xlat18) + u_xlat0.xyz;
					    u_xlat0 = (-u_xlat2) + u_xlat4;
					    u_xlat7.x = (-_FinalBlendParameters.x) + _FinalBlendParameters.y;
					    u_xlat1.x = u_xlat1.x * u_xlat7.x + _FinalBlendParameters.x;
					    u_xlat1.x = max(u_xlat1.x, _FinalBlendParameters.y);
					    u_xlat1.x = min(u_xlat1.x, _FinalBlendParameters.x);
					    u_xlat0 = u_xlat1.xxxx * u_xlat0 + u_xlat2;
					    u_xlat0 = max(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat0 = min(u_xlat0, vec4(65472.0, 65472.0, 65472.0, 65472.0));
					    SV_Target0 = u_xlat0;
					    SV_Target1 = u_xlat0;
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
					uniform 	vec2 _Jitter;
					uniform 	vec4 _FinalBlendParameters;
					uniform 	float _Sharpness;
					uniform mediump sampler2D _CameraMotionVectorsTexture;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _HistoryTex;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					layout(location = 1) out highp vec4 SV_Target1;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec2 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec3 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					vec3 u_xlat5;
					vec3 u_xlat7;
					mediump float u_xlat16_7;
					vec2 u_xlat12;
					mediump float u_xlat16_13;
					float u_xlat18;
					float u_xlat19;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD1.xy + (-_Jitter.xy);
					    u_xlat0.xy = max(u_xlat0.xy, vec2(0.0, 0.0));
					    u_xlat0.xy = min(u_xlat0.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat12.xy = (-_MainTex_TexelSize.xy) * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat12.xy = max(u_xlat12.xy, vec2(0.0, 0.0));
					    u_xlat12.xy = min(u_xlat12.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat16_1 = texture(_MainTex, u_xlat12.xy);
					    u_xlat12.xy = _MainTex_TexelSize.xy * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat16_2 = texture(_MainTex, u_xlat0.xy);
					    u_xlat0.xy = max(u_xlat12.xy, vec2(0.0, 0.0));
					    u_xlat0.xy = min(u_xlat0.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat16_0 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_3 = u_xlat16_0 + u_xlat16_1;
					    u_xlat16_4 = u_xlat16_2 + u_xlat16_2;
					    u_xlat16_3 = u_xlat16_3 * vec4(4.0, 4.0, 4.0, 4.0) + (-u_xlat16_4);
					    u_xlat16_4 = (-u_xlat16_3) * vec4(0.166666999, 0.166666999, 0.166666999, 0.166666999) + u_xlat16_2;
					    u_xlat4 = u_xlat16_4 * vec4(_Sharpness);
					    u_xlat2 = u_xlat4 * vec4(2.71828198, 2.71828198, 2.71828198, 2.71828198) + u_xlat16_2;
					    u_xlat2 = max(u_xlat2, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat2 = min(u_xlat2, vec4(65472.0, 65472.0, 65472.0, 65472.0));
					    u_xlat3.xyz = u_xlat2.xyz + u_xlat16_3.xyz;
					    u_xlat3.xyz = u_xlat3.xyz * vec3(0.142857, 0.142857, 0.142857);
					    u_xlat18 = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat19 = dot(u_xlat2.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat18 = u_xlat18 + (-u_xlat19);
					    u_xlat16_3.xyz = min(u_xlat16_1.xyz, u_xlat16_0.xyz);
					    u_xlat16_0.xyz = max(u_xlat16_0.xyz, u_xlat16_1.xyz);
					    u_xlat16_1.xy = texture(_CameraMotionVectorsTexture, vs_TEXCOORD1.xy).xy;
					    u_xlat16_13 = dot(u_xlat16_1.xy, u_xlat16_1.xy);
					    u_xlat1.xy = (-u_xlat16_1.xy) + vs_TEXCOORD1.xy;
					    u_xlat1.xy = max(u_xlat1.xy, vec2(0.0, 0.0));
					    u_xlat1.xy = min(u_xlat1.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat4 = texture(_HistoryTex, u_xlat1.xy);
					    u_xlat16_1.x = sqrt(u_xlat16_13);
					    u_xlat16_7 = u_xlat16_1.x * 100.0;
					    u_xlat1.x = u_xlat16_1.x * _FinalBlendParameters.z;
					    u_xlat16_7 = min(u_xlat16_7, 1.0);
					    u_xlat16_7 = u_xlat16_7 * -3.75 + 4.0;
					    u_xlat3.xyz = (-vec3(u_xlat16_7)) * abs(vec3(u_xlat18)) + u_xlat16_3.xyz;
					    u_xlat0.xyz = vec3(u_xlat16_7) * abs(vec3(u_xlat18)) + u_xlat16_0.xyz;
					    u_xlat7.xyz = (-u_xlat3.xyz) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat3.xyz + u_xlat0.xyz;
					    u_xlat7.xyz = u_xlat7.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat3.xyz = (-u_xlat0.xyz) * vec3(0.5, 0.5, 0.5) + u_xlat4.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat5.xyz = u_xlat3.xyz + vec3(9.99999975e-05, 9.99999975e-05, 9.99999975e-05);
					    u_xlat7.xyz = u_xlat7.xyz / u_xlat5.xyz;
					    u_xlat18 = min(abs(u_xlat7.y), abs(u_xlat7.x));
					    u_xlat18 = min(abs(u_xlat7.z), u_xlat18);
					    u_xlat18 = min(u_xlat18, 1.0);
					    u_xlat4.xyz = u_xlat3.xyz * vec3(u_xlat18) + u_xlat0.xyz;
					    u_xlat0 = (-u_xlat2) + u_xlat4;
					    u_xlat7.x = (-_FinalBlendParameters.x) + _FinalBlendParameters.y;
					    u_xlat1.x = u_xlat1.x * u_xlat7.x + _FinalBlendParameters.x;
					    u_xlat1.x = max(u_xlat1.x, _FinalBlendParameters.y);
					    u_xlat1.x = min(u_xlat1.x, _FinalBlendParameters.x);
					    u_xlat0 = u_xlat1.xxxx * u_xlat0 + u_xlat2;
					    u_xlat0 = max(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat0 = min(u_xlat0, vec4(65472.0, 65472.0, 65472.0, 65472.0));
					    SV_Target0 = u_xlat0;
					    SV_Target1 = u_xlat0;
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
					uniform 	vec2 _Jitter;
					uniform 	vec4 _FinalBlendParameters;
					uniform 	float _Sharpness;
					uniform mediump sampler2D _CameraMotionVectorsTexture;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _HistoryTex;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					layout(location = 1) out highp vec4 SV_Target1;
					vec4 u_xlat0;
					mediump vec4 u_xlat16_0;
					vec2 u_xlat1;
					mediump vec4 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					vec3 u_xlat3;
					mediump vec4 u_xlat16_3;
					vec4 u_xlat4;
					mediump vec4 u_xlat16_4;
					vec3 u_xlat5;
					vec3 u_xlat7;
					mediump float u_xlat16_7;
					vec2 u_xlat12;
					mediump float u_xlat16_13;
					float u_xlat18;
					float u_xlat19;
					void main()
					{
					    u_xlat0.xy = vs_TEXCOORD1.xy + (-_Jitter.xy);
					    u_xlat0.xy = max(u_xlat0.xy, vec2(0.0, 0.0));
					    u_xlat0.xy = min(u_xlat0.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat12.xy = (-_MainTex_TexelSize.xy) * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat12.xy = max(u_xlat12.xy, vec2(0.0, 0.0));
					    u_xlat12.xy = min(u_xlat12.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat16_1 = texture(_MainTex, u_xlat12.xy);
					    u_xlat12.xy = _MainTex_TexelSize.xy * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat16_2 = texture(_MainTex, u_xlat0.xy);
					    u_xlat0.xy = max(u_xlat12.xy, vec2(0.0, 0.0));
					    u_xlat0.xy = min(u_xlat0.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat16_0 = texture(_MainTex, u_xlat0.xy);
					    u_xlat16_3 = u_xlat16_0 + u_xlat16_1;
					    u_xlat16_4 = u_xlat16_2 + u_xlat16_2;
					    u_xlat16_3 = u_xlat16_3 * vec4(4.0, 4.0, 4.0, 4.0) + (-u_xlat16_4);
					    u_xlat16_4 = (-u_xlat16_3) * vec4(0.166666999, 0.166666999, 0.166666999, 0.166666999) + u_xlat16_2;
					    u_xlat4 = u_xlat16_4 * vec4(_Sharpness);
					    u_xlat2 = u_xlat4 * vec4(2.71828198, 2.71828198, 2.71828198, 2.71828198) + u_xlat16_2;
					    u_xlat2 = max(u_xlat2, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat2 = min(u_xlat2, vec4(65472.0, 65472.0, 65472.0, 65472.0));
					    u_xlat3.xyz = u_xlat2.xyz + u_xlat16_3.xyz;
					    u_xlat3.xyz = u_xlat3.xyz * vec3(0.142857, 0.142857, 0.142857);
					    u_xlat18 = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat19 = dot(u_xlat2.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat18 = u_xlat18 + (-u_xlat19);
					    u_xlat16_3.xyz = min(u_xlat16_1.xyz, u_xlat16_0.xyz);
					    u_xlat16_0.xyz = max(u_xlat16_0.xyz, u_xlat16_1.xyz);
					    u_xlat16_1.xy = texture(_CameraMotionVectorsTexture, vs_TEXCOORD1.xy).xy;
					    u_xlat16_13 = dot(u_xlat16_1.xy, u_xlat16_1.xy);
					    u_xlat1.xy = (-u_xlat16_1.xy) + vs_TEXCOORD1.xy;
					    u_xlat1.xy = max(u_xlat1.xy, vec2(0.0, 0.0));
					    u_xlat1.xy = min(u_xlat1.xy, vec2(_RenderViewportScaleFactor));
					    u_xlat4 = texture(_HistoryTex, u_xlat1.xy);
					    u_xlat16_1.x = sqrt(u_xlat16_13);
					    u_xlat16_7 = u_xlat16_1.x * 100.0;
					    u_xlat1.x = u_xlat16_1.x * _FinalBlendParameters.z;
					    u_xlat16_7 = min(u_xlat16_7, 1.0);
					    u_xlat16_7 = u_xlat16_7 * -3.75 + 4.0;
					    u_xlat3.xyz = (-vec3(u_xlat16_7)) * abs(vec3(u_xlat18)) + u_xlat16_3.xyz;
					    u_xlat0.xyz = vec3(u_xlat16_7) * abs(vec3(u_xlat18)) + u_xlat16_0.xyz;
					    u_xlat7.xyz = (-u_xlat3.xyz) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat3.xyz + u_xlat0.xyz;
					    u_xlat7.xyz = u_xlat7.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat3.xyz = (-u_xlat0.xyz) * vec3(0.5, 0.5, 0.5) + u_xlat4.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat5.xyz = u_xlat3.xyz + vec3(9.99999975e-05, 9.99999975e-05, 9.99999975e-05);
					    u_xlat7.xyz = u_xlat7.xyz / u_xlat5.xyz;
					    u_xlat18 = min(abs(u_xlat7.y), abs(u_xlat7.x));
					    u_xlat18 = min(abs(u_xlat7.z), u_xlat18);
					    u_xlat18 = min(u_xlat18, 1.0);
					    u_xlat4.xyz = u_xlat3.xyz * vec3(u_xlat18) + u_xlat0.xyz;
					    u_xlat0 = (-u_xlat2) + u_xlat4;
					    u_xlat7.x = (-_FinalBlendParameters.x) + _FinalBlendParameters.y;
					    u_xlat1.x = u_xlat1.x * u_xlat7.x + _FinalBlendParameters.x;
					    u_xlat1.x = max(u_xlat1.x, _FinalBlendParameters.y);
					    u_xlat1.x = min(u_xlat1.x, _FinalBlendParameters.x);
					    u_xlat0 = u_xlat1.xxxx * u_xlat0 + u_xlat2;
					    u_xlat0 = max(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlat0 = min(u_xlat0, vec4(65472.0, 65472.0, 65472.0, 65472.0));
					    SV_Target0 = u_xlat0;
					    SV_Target1 = u_xlat0;
					    return;
					}
					
					#endif"
				}
			}
			Program "fp" {
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