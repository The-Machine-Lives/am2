Shader "Hidden/PostProcessing/Copy" {
	Properties {
	}
	SubShader {
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 22111
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
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					void main()
					{
					    SV_Target0 = texture2D(_MainTex, vs_TEXCOORD1.xy);
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
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					void main()
					{
					    SV_Target0 = texture2D(_MainTex, vs_TEXCOORD1.xy);
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
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					void main()
					{
					    SV_Target0 = texture2D(_MainTex, vs_TEXCOORD1.xy);
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
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					void main()
					{
					    SV_Target0 = texture(_MainTex, vs_TEXCOORD1.xy);
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
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					void main()
					{
					    SV_Target0 = texture(_MainTex, vs_TEXCOORD1.xy);
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
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					void main()
					{
					    SV_Target0 = texture(_MainTex, vs_TEXCOORD1.xy);
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
			GpuProgramID 123322
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
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					ivec4 u_xlati1;
					bvec4 u_xlatb1;
					bvec4 u_xlatb2;
					const int BITWISE_BIT_COUNT = 32;
					int op_modi(int x, int y) { return x - y * (x / y); }
					ivec2 op_modi(ivec2 a, ivec2 b) { a.x = op_modi(a.x, b.x); a.y = op_modi(a.y, b.y); return a; }
					ivec3 op_modi(ivec3 a, ivec3 b) { a.x = op_modi(a.x, b.x); a.y = op_modi(a.y, b.y); a.z = op_modi(a.z, b.z); return a; }
					ivec4 op_modi(ivec4 a, ivec4 b) { a.x = op_modi(a.x, b.x); a.y = op_modi(a.y, b.y); a.z = op_modi(a.z, b.z); a.w = op_modi(a.w, b.w); return a; }
					
					int op_or(int a, int b) { int result = 0; int n = 1; for (int i = 0; i < BITWISE_BIT_COUNT; i++) { if ((op_modi(a, 2) != 0) || (op_modi(b, 2) != 0)) { result += n; } a = a / 2; b = b / 2; n = n * 2; if (!(a > 0 || b > 0)) { break; } } return result; }
					ivec2 op_or(ivec2 a, ivec2 b) { a.x = op_or(a.x, b.x); a.y = op_or(a.y, b.y); return a; }
					ivec3 op_or(ivec3 a, ivec3 b) { a.x = op_or(a.x, b.x); a.y = op_or(a.y, b.y); a.z = op_or(a.z, b.z); return a; }
					ivec4 op_or(ivec4 a, ivec4 b) { a.x = op_or(a.x, b.x); a.y = op_or(a.y, b.y); a.z = op_or(a.z, b.z); a.w = op_or(a.w, b.w); return a; }
					
					void main()
					{
					    u_xlat0 = texture2D(_MainTex, vs_TEXCOORD1.xy);
					    u_xlatb1 = lessThan(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlatb2 = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0);
					    u_xlati1 = op_or((ivec4(u_xlatb1) * -1), (ivec4(u_xlatb2) * -1));
					    u_xlatb2 = equal(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlati1 = op_or(u_xlati1, (ivec4(u_xlatb2) * -1));
					    u_xlatb1 = equal(u_xlati1, ivec4(0, 0, 0, 0));
					    u_xlatb1.x = u_xlatb1.y || u_xlatb1.x;
					    u_xlatb1.x = u_xlatb1.z || u_xlatb1.x;
					    u_xlatb1.x = u_xlatb1.w || u_xlatb1.x;
					    SV_Target0 = (u_xlatb1.x) ? vec4(0.0, 0.0, 0.0, 0.0) : u_xlat0;
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
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					ivec4 u_xlati1;
					bvec4 u_xlatb1;
					bvec4 u_xlatb2;
					const int BITWISE_BIT_COUNT = 32;
					int op_modi(int x, int y) { return x - y * (x / y); }
					ivec2 op_modi(ivec2 a, ivec2 b) { a.x = op_modi(a.x, b.x); a.y = op_modi(a.y, b.y); return a; }
					ivec3 op_modi(ivec3 a, ivec3 b) { a.x = op_modi(a.x, b.x); a.y = op_modi(a.y, b.y); a.z = op_modi(a.z, b.z); return a; }
					ivec4 op_modi(ivec4 a, ivec4 b) { a.x = op_modi(a.x, b.x); a.y = op_modi(a.y, b.y); a.z = op_modi(a.z, b.z); a.w = op_modi(a.w, b.w); return a; }
					
					int op_or(int a, int b) { int result = 0; int n = 1; for (int i = 0; i < BITWISE_BIT_COUNT; i++) { if ((op_modi(a, 2) != 0) || (op_modi(b, 2) != 0)) { result += n; } a = a / 2; b = b / 2; n = n * 2; if (!(a > 0 || b > 0)) { break; } } return result; }
					ivec2 op_or(ivec2 a, ivec2 b) { a.x = op_or(a.x, b.x); a.y = op_or(a.y, b.y); return a; }
					ivec3 op_or(ivec3 a, ivec3 b) { a.x = op_or(a.x, b.x); a.y = op_or(a.y, b.y); a.z = op_or(a.z, b.z); return a; }
					ivec4 op_or(ivec4 a, ivec4 b) { a.x = op_or(a.x, b.x); a.y = op_or(a.y, b.y); a.z = op_or(a.z, b.z); a.w = op_or(a.w, b.w); return a; }
					
					void main()
					{
					    u_xlat0 = texture2D(_MainTex, vs_TEXCOORD1.xy);
					    u_xlatb1 = lessThan(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlatb2 = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0);
					    u_xlati1 = op_or((ivec4(u_xlatb1) * -1), (ivec4(u_xlatb2) * -1));
					    u_xlatb2 = equal(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlati1 = op_or(u_xlati1, (ivec4(u_xlatb2) * -1));
					    u_xlatb1 = equal(u_xlati1, ivec4(0, 0, 0, 0));
					    u_xlatb1.x = u_xlatb1.y || u_xlatb1.x;
					    u_xlatb1.x = u_xlatb1.z || u_xlatb1.x;
					    u_xlatb1.x = u_xlatb1.w || u_xlatb1.x;
					    SV_Target0 = (u_xlatb1.x) ? vec4(0.0, 0.0, 0.0, 0.0) : u_xlat0;
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
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					ivec4 u_xlati1;
					bvec4 u_xlatb1;
					bvec4 u_xlatb2;
					const int BITWISE_BIT_COUNT = 32;
					int op_modi(int x, int y) { return x - y * (x / y); }
					ivec2 op_modi(ivec2 a, ivec2 b) { a.x = op_modi(a.x, b.x); a.y = op_modi(a.y, b.y); return a; }
					ivec3 op_modi(ivec3 a, ivec3 b) { a.x = op_modi(a.x, b.x); a.y = op_modi(a.y, b.y); a.z = op_modi(a.z, b.z); return a; }
					ivec4 op_modi(ivec4 a, ivec4 b) { a.x = op_modi(a.x, b.x); a.y = op_modi(a.y, b.y); a.z = op_modi(a.z, b.z); a.w = op_modi(a.w, b.w); return a; }
					
					int op_or(int a, int b) { int result = 0; int n = 1; for (int i = 0; i < BITWISE_BIT_COUNT; i++) { if ((op_modi(a, 2) != 0) || (op_modi(b, 2) != 0)) { result += n; } a = a / 2; b = b / 2; n = n * 2; if (!(a > 0 || b > 0)) { break; } } return result; }
					ivec2 op_or(ivec2 a, ivec2 b) { a.x = op_or(a.x, b.x); a.y = op_or(a.y, b.y); return a; }
					ivec3 op_or(ivec3 a, ivec3 b) { a.x = op_or(a.x, b.x); a.y = op_or(a.y, b.y); a.z = op_or(a.z, b.z); return a; }
					ivec4 op_or(ivec4 a, ivec4 b) { a.x = op_or(a.x, b.x); a.y = op_or(a.y, b.y); a.z = op_or(a.z, b.z); a.w = op_or(a.w, b.w); return a; }
					
					void main()
					{
					    u_xlat0 = texture2D(_MainTex, vs_TEXCOORD1.xy);
					    u_xlatb1 = lessThan(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlatb2 = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0);
					    u_xlati1 = op_or((ivec4(u_xlatb1) * -1), (ivec4(u_xlatb2) * -1));
					    u_xlatb2 = equal(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlati1 = op_or(u_xlati1, (ivec4(u_xlatb2) * -1));
					    u_xlatb1 = equal(u_xlati1, ivec4(0, 0, 0, 0));
					    u_xlatb1.x = u_xlatb1.y || u_xlatb1.x;
					    u_xlatb1.x = u_xlatb1.z || u_xlatb1.x;
					    u_xlatb1.x = u_xlatb1.w || u_xlatb1.x;
					    SV_Target0 = (u_xlatb1.x) ? vec4(0.0, 0.0, 0.0, 0.0) : u_xlat0;
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
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					ivec4 u_xlati1;
					bvec4 u_xlatb1;
					bvec4 u_xlatb2;
					void main()
					{
					    u_xlat0 = texture(_MainTex, vs_TEXCOORD1.xy);
					    u_xlatb1 = lessThan(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlatb2 = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0);
					    u_xlati1 = ivec4(uvec4((uint(u_xlatb1.x) * 0xffffffffu) | (uint(u_xlatb2.x) * 0xffffffffu), (uint(u_xlatb1.y) * 0xffffffffu) | (uint(u_xlatb2.y) * 0xffffffffu), (uint(u_xlatb1.z) * 0xffffffffu) | (uint(u_xlatb2.z) * 0xffffffffu), (uint(u_xlatb1.w) * 0xffffffffu) | (uint(u_xlatb2.w) * 0xffffffffu)));
					    u_xlatb2 = equal(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlati1 = ivec4(uvec4(uint(u_xlati1.x) | (uint(u_xlatb2.x) * 0xffffffffu), uint(u_xlati1.y) | (uint(u_xlatb2.y) * 0xffffffffu), uint(u_xlati1.z) | (uint(u_xlatb2.z) * 0xffffffffu), uint(u_xlati1.w) | (uint(u_xlatb2.w) * 0xffffffffu)));
					    u_xlatb1 = equal(u_xlati1, ivec4(0, 0, 0, 0));
					    u_xlatb1.x = u_xlatb1.y || u_xlatb1.x;
					    u_xlatb1.x = u_xlatb1.z || u_xlatb1.x;
					    u_xlatb1.x = u_xlatb1.w || u_xlatb1.x;
					    SV_Target0 = (u_xlatb1.x) ? vec4(0.0, 0.0, 0.0, 0.0) : u_xlat0;
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
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					ivec4 u_xlati1;
					bvec4 u_xlatb1;
					bvec4 u_xlatb2;
					void main()
					{
					    u_xlat0 = texture(_MainTex, vs_TEXCOORD1.xy);
					    u_xlatb1 = lessThan(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlatb2 = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0);
					    u_xlati1 = ivec4(uvec4((uint(u_xlatb1.x) * 0xffffffffu) | (uint(u_xlatb2.x) * 0xffffffffu), (uint(u_xlatb1.y) * 0xffffffffu) | (uint(u_xlatb2.y) * 0xffffffffu), (uint(u_xlatb1.z) * 0xffffffffu) | (uint(u_xlatb2.z) * 0xffffffffu), (uint(u_xlatb1.w) * 0xffffffffu) | (uint(u_xlatb2.w) * 0xffffffffu)));
					    u_xlatb2 = equal(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlati1 = ivec4(uvec4(uint(u_xlati1.x) | (uint(u_xlatb2.x) * 0xffffffffu), uint(u_xlati1.y) | (uint(u_xlatb2.y) * 0xffffffffu), uint(u_xlati1.z) | (uint(u_xlatb2.z) * 0xffffffffu), uint(u_xlati1.w) | (uint(u_xlatb2.w) * 0xffffffffu)));
					    u_xlatb1 = equal(u_xlati1, ivec4(0, 0, 0, 0));
					    u_xlatb1.x = u_xlatb1.y || u_xlatb1.x;
					    u_xlatb1.x = u_xlatb1.z || u_xlatb1.x;
					    u_xlatb1.x = u_xlatb1.w || u_xlatb1.x;
					    SV_Target0 = (u_xlatb1.x) ? vec4(0.0, 0.0, 0.0, 0.0) : u_xlat0;
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
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					ivec4 u_xlati1;
					bvec4 u_xlatb1;
					bvec4 u_xlatb2;
					void main()
					{
					    u_xlat0 = texture(_MainTex, vs_TEXCOORD1.xy);
					    u_xlatb1 = lessThan(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlatb2 = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0);
					    u_xlati1 = ivec4(uvec4((uint(u_xlatb1.x) * 0xffffffffu) | (uint(u_xlatb2.x) * 0xffffffffu), (uint(u_xlatb1.y) * 0xffffffffu) | (uint(u_xlatb2.y) * 0xffffffffu), (uint(u_xlatb1.z) * 0xffffffffu) | (uint(u_xlatb2.z) * 0xffffffffu), (uint(u_xlatb1.w) * 0xffffffffu) | (uint(u_xlatb2.w) * 0xffffffffu)));
					    u_xlatb2 = equal(u_xlat0, vec4(0.0, 0.0, 0.0, 0.0));
					    u_xlati1 = ivec4(uvec4(uint(u_xlati1.x) | (uint(u_xlatb2.x) * 0xffffffffu), uint(u_xlati1.y) | (uint(u_xlatb2.y) * 0xffffffffu), uint(u_xlati1.z) | (uint(u_xlatb2.z) * 0xffffffffu), uint(u_xlati1.w) | (uint(u_xlatb2.w) * 0xffffffffu)));
					    u_xlatb1 = equal(u_xlati1, ivec4(0, 0, 0, 0));
					    u_xlatb1.x = u_xlatb1.y || u_xlatb1.x;
					    u_xlatb1.x = u_xlatb1.z || u_xlatb1.x;
					    u_xlatb1.x = u_xlatb1.w || u_xlatb1.x;
					    SV_Target0 = (u_xlatb1.x) ? vec4(0.0, 0.0, 0.0, 0.0) : u_xlat0;
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