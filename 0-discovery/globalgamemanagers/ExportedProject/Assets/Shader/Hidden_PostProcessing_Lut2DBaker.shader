Shader "Hidden/PostProcessing/Lut2DBaker" {
	Properties {
	}
	SubShader {
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 49193
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	float _Brightness;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					vec4 u_xlat1;
					lowp float u_xlat10_1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD1.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(vec3(_Brightness, _Brightness, _Brightness)) + vec3(-0.217637643, -0.217637643, -0.217637643);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.217637643, 0.217637643, 0.217637643);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb4 = 1.0<u_xlat5.x;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					    u_xlatb12 = u_xlat5.x<0.0;
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat10_1 = texture2D(_Curves, u_xlat0.xw).w;
					    u_xlat1.x = u_xlat10_1;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat5.x = texture2D(_Curves, u_xlat0.yw).w;
					    u_xlat5.y = texture2D(_Curves, u_xlat0.zw).w;
					    u_xlat1.yz = u_xlat5.xy;
					    u_xlat1.yz = clamp(u_xlat1.yz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat10_0 = texture2D(_Curves, u_xlat0.xw).x;
					    SV_Target0.x = u_xlat10_0;
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					    u_xlat0.x = texture2D(_Curves, u_xlat0.yw).y;
					    u_xlat0.y = texture2D(_Curves, u_xlat0.zw).z;
					    SV_Target0.yz = u_xlat0.xy;
					    SV_Target0.yz = clamp(SV_Target0.yz, 0.0, 1.0);
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	float _Brightness;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					vec4 u_xlat1;
					lowp float u_xlat10_1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD1.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(vec3(_Brightness, _Brightness, _Brightness)) + vec3(-0.217637643, -0.217637643, -0.217637643);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.217637643, 0.217637643, 0.217637643);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb4 = 1.0<u_xlat5.x;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					    u_xlatb12 = u_xlat5.x<0.0;
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat10_1 = texture2D(_Curves, u_xlat0.xw).w;
					    u_xlat1.x = u_xlat10_1;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat5.x = texture2D(_Curves, u_xlat0.yw).w;
					    u_xlat5.y = texture2D(_Curves, u_xlat0.zw).w;
					    u_xlat1.yz = u_xlat5.xy;
					    u_xlat1.yz = clamp(u_xlat1.yz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat10_0 = texture2D(_Curves, u_xlat0.xw).x;
					    SV_Target0.x = u_xlat10_0;
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					    u_xlat0.x = texture2D(_Curves, u_xlat0.yw).y;
					    u_xlat0.y = texture2D(_Curves, u_xlat0.zw).z;
					    SV_Target0.yz = u_xlat0.xy;
					    SV_Target0.yz = clamp(SV_Target0.yz, 0.0, 1.0);
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	float _Brightness;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					vec4 u_xlat1;
					lowp float u_xlat10_1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD1.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(vec3(_Brightness, _Brightness, _Brightness)) + vec3(-0.217637643, -0.217637643, -0.217637643);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.217637643, 0.217637643, 0.217637643);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb4 = 1.0<u_xlat5.x;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					    u_xlatb12 = u_xlat5.x<0.0;
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat10_1 = texture2D(_Curves, u_xlat0.xw).w;
					    u_xlat1.x = u_xlat10_1;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat5.x = texture2D(_Curves, u_xlat0.yw).w;
					    u_xlat5.y = texture2D(_Curves, u_xlat0.zw).w;
					    u_xlat1.yz = u_xlat5.xy;
					    u_xlat1.yz = clamp(u_xlat1.yz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat10_0 = texture2D(_Curves, u_xlat0.xw).x;
					    SV_Target0.x = u_xlat10_0;
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					    u_xlat0.x = texture2D(_Curves, u_xlat0.yw).y;
					    u_xlat0.y = texture2D(_Curves, u_xlat0.zw).z;
					    SV_Target0.yz = u_xlat0.xy;
					    SV_Target0.yz = clamp(SV_Target0.yz, 0.0, 1.0);
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	float _Brightness;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					vec4 u_xlat1;
					mediump float u_xlat16_1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD1.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(vec3(_Brightness, _Brightness, _Brightness)) + vec3(-0.217637643, -0.217637643, -0.217637643);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.217637643, 0.217637643, 0.217637643);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = textureLod(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(1.0<u_xlat5.x);
					#else
					    u_xlatb4 = 1.0<u_xlat5.x;
					#endif
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat5.x<0.0);
					#else
					    u_xlatb12 = u_xlat5.x<0.0;
					#endif
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat16_1 = texture(_Curves, u_xlat0.xw).w;
					    u_xlat1.x = u_xlat16_1;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.x = min(max(u_xlat1.x, 0.0), 1.0);
					#else
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					#endif
					    u_xlat5.x = texture(_Curves, u_xlat0.yw).w;
					    u_xlat5.y = texture(_Curves, u_xlat0.zw).w;
					    u_xlat1.yz = u_xlat5.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.yz = min(max(u_xlat1.yz, 0.0), 1.0);
					#else
					    u_xlat1.yz = clamp(u_xlat1.yz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat16_0 = texture(_Curves, u_xlat0.xw).x;
					    SV_Target0.x = u_xlat16_0;
					#ifdef UNITY_ADRENO_ES3
					    SV_Target0.x = min(max(SV_Target0.x, 0.0), 1.0);
					#else
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					#endif
					    u_xlat0.x = texture(_Curves, u_xlat0.yw).y;
					    u_xlat0.y = texture(_Curves, u_xlat0.zw).z;
					    SV_Target0.yz = u_xlat0.xy;
					#ifdef UNITY_ADRENO_ES3
					    SV_Target0.yz = min(max(SV_Target0.yz, 0.0), 1.0);
					#else
					    SV_Target0.yz = clamp(SV_Target0.yz, 0.0, 1.0);
					#endif
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	float _Brightness;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					vec4 u_xlat1;
					mediump float u_xlat16_1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD1.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(vec3(_Brightness, _Brightness, _Brightness)) + vec3(-0.217637643, -0.217637643, -0.217637643);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.217637643, 0.217637643, 0.217637643);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = textureLod(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(1.0<u_xlat5.x);
					#else
					    u_xlatb4 = 1.0<u_xlat5.x;
					#endif
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat5.x<0.0);
					#else
					    u_xlatb12 = u_xlat5.x<0.0;
					#endif
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat16_1 = texture(_Curves, u_xlat0.xw).w;
					    u_xlat1.x = u_xlat16_1;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.x = min(max(u_xlat1.x, 0.0), 1.0);
					#else
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					#endif
					    u_xlat5.x = texture(_Curves, u_xlat0.yw).w;
					    u_xlat5.y = texture(_Curves, u_xlat0.zw).w;
					    u_xlat1.yz = u_xlat5.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.yz = min(max(u_xlat1.yz, 0.0), 1.0);
					#else
					    u_xlat1.yz = clamp(u_xlat1.yz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat16_0 = texture(_Curves, u_xlat0.xw).x;
					    SV_Target0.x = u_xlat16_0;
					#ifdef UNITY_ADRENO_ES3
					    SV_Target0.x = min(max(SV_Target0.x, 0.0), 1.0);
					#else
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					#endif
					    u_xlat0.x = texture(_Curves, u_xlat0.yw).y;
					    u_xlat0.y = texture(_Curves, u_xlat0.zw).z;
					    SV_Target0.yz = u_xlat0.xy;
					#ifdef UNITY_ADRENO_ES3
					    SV_Target0.yz = min(max(SV_Target0.yz, 0.0), 1.0);
					#else
					    SV_Target0.yz = clamp(SV_Target0.yz, 0.0, 1.0);
					#endif
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	float _Brightness;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					vec4 u_xlat1;
					mediump float u_xlat16_1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD1.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(vec3(_Brightness, _Brightness, _Brightness)) + vec3(-0.217637643, -0.217637643, -0.217637643);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.217637643, 0.217637643, 0.217637643);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = textureLod(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(1.0<u_xlat5.x);
					#else
					    u_xlatb4 = 1.0<u_xlat5.x;
					#endif
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat5.x<0.0);
					#else
					    u_xlatb12 = u_xlat5.x<0.0;
					#endif
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat16_1 = texture(_Curves, u_xlat0.xw).w;
					    u_xlat1.x = u_xlat16_1;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.x = min(max(u_xlat1.x, 0.0), 1.0);
					#else
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					#endif
					    u_xlat5.x = texture(_Curves, u_xlat0.yw).w;
					    u_xlat5.y = texture(_Curves, u_xlat0.zw).w;
					    u_xlat1.yz = u_xlat5.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.yz = min(max(u_xlat1.yz, 0.0), 1.0);
					#else
					    u_xlat1.yz = clamp(u_xlat1.yz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat16_0 = texture(_Curves, u_xlat0.xw).x;
					    SV_Target0.x = u_xlat16_0;
					#ifdef UNITY_ADRENO_ES3
					    SV_Target0.x = min(max(SV_Target0.x, 0.0), 1.0);
					#else
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					#endif
					    u_xlat0.x = texture(_Curves, u_xlat0.yw).y;
					    u_xlat0.y = texture(_Curves, u_xlat0.zw).z;
					    SV_Target0.yz = u_xlat0.xy;
					#ifdef UNITY_ADRENO_ES3
					    SV_Target0.yz = min(max(SV_Target0.yz, 0.0), 1.0);
					#else
					    SV_Target0.yz = clamp(SV_Target0.yz, 0.0, 1.0);
					#endif
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
			GpuProgramID 76690
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec4 _UserLut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	float _Brightness;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec4 u_xlat1;
					lowp float u_xlat10_1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					lowp vec3 u_xlat10_3;
					mediump vec3 u_xlat16_4;
					lowp vec3 u_xlat10_4;
					vec3 u_xlat5;
					mediump float u_xlat16_5;
					lowp float u_xlat10_5;
					bool u_xlatb5;
					vec2 u_xlat6;
					bool u_xlatb6;
					float u_xlat7;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat15;
					void main()
					{
					    u_xlat0.x = _UserLut2D_Params.y;
					    u_xlat1.yz = vs_TEXCOORD1.xy + (-_Lut2D_Params.yz);
					    u_xlat2.x = u_xlat1.y * _Lut2D_Params.x;
					    u_xlat1.x = fract(u_xlat2.x);
					    u_xlat2.x = u_xlat1.x / _Lut2D_Params.x;
					    u_xlat1.w = u_xlat1.y + (-u_xlat2.x);
					    u_xlat2.xyz = u_xlat1.xzw * _Lut2D_Params.www;
					    u_xlat3.xyz = u_xlat2.zxy * _UserLut2D_Params.zzz;
					    u_xlat6.x = floor(u_xlat3.x);
					    u_xlat3.xw = _UserLut2D_Params.xy * vec2(0.5, 0.5);
					    u_xlat3.yz = u_xlat3.yz * _UserLut2D_Params.xy + u_xlat3.xw;
					    u_xlat3.x = u_xlat6.x * _UserLut2D_Params.y + u_xlat3.y;
					    u_xlat6.x = u_xlat2.z * _UserLut2D_Params.z + (-u_xlat6.x);
					    u_xlat0.y = float(0.0);
					    u_xlat10.y = float(0.25);
					    u_xlat0.xy = u_xlat0.xy + u_xlat3.xz;
					    u_xlat10_3.xyz = texture2D(_MainTex, u_xlat3.xz).xyz;
					    u_xlat10_4.xyz = texture2D(_MainTex, u_xlat0.xy).xyz;
					    u_xlat16_4.xyz = (-u_xlat10_3.xyz) + u_xlat10_4.xyz;
					    u_xlat3.xyz = u_xlat6.xxx * u_xlat16_4.xyz + u_xlat10_3.xyz;
					    u_xlat1.xyz = (-u_xlat1.xzw) * _Lut2D_Params.www + u_xlat3.xyz;
					    u_xlat1.xyz = _UserLut2D_Params.www * u_xlat1.xyz + u_xlat2.xyz;
					    u_xlat1.xyz = u_xlat1.xyz * vec3(vec3(_Brightness, _Brightness, _Brightness)) + vec3(-0.217637643, -0.217637643, -0.217637643);
					    u_xlat1.xyz = u_xlat1.xyz * _HueSatCon.zzz + vec3(0.217637643, 0.217637643, 0.217637643);
					    u_xlat2.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat1.xyz);
					    u_xlat2.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat1.xyz);
					    u_xlat2.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _ColorBalance.xyz;
					    u_xlat2.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat1.xyz);
					    u_xlat2.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat1.xyz);
					    u_xlat2.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _ColorFilter.xyz;
					    u_xlat2.x = dot(u_xlat1.xyz, _ChannelMixerRed.xyz);
					    u_xlat2.y = dot(u_xlat1.xyz, _ChannelMixerGreen.xyz);
					    u_xlat2.z = dot(u_xlat1.xyz, _ChannelMixerBlue.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat2.xyz = log2(abs(u_xlat1.xyz));
					    u_xlat1.xyz = u_xlat1.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat1.xyz = clamp(u_xlat1.xyz, 0.0, 1.0);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat2.xyz = u_xlat2.xyz * _InvGamma.xyz;
					    u_xlat2.xyz = exp2(u_xlat2.xyz);
					    u_xlat1.xyz = u_xlat1.xyz * u_xlat2.xyz;
					    u_xlat1.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb0 = u_xlat1.y>=u_xlat1.z;
					    u_xlat0.x = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat2.xy = u_xlat1.zy;
					    u_xlat3.xy = u_xlat1.yz + (-u_xlat2.xy);
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.666666687);
					    u_xlat3.z = float(1.0);
					    u_xlat3.w = float(-1.0);
					    u_xlat2 = u_xlat0.xxxx * u_xlat3.xywz + u_xlat2.xywz;
					    u_xlatb0 = u_xlat1.x>=u_xlat2.x;
					    u_xlat0.x = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat3.z = u_xlat2.w;
					    u_xlat2.w = u_xlat1.x;
					    u_xlat11.x = dot(u_xlat1.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat3.xyw = u_xlat2.wyx;
					    u_xlat3 = (-u_xlat2) + u_xlat3;
					    u_xlat2 = u_xlat0.xxxx * u_xlat3 + u_xlat2;
					    u_xlat0.x = min(u_xlat2.y, u_xlat2.w);
					    u_xlat0.x = (-u_xlat0.x) + u_xlat2.x;
					    u_xlat5.x = u_xlat0.x * 6.0 + 9.99999975e-05;
					    u_xlat7 = (-u_xlat2.y) + u_xlat2.w;
					    u_xlat5.x = u_xlat7 / u_xlat5.x;
					    u_xlat5.x = u_xlat5.x + u_xlat2.z;
					    u_xlat10.x = abs(u_xlat5.x);
					    u_xlat10_5 = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).y;
					    u_xlat3.x = u_xlat10.x + _HueSatCon.x;
					    u_xlat16_5 = u_xlat10_5;
					    u_xlat16_5 = clamp(u_xlat16_5, 0.0, 1.0);
					    u_xlat16_5 = u_xlat16_5 + u_xlat16_5;
					    u_xlat10.x = u_xlat2.x + 9.99999975e-05;
					    u_xlat1.x = u_xlat0.x / u_xlat10.x;
					    u_xlat1.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat1.xy, 0.0).z;
					    u_xlat0.z = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).w;
					    u_xlat0.xz = u_xlat0.xz;
					    u_xlat0.xz = clamp(u_xlat0.xz, 0.0, 1.0);
					    u_xlat0.x = dot(u_xlat0.xx, vec2(u_xlat16_5));
					    u_xlat0.x = u_xlat0.x * u_xlat0.z;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat3.y = 0.25;
					    u_xlat10_5 = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).x;
					    u_xlat16_5 = u_xlat10_5;
					    u_xlat16_5 = clamp(u_xlat16_5, 0.0, 1.0);
					    u_xlat5.x = u_xlat3.x + u_xlat16_5;
					    u_xlat5.xyz = u_xlat5.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb6 = 1.0<u_xlat5.x;
					    u_xlat15 = (u_xlatb6) ? u_xlat5.z : u_xlat5.x;
					    u_xlatb5 = u_xlat5.x<0.0;
					    u_xlat5.x = (u_xlatb5) ? u_xlat5.y : u_xlat15;
					    u_xlat5.xyz = u_xlat5.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = u_xlat1.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat1.xyz = u_xlat5.xyz * u_xlat2.xxx;
					    u_xlat1.x = dot(u_xlat1.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat5.xyz = u_xlat2.xxx * u_xlat5.xyz + (-u_xlat1.xxx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat5.xyz + u_xlat1.xxx;
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat10_1 = texture2D(_Curves, u_xlat0.xw).w;
					    u_xlat1.x = u_xlat10_1;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat6.x = texture2D(_Curves, u_xlat0.yw).w;
					    u_xlat6.y = texture2D(_Curves, u_xlat0.zw).w;
					    u_xlat1.yz = u_xlat6.xy;
					    u_xlat1.yz = clamp(u_xlat1.yz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat10_0 = texture2D(_Curves, u_xlat0.xw).x;
					    SV_Target0.x = u_xlat10_0;
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					    u_xlat0.x = texture2D(_Curves, u_xlat0.yw).y;
					    u_xlat0.y = texture2D(_Curves, u_xlat0.zw).z;
					    SV_Target0.yz = u_xlat0.xy;
					    SV_Target0.yz = clamp(SV_Target0.yz, 0.0, 1.0);
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec4 _UserLut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	float _Brightness;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec4 u_xlat1;
					lowp float u_xlat10_1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					lowp vec3 u_xlat10_3;
					mediump vec3 u_xlat16_4;
					lowp vec3 u_xlat10_4;
					vec3 u_xlat5;
					mediump float u_xlat16_5;
					lowp float u_xlat10_5;
					bool u_xlatb5;
					vec2 u_xlat6;
					bool u_xlatb6;
					float u_xlat7;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat15;
					void main()
					{
					    u_xlat0.x = _UserLut2D_Params.y;
					    u_xlat1.yz = vs_TEXCOORD1.xy + (-_Lut2D_Params.yz);
					    u_xlat2.x = u_xlat1.y * _Lut2D_Params.x;
					    u_xlat1.x = fract(u_xlat2.x);
					    u_xlat2.x = u_xlat1.x / _Lut2D_Params.x;
					    u_xlat1.w = u_xlat1.y + (-u_xlat2.x);
					    u_xlat2.xyz = u_xlat1.xzw * _Lut2D_Params.www;
					    u_xlat3.xyz = u_xlat2.zxy * _UserLut2D_Params.zzz;
					    u_xlat6.x = floor(u_xlat3.x);
					    u_xlat3.xw = _UserLut2D_Params.xy * vec2(0.5, 0.5);
					    u_xlat3.yz = u_xlat3.yz * _UserLut2D_Params.xy + u_xlat3.xw;
					    u_xlat3.x = u_xlat6.x * _UserLut2D_Params.y + u_xlat3.y;
					    u_xlat6.x = u_xlat2.z * _UserLut2D_Params.z + (-u_xlat6.x);
					    u_xlat0.y = float(0.0);
					    u_xlat10.y = float(0.25);
					    u_xlat0.xy = u_xlat0.xy + u_xlat3.xz;
					    u_xlat10_3.xyz = texture2D(_MainTex, u_xlat3.xz).xyz;
					    u_xlat10_4.xyz = texture2D(_MainTex, u_xlat0.xy).xyz;
					    u_xlat16_4.xyz = (-u_xlat10_3.xyz) + u_xlat10_4.xyz;
					    u_xlat3.xyz = u_xlat6.xxx * u_xlat16_4.xyz + u_xlat10_3.xyz;
					    u_xlat1.xyz = (-u_xlat1.xzw) * _Lut2D_Params.www + u_xlat3.xyz;
					    u_xlat1.xyz = _UserLut2D_Params.www * u_xlat1.xyz + u_xlat2.xyz;
					    u_xlat1.xyz = u_xlat1.xyz * vec3(vec3(_Brightness, _Brightness, _Brightness)) + vec3(-0.217637643, -0.217637643, -0.217637643);
					    u_xlat1.xyz = u_xlat1.xyz * _HueSatCon.zzz + vec3(0.217637643, 0.217637643, 0.217637643);
					    u_xlat2.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat1.xyz);
					    u_xlat2.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat1.xyz);
					    u_xlat2.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _ColorBalance.xyz;
					    u_xlat2.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat1.xyz);
					    u_xlat2.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat1.xyz);
					    u_xlat2.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _ColorFilter.xyz;
					    u_xlat2.x = dot(u_xlat1.xyz, _ChannelMixerRed.xyz);
					    u_xlat2.y = dot(u_xlat1.xyz, _ChannelMixerGreen.xyz);
					    u_xlat2.z = dot(u_xlat1.xyz, _ChannelMixerBlue.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat2.xyz = log2(abs(u_xlat1.xyz));
					    u_xlat1.xyz = u_xlat1.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat1.xyz = clamp(u_xlat1.xyz, 0.0, 1.0);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat2.xyz = u_xlat2.xyz * _InvGamma.xyz;
					    u_xlat2.xyz = exp2(u_xlat2.xyz);
					    u_xlat1.xyz = u_xlat1.xyz * u_xlat2.xyz;
					    u_xlat1.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb0 = u_xlat1.y>=u_xlat1.z;
					    u_xlat0.x = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat2.xy = u_xlat1.zy;
					    u_xlat3.xy = u_xlat1.yz + (-u_xlat2.xy);
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.666666687);
					    u_xlat3.z = float(1.0);
					    u_xlat3.w = float(-1.0);
					    u_xlat2 = u_xlat0.xxxx * u_xlat3.xywz + u_xlat2.xywz;
					    u_xlatb0 = u_xlat1.x>=u_xlat2.x;
					    u_xlat0.x = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat3.z = u_xlat2.w;
					    u_xlat2.w = u_xlat1.x;
					    u_xlat11.x = dot(u_xlat1.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat3.xyw = u_xlat2.wyx;
					    u_xlat3 = (-u_xlat2) + u_xlat3;
					    u_xlat2 = u_xlat0.xxxx * u_xlat3 + u_xlat2;
					    u_xlat0.x = min(u_xlat2.y, u_xlat2.w);
					    u_xlat0.x = (-u_xlat0.x) + u_xlat2.x;
					    u_xlat5.x = u_xlat0.x * 6.0 + 9.99999975e-05;
					    u_xlat7 = (-u_xlat2.y) + u_xlat2.w;
					    u_xlat5.x = u_xlat7 / u_xlat5.x;
					    u_xlat5.x = u_xlat5.x + u_xlat2.z;
					    u_xlat10.x = abs(u_xlat5.x);
					    u_xlat10_5 = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).y;
					    u_xlat3.x = u_xlat10.x + _HueSatCon.x;
					    u_xlat16_5 = u_xlat10_5;
					    u_xlat16_5 = clamp(u_xlat16_5, 0.0, 1.0);
					    u_xlat16_5 = u_xlat16_5 + u_xlat16_5;
					    u_xlat10.x = u_xlat2.x + 9.99999975e-05;
					    u_xlat1.x = u_xlat0.x / u_xlat10.x;
					    u_xlat1.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat1.xy, 0.0).z;
					    u_xlat0.z = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).w;
					    u_xlat0.xz = u_xlat0.xz;
					    u_xlat0.xz = clamp(u_xlat0.xz, 0.0, 1.0);
					    u_xlat0.x = dot(u_xlat0.xx, vec2(u_xlat16_5));
					    u_xlat0.x = u_xlat0.x * u_xlat0.z;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat3.y = 0.25;
					    u_xlat10_5 = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).x;
					    u_xlat16_5 = u_xlat10_5;
					    u_xlat16_5 = clamp(u_xlat16_5, 0.0, 1.0);
					    u_xlat5.x = u_xlat3.x + u_xlat16_5;
					    u_xlat5.xyz = u_xlat5.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb6 = 1.0<u_xlat5.x;
					    u_xlat15 = (u_xlatb6) ? u_xlat5.z : u_xlat5.x;
					    u_xlatb5 = u_xlat5.x<0.0;
					    u_xlat5.x = (u_xlatb5) ? u_xlat5.y : u_xlat15;
					    u_xlat5.xyz = u_xlat5.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = u_xlat1.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat1.xyz = u_xlat5.xyz * u_xlat2.xxx;
					    u_xlat1.x = dot(u_xlat1.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat5.xyz = u_xlat2.xxx * u_xlat5.xyz + (-u_xlat1.xxx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat5.xyz + u_xlat1.xxx;
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat10_1 = texture2D(_Curves, u_xlat0.xw).w;
					    u_xlat1.x = u_xlat10_1;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat6.x = texture2D(_Curves, u_xlat0.yw).w;
					    u_xlat6.y = texture2D(_Curves, u_xlat0.zw).w;
					    u_xlat1.yz = u_xlat6.xy;
					    u_xlat1.yz = clamp(u_xlat1.yz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat10_0 = texture2D(_Curves, u_xlat0.xw).x;
					    SV_Target0.x = u_xlat10_0;
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					    u_xlat0.x = texture2D(_Curves, u_xlat0.yw).y;
					    u_xlat0.y = texture2D(_Curves, u_xlat0.zw).z;
					    SV_Target0.yz = u_xlat0.xy;
					    SV_Target0.yz = clamp(SV_Target0.yz, 0.0, 1.0);
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec4 _UserLut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	float _Brightness;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec4 u_xlat1;
					lowp float u_xlat10_1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					lowp vec3 u_xlat10_3;
					mediump vec3 u_xlat16_4;
					lowp vec3 u_xlat10_4;
					vec3 u_xlat5;
					mediump float u_xlat16_5;
					lowp float u_xlat10_5;
					bool u_xlatb5;
					vec2 u_xlat6;
					bool u_xlatb6;
					float u_xlat7;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat15;
					void main()
					{
					    u_xlat0.x = _UserLut2D_Params.y;
					    u_xlat1.yz = vs_TEXCOORD1.xy + (-_Lut2D_Params.yz);
					    u_xlat2.x = u_xlat1.y * _Lut2D_Params.x;
					    u_xlat1.x = fract(u_xlat2.x);
					    u_xlat2.x = u_xlat1.x / _Lut2D_Params.x;
					    u_xlat1.w = u_xlat1.y + (-u_xlat2.x);
					    u_xlat2.xyz = u_xlat1.xzw * _Lut2D_Params.www;
					    u_xlat3.xyz = u_xlat2.zxy * _UserLut2D_Params.zzz;
					    u_xlat6.x = floor(u_xlat3.x);
					    u_xlat3.xw = _UserLut2D_Params.xy * vec2(0.5, 0.5);
					    u_xlat3.yz = u_xlat3.yz * _UserLut2D_Params.xy + u_xlat3.xw;
					    u_xlat3.x = u_xlat6.x * _UserLut2D_Params.y + u_xlat3.y;
					    u_xlat6.x = u_xlat2.z * _UserLut2D_Params.z + (-u_xlat6.x);
					    u_xlat0.y = float(0.0);
					    u_xlat10.y = float(0.25);
					    u_xlat0.xy = u_xlat0.xy + u_xlat3.xz;
					    u_xlat10_3.xyz = texture2D(_MainTex, u_xlat3.xz).xyz;
					    u_xlat10_4.xyz = texture2D(_MainTex, u_xlat0.xy).xyz;
					    u_xlat16_4.xyz = (-u_xlat10_3.xyz) + u_xlat10_4.xyz;
					    u_xlat3.xyz = u_xlat6.xxx * u_xlat16_4.xyz + u_xlat10_3.xyz;
					    u_xlat1.xyz = (-u_xlat1.xzw) * _Lut2D_Params.www + u_xlat3.xyz;
					    u_xlat1.xyz = _UserLut2D_Params.www * u_xlat1.xyz + u_xlat2.xyz;
					    u_xlat1.xyz = u_xlat1.xyz * vec3(vec3(_Brightness, _Brightness, _Brightness)) + vec3(-0.217637643, -0.217637643, -0.217637643);
					    u_xlat1.xyz = u_xlat1.xyz * _HueSatCon.zzz + vec3(0.217637643, 0.217637643, 0.217637643);
					    u_xlat2.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat1.xyz);
					    u_xlat2.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat1.xyz);
					    u_xlat2.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _ColorBalance.xyz;
					    u_xlat2.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat1.xyz);
					    u_xlat2.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat1.xyz);
					    u_xlat2.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _ColorFilter.xyz;
					    u_xlat2.x = dot(u_xlat1.xyz, _ChannelMixerRed.xyz);
					    u_xlat2.y = dot(u_xlat1.xyz, _ChannelMixerGreen.xyz);
					    u_xlat2.z = dot(u_xlat1.xyz, _ChannelMixerBlue.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat2.xyz = log2(abs(u_xlat1.xyz));
					    u_xlat1.xyz = u_xlat1.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat1.xyz = clamp(u_xlat1.xyz, 0.0, 1.0);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat2.xyz = u_xlat2.xyz * _InvGamma.xyz;
					    u_xlat2.xyz = exp2(u_xlat2.xyz);
					    u_xlat1.xyz = u_xlat1.xyz * u_xlat2.xyz;
					    u_xlat1.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb0 = u_xlat1.y>=u_xlat1.z;
					    u_xlat0.x = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat2.xy = u_xlat1.zy;
					    u_xlat3.xy = u_xlat1.yz + (-u_xlat2.xy);
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.666666687);
					    u_xlat3.z = float(1.0);
					    u_xlat3.w = float(-1.0);
					    u_xlat2 = u_xlat0.xxxx * u_xlat3.xywz + u_xlat2.xywz;
					    u_xlatb0 = u_xlat1.x>=u_xlat2.x;
					    u_xlat0.x = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat3.z = u_xlat2.w;
					    u_xlat2.w = u_xlat1.x;
					    u_xlat11.x = dot(u_xlat1.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat3.xyw = u_xlat2.wyx;
					    u_xlat3 = (-u_xlat2) + u_xlat3;
					    u_xlat2 = u_xlat0.xxxx * u_xlat3 + u_xlat2;
					    u_xlat0.x = min(u_xlat2.y, u_xlat2.w);
					    u_xlat0.x = (-u_xlat0.x) + u_xlat2.x;
					    u_xlat5.x = u_xlat0.x * 6.0 + 9.99999975e-05;
					    u_xlat7 = (-u_xlat2.y) + u_xlat2.w;
					    u_xlat5.x = u_xlat7 / u_xlat5.x;
					    u_xlat5.x = u_xlat5.x + u_xlat2.z;
					    u_xlat10.x = abs(u_xlat5.x);
					    u_xlat10_5 = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).y;
					    u_xlat3.x = u_xlat10.x + _HueSatCon.x;
					    u_xlat16_5 = u_xlat10_5;
					    u_xlat16_5 = clamp(u_xlat16_5, 0.0, 1.0);
					    u_xlat16_5 = u_xlat16_5 + u_xlat16_5;
					    u_xlat10.x = u_xlat2.x + 9.99999975e-05;
					    u_xlat1.x = u_xlat0.x / u_xlat10.x;
					    u_xlat1.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat1.xy, 0.0).z;
					    u_xlat0.z = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).w;
					    u_xlat0.xz = u_xlat0.xz;
					    u_xlat0.xz = clamp(u_xlat0.xz, 0.0, 1.0);
					    u_xlat0.x = dot(u_xlat0.xx, vec2(u_xlat16_5));
					    u_xlat0.x = u_xlat0.x * u_xlat0.z;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat3.y = 0.25;
					    u_xlat10_5 = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).x;
					    u_xlat16_5 = u_xlat10_5;
					    u_xlat16_5 = clamp(u_xlat16_5, 0.0, 1.0);
					    u_xlat5.x = u_xlat3.x + u_xlat16_5;
					    u_xlat5.xyz = u_xlat5.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb6 = 1.0<u_xlat5.x;
					    u_xlat15 = (u_xlatb6) ? u_xlat5.z : u_xlat5.x;
					    u_xlatb5 = u_xlat5.x<0.0;
					    u_xlat5.x = (u_xlatb5) ? u_xlat5.y : u_xlat15;
					    u_xlat5.xyz = u_xlat5.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = u_xlat1.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat1.xyz = u_xlat5.xyz * u_xlat2.xxx;
					    u_xlat1.x = dot(u_xlat1.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat5.xyz = u_xlat2.xxx * u_xlat5.xyz + (-u_xlat1.xxx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat5.xyz + u_xlat1.xxx;
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat10_1 = texture2D(_Curves, u_xlat0.xw).w;
					    u_xlat1.x = u_xlat10_1;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat6.x = texture2D(_Curves, u_xlat0.yw).w;
					    u_xlat6.y = texture2D(_Curves, u_xlat0.zw).w;
					    u_xlat1.yz = u_xlat6.xy;
					    u_xlat1.yz = clamp(u_xlat1.yz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat10_0 = texture2D(_Curves, u_xlat0.xw).x;
					    SV_Target0.x = u_xlat10_0;
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					    u_xlat0.x = texture2D(_Curves, u_xlat0.yw).y;
					    u_xlat0.y = texture2D(_Curves, u_xlat0.zw).z;
					    SV_Target0.yz = u_xlat0.xy;
					    SV_Target0.yz = clamp(SV_Target0.yz, 0.0, 1.0);
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec4 _UserLut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	float _Brightness;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec4 u_xlat1;
					mediump float u_xlat16_1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					vec3 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb5;
					vec2 u_xlat6;
					bool u_xlatb6;
					float u_xlat7;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat15;
					void main()
					{
					    u_xlat0.x = _UserLut2D_Params.y;
					    u_xlat1.yz = vs_TEXCOORD1.xy + (-_Lut2D_Params.yz);
					    u_xlat2.x = u_xlat1.y * _Lut2D_Params.x;
					    u_xlat1.x = fract(u_xlat2.x);
					    u_xlat2.x = u_xlat1.x / _Lut2D_Params.x;
					    u_xlat1.w = u_xlat1.y + (-u_xlat2.x);
					    u_xlat2.xyz = u_xlat1.xzw * _Lut2D_Params.www;
					    u_xlat3.xyz = u_xlat2.zxy * _UserLut2D_Params.zzz;
					    u_xlat6.x = floor(u_xlat3.x);
					    u_xlat3.xw = _UserLut2D_Params.xy * vec2(0.5, 0.5);
					    u_xlat3.yz = u_xlat3.yz * _UserLut2D_Params.xy + u_xlat3.xw;
					    u_xlat3.x = u_xlat6.x * _UserLut2D_Params.y + u_xlat3.y;
					    u_xlat6.x = u_xlat2.z * _UserLut2D_Params.z + (-u_xlat6.x);
					    u_xlat0.y = float(0.0);
					    u_xlat10.y = float(0.25);
					    u_xlat0.xy = u_xlat0.xy + u_xlat3.xz;
					    u_xlat16_3.xyz = texture(_MainTex, u_xlat3.xz).xyz;
					    u_xlat16_4.xyz = texture(_MainTex, u_xlat0.xy).xyz;
					    u_xlat16_4.xyz = (-u_xlat16_3.xyz) + u_xlat16_4.xyz;
					    u_xlat3.xyz = u_xlat6.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					    u_xlat1.xyz = (-u_xlat1.xzw) * _Lut2D_Params.www + u_xlat3.xyz;
					    u_xlat1.xyz = _UserLut2D_Params.www * u_xlat1.xyz + u_xlat2.xyz;
					    u_xlat1.xyz = u_xlat1.xyz * vec3(vec3(_Brightness, _Brightness, _Brightness)) + vec3(-0.217637643, -0.217637643, -0.217637643);
					    u_xlat1.xyz = u_xlat1.xyz * _HueSatCon.zzz + vec3(0.217637643, 0.217637643, 0.217637643);
					    u_xlat2.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat1.xyz);
					    u_xlat2.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat1.xyz);
					    u_xlat2.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _ColorBalance.xyz;
					    u_xlat2.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat1.xyz);
					    u_xlat2.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat1.xyz);
					    u_xlat2.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _ColorFilter.xyz;
					    u_xlat2.x = dot(u_xlat1.xyz, _ChannelMixerRed.xyz);
					    u_xlat2.y = dot(u_xlat1.xyz, _ChannelMixerGreen.xyz);
					    u_xlat2.z = dot(u_xlat1.xyz, _ChannelMixerBlue.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat2.xyz = log2(abs(u_xlat1.xyz));
					    u_xlat1.xyz = u_xlat1.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xyz = min(max(u_xlat1.xyz, 0.0), 1.0);
					#else
					    u_xlat1.xyz = clamp(u_xlat1.xyz, 0.0, 1.0);
					#endif
					    u_xlat1.xyz = u_xlat1.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat2.xyz = u_xlat2.xyz * _InvGamma.xyz;
					    u_xlat2.xyz = exp2(u_xlat2.xyz);
					    u_xlat1.xyz = u_xlat1.xyz * u_xlat2.xyz;
					    u_xlat1.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat1.y>=u_xlat1.z);
					#else
					    u_xlatb0 = u_xlat1.y>=u_xlat1.z;
					#endif
					    u_xlat0.x = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat2.xy = u_xlat1.zy;
					    u_xlat3.xy = u_xlat1.yz + (-u_xlat2.xy);
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.666666687);
					    u_xlat3.z = float(1.0);
					    u_xlat3.w = float(-1.0);
					    u_xlat2 = u_xlat0.xxxx * u_xlat3.xywz + u_xlat2.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat1.x>=u_xlat2.x);
					#else
					    u_xlatb0 = u_xlat1.x>=u_xlat2.x;
					#endif
					    u_xlat0.x = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat3.z = u_xlat2.w;
					    u_xlat2.w = u_xlat1.x;
					    u_xlat11.x = dot(u_xlat1.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat3.xyw = u_xlat2.wyx;
					    u_xlat3 = (-u_xlat2) + u_xlat3;
					    u_xlat2 = u_xlat0.xxxx * u_xlat3 + u_xlat2;
					    u_xlat0.x = min(u_xlat2.y, u_xlat2.w);
					    u_xlat0.x = (-u_xlat0.x) + u_xlat2.x;
					    u_xlat5.x = u_xlat0.x * 6.0 + 9.99999975e-05;
					    u_xlat7 = (-u_xlat2.y) + u_xlat2.w;
					    u_xlat5.x = u_xlat7 / u_xlat5.x;
					    u_xlat5.x = u_xlat5.x + u_xlat2.z;
					    u_xlat10.x = abs(u_xlat5.x);
					    u_xlat16_5 = textureLod(_Curves, u_xlat10.xy, 0.0).y;
					    u_xlat3.x = u_xlat10.x + _HueSatCon.x;
					    u_xlat16_5 = u_xlat16_5;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_5 = min(max(u_xlat16_5, 0.0), 1.0);
					#else
					    u_xlat16_5 = clamp(u_xlat16_5, 0.0, 1.0);
					#endif
					    u_xlat16_5 = u_xlat16_5 + u_xlat16_5;
					    u_xlat10.x = u_xlat2.x + 9.99999975e-05;
					    u_xlat1.x = u_xlat0.x / u_xlat10.x;
					    u_xlat1.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat1.xy, 0.0).z;
					    u_xlat0.z = textureLod(_Curves, u_xlat11.xy, 0.0).w;
					    u_xlat0.xz = u_xlat0.xz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xz = min(max(u_xlat0.xz, 0.0), 1.0);
					#else
					    u_xlat0.xz = clamp(u_xlat0.xz, 0.0, 1.0);
					#endif
					    u_xlat0.x = dot(u_xlat0.xx, vec2(u_xlat16_5));
					    u_xlat0.x = u_xlat0.x * u_xlat0.z;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat3.y = 0.25;
					    u_xlat16_5 = textureLod(_Curves, u_xlat3.xy, 0.0).x;
					    u_xlat16_5 = u_xlat16_5;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_5 = min(max(u_xlat16_5, 0.0), 1.0);
					#else
					    u_xlat16_5 = clamp(u_xlat16_5, 0.0, 1.0);
					#endif
					    u_xlat5.x = u_xlat3.x + u_xlat16_5;
					    u_xlat5.xyz = u_xlat5.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(1.0<u_xlat5.x);
					#else
					    u_xlatb6 = 1.0<u_xlat5.x;
					#endif
					    u_xlat15 = (u_xlatb6) ? u_xlat5.z : u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb5 = !!(u_xlat5.x<0.0);
					#else
					    u_xlatb5 = u_xlat5.x<0.0;
					#endif
					    u_xlat5.x = (u_xlatb5) ? u_xlat5.y : u_xlat15;
					    u_xlat5.xyz = u_xlat5.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = u_xlat1.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat1.xyz = u_xlat5.xyz * u_xlat2.xxx;
					    u_xlat1.x = dot(u_xlat1.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat5.xyz = u_xlat2.xxx * u_xlat5.xyz + (-u_xlat1.xxx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat5.xyz + u_xlat1.xxx;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat16_1 = texture(_Curves, u_xlat0.xw).w;
					    u_xlat1.x = u_xlat16_1;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.x = min(max(u_xlat1.x, 0.0), 1.0);
					#else
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					#endif
					    u_xlat6.x = texture(_Curves, u_xlat0.yw).w;
					    u_xlat6.y = texture(_Curves, u_xlat0.zw).w;
					    u_xlat1.yz = u_xlat6.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.yz = min(max(u_xlat1.yz, 0.0), 1.0);
					#else
					    u_xlat1.yz = clamp(u_xlat1.yz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat16_0 = texture(_Curves, u_xlat0.xw).x;
					    SV_Target0.x = u_xlat16_0;
					#ifdef UNITY_ADRENO_ES3
					    SV_Target0.x = min(max(SV_Target0.x, 0.0), 1.0);
					#else
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					#endif
					    u_xlat0.x = texture(_Curves, u_xlat0.yw).y;
					    u_xlat0.y = texture(_Curves, u_xlat0.zw).z;
					    SV_Target0.yz = u_xlat0.xy;
					#ifdef UNITY_ADRENO_ES3
					    SV_Target0.yz = min(max(SV_Target0.yz, 0.0), 1.0);
					#else
					    SV_Target0.yz = clamp(SV_Target0.yz, 0.0, 1.0);
					#endif
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec4 _UserLut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	float _Brightness;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec4 u_xlat1;
					mediump float u_xlat16_1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					vec3 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb5;
					vec2 u_xlat6;
					bool u_xlatb6;
					float u_xlat7;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat15;
					void main()
					{
					    u_xlat0.x = _UserLut2D_Params.y;
					    u_xlat1.yz = vs_TEXCOORD1.xy + (-_Lut2D_Params.yz);
					    u_xlat2.x = u_xlat1.y * _Lut2D_Params.x;
					    u_xlat1.x = fract(u_xlat2.x);
					    u_xlat2.x = u_xlat1.x / _Lut2D_Params.x;
					    u_xlat1.w = u_xlat1.y + (-u_xlat2.x);
					    u_xlat2.xyz = u_xlat1.xzw * _Lut2D_Params.www;
					    u_xlat3.xyz = u_xlat2.zxy * _UserLut2D_Params.zzz;
					    u_xlat6.x = floor(u_xlat3.x);
					    u_xlat3.xw = _UserLut2D_Params.xy * vec2(0.5, 0.5);
					    u_xlat3.yz = u_xlat3.yz * _UserLut2D_Params.xy + u_xlat3.xw;
					    u_xlat3.x = u_xlat6.x * _UserLut2D_Params.y + u_xlat3.y;
					    u_xlat6.x = u_xlat2.z * _UserLut2D_Params.z + (-u_xlat6.x);
					    u_xlat0.y = float(0.0);
					    u_xlat10.y = float(0.25);
					    u_xlat0.xy = u_xlat0.xy + u_xlat3.xz;
					    u_xlat16_3.xyz = texture(_MainTex, u_xlat3.xz).xyz;
					    u_xlat16_4.xyz = texture(_MainTex, u_xlat0.xy).xyz;
					    u_xlat16_4.xyz = (-u_xlat16_3.xyz) + u_xlat16_4.xyz;
					    u_xlat3.xyz = u_xlat6.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					    u_xlat1.xyz = (-u_xlat1.xzw) * _Lut2D_Params.www + u_xlat3.xyz;
					    u_xlat1.xyz = _UserLut2D_Params.www * u_xlat1.xyz + u_xlat2.xyz;
					    u_xlat1.xyz = u_xlat1.xyz * vec3(vec3(_Brightness, _Brightness, _Brightness)) + vec3(-0.217637643, -0.217637643, -0.217637643);
					    u_xlat1.xyz = u_xlat1.xyz * _HueSatCon.zzz + vec3(0.217637643, 0.217637643, 0.217637643);
					    u_xlat2.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat1.xyz);
					    u_xlat2.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat1.xyz);
					    u_xlat2.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _ColorBalance.xyz;
					    u_xlat2.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat1.xyz);
					    u_xlat2.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat1.xyz);
					    u_xlat2.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _ColorFilter.xyz;
					    u_xlat2.x = dot(u_xlat1.xyz, _ChannelMixerRed.xyz);
					    u_xlat2.y = dot(u_xlat1.xyz, _ChannelMixerGreen.xyz);
					    u_xlat2.z = dot(u_xlat1.xyz, _ChannelMixerBlue.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat2.xyz = log2(abs(u_xlat1.xyz));
					    u_xlat1.xyz = u_xlat1.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xyz = min(max(u_xlat1.xyz, 0.0), 1.0);
					#else
					    u_xlat1.xyz = clamp(u_xlat1.xyz, 0.0, 1.0);
					#endif
					    u_xlat1.xyz = u_xlat1.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat2.xyz = u_xlat2.xyz * _InvGamma.xyz;
					    u_xlat2.xyz = exp2(u_xlat2.xyz);
					    u_xlat1.xyz = u_xlat1.xyz * u_xlat2.xyz;
					    u_xlat1.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat1.y>=u_xlat1.z);
					#else
					    u_xlatb0 = u_xlat1.y>=u_xlat1.z;
					#endif
					    u_xlat0.x = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat2.xy = u_xlat1.zy;
					    u_xlat3.xy = u_xlat1.yz + (-u_xlat2.xy);
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.666666687);
					    u_xlat3.z = float(1.0);
					    u_xlat3.w = float(-1.0);
					    u_xlat2 = u_xlat0.xxxx * u_xlat3.xywz + u_xlat2.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat1.x>=u_xlat2.x);
					#else
					    u_xlatb0 = u_xlat1.x>=u_xlat2.x;
					#endif
					    u_xlat0.x = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat3.z = u_xlat2.w;
					    u_xlat2.w = u_xlat1.x;
					    u_xlat11.x = dot(u_xlat1.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat3.xyw = u_xlat2.wyx;
					    u_xlat3 = (-u_xlat2) + u_xlat3;
					    u_xlat2 = u_xlat0.xxxx * u_xlat3 + u_xlat2;
					    u_xlat0.x = min(u_xlat2.y, u_xlat2.w);
					    u_xlat0.x = (-u_xlat0.x) + u_xlat2.x;
					    u_xlat5.x = u_xlat0.x * 6.0 + 9.99999975e-05;
					    u_xlat7 = (-u_xlat2.y) + u_xlat2.w;
					    u_xlat5.x = u_xlat7 / u_xlat5.x;
					    u_xlat5.x = u_xlat5.x + u_xlat2.z;
					    u_xlat10.x = abs(u_xlat5.x);
					    u_xlat16_5 = textureLod(_Curves, u_xlat10.xy, 0.0).y;
					    u_xlat3.x = u_xlat10.x + _HueSatCon.x;
					    u_xlat16_5 = u_xlat16_5;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_5 = min(max(u_xlat16_5, 0.0), 1.0);
					#else
					    u_xlat16_5 = clamp(u_xlat16_5, 0.0, 1.0);
					#endif
					    u_xlat16_5 = u_xlat16_5 + u_xlat16_5;
					    u_xlat10.x = u_xlat2.x + 9.99999975e-05;
					    u_xlat1.x = u_xlat0.x / u_xlat10.x;
					    u_xlat1.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat1.xy, 0.0).z;
					    u_xlat0.z = textureLod(_Curves, u_xlat11.xy, 0.0).w;
					    u_xlat0.xz = u_xlat0.xz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xz = min(max(u_xlat0.xz, 0.0), 1.0);
					#else
					    u_xlat0.xz = clamp(u_xlat0.xz, 0.0, 1.0);
					#endif
					    u_xlat0.x = dot(u_xlat0.xx, vec2(u_xlat16_5));
					    u_xlat0.x = u_xlat0.x * u_xlat0.z;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat3.y = 0.25;
					    u_xlat16_5 = textureLod(_Curves, u_xlat3.xy, 0.0).x;
					    u_xlat16_5 = u_xlat16_5;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_5 = min(max(u_xlat16_5, 0.0), 1.0);
					#else
					    u_xlat16_5 = clamp(u_xlat16_5, 0.0, 1.0);
					#endif
					    u_xlat5.x = u_xlat3.x + u_xlat16_5;
					    u_xlat5.xyz = u_xlat5.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(1.0<u_xlat5.x);
					#else
					    u_xlatb6 = 1.0<u_xlat5.x;
					#endif
					    u_xlat15 = (u_xlatb6) ? u_xlat5.z : u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb5 = !!(u_xlat5.x<0.0);
					#else
					    u_xlatb5 = u_xlat5.x<0.0;
					#endif
					    u_xlat5.x = (u_xlatb5) ? u_xlat5.y : u_xlat15;
					    u_xlat5.xyz = u_xlat5.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = u_xlat1.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat1.xyz = u_xlat5.xyz * u_xlat2.xxx;
					    u_xlat1.x = dot(u_xlat1.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat5.xyz = u_xlat2.xxx * u_xlat5.xyz + (-u_xlat1.xxx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat5.xyz + u_xlat1.xxx;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat16_1 = texture(_Curves, u_xlat0.xw).w;
					    u_xlat1.x = u_xlat16_1;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.x = min(max(u_xlat1.x, 0.0), 1.0);
					#else
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					#endif
					    u_xlat6.x = texture(_Curves, u_xlat0.yw).w;
					    u_xlat6.y = texture(_Curves, u_xlat0.zw).w;
					    u_xlat1.yz = u_xlat6.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.yz = min(max(u_xlat1.yz, 0.0), 1.0);
					#else
					    u_xlat1.yz = clamp(u_xlat1.yz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat16_0 = texture(_Curves, u_xlat0.xw).x;
					    SV_Target0.x = u_xlat16_0;
					#ifdef UNITY_ADRENO_ES3
					    SV_Target0.x = min(max(SV_Target0.x, 0.0), 1.0);
					#else
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					#endif
					    u_xlat0.x = texture(_Curves, u_xlat0.yw).y;
					    u_xlat0.y = texture(_Curves, u_xlat0.zw).z;
					    SV_Target0.yz = u_xlat0.xy;
					#ifdef UNITY_ADRENO_ES3
					    SV_Target0.yz = min(max(SV_Target0.yz, 0.0), 1.0);
					#else
					    SV_Target0.yz = clamp(SV_Target0.yz, 0.0, 1.0);
					#endif
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec4 _UserLut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	float _Brightness;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec4 u_xlat1;
					mediump float u_xlat16_1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					mediump vec3 u_xlat16_3;
					mediump vec3 u_xlat16_4;
					vec3 u_xlat5;
					mediump float u_xlat16_5;
					bool u_xlatb5;
					vec2 u_xlat6;
					bool u_xlatb6;
					float u_xlat7;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat15;
					void main()
					{
					    u_xlat0.x = _UserLut2D_Params.y;
					    u_xlat1.yz = vs_TEXCOORD1.xy + (-_Lut2D_Params.yz);
					    u_xlat2.x = u_xlat1.y * _Lut2D_Params.x;
					    u_xlat1.x = fract(u_xlat2.x);
					    u_xlat2.x = u_xlat1.x / _Lut2D_Params.x;
					    u_xlat1.w = u_xlat1.y + (-u_xlat2.x);
					    u_xlat2.xyz = u_xlat1.xzw * _Lut2D_Params.www;
					    u_xlat3.xyz = u_xlat2.zxy * _UserLut2D_Params.zzz;
					    u_xlat6.x = floor(u_xlat3.x);
					    u_xlat3.xw = _UserLut2D_Params.xy * vec2(0.5, 0.5);
					    u_xlat3.yz = u_xlat3.yz * _UserLut2D_Params.xy + u_xlat3.xw;
					    u_xlat3.x = u_xlat6.x * _UserLut2D_Params.y + u_xlat3.y;
					    u_xlat6.x = u_xlat2.z * _UserLut2D_Params.z + (-u_xlat6.x);
					    u_xlat0.y = float(0.0);
					    u_xlat10.y = float(0.25);
					    u_xlat0.xy = u_xlat0.xy + u_xlat3.xz;
					    u_xlat16_3.xyz = texture(_MainTex, u_xlat3.xz).xyz;
					    u_xlat16_4.xyz = texture(_MainTex, u_xlat0.xy).xyz;
					    u_xlat16_4.xyz = (-u_xlat16_3.xyz) + u_xlat16_4.xyz;
					    u_xlat3.xyz = u_xlat6.xxx * u_xlat16_4.xyz + u_xlat16_3.xyz;
					    u_xlat1.xyz = (-u_xlat1.xzw) * _Lut2D_Params.www + u_xlat3.xyz;
					    u_xlat1.xyz = _UserLut2D_Params.www * u_xlat1.xyz + u_xlat2.xyz;
					    u_xlat1.xyz = u_xlat1.xyz * vec3(vec3(_Brightness, _Brightness, _Brightness)) + vec3(-0.217637643, -0.217637643, -0.217637643);
					    u_xlat1.xyz = u_xlat1.xyz * _HueSatCon.zzz + vec3(0.217637643, 0.217637643, 0.217637643);
					    u_xlat2.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat1.xyz);
					    u_xlat2.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat1.xyz);
					    u_xlat2.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _ColorBalance.xyz;
					    u_xlat2.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat1.xyz);
					    u_xlat2.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat1.xyz);
					    u_xlat2.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _ColorFilter.xyz;
					    u_xlat2.x = dot(u_xlat1.xyz, _ChannelMixerRed.xyz);
					    u_xlat2.y = dot(u_xlat1.xyz, _ChannelMixerGreen.xyz);
					    u_xlat2.z = dot(u_xlat1.xyz, _ChannelMixerBlue.xyz);
					    u_xlat1.xyz = u_xlat2.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat2.xyz = log2(abs(u_xlat1.xyz));
					    u_xlat1.xyz = u_xlat1.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.xyz = min(max(u_xlat1.xyz, 0.0), 1.0);
					#else
					    u_xlat1.xyz = clamp(u_xlat1.xyz, 0.0, 1.0);
					#endif
					    u_xlat1.xyz = u_xlat1.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat2.xyz = u_xlat2.xyz * _InvGamma.xyz;
					    u_xlat2.xyz = exp2(u_xlat2.xyz);
					    u_xlat1.xyz = u_xlat1.xyz * u_xlat2.xyz;
					    u_xlat1.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat1.y>=u_xlat1.z);
					#else
					    u_xlatb0 = u_xlat1.y>=u_xlat1.z;
					#endif
					    u_xlat0.x = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat2.xy = u_xlat1.zy;
					    u_xlat3.xy = u_xlat1.yz + (-u_xlat2.xy);
					    u_xlat2.z = float(-1.0);
					    u_xlat2.w = float(0.666666687);
					    u_xlat3.z = float(1.0);
					    u_xlat3.w = float(-1.0);
					    u_xlat2 = u_xlat0.xxxx * u_xlat3.xywz + u_xlat2.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(u_xlat1.x>=u_xlat2.x);
					#else
					    u_xlatb0 = u_xlat1.x>=u_xlat2.x;
					#endif
					    u_xlat0.x = u_xlatb0 ? 1.0 : float(0.0);
					    u_xlat3.z = u_xlat2.w;
					    u_xlat2.w = u_xlat1.x;
					    u_xlat11.x = dot(u_xlat1.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat3.xyw = u_xlat2.wyx;
					    u_xlat3 = (-u_xlat2) + u_xlat3;
					    u_xlat2 = u_xlat0.xxxx * u_xlat3 + u_xlat2;
					    u_xlat0.x = min(u_xlat2.y, u_xlat2.w);
					    u_xlat0.x = (-u_xlat0.x) + u_xlat2.x;
					    u_xlat5.x = u_xlat0.x * 6.0 + 9.99999975e-05;
					    u_xlat7 = (-u_xlat2.y) + u_xlat2.w;
					    u_xlat5.x = u_xlat7 / u_xlat5.x;
					    u_xlat5.x = u_xlat5.x + u_xlat2.z;
					    u_xlat10.x = abs(u_xlat5.x);
					    u_xlat16_5 = textureLod(_Curves, u_xlat10.xy, 0.0).y;
					    u_xlat3.x = u_xlat10.x + _HueSatCon.x;
					    u_xlat16_5 = u_xlat16_5;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_5 = min(max(u_xlat16_5, 0.0), 1.0);
					#else
					    u_xlat16_5 = clamp(u_xlat16_5, 0.0, 1.0);
					#endif
					    u_xlat16_5 = u_xlat16_5 + u_xlat16_5;
					    u_xlat10.x = u_xlat2.x + 9.99999975e-05;
					    u_xlat1.x = u_xlat0.x / u_xlat10.x;
					    u_xlat1.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat1.xy, 0.0).z;
					    u_xlat0.z = textureLod(_Curves, u_xlat11.xy, 0.0).w;
					    u_xlat0.xz = u_xlat0.xz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xz = min(max(u_xlat0.xz, 0.0), 1.0);
					#else
					    u_xlat0.xz = clamp(u_xlat0.xz, 0.0, 1.0);
					#endif
					    u_xlat0.x = dot(u_xlat0.xx, vec2(u_xlat16_5));
					    u_xlat0.x = u_xlat0.x * u_xlat0.z;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat3.y = 0.25;
					    u_xlat16_5 = textureLod(_Curves, u_xlat3.xy, 0.0).x;
					    u_xlat16_5 = u_xlat16_5;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat16_5 = min(max(u_xlat16_5, 0.0), 1.0);
					#else
					    u_xlat16_5 = clamp(u_xlat16_5, 0.0, 1.0);
					#endif
					    u_xlat5.x = u_xlat3.x + u_xlat16_5;
					    u_xlat5.xyz = u_xlat5.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(1.0<u_xlat5.x);
					#else
					    u_xlatb6 = 1.0<u_xlat5.x;
					#endif
					    u_xlat15 = (u_xlatb6) ? u_xlat5.z : u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb5 = !!(u_xlat5.x<0.0);
					#else
					    u_xlatb5 = u_xlat5.x<0.0;
					#endif
					    u_xlat5.x = (u_xlatb5) ? u_xlat5.y : u_xlat15;
					    u_xlat5.xyz = u_xlat5.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = u_xlat1.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat1.xyz = u_xlat5.xyz * u_xlat2.xxx;
					    u_xlat1.x = dot(u_xlat1.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat5.xyz = u_xlat2.xxx * u_xlat5.xyz + (-u_xlat1.xxx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat5.xyz + u_xlat1.xxx;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat16_1 = texture(_Curves, u_xlat0.xw).w;
					    u_xlat1.x = u_xlat16_1;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.x = min(max(u_xlat1.x, 0.0), 1.0);
					#else
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					#endif
					    u_xlat6.x = texture(_Curves, u_xlat0.yw).w;
					    u_xlat6.y = texture(_Curves, u_xlat0.zw).w;
					    u_xlat1.yz = u_xlat6.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat1.yz = min(max(u_xlat1.yz, 0.0), 1.0);
					#else
					    u_xlat1.yz = clamp(u_xlat1.yz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat1.xyz + vec3(0.00390625, 0.00390625, 0.00390625);
					    u_xlat0.w = 0.75;
					    u_xlat16_0 = texture(_Curves, u_xlat0.xw).x;
					    SV_Target0.x = u_xlat16_0;
					#ifdef UNITY_ADRENO_ES3
					    SV_Target0.x = min(max(SV_Target0.x, 0.0), 1.0);
					#else
					    SV_Target0.x = clamp(SV_Target0.x, 0.0, 1.0);
					#endif
					    u_xlat0.x = texture(_Curves, u_xlat0.yw).y;
					    u_xlat0.y = texture(_Curves, u_xlat0.zw).z;
					    SV_Target0.yz = u_xlat0.xy;
					#ifdef UNITY_ADRENO_ES3
					    SV_Target0.yz = min(max(SV_Target0.yz, 0.0), 1.0);
					#else
					    SV_Target0.yz = clamp(SV_Target0.yz, 0.0, 1.0);
					#endif
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
			GpuProgramID 167588
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb4 = 1.0<u_xlat5.x;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					    u_xlatb12 = u_xlat5.x<0.0;
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb4 = 1.0<u_xlat5.x;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					    u_xlatb12 = u_xlat5.x<0.0;
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb4 = 1.0<u_xlat5.x;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					    u_xlatb12 = u_xlat5.x<0.0;
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = textureLod(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(1.0<u_xlat5.x);
					#else
					    u_xlatb4 = 1.0<u_xlat5.x;
					#endif
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat5.x<0.0);
					#else
					    u_xlatb12 = u_xlat5.x<0.0;
					#endif
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = textureLod(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(1.0<u_xlat5.x);
					#else
					    u_xlatb4 = 1.0<u_xlat5.x;
					#endif
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat5.x<0.0);
					#else
					    u_xlatb12 = u_xlat5.x<0.0;
					#endif
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
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
					#ifdef GL_EXT_shader_texture_lod
					#extension GL_EXT_shader_texture_lod : enable
					#endif
					
					precision highp float;
					precision highp int;
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = textureLod(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(1.0<u_xlat5.x);
					#else
					    u_xlatb4 = 1.0<u_xlat5.x;
					#endif
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat5.x<0.0);
					#else
					    u_xlatb12 = u_xlat5.x<0.0;
					#endif
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "TONEMAPPING_ACES" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					bvec3 u_xlatb0;
					vec4 u_xlat1;
					bvec4 u_xlatb1;
					vec4 u_xlat2;
					bvec2 u_xlatb2;
					vec3 u_xlat3;
					vec3 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					bool u_xlatb5;
					float u_xlat8;
					float u_xlat9;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.386036009, -0.386036009, -0.386036009);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.439700991, 0.382977992, 0.177334994), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.0897922963, 0.813422978, 0.0967615992), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0175439995, 0.111543998, 0.870703995), u_xlat0.xyz);
					    u_xlat0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = min(u_xlat0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5) + vec3(1.525878e-05, 1.525878e-05, 1.525878e-05);
					    u_xlat1.xyz = log2(u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat1.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat2.xyz = log2(u_xlat0.xyz);
					    u_xlatb0.xyz = lessThan(u_xlat0.xyzx, vec4(3.05175708e-05, 3.05175708e-05, 3.05175708e-05, 0.0)).xyz;
					    u_xlat2.xyz = u_xlat2.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat2.xyz = u_xlat2.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat2.x;
					    u_xlat0.y = (u_xlatb0.y) ? u_xlat1.y : u_xlat2.y;
					    u_xlat0.z = (u_xlatb0.z) ? u_xlat1.z : u_xlat2.z;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.413588405, 0.413588405, 0.413588405);
					    u_xlatb1 = lessThan(u_xlat0.xxyy, vec4(-0.301369876, 1.46799636, -0.301369876, 1.46799636));
					    u_xlat0.xyw = u_xlat0.xyz * vec3(17.5200005, 17.5200005, 17.5200005) + vec3(-9.72000027, -9.72000027, -9.72000027);
					    u_xlatb2.xy = lessThan(u_xlat0.zzzz, vec4(-0.301369876, 1.46799636, 0.0, 0.0)).xy;
					    u_xlat0.xyz = exp2(u_xlat0.xyw);
					    u_xlat5.x = (u_xlatb1.y) ? u_xlat0.x : float(65504.0);
					    u_xlat5.z = (u_xlatb1.w) ? u_xlat0.y : float(65504.0);
					    u_xlat0.xyw = u_xlat0.xyz + vec3(-1.52587891e-05, -1.52587891e-05, -1.52587891e-05);
					    u_xlat8 = (u_xlatb2.y) ? u_xlat0.z : 65504.0;
					    u_xlat0.xyw = u_xlat0.xyw + u_xlat0.xyw;
					    u_xlat1.x = (u_xlatb1.x) ? u_xlat0.x : u_xlat5.x;
					    u_xlat1.y = (u_xlatb1.z) ? u_xlat0.y : u_xlat5.z;
					    u_xlat1.z = (u_xlatb2.x) ? u_xlat0.w : u_xlat8;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat1.xyz);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.x = u_xlat4.x + -0.5;
					    u_xlat4.x = u_xlat4.x + u_xlat11.x;
					    u_xlatb12 = 1.0<u_xlat4.x;
					    u_xlat5.xy = u_xlat4.xx + vec2(1.0, -1.0);
					    u_xlat12 = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlatb4 = u_xlat4.x<0.0;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.x : u_xlat12;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat5.x = dot(vec3(0.695452213, 0.140678704, 0.163869068), u_xlat0.xyz);
					    u_xlat5.y = dot(vec3(0.0447945632, 0.859671116, 0.0955343172), u_xlat0.xyz);
					    u_xlat5.z = dot(vec3(-0.00552588282, 0.00402521016, 1.00150073), u_xlat0.xyz);
					    u_xlat0.xyz = (-u_xlat5.yxz) + u_xlat5.zyx;
					    u_xlat0.xy = u_xlat0.xy * u_xlat5.zy;
					    u_xlat0.x = u_xlat0.y + u_xlat0.x;
					    u_xlat0.x = u_xlat5.x * u_xlat0.z + u_xlat0.x;
					    u_xlat0.x = sqrt(u_xlat0.x);
					    u_xlat4.x = u_xlat5.y + u_xlat5.z;
					    u_xlat4.x = u_xlat5.x + u_xlat4.x;
					    u_xlat0.x = u_xlat0.x * 1.75 + u_xlat4.x;
					    u_xlat4.x = u_xlat0.x * 0.333333343;
					    u_xlat4.x = 0.0799999982 / u_xlat4.x;
					    u_xlat8 = min(u_xlat5.y, u_xlat5.x);
					    u_xlat8 = min(u_xlat5.z, u_xlat8);
					    u_xlat8 = max(u_xlat8, 9.99999975e-05);
					    u_xlat12 = max(u_xlat5.y, u_xlat5.x);
					    u_xlat12 = max(u_xlat5.z, u_xlat12);
					    u_xlat2.xy = max(vec2(u_xlat12), vec2(9.99999975e-05, 0.00999999978));
					    u_xlat8 = (-u_xlat8) + u_xlat2.x;
					    u_xlat4.y = u_xlat8 / u_xlat2.y;
					    u_xlat4.xz = u_xlat4.xy + vec2(-0.5, -0.400000006);
					    u_xlat1.x = u_xlat4.z * 2.5;
					    u_xlat12 = u_xlat4.z * inf + 0.5;
					    u_xlat12 = clamp(u_xlat12, 0.0, 1.0);
					    u_xlat12 = u_xlat12 * 2.0 + -1.0;
					    u_xlat1.x = -abs(u_xlat1.x) + 1.0;
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = (-u_xlat1.x) * u_xlat1.x + 1.0;
					    u_xlat12 = u_xlat12 * u_xlat1.x + 1.0;
					    u_xlat12 = u_xlat12 * 0.0250000004;
					    u_xlat4.x = u_xlat4.x * u_xlat12;
					    u_xlatb1.x = u_xlat0.x>=0.479999989;
					    u_xlatb0.x = 0.159999996>=u_xlat0.x;
					    u_xlat4.x = (u_xlatb1.x) ? 0.0 : u_xlat4.x;
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat12 : u_xlat4.x;
					    u_xlat0.x = u_xlat0.x + 1.0;
					    u_xlat2.yzw = u_xlat0.xxx * u_xlat5.xyz;
					    u_xlat4.x = (-u_xlat5.x) * u_xlat0.x + 0.0299999993;
					    u_xlat12 = u_xlat5.y * u_xlat0.x + (-u_xlat2.w);
					    u_xlat12 = u_xlat12 * 1.73205078;
					    u_xlat1.x = u_xlat2.y * 2.0 + (-u_xlat2.z);
					    u_xlat0.x = (-u_xlat5.z) * u_xlat0.x + u_xlat1.x;
					    u_xlat1.x = max(abs(u_xlat0.x), abs(u_xlat12));
					    u_xlat1.x = float(1.0) / u_xlat1.x;
					    u_xlat5.x = min(abs(u_xlat0.x), abs(u_xlat12));
					    u_xlat1.x = u_xlat1.x * u_xlat5.x;
					    u_xlat5.x = u_xlat1.x * u_xlat1.x;
					    u_xlat9 = u_xlat5.x * 0.0208350997 + -0.0851330012;
					    u_xlat9 = u_xlat5.x * u_xlat9 + 0.180141002;
					    u_xlat9 = u_xlat5.x * u_xlat9 + -0.330299497;
					    u_xlat5.x = u_xlat5.x * u_xlat9 + 0.999866009;
					    u_xlat9 = u_xlat5.x * u_xlat1.x;
					    u_xlat9 = u_xlat9 * -2.0 + 1.57079637;
					    u_xlatb13 = abs(u_xlat0.x)<abs(u_xlat12);
					    u_xlat9 = u_xlatb13 ? u_xlat9 : float(0.0);
					    u_xlat1.x = u_xlat1.x * u_xlat5.x + u_xlat9;
					    u_xlatb5 = u_xlat0.x<(-u_xlat0.x);
					    u_xlat5.x = u_xlatb5 ? -3.14159274 : float(0.0);
					    u_xlat1.x = u_xlat5.x + u_xlat1.x;
					    u_xlat5.x = min(u_xlat0.x, u_xlat12);
					    u_xlat0.x = max(u_xlat0.x, u_xlat12);
					    u_xlatb0.x = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb12 = u_xlat5.x<(-u_xlat5.x);
					    u_xlatb0.x = u_xlatb0.x && u_xlatb12;
					    u_xlat0.x = (u_xlatb0.x) ? (-u_xlat1.x) : u_xlat1.x;
					    u_xlat0.x = u_xlat0.x * 57.2957802;
					    u_xlatb1.xy = equal(u_xlat2.zwzz, u_xlat2.yzyy).xy;
					    u_xlatb12 = u_xlatb1.y && u_xlatb1.x;
					    u_xlat0.x = (u_xlatb12) ? 0.0 : u_xlat0.x;
					    u_xlatb12 = u_xlat0.x<0.0;
					    u_xlat1.x = u_xlat0.x + 360.0;
					    u_xlat0.x = (u_xlatb12) ? u_xlat1.x : u_xlat0.x;
					    u_xlatb12 = 180.0<u_xlat0.x;
					    u_xlat1.xy = u_xlat0.xx + vec2(360.0, -360.0);
					    u_xlat12 = (u_xlatb12) ? u_xlat1.y : u_xlat0.x;
					    u_xlatb0.x = u_xlat0.x<-180.0;
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat12;
					    u_xlat0.x = u_xlat0.x * 0.0148148146;
					    u_xlat0.x = -abs(u_xlat0.x) + 1.0;
					    u_xlat0.x = max(u_xlat0.x, 0.0);
					    u_xlat12 = u_xlat0.x * -2.0 + 3.0;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat12;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat4.y * u_xlat0.x;
					    u_xlat0.x = u_xlat4.x * u_xlat0.x;
					    u_xlat2.x = u_xlat0.x * 0.180000007 + u_xlat2.y;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat2.xzw);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat2.xzw);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat2.xzw);
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.959999979, 0.959999979, 0.959999979) + vec3(u_xlat12);
					    u_xlat1.xyz = u_xlat0.xyz * vec3(278.508514, 278.508514, 278.508514) + vec3(10.7771997, 10.7771997, 10.7771997);
					    u_xlat1.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat2.xyz = u_xlat0.xyz * vec3(293.604492, 293.604492, 293.604492) + vec3(88.7121964, 88.7121964, 88.7121964);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat2.xyz + vec3(80.6889038, 80.6889038, 80.6889038);
					    u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat0.x = dot(u_xlat1.xyz, vec3(1.0, 1.0, 1.0));
					    u_xlat0.x = max(u_xlat0.x, 9.99999975e-05);
					    u_xlat0.xy = u_xlat1.xy / u_xlat0.xx;
					    u_xlat12 = max(u_xlat1.y, 0.0);
					    u_xlat12 = min(u_xlat12, 65504.0);
					    u_xlat12 = log2(u_xlat12);
					    u_xlat12 = u_xlat12 * 0.981100023;
					    u_xlat1.y = exp2(u_xlat12);
					    u_xlat12 = (-u_xlat0.x) + 1.0;
					    u_xlat0.z = (-u_xlat0.y) + u_xlat12;
					    u_xlat4.x = max(u_xlat0.y, 9.99999975e-05);
					    u_xlat4.x = u_xlat1.y / u_xlat4.x;
					    u_xlat1.xz = u_xlat4.xx * u_xlat0.xz;
					    u_xlat0.x = dot(vec3(1.6410234, -0.324803293, -0.236424699), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.663662851, 1.61533165, 0.0167563483), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.0117218941, -0.00828444213, 0.988394856), u_xlat1.xyz);
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.930000007, 0.930000007, 0.930000007) + vec3(u_xlat12);
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat0.x = dot(vec3(0.987223983, -0.00611326983, 0.0159533005), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.00759836007, 1.00186002, 0.00533019984), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.00307257008, -0.00509594986, 1.08168006), u_xlat1.xyz);
					    u_xlat1.x = dot(vec3(3.2409699, -1.5373832, -0.498610765), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.969243646, 1.8759675, 0.0415550582), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0556300804, -0.203976959, 1.05697155), u_xlat0.xyz);
					    SV_Target0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "TONEMAPPING_ACES" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					bvec3 u_xlatb0;
					vec4 u_xlat1;
					bvec4 u_xlatb1;
					vec4 u_xlat2;
					bvec2 u_xlatb2;
					vec3 u_xlat3;
					vec3 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					bool u_xlatb5;
					float u_xlat8;
					float u_xlat9;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.386036009, -0.386036009, -0.386036009);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.439700991, 0.382977992, 0.177334994), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.0897922963, 0.813422978, 0.0967615992), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0175439995, 0.111543998, 0.870703995), u_xlat0.xyz);
					    u_xlat0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = min(u_xlat0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5) + vec3(1.525878e-05, 1.525878e-05, 1.525878e-05);
					    u_xlat1.xyz = log2(u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat1.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat2.xyz = log2(u_xlat0.xyz);
					    u_xlatb0.xyz = lessThan(u_xlat0.xyzx, vec4(3.05175708e-05, 3.05175708e-05, 3.05175708e-05, 0.0)).xyz;
					    u_xlat2.xyz = u_xlat2.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat2.xyz = u_xlat2.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat2.x;
					    u_xlat0.y = (u_xlatb0.y) ? u_xlat1.y : u_xlat2.y;
					    u_xlat0.z = (u_xlatb0.z) ? u_xlat1.z : u_xlat2.z;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.413588405, 0.413588405, 0.413588405);
					    u_xlatb1 = lessThan(u_xlat0.xxyy, vec4(-0.301369876, 1.46799636, -0.301369876, 1.46799636));
					    u_xlat0.xyw = u_xlat0.xyz * vec3(17.5200005, 17.5200005, 17.5200005) + vec3(-9.72000027, -9.72000027, -9.72000027);
					    u_xlatb2.xy = lessThan(u_xlat0.zzzz, vec4(-0.301369876, 1.46799636, 0.0, 0.0)).xy;
					    u_xlat0.xyz = exp2(u_xlat0.xyw);
					    u_xlat5.x = (u_xlatb1.y) ? u_xlat0.x : float(65504.0);
					    u_xlat5.z = (u_xlatb1.w) ? u_xlat0.y : float(65504.0);
					    u_xlat0.xyw = u_xlat0.xyz + vec3(-1.52587891e-05, -1.52587891e-05, -1.52587891e-05);
					    u_xlat8 = (u_xlatb2.y) ? u_xlat0.z : 65504.0;
					    u_xlat0.xyw = u_xlat0.xyw + u_xlat0.xyw;
					    u_xlat1.x = (u_xlatb1.x) ? u_xlat0.x : u_xlat5.x;
					    u_xlat1.y = (u_xlatb1.z) ? u_xlat0.y : u_xlat5.z;
					    u_xlat1.z = (u_xlatb2.x) ? u_xlat0.w : u_xlat8;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat1.xyz);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.x = u_xlat4.x + -0.5;
					    u_xlat4.x = u_xlat4.x + u_xlat11.x;
					    u_xlatb12 = 1.0<u_xlat4.x;
					    u_xlat5.xy = u_xlat4.xx + vec2(1.0, -1.0);
					    u_xlat12 = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlatb4 = u_xlat4.x<0.0;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.x : u_xlat12;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat5.x = dot(vec3(0.695452213, 0.140678704, 0.163869068), u_xlat0.xyz);
					    u_xlat5.y = dot(vec3(0.0447945632, 0.859671116, 0.0955343172), u_xlat0.xyz);
					    u_xlat5.z = dot(vec3(-0.00552588282, 0.00402521016, 1.00150073), u_xlat0.xyz);
					    u_xlat0.xyz = (-u_xlat5.yxz) + u_xlat5.zyx;
					    u_xlat0.xy = u_xlat0.xy * u_xlat5.zy;
					    u_xlat0.x = u_xlat0.y + u_xlat0.x;
					    u_xlat0.x = u_xlat5.x * u_xlat0.z + u_xlat0.x;
					    u_xlat0.x = sqrt(u_xlat0.x);
					    u_xlat4.x = u_xlat5.y + u_xlat5.z;
					    u_xlat4.x = u_xlat5.x + u_xlat4.x;
					    u_xlat0.x = u_xlat0.x * 1.75 + u_xlat4.x;
					    u_xlat4.x = u_xlat0.x * 0.333333343;
					    u_xlat4.x = 0.0799999982 / u_xlat4.x;
					    u_xlat8 = min(u_xlat5.y, u_xlat5.x);
					    u_xlat8 = min(u_xlat5.z, u_xlat8);
					    u_xlat8 = max(u_xlat8, 9.99999975e-05);
					    u_xlat12 = max(u_xlat5.y, u_xlat5.x);
					    u_xlat12 = max(u_xlat5.z, u_xlat12);
					    u_xlat2.xy = max(vec2(u_xlat12), vec2(9.99999975e-05, 0.00999999978));
					    u_xlat8 = (-u_xlat8) + u_xlat2.x;
					    u_xlat4.y = u_xlat8 / u_xlat2.y;
					    u_xlat4.xz = u_xlat4.xy + vec2(-0.5, -0.400000006);
					    u_xlat1.x = u_xlat4.z * 2.5;
					    u_xlat12 = u_xlat4.z * inf + 0.5;
					    u_xlat12 = clamp(u_xlat12, 0.0, 1.0);
					    u_xlat12 = u_xlat12 * 2.0 + -1.0;
					    u_xlat1.x = -abs(u_xlat1.x) + 1.0;
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = (-u_xlat1.x) * u_xlat1.x + 1.0;
					    u_xlat12 = u_xlat12 * u_xlat1.x + 1.0;
					    u_xlat12 = u_xlat12 * 0.0250000004;
					    u_xlat4.x = u_xlat4.x * u_xlat12;
					    u_xlatb1.x = u_xlat0.x>=0.479999989;
					    u_xlatb0.x = 0.159999996>=u_xlat0.x;
					    u_xlat4.x = (u_xlatb1.x) ? 0.0 : u_xlat4.x;
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat12 : u_xlat4.x;
					    u_xlat0.x = u_xlat0.x + 1.0;
					    u_xlat2.yzw = u_xlat0.xxx * u_xlat5.xyz;
					    u_xlat4.x = (-u_xlat5.x) * u_xlat0.x + 0.0299999993;
					    u_xlat12 = u_xlat5.y * u_xlat0.x + (-u_xlat2.w);
					    u_xlat12 = u_xlat12 * 1.73205078;
					    u_xlat1.x = u_xlat2.y * 2.0 + (-u_xlat2.z);
					    u_xlat0.x = (-u_xlat5.z) * u_xlat0.x + u_xlat1.x;
					    u_xlat1.x = max(abs(u_xlat0.x), abs(u_xlat12));
					    u_xlat1.x = float(1.0) / u_xlat1.x;
					    u_xlat5.x = min(abs(u_xlat0.x), abs(u_xlat12));
					    u_xlat1.x = u_xlat1.x * u_xlat5.x;
					    u_xlat5.x = u_xlat1.x * u_xlat1.x;
					    u_xlat9 = u_xlat5.x * 0.0208350997 + -0.0851330012;
					    u_xlat9 = u_xlat5.x * u_xlat9 + 0.180141002;
					    u_xlat9 = u_xlat5.x * u_xlat9 + -0.330299497;
					    u_xlat5.x = u_xlat5.x * u_xlat9 + 0.999866009;
					    u_xlat9 = u_xlat5.x * u_xlat1.x;
					    u_xlat9 = u_xlat9 * -2.0 + 1.57079637;
					    u_xlatb13 = abs(u_xlat0.x)<abs(u_xlat12);
					    u_xlat9 = u_xlatb13 ? u_xlat9 : float(0.0);
					    u_xlat1.x = u_xlat1.x * u_xlat5.x + u_xlat9;
					    u_xlatb5 = u_xlat0.x<(-u_xlat0.x);
					    u_xlat5.x = u_xlatb5 ? -3.14159274 : float(0.0);
					    u_xlat1.x = u_xlat5.x + u_xlat1.x;
					    u_xlat5.x = min(u_xlat0.x, u_xlat12);
					    u_xlat0.x = max(u_xlat0.x, u_xlat12);
					    u_xlatb0.x = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb12 = u_xlat5.x<(-u_xlat5.x);
					    u_xlatb0.x = u_xlatb0.x && u_xlatb12;
					    u_xlat0.x = (u_xlatb0.x) ? (-u_xlat1.x) : u_xlat1.x;
					    u_xlat0.x = u_xlat0.x * 57.2957802;
					    u_xlatb1.xy = equal(u_xlat2.zwzz, u_xlat2.yzyy).xy;
					    u_xlatb12 = u_xlatb1.y && u_xlatb1.x;
					    u_xlat0.x = (u_xlatb12) ? 0.0 : u_xlat0.x;
					    u_xlatb12 = u_xlat0.x<0.0;
					    u_xlat1.x = u_xlat0.x + 360.0;
					    u_xlat0.x = (u_xlatb12) ? u_xlat1.x : u_xlat0.x;
					    u_xlatb12 = 180.0<u_xlat0.x;
					    u_xlat1.xy = u_xlat0.xx + vec2(360.0, -360.0);
					    u_xlat12 = (u_xlatb12) ? u_xlat1.y : u_xlat0.x;
					    u_xlatb0.x = u_xlat0.x<-180.0;
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat12;
					    u_xlat0.x = u_xlat0.x * 0.0148148146;
					    u_xlat0.x = -abs(u_xlat0.x) + 1.0;
					    u_xlat0.x = max(u_xlat0.x, 0.0);
					    u_xlat12 = u_xlat0.x * -2.0 + 3.0;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat12;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat4.y * u_xlat0.x;
					    u_xlat0.x = u_xlat4.x * u_xlat0.x;
					    u_xlat2.x = u_xlat0.x * 0.180000007 + u_xlat2.y;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat2.xzw);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat2.xzw);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat2.xzw);
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.959999979, 0.959999979, 0.959999979) + vec3(u_xlat12);
					    u_xlat1.xyz = u_xlat0.xyz * vec3(278.508514, 278.508514, 278.508514) + vec3(10.7771997, 10.7771997, 10.7771997);
					    u_xlat1.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat2.xyz = u_xlat0.xyz * vec3(293.604492, 293.604492, 293.604492) + vec3(88.7121964, 88.7121964, 88.7121964);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat2.xyz + vec3(80.6889038, 80.6889038, 80.6889038);
					    u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat0.x = dot(u_xlat1.xyz, vec3(1.0, 1.0, 1.0));
					    u_xlat0.x = max(u_xlat0.x, 9.99999975e-05);
					    u_xlat0.xy = u_xlat1.xy / u_xlat0.xx;
					    u_xlat12 = max(u_xlat1.y, 0.0);
					    u_xlat12 = min(u_xlat12, 65504.0);
					    u_xlat12 = log2(u_xlat12);
					    u_xlat12 = u_xlat12 * 0.981100023;
					    u_xlat1.y = exp2(u_xlat12);
					    u_xlat12 = (-u_xlat0.x) + 1.0;
					    u_xlat0.z = (-u_xlat0.y) + u_xlat12;
					    u_xlat4.x = max(u_xlat0.y, 9.99999975e-05);
					    u_xlat4.x = u_xlat1.y / u_xlat4.x;
					    u_xlat1.xz = u_xlat4.xx * u_xlat0.xz;
					    u_xlat0.x = dot(vec3(1.6410234, -0.324803293, -0.236424699), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.663662851, 1.61533165, 0.0167563483), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.0117218941, -0.00828444213, 0.988394856), u_xlat1.xyz);
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.930000007, 0.930000007, 0.930000007) + vec3(u_xlat12);
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat0.x = dot(vec3(0.987223983, -0.00611326983, 0.0159533005), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.00759836007, 1.00186002, 0.00533019984), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.00307257008, -0.00509594986, 1.08168006), u_xlat1.xyz);
					    u_xlat1.x = dot(vec3(3.2409699, -1.5373832, -0.498610765), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.969243646, 1.8759675, 0.0415550582), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0556300804, -0.203976959, 1.05697155), u_xlat0.xyz);
					    SV_Target0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "TONEMAPPING_ACES" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					bvec3 u_xlatb0;
					vec4 u_xlat1;
					bvec4 u_xlatb1;
					vec4 u_xlat2;
					bvec2 u_xlatb2;
					vec3 u_xlat3;
					vec3 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					bool u_xlatb5;
					float u_xlat8;
					float u_xlat9;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.386036009, -0.386036009, -0.386036009);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.439700991, 0.382977992, 0.177334994), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.0897922963, 0.813422978, 0.0967615992), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0175439995, 0.111543998, 0.870703995), u_xlat0.xyz);
					    u_xlat0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = min(u_xlat0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5) + vec3(1.525878e-05, 1.525878e-05, 1.525878e-05);
					    u_xlat1.xyz = log2(u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat1.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat2.xyz = log2(u_xlat0.xyz);
					    u_xlatb0.xyz = lessThan(u_xlat0.xyzx, vec4(3.05175708e-05, 3.05175708e-05, 3.05175708e-05, 0.0)).xyz;
					    u_xlat2.xyz = u_xlat2.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat2.xyz = u_xlat2.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat2.x;
					    u_xlat0.y = (u_xlatb0.y) ? u_xlat1.y : u_xlat2.y;
					    u_xlat0.z = (u_xlatb0.z) ? u_xlat1.z : u_xlat2.z;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.413588405, 0.413588405, 0.413588405);
					    u_xlatb1 = lessThan(u_xlat0.xxyy, vec4(-0.301369876, 1.46799636, -0.301369876, 1.46799636));
					    u_xlat0.xyw = u_xlat0.xyz * vec3(17.5200005, 17.5200005, 17.5200005) + vec3(-9.72000027, -9.72000027, -9.72000027);
					    u_xlatb2.xy = lessThan(u_xlat0.zzzz, vec4(-0.301369876, 1.46799636, 0.0, 0.0)).xy;
					    u_xlat0.xyz = exp2(u_xlat0.xyw);
					    u_xlat5.x = (u_xlatb1.y) ? u_xlat0.x : float(65504.0);
					    u_xlat5.z = (u_xlatb1.w) ? u_xlat0.y : float(65504.0);
					    u_xlat0.xyw = u_xlat0.xyz + vec3(-1.52587891e-05, -1.52587891e-05, -1.52587891e-05);
					    u_xlat8 = (u_xlatb2.y) ? u_xlat0.z : 65504.0;
					    u_xlat0.xyw = u_xlat0.xyw + u_xlat0.xyw;
					    u_xlat1.x = (u_xlatb1.x) ? u_xlat0.x : u_xlat5.x;
					    u_xlat1.y = (u_xlatb1.z) ? u_xlat0.y : u_xlat5.z;
					    u_xlat1.z = (u_xlatb2.x) ? u_xlat0.w : u_xlat8;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat1.xyz);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.x = u_xlat4.x + -0.5;
					    u_xlat4.x = u_xlat4.x + u_xlat11.x;
					    u_xlatb12 = 1.0<u_xlat4.x;
					    u_xlat5.xy = u_xlat4.xx + vec2(1.0, -1.0);
					    u_xlat12 = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlatb4 = u_xlat4.x<0.0;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.x : u_xlat12;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat5.x = dot(vec3(0.695452213, 0.140678704, 0.163869068), u_xlat0.xyz);
					    u_xlat5.y = dot(vec3(0.0447945632, 0.859671116, 0.0955343172), u_xlat0.xyz);
					    u_xlat5.z = dot(vec3(-0.00552588282, 0.00402521016, 1.00150073), u_xlat0.xyz);
					    u_xlat0.xyz = (-u_xlat5.yxz) + u_xlat5.zyx;
					    u_xlat0.xy = u_xlat0.xy * u_xlat5.zy;
					    u_xlat0.x = u_xlat0.y + u_xlat0.x;
					    u_xlat0.x = u_xlat5.x * u_xlat0.z + u_xlat0.x;
					    u_xlat0.x = sqrt(u_xlat0.x);
					    u_xlat4.x = u_xlat5.y + u_xlat5.z;
					    u_xlat4.x = u_xlat5.x + u_xlat4.x;
					    u_xlat0.x = u_xlat0.x * 1.75 + u_xlat4.x;
					    u_xlat4.x = u_xlat0.x * 0.333333343;
					    u_xlat4.x = 0.0799999982 / u_xlat4.x;
					    u_xlat8 = min(u_xlat5.y, u_xlat5.x);
					    u_xlat8 = min(u_xlat5.z, u_xlat8);
					    u_xlat8 = max(u_xlat8, 9.99999975e-05);
					    u_xlat12 = max(u_xlat5.y, u_xlat5.x);
					    u_xlat12 = max(u_xlat5.z, u_xlat12);
					    u_xlat2.xy = max(vec2(u_xlat12), vec2(9.99999975e-05, 0.00999999978));
					    u_xlat8 = (-u_xlat8) + u_xlat2.x;
					    u_xlat4.y = u_xlat8 / u_xlat2.y;
					    u_xlat4.xz = u_xlat4.xy + vec2(-0.5, -0.400000006);
					    u_xlat1.x = u_xlat4.z * 2.5;
					    u_xlat12 = u_xlat4.z * inf + 0.5;
					    u_xlat12 = clamp(u_xlat12, 0.0, 1.0);
					    u_xlat12 = u_xlat12 * 2.0 + -1.0;
					    u_xlat1.x = -abs(u_xlat1.x) + 1.0;
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = (-u_xlat1.x) * u_xlat1.x + 1.0;
					    u_xlat12 = u_xlat12 * u_xlat1.x + 1.0;
					    u_xlat12 = u_xlat12 * 0.0250000004;
					    u_xlat4.x = u_xlat4.x * u_xlat12;
					    u_xlatb1.x = u_xlat0.x>=0.479999989;
					    u_xlatb0.x = 0.159999996>=u_xlat0.x;
					    u_xlat4.x = (u_xlatb1.x) ? 0.0 : u_xlat4.x;
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat12 : u_xlat4.x;
					    u_xlat0.x = u_xlat0.x + 1.0;
					    u_xlat2.yzw = u_xlat0.xxx * u_xlat5.xyz;
					    u_xlat4.x = (-u_xlat5.x) * u_xlat0.x + 0.0299999993;
					    u_xlat12 = u_xlat5.y * u_xlat0.x + (-u_xlat2.w);
					    u_xlat12 = u_xlat12 * 1.73205078;
					    u_xlat1.x = u_xlat2.y * 2.0 + (-u_xlat2.z);
					    u_xlat0.x = (-u_xlat5.z) * u_xlat0.x + u_xlat1.x;
					    u_xlat1.x = max(abs(u_xlat0.x), abs(u_xlat12));
					    u_xlat1.x = float(1.0) / u_xlat1.x;
					    u_xlat5.x = min(abs(u_xlat0.x), abs(u_xlat12));
					    u_xlat1.x = u_xlat1.x * u_xlat5.x;
					    u_xlat5.x = u_xlat1.x * u_xlat1.x;
					    u_xlat9 = u_xlat5.x * 0.0208350997 + -0.0851330012;
					    u_xlat9 = u_xlat5.x * u_xlat9 + 0.180141002;
					    u_xlat9 = u_xlat5.x * u_xlat9 + -0.330299497;
					    u_xlat5.x = u_xlat5.x * u_xlat9 + 0.999866009;
					    u_xlat9 = u_xlat5.x * u_xlat1.x;
					    u_xlat9 = u_xlat9 * -2.0 + 1.57079637;
					    u_xlatb13 = abs(u_xlat0.x)<abs(u_xlat12);
					    u_xlat9 = u_xlatb13 ? u_xlat9 : float(0.0);
					    u_xlat1.x = u_xlat1.x * u_xlat5.x + u_xlat9;
					    u_xlatb5 = u_xlat0.x<(-u_xlat0.x);
					    u_xlat5.x = u_xlatb5 ? -3.14159274 : float(0.0);
					    u_xlat1.x = u_xlat5.x + u_xlat1.x;
					    u_xlat5.x = min(u_xlat0.x, u_xlat12);
					    u_xlat0.x = max(u_xlat0.x, u_xlat12);
					    u_xlatb0.x = u_xlat0.x>=(-u_xlat0.x);
					    u_xlatb12 = u_xlat5.x<(-u_xlat5.x);
					    u_xlatb0.x = u_xlatb0.x && u_xlatb12;
					    u_xlat0.x = (u_xlatb0.x) ? (-u_xlat1.x) : u_xlat1.x;
					    u_xlat0.x = u_xlat0.x * 57.2957802;
					    u_xlatb1.xy = equal(u_xlat2.zwzz, u_xlat2.yzyy).xy;
					    u_xlatb12 = u_xlatb1.y && u_xlatb1.x;
					    u_xlat0.x = (u_xlatb12) ? 0.0 : u_xlat0.x;
					    u_xlatb12 = u_xlat0.x<0.0;
					    u_xlat1.x = u_xlat0.x + 360.0;
					    u_xlat0.x = (u_xlatb12) ? u_xlat1.x : u_xlat0.x;
					    u_xlatb12 = 180.0<u_xlat0.x;
					    u_xlat1.xy = u_xlat0.xx + vec2(360.0, -360.0);
					    u_xlat12 = (u_xlatb12) ? u_xlat1.y : u_xlat0.x;
					    u_xlatb0.x = u_xlat0.x<-180.0;
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat12;
					    u_xlat0.x = u_xlat0.x * 0.0148148146;
					    u_xlat0.x = -abs(u_xlat0.x) + 1.0;
					    u_xlat0.x = max(u_xlat0.x, 0.0);
					    u_xlat12 = u_xlat0.x * -2.0 + 3.0;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat12;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat4.y * u_xlat0.x;
					    u_xlat0.x = u_xlat4.x * u_xlat0.x;
					    u_xlat2.x = u_xlat0.x * 0.180000007 + u_xlat2.y;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat2.xzw);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat2.xzw);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat2.xzw);
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.959999979, 0.959999979, 0.959999979) + vec3(u_xlat12);
					    u_xlat1.xyz = u_xlat0.xyz * vec3(278.508514, 278.508514, 278.508514) + vec3(10.7771997, 10.7771997, 10.7771997);
					    u_xlat1.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat2.xyz = u_xlat0.xyz * vec3(293.604492, 293.604492, 293.604492) + vec3(88.7121964, 88.7121964, 88.7121964);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat2.xyz + vec3(80.6889038, 80.6889038, 80.6889038);
					    u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat0.x = dot(u_xlat1.xyz, vec3(1.0, 1.0, 1.0));
					    u_xlat0.x = max(u_xlat0.x, 9.99999975e-05);
					    u_xlat0.xy = u_xlat1.xy / u_xlat0.xx;
					    u_xlat12 = max(u_xlat1.y, 0.0);
					    u_xlat12 = min(u_xlat12, 65504.0);
					    u_xlat12 = log2(u_xlat12);
					    u_xlat12 = u_xlat12 * 0.981100023;
					    u_xlat1.y = exp2(u_xlat12);
					    u_xlat12 = (-u_xlat0.x) + 1.0;
					    u_xlat0.z = (-u_xlat0.y) + u_xlat12;
					    u_xlat4.x = max(u_xlat0.y, 9.99999975e-05);
					    u_xlat4.x = u_xlat1.y / u_xlat4.x;
					    u_xlat1.xz = u_xlat4.xx * u_xlat0.xz;
					    u_xlat0.x = dot(vec3(1.6410234, -0.324803293, -0.236424699), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.663662851, 1.61533165, 0.0167563483), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.0117218941, -0.00828444213, 0.988394856), u_xlat1.xyz);
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.930000007, 0.930000007, 0.930000007) + vec3(u_xlat12);
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat0.x = dot(vec3(0.987223983, -0.00611326983, 0.0159533005), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.00759836007, 1.00186002, 0.00533019984), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.00307257008, -0.00509594986, 1.08168006), u_xlat1.xyz);
					    u_xlat1.x = dot(vec3(3.2409699, -1.5373832, -0.498610765), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.969243646, 1.8759675, 0.0415550582), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0556300804, -0.203976959, 1.05697155), u_xlat0.xyz);
					    SV_Target0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "TONEMAPPING_ACES" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					bvec3 u_xlatb0;
					vec4 u_xlat1;
					bvec4 u_xlatb1;
					vec4 u_xlat2;
					bvec2 u_xlatb2;
					vec3 u_xlat3;
					vec3 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					bool u_xlatb5;
					float u_xlat8;
					float u_xlat9;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.386036009, -0.386036009, -0.386036009);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.439700991, 0.382977992, 0.177334994), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.0897922963, 0.813422978, 0.0967615992), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0175439995, 0.111543998, 0.870703995), u_xlat0.xyz);
					    u_xlat0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = min(u_xlat0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5) + vec3(1.525878e-05, 1.525878e-05, 1.525878e-05);
					    u_xlat1.xyz = log2(u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat1.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat2.xyz = log2(u_xlat0.xyz);
					    u_xlatb0.xyz = lessThan(u_xlat0.xyzx, vec4(3.05175708e-05, 3.05175708e-05, 3.05175708e-05, 0.0)).xyz;
					    u_xlat2.xyz = u_xlat2.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat2.xyz = u_xlat2.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat2.x;
					    u_xlat0.y = (u_xlatb0.y) ? u_xlat1.y : u_xlat2.y;
					    u_xlat0.z = (u_xlatb0.z) ? u_xlat1.z : u_xlat2.z;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.413588405, 0.413588405, 0.413588405);
					    u_xlatb1 = lessThan(u_xlat0.xxyy, vec4(-0.301369876, 1.46799636, -0.301369876, 1.46799636));
					    u_xlat0.xyw = u_xlat0.xyz * vec3(17.5200005, 17.5200005, 17.5200005) + vec3(-9.72000027, -9.72000027, -9.72000027);
					    u_xlatb2.xy = lessThan(u_xlat0.zzzz, vec4(-0.301369876, 1.46799636, 0.0, 0.0)).xy;
					    u_xlat0.xyz = exp2(u_xlat0.xyw);
					    u_xlat5.x = (u_xlatb1.y) ? u_xlat0.x : float(65504.0);
					    u_xlat5.z = (u_xlatb1.w) ? u_xlat0.y : float(65504.0);
					    u_xlat0.xyw = u_xlat0.xyz + vec3(-1.52587891e-05, -1.52587891e-05, -1.52587891e-05);
					    u_xlat8 = (u_xlatb2.y) ? u_xlat0.z : 65504.0;
					    u_xlat0.xyw = u_xlat0.xyw + u_xlat0.xyw;
					    u_xlat1.x = (u_xlatb1.x) ? u_xlat0.x : u_xlat5.x;
					    u_xlat1.y = (u_xlatb1.z) ? u_xlat0.y : u_xlat5.z;
					    u_xlat1.z = (u_xlatb2.x) ? u_xlat0.w : u_xlat8;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat1.xyz);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = textureLod(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.x = u_xlat4.x + -0.5;
					    u_xlat4.x = u_xlat4.x + u_xlat11.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(1.0<u_xlat4.x);
					#else
					    u_xlatb12 = 1.0<u_xlat4.x;
					#endif
					    u_xlat5.xy = u_xlat4.xx + vec2(1.0, -1.0);
					    u_xlat12 = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4.x<0.0);
					#else
					    u_xlatb4 = u_xlat4.x<0.0;
					#endif
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.x : u_xlat12;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat5.x = dot(vec3(0.695452213, 0.140678704, 0.163869068), u_xlat0.xyz);
					    u_xlat5.y = dot(vec3(0.0447945632, 0.859671116, 0.0955343172), u_xlat0.xyz);
					    u_xlat5.z = dot(vec3(-0.00552588282, 0.00402521016, 1.00150073), u_xlat0.xyz);
					    u_xlat0.xyz = (-u_xlat5.yxz) + u_xlat5.zyx;
					    u_xlat0.xy = u_xlat0.xy * u_xlat5.zy;
					    u_xlat0.x = u_xlat0.y + u_xlat0.x;
					    u_xlat0.x = u_xlat5.x * u_xlat0.z + u_xlat0.x;
					    u_xlat0.x = sqrt(u_xlat0.x);
					    u_xlat4.x = u_xlat5.y + u_xlat5.z;
					    u_xlat4.x = u_xlat5.x + u_xlat4.x;
					    u_xlat0.x = u_xlat0.x * 1.75 + u_xlat4.x;
					    u_xlat4.x = u_xlat0.x * 0.333333343;
					    u_xlat4.x = 0.0799999982 / u_xlat4.x;
					    u_xlat8 = min(u_xlat5.y, u_xlat5.x);
					    u_xlat8 = min(u_xlat5.z, u_xlat8);
					    u_xlat8 = max(u_xlat8, 9.99999975e-05);
					    u_xlat12 = max(u_xlat5.y, u_xlat5.x);
					    u_xlat12 = max(u_xlat5.z, u_xlat12);
					    u_xlat2.xy = max(vec2(u_xlat12), vec2(9.99999975e-05, 0.00999999978));
					    u_xlat8 = (-u_xlat8) + u_xlat2.x;
					    u_xlat4.y = u_xlat8 / u_xlat2.y;
					    u_xlat4.xz = u_xlat4.xy + vec2(-0.5, -0.400000006);
					    u_xlat1.x = u_xlat4.z * 2.5;
					    u_xlat12 = u_xlat4.z * intBitsToFloat(int(0x7F800000u)) + 0.5;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat12 = min(max(u_xlat12, 0.0), 1.0);
					#else
					    u_xlat12 = clamp(u_xlat12, 0.0, 1.0);
					#endif
					    u_xlat12 = u_xlat12 * 2.0 + -1.0;
					    u_xlat1.x = -abs(u_xlat1.x) + 1.0;
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = (-u_xlat1.x) * u_xlat1.x + 1.0;
					    u_xlat12 = u_xlat12 * u_xlat1.x + 1.0;
					    u_xlat12 = u_xlat12 * 0.0250000004;
					    u_xlat4.x = u_xlat4.x * u_xlat12;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1.x = !!(u_xlat0.x>=0.479999989);
					#else
					    u_xlatb1.x = u_xlat0.x>=0.479999989;
					#endif
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(0.159999996>=u_xlat0.x);
					#else
					    u_xlatb0.x = 0.159999996>=u_xlat0.x;
					#endif
					    u_xlat4.x = (u_xlatb1.x) ? 0.0 : u_xlat4.x;
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat12 : u_xlat4.x;
					    u_xlat0.x = u_xlat0.x + 1.0;
					    u_xlat2.yzw = u_xlat0.xxx * u_xlat5.xyz;
					    u_xlat4.x = (-u_xlat5.x) * u_xlat0.x + 0.0299999993;
					    u_xlat12 = u_xlat5.y * u_xlat0.x + (-u_xlat2.w);
					    u_xlat12 = u_xlat12 * 1.73205078;
					    u_xlat1.x = u_xlat2.y * 2.0 + (-u_xlat2.z);
					    u_xlat0.x = (-u_xlat5.z) * u_xlat0.x + u_xlat1.x;
					    u_xlat1.x = max(abs(u_xlat0.x), abs(u_xlat12));
					    u_xlat1.x = float(1.0) / u_xlat1.x;
					    u_xlat5.x = min(abs(u_xlat0.x), abs(u_xlat12));
					    u_xlat1.x = u_xlat1.x * u_xlat5.x;
					    u_xlat5.x = u_xlat1.x * u_xlat1.x;
					    u_xlat9 = u_xlat5.x * 0.0208350997 + -0.0851330012;
					    u_xlat9 = u_xlat5.x * u_xlat9 + 0.180141002;
					    u_xlat9 = u_xlat5.x * u_xlat9 + -0.330299497;
					    u_xlat5.x = u_xlat5.x * u_xlat9 + 0.999866009;
					    u_xlat9 = u_xlat5.x * u_xlat1.x;
					    u_xlat9 = u_xlat9 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb13 = !!(abs(u_xlat0.x)<abs(u_xlat12));
					#else
					    u_xlatb13 = abs(u_xlat0.x)<abs(u_xlat12);
					#endif
					    u_xlat9 = u_xlatb13 ? u_xlat9 : float(0.0);
					    u_xlat1.x = u_xlat1.x * u_xlat5.x + u_xlat9;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb5 = !!(u_xlat0.x<(-u_xlat0.x));
					#else
					    u_xlatb5 = u_xlat0.x<(-u_xlat0.x);
					#endif
					    u_xlat5.x = u_xlatb5 ? -3.14159274 : float(0.0);
					    u_xlat1.x = u_xlat5.x + u_xlat1.x;
					    u_xlat5.x = min(u_xlat0.x, u_xlat12);
					    u_xlat0.x = max(u_xlat0.x, u_xlat12);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0.x = u_xlat0.x>=(-u_xlat0.x);
					#endif
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat5.x<(-u_xlat5.x));
					#else
					    u_xlatb12 = u_xlat5.x<(-u_xlat5.x);
					#endif
					    u_xlatb0.x = u_xlatb0.x && u_xlatb12;
					    u_xlat0.x = (u_xlatb0.x) ? (-u_xlat1.x) : u_xlat1.x;
					    u_xlat0.x = u_xlat0.x * 57.2957802;
					    u_xlatb1.xy = equal(u_xlat2.zwzz, u_xlat2.yzyy).xy;
					    u_xlatb12 = u_xlatb1.y && u_xlatb1.x;
					    u_xlat0.x = (u_xlatb12) ? 0.0 : u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x<0.0);
					#else
					    u_xlatb12 = u_xlat0.x<0.0;
					#endif
					    u_xlat1.x = u_xlat0.x + 360.0;
					    u_xlat0.x = (u_xlatb12) ? u_xlat1.x : u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(180.0<u_xlat0.x);
					#else
					    u_xlatb12 = 180.0<u_xlat0.x;
					#endif
					    u_xlat1.xy = u_xlat0.xx + vec2(360.0, -360.0);
					    u_xlat12 = (u_xlatb12) ? u_xlat1.y : u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(u_xlat0.x<-180.0);
					#else
					    u_xlatb0.x = u_xlat0.x<-180.0;
					#endif
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat12;
					    u_xlat0.x = u_xlat0.x * 0.0148148146;
					    u_xlat0.x = -abs(u_xlat0.x) + 1.0;
					    u_xlat0.x = max(u_xlat0.x, 0.0);
					    u_xlat12 = u_xlat0.x * -2.0 + 3.0;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat12;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat4.y * u_xlat0.x;
					    u_xlat0.x = u_xlat4.x * u_xlat0.x;
					    u_xlat2.x = u_xlat0.x * 0.180000007 + u_xlat2.y;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat2.xzw);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat2.xzw);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat2.xzw);
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.959999979, 0.959999979, 0.959999979) + vec3(u_xlat12);
					    u_xlat1.xyz = u_xlat0.xyz * vec3(278.508514, 278.508514, 278.508514) + vec3(10.7771997, 10.7771997, 10.7771997);
					    u_xlat1.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat2.xyz = u_xlat0.xyz * vec3(293.604492, 293.604492, 293.604492) + vec3(88.7121964, 88.7121964, 88.7121964);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat2.xyz + vec3(80.6889038, 80.6889038, 80.6889038);
					    u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat0.x = dot(u_xlat1.xyz, vec3(1.0, 1.0, 1.0));
					    u_xlat0.x = max(u_xlat0.x, 9.99999975e-05);
					    u_xlat0.xy = u_xlat1.xy / u_xlat0.xx;
					    u_xlat12 = max(u_xlat1.y, 0.0);
					    u_xlat12 = min(u_xlat12, 65504.0);
					    u_xlat12 = log2(u_xlat12);
					    u_xlat12 = u_xlat12 * 0.981100023;
					    u_xlat1.y = exp2(u_xlat12);
					    u_xlat12 = (-u_xlat0.x) + 1.0;
					    u_xlat0.z = (-u_xlat0.y) + u_xlat12;
					    u_xlat4.x = max(u_xlat0.y, 9.99999975e-05);
					    u_xlat4.x = u_xlat1.y / u_xlat4.x;
					    u_xlat1.xz = u_xlat4.xx * u_xlat0.xz;
					    u_xlat0.x = dot(vec3(1.6410234, -0.324803293, -0.236424699), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.663662851, 1.61533165, 0.0167563483), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.0117218941, -0.00828444213, 0.988394856), u_xlat1.xyz);
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.930000007, 0.930000007, 0.930000007) + vec3(u_xlat12);
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat0.x = dot(vec3(0.987223983, -0.00611326983, 0.0159533005), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.00759836007, 1.00186002, 0.00533019984), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.00307257008, -0.00509594986, 1.08168006), u_xlat1.xyz);
					    u_xlat1.x = dot(vec3(3.2409699, -1.5373832, -0.498610765), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.969243646, 1.8759675, 0.0415550582), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0556300804, -0.203976959, 1.05697155), u_xlat0.xyz);
					    SV_Target0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "TONEMAPPING_ACES" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					bvec3 u_xlatb0;
					vec4 u_xlat1;
					bvec4 u_xlatb1;
					vec4 u_xlat2;
					bvec2 u_xlatb2;
					vec3 u_xlat3;
					vec3 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					bool u_xlatb5;
					float u_xlat8;
					float u_xlat9;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.386036009, -0.386036009, -0.386036009);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.439700991, 0.382977992, 0.177334994), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.0897922963, 0.813422978, 0.0967615992), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0175439995, 0.111543998, 0.870703995), u_xlat0.xyz);
					    u_xlat0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = min(u_xlat0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5) + vec3(1.525878e-05, 1.525878e-05, 1.525878e-05);
					    u_xlat1.xyz = log2(u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat1.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat2.xyz = log2(u_xlat0.xyz);
					    u_xlatb0.xyz = lessThan(u_xlat0.xyzx, vec4(3.05175708e-05, 3.05175708e-05, 3.05175708e-05, 0.0)).xyz;
					    u_xlat2.xyz = u_xlat2.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat2.xyz = u_xlat2.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat2.x;
					    u_xlat0.y = (u_xlatb0.y) ? u_xlat1.y : u_xlat2.y;
					    u_xlat0.z = (u_xlatb0.z) ? u_xlat1.z : u_xlat2.z;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.413588405, 0.413588405, 0.413588405);
					    u_xlatb1 = lessThan(u_xlat0.xxyy, vec4(-0.301369876, 1.46799636, -0.301369876, 1.46799636));
					    u_xlat0.xyw = u_xlat0.xyz * vec3(17.5200005, 17.5200005, 17.5200005) + vec3(-9.72000027, -9.72000027, -9.72000027);
					    u_xlatb2.xy = lessThan(u_xlat0.zzzz, vec4(-0.301369876, 1.46799636, 0.0, 0.0)).xy;
					    u_xlat0.xyz = exp2(u_xlat0.xyw);
					    u_xlat5.x = (u_xlatb1.y) ? u_xlat0.x : float(65504.0);
					    u_xlat5.z = (u_xlatb1.w) ? u_xlat0.y : float(65504.0);
					    u_xlat0.xyw = u_xlat0.xyz + vec3(-1.52587891e-05, -1.52587891e-05, -1.52587891e-05);
					    u_xlat8 = (u_xlatb2.y) ? u_xlat0.z : 65504.0;
					    u_xlat0.xyw = u_xlat0.xyw + u_xlat0.xyw;
					    u_xlat1.x = (u_xlatb1.x) ? u_xlat0.x : u_xlat5.x;
					    u_xlat1.y = (u_xlatb1.z) ? u_xlat0.y : u_xlat5.z;
					    u_xlat1.z = (u_xlatb2.x) ? u_xlat0.w : u_xlat8;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat1.xyz);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = textureLod(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.x = u_xlat4.x + -0.5;
					    u_xlat4.x = u_xlat4.x + u_xlat11.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(1.0<u_xlat4.x);
					#else
					    u_xlatb12 = 1.0<u_xlat4.x;
					#endif
					    u_xlat5.xy = u_xlat4.xx + vec2(1.0, -1.0);
					    u_xlat12 = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4.x<0.0);
					#else
					    u_xlatb4 = u_xlat4.x<0.0;
					#endif
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.x : u_xlat12;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat5.x = dot(vec3(0.695452213, 0.140678704, 0.163869068), u_xlat0.xyz);
					    u_xlat5.y = dot(vec3(0.0447945632, 0.859671116, 0.0955343172), u_xlat0.xyz);
					    u_xlat5.z = dot(vec3(-0.00552588282, 0.00402521016, 1.00150073), u_xlat0.xyz);
					    u_xlat0.xyz = (-u_xlat5.yxz) + u_xlat5.zyx;
					    u_xlat0.xy = u_xlat0.xy * u_xlat5.zy;
					    u_xlat0.x = u_xlat0.y + u_xlat0.x;
					    u_xlat0.x = u_xlat5.x * u_xlat0.z + u_xlat0.x;
					    u_xlat0.x = sqrt(u_xlat0.x);
					    u_xlat4.x = u_xlat5.y + u_xlat5.z;
					    u_xlat4.x = u_xlat5.x + u_xlat4.x;
					    u_xlat0.x = u_xlat0.x * 1.75 + u_xlat4.x;
					    u_xlat4.x = u_xlat0.x * 0.333333343;
					    u_xlat4.x = 0.0799999982 / u_xlat4.x;
					    u_xlat8 = min(u_xlat5.y, u_xlat5.x);
					    u_xlat8 = min(u_xlat5.z, u_xlat8);
					    u_xlat8 = max(u_xlat8, 9.99999975e-05);
					    u_xlat12 = max(u_xlat5.y, u_xlat5.x);
					    u_xlat12 = max(u_xlat5.z, u_xlat12);
					    u_xlat2.xy = max(vec2(u_xlat12), vec2(9.99999975e-05, 0.00999999978));
					    u_xlat8 = (-u_xlat8) + u_xlat2.x;
					    u_xlat4.y = u_xlat8 / u_xlat2.y;
					    u_xlat4.xz = u_xlat4.xy + vec2(-0.5, -0.400000006);
					    u_xlat1.x = u_xlat4.z * 2.5;
					    u_xlat12 = u_xlat4.z * intBitsToFloat(int(0x7F800000u)) + 0.5;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat12 = min(max(u_xlat12, 0.0), 1.0);
					#else
					    u_xlat12 = clamp(u_xlat12, 0.0, 1.0);
					#endif
					    u_xlat12 = u_xlat12 * 2.0 + -1.0;
					    u_xlat1.x = -abs(u_xlat1.x) + 1.0;
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = (-u_xlat1.x) * u_xlat1.x + 1.0;
					    u_xlat12 = u_xlat12 * u_xlat1.x + 1.0;
					    u_xlat12 = u_xlat12 * 0.0250000004;
					    u_xlat4.x = u_xlat4.x * u_xlat12;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1.x = !!(u_xlat0.x>=0.479999989);
					#else
					    u_xlatb1.x = u_xlat0.x>=0.479999989;
					#endif
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(0.159999996>=u_xlat0.x);
					#else
					    u_xlatb0.x = 0.159999996>=u_xlat0.x;
					#endif
					    u_xlat4.x = (u_xlatb1.x) ? 0.0 : u_xlat4.x;
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat12 : u_xlat4.x;
					    u_xlat0.x = u_xlat0.x + 1.0;
					    u_xlat2.yzw = u_xlat0.xxx * u_xlat5.xyz;
					    u_xlat4.x = (-u_xlat5.x) * u_xlat0.x + 0.0299999993;
					    u_xlat12 = u_xlat5.y * u_xlat0.x + (-u_xlat2.w);
					    u_xlat12 = u_xlat12 * 1.73205078;
					    u_xlat1.x = u_xlat2.y * 2.0 + (-u_xlat2.z);
					    u_xlat0.x = (-u_xlat5.z) * u_xlat0.x + u_xlat1.x;
					    u_xlat1.x = max(abs(u_xlat0.x), abs(u_xlat12));
					    u_xlat1.x = float(1.0) / u_xlat1.x;
					    u_xlat5.x = min(abs(u_xlat0.x), abs(u_xlat12));
					    u_xlat1.x = u_xlat1.x * u_xlat5.x;
					    u_xlat5.x = u_xlat1.x * u_xlat1.x;
					    u_xlat9 = u_xlat5.x * 0.0208350997 + -0.0851330012;
					    u_xlat9 = u_xlat5.x * u_xlat9 + 0.180141002;
					    u_xlat9 = u_xlat5.x * u_xlat9 + -0.330299497;
					    u_xlat5.x = u_xlat5.x * u_xlat9 + 0.999866009;
					    u_xlat9 = u_xlat5.x * u_xlat1.x;
					    u_xlat9 = u_xlat9 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb13 = !!(abs(u_xlat0.x)<abs(u_xlat12));
					#else
					    u_xlatb13 = abs(u_xlat0.x)<abs(u_xlat12);
					#endif
					    u_xlat9 = u_xlatb13 ? u_xlat9 : float(0.0);
					    u_xlat1.x = u_xlat1.x * u_xlat5.x + u_xlat9;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb5 = !!(u_xlat0.x<(-u_xlat0.x));
					#else
					    u_xlatb5 = u_xlat0.x<(-u_xlat0.x);
					#endif
					    u_xlat5.x = u_xlatb5 ? -3.14159274 : float(0.0);
					    u_xlat1.x = u_xlat5.x + u_xlat1.x;
					    u_xlat5.x = min(u_xlat0.x, u_xlat12);
					    u_xlat0.x = max(u_xlat0.x, u_xlat12);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0.x = u_xlat0.x>=(-u_xlat0.x);
					#endif
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat5.x<(-u_xlat5.x));
					#else
					    u_xlatb12 = u_xlat5.x<(-u_xlat5.x);
					#endif
					    u_xlatb0.x = u_xlatb0.x && u_xlatb12;
					    u_xlat0.x = (u_xlatb0.x) ? (-u_xlat1.x) : u_xlat1.x;
					    u_xlat0.x = u_xlat0.x * 57.2957802;
					    u_xlatb1.xy = equal(u_xlat2.zwzz, u_xlat2.yzyy).xy;
					    u_xlatb12 = u_xlatb1.y && u_xlatb1.x;
					    u_xlat0.x = (u_xlatb12) ? 0.0 : u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x<0.0);
					#else
					    u_xlatb12 = u_xlat0.x<0.0;
					#endif
					    u_xlat1.x = u_xlat0.x + 360.0;
					    u_xlat0.x = (u_xlatb12) ? u_xlat1.x : u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(180.0<u_xlat0.x);
					#else
					    u_xlatb12 = 180.0<u_xlat0.x;
					#endif
					    u_xlat1.xy = u_xlat0.xx + vec2(360.0, -360.0);
					    u_xlat12 = (u_xlatb12) ? u_xlat1.y : u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(u_xlat0.x<-180.0);
					#else
					    u_xlatb0.x = u_xlat0.x<-180.0;
					#endif
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat12;
					    u_xlat0.x = u_xlat0.x * 0.0148148146;
					    u_xlat0.x = -abs(u_xlat0.x) + 1.0;
					    u_xlat0.x = max(u_xlat0.x, 0.0);
					    u_xlat12 = u_xlat0.x * -2.0 + 3.0;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat12;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat4.y * u_xlat0.x;
					    u_xlat0.x = u_xlat4.x * u_xlat0.x;
					    u_xlat2.x = u_xlat0.x * 0.180000007 + u_xlat2.y;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat2.xzw);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat2.xzw);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat2.xzw);
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.959999979, 0.959999979, 0.959999979) + vec3(u_xlat12);
					    u_xlat1.xyz = u_xlat0.xyz * vec3(278.508514, 278.508514, 278.508514) + vec3(10.7771997, 10.7771997, 10.7771997);
					    u_xlat1.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat2.xyz = u_xlat0.xyz * vec3(293.604492, 293.604492, 293.604492) + vec3(88.7121964, 88.7121964, 88.7121964);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat2.xyz + vec3(80.6889038, 80.6889038, 80.6889038);
					    u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat0.x = dot(u_xlat1.xyz, vec3(1.0, 1.0, 1.0));
					    u_xlat0.x = max(u_xlat0.x, 9.99999975e-05);
					    u_xlat0.xy = u_xlat1.xy / u_xlat0.xx;
					    u_xlat12 = max(u_xlat1.y, 0.0);
					    u_xlat12 = min(u_xlat12, 65504.0);
					    u_xlat12 = log2(u_xlat12);
					    u_xlat12 = u_xlat12 * 0.981100023;
					    u_xlat1.y = exp2(u_xlat12);
					    u_xlat12 = (-u_xlat0.x) + 1.0;
					    u_xlat0.z = (-u_xlat0.y) + u_xlat12;
					    u_xlat4.x = max(u_xlat0.y, 9.99999975e-05);
					    u_xlat4.x = u_xlat1.y / u_xlat4.x;
					    u_xlat1.xz = u_xlat4.xx * u_xlat0.xz;
					    u_xlat0.x = dot(vec3(1.6410234, -0.324803293, -0.236424699), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.663662851, 1.61533165, 0.0167563483), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.0117218941, -0.00828444213, 0.988394856), u_xlat1.xyz);
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.930000007, 0.930000007, 0.930000007) + vec3(u_xlat12);
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat0.x = dot(vec3(0.987223983, -0.00611326983, 0.0159533005), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.00759836007, 1.00186002, 0.00533019984), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.00307257008, -0.00509594986, 1.08168006), u_xlat1.xyz);
					    u_xlat1.x = dot(vec3(3.2409699, -1.5373832, -0.498610765), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.969243646, 1.8759675, 0.0415550582), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0556300804, -0.203976959, 1.05697155), u_xlat0.xyz);
					    SV_Target0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "TONEMAPPING_ACES" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					bvec3 u_xlatb0;
					vec4 u_xlat1;
					bvec4 u_xlatb1;
					vec4 u_xlat2;
					bvec2 u_xlatb2;
					vec3 u_xlat3;
					vec3 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					bool u_xlatb5;
					float u_xlat8;
					float u_xlat9;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.386036009, -0.386036009, -0.386036009);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.439700991, 0.382977992, 0.177334994), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.0897922963, 0.813422978, 0.0967615992), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0175439995, 0.111543998, 0.870703995), u_xlat0.xyz);
					    u_xlat0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = min(u_xlat0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5) + vec3(1.525878e-05, 1.525878e-05, 1.525878e-05);
					    u_xlat1.xyz = log2(u_xlat1.xyz);
					    u_xlat1.xyz = u_xlat1.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat2.xyz = log2(u_xlat0.xyz);
					    u_xlatb0.xyz = lessThan(u_xlat0.xyzx, vec4(3.05175708e-05, 3.05175708e-05, 3.05175708e-05, 0.0)).xyz;
					    u_xlat2.xyz = u_xlat2.xyz + vec3(9.72000027, 9.72000027, 9.72000027);
					    u_xlat2.xyz = u_xlat2.xyz * vec3(0.0570776239, 0.0570776239, 0.0570776239);
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat2.x;
					    u_xlat0.y = (u_xlatb0.y) ? u_xlat1.y : u_xlat2.y;
					    u_xlat0.z = (u_xlatb0.z) ? u_xlat1.z : u_xlat2.z;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.413588405, 0.413588405, 0.413588405);
					    u_xlatb1 = lessThan(u_xlat0.xxyy, vec4(-0.301369876, 1.46799636, -0.301369876, 1.46799636));
					    u_xlat0.xyw = u_xlat0.xyz * vec3(17.5200005, 17.5200005, 17.5200005) + vec3(-9.72000027, -9.72000027, -9.72000027);
					    u_xlatb2.xy = lessThan(u_xlat0.zzzz, vec4(-0.301369876, 1.46799636, 0.0, 0.0)).xy;
					    u_xlat0.xyz = exp2(u_xlat0.xyw);
					    u_xlat5.x = (u_xlatb1.y) ? u_xlat0.x : float(65504.0);
					    u_xlat5.z = (u_xlatb1.w) ? u_xlat0.y : float(65504.0);
					    u_xlat0.xyw = u_xlat0.xyz + vec3(-1.52587891e-05, -1.52587891e-05, -1.52587891e-05);
					    u_xlat8 = (u_xlatb2.y) ? u_xlat0.z : 65504.0;
					    u_xlat0.xyw = u_xlat0.xyw + u_xlat0.xyw;
					    u_xlat1.x = (u_xlatb1.x) ? u_xlat0.x : u_xlat5.x;
					    u_xlat1.y = (u_xlatb1.z) ? u_xlat0.y : u_xlat5.z;
					    u_xlat1.z = (u_xlatb2.x) ? u_xlat0.w : u_xlat8;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat1.xyz);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = textureLod(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.x = u_xlat4.x + -0.5;
					    u_xlat4.x = u_xlat4.x + u_xlat11.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(1.0<u_xlat4.x);
					#else
					    u_xlatb12 = 1.0<u_xlat4.x;
					#endif
					    u_xlat5.xy = u_xlat4.xx + vec2(1.0, -1.0);
					    u_xlat12 = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(u_xlat4.x<0.0);
					#else
					    u_xlatb4 = u_xlat4.x<0.0;
					#endif
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.x : u_xlat12;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat5.x = dot(vec3(0.695452213, 0.140678704, 0.163869068), u_xlat0.xyz);
					    u_xlat5.y = dot(vec3(0.0447945632, 0.859671116, 0.0955343172), u_xlat0.xyz);
					    u_xlat5.z = dot(vec3(-0.00552588282, 0.00402521016, 1.00150073), u_xlat0.xyz);
					    u_xlat0.xyz = (-u_xlat5.yxz) + u_xlat5.zyx;
					    u_xlat0.xy = u_xlat0.xy * u_xlat5.zy;
					    u_xlat0.x = u_xlat0.y + u_xlat0.x;
					    u_xlat0.x = u_xlat5.x * u_xlat0.z + u_xlat0.x;
					    u_xlat0.x = sqrt(u_xlat0.x);
					    u_xlat4.x = u_xlat5.y + u_xlat5.z;
					    u_xlat4.x = u_xlat5.x + u_xlat4.x;
					    u_xlat0.x = u_xlat0.x * 1.75 + u_xlat4.x;
					    u_xlat4.x = u_xlat0.x * 0.333333343;
					    u_xlat4.x = 0.0799999982 / u_xlat4.x;
					    u_xlat8 = min(u_xlat5.y, u_xlat5.x);
					    u_xlat8 = min(u_xlat5.z, u_xlat8);
					    u_xlat8 = max(u_xlat8, 9.99999975e-05);
					    u_xlat12 = max(u_xlat5.y, u_xlat5.x);
					    u_xlat12 = max(u_xlat5.z, u_xlat12);
					    u_xlat2.xy = max(vec2(u_xlat12), vec2(9.99999975e-05, 0.00999999978));
					    u_xlat8 = (-u_xlat8) + u_xlat2.x;
					    u_xlat4.y = u_xlat8 / u_xlat2.y;
					    u_xlat4.xz = u_xlat4.xy + vec2(-0.5, -0.400000006);
					    u_xlat1.x = u_xlat4.z * 2.5;
					    u_xlat12 = u_xlat4.z * intBitsToFloat(int(0x7F800000u)) + 0.5;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat12 = min(max(u_xlat12, 0.0), 1.0);
					#else
					    u_xlat12 = clamp(u_xlat12, 0.0, 1.0);
					#endif
					    u_xlat12 = u_xlat12 * 2.0 + -1.0;
					    u_xlat1.x = -abs(u_xlat1.x) + 1.0;
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = (-u_xlat1.x) * u_xlat1.x + 1.0;
					    u_xlat12 = u_xlat12 * u_xlat1.x + 1.0;
					    u_xlat12 = u_xlat12 * 0.0250000004;
					    u_xlat4.x = u_xlat4.x * u_xlat12;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1.x = !!(u_xlat0.x>=0.479999989);
					#else
					    u_xlatb1.x = u_xlat0.x>=0.479999989;
					#endif
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(0.159999996>=u_xlat0.x);
					#else
					    u_xlatb0.x = 0.159999996>=u_xlat0.x;
					#endif
					    u_xlat4.x = (u_xlatb1.x) ? 0.0 : u_xlat4.x;
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat12 : u_xlat4.x;
					    u_xlat0.x = u_xlat0.x + 1.0;
					    u_xlat2.yzw = u_xlat0.xxx * u_xlat5.xyz;
					    u_xlat4.x = (-u_xlat5.x) * u_xlat0.x + 0.0299999993;
					    u_xlat12 = u_xlat5.y * u_xlat0.x + (-u_xlat2.w);
					    u_xlat12 = u_xlat12 * 1.73205078;
					    u_xlat1.x = u_xlat2.y * 2.0 + (-u_xlat2.z);
					    u_xlat0.x = (-u_xlat5.z) * u_xlat0.x + u_xlat1.x;
					    u_xlat1.x = max(abs(u_xlat0.x), abs(u_xlat12));
					    u_xlat1.x = float(1.0) / u_xlat1.x;
					    u_xlat5.x = min(abs(u_xlat0.x), abs(u_xlat12));
					    u_xlat1.x = u_xlat1.x * u_xlat5.x;
					    u_xlat5.x = u_xlat1.x * u_xlat1.x;
					    u_xlat9 = u_xlat5.x * 0.0208350997 + -0.0851330012;
					    u_xlat9 = u_xlat5.x * u_xlat9 + 0.180141002;
					    u_xlat9 = u_xlat5.x * u_xlat9 + -0.330299497;
					    u_xlat5.x = u_xlat5.x * u_xlat9 + 0.999866009;
					    u_xlat9 = u_xlat5.x * u_xlat1.x;
					    u_xlat9 = u_xlat9 * -2.0 + 1.57079637;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb13 = !!(abs(u_xlat0.x)<abs(u_xlat12));
					#else
					    u_xlatb13 = abs(u_xlat0.x)<abs(u_xlat12);
					#endif
					    u_xlat9 = u_xlatb13 ? u_xlat9 : float(0.0);
					    u_xlat1.x = u_xlat1.x * u_xlat5.x + u_xlat9;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb5 = !!(u_xlat0.x<(-u_xlat0.x));
					#else
					    u_xlatb5 = u_xlat0.x<(-u_xlat0.x);
					#endif
					    u_xlat5.x = u_xlatb5 ? -3.14159274 : float(0.0);
					    u_xlat1.x = u_xlat5.x + u_xlat1.x;
					    u_xlat5.x = min(u_xlat0.x, u_xlat12);
					    u_xlat0.x = max(u_xlat0.x, u_xlat12);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(u_xlat0.x>=(-u_xlat0.x));
					#else
					    u_xlatb0.x = u_xlat0.x>=(-u_xlat0.x);
					#endif
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat5.x<(-u_xlat5.x));
					#else
					    u_xlatb12 = u_xlat5.x<(-u_xlat5.x);
					#endif
					    u_xlatb0.x = u_xlatb0.x && u_xlatb12;
					    u_xlat0.x = (u_xlatb0.x) ? (-u_xlat1.x) : u_xlat1.x;
					    u_xlat0.x = u_xlat0.x * 57.2957802;
					    u_xlatb1.xy = equal(u_xlat2.zwzz, u_xlat2.yzyy).xy;
					    u_xlatb12 = u_xlatb1.y && u_xlatb1.x;
					    u_xlat0.x = (u_xlatb12) ? 0.0 : u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x<0.0);
					#else
					    u_xlatb12 = u_xlat0.x<0.0;
					#endif
					    u_xlat1.x = u_xlat0.x + 360.0;
					    u_xlat0.x = (u_xlatb12) ? u_xlat1.x : u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(180.0<u_xlat0.x);
					#else
					    u_xlatb12 = 180.0<u_xlat0.x;
					#endif
					    u_xlat1.xy = u_xlat0.xx + vec2(360.0, -360.0);
					    u_xlat12 = (u_xlatb12) ? u_xlat1.y : u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0.x = !!(u_xlat0.x<-180.0);
					#else
					    u_xlatb0.x = u_xlat0.x<-180.0;
					#endif
					    u_xlat0.x = (u_xlatb0.x) ? u_xlat1.x : u_xlat12;
					    u_xlat0.x = u_xlat0.x * 0.0148148146;
					    u_xlat0.x = -abs(u_xlat0.x) + 1.0;
					    u_xlat0.x = max(u_xlat0.x, 0.0);
					    u_xlat12 = u_xlat0.x * -2.0 + 3.0;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat12;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat4.y * u_xlat0.x;
					    u_xlat0.x = u_xlat4.x * u_xlat0.x;
					    u_xlat2.x = u_xlat0.x * 0.180000007 + u_xlat2.y;
					    u_xlat0.x = dot(vec3(1.45143926, -0.236510754, -0.214928567), u_xlat2.xzw);
					    u_xlat0.y = dot(vec3(-0.0765537769, 1.17622972, -0.0996759236), u_xlat2.xzw);
					    u_xlat0.z = dot(vec3(0.00831614807, -0.00603244966, 0.997716308), u_xlat2.xzw);
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.959999979, 0.959999979, 0.959999979) + vec3(u_xlat12);
					    u_xlat1.xyz = u_xlat0.xyz * vec3(278.508514, 278.508514, 278.508514) + vec3(10.7771997, 10.7771997, 10.7771997);
					    u_xlat1.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat2.xyz = u_xlat0.xyz * vec3(293.604492, 293.604492, 293.604492) + vec3(88.7121964, 88.7121964, 88.7121964);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat2.xyz + vec3(80.6889038, 80.6889038, 80.6889038);
					    u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat0.x = dot(u_xlat1.xyz, vec3(1.0, 1.0, 1.0));
					    u_xlat0.x = max(u_xlat0.x, 9.99999975e-05);
					    u_xlat0.xy = u_xlat1.xy / u_xlat0.xx;
					    u_xlat12 = max(u_xlat1.y, 0.0);
					    u_xlat12 = min(u_xlat12, 65504.0);
					    u_xlat12 = log2(u_xlat12);
					    u_xlat12 = u_xlat12 * 0.981100023;
					    u_xlat1.y = exp2(u_xlat12);
					    u_xlat12 = (-u_xlat0.x) + 1.0;
					    u_xlat0.z = (-u_xlat0.y) + u_xlat12;
					    u_xlat4.x = max(u_xlat0.y, 9.99999975e-05);
					    u_xlat4.x = u_xlat1.y / u_xlat4.x;
					    u_xlat1.xz = u_xlat4.xx * u_xlat0.xz;
					    u_xlat0.x = dot(vec3(1.6410234, -0.324803293, -0.236424699), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.663662851, 1.61533165, 0.0167563483), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.0117218941, -0.00828444213, 0.988394856), u_xlat1.xyz);
					    u_xlat12 = dot(u_xlat0.xyz, vec3(0.272228986, 0.674081981, 0.0536894985));
					    u_xlat0.xyz = (-vec3(u_xlat12)) + u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.930000007, 0.930000007, 0.930000007) + vec3(u_xlat12);
					    u_xlat1.x = dot(vec3(0.662454188, 0.134004205, 0.156187683), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.272228718, 0.674081743, 0.0536895171), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.00557464967, 0.0040607336, 1.01033914), u_xlat0.xyz);
					    u_xlat0.x = dot(vec3(0.987223983, -0.00611326983, 0.0159533005), u_xlat1.xyz);
					    u_xlat0.y = dot(vec3(-0.00759836007, 1.00186002, 0.00533019984), u_xlat1.xyz);
					    u_xlat0.z = dot(vec3(0.00307257008, -0.00509594986, 1.08168006), u_xlat1.xyz);
					    u_xlat1.x = dot(vec3(3.2409699, -1.5373832, -0.498610765), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.969243646, 1.8759675, 0.0415550582), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0556300804, -0.203976959, 1.05697155), u_xlat0.xyz);
					    SV_Target0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb4 = 1.0<u_xlat5.x;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					    u_xlatb12 = u_xlat5.x<0.0;
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.262677222, 0.262677222, 0.262677222) + vec3(0.0695999935, 0.0695999935, 0.0695999935);
					    u_xlat2.xyz = u_xlat0.xyz * vec3(1.31338608, 1.31338608, 1.31338608);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.262677222, 0.262677222, 0.262677222) + vec3(0.289999992, 0.289999992, 0.289999992);
					    u_xlat0.xyz = u_xlat2.xyz * u_xlat0.xyz + vec3(0.0816000104, 0.0816000104, 0.0816000104);
					    u_xlat1.xyz = u_xlat2.xyz * u_xlat1.xyz + vec3(0.00543999998, 0.00543999998, 0.00543999998);
					    u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0666666627, -0.0666666627, -0.0666666627);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(1.31338608, 1.31338608, 1.31338608);
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb4 = 1.0<u_xlat5.x;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					    u_xlatb12 = u_xlat5.x<0.0;
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.262677222, 0.262677222, 0.262677222) + vec3(0.0695999935, 0.0695999935, 0.0695999935);
					    u_xlat2.xyz = u_xlat0.xyz * vec3(1.31338608, 1.31338608, 1.31338608);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.262677222, 0.262677222, 0.262677222) + vec3(0.289999992, 0.289999992, 0.289999992);
					    u_xlat0.xyz = u_xlat2.xyz * u_xlat0.xyz + vec3(0.0816000104, 0.0816000104, 0.0816000104);
					    u_xlat1.xyz = u_xlat2.xyz * u_xlat1.xyz + vec3(0.00543999998, 0.00543999998, 0.00543999998);
					    u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0666666627, -0.0666666627, -0.0666666627);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(1.31338608, 1.31338608, 1.31338608);
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = texture2DLodEXT(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb4 = 1.0<u_xlat5.x;
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					    u_xlatb12 = u_xlat5.x<0.0;
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.262677222, 0.262677222, 0.262677222) + vec3(0.0695999935, 0.0695999935, 0.0695999935);
					    u_xlat2.xyz = u_xlat0.xyz * vec3(1.31338608, 1.31338608, 1.31338608);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.262677222, 0.262677222, 0.262677222) + vec3(0.289999992, 0.289999992, 0.289999992);
					    u_xlat0.xyz = u_xlat2.xyz * u_xlat0.xyz + vec3(0.0816000104, 0.0816000104, 0.0816000104);
					    u_xlat1.xyz = u_xlat2.xyz * u_xlat1.xyz + vec3(0.00543999998, 0.00543999998, 0.00543999998);
					    u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0666666627, -0.0666666627, -0.0666666627);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(1.31338608, 1.31338608, 1.31338608);
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = textureLod(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(1.0<u_xlat5.x);
					#else
					    u_xlatb4 = 1.0<u_xlat5.x;
					#endif
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat5.x<0.0);
					#else
					    u_xlatb12 = u_xlat5.x<0.0;
					#endif
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.262677222, 0.262677222, 0.262677222) + vec3(0.0695999935, 0.0695999935, 0.0695999935);
					    u_xlat2.xyz = u_xlat0.xyz * vec3(1.31338608, 1.31338608, 1.31338608);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.262677222, 0.262677222, 0.262677222) + vec3(0.289999992, 0.289999992, 0.289999992);
					    u_xlat0.xyz = u_xlat2.xyz * u_xlat0.xyz + vec3(0.0816000104, 0.0816000104, 0.0816000104);
					    u_xlat1.xyz = u_xlat2.xyz * u_xlat1.xyz + vec3(0.00543999998, 0.00543999998, 0.00543999998);
					    u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0666666627, -0.0666666627, -0.0666666627);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(1.31338608, 1.31338608, 1.31338608);
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = textureLod(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(1.0<u_xlat5.x);
					#else
					    u_xlatb4 = 1.0<u_xlat5.x;
					#endif
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat5.x<0.0);
					#else
					    u_xlatb12 = u_xlat5.x<0.0;
					#endif
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.262677222, 0.262677222, 0.262677222) + vec3(0.0695999935, 0.0695999935, 0.0695999935);
					    u_xlat2.xyz = u_xlat0.xyz * vec3(1.31338608, 1.31338608, 1.31338608);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.262677222, 0.262677222, 0.262677222) + vec3(0.289999992, 0.289999992, 0.289999992);
					    u_xlat0.xyz = u_xlat2.xyz * u_xlat0.xyz + vec3(0.0816000104, 0.0816000104, 0.0816000104);
					    u_xlat1.xyz = u_xlat2.xyz * u_xlat1.xyz + vec3(0.00543999998, 0.00543999998, 0.00543999998);
					    u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0666666627, -0.0666666627, -0.0666666627);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(1.31338608, 1.31338608, 1.31338608);
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					bool u_xlatb4;
					vec3 u_xlat5;
					vec2 u_xlat10;
					vec2 u_xlat11;
					float u_xlat12;
					bool u_xlatb12;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb12 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat12) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb12 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat12 = u_xlatb12 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat12) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat5.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat4.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat4.x = u_xlat4.x / u_xlat5.x;
					    u_xlat4.x = u_xlat4.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat4.x);
					    u_xlat11.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat11.y = float(0.25);
					    u_xlat4.x = textureLod(_Curves, u_xlat11.xy, 0.0).x;
					    u_xlat4.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat4.xy = u_xlat4.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat4.xy = min(max(u_xlat4.xy, 0.0), 1.0);
					#else
					    u_xlat4.xy = clamp(u_xlat4.xy, 0.0, 1.0);
					#endif
					    u_xlat4.x = u_xlat11.x + u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb4 = !!(1.0<u_xlat5.x);
					#else
					    u_xlatb4 = 1.0<u_xlat5.x;
					#endif
					    u_xlat4.x = (u_xlatb4) ? u_xlat5.z : u_xlat5.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb12 = !!(u_xlat5.x<0.0);
					#else
					    u_xlatb12 = u_xlat5.x<0.0;
					#endif
					    u_xlat4.x = (u_xlatb12) ? u_xlat5.y : u_xlat4.x;
					    u_xlat5.xyz = u_xlat4.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat5.xyz = fract(u_xlat5.xyz);
					    u_xlat5.xyz = u_xlat5.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat5.xyz = abs(u_xlat5.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xyz = min(max(u_xlat5.xyz, 0.0), 1.0);
					#else
					    u_xlat5.xyz = clamp(u_xlat5.xyz, 0.0, 1.0);
					#endif
					    u_xlat5.xyz = u_xlat5.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat4.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat10.x = u_xlat1.x / u_xlat4.x;
					    u_xlat1.xyz = u_xlat10.xxx * u_xlat5.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat4.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat4.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat10.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat10.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat4.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat4.xxx;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.262677222, 0.262677222, 0.262677222) + vec3(0.0695999935, 0.0695999935, 0.0695999935);
					    u_xlat2.xyz = u_xlat0.xyz * vec3(1.31338608, 1.31338608, 1.31338608);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.262677222, 0.262677222, 0.262677222) + vec3(0.289999992, 0.289999992, 0.289999992);
					    u_xlat0.xyz = u_xlat2.xyz * u_xlat0.xyz + vec3(0.0816000104, 0.0816000104, 0.0816000104);
					    u_xlat1.xyz = u_xlat2.xyz * u_xlat1.xyz + vec3(0.00543999998, 0.00543999998, 0.00543999998);
					    u_xlat0.xyz = u_xlat1.xyz / u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0666666627, -0.0666666627, -0.0666666627);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(1.31338608, 1.31338608, 1.31338608);
					    SV_Target0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "TONEMAPPING_CUSTOM" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform 	vec4 _CustomToneCurve;
					uniform 	vec4 _ToeSegmentA;
					uniform 	vec4 _ToeSegmentB;
					uniform 	vec4 _MidSegmentA;
					uniform 	vec4 _MidSegmentB;
					uniform 	vec4 _ShoSegmentA;
					uniform 	vec4 _ShoSegmentB;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb5;
					vec3 u_xlat6;
					float u_xlat10;
					bool u_xlatb10;
					bvec2 u_xlatb11;
					vec2 u_xlat12;
					vec2 u_xlat13;
					float u_xlat15;
					bool u_xlatb15;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb15 = u_xlat0.y>=u_xlat0.z;
					    u_xlat15 = u_xlatb15 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat15) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb15 = u_xlat0.x>=u_xlat1.x;
					    u_xlat15 = u_xlatb15 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat15) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat6.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat5.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat5.x = u_xlat5.x / u_xlat6.x;
					    u_xlat5.x = u_xlat5.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat5.x);
					    u_xlat13.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat13.y = float(0.25);
					    u_xlat5.x = texture2DLodEXT(_Curves, u_xlat13.xy, 0.0).x;
					    u_xlat5.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat5.xy = u_xlat5.xy;
					    u_xlat5.xy = clamp(u_xlat5.xy, 0.0, 1.0);
					    u_xlat5.x = u_xlat13.x + u_xlat5.x;
					    u_xlat6.xyz = u_xlat5.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb5 = 1.0<u_xlat6.x;
					    u_xlat5.x = (u_xlatb5) ? u_xlat6.z : u_xlat6.x;
					    u_xlatb15 = u_xlat6.x<0.0;
					    u_xlat5.x = (u_xlatb15) ? u_xlat6.y : u_xlat5.x;
					    u_xlat6.xyz = u_xlat5.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat6.xyz = fract(u_xlat6.xyz);
					    u_xlat6.xyz = u_xlat6.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat6.xyz = abs(u_xlat6.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat6.xyz = clamp(u_xlat6.xyz, 0.0, 1.0);
					    u_xlat6.xyz = u_xlat6.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat12.x = u_xlat1.x / u_xlat5.x;
					    u_xlat1.xyz = u_xlat12.xxx * u_xlat6.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat5.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat5.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat12.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat12.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat5.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat5.xxx;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat1.xyz = u_xlat0.xyz * _CustomToneCurve.xxx;
					    u_xlatb11.xy = lessThan(u_xlat1.zzzz, _CustomToneCurve.yzyz).xy;
					    u_xlatb2 = lessThan(u_xlat1.xxyy, _CustomToneCurve.yzyz);
					    u_xlat3 = (u_xlatb11.y) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat3 = (u_xlatb11.x) ? _ToeSegmentA : u_xlat3;
					    u_xlat10 = u_xlat0.z * _CustomToneCurve.x + (-u_xlat3.x);
					    u_xlat10 = u_xlat3.z * u_xlat10;
					    u_xlat15 = log2(u_xlat10);
					    u_xlatb10 = 0.0<u_xlat10;
					    u_xlat1.xy = (u_xlatb11.y) ? _MidSegmentB.xy : _ShoSegmentB.xy;
					    u_xlat1.xy = (u_xlatb11.x) ? _ToeSegmentB.xy : u_xlat1.xy;
					    u_xlat15 = u_xlat15 * u_xlat1.y;
					    u_xlat15 = u_xlat15 * 0.693147182 + u_xlat1.x;
					    u_xlat15 = u_xlat15 * 1.44269502;
					    u_xlat15 = exp2(u_xlat15);
					    u_xlat10 = u_xlatb10 ? u_xlat15 : float(0.0);
					    u_xlat1.z = u_xlat10 * u_xlat3.w + u_xlat3.y;
					    u_xlat3 = (u_xlatb2.y) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat3 = (u_xlatb2.x) ? _ToeSegmentA : u_xlat3;
					    u_xlat0.x = u_xlat0.x * _CustomToneCurve.x + (-u_xlat3.x);
					    u_xlat0.x = u_xlat3.z * u_xlat0.x;
					    u_xlat10 = log2(u_xlat0.x);
					    u_xlatb0 = 0.0<u_xlat0.x;
					    u_xlat4.x = (u_xlatb2.y) ? _MidSegmentB.x : _ShoSegmentB.x;
					    u_xlat4.y = (u_xlatb2.y) ? _MidSegmentB.y : _ShoSegmentB.y;
					    u_xlat4.z = (u_xlatb2.w) ? _MidSegmentB.x : _ShoSegmentB.x;
					    u_xlat4.w = (u_xlatb2.w) ? _MidSegmentB.y : _ShoSegmentB.y;
					    {
					        vec4 hlslcc_movcTemp = u_xlat4;
					        hlslcc_movcTemp.x = (u_xlatb2.x) ? _ToeSegmentB.x : u_xlat4.x;
					        hlslcc_movcTemp.y = (u_xlatb2.x) ? _ToeSegmentB.y : u_xlat4.y;
					        hlslcc_movcTemp.z = (u_xlatb2.z) ? _ToeSegmentB.x : u_xlat4.z;
					        hlslcc_movcTemp.w = (u_xlatb2.z) ? _ToeSegmentB.y : u_xlat4.w;
					        u_xlat4 = hlslcc_movcTemp;
					    }
					    u_xlat10 = u_xlat10 * u_xlat4.y;
					    u_xlat10 = u_xlat10 * 0.693147182 + u_xlat4.x;
					    u_xlat10 = u_xlat10 * 1.44269502;
					    u_xlat10 = exp2(u_xlat10);
					    u_xlat0.x = u_xlatb0 ? u_xlat10 : float(0.0);
					    u_xlat1.x = u_xlat0.x * u_xlat3.w + u_xlat3.y;
					    u_xlat3 = (u_xlatb2.w) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat2 = (u_xlatb2.z) ? _ToeSegmentA : u_xlat3;
					    u_xlat0.x = u_xlat0.y * _CustomToneCurve.x + (-u_xlat2.x);
					    u_xlat0.x = u_xlat2.z * u_xlat0.x;
					    u_xlat5.x = log2(u_xlat0.x);
					    u_xlatb0 = 0.0<u_xlat0.x;
					    u_xlat5.x = u_xlat5.x * u_xlat4.w;
					    u_xlat5.x = u_xlat5.x * 0.693147182 + u_xlat4.z;
					    u_xlat5.x = u_xlat5.x * 1.44269502;
					    u_xlat5.x = exp2(u_xlat5.x);
					    u_xlat0.x = u_xlatb0 ? u_xlat5.x : float(0.0);
					    u_xlat1.y = u_xlat0.x * u_xlat2.w + u_xlat2.y;
					    SV_Target0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "TONEMAPPING_CUSTOM" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform 	vec4 _CustomToneCurve;
					uniform 	vec4 _ToeSegmentA;
					uniform 	vec4 _ToeSegmentB;
					uniform 	vec4 _MidSegmentA;
					uniform 	vec4 _MidSegmentB;
					uniform 	vec4 _ShoSegmentA;
					uniform 	vec4 _ShoSegmentB;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb5;
					vec3 u_xlat6;
					float u_xlat10;
					bool u_xlatb10;
					bvec2 u_xlatb11;
					vec2 u_xlat12;
					vec2 u_xlat13;
					float u_xlat15;
					bool u_xlatb15;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb15 = u_xlat0.y>=u_xlat0.z;
					    u_xlat15 = u_xlatb15 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat15) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb15 = u_xlat0.x>=u_xlat1.x;
					    u_xlat15 = u_xlatb15 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat15) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat6.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat5.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat5.x = u_xlat5.x / u_xlat6.x;
					    u_xlat5.x = u_xlat5.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat5.x);
					    u_xlat13.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat13.y = float(0.25);
					    u_xlat5.x = texture2DLodEXT(_Curves, u_xlat13.xy, 0.0).x;
					    u_xlat5.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat5.xy = u_xlat5.xy;
					    u_xlat5.xy = clamp(u_xlat5.xy, 0.0, 1.0);
					    u_xlat5.x = u_xlat13.x + u_xlat5.x;
					    u_xlat6.xyz = u_xlat5.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb5 = 1.0<u_xlat6.x;
					    u_xlat5.x = (u_xlatb5) ? u_xlat6.z : u_xlat6.x;
					    u_xlatb15 = u_xlat6.x<0.0;
					    u_xlat5.x = (u_xlatb15) ? u_xlat6.y : u_xlat5.x;
					    u_xlat6.xyz = u_xlat5.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat6.xyz = fract(u_xlat6.xyz);
					    u_xlat6.xyz = u_xlat6.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat6.xyz = abs(u_xlat6.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat6.xyz = clamp(u_xlat6.xyz, 0.0, 1.0);
					    u_xlat6.xyz = u_xlat6.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat12.x = u_xlat1.x / u_xlat5.x;
					    u_xlat1.xyz = u_xlat12.xxx * u_xlat6.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat5.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat5.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat12.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat12.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat5.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat5.xxx;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat1.xyz = u_xlat0.xyz * _CustomToneCurve.xxx;
					    u_xlatb11.xy = lessThan(u_xlat1.zzzz, _CustomToneCurve.yzyz).xy;
					    u_xlatb2 = lessThan(u_xlat1.xxyy, _CustomToneCurve.yzyz);
					    u_xlat3 = (u_xlatb11.y) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat3 = (u_xlatb11.x) ? _ToeSegmentA : u_xlat3;
					    u_xlat10 = u_xlat0.z * _CustomToneCurve.x + (-u_xlat3.x);
					    u_xlat10 = u_xlat3.z * u_xlat10;
					    u_xlat15 = log2(u_xlat10);
					    u_xlatb10 = 0.0<u_xlat10;
					    u_xlat1.xy = (u_xlatb11.y) ? _MidSegmentB.xy : _ShoSegmentB.xy;
					    u_xlat1.xy = (u_xlatb11.x) ? _ToeSegmentB.xy : u_xlat1.xy;
					    u_xlat15 = u_xlat15 * u_xlat1.y;
					    u_xlat15 = u_xlat15 * 0.693147182 + u_xlat1.x;
					    u_xlat15 = u_xlat15 * 1.44269502;
					    u_xlat15 = exp2(u_xlat15);
					    u_xlat10 = u_xlatb10 ? u_xlat15 : float(0.0);
					    u_xlat1.z = u_xlat10 * u_xlat3.w + u_xlat3.y;
					    u_xlat3 = (u_xlatb2.y) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat3 = (u_xlatb2.x) ? _ToeSegmentA : u_xlat3;
					    u_xlat0.x = u_xlat0.x * _CustomToneCurve.x + (-u_xlat3.x);
					    u_xlat0.x = u_xlat3.z * u_xlat0.x;
					    u_xlat10 = log2(u_xlat0.x);
					    u_xlatb0 = 0.0<u_xlat0.x;
					    u_xlat4.x = (u_xlatb2.y) ? _MidSegmentB.x : _ShoSegmentB.x;
					    u_xlat4.y = (u_xlatb2.y) ? _MidSegmentB.y : _ShoSegmentB.y;
					    u_xlat4.z = (u_xlatb2.w) ? _MidSegmentB.x : _ShoSegmentB.x;
					    u_xlat4.w = (u_xlatb2.w) ? _MidSegmentB.y : _ShoSegmentB.y;
					    {
					        vec4 hlslcc_movcTemp = u_xlat4;
					        hlslcc_movcTemp.x = (u_xlatb2.x) ? _ToeSegmentB.x : u_xlat4.x;
					        hlslcc_movcTemp.y = (u_xlatb2.x) ? _ToeSegmentB.y : u_xlat4.y;
					        hlslcc_movcTemp.z = (u_xlatb2.z) ? _ToeSegmentB.x : u_xlat4.z;
					        hlslcc_movcTemp.w = (u_xlatb2.z) ? _ToeSegmentB.y : u_xlat4.w;
					        u_xlat4 = hlslcc_movcTemp;
					    }
					    u_xlat10 = u_xlat10 * u_xlat4.y;
					    u_xlat10 = u_xlat10 * 0.693147182 + u_xlat4.x;
					    u_xlat10 = u_xlat10 * 1.44269502;
					    u_xlat10 = exp2(u_xlat10);
					    u_xlat0.x = u_xlatb0 ? u_xlat10 : float(0.0);
					    u_xlat1.x = u_xlat0.x * u_xlat3.w + u_xlat3.y;
					    u_xlat3 = (u_xlatb2.w) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat2 = (u_xlatb2.z) ? _ToeSegmentA : u_xlat3;
					    u_xlat0.x = u_xlat0.y * _CustomToneCurve.x + (-u_xlat2.x);
					    u_xlat0.x = u_xlat2.z * u_xlat0.x;
					    u_xlat5.x = log2(u_xlat0.x);
					    u_xlatb0 = 0.0<u_xlat0.x;
					    u_xlat5.x = u_xlat5.x * u_xlat4.w;
					    u_xlat5.x = u_xlat5.x * 0.693147182 + u_xlat4.z;
					    u_xlat5.x = u_xlat5.x * 1.44269502;
					    u_xlat5.x = exp2(u_xlat5.x);
					    u_xlat0.x = u_xlatb0 ? u_xlat5.x : float(0.0);
					    u_xlat1.y = u_xlat0.x * u_xlat2.w + u_xlat2.y;
					    SV_Target0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "TONEMAPPING_CUSTOM" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform 	vec4 _CustomToneCurve;
					uniform 	vec4 _ToeSegmentA;
					uniform 	vec4 _ToeSegmentB;
					uniform 	vec4 _MidSegmentA;
					uniform 	vec4 _MidSegmentB;
					uniform 	vec4 _ShoSegmentA;
					uniform 	vec4 _ShoSegmentB;
					uniform lowp sampler2D _Curves;
					varying highp vec2 vs_TEXCOORD0;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb5;
					vec3 u_xlat6;
					float u_xlat10;
					bool u_xlatb10;
					bvec2 u_xlatb11;
					vec2 u_xlat12;
					vec2 u_xlat13;
					float u_xlat15;
					bool u_xlatb15;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlatb15 = u_xlat0.y>=u_xlat0.z;
					    u_xlat15 = u_xlatb15 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat15) * u_xlat2.xywz + u_xlat1.xywz;
					    u_xlatb15 = u_xlat0.x>=u_xlat1.x;
					    u_xlat15 = u_xlatb15 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat15) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat6.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat5.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat5.x = u_xlat5.x / u_xlat6.x;
					    u_xlat5.x = u_xlat5.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat5.x);
					    u_xlat13.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat13.y = float(0.25);
					    u_xlat5.x = texture2DLodEXT(_Curves, u_xlat13.xy, 0.0).x;
					    u_xlat5.y = texture2DLodEXT(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat5.xy = u_xlat5.xy;
					    u_xlat5.xy = clamp(u_xlat5.xy, 0.0, 1.0);
					    u_xlat5.x = u_xlat13.x + u_xlat5.x;
					    u_xlat6.xyz = u_xlat5.xxx + vec3(-0.5, 0.5, -1.5);
					    u_xlatb5 = 1.0<u_xlat6.x;
					    u_xlat5.x = (u_xlatb5) ? u_xlat6.z : u_xlat6.x;
					    u_xlatb15 = u_xlat6.x<0.0;
					    u_xlat5.x = (u_xlatb15) ? u_xlat6.y : u_xlat5.x;
					    u_xlat6.xyz = u_xlat5.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat6.xyz = fract(u_xlat6.xyz);
					    u_xlat6.xyz = u_xlat6.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat6.xyz = abs(u_xlat6.xyz) + vec3(-1.0, -1.0, -1.0);
					    u_xlat6.xyz = clamp(u_xlat6.xyz, 0.0, 1.0);
					    u_xlat6.xyz = u_xlat6.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat12.x = u_xlat1.x / u_xlat5.x;
					    u_xlat1.xyz = u_xlat12.xxx * u_xlat6.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat5.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat5.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat12.y = float(0.25);
					    u_xlat0.x = texture2DLodEXT(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = texture2DLodEXT(_Curves, u_xlat12.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat5.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat5.xxx;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat1.xyz = u_xlat0.xyz * _CustomToneCurve.xxx;
					    u_xlatb11.xy = lessThan(u_xlat1.zzzz, _CustomToneCurve.yzyz).xy;
					    u_xlatb2 = lessThan(u_xlat1.xxyy, _CustomToneCurve.yzyz);
					    u_xlat3 = (u_xlatb11.y) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat3 = (u_xlatb11.x) ? _ToeSegmentA : u_xlat3;
					    u_xlat10 = u_xlat0.z * _CustomToneCurve.x + (-u_xlat3.x);
					    u_xlat10 = u_xlat3.z * u_xlat10;
					    u_xlat15 = log2(u_xlat10);
					    u_xlatb10 = 0.0<u_xlat10;
					    u_xlat1.xy = (u_xlatb11.y) ? _MidSegmentB.xy : _ShoSegmentB.xy;
					    u_xlat1.xy = (u_xlatb11.x) ? _ToeSegmentB.xy : u_xlat1.xy;
					    u_xlat15 = u_xlat15 * u_xlat1.y;
					    u_xlat15 = u_xlat15 * 0.693147182 + u_xlat1.x;
					    u_xlat15 = u_xlat15 * 1.44269502;
					    u_xlat15 = exp2(u_xlat15);
					    u_xlat10 = u_xlatb10 ? u_xlat15 : float(0.0);
					    u_xlat1.z = u_xlat10 * u_xlat3.w + u_xlat3.y;
					    u_xlat3 = (u_xlatb2.y) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat3 = (u_xlatb2.x) ? _ToeSegmentA : u_xlat3;
					    u_xlat0.x = u_xlat0.x * _CustomToneCurve.x + (-u_xlat3.x);
					    u_xlat0.x = u_xlat3.z * u_xlat0.x;
					    u_xlat10 = log2(u_xlat0.x);
					    u_xlatb0 = 0.0<u_xlat0.x;
					    u_xlat4.x = (u_xlatb2.y) ? _MidSegmentB.x : _ShoSegmentB.x;
					    u_xlat4.y = (u_xlatb2.y) ? _MidSegmentB.y : _ShoSegmentB.y;
					    u_xlat4.z = (u_xlatb2.w) ? _MidSegmentB.x : _ShoSegmentB.x;
					    u_xlat4.w = (u_xlatb2.w) ? _MidSegmentB.y : _ShoSegmentB.y;
					    {
					        vec4 hlslcc_movcTemp = u_xlat4;
					        hlslcc_movcTemp.x = (u_xlatb2.x) ? _ToeSegmentB.x : u_xlat4.x;
					        hlslcc_movcTemp.y = (u_xlatb2.x) ? _ToeSegmentB.y : u_xlat4.y;
					        hlslcc_movcTemp.z = (u_xlatb2.z) ? _ToeSegmentB.x : u_xlat4.z;
					        hlslcc_movcTemp.w = (u_xlatb2.z) ? _ToeSegmentB.y : u_xlat4.w;
					        u_xlat4 = hlslcc_movcTemp;
					    }
					    u_xlat10 = u_xlat10 * u_xlat4.y;
					    u_xlat10 = u_xlat10 * 0.693147182 + u_xlat4.x;
					    u_xlat10 = u_xlat10 * 1.44269502;
					    u_xlat10 = exp2(u_xlat10);
					    u_xlat0.x = u_xlatb0 ? u_xlat10 : float(0.0);
					    u_xlat1.x = u_xlat0.x * u_xlat3.w + u_xlat3.y;
					    u_xlat3 = (u_xlatb2.w) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat2 = (u_xlatb2.z) ? _ToeSegmentA : u_xlat3;
					    u_xlat0.x = u_xlat0.y * _CustomToneCurve.x + (-u_xlat2.x);
					    u_xlat0.x = u_xlat2.z * u_xlat0.x;
					    u_xlat5.x = log2(u_xlat0.x);
					    u_xlatb0 = 0.0<u_xlat0.x;
					    u_xlat5.x = u_xlat5.x * u_xlat4.w;
					    u_xlat5.x = u_xlat5.x * 0.693147182 + u_xlat4.z;
					    u_xlat5.x = u_xlat5.x * 1.44269502;
					    u_xlat5.x = exp2(u_xlat5.x);
					    u_xlat0.x = u_xlatb0 ? u_xlat5.x : float(0.0);
					    u_xlat1.y = u_xlat0.x * u_xlat2.w + u_xlat2.y;
					    SV_Target0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "TONEMAPPING_CUSTOM" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform 	vec4 _CustomToneCurve;
					uniform 	vec4 _ToeSegmentA;
					uniform 	vec4 _ToeSegmentB;
					uniform 	vec4 _MidSegmentA;
					uniform 	vec4 _MidSegmentB;
					uniform 	vec4 _ShoSegmentA;
					uniform 	vec4 _ShoSegmentB;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb5;
					vec3 u_xlat6;
					float u_xlat10;
					bool u_xlatb10;
					bvec2 u_xlatb11;
					vec2 u_xlat12;
					vec2 u_xlat13;
					float u_xlat15;
					bool u_xlatb15;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb15 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb15 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat15 = u_xlatb15 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat15) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb15 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb15 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat15 = u_xlatb15 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat15) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat6.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat5.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat5.x = u_xlat5.x / u_xlat6.x;
					    u_xlat5.x = u_xlat5.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat5.x);
					    u_xlat13.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat13.y = float(0.25);
					    u_xlat5.x = textureLod(_Curves, u_xlat13.xy, 0.0).x;
					    u_xlat5.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat5.xy = u_xlat5.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xy = min(max(u_xlat5.xy, 0.0), 1.0);
					#else
					    u_xlat5.xy = clamp(u_xlat5.xy, 0.0, 1.0);
					#endif
					    u_xlat5.x = u_xlat13.x + u_xlat5.x;
					    u_xlat6.xyz = u_xlat5.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb5 = !!(1.0<u_xlat6.x);
					#else
					    u_xlatb5 = 1.0<u_xlat6.x;
					#endif
					    u_xlat5.x = (u_xlatb5) ? u_xlat6.z : u_xlat6.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb15 = !!(u_xlat6.x<0.0);
					#else
					    u_xlatb15 = u_xlat6.x<0.0;
					#endif
					    u_xlat5.x = (u_xlatb15) ? u_xlat6.y : u_xlat5.x;
					    u_xlat6.xyz = u_xlat5.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat6.xyz = fract(u_xlat6.xyz);
					    u_xlat6.xyz = u_xlat6.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat6.xyz = abs(u_xlat6.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat6.xyz = min(max(u_xlat6.xyz, 0.0), 1.0);
					#else
					    u_xlat6.xyz = clamp(u_xlat6.xyz, 0.0, 1.0);
					#endif
					    u_xlat6.xyz = u_xlat6.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat12.x = u_xlat1.x / u_xlat5.x;
					    u_xlat1.xyz = u_xlat12.xxx * u_xlat6.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat5.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat5.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat12.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat12.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat5.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat5.xxx;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat1.xyz = u_xlat0.xyz * _CustomToneCurve.xxx;
					    u_xlatb11.xy = lessThan(u_xlat1.zzzz, _CustomToneCurve.yzyz).xy;
					    u_xlatb2 = lessThan(u_xlat1.xxyy, _CustomToneCurve.yzyz);
					    u_xlat3 = (u_xlatb11.y) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat3 = (u_xlatb11.x) ? _ToeSegmentA : u_xlat3;
					    u_xlat10 = u_xlat0.z * _CustomToneCurve.x + (-u_xlat3.x);
					    u_xlat10 = u_xlat3.z * u_xlat10;
					    u_xlat15 = log2(u_xlat10);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb10 = !!(0.0<u_xlat10);
					#else
					    u_xlatb10 = 0.0<u_xlat10;
					#endif
					    u_xlat1.xy = (u_xlatb11.y) ? _MidSegmentB.xy : _ShoSegmentB.xy;
					    u_xlat1.xy = (u_xlatb11.x) ? _ToeSegmentB.xy : u_xlat1.xy;
					    u_xlat15 = u_xlat15 * u_xlat1.y;
					    u_xlat15 = u_xlat15 * 0.693147182 + u_xlat1.x;
					    u_xlat15 = u_xlat15 * 1.44269502;
					    u_xlat15 = exp2(u_xlat15);
					    u_xlat10 = u_xlatb10 ? u_xlat15 : float(0.0);
					    u_xlat1.z = u_xlat10 * u_xlat3.w + u_xlat3.y;
					    u_xlat3 = (u_xlatb2.y) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat3 = (u_xlatb2.x) ? _ToeSegmentA : u_xlat3;
					    u_xlat0.x = u_xlat0.x * _CustomToneCurve.x + (-u_xlat3.x);
					    u_xlat0.x = u_xlat3.z * u_xlat0.x;
					    u_xlat10 = log2(u_xlat0.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(0.0<u_xlat0.x);
					#else
					    u_xlatb0 = 0.0<u_xlat0.x;
					#endif
					    u_xlat4.x = (u_xlatb2.y) ? _MidSegmentB.x : _ShoSegmentB.x;
					    u_xlat4.y = (u_xlatb2.y) ? _MidSegmentB.y : _ShoSegmentB.y;
					    u_xlat4.z = (u_xlatb2.w) ? _MidSegmentB.x : _ShoSegmentB.x;
					    u_xlat4.w = (u_xlatb2.w) ? _MidSegmentB.y : _ShoSegmentB.y;
					    {
					        vec4 hlslcc_movcTemp = u_xlat4;
					        hlslcc_movcTemp.x = (u_xlatb2.x) ? _ToeSegmentB.x : u_xlat4.x;
					        hlslcc_movcTemp.y = (u_xlatb2.x) ? _ToeSegmentB.y : u_xlat4.y;
					        hlslcc_movcTemp.z = (u_xlatb2.z) ? _ToeSegmentB.x : u_xlat4.z;
					        hlslcc_movcTemp.w = (u_xlatb2.z) ? _ToeSegmentB.y : u_xlat4.w;
					        u_xlat4 = hlslcc_movcTemp;
					    }
					    u_xlat10 = u_xlat10 * u_xlat4.y;
					    u_xlat10 = u_xlat10 * 0.693147182 + u_xlat4.x;
					    u_xlat10 = u_xlat10 * 1.44269502;
					    u_xlat10 = exp2(u_xlat10);
					    u_xlat0.x = u_xlatb0 ? u_xlat10 : float(0.0);
					    u_xlat1.x = u_xlat0.x * u_xlat3.w + u_xlat3.y;
					    u_xlat3 = (u_xlatb2.w) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat2 = (u_xlatb2.z) ? _ToeSegmentA : u_xlat3;
					    u_xlat0.x = u_xlat0.y * _CustomToneCurve.x + (-u_xlat2.x);
					    u_xlat0.x = u_xlat2.z * u_xlat0.x;
					    u_xlat5.x = log2(u_xlat0.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(0.0<u_xlat0.x);
					#else
					    u_xlatb0 = 0.0<u_xlat0.x;
					#endif
					    u_xlat5.x = u_xlat5.x * u_xlat4.w;
					    u_xlat5.x = u_xlat5.x * 0.693147182 + u_xlat4.z;
					    u_xlat5.x = u_xlat5.x * 1.44269502;
					    u_xlat5.x = exp2(u_xlat5.x);
					    u_xlat0.x = u_xlatb0 ? u_xlat5.x : float(0.0);
					    u_xlat1.y = u_xlat0.x * u_xlat2.w + u_xlat2.y;
					    SV_Target0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "TONEMAPPING_CUSTOM" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform 	vec4 _CustomToneCurve;
					uniform 	vec4 _ToeSegmentA;
					uniform 	vec4 _ToeSegmentB;
					uniform 	vec4 _MidSegmentA;
					uniform 	vec4 _MidSegmentB;
					uniform 	vec4 _ShoSegmentA;
					uniform 	vec4 _ShoSegmentB;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb5;
					vec3 u_xlat6;
					float u_xlat10;
					bool u_xlatb10;
					bvec2 u_xlatb11;
					vec2 u_xlat12;
					vec2 u_xlat13;
					float u_xlat15;
					bool u_xlatb15;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb15 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb15 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat15 = u_xlatb15 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat15) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb15 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb15 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat15 = u_xlatb15 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat15) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat6.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat5.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat5.x = u_xlat5.x / u_xlat6.x;
					    u_xlat5.x = u_xlat5.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat5.x);
					    u_xlat13.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat13.y = float(0.25);
					    u_xlat5.x = textureLod(_Curves, u_xlat13.xy, 0.0).x;
					    u_xlat5.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat5.xy = u_xlat5.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xy = min(max(u_xlat5.xy, 0.0), 1.0);
					#else
					    u_xlat5.xy = clamp(u_xlat5.xy, 0.0, 1.0);
					#endif
					    u_xlat5.x = u_xlat13.x + u_xlat5.x;
					    u_xlat6.xyz = u_xlat5.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb5 = !!(1.0<u_xlat6.x);
					#else
					    u_xlatb5 = 1.0<u_xlat6.x;
					#endif
					    u_xlat5.x = (u_xlatb5) ? u_xlat6.z : u_xlat6.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb15 = !!(u_xlat6.x<0.0);
					#else
					    u_xlatb15 = u_xlat6.x<0.0;
					#endif
					    u_xlat5.x = (u_xlatb15) ? u_xlat6.y : u_xlat5.x;
					    u_xlat6.xyz = u_xlat5.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat6.xyz = fract(u_xlat6.xyz);
					    u_xlat6.xyz = u_xlat6.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat6.xyz = abs(u_xlat6.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat6.xyz = min(max(u_xlat6.xyz, 0.0), 1.0);
					#else
					    u_xlat6.xyz = clamp(u_xlat6.xyz, 0.0, 1.0);
					#endif
					    u_xlat6.xyz = u_xlat6.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat12.x = u_xlat1.x / u_xlat5.x;
					    u_xlat1.xyz = u_xlat12.xxx * u_xlat6.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat5.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat5.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat12.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat12.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat5.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat5.xxx;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat1.xyz = u_xlat0.xyz * _CustomToneCurve.xxx;
					    u_xlatb11.xy = lessThan(u_xlat1.zzzz, _CustomToneCurve.yzyz).xy;
					    u_xlatb2 = lessThan(u_xlat1.xxyy, _CustomToneCurve.yzyz);
					    u_xlat3 = (u_xlatb11.y) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat3 = (u_xlatb11.x) ? _ToeSegmentA : u_xlat3;
					    u_xlat10 = u_xlat0.z * _CustomToneCurve.x + (-u_xlat3.x);
					    u_xlat10 = u_xlat3.z * u_xlat10;
					    u_xlat15 = log2(u_xlat10);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb10 = !!(0.0<u_xlat10);
					#else
					    u_xlatb10 = 0.0<u_xlat10;
					#endif
					    u_xlat1.xy = (u_xlatb11.y) ? _MidSegmentB.xy : _ShoSegmentB.xy;
					    u_xlat1.xy = (u_xlatb11.x) ? _ToeSegmentB.xy : u_xlat1.xy;
					    u_xlat15 = u_xlat15 * u_xlat1.y;
					    u_xlat15 = u_xlat15 * 0.693147182 + u_xlat1.x;
					    u_xlat15 = u_xlat15 * 1.44269502;
					    u_xlat15 = exp2(u_xlat15);
					    u_xlat10 = u_xlatb10 ? u_xlat15 : float(0.0);
					    u_xlat1.z = u_xlat10 * u_xlat3.w + u_xlat3.y;
					    u_xlat3 = (u_xlatb2.y) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat3 = (u_xlatb2.x) ? _ToeSegmentA : u_xlat3;
					    u_xlat0.x = u_xlat0.x * _CustomToneCurve.x + (-u_xlat3.x);
					    u_xlat0.x = u_xlat3.z * u_xlat0.x;
					    u_xlat10 = log2(u_xlat0.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(0.0<u_xlat0.x);
					#else
					    u_xlatb0 = 0.0<u_xlat0.x;
					#endif
					    u_xlat4.x = (u_xlatb2.y) ? _MidSegmentB.x : _ShoSegmentB.x;
					    u_xlat4.y = (u_xlatb2.y) ? _MidSegmentB.y : _ShoSegmentB.y;
					    u_xlat4.z = (u_xlatb2.w) ? _MidSegmentB.x : _ShoSegmentB.x;
					    u_xlat4.w = (u_xlatb2.w) ? _MidSegmentB.y : _ShoSegmentB.y;
					    {
					        vec4 hlslcc_movcTemp = u_xlat4;
					        hlslcc_movcTemp.x = (u_xlatb2.x) ? _ToeSegmentB.x : u_xlat4.x;
					        hlslcc_movcTemp.y = (u_xlatb2.x) ? _ToeSegmentB.y : u_xlat4.y;
					        hlslcc_movcTemp.z = (u_xlatb2.z) ? _ToeSegmentB.x : u_xlat4.z;
					        hlslcc_movcTemp.w = (u_xlatb2.z) ? _ToeSegmentB.y : u_xlat4.w;
					        u_xlat4 = hlslcc_movcTemp;
					    }
					    u_xlat10 = u_xlat10 * u_xlat4.y;
					    u_xlat10 = u_xlat10 * 0.693147182 + u_xlat4.x;
					    u_xlat10 = u_xlat10 * 1.44269502;
					    u_xlat10 = exp2(u_xlat10);
					    u_xlat0.x = u_xlatb0 ? u_xlat10 : float(0.0);
					    u_xlat1.x = u_xlat0.x * u_xlat3.w + u_xlat3.y;
					    u_xlat3 = (u_xlatb2.w) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat2 = (u_xlatb2.z) ? _ToeSegmentA : u_xlat3;
					    u_xlat0.x = u_xlat0.y * _CustomToneCurve.x + (-u_xlat2.x);
					    u_xlat0.x = u_xlat2.z * u_xlat0.x;
					    u_xlat5.x = log2(u_xlat0.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(0.0<u_xlat0.x);
					#else
					    u_xlatb0 = 0.0<u_xlat0.x;
					#endif
					    u_xlat5.x = u_xlat5.x * u_xlat4.w;
					    u_xlat5.x = u_xlat5.x * 0.693147182 + u_xlat4.z;
					    u_xlat5.x = u_xlat5.x * 1.44269502;
					    u_xlat5.x = exp2(u_xlat5.x);
					    u_xlat0.x = u_xlatb0 ? u_xlat5.x : float(0.0);
					    u_xlat1.y = u_xlat0.x * u_xlat2.w + u_xlat2.y;
					    SV_Target0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
					    SV_Target0.w = 1.0;
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "TONEMAPPING_CUSTOM" }
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
					uniform 	vec4 _Lut2D_Params;
					uniform 	vec3 _ColorBalance;
					uniform 	vec3 _ColorFilter;
					uniform 	vec3 _HueSatCon;
					uniform 	vec3 _ChannelMixerRed;
					uniform 	vec3 _ChannelMixerGreen;
					uniform 	vec3 _ChannelMixerBlue;
					uniform 	vec3 _Lift;
					uniform 	vec3 _InvGamma;
					uniform 	vec3 _Gain;
					uniform 	vec4 _CustomToneCurve;
					uniform 	vec4 _ToeSegmentA;
					uniform 	vec4 _ToeSegmentB;
					uniform 	vec4 _MidSegmentA;
					uniform 	vec4 _MidSegmentB;
					uniform 	vec4 _ShoSegmentA;
					uniform 	vec4 _ShoSegmentB;
					uniform mediump sampler2D _Curves;
					in highp vec2 vs_TEXCOORD0;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb5;
					vec3 u_xlat6;
					float u_xlat10;
					bool u_xlatb10;
					bvec2 u_xlatb11;
					vec2 u_xlat12;
					vec2 u_xlat13;
					float u_xlat15;
					bool u_xlatb15;
					void main()
					{
					    u_xlat0.yz = vs_TEXCOORD0.xy + (-_Lut2D_Params.yz);
					    u_xlat1.x = u_xlat0.y * _Lut2D_Params.x;
					    u_xlat0.x = fract(u_xlat1.x);
					    u_xlat1.x = u_xlat0.x / _Lut2D_Params.x;
					    u_xlat0.w = u_xlat0.y + (-u_xlat1.x);
					    u_xlat0.xyz = u_xlat0.xzw * _Lut2D_Params.www + vec3(-0.413588405, -0.413588405, -0.413588405);
					    u_xlat0.xyz = u_xlat0.xyz * _HueSatCon.zzz + vec3(0.0275523961, 0.0275523961, 0.0275523961);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(13.6054821, 13.6054821, 13.6054821);
					    u_xlat0.xyz = exp2(u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(-0.0479959995, -0.0479959995, -0.0479959995);
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.179999992, 0.179999992, 0.179999992);
					    u_xlat1.x = dot(vec3(0.390404999, 0.549941003, 0.00892631989), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(0.070841603, 0.963172019, 0.00135775004), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(0.0231081992, 0.128021002, 0.936245024), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorBalance.xyz;
					    u_xlat1.x = dot(vec3(2.85846996, -1.62879002, -0.0248910002), u_xlat0.xyz);
					    u_xlat1.y = dot(vec3(-0.210181996, 1.15820003, 0.000324280991), u_xlat0.xyz);
					    u_xlat1.z = dot(vec3(-0.0418119989, -0.118169002, 1.06867003), u_xlat0.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _ColorFilter.xyz;
					    u_xlat1.x = dot(u_xlat0.xyz, _ChannelMixerRed.xyz);
					    u_xlat1.y = dot(u_xlat0.xyz, _ChannelMixerGreen.xyz);
					    u_xlat1.z = dot(u_xlat0.xyz, _ChannelMixerBlue.xyz);
					    u_xlat0.xyz = u_xlat1.xyz * _Gain.xyz + _Lift.xyz;
					    u_xlat1.xyz = log2(abs(u_xlat0.xyz));
					    u_xlat0.xyz = u_xlat0.xyz * vec3(3.40282347e+38, 3.40282347e+38, 3.40282347e+38) + vec3(0.5, 0.5, 0.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xyz = min(max(u_xlat0.xyz, 0.0), 1.0);
					#else
					    u_xlat0.xyz = clamp(u_xlat0.xyz, 0.0, 1.0);
					#endif
					    u_xlat0.xyz = u_xlat0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
					    u_xlat1.xyz = u_xlat1.xyz * _InvGamma.xyz;
					    u_xlat1.xyz = exp2(u_xlat1.xyz);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb15 = !!(u_xlat0.y>=u_xlat0.z);
					#else
					    u_xlatb15 = u_xlat0.y>=u_xlat0.z;
					#endif
					    u_xlat15 = u_xlatb15 ? 1.0 : float(0.0);
					    u_xlat1.xy = u_xlat0.zy;
					    u_xlat2.xy = u_xlat0.yz + (-u_xlat1.xy);
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.666666687);
					    u_xlat2.z = float(1.0);
					    u_xlat2.w = float(-1.0);
					    u_xlat1 = vec4(u_xlat15) * u_xlat2.xywz + u_xlat1.xywz;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb15 = !!(u_xlat0.x>=u_xlat1.x);
					#else
					    u_xlatb15 = u_xlat0.x>=u_xlat1.x;
					#endif
					    u_xlat15 = u_xlatb15 ? 1.0 : float(0.0);
					    u_xlat2.z = u_xlat1.w;
					    u_xlat1.w = u_xlat0.x;
					    u_xlat3.x = dot(u_xlat0.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat2.xyw = u_xlat1.wyx;
					    u_xlat2 = (-u_xlat1) + u_xlat2;
					    u_xlat0 = vec4(u_xlat15) * u_xlat2 + u_xlat1;
					    u_xlat1.x = min(u_xlat0.y, u_xlat0.w);
					    u_xlat1.x = u_xlat0.x + (-u_xlat1.x);
					    u_xlat6.x = u_xlat1.x * 6.0 + 9.99999975e-05;
					    u_xlat5.x = (-u_xlat0.y) + u_xlat0.w;
					    u_xlat5.x = u_xlat5.x / u_xlat6.x;
					    u_xlat5.x = u_xlat5.x + u_xlat0.z;
					    u_xlat2.x = abs(u_xlat5.x);
					    u_xlat13.x = u_xlat2.x + _HueSatCon.x;
					    u_xlat3.y = float(0.25);
					    u_xlat13.y = float(0.25);
					    u_xlat5.x = textureLod(_Curves, u_xlat13.xy, 0.0).x;
					    u_xlat5.y = textureLod(_Curves, u_xlat3.xy, 0.0).w;
					    u_xlat5.xy = u_xlat5.xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat5.xy = min(max(u_xlat5.xy, 0.0), 1.0);
					#else
					    u_xlat5.xy = clamp(u_xlat5.xy, 0.0, 1.0);
					#endif
					    u_xlat5.x = u_xlat13.x + u_xlat5.x;
					    u_xlat6.xyz = u_xlat5.xxx + vec3(-0.5, 0.5, -1.5);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb5 = !!(1.0<u_xlat6.x);
					#else
					    u_xlatb5 = 1.0<u_xlat6.x;
					#endif
					    u_xlat5.x = (u_xlatb5) ? u_xlat6.z : u_xlat6.x;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb15 = !!(u_xlat6.x<0.0);
					#else
					    u_xlatb15 = u_xlat6.x<0.0;
					#endif
					    u_xlat5.x = (u_xlatb15) ? u_xlat6.y : u_xlat5.x;
					    u_xlat6.xyz = u_xlat5.xxx + vec3(1.0, 0.666666687, 0.333333343);
					    u_xlat6.xyz = fract(u_xlat6.xyz);
					    u_xlat6.xyz = u_xlat6.xyz * vec3(6.0, 6.0, 6.0) + vec3(-3.0, -3.0, -3.0);
					    u_xlat6.xyz = abs(u_xlat6.xyz) + vec3(-1.0, -1.0, -1.0);
					#ifdef UNITY_ADRENO_ES3
					    u_xlat6.xyz = min(max(u_xlat6.xyz, 0.0), 1.0);
					#else
					    u_xlat6.xyz = clamp(u_xlat6.xyz, 0.0, 1.0);
					#endif
					    u_xlat6.xyz = u_xlat6.xyz + vec3(-1.0, -1.0, -1.0);
					    u_xlat5.x = u_xlat0.x + 9.99999975e-05;
					    u_xlat12.x = u_xlat1.x / u_xlat5.x;
					    u_xlat1.xyz = u_xlat12.xxx * u_xlat6.xyz + vec3(1.0, 1.0, 1.0);
					    u_xlat3.xyz = u_xlat0.xxx * u_xlat1.xyz;
					    u_xlat5.x = dot(u_xlat3.xyz, vec3(0.212672904, 0.715152204, 0.0721750036));
					    u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz + (-u_xlat5.xxx);
					    u_xlat2.y = float(0.25);
					    u_xlat12.y = float(0.25);
					    u_xlat0.x = textureLod(_Curves, u_xlat2.xy, 0.0).y;
					    u_xlat0.w = textureLod(_Curves, u_xlat12.xy, 0.0).z;
					    u_xlat0.xw = u_xlat0.xw;
					#ifdef UNITY_ADRENO_ES3
					    u_xlat0.xw = min(max(u_xlat0.xw, 0.0), 1.0);
					#else
					    u_xlat0.xw = clamp(u_xlat0.xw, 0.0, 1.0);
					#endif
					    u_xlat0.x = u_xlat0.x + u_xlat0.x;
					    u_xlat0.x = dot(u_xlat0.ww, u_xlat0.xx);
					    u_xlat0.x = u_xlat0.x * u_xlat5.y;
					    u_xlat0.x = dot(_HueSatCon.yy, u_xlat0.xx);
					    u_xlat0.xyz = u_xlat0.xxx * u_xlat1.xyz + u_xlat5.xxx;
					    u_xlat0.xyz = max(u_xlat0.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat1.xyz = u_xlat0.xyz * _CustomToneCurve.xxx;
					    u_xlatb11.xy = lessThan(u_xlat1.zzzz, _CustomToneCurve.yzyz).xy;
					    u_xlatb2 = lessThan(u_xlat1.xxyy, _CustomToneCurve.yzyz);
					    u_xlat3 = (u_xlatb11.y) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat3 = (u_xlatb11.x) ? _ToeSegmentA : u_xlat3;
					    u_xlat10 = u_xlat0.z * _CustomToneCurve.x + (-u_xlat3.x);
					    u_xlat10 = u_xlat3.z * u_xlat10;
					    u_xlat15 = log2(u_xlat10);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb10 = !!(0.0<u_xlat10);
					#else
					    u_xlatb10 = 0.0<u_xlat10;
					#endif
					    u_xlat1.xy = (u_xlatb11.y) ? _MidSegmentB.xy : _ShoSegmentB.xy;
					    u_xlat1.xy = (u_xlatb11.x) ? _ToeSegmentB.xy : u_xlat1.xy;
					    u_xlat15 = u_xlat15 * u_xlat1.y;
					    u_xlat15 = u_xlat15 * 0.693147182 + u_xlat1.x;
					    u_xlat15 = u_xlat15 * 1.44269502;
					    u_xlat15 = exp2(u_xlat15);
					    u_xlat10 = u_xlatb10 ? u_xlat15 : float(0.0);
					    u_xlat1.z = u_xlat10 * u_xlat3.w + u_xlat3.y;
					    u_xlat3 = (u_xlatb2.y) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat3 = (u_xlatb2.x) ? _ToeSegmentA : u_xlat3;
					    u_xlat0.x = u_xlat0.x * _CustomToneCurve.x + (-u_xlat3.x);
					    u_xlat0.x = u_xlat3.z * u_xlat0.x;
					    u_xlat10 = log2(u_xlat0.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(0.0<u_xlat0.x);
					#else
					    u_xlatb0 = 0.0<u_xlat0.x;
					#endif
					    u_xlat4.x = (u_xlatb2.y) ? _MidSegmentB.x : _ShoSegmentB.x;
					    u_xlat4.y = (u_xlatb2.y) ? _MidSegmentB.y : _ShoSegmentB.y;
					    u_xlat4.z = (u_xlatb2.w) ? _MidSegmentB.x : _ShoSegmentB.x;
					    u_xlat4.w = (u_xlatb2.w) ? _MidSegmentB.y : _ShoSegmentB.y;
					    {
					        vec4 hlslcc_movcTemp = u_xlat4;
					        hlslcc_movcTemp.x = (u_xlatb2.x) ? _ToeSegmentB.x : u_xlat4.x;
					        hlslcc_movcTemp.y = (u_xlatb2.x) ? _ToeSegmentB.y : u_xlat4.y;
					        hlslcc_movcTemp.z = (u_xlatb2.z) ? _ToeSegmentB.x : u_xlat4.z;
					        hlslcc_movcTemp.w = (u_xlatb2.z) ? _ToeSegmentB.y : u_xlat4.w;
					        u_xlat4 = hlslcc_movcTemp;
					    }
					    u_xlat10 = u_xlat10 * u_xlat4.y;
					    u_xlat10 = u_xlat10 * 0.693147182 + u_xlat4.x;
					    u_xlat10 = u_xlat10 * 1.44269502;
					    u_xlat10 = exp2(u_xlat10);
					    u_xlat0.x = u_xlatb0 ? u_xlat10 : float(0.0);
					    u_xlat1.x = u_xlat0.x * u_xlat3.w + u_xlat3.y;
					    u_xlat3 = (u_xlatb2.w) ? _MidSegmentA : _ShoSegmentA;
					    u_xlat2 = (u_xlatb2.z) ? _ToeSegmentA : u_xlat3;
					    u_xlat0.x = u_xlat0.y * _CustomToneCurve.x + (-u_xlat2.x);
					    u_xlat0.x = u_xlat2.z * u_xlat0.x;
					    u_xlat5.x = log2(u_xlat0.x);
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(0.0<u_xlat0.x);
					#else
					    u_xlatb0 = 0.0<u_xlat0.x;
					#endif
					    u_xlat5.x = u_xlat5.x * u_xlat4.w;
					    u_xlat5.x = u_xlat5.x * 0.693147182 + u_xlat4.z;
					    u_xlat5.x = u_xlat5.x * 1.44269502;
					    u_xlat5.x = exp2(u_xlat5.x);
					    u_xlat0.x = u_xlatb0 ? u_xlat5.x : float(0.0);
					    u_xlat1.y = u_xlat0.x * u_xlat2.w + u_xlat2.y;
					    SV_Target0.xyz = max(u_xlat1.xyz, vec3(0.0, 0.0, 0.0));
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
				SubProgram "gles hw_tier00 " {
					Keywords { "TONEMAPPING_ACES" }
					"!!GLES"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "TONEMAPPING_ACES" }
					"!!GLES"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "TONEMAPPING_ACES" }
					"!!GLES"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "TONEMAPPING_ACES" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "TONEMAPPING_ACES" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "TONEMAPPING_ACES" }
					"!!GLES3"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
					"!!GLES"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
					"!!GLES"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
					"!!GLES"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "TONEMAPPING_NEUTRAL" }
					"!!GLES3"
				}
				SubProgram "gles hw_tier00 " {
					Keywords { "TONEMAPPING_CUSTOM" }
					"!!GLES"
				}
				SubProgram "gles hw_tier01 " {
					Keywords { "TONEMAPPING_CUSTOM" }
					"!!GLES"
				}
				SubProgram "gles hw_tier02 " {
					Keywords { "TONEMAPPING_CUSTOM" }
					"!!GLES"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "TONEMAPPING_CUSTOM" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "TONEMAPPING_CUSTOM" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "TONEMAPPING_CUSTOM" }
					"!!GLES3"
				}
			}
		}
	}
}