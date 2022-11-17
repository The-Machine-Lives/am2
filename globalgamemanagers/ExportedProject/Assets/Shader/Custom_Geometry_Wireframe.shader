Shader "Custom/Geometry/Wireframe" {
	Properties {
		[PowerSlider(3.0)] _WireframeVal ("Wireframe width", Range(0, 0.5)) = 0.05
		_FrontColor ("Front color", Vector) = (1,1,1,1)
		_BackColor ("Back color", Vector) = (1,1,1,1)
		[Toggle] _RemoveDiag ("Remove diagonals?", Float) = 0
	}
	SubShader {
		Tags { "QUEUE" = "Geometry" "RenderType" = "Opaque" }
		0 {
			Tags { "QUEUE" = "Geometry" "RenderType" = "Opaque" }
			Cull Front
			GpuProgramID 24046
			Program "vp" {
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 310 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					in highp vec4 in_POSITION0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = hlslcc_mtx4x4unity_ObjectToWorld[3] * in_POSITION0.wwww + u_xlat0;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 310 es
					
					precision highp float;
					precision highp int;
					uniform 	float _WireframeVal;
					uniform 	mediump vec4 _BackColor;
					layout(location = 0) in highp vec3 gs_TEXCOORD0;
					layout(location = 0) out mediump vec4 SV_Target0;
					bvec3 u_xlatb0;
					void main()
					{
					    u_xlatb0.xyz = lessThan(gs_TEXCOORD0.xyzx, vec4(_WireframeVal)).xyz;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlatb0.x = u_xlatb0.z || u_xlatb0.x;
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))==0){discard;}
					    SV_Target0 = _BackColor;
					    return;
					}
					
					#endif
					#ifdef GEOMETRY
					#version 310 es
					#ifdef GL_ARB_geometry_shader
					#extension GL_ARB_geometry_shader : enable
					#endif
					#ifdef GL_OES_geometry_shader
					#extension GL_OES_geometry_shader : enable
					#endif
					#ifdef GL_EXT_geometry_shader
					#extension GL_EXT_geometry_shader : enable
					#endif
					
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					vec4 u_xlat0;
					layout(triangles) in;
					layout(triangle_strip) out;
					layout(location = 0) out highp vec3 gs_TEXCOORD0;
					layout(max_vertices = 3) out;
					void main()
					{
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[0].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[0].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[0].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[0].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(1.0, 0.0, 0.0);
					    EmitVertex();
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[1].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[1].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[1].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[1].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(0.0, 0.0, 1.0);
					    EmitVertex();
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[2].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[2].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[2].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[2].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(0.0, 1.0, 0.0);
					    EmitVertex();
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 310 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					in highp vec4 in_POSITION0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = hlslcc_mtx4x4unity_ObjectToWorld[3] * in_POSITION0.wwww + u_xlat0;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 310 es
					
					precision highp float;
					precision highp int;
					uniform 	float _WireframeVal;
					uniform 	mediump vec4 _BackColor;
					layout(location = 0) in highp vec3 gs_TEXCOORD0;
					layout(location = 0) out mediump vec4 SV_Target0;
					bvec3 u_xlatb0;
					void main()
					{
					    u_xlatb0.xyz = lessThan(gs_TEXCOORD0.xyzx, vec4(_WireframeVal)).xyz;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlatb0.x = u_xlatb0.z || u_xlatb0.x;
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))==0){discard;}
					    SV_Target0 = _BackColor;
					    return;
					}
					
					#endif
					#ifdef GEOMETRY
					#version 310 es
					#ifdef GL_ARB_geometry_shader
					#extension GL_ARB_geometry_shader : enable
					#endif
					#ifdef GL_OES_geometry_shader
					#extension GL_OES_geometry_shader : enable
					#endif
					#ifdef GL_EXT_geometry_shader
					#extension GL_EXT_geometry_shader : enable
					#endif
					
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					vec4 u_xlat0;
					layout(triangles) in;
					layout(triangle_strip) out;
					layout(location = 0) out highp vec3 gs_TEXCOORD0;
					layout(max_vertices = 3) out;
					void main()
					{
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[0].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[0].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[0].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[0].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(1.0, 0.0, 0.0);
					    EmitVertex();
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[1].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[1].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[1].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[1].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(0.0, 0.0, 1.0);
					    EmitVertex();
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[2].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[2].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[2].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[2].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(0.0, 1.0, 0.0);
					    EmitVertex();
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 310 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					in highp vec4 in_POSITION0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = hlslcc_mtx4x4unity_ObjectToWorld[3] * in_POSITION0.wwww + u_xlat0;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 310 es
					
					precision highp float;
					precision highp int;
					uniform 	float _WireframeVal;
					uniform 	mediump vec4 _BackColor;
					layout(location = 0) in highp vec3 gs_TEXCOORD0;
					layout(location = 0) out mediump vec4 SV_Target0;
					bvec3 u_xlatb0;
					void main()
					{
					    u_xlatb0.xyz = lessThan(gs_TEXCOORD0.xyzx, vec4(_WireframeVal)).xyz;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlatb0.x = u_xlatb0.z || u_xlatb0.x;
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))==0){discard;}
					    SV_Target0 = _BackColor;
					    return;
					}
					
					#endif
					#ifdef GEOMETRY
					#version 310 es
					#ifdef GL_ARB_geometry_shader
					#extension GL_ARB_geometry_shader : enable
					#endif
					#ifdef GL_OES_geometry_shader
					#extension GL_OES_geometry_shader : enable
					#endif
					#ifdef GL_EXT_geometry_shader
					#extension GL_EXT_geometry_shader : enable
					#endif
					
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					vec4 u_xlat0;
					layout(triangles) in;
					layout(triangle_strip) out;
					layout(location = 0) out highp vec3 gs_TEXCOORD0;
					layout(max_vertices = 3) out;
					void main()
					{
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[0].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[0].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[0].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[0].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(1.0, 0.0, 0.0);
					    EmitVertex();
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[1].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[1].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[1].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[1].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(0.0, 0.0, 1.0);
					    EmitVertex();
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[2].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[2].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[2].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[2].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(0.0, 1.0, 0.0);
					    EmitVertex();
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 310 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					in highp vec4 in_POSITION0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = hlslcc_mtx4x4unity_ObjectToWorld[3] * in_POSITION0.wwww + u_xlat0;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 310 es
					
					precision highp float;
					precision highp int;
					uniform 	float _WireframeVal;
					uniform 	mediump vec4 _BackColor;
					layout(location = 0) in highp vec3 gs_TEXCOORD0;
					layout(location = 0) out mediump vec4 SV_Target0;
					bvec3 u_xlatb0;
					void main()
					{
					    u_xlatb0.xyz = lessThan(gs_TEXCOORD0.xyzx, vec4(_WireframeVal)).xyz;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlatb0.x = u_xlatb0.z || u_xlatb0.x;
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))==0){discard;}
					    SV_Target0 = _BackColor;
					    return;
					}
					
					#endif
					#ifdef GEOMETRY
					#version 310 es
					#ifdef GL_ARB_geometry_shader
					#extension GL_ARB_geometry_shader : enable
					#endif
					#ifdef GL_OES_geometry_shader
					#extension GL_OES_geometry_shader : enable
					#endif
					#ifdef GL_EXT_geometry_shader
					#extension GL_EXT_geometry_shader : enable
					#endif
					
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					vec4 u_xlat0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					bool u_xlatb1;
					bool u_xlatb2;
					bool u_xlatb4;
					float u_xlat6;
					layout(triangles) in;
					layout(triangle_strip) out;
					layout(location = 0) out highp vec3 gs_TEXCOORD0;
					layout(max_vertices = 3) out;
					void main()
					{
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[0].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[0].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[0].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[0].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    u_xlat0 = (-gl_in[0].gl_Position) + gl_in[2].gl_Position;
					    u_xlat0.x = dot(u_xlat0, u_xlat0);
					    u_xlat1 = (-gl_in[2].gl_Position) + gl_in[1].gl_Position;
					    u_xlat0.y = dot(u_xlat1, u_xlat1);
					    u_xlat0.xy = sqrt(u_xlat0.xy);
					    u_xlatb4 = u_xlat0.x<u_xlat0.y;
					    u_xlat1 = (-gl_in[1].gl_Position) + gl_in[0].gl_Position;
					    u_xlat6 = dot(u_xlat1, u_xlat1);
					    u_xlat6 = sqrt(u_xlat6);
					    u_xlatb1 = u_xlat6<u_xlat0.y;
					    u_xlatb0.xy = lessThan(u_xlat0.xyxx, vec4(u_xlat6)).xy;
					    u_xlatb0.x = u_xlatb0.x && u_xlatb0.y;
					    u_xlatb2 = u_xlatb4 && u_xlatb1;
					    u_xlat1.xz = (bool(u_xlatb2)) ? vec2(1.0, 0.0) : vec2(0.0, 1.0);
					    u_xlat1.y = 0.0;
					    u_xlat0.xyz = (u_xlatb0.x) ? vec3(0.0, 1.0, 0.0) : u_xlat1.xyz;
					    u_xlat1.xyz = u_xlat0.xyz + vec3(1.0, 0.0, 0.0);
					    gs_TEXCOORD0.xyz = u_xlat1.xyz;
					    EmitVertex();
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[1].gl_Position.yyyy;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[1].gl_Position.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[1].gl_Position.zzzz + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[1].gl_Position.wwww + u_xlat1;
					    gl_Position = u_xlat1;
					    u_xlat1.xyz = u_xlat0.xyz + vec3(0.0, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.0, 1.0, 0.0);
					    gs_TEXCOORD0.xyz = u_xlat1.xyz;
					    EmitVertex();
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[2].gl_Position.yyyy;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[2].gl_Position.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[2].gl_Position.zzzz + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[2].gl_Position.wwww + u_xlat1;
					    gl_Position = u_xlat1;
					    gs_TEXCOORD0.xyz = u_xlat0.xyz;
					    EmitVertex();
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 310 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					in highp vec4 in_POSITION0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = hlslcc_mtx4x4unity_ObjectToWorld[3] * in_POSITION0.wwww + u_xlat0;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 310 es
					
					precision highp float;
					precision highp int;
					uniform 	float _WireframeVal;
					uniform 	mediump vec4 _BackColor;
					layout(location = 0) in highp vec3 gs_TEXCOORD0;
					layout(location = 0) out mediump vec4 SV_Target0;
					bvec3 u_xlatb0;
					void main()
					{
					    u_xlatb0.xyz = lessThan(gs_TEXCOORD0.xyzx, vec4(_WireframeVal)).xyz;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlatb0.x = u_xlatb0.z || u_xlatb0.x;
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))==0){discard;}
					    SV_Target0 = _BackColor;
					    return;
					}
					
					#endif
					#ifdef GEOMETRY
					#version 310 es
					#ifdef GL_ARB_geometry_shader
					#extension GL_ARB_geometry_shader : enable
					#endif
					#ifdef GL_OES_geometry_shader
					#extension GL_OES_geometry_shader : enable
					#endif
					#ifdef GL_EXT_geometry_shader
					#extension GL_EXT_geometry_shader : enable
					#endif
					
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					vec4 u_xlat0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					bool u_xlatb1;
					bool u_xlatb2;
					bool u_xlatb4;
					float u_xlat6;
					layout(triangles) in;
					layout(triangle_strip) out;
					layout(location = 0) out highp vec3 gs_TEXCOORD0;
					layout(max_vertices = 3) out;
					void main()
					{
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[0].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[0].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[0].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[0].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    u_xlat0 = (-gl_in[0].gl_Position) + gl_in[2].gl_Position;
					    u_xlat0.x = dot(u_xlat0, u_xlat0);
					    u_xlat1 = (-gl_in[2].gl_Position) + gl_in[1].gl_Position;
					    u_xlat0.y = dot(u_xlat1, u_xlat1);
					    u_xlat0.xy = sqrt(u_xlat0.xy);
					    u_xlatb4 = u_xlat0.x<u_xlat0.y;
					    u_xlat1 = (-gl_in[1].gl_Position) + gl_in[0].gl_Position;
					    u_xlat6 = dot(u_xlat1, u_xlat1);
					    u_xlat6 = sqrt(u_xlat6);
					    u_xlatb1 = u_xlat6<u_xlat0.y;
					    u_xlatb0.xy = lessThan(u_xlat0.xyxx, vec4(u_xlat6)).xy;
					    u_xlatb0.x = u_xlatb0.x && u_xlatb0.y;
					    u_xlatb2 = u_xlatb4 && u_xlatb1;
					    u_xlat1.xz = (bool(u_xlatb2)) ? vec2(1.0, 0.0) : vec2(0.0, 1.0);
					    u_xlat1.y = 0.0;
					    u_xlat0.xyz = (u_xlatb0.x) ? vec3(0.0, 1.0, 0.0) : u_xlat1.xyz;
					    u_xlat1.xyz = u_xlat0.xyz + vec3(1.0, 0.0, 0.0);
					    gs_TEXCOORD0.xyz = u_xlat1.xyz;
					    EmitVertex();
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[1].gl_Position.yyyy;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[1].gl_Position.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[1].gl_Position.zzzz + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[1].gl_Position.wwww + u_xlat1;
					    gl_Position = u_xlat1;
					    u_xlat1.xyz = u_xlat0.xyz + vec3(0.0, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.0, 1.0, 0.0);
					    gs_TEXCOORD0.xyz = u_xlat1.xyz;
					    EmitVertex();
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[2].gl_Position.yyyy;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[2].gl_Position.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[2].gl_Position.zzzz + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[2].gl_Position.wwww + u_xlat1;
					    gl_Position = u_xlat1;
					    gs_TEXCOORD0.xyz = u_xlat0.xyz;
					    EmitVertex();
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 310 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					in highp vec4 in_POSITION0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = hlslcc_mtx4x4unity_ObjectToWorld[3] * in_POSITION0.wwww + u_xlat0;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 310 es
					
					precision highp float;
					precision highp int;
					uniform 	float _WireframeVal;
					uniform 	mediump vec4 _BackColor;
					layout(location = 0) in highp vec3 gs_TEXCOORD0;
					layout(location = 0) out mediump vec4 SV_Target0;
					bvec3 u_xlatb0;
					void main()
					{
					    u_xlatb0.xyz = lessThan(gs_TEXCOORD0.xyzx, vec4(_WireframeVal)).xyz;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlatb0.x = u_xlatb0.z || u_xlatb0.x;
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))==0){discard;}
					    SV_Target0 = _BackColor;
					    return;
					}
					
					#endif
					#ifdef GEOMETRY
					#version 310 es
					#ifdef GL_ARB_geometry_shader
					#extension GL_ARB_geometry_shader : enable
					#endif
					#ifdef GL_OES_geometry_shader
					#extension GL_OES_geometry_shader : enable
					#endif
					#ifdef GL_EXT_geometry_shader
					#extension GL_EXT_geometry_shader : enable
					#endif
					
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					vec4 u_xlat0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					bool u_xlatb1;
					bool u_xlatb2;
					bool u_xlatb4;
					float u_xlat6;
					layout(triangles) in;
					layout(triangle_strip) out;
					layout(location = 0) out highp vec3 gs_TEXCOORD0;
					layout(max_vertices = 3) out;
					void main()
					{
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[0].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[0].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[0].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[0].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    u_xlat0 = (-gl_in[0].gl_Position) + gl_in[2].gl_Position;
					    u_xlat0.x = dot(u_xlat0, u_xlat0);
					    u_xlat1 = (-gl_in[2].gl_Position) + gl_in[1].gl_Position;
					    u_xlat0.y = dot(u_xlat1, u_xlat1);
					    u_xlat0.xy = sqrt(u_xlat0.xy);
					    u_xlatb4 = u_xlat0.x<u_xlat0.y;
					    u_xlat1 = (-gl_in[1].gl_Position) + gl_in[0].gl_Position;
					    u_xlat6 = dot(u_xlat1, u_xlat1);
					    u_xlat6 = sqrt(u_xlat6);
					    u_xlatb1 = u_xlat6<u_xlat0.y;
					    u_xlatb0.xy = lessThan(u_xlat0.xyxx, vec4(u_xlat6)).xy;
					    u_xlatb0.x = u_xlatb0.x && u_xlatb0.y;
					    u_xlatb2 = u_xlatb4 && u_xlatb1;
					    u_xlat1.xz = (bool(u_xlatb2)) ? vec2(1.0, 0.0) : vec2(0.0, 1.0);
					    u_xlat1.y = 0.0;
					    u_xlat0.xyz = (u_xlatb0.x) ? vec3(0.0, 1.0, 0.0) : u_xlat1.xyz;
					    u_xlat1.xyz = u_xlat0.xyz + vec3(1.0, 0.0, 0.0);
					    gs_TEXCOORD0.xyz = u_xlat1.xyz;
					    EmitVertex();
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[1].gl_Position.yyyy;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[1].gl_Position.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[1].gl_Position.zzzz + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[1].gl_Position.wwww + u_xlat1;
					    gl_Position = u_xlat1;
					    u_xlat1.xyz = u_xlat0.xyz + vec3(0.0, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.0, 1.0, 0.0);
					    gs_TEXCOORD0.xyz = u_xlat1.xyz;
					    EmitVertex();
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[2].gl_Position.yyyy;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[2].gl_Position.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[2].gl_Position.zzzz + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[2].gl_Position.wwww + u_xlat1;
					    gl_Position = u_xlat1;
					    gs_TEXCOORD0.xyz = u_xlat0.xyz;
					    EmitVertex();
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
				SubProgram "gles3 hw_tier00 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3"
				}
			}
			Program "gp" {
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3"
				}
			}
		}
		0 {
			Tags { "QUEUE" = "Geometry" "RenderType" = "Opaque" }
			GpuProgramID 110552
			Program "vp" {
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 310 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					in highp vec4 in_POSITION0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = hlslcc_mtx4x4unity_ObjectToWorld[3] * in_POSITION0.wwww + u_xlat0;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 310 es
					
					precision highp float;
					precision highp int;
					uniform 	float _WireframeVal;
					uniform 	mediump vec4 _FrontColor;
					layout(location = 0) in highp vec3 gs_TEXCOORD0;
					layout(location = 0) out mediump vec4 SV_Target0;
					bvec3 u_xlatb0;
					void main()
					{
					    u_xlatb0.xyz = greaterThanEqual(vec4(_WireframeVal), gs_TEXCOORD0.xyzx).xyz;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlatb0.x = u_xlatb0.z || u_xlatb0.x;
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))==0){discard;}
					    SV_Target0 = _FrontColor;
					    return;
					}
					
					#endif
					#ifdef GEOMETRY
					#version 310 es
					#ifdef GL_ARB_geometry_shader
					#extension GL_ARB_geometry_shader : enable
					#endif
					#ifdef GL_OES_geometry_shader
					#extension GL_OES_geometry_shader : enable
					#endif
					#ifdef GL_EXT_geometry_shader
					#extension GL_EXT_geometry_shader : enable
					#endif
					
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					vec4 u_xlat0;
					layout(triangles) in;
					layout(triangle_strip) out;
					layout(location = 0) out highp vec3 gs_TEXCOORD0;
					layout(max_vertices = 3) out;
					void main()
					{
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[0].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[0].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[0].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[0].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(1.0, 0.0, 0.0);
					    EmitVertex();
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[1].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[1].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[1].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[1].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(0.0, 0.0, 1.0);
					    EmitVertex();
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[2].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[2].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[2].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[2].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(0.0, 1.0, 0.0);
					    EmitVertex();
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 310 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					in highp vec4 in_POSITION0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = hlslcc_mtx4x4unity_ObjectToWorld[3] * in_POSITION0.wwww + u_xlat0;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 310 es
					
					precision highp float;
					precision highp int;
					uniform 	float _WireframeVal;
					uniform 	mediump vec4 _FrontColor;
					layout(location = 0) in highp vec3 gs_TEXCOORD0;
					layout(location = 0) out mediump vec4 SV_Target0;
					bvec3 u_xlatb0;
					void main()
					{
					    u_xlatb0.xyz = greaterThanEqual(vec4(_WireframeVal), gs_TEXCOORD0.xyzx).xyz;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlatb0.x = u_xlatb0.z || u_xlatb0.x;
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))==0){discard;}
					    SV_Target0 = _FrontColor;
					    return;
					}
					
					#endif
					#ifdef GEOMETRY
					#version 310 es
					#ifdef GL_ARB_geometry_shader
					#extension GL_ARB_geometry_shader : enable
					#endif
					#ifdef GL_OES_geometry_shader
					#extension GL_OES_geometry_shader : enable
					#endif
					#ifdef GL_EXT_geometry_shader
					#extension GL_EXT_geometry_shader : enable
					#endif
					
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					vec4 u_xlat0;
					layout(triangles) in;
					layout(triangle_strip) out;
					layout(location = 0) out highp vec3 gs_TEXCOORD0;
					layout(max_vertices = 3) out;
					void main()
					{
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[0].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[0].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[0].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[0].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(1.0, 0.0, 0.0);
					    EmitVertex();
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[1].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[1].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[1].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[1].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(0.0, 0.0, 1.0);
					    EmitVertex();
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[2].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[2].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[2].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[2].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(0.0, 1.0, 0.0);
					    EmitVertex();
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 310 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					in highp vec4 in_POSITION0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = hlslcc_mtx4x4unity_ObjectToWorld[3] * in_POSITION0.wwww + u_xlat0;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 310 es
					
					precision highp float;
					precision highp int;
					uniform 	float _WireframeVal;
					uniform 	mediump vec4 _FrontColor;
					layout(location = 0) in highp vec3 gs_TEXCOORD0;
					layout(location = 0) out mediump vec4 SV_Target0;
					bvec3 u_xlatb0;
					void main()
					{
					    u_xlatb0.xyz = greaterThanEqual(vec4(_WireframeVal), gs_TEXCOORD0.xyzx).xyz;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlatb0.x = u_xlatb0.z || u_xlatb0.x;
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))==0){discard;}
					    SV_Target0 = _FrontColor;
					    return;
					}
					
					#endif
					#ifdef GEOMETRY
					#version 310 es
					#ifdef GL_ARB_geometry_shader
					#extension GL_ARB_geometry_shader : enable
					#endif
					#ifdef GL_OES_geometry_shader
					#extension GL_OES_geometry_shader : enable
					#endif
					#ifdef GL_EXT_geometry_shader
					#extension GL_EXT_geometry_shader : enable
					#endif
					
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					vec4 u_xlat0;
					layout(triangles) in;
					layout(triangle_strip) out;
					layout(location = 0) out highp vec3 gs_TEXCOORD0;
					layout(max_vertices = 3) out;
					void main()
					{
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[0].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[0].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[0].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[0].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(1.0, 0.0, 0.0);
					    EmitVertex();
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[1].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[1].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[1].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[1].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(0.0, 0.0, 1.0);
					    EmitVertex();
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[2].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[2].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[2].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[2].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    gs_TEXCOORD0.xyz = vec3(0.0, 1.0, 0.0);
					    EmitVertex();
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 310 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					in highp vec4 in_POSITION0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = hlslcc_mtx4x4unity_ObjectToWorld[3] * in_POSITION0.wwww + u_xlat0;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 310 es
					
					precision highp float;
					precision highp int;
					uniform 	float _WireframeVal;
					uniform 	mediump vec4 _FrontColor;
					layout(location = 0) in highp vec3 gs_TEXCOORD0;
					layout(location = 0) out mediump vec4 SV_Target0;
					bvec3 u_xlatb0;
					void main()
					{
					    u_xlatb0.xyz = greaterThanEqual(vec4(_WireframeVal), gs_TEXCOORD0.xyzx).xyz;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlatb0.x = u_xlatb0.z || u_xlatb0.x;
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))==0){discard;}
					    SV_Target0 = _FrontColor;
					    return;
					}
					
					#endif
					#ifdef GEOMETRY
					#version 310 es
					#ifdef GL_ARB_geometry_shader
					#extension GL_ARB_geometry_shader : enable
					#endif
					#ifdef GL_OES_geometry_shader
					#extension GL_OES_geometry_shader : enable
					#endif
					#ifdef GL_EXT_geometry_shader
					#extension GL_EXT_geometry_shader : enable
					#endif
					
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					vec4 u_xlat0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					bool u_xlatb1;
					bool u_xlatb2;
					bool u_xlatb4;
					float u_xlat6;
					layout(triangles) in;
					layout(triangle_strip) out;
					layout(location = 0) out highp vec3 gs_TEXCOORD0;
					layout(max_vertices = 3) out;
					void main()
					{
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[0].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[0].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[0].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[0].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    u_xlat0 = (-gl_in[0].gl_Position) + gl_in[2].gl_Position;
					    u_xlat0.x = dot(u_xlat0, u_xlat0);
					    u_xlat1 = (-gl_in[2].gl_Position) + gl_in[1].gl_Position;
					    u_xlat0.y = dot(u_xlat1, u_xlat1);
					    u_xlat0.xy = sqrt(u_xlat0.xy);
					    u_xlatb4 = u_xlat0.x<u_xlat0.y;
					    u_xlat1 = (-gl_in[1].gl_Position) + gl_in[0].gl_Position;
					    u_xlat6 = dot(u_xlat1, u_xlat1);
					    u_xlat6 = sqrt(u_xlat6);
					    u_xlatb1 = u_xlat6<u_xlat0.y;
					    u_xlatb0.xy = lessThan(u_xlat0.xyxx, vec4(u_xlat6)).xy;
					    u_xlatb0.x = u_xlatb0.x && u_xlatb0.y;
					    u_xlatb2 = u_xlatb4 && u_xlatb1;
					    u_xlat1.xz = (bool(u_xlatb2)) ? vec2(1.0, 0.0) : vec2(0.0, 1.0);
					    u_xlat1.y = 0.0;
					    u_xlat0.xyz = (u_xlatb0.x) ? vec3(0.0, 1.0, 0.0) : u_xlat1.xyz;
					    u_xlat1.xyz = u_xlat0.xyz + vec3(1.0, 0.0, 0.0);
					    gs_TEXCOORD0.xyz = u_xlat1.xyz;
					    EmitVertex();
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[1].gl_Position.yyyy;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[1].gl_Position.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[1].gl_Position.zzzz + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[1].gl_Position.wwww + u_xlat1;
					    gl_Position = u_xlat1;
					    u_xlat1.xyz = u_xlat0.xyz + vec3(0.0, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.0, 1.0, 0.0);
					    gs_TEXCOORD0.xyz = u_xlat1.xyz;
					    EmitVertex();
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[2].gl_Position.yyyy;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[2].gl_Position.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[2].gl_Position.zzzz + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[2].gl_Position.wwww + u_xlat1;
					    gl_Position = u_xlat1;
					    gs_TEXCOORD0.xyz = u_xlat0.xyz;
					    EmitVertex();
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 310 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					in highp vec4 in_POSITION0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = hlslcc_mtx4x4unity_ObjectToWorld[3] * in_POSITION0.wwww + u_xlat0;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 310 es
					
					precision highp float;
					precision highp int;
					uniform 	float _WireframeVal;
					uniform 	mediump vec4 _FrontColor;
					layout(location = 0) in highp vec3 gs_TEXCOORD0;
					layout(location = 0) out mediump vec4 SV_Target0;
					bvec3 u_xlatb0;
					void main()
					{
					    u_xlatb0.xyz = greaterThanEqual(vec4(_WireframeVal), gs_TEXCOORD0.xyzx).xyz;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlatb0.x = u_xlatb0.z || u_xlatb0.x;
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))==0){discard;}
					    SV_Target0 = _FrontColor;
					    return;
					}
					
					#endif
					#ifdef GEOMETRY
					#version 310 es
					#ifdef GL_ARB_geometry_shader
					#extension GL_ARB_geometry_shader : enable
					#endif
					#ifdef GL_OES_geometry_shader
					#extension GL_OES_geometry_shader : enable
					#endif
					#ifdef GL_EXT_geometry_shader
					#extension GL_EXT_geometry_shader : enable
					#endif
					
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					vec4 u_xlat0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					bool u_xlatb1;
					bool u_xlatb2;
					bool u_xlatb4;
					float u_xlat6;
					layout(triangles) in;
					layout(triangle_strip) out;
					layout(location = 0) out highp vec3 gs_TEXCOORD0;
					layout(max_vertices = 3) out;
					void main()
					{
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[0].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[0].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[0].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[0].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    u_xlat0 = (-gl_in[0].gl_Position) + gl_in[2].gl_Position;
					    u_xlat0.x = dot(u_xlat0, u_xlat0);
					    u_xlat1 = (-gl_in[2].gl_Position) + gl_in[1].gl_Position;
					    u_xlat0.y = dot(u_xlat1, u_xlat1);
					    u_xlat0.xy = sqrt(u_xlat0.xy);
					    u_xlatb4 = u_xlat0.x<u_xlat0.y;
					    u_xlat1 = (-gl_in[1].gl_Position) + gl_in[0].gl_Position;
					    u_xlat6 = dot(u_xlat1, u_xlat1);
					    u_xlat6 = sqrt(u_xlat6);
					    u_xlatb1 = u_xlat6<u_xlat0.y;
					    u_xlatb0.xy = lessThan(u_xlat0.xyxx, vec4(u_xlat6)).xy;
					    u_xlatb0.x = u_xlatb0.x && u_xlatb0.y;
					    u_xlatb2 = u_xlatb4 && u_xlatb1;
					    u_xlat1.xz = (bool(u_xlatb2)) ? vec2(1.0, 0.0) : vec2(0.0, 1.0);
					    u_xlat1.y = 0.0;
					    u_xlat0.xyz = (u_xlatb0.x) ? vec3(0.0, 1.0, 0.0) : u_xlat1.xyz;
					    u_xlat1.xyz = u_xlat0.xyz + vec3(1.0, 0.0, 0.0);
					    gs_TEXCOORD0.xyz = u_xlat1.xyz;
					    EmitVertex();
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[1].gl_Position.yyyy;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[1].gl_Position.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[1].gl_Position.zzzz + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[1].gl_Position.wwww + u_xlat1;
					    gl_Position = u_xlat1;
					    u_xlat1.xyz = u_xlat0.xyz + vec3(0.0, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.0, 1.0, 0.0);
					    gs_TEXCOORD0.xyz = u_xlat1.xyz;
					    EmitVertex();
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[2].gl_Position.yyyy;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[2].gl_Position.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[2].gl_Position.zzzz + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[2].gl_Position.wwww + u_xlat1;
					    gl_Position = u_xlat1;
					    gs_TEXCOORD0.xyz = u_xlat0.xyz;
					    EmitVertex();
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 310 es
					
					uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
					in highp vec4 in_POSITION0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    gl_Position = hlslcc_mtx4x4unity_ObjectToWorld[3] * in_POSITION0.wwww + u_xlat0;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 310 es
					
					precision highp float;
					precision highp int;
					uniform 	float _WireframeVal;
					uniform 	mediump vec4 _FrontColor;
					layout(location = 0) in highp vec3 gs_TEXCOORD0;
					layout(location = 0) out mediump vec4 SV_Target0;
					bvec3 u_xlatb0;
					void main()
					{
					    u_xlatb0.xyz = greaterThanEqual(vec4(_WireframeVal), gs_TEXCOORD0.xyzx).xyz;
					    u_xlatb0.x = u_xlatb0.y || u_xlatb0.x;
					    u_xlatb0.x = u_xlatb0.z || u_xlatb0.x;
					    if(((int(u_xlatb0.x) * int(0xffffffffu)))==0){discard;}
					    SV_Target0 = _FrontColor;
					    return;
					}
					
					#endif
					#ifdef GEOMETRY
					#version 310 es
					#ifdef GL_ARB_geometry_shader
					#extension GL_ARB_geometry_shader : enable
					#endif
					#ifdef GL_OES_geometry_shader
					#extension GL_OES_geometry_shader : enable
					#endif
					#ifdef GL_EXT_geometry_shader
					#extension GL_EXT_geometry_shader : enable
					#endif
					
					uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
					vec4 u_xlat0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					bool u_xlatb1;
					bool u_xlatb2;
					bool u_xlatb4;
					float u_xlat6;
					layout(triangles) in;
					layout(triangle_strip) out;
					layout(location = 0) out highp vec3 gs_TEXCOORD0;
					layout(max_vertices = 3) out;
					void main()
					{
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[0].gl_Position.yyyy;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[0].gl_Position.xxxx + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[0].gl_Position.zzzz + u_xlat0;
					    u_xlat0 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[0].gl_Position.wwww + u_xlat0;
					    gl_Position = u_xlat0;
					    u_xlat0 = (-gl_in[0].gl_Position) + gl_in[2].gl_Position;
					    u_xlat0.x = dot(u_xlat0, u_xlat0);
					    u_xlat1 = (-gl_in[2].gl_Position) + gl_in[1].gl_Position;
					    u_xlat0.y = dot(u_xlat1, u_xlat1);
					    u_xlat0.xy = sqrt(u_xlat0.xy);
					    u_xlatb4 = u_xlat0.x<u_xlat0.y;
					    u_xlat1 = (-gl_in[1].gl_Position) + gl_in[0].gl_Position;
					    u_xlat6 = dot(u_xlat1, u_xlat1);
					    u_xlat6 = sqrt(u_xlat6);
					    u_xlatb1 = u_xlat6<u_xlat0.y;
					    u_xlatb0.xy = lessThan(u_xlat0.xyxx, vec4(u_xlat6)).xy;
					    u_xlatb0.x = u_xlatb0.x && u_xlatb0.y;
					    u_xlatb2 = u_xlatb4 && u_xlatb1;
					    u_xlat1.xz = (bool(u_xlatb2)) ? vec2(1.0, 0.0) : vec2(0.0, 1.0);
					    u_xlat1.y = 0.0;
					    u_xlat0.xyz = (u_xlatb0.x) ? vec3(0.0, 1.0, 0.0) : u_xlat1.xyz;
					    u_xlat1.xyz = u_xlat0.xyz + vec3(1.0, 0.0, 0.0);
					    gs_TEXCOORD0.xyz = u_xlat1.xyz;
					    EmitVertex();
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[1].gl_Position.yyyy;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[1].gl_Position.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[1].gl_Position.zzzz + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[1].gl_Position.wwww + u_xlat1;
					    gl_Position = u_xlat1;
					    u_xlat1.xyz = u_xlat0.xyz + vec3(0.0, 0.0, 1.0);
					    u_xlat0.xyz = u_xlat0.xyz + vec3(0.0, 1.0, 0.0);
					    gs_TEXCOORD0.xyz = u_xlat1.xyz;
					    EmitVertex();
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[1] * gl_in[2].gl_Position.yyyy;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * gl_in[2].gl_Position.xxxx + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * gl_in[2].gl_Position.zzzz + u_xlat1;
					    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[3] * gl_in[2].gl_Position.wwww + u_xlat1;
					    gl_Position = u_xlat1;
					    gs_TEXCOORD0.xyz = u_xlat0.xyz;
					    EmitVertex();
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
				SubProgram "gles3 hw_tier00 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3"
				}
			}
			Program "gp" {
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier00 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier01 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3"
				}
				SubProgram "gles3 hw_tier02 " {
					Keywords { "_REMOVEDIAG_ON" }
					"!!GLES3"
				}
			}
		}
	}
}