Shader "Hidden/PostProcessing/SubpixelMorphologicalAntialiasing" {
	Properties {
	}
	SubShader {
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 58247
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
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
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					lowp vec3 u_xlat10_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp vec3 u_xlat10_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					lowp vec3 u_xlat10_4;
					lowp vec3 u_xlat10_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat10_0.xyz = texture2D(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat10_1.xyz = texture2D(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat10_0.xyz + (-u_xlat10_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat10_3.xyz = texture2D(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.150000006, 0.150000006, 0.150000006, 0.150000006)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					    u_xlatb18 = u_xlat18==0.0;
					    if(((int(u_xlatb18) * -1))!=0){discard;}
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat10_5.xyz = texture2D(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz + (-u_xlat10_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat10_1.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_3.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
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
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					lowp vec3 u_xlat10_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp vec3 u_xlat10_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					lowp vec3 u_xlat10_4;
					lowp vec3 u_xlat10_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat10_0.xyz = texture2D(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat10_1.xyz = texture2D(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat10_0.xyz + (-u_xlat10_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat10_3.xyz = texture2D(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.150000006, 0.150000006, 0.150000006, 0.150000006)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					    u_xlatb18 = u_xlat18==0.0;
					    if(((int(u_xlatb18) * -1))!=0){discard;}
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat10_5.xyz = texture2D(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz + (-u_xlat10_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat10_1.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_3.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
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
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					lowp vec3 u_xlat10_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp vec3 u_xlat10_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					lowp vec3 u_xlat10_4;
					lowp vec3 u_xlat10_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat10_0.xyz = texture2D(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat10_1.xyz = texture2D(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat10_0.xyz + (-u_xlat10_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat10_3.xyz = texture2D(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.150000006, 0.150000006, 0.150000006, 0.150000006)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					    u_xlatb18 = u_xlat18==0.0;
					    if(((int(u_xlatb18) * -1))!=0){discard;}
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat10_5.xyz = texture2D(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz + (-u_xlat10_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat10_1.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_3.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat16_0.xyz = texture(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat16_1.xyz = texture(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat16_0.xyz + (-u_xlat16_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat16_3.xyz = texture(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.150000006, 0.150000006, 0.150000006, 0.150000006)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb18 = !!(u_xlat18==0.0);
					#else
					    u_xlatb18 = u_xlat18==0.0;
					#endif
					    if(((int(u_xlatb18) * int(0xffffffffu)))!=0){discard;}
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat16_5.xyz = texture(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + (-u_xlat16_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat16_0.xyz = texture(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat16_1.xyz = texture(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat16_0.xyz + (-u_xlat16_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat16_3.xyz = texture(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.150000006, 0.150000006, 0.150000006, 0.150000006)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb18 = !!(u_xlat18==0.0);
					#else
					    u_xlatb18 = u_xlat18==0.0;
					#endif
					    if(((int(u_xlatb18) * int(0xffffffffu)))!=0){discard;}
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat16_5.xyz = texture(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + (-u_xlat16_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat16_0.xyz = texture(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat16_1.xyz = texture(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat16_0.xyz + (-u_xlat16_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat16_3.xyz = texture(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.150000006, 0.150000006, 0.150000006, 0.150000006)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb18 = !!(u_xlat18==0.0);
					#else
					    u_xlatb18 = u_xlat18==0.0;
					#endif
					    if(((int(u_xlatb18) * int(0xffffffffu)))!=0){discard;}
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat16_5.xyz = texture(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + (-u_xlat16_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
			GpuProgramID 80576
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
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
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					lowp vec3 u_xlat10_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp vec3 u_xlat10_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					lowp vec3 u_xlat10_4;
					lowp vec3 u_xlat10_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat10_0.xyz = texture2D(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat10_1.xyz = texture2D(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat10_0.xyz + (-u_xlat10_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat10_3.xyz = texture2D(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.100000001, 0.100000001, 0.100000001, 0.100000001)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					    u_xlatb18 = u_xlat18==0.0;
					    if(((int(u_xlatb18) * -1))!=0){discard;}
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat10_5.xyz = texture2D(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz + (-u_xlat10_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat10_1.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_3.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
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
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					lowp vec3 u_xlat10_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp vec3 u_xlat10_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					lowp vec3 u_xlat10_4;
					lowp vec3 u_xlat10_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat10_0.xyz = texture2D(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat10_1.xyz = texture2D(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat10_0.xyz + (-u_xlat10_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat10_3.xyz = texture2D(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.100000001, 0.100000001, 0.100000001, 0.100000001)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					    u_xlatb18 = u_xlat18==0.0;
					    if(((int(u_xlatb18) * -1))!=0){discard;}
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat10_5.xyz = texture2D(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz + (-u_xlat10_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat10_1.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_3.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
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
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					lowp vec3 u_xlat10_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp vec3 u_xlat10_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					lowp vec3 u_xlat10_4;
					lowp vec3 u_xlat10_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat10_0.xyz = texture2D(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat10_1.xyz = texture2D(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat10_0.xyz + (-u_xlat10_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat10_3.xyz = texture2D(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.100000001, 0.100000001, 0.100000001, 0.100000001)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					    u_xlatb18 = u_xlat18==0.0;
					    if(((int(u_xlatb18) * -1))!=0){discard;}
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat10_5.xyz = texture2D(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz + (-u_xlat10_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat10_1.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_3.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat16_0.xyz = texture(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat16_1.xyz = texture(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat16_0.xyz + (-u_xlat16_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat16_3.xyz = texture(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.100000001, 0.100000001, 0.100000001, 0.100000001)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb18 = !!(u_xlat18==0.0);
					#else
					    u_xlatb18 = u_xlat18==0.0;
					#endif
					    if(((int(u_xlatb18) * int(0xffffffffu)))!=0){discard;}
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat16_5.xyz = texture(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + (-u_xlat16_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat16_0.xyz = texture(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat16_1.xyz = texture(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat16_0.xyz + (-u_xlat16_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat16_3.xyz = texture(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.100000001, 0.100000001, 0.100000001, 0.100000001)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb18 = !!(u_xlat18==0.0);
					#else
					    u_xlatb18 = u_xlat18==0.0;
					#endif
					    if(((int(u_xlatb18) * int(0xffffffffu)))!=0){discard;}
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat16_5.xyz = texture(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + (-u_xlat16_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat16_0.xyz = texture(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat16_1.xyz = texture(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat16_0.xyz + (-u_xlat16_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat16_3.xyz = texture(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.100000001, 0.100000001, 0.100000001, 0.100000001)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb18 = !!(u_xlat18==0.0);
					#else
					    u_xlatb18 = u_xlat18==0.0;
					#endif
					    if(((int(u_xlatb18) * int(0xffffffffu)))!=0){discard;}
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat16_5.xyz = texture(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + (-u_xlat16_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
			GpuProgramID 138618
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
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
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					lowp vec3 u_xlat10_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp vec3 u_xlat10_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					lowp vec3 u_xlat10_4;
					lowp vec3 u_xlat10_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat10_0.xyz = texture2D(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat10_1.xyz = texture2D(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat10_0.xyz + (-u_xlat10_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat10_3.xyz = texture2D(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.100000001, 0.100000001, 0.100000001, 0.100000001)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					    u_xlatb18 = u_xlat18==0.0;
					    if(((int(u_xlatb18) * -1))!=0){discard;}
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat10_5.xyz = texture2D(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz + (-u_xlat10_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat10_1.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_3.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
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
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					lowp vec3 u_xlat10_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp vec3 u_xlat10_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					lowp vec3 u_xlat10_4;
					lowp vec3 u_xlat10_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat10_0.xyz = texture2D(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat10_1.xyz = texture2D(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat10_0.xyz + (-u_xlat10_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat10_3.xyz = texture2D(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.100000001, 0.100000001, 0.100000001, 0.100000001)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					    u_xlatb18 = u_xlat18==0.0;
					    if(((int(u_xlatb18) * -1))!=0){discard;}
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat10_5.xyz = texture2D(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz + (-u_xlat10_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat10_1.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_3.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
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
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					#define SV_Target0 gl_FragData[0]
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					lowp vec3 u_xlat10_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					lowp vec3 u_xlat10_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					lowp vec3 u_xlat10_4;
					lowp vec3 u_xlat10_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat10_0.xyz = texture2D(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat10_1.xyz = texture2D(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat10_0.xyz + (-u_xlat10_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat10_3.xyz = texture2D(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.100000001, 0.100000001, 0.100000001, 0.100000001)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					    u_xlatb18 = u_xlat18==0.0;
					    if(((int(u_xlatb18) * -1))!=0){discard;}
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat10_0.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat10_5.xyz = texture2D(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat10_0.xyz + (-u_xlat10_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat10_1.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat10_4.xyz = texture2D(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat10_3.xyz + (-u_xlat10_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat16_0.xyz = texture(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat16_1.xyz = texture(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat16_0.xyz + (-u_xlat16_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat16_3.xyz = texture(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.100000001, 0.100000001, 0.100000001, 0.100000001)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb18 = !!(u_xlat18==0.0);
					#else
					    u_xlatb18 = u_xlat18==0.0;
					#endif
					    if(((int(u_xlatb18) * int(0xffffffffu)))!=0){discard;}
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat16_5.xyz = texture(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + (-u_xlat16_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat16_0.xyz = texture(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat16_1.xyz = texture(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat16_0.xyz + (-u_xlat16_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat16_3.xyz = texture(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.100000001, 0.100000001, 0.100000001, 0.100000001)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb18 = !!(u_xlat18==0.0);
					#else
					    u_xlatb18 = u_xlat18==0.0;
					#endif
					    if(((int(u_xlatb18) * int(0xffffffffu)))!=0){discard;}
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat16_5.xyz = texture(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + (-u_xlat16_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD2 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
					    vs_TEXCOORD3 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, 0.0, -2.0) + u_xlat0.xyxy;
					    return;
					}
					
					#endif
					#ifdef FRAGMENT
					#version 300 es
					
					precision highp float;
					precision highp int;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					layout(location = 0) out highp vec4 SV_Target0;
					vec2 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec2 u_xlat1;
					mediump vec3 u_xlat16_1;
					vec2 u_xlat2;
					mediump vec3 u_xlat16_2;
					mediump vec3 u_xlat16_3;
					vec2 u_xlat4;
					mediump vec3 u_xlat16_4;
					mediump vec3 u_xlat16_5;
					vec2 u_xlat6;
					mediump float u_xlat16_12;
					vec2 u_xlat14;
					bvec2 u_xlatb14;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					void main()
					{
					    u_xlat16_0.xyz = texture(_MainTex, vs_TEXCOORD0.xy).xyz;
					    u_xlat16_1.xyz = texture(_MainTex, vs_TEXCOORD1.xy).xyz;
					    u_xlat16_2.xyz = u_xlat16_0.xyz + (-u_xlat16_1.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_2.y), abs(u_xlat16_2.x));
					    u_xlat2.x = max(abs(u_xlat16_2.z), u_xlat16_18);
					    u_xlat16_3.xyz = texture(_MainTex, vs_TEXCOORD1.zw).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_3.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat2.y = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlatb14.xy = greaterThanEqual(u_xlat2.xyxy, vec4(0.100000001, 0.100000001, 0.100000001, 0.100000001)).xy;
					    u_xlat14.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb14.xy));
					    u_xlat18 = dot(u_xlat14.xy, vec2(1.0, 1.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb18 = !!(u_xlat18==0.0);
					#else
					    u_xlatb18 = u_xlat18==0.0;
					#endif
					    if(((int(u_xlatb18) * int(0xffffffffu)))!=0){discard;}
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD2.xy).xyz;
					    u_xlat16_4.xyz = u_xlat16_0.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_18 = max(abs(u_xlat16_4.y), abs(u_xlat16_4.x));
					    u_xlat4.x = max(abs(u_xlat16_4.z), u_xlat16_18);
					    u_xlat16_5.xyz = texture(_MainTex, vs_TEXCOORD2.zw).xyz;
					    u_xlat16_0.xyz = u_xlat16_0.xyz + (-u_xlat16_5.xyz);
					    u_xlat16_0.x = max(abs(u_xlat16_0.y), abs(u_xlat16_0.x));
					    u_xlat4.y = max(abs(u_xlat16_0.z), u_xlat16_0.x);
					    u_xlat0.xy = max(u_xlat2.xy, u_xlat4.xy);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.xy).xyz;
					    u_xlat16_1.xyz = u_xlat16_1.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_1.y), abs(u_xlat16_1.x));
					    u_xlat1.x = max(abs(u_xlat16_1.z), u_xlat16_12);
					    u_xlat16_4.xyz = texture(_MainTex, vs_TEXCOORD3.zw).xyz;
					    u_xlat16_3.xyz = u_xlat16_3.xyz + (-u_xlat16_4.xyz);
					    u_xlat16_12 = max(abs(u_xlat16_3.y), abs(u_xlat16_3.x));
					    u_xlat1.y = max(abs(u_xlat16_3.z), u_xlat16_12);
					    u_xlat0.xy = max(u_xlat0.xy, u_xlat1.xy);
					    u_xlat0.x = max(u_xlat0.y, u_xlat0.x);
					    u_xlat6.xy = u_xlat2.xy + u_xlat2.xy;
					    u_xlatb0.xy = greaterThanEqual(u_xlat6.xyxx, u_xlat0.xxxx).xy;
					    u_xlat0.xy = mix(vec2(0.0, 0.0), vec2(1.0, 1.0), vec2(u_xlatb0.xy));
					    u_xlat0.xy = u_xlat0.xy * u_xlat14.xy;
					    SV_Target0.xy = u_xlat0.xy;
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
			GpuProgramID 243888
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.xzyw;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-8.0, 8.0, -8.0, 8.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SearchTex;
					uniform lowp sampler2D _AreaTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb8;
					vec2 u_xlat9;
					bool u_xlatb9;
					mediump float u_xlat16_12;
					lowp float u_xlat10_12;
					bool u_xlatb12;
					bool u_xlatb13;
					float roundEven(float x) { float y = floor(x + 0.5); return (y - x == 0.5) ? floor(0.5*y) * 2.0 : y; }
					vec2 roundEven(vec2 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); return a; }
					vec3 roundEven(vec3 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); return a; }
					vec4 roundEven(vec4 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); a.w = roundEven(a.w); return a; }
					
					void main()
					{
					    u_xlat0.xy = texture2D(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb0.xy = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.yxyy).xy;
					    if(u_xlatb0.x){
					        u_xlat1.xy = vs_TEXCOORD2.xy;
					        u_xlat1.z = 1.0;
					        u_xlat2.x = 0.0;
					        for(int u_xlati_while_true_0 = 0 ; u_xlati_while_true_0 < 0x7FFF ; u_xlati_while_true_0++){
					            u_xlatb0.x = vs_TEXCOORD4.x<u_xlat1.x;
					            u_xlatb8 = 0.828100026<u_xlat1.z;
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            u_xlatb8 = u_xlat2.x==0.0;
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            if(!u_xlatb0.x){break;}
					            u_xlat2.xy = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).xy;
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					            u_xlat1.z = u_xlat2.y;
					        }
					        u_xlat2.yz = u_xlat1.xz;
					        u_xlat0.xz = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0.x = texture2DLodEXT(_SearchTex, u_xlat0.xz, 0.0).w;
					        u_xlat16_0 = u_xlat10_0.x * -2.00787401 + 3.25;
					        u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_0 + u_xlat2.y;
					        u_xlat1.y = vs_TEXCOORD3.y;
					        u_xlat0.x = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).x;
					        u_xlat2.xy = vs_TEXCOORD2.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_1 = 0 ; u_xlati_while_true_1 < 0x7FFF ; u_xlati_while_true_1++){
					            u_xlatb12 = u_xlat2.x<vs_TEXCOORD4.y;
					            u_xlatb13 = 0.828100026<u_xlat2.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            u_xlatb13 = u_xlat3.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.xz;
					        u_xlat2.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_12 = texture2DLodEXT(_SearchTex, u_xlat2.xy, 0.0).w;
					        u_xlat16_12 = u_xlat10_12 * -2.00787401 + 3.25;
					        u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_12 + u_xlat3.y;
					        u_xlat1.xw = _MainTex_TexelSize.zz * u_xlat1.xz + (-vs_TEXCOORD1.xx);
					        u_xlat1.xw = roundEven(u_xlat1.xw);
					        u_xlat1.xw = sqrt(abs(u_xlat1.xw));
					        u_xlat5.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					        u_xlat0.z = texture2DLodEXT(_MainTex, u_xlat5.xy, 0.0).x;
					        u_xlat0.xz = u_xlat0.xz * vec2(4.0, 4.0);
					        u_xlat0.xz = roundEven(u_xlat0.xz);
					        u_xlat0.xz = u_xlat0.xz * vec2(16.0, 16.0) + u_xlat1.xw;
					        u_xlat0.xz = u_xlat0.xz * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_0.xz = texture2DLodEXT(_AreaTex, u_xlat0.xz, 0.0).xy;
					        SV_Target0.xy = u_xlat10_0.xz;
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    if(u_xlatb0.y){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        for(int u_xlati_while_true_2 = 0 ; u_xlati_while_true_2 < 0x7FFF ; u_xlati_while_true_2++){
					            u_xlatb12 = vs_TEXCOORD4.z<u_xlat0.y;
					            u_xlatb13 = 0.828100026<u_xlat0.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            u_xlatb13 = u_xlat1.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat1.xy = texture2DLodEXT(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0.x = texture2DLodEXT(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0 = u_xlat10_0.x * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0 + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = texture2DLodEXT(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_3 = 0 ; u_xlati_while_true_3 < 0x7FFF ; u_xlati_while_true_3++){
					            u_xlatb12 = u_xlat2.y<vs_TEXCOORD4.w;
					            u_xlatb9 = 0.828100026<u_xlat2.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            u_xlatb9 = u_xlat3.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat9.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_12 = texture2DLodEXT(_SearchTex, u_xlat9.xy, 0.0).w;
					        u_xlat16_12 = u_xlat10_12 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_12 + u_xlat3.y;
					        u_xlat0.xw = _MainTex_TexelSize.ww * u_xlat0.xz + (-vs_TEXCOORD1.yy);
					        u_xlat0.xw = roundEven(u_xlat0.xw);
					        u_xlat0.xw = sqrt(abs(u_xlat0.xw));
					        u_xlat4.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).y;
					        u_xlat4.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat4.xy = roundEven(u_xlat4.xy);
					        u_xlat0.xy = u_xlat4.xy * vec2(16.0, 16.0) + u_xlat0.xw;
					        u_xlat0.xy = u_xlat0.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_0.xy = texture2DLodEXT(_AreaTex, u_xlat0.xy, 0.0).xy;
					        SV_Target0.zw = u_xlat10_0.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.xzyw;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-8.0, 8.0, -8.0, 8.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SearchTex;
					uniform lowp sampler2D _AreaTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb8;
					vec2 u_xlat9;
					bool u_xlatb9;
					mediump float u_xlat16_12;
					lowp float u_xlat10_12;
					bool u_xlatb12;
					bool u_xlatb13;
					float roundEven(float x) { float y = floor(x + 0.5); return (y - x == 0.5) ? floor(0.5*y) * 2.0 : y; }
					vec2 roundEven(vec2 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); return a; }
					vec3 roundEven(vec3 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); return a; }
					vec4 roundEven(vec4 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); a.w = roundEven(a.w); return a; }
					
					void main()
					{
					    u_xlat0.xy = texture2D(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb0.xy = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.yxyy).xy;
					    if(u_xlatb0.x){
					        u_xlat1.xy = vs_TEXCOORD2.xy;
					        u_xlat1.z = 1.0;
					        u_xlat2.x = 0.0;
					        for(int u_xlati_while_true_0 = 0 ; u_xlati_while_true_0 < 0x7FFF ; u_xlati_while_true_0++){
					            u_xlatb0.x = vs_TEXCOORD4.x<u_xlat1.x;
					            u_xlatb8 = 0.828100026<u_xlat1.z;
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            u_xlatb8 = u_xlat2.x==0.0;
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            if(!u_xlatb0.x){break;}
					            u_xlat2.xy = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).xy;
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					            u_xlat1.z = u_xlat2.y;
					        }
					        u_xlat2.yz = u_xlat1.xz;
					        u_xlat0.xz = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0.x = texture2DLodEXT(_SearchTex, u_xlat0.xz, 0.0).w;
					        u_xlat16_0 = u_xlat10_0.x * -2.00787401 + 3.25;
					        u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_0 + u_xlat2.y;
					        u_xlat1.y = vs_TEXCOORD3.y;
					        u_xlat0.x = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).x;
					        u_xlat2.xy = vs_TEXCOORD2.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_1 = 0 ; u_xlati_while_true_1 < 0x7FFF ; u_xlati_while_true_1++){
					            u_xlatb12 = u_xlat2.x<vs_TEXCOORD4.y;
					            u_xlatb13 = 0.828100026<u_xlat2.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            u_xlatb13 = u_xlat3.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.xz;
					        u_xlat2.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_12 = texture2DLodEXT(_SearchTex, u_xlat2.xy, 0.0).w;
					        u_xlat16_12 = u_xlat10_12 * -2.00787401 + 3.25;
					        u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_12 + u_xlat3.y;
					        u_xlat1.xw = _MainTex_TexelSize.zz * u_xlat1.xz + (-vs_TEXCOORD1.xx);
					        u_xlat1.xw = roundEven(u_xlat1.xw);
					        u_xlat1.xw = sqrt(abs(u_xlat1.xw));
					        u_xlat5.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					        u_xlat0.z = texture2DLodEXT(_MainTex, u_xlat5.xy, 0.0).x;
					        u_xlat0.xz = u_xlat0.xz * vec2(4.0, 4.0);
					        u_xlat0.xz = roundEven(u_xlat0.xz);
					        u_xlat0.xz = u_xlat0.xz * vec2(16.0, 16.0) + u_xlat1.xw;
					        u_xlat0.xz = u_xlat0.xz * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_0.xz = texture2DLodEXT(_AreaTex, u_xlat0.xz, 0.0).xy;
					        SV_Target0.xy = u_xlat10_0.xz;
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    if(u_xlatb0.y){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        for(int u_xlati_while_true_2 = 0 ; u_xlati_while_true_2 < 0x7FFF ; u_xlati_while_true_2++){
					            u_xlatb12 = vs_TEXCOORD4.z<u_xlat0.y;
					            u_xlatb13 = 0.828100026<u_xlat0.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            u_xlatb13 = u_xlat1.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat1.xy = texture2DLodEXT(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0.x = texture2DLodEXT(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0 = u_xlat10_0.x * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0 + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = texture2DLodEXT(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_3 = 0 ; u_xlati_while_true_3 < 0x7FFF ; u_xlati_while_true_3++){
					            u_xlatb12 = u_xlat2.y<vs_TEXCOORD4.w;
					            u_xlatb9 = 0.828100026<u_xlat2.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            u_xlatb9 = u_xlat3.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat9.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_12 = texture2DLodEXT(_SearchTex, u_xlat9.xy, 0.0).w;
					        u_xlat16_12 = u_xlat10_12 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_12 + u_xlat3.y;
					        u_xlat0.xw = _MainTex_TexelSize.ww * u_xlat0.xz + (-vs_TEXCOORD1.yy);
					        u_xlat0.xw = roundEven(u_xlat0.xw);
					        u_xlat0.xw = sqrt(abs(u_xlat0.xw));
					        u_xlat4.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).y;
					        u_xlat4.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat4.xy = roundEven(u_xlat4.xy);
					        u_xlat0.xy = u_xlat4.xy * vec2(16.0, 16.0) + u_xlat0.xw;
					        u_xlat0.xy = u_xlat0.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_0.xy = texture2DLodEXT(_AreaTex, u_xlat0.xy, 0.0).xy;
					        SV_Target0.zw = u_xlat10_0.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.xzyw;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-8.0, 8.0, -8.0, 8.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SearchTex;
					uniform lowp sampler2D _AreaTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb8;
					vec2 u_xlat9;
					bool u_xlatb9;
					mediump float u_xlat16_12;
					lowp float u_xlat10_12;
					bool u_xlatb12;
					bool u_xlatb13;
					float roundEven(float x) { float y = floor(x + 0.5); return (y - x == 0.5) ? floor(0.5*y) * 2.0 : y; }
					vec2 roundEven(vec2 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); return a; }
					vec3 roundEven(vec3 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); return a; }
					vec4 roundEven(vec4 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); a.w = roundEven(a.w); return a; }
					
					void main()
					{
					    u_xlat0.xy = texture2D(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb0.xy = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.yxyy).xy;
					    if(u_xlatb0.x){
					        u_xlat1.xy = vs_TEXCOORD2.xy;
					        u_xlat1.z = 1.0;
					        u_xlat2.x = 0.0;
					        for(int u_xlati_while_true_0 = 0 ; u_xlati_while_true_0 < 0x7FFF ; u_xlati_while_true_0++){
					            u_xlatb0.x = vs_TEXCOORD4.x<u_xlat1.x;
					            u_xlatb8 = 0.828100026<u_xlat1.z;
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            u_xlatb8 = u_xlat2.x==0.0;
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            if(!u_xlatb0.x){break;}
					            u_xlat2.xy = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).xy;
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					            u_xlat1.z = u_xlat2.y;
					        }
					        u_xlat2.yz = u_xlat1.xz;
					        u_xlat0.xz = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0.x = texture2DLodEXT(_SearchTex, u_xlat0.xz, 0.0).w;
					        u_xlat16_0 = u_xlat10_0.x * -2.00787401 + 3.25;
					        u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_0 + u_xlat2.y;
					        u_xlat1.y = vs_TEXCOORD3.y;
					        u_xlat0.x = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).x;
					        u_xlat2.xy = vs_TEXCOORD2.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_1 = 0 ; u_xlati_while_true_1 < 0x7FFF ; u_xlati_while_true_1++){
					            u_xlatb12 = u_xlat2.x<vs_TEXCOORD4.y;
					            u_xlatb13 = 0.828100026<u_xlat2.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            u_xlatb13 = u_xlat3.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.xz;
					        u_xlat2.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_12 = texture2DLodEXT(_SearchTex, u_xlat2.xy, 0.0).w;
					        u_xlat16_12 = u_xlat10_12 * -2.00787401 + 3.25;
					        u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_12 + u_xlat3.y;
					        u_xlat1.xw = _MainTex_TexelSize.zz * u_xlat1.xz + (-vs_TEXCOORD1.xx);
					        u_xlat1.xw = roundEven(u_xlat1.xw);
					        u_xlat1.xw = sqrt(abs(u_xlat1.xw));
					        u_xlat5.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					        u_xlat0.z = texture2DLodEXT(_MainTex, u_xlat5.xy, 0.0).x;
					        u_xlat0.xz = u_xlat0.xz * vec2(4.0, 4.0);
					        u_xlat0.xz = roundEven(u_xlat0.xz);
					        u_xlat0.xz = u_xlat0.xz * vec2(16.0, 16.0) + u_xlat1.xw;
					        u_xlat0.xz = u_xlat0.xz * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_0.xz = texture2DLodEXT(_AreaTex, u_xlat0.xz, 0.0).xy;
					        SV_Target0.xy = u_xlat10_0.xz;
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    if(u_xlatb0.y){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        for(int u_xlati_while_true_2 = 0 ; u_xlati_while_true_2 < 0x7FFF ; u_xlati_while_true_2++){
					            u_xlatb12 = vs_TEXCOORD4.z<u_xlat0.y;
					            u_xlatb13 = 0.828100026<u_xlat0.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            u_xlatb13 = u_xlat1.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat1.xy = texture2DLodEXT(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0.x = texture2DLodEXT(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0 = u_xlat10_0.x * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0 + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = texture2DLodEXT(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_3 = 0 ; u_xlati_while_true_3 < 0x7FFF ; u_xlati_while_true_3++){
					            u_xlatb12 = u_xlat2.y<vs_TEXCOORD4.w;
					            u_xlatb9 = 0.828100026<u_xlat2.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            u_xlatb9 = u_xlat3.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat9.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_12 = texture2DLodEXT(_SearchTex, u_xlat9.xy, 0.0).w;
					        u_xlat16_12 = u_xlat10_12 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_12 + u_xlat3.y;
					        u_xlat0.xw = _MainTex_TexelSize.ww * u_xlat0.xz + (-vs_TEXCOORD1.yy);
					        u_xlat0.xw = roundEven(u_xlat0.xw);
					        u_xlat0.xw = sqrt(abs(u_xlat0.xw));
					        u_xlat4.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).y;
					        u_xlat4.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat4.xy = roundEven(u_xlat4.xy);
					        u_xlat0.xy = u_xlat4.xy * vec2(16.0, 16.0) + u_xlat0.xw;
					        u_xlat0.xy = u_xlat0.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_0.xy = texture2DLodEXT(_AreaTex, u_xlat0.xy, 0.0).xy;
					        SV_Target0.zw = u_xlat10_0.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					out highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.zzww;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-8.0, 8.0, -8.0, 8.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SearchTex;
					uniform mediump sampler2D _AreaTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					in highp vec4 vs_TEXCOORD4;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb8;
					vec2 u_xlat9;
					bool u_xlatb9;
					mediump float u_xlat16_12;
					bool u_xlatb12;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0.xy = texture(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb0.xy = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.yxyy).xy;
					    if(u_xlatb0.x){
					        u_xlat1.xy = vs_TEXCOORD2.xy;
					        u_xlat1.z = 1.0;
					        u_xlat2.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb0.x = !!(vs_TEXCOORD4.x<u_xlat1.x);
					#else
					            u_xlatb0.x = vs_TEXCOORD4.x<u_xlat1.x;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb8 = !!(0.828100026<u_xlat1.z);
					#else
					            u_xlatb8 = 0.828100026<u_xlat1.z;
					#endif
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb8 = !!(u_xlat2.x==0.0);
					#else
					            u_xlatb8 = u_xlat2.x==0.0;
					#endif
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            if(!u_xlatb0.x){break;}
					            u_xlat2.xy = textureLod(_MainTex, u_xlat1.xy, 0.0).xy;
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					            u_xlat1.z = u_xlat2.y;
					        }
					        u_xlat2.yz = u_xlat1.xz;
					        u_xlat0.xz = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0.x = textureLod(_SearchTex, u_xlat0.xz, 0.0).w;
					        u_xlat16_0.x = u_xlat16_0.x * -2.00787401 + 3.25;
					        u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_0.x + u_xlat2.y;
					        u_xlat1.y = vs_TEXCOORD3.y;
					        u_xlat0.x = textureLod(_MainTex, u_xlat1.xy, 0.0).x;
					        u_xlat2.xy = vs_TEXCOORD2.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(u_xlat2.x<vs_TEXCOORD4.y);
					#else
					            u_xlatb12 = u_xlat2.x<vs_TEXCOORD4.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb13 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb13 = u_xlat3.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.xz;
					        u_xlat2.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_12 = textureLod(_SearchTex, u_xlat2.xy, 0.0).w;
					        u_xlat16_12 = u_xlat16_12 * -2.00787401 + 3.25;
					        u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_12 + u_xlat3.y;
					        u_xlat1.xw = _MainTex_TexelSize.zz * u_xlat1.xz + (-vs_TEXCOORD1.xx);
					        u_xlat1.xw = roundEven(u_xlat1.xw);
					        u_xlat1.xw = sqrt(abs(u_xlat1.xw));
					        u_xlat5.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					        u_xlat0.z = textureLod(_MainTex, u_xlat5.xy, 0.0).x;
					        u_xlat0.xz = u_xlat0.xz * vec2(4.0, 4.0);
					        u_xlat0.xz = roundEven(u_xlat0.xz);
					        u_xlat0.xz = u_xlat0.xz * vec2(16.0, 16.0) + u_xlat1.xw;
					        u_xlat0.xz = u_xlat0.xz * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_0.xz = textureLod(_AreaTex, u_xlat0.xz, 0.0).xy;
					        SV_Target0.xy = u_xlat16_0.xz;
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    if(u_xlatb0.y){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(vs_TEXCOORD4.z<u_xlat0.y);
					#else
					            u_xlatb12 = vs_TEXCOORD4.z<u_xlat0.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(0.828100026<u_xlat0.z);
					#else
					            u_xlatb13 = 0.828100026<u_xlat0.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat1.x==0.0);
					#else
					            u_xlatb13 = u_xlat1.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat1.xy = textureLod(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0.x = textureLod(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0.x = u_xlat16_0.x * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0.x + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = textureLod(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(u_xlat2.y<vs_TEXCOORD4.w);
					#else
					            u_xlatb12 = u_xlat2.y<vs_TEXCOORD4.w;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb9 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb9 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb9 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb9 = u_xlat3.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat9.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_12 = textureLod(_SearchTex, u_xlat9.xy, 0.0).w;
					        u_xlat16_12 = u_xlat16_12 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_12 + u_xlat3.y;
					        u_xlat0.xw = _MainTex_TexelSize.ww * u_xlat0.xz + (-vs_TEXCOORD1.yy);
					        u_xlat0.xw = roundEven(u_xlat0.xw);
					        u_xlat0.xw = sqrt(abs(u_xlat0.xw));
					        u_xlat4.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = textureLod(_MainTex, u_xlat4.xy, 0.0).y;
					        u_xlat4.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat4.xy = roundEven(u_xlat4.xy);
					        u_xlat0.xy = u_xlat4.xy * vec2(16.0, 16.0) + u_xlat0.xw;
					        u_xlat0.xy = u_xlat0.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_0.xy = textureLod(_AreaTex, u_xlat0.xy, 0.0).xy;
					        SV_Target0.zw = u_xlat16_0.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					out highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.zzww;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-8.0, 8.0, -8.0, 8.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SearchTex;
					uniform mediump sampler2D _AreaTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					in highp vec4 vs_TEXCOORD4;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb8;
					vec2 u_xlat9;
					bool u_xlatb9;
					mediump float u_xlat16_12;
					bool u_xlatb12;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0.xy = texture(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb0.xy = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.yxyy).xy;
					    if(u_xlatb0.x){
					        u_xlat1.xy = vs_TEXCOORD2.xy;
					        u_xlat1.z = 1.0;
					        u_xlat2.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb0.x = !!(vs_TEXCOORD4.x<u_xlat1.x);
					#else
					            u_xlatb0.x = vs_TEXCOORD4.x<u_xlat1.x;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb8 = !!(0.828100026<u_xlat1.z);
					#else
					            u_xlatb8 = 0.828100026<u_xlat1.z;
					#endif
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb8 = !!(u_xlat2.x==0.0);
					#else
					            u_xlatb8 = u_xlat2.x==0.0;
					#endif
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            if(!u_xlatb0.x){break;}
					            u_xlat2.xy = textureLod(_MainTex, u_xlat1.xy, 0.0).xy;
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					            u_xlat1.z = u_xlat2.y;
					        }
					        u_xlat2.yz = u_xlat1.xz;
					        u_xlat0.xz = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0.x = textureLod(_SearchTex, u_xlat0.xz, 0.0).w;
					        u_xlat16_0.x = u_xlat16_0.x * -2.00787401 + 3.25;
					        u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_0.x + u_xlat2.y;
					        u_xlat1.y = vs_TEXCOORD3.y;
					        u_xlat0.x = textureLod(_MainTex, u_xlat1.xy, 0.0).x;
					        u_xlat2.xy = vs_TEXCOORD2.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(u_xlat2.x<vs_TEXCOORD4.y);
					#else
					            u_xlatb12 = u_xlat2.x<vs_TEXCOORD4.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb13 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb13 = u_xlat3.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.xz;
					        u_xlat2.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_12 = textureLod(_SearchTex, u_xlat2.xy, 0.0).w;
					        u_xlat16_12 = u_xlat16_12 * -2.00787401 + 3.25;
					        u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_12 + u_xlat3.y;
					        u_xlat1.xw = _MainTex_TexelSize.zz * u_xlat1.xz + (-vs_TEXCOORD1.xx);
					        u_xlat1.xw = roundEven(u_xlat1.xw);
					        u_xlat1.xw = sqrt(abs(u_xlat1.xw));
					        u_xlat5.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					        u_xlat0.z = textureLod(_MainTex, u_xlat5.xy, 0.0).x;
					        u_xlat0.xz = u_xlat0.xz * vec2(4.0, 4.0);
					        u_xlat0.xz = roundEven(u_xlat0.xz);
					        u_xlat0.xz = u_xlat0.xz * vec2(16.0, 16.0) + u_xlat1.xw;
					        u_xlat0.xz = u_xlat0.xz * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_0.xz = textureLod(_AreaTex, u_xlat0.xz, 0.0).xy;
					        SV_Target0.xy = u_xlat16_0.xz;
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    if(u_xlatb0.y){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(vs_TEXCOORD4.z<u_xlat0.y);
					#else
					            u_xlatb12 = vs_TEXCOORD4.z<u_xlat0.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(0.828100026<u_xlat0.z);
					#else
					            u_xlatb13 = 0.828100026<u_xlat0.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat1.x==0.0);
					#else
					            u_xlatb13 = u_xlat1.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat1.xy = textureLod(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0.x = textureLod(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0.x = u_xlat16_0.x * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0.x + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = textureLod(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(u_xlat2.y<vs_TEXCOORD4.w);
					#else
					            u_xlatb12 = u_xlat2.y<vs_TEXCOORD4.w;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb9 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb9 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb9 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb9 = u_xlat3.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat9.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_12 = textureLod(_SearchTex, u_xlat9.xy, 0.0).w;
					        u_xlat16_12 = u_xlat16_12 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_12 + u_xlat3.y;
					        u_xlat0.xw = _MainTex_TexelSize.ww * u_xlat0.xz + (-vs_TEXCOORD1.yy);
					        u_xlat0.xw = roundEven(u_xlat0.xw);
					        u_xlat0.xw = sqrt(abs(u_xlat0.xw));
					        u_xlat4.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = textureLod(_MainTex, u_xlat4.xy, 0.0).y;
					        u_xlat4.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat4.xy = roundEven(u_xlat4.xy);
					        u_xlat0.xy = u_xlat4.xy * vec2(16.0, 16.0) + u_xlat0.xw;
					        u_xlat0.xy = u_xlat0.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_0.xy = textureLod(_AreaTex, u_xlat0.xy, 0.0).xy;
					        SV_Target0.zw = u_xlat16_0.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					out highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.zzww;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-8.0, 8.0, -8.0, 8.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SearchTex;
					uniform mediump sampler2D _AreaTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					in highp vec4 vs_TEXCOORD4;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb8;
					vec2 u_xlat9;
					bool u_xlatb9;
					mediump float u_xlat16_12;
					bool u_xlatb12;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0.xy = texture(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb0.xy = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.yxyy).xy;
					    if(u_xlatb0.x){
					        u_xlat1.xy = vs_TEXCOORD2.xy;
					        u_xlat1.z = 1.0;
					        u_xlat2.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb0.x = !!(vs_TEXCOORD4.x<u_xlat1.x);
					#else
					            u_xlatb0.x = vs_TEXCOORD4.x<u_xlat1.x;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb8 = !!(0.828100026<u_xlat1.z);
					#else
					            u_xlatb8 = 0.828100026<u_xlat1.z;
					#endif
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb8 = !!(u_xlat2.x==0.0);
					#else
					            u_xlatb8 = u_xlat2.x==0.0;
					#endif
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            if(!u_xlatb0.x){break;}
					            u_xlat2.xy = textureLod(_MainTex, u_xlat1.xy, 0.0).xy;
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					            u_xlat1.z = u_xlat2.y;
					        }
					        u_xlat2.yz = u_xlat1.xz;
					        u_xlat0.xz = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0.x = textureLod(_SearchTex, u_xlat0.xz, 0.0).w;
					        u_xlat16_0.x = u_xlat16_0.x * -2.00787401 + 3.25;
					        u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_0.x + u_xlat2.y;
					        u_xlat1.y = vs_TEXCOORD3.y;
					        u_xlat0.x = textureLod(_MainTex, u_xlat1.xy, 0.0).x;
					        u_xlat2.xy = vs_TEXCOORD2.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(u_xlat2.x<vs_TEXCOORD4.y);
					#else
					            u_xlatb12 = u_xlat2.x<vs_TEXCOORD4.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb13 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb13 = u_xlat3.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.xz;
					        u_xlat2.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_12 = textureLod(_SearchTex, u_xlat2.xy, 0.0).w;
					        u_xlat16_12 = u_xlat16_12 * -2.00787401 + 3.25;
					        u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_12 + u_xlat3.y;
					        u_xlat1.xw = _MainTex_TexelSize.zz * u_xlat1.xz + (-vs_TEXCOORD1.xx);
					        u_xlat1.xw = roundEven(u_xlat1.xw);
					        u_xlat1.xw = sqrt(abs(u_xlat1.xw));
					        u_xlat5.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					        u_xlat0.z = textureLod(_MainTex, u_xlat5.xy, 0.0).x;
					        u_xlat0.xz = u_xlat0.xz * vec2(4.0, 4.0);
					        u_xlat0.xz = roundEven(u_xlat0.xz);
					        u_xlat0.xz = u_xlat0.xz * vec2(16.0, 16.0) + u_xlat1.xw;
					        u_xlat0.xz = u_xlat0.xz * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_0.xz = textureLod(_AreaTex, u_xlat0.xz, 0.0).xy;
					        SV_Target0.xy = u_xlat16_0.xz;
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    if(u_xlatb0.y){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(vs_TEXCOORD4.z<u_xlat0.y);
					#else
					            u_xlatb12 = vs_TEXCOORD4.z<u_xlat0.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(0.828100026<u_xlat0.z);
					#else
					            u_xlatb13 = 0.828100026<u_xlat0.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat1.x==0.0);
					#else
					            u_xlatb13 = u_xlat1.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat1.xy = textureLod(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0.x = textureLod(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0.x = u_xlat16_0.x * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0.x + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = textureLod(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(u_xlat2.y<vs_TEXCOORD4.w);
					#else
					            u_xlatb12 = u_xlat2.y<vs_TEXCOORD4.w;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb9 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb9 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb9 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb9 = u_xlat3.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat9.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_12 = textureLod(_SearchTex, u_xlat9.xy, 0.0).w;
					        u_xlat16_12 = u_xlat16_12 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_12 + u_xlat3.y;
					        u_xlat0.xw = _MainTex_TexelSize.ww * u_xlat0.xz + (-vs_TEXCOORD1.yy);
					        u_xlat0.xw = roundEven(u_xlat0.xw);
					        u_xlat0.xw = sqrt(abs(u_xlat0.xw));
					        u_xlat4.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = textureLod(_MainTex, u_xlat4.xy, 0.0).y;
					        u_xlat4.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat4.xy = roundEven(u_xlat4.xy);
					        u_xlat0.xy = u_xlat4.xy * vec2(16.0, 16.0) + u_xlat0.xw;
					        u_xlat0.xy = u_xlat0.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_0.xy = textureLod(_AreaTex, u_xlat0.xy, 0.0).xy;
					        SV_Target0.zw = u_xlat16_0.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
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
			GpuProgramID 276966
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.xzyw;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-16.0, 16.0, -16.0, 16.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SearchTex;
					uniform lowp sampler2D _AreaTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb8;
					vec2 u_xlat9;
					bool u_xlatb9;
					mediump float u_xlat16_12;
					lowp float u_xlat10_12;
					bool u_xlatb12;
					bool u_xlatb13;
					float roundEven(float x) { float y = floor(x + 0.5); return (y - x == 0.5) ? floor(0.5*y) * 2.0 : y; }
					vec2 roundEven(vec2 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); return a; }
					vec3 roundEven(vec3 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); return a; }
					vec4 roundEven(vec4 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); a.w = roundEven(a.w); return a; }
					
					void main()
					{
					    u_xlat0.xy = texture2D(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb0.xy = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.yxyy).xy;
					    if(u_xlatb0.x){
					        u_xlat1.xy = vs_TEXCOORD2.xy;
					        u_xlat1.z = 1.0;
					        u_xlat2.x = 0.0;
					        for(int u_xlati_while_true_0 = 0 ; u_xlati_while_true_0 < 0x7FFF ; u_xlati_while_true_0++){
					            u_xlatb0.x = vs_TEXCOORD4.x<u_xlat1.x;
					            u_xlatb8 = 0.828100026<u_xlat1.z;
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            u_xlatb8 = u_xlat2.x==0.0;
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            if(!u_xlatb0.x){break;}
					            u_xlat2.xy = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).xy;
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					            u_xlat1.z = u_xlat2.y;
					        }
					        u_xlat2.yz = u_xlat1.xz;
					        u_xlat0.xz = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0.x = texture2DLodEXT(_SearchTex, u_xlat0.xz, 0.0).w;
					        u_xlat16_0 = u_xlat10_0.x * -2.00787401 + 3.25;
					        u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_0 + u_xlat2.y;
					        u_xlat1.y = vs_TEXCOORD3.y;
					        u_xlat0.x = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).x;
					        u_xlat2.xy = vs_TEXCOORD2.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_1 = 0 ; u_xlati_while_true_1 < 0x7FFF ; u_xlati_while_true_1++){
					            u_xlatb12 = u_xlat2.x<vs_TEXCOORD4.y;
					            u_xlatb13 = 0.828100026<u_xlat2.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            u_xlatb13 = u_xlat3.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.xz;
					        u_xlat2.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_12 = texture2DLodEXT(_SearchTex, u_xlat2.xy, 0.0).w;
					        u_xlat16_12 = u_xlat10_12 * -2.00787401 + 3.25;
					        u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_12 + u_xlat3.y;
					        u_xlat1.xw = _MainTex_TexelSize.zz * u_xlat1.xz + (-vs_TEXCOORD1.xx);
					        u_xlat1.xw = roundEven(u_xlat1.xw);
					        u_xlat1.xw = sqrt(abs(u_xlat1.xw));
					        u_xlat5.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					        u_xlat0.z = texture2DLodEXT(_MainTex, u_xlat5.xy, 0.0).x;
					        u_xlat0.xz = u_xlat0.xz * vec2(4.0, 4.0);
					        u_xlat0.xz = roundEven(u_xlat0.xz);
					        u_xlat0.xz = u_xlat0.xz * vec2(16.0, 16.0) + u_xlat1.xw;
					        u_xlat0.xz = u_xlat0.xz * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_0.xz = texture2DLodEXT(_AreaTex, u_xlat0.xz, 0.0).xy;
					        SV_Target0.xy = u_xlat10_0.xz;
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    if(u_xlatb0.y){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        for(int u_xlati_while_true_2 = 0 ; u_xlati_while_true_2 < 0x7FFF ; u_xlati_while_true_2++){
					            u_xlatb12 = vs_TEXCOORD4.z<u_xlat0.y;
					            u_xlatb13 = 0.828100026<u_xlat0.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            u_xlatb13 = u_xlat1.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat1.xy = texture2DLodEXT(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0.x = texture2DLodEXT(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0 = u_xlat10_0.x * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0 + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = texture2DLodEXT(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_3 = 0 ; u_xlati_while_true_3 < 0x7FFF ; u_xlati_while_true_3++){
					            u_xlatb12 = u_xlat2.y<vs_TEXCOORD4.w;
					            u_xlatb9 = 0.828100026<u_xlat2.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            u_xlatb9 = u_xlat3.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat9.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_12 = texture2DLodEXT(_SearchTex, u_xlat9.xy, 0.0).w;
					        u_xlat16_12 = u_xlat10_12 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_12 + u_xlat3.y;
					        u_xlat0.xw = _MainTex_TexelSize.ww * u_xlat0.xz + (-vs_TEXCOORD1.yy);
					        u_xlat0.xw = roundEven(u_xlat0.xw);
					        u_xlat0.xw = sqrt(abs(u_xlat0.xw));
					        u_xlat4.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).y;
					        u_xlat4.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat4.xy = roundEven(u_xlat4.xy);
					        u_xlat0.xy = u_xlat4.xy * vec2(16.0, 16.0) + u_xlat0.xw;
					        u_xlat0.xy = u_xlat0.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_0.xy = texture2DLodEXT(_AreaTex, u_xlat0.xy, 0.0).xy;
					        SV_Target0.zw = u_xlat10_0.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.xzyw;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-16.0, 16.0, -16.0, 16.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SearchTex;
					uniform lowp sampler2D _AreaTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb8;
					vec2 u_xlat9;
					bool u_xlatb9;
					mediump float u_xlat16_12;
					lowp float u_xlat10_12;
					bool u_xlatb12;
					bool u_xlatb13;
					float roundEven(float x) { float y = floor(x + 0.5); return (y - x == 0.5) ? floor(0.5*y) * 2.0 : y; }
					vec2 roundEven(vec2 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); return a; }
					vec3 roundEven(vec3 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); return a; }
					vec4 roundEven(vec4 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); a.w = roundEven(a.w); return a; }
					
					void main()
					{
					    u_xlat0.xy = texture2D(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb0.xy = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.yxyy).xy;
					    if(u_xlatb0.x){
					        u_xlat1.xy = vs_TEXCOORD2.xy;
					        u_xlat1.z = 1.0;
					        u_xlat2.x = 0.0;
					        for(int u_xlati_while_true_0 = 0 ; u_xlati_while_true_0 < 0x7FFF ; u_xlati_while_true_0++){
					            u_xlatb0.x = vs_TEXCOORD4.x<u_xlat1.x;
					            u_xlatb8 = 0.828100026<u_xlat1.z;
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            u_xlatb8 = u_xlat2.x==0.0;
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            if(!u_xlatb0.x){break;}
					            u_xlat2.xy = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).xy;
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					            u_xlat1.z = u_xlat2.y;
					        }
					        u_xlat2.yz = u_xlat1.xz;
					        u_xlat0.xz = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0.x = texture2DLodEXT(_SearchTex, u_xlat0.xz, 0.0).w;
					        u_xlat16_0 = u_xlat10_0.x * -2.00787401 + 3.25;
					        u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_0 + u_xlat2.y;
					        u_xlat1.y = vs_TEXCOORD3.y;
					        u_xlat0.x = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).x;
					        u_xlat2.xy = vs_TEXCOORD2.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_1 = 0 ; u_xlati_while_true_1 < 0x7FFF ; u_xlati_while_true_1++){
					            u_xlatb12 = u_xlat2.x<vs_TEXCOORD4.y;
					            u_xlatb13 = 0.828100026<u_xlat2.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            u_xlatb13 = u_xlat3.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.xz;
					        u_xlat2.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_12 = texture2DLodEXT(_SearchTex, u_xlat2.xy, 0.0).w;
					        u_xlat16_12 = u_xlat10_12 * -2.00787401 + 3.25;
					        u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_12 + u_xlat3.y;
					        u_xlat1.xw = _MainTex_TexelSize.zz * u_xlat1.xz + (-vs_TEXCOORD1.xx);
					        u_xlat1.xw = roundEven(u_xlat1.xw);
					        u_xlat1.xw = sqrt(abs(u_xlat1.xw));
					        u_xlat5.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					        u_xlat0.z = texture2DLodEXT(_MainTex, u_xlat5.xy, 0.0).x;
					        u_xlat0.xz = u_xlat0.xz * vec2(4.0, 4.0);
					        u_xlat0.xz = roundEven(u_xlat0.xz);
					        u_xlat0.xz = u_xlat0.xz * vec2(16.0, 16.0) + u_xlat1.xw;
					        u_xlat0.xz = u_xlat0.xz * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_0.xz = texture2DLodEXT(_AreaTex, u_xlat0.xz, 0.0).xy;
					        SV_Target0.xy = u_xlat10_0.xz;
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    if(u_xlatb0.y){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        for(int u_xlati_while_true_2 = 0 ; u_xlati_while_true_2 < 0x7FFF ; u_xlati_while_true_2++){
					            u_xlatb12 = vs_TEXCOORD4.z<u_xlat0.y;
					            u_xlatb13 = 0.828100026<u_xlat0.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            u_xlatb13 = u_xlat1.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat1.xy = texture2DLodEXT(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0.x = texture2DLodEXT(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0 = u_xlat10_0.x * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0 + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = texture2DLodEXT(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_3 = 0 ; u_xlati_while_true_3 < 0x7FFF ; u_xlati_while_true_3++){
					            u_xlatb12 = u_xlat2.y<vs_TEXCOORD4.w;
					            u_xlatb9 = 0.828100026<u_xlat2.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            u_xlatb9 = u_xlat3.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat9.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_12 = texture2DLodEXT(_SearchTex, u_xlat9.xy, 0.0).w;
					        u_xlat16_12 = u_xlat10_12 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_12 + u_xlat3.y;
					        u_xlat0.xw = _MainTex_TexelSize.ww * u_xlat0.xz + (-vs_TEXCOORD1.yy);
					        u_xlat0.xw = roundEven(u_xlat0.xw);
					        u_xlat0.xw = sqrt(abs(u_xlat0.xw));
					        u_xlat4.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).y;
					        u_xlat4.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat4.xy = roundEven(u_xlat4.xy);
					        u_xlat0.xy = u_xlat4.xy * vec2(16.0, 16.0) + u_xlat0.xw;
					        u_xlat0.xy = u_xlat0.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_0.xy = texture2DLodEXT(_AreaTex, u_xlat0.xy, 0.0).xy;
					        SV_Target0.zw = u_xlat10_0.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.xzyw;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-16.0, 16.0, -16.0, 16.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _SearchTex;
					uniform lowp sampler2D _AreaTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					lowp vec3 u_xlat10_0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb8;
					vec2 u_xlat9;
					bool u_xlatb9;
					mediump float u_xlat16_12;
					lowp float u_xlat10_12;
					bool u_xlatb12;
					bool u_xlatb13;
					float roundEven(float x) { float y = floor(x + 0.5); return (y - x == 0.5) ? floor(0.5*y) * 2.0 : y; }
					vec2 roundEven(vec2 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); return a; }
					vec3 roundEven(vec3 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); return a; }
					vec4 roundEven(vec4 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); a.w = roundEven(a.w); return a; }
					
					void main()
					{
					    u_xlat0.xy = texture2D(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb0.xy = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.yxyy).xy;
					    if(u_xlatb0.x){
					        u_xlat1.xy = vs_TEXCOORD2.xy;
					        u_xlat1.z = 1.0;
					        u_xlat2.x = 0.0;
					        for(int u_xlati_while_true_0 = 0 ; u_xlati_while_true_0 < 0x7FFF ; u_xlati_while_true_0++){
					            u_xlatb0.x = vs_TEXCOORD4.x<u_xlat1.x;
					            u_xlatb8 = 0.828100026<u_xlat1.z;
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            u_xlatb8 = u_xlat2.x==0.0;
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            if(!u_xlatb0.x){break;}
					            u_xlat2.xy = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).xy;
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					            u_xlat1.z = u_xlat2.y;
					        }
					        u_xlat2.yz = u_xlat1.xz;
					        u_xlat0.xz = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0.x = texture2DLodEXT(_SearchTex, u_xlat0.xz, 0.0).w;
					        u_xlat16_0 = u_xlat10_0.x * -2.00787401 + 3.25;
					        u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_0 + u_xlat2.y;
					        u_xlat1.y = vs_TEXCOORD3.y;
					        u_xlat0.x = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).x;
					        u_xlat2.xy = vs_TEXCOORD2.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_1 = 0 ; u_xlati_while_true_1 < 0x7FFF ; u_xlati_while_true_1++){
					            u_xlatb12 = u_xlat2.x<vs_TEXCOORD4.y;
					            u_xlatb13 = 0.828100026<u_xlat2.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            u_xlatb13 = u_xlat3.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.xz;
					        u_xlat2.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_12 = texture2DLodEXT(_SearchTex, u_xlat2.xy, 0.0).w;
					        u_xlat16_12 = u_xlat10_12 * -2.00787401 + 3.25;
					        u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_12 + u_xlat3.y;
					        u_xlat1.xw = _MainTex_TexelSize.zz * u_xlat1.xz + (-vs_TEXCOORD1.xx);
					        u_xlat1.xw = roundEven(u_xlat1.xw);
					        u_xlat1.xw = sqrt(abs(u_xlat1.xw));
					        u_xlat5.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					        u_xlat0.z = texture2DLodEXT(_MainTex, u_xlat5.xy, 0.0).x;
					        u_xlat0.xz = u_xlat0.xz * vec2(4.0, 4.0);
					        u_xlat0.xz = roundEven(u_xlat0.xz);
					        u_xlat0.xz = u_xlat0.xz * vec2(16.0, 16.0) + u_xlat1.xw;
					        u_xlat0.xz = u_xlat0.xz * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_0.xz = texture2DLodEXT(_AreaTex, u_xlat0.xz, 0.0).xy;
					        SV_Target0.xy = u_xlat10_0.xz;
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    if(u_xlatb0.y){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        for(int u_xlati_while_true_2 = 0 ; u_xlati_while_true_2 < 0x7FFF ; u_xlati_while_true_2++){
					            u_xlatb12 = vs_TEXCOORD4.z<u_xlat0.y;
					            u_xlatb13 = 0.828100026<u_xlat0.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            u_xlatb13 = u_xlat1.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat1.xy = texture2DLodEXT(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0.x = texture2DLodEXT(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0 = u_xlat10_0.x * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0 + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = texture2DLodEXT(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_3 = 0 ; u_xlati_while_true_3 < 0x7FFF ; u_xlati_while_true_3++){
					            u_xlatb12 = u_xlat2.y<vs_TEXCOORD4.w;
					            u_xlatb9 = 0.828100026<u_xlat2.z;
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            u_xlatb9 = u_xlat3.x==0.0;
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat9.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_12 = texture2DLodEXT(_SearchTex, u_xlat9.xy, 0.0).w;
					        u_xlat16_12 = u_xlat10_12 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_12 + u_xlat3.y;
					        u_xlat0.xw = _MainTex_TexelSize.ww * u_xlat0.xz + (-vs_TEXCOORD1.yy);
					        u_xlat0.xw = roundEven(u_xlat0.xw);
					        u_xlat0.xw = sqrt(abs(u_xlat0.xw));
					        u_xlat4.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).y;
					        u_xlat4.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat4.xy = roundEven(u_xlat4.xy);
					        u_xlat0.xy = u_xlat4.xy * vec2(16.0, 16.0) + u_xlat0.xw;
					        u_xlat0.xy = u_xlat0.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_0.xy = texture2DLodEXT(_AreaTex, u_xlat0.xy, 0.0).xy;
					        SV_Target0.zw = u_xlat10_0.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					out highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.zzww;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-16.0, 16.0, -16.0, 16.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SearchTex;
					uniform mediump sampler2D _AreaTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					in highp vec4 vs_TEXCOORD4;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb8;
					vec2 u_xlat9;
					bool u_xlatb9;
					mediump float u_xlat16_12;
					bool u_xlatb12;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0.xy = texture(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb0.xy = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.yxyy).xy;
					    if(u_xlatb0.x){
					        u_xlat1.xy = vs_TEXCOORD2.xy;
					        u_xlat1.z = 1.0;
					        u_xlat2.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb0.x = !!(vs_TEXCOORD4.x<u_xlat1.x);
					#else
					            u_xlatb0.x = vs_TEXCOORD4.x<u_xlat1.x;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb8 = !!(0.828100026<u_xlat1.z);
					#else
					            u_xlatb8 = 0.828100026<u_xlat1.z;
					#endif
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb8 = !!(u_xlat2.x==0.0);
					#else
					            u_xlatb8 = u_xlat2.x==0.0;
					#endif
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            if(!u_xlatb0.x){break;}
					            u_xlat2.xy = textureLod(_MainTex, u_xlat1.xy, 0.0).xy;
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					            u_xlat1.z = u_xlat2.y;
					        }
					        u_xlat2.yz = u_xlat1.xz;
					        u_xlat0.xz = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0.x = textureLod(_SearchTex, u_xlat0.xz, 0.0).w;
					        u_xlat16_0.x = u_xlat16_0.x * -2.00787401 + 3.25;
					        u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_0.x + u_xlat2.y;
					        u_xlat1.y = vs_TEXCOORD3.y;
					        u_xlat0.x = textureLod(_MainTex, u_xlat1.xy, 0.0).x;
					        u_xlat2.xy = vs_TEXCOORD2.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(u_xlat2.x<vs_TEXCOORD4.y);
					#else
					            u_xlatb12 = u_xlat2.x<vs_TEXCOORD4.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb13 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb13 = u_xlat3.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.xz;
					        u_xlat2.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_12 = textureLod(_SearchTex, u_xlat2.xy, 0.0).w;
					        u_xlat16_12 = u_xlat16_12 * -2.00787401 + 3.25;
					        u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_12 + u_xlat3.y;
					        u_xlat1.xw = _MainTex_TexelSize.zz * u_xlat1.xz + (-vs_TEXCOORD1.xx);
					        u_xlat1.xw = roundEven(u_xlat1.xw);
					        u_xlat1.xw = sqrt(abs(u_xlat1.xw));
					        u_xlat5.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					        u_xlat0.z = textureLod(_MainTex, u_xlat5.xy, 0.0).x;
					        u_xlat0.xz = u_xlat0.xz * vec2(4.0, 4.0);
					        u_xlat0.xz = roundEven(u_xlat0.xz);
					        u_xlat0.xz = u_xlat0.xz * vec2(16.0, 16.0) + u_xlat1.xw;
					        u_xlat0.xz = u_xlat0.xz * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_0.xz = textureLod(_AreaTex, u_xlat0.xz, 0.0).xy;
					        SV_Target0.xy = u_xlat16_0.xz;
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    if(u_xlatb0.y){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(vs_TEXCOORD4.z<u_xlat0.y);
					#else
					            u_xlatb12 = vs_TEXCOORD4.z<u_xlat0.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(0.828100026<u_xlat0.z);
					#else
					            u_xlatb13 = 0.828100026<u_xlat0.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat1.x==0.0);
					#else
					            u_xlatb13 = u_xlat1.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat1.xy = textureLod(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0.x = textureLod(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0.x = u_xlat16_0.x * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0.x + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = textureLod(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(u_xlat2.y<vs_TEXCOORD4.w);
					#else
					            u_xlatb12 = u_xlat2.y<vs_TEXCOORD4.w;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb9 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb9 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb9 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb9 = u_xlat3.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat9.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_12 = textureLod(_SearchTex, u_xlat9.xy, 0.0).w;
					        u_xlat16_12 = u_xlat16_12 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_12 + u_xlat3.y;
					        u_xlat0.xw = _MainTex_TexelSize.ww * u_xlat0.xz + (-vs_TEXCOORD1.yy);
					        u_xlat0.xw = roundEven(u_xlat0.xw);
					        u_xlat0.xw = sqrt(abs(u_xlat0.xw));
					        u_xlat4.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = textureLod(_MainTex, u_xlat4.xy, 0.0).y;
					        u_xlat4.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat4.xy = roundEven(u_xlat4.xy);
					        u_xlat0.xy = u_xlat4.xy * vec2(16.0, 16.0) + u_xlat0.xw;
					        u_xlat0.xy = u_xlat0.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_0.xy = textureLod(_AreaTex, u_xlat0.xy, 0.0).xy;
					        SV_Target0.zw = u_xlat16_0.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					out highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.zzww;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-16.0, 16.0, -16.0, 16.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SearchTex;
					uniform mediump sampler2D _AreaTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					in highp vec4 vs_TEXCOORD4;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb8;
					vec2 u_xlat9;
					bool u_xlatb9;
					mediump float u_xlat16_12;
					bool u_xlatb12;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0.xy = texture(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb0.xy = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.yxyy).xy;
					    if(u_xlatb0.x){
					        u_xlat1.xy = vs_TEXCOORD2.xy;
					        u_xlat1.z = 1.0;
					        u_xlat2.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb0.x = !!(vs_TEXCOORD4.x<u_xlat1.x);
					#else
					            u_xlatb0.x = vs_TEXCOORD4.x<u_xlat1.x;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb8 = !!(0.828100026<u_xlat1.z);
					#else
					            u_xlatb8 = 0.828100026<u_xlat1.z;
					#endif
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb8 = !!(u_xlat2.x==0.0);
					#else
					            u_xlatb8 = u_xlat2.x==0.0;
					#endif
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            if(!u_xlatb0.x){break;}
					            u_xlat2.xy = textureLod(_MainTex, u_xlat1.xy, 0.0).xy;
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					            u_xlat1.z = u_xlat2.y;
					        }
					        u_xlat2.yz = u_xlat1.xz;
					        u_xlat0.xz = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0.x = textureLod(_SearchTex, u_xlat0.xz, 0.0).w;
					        u_xlat16_0.x = u_xlat16_0.x * -2.00787401 + 3.25;
					        u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_0.x + u_xlat2.y;
					        u_xlat1.y = vs_TEXCOORD3.y;
					        u_xlat0.x = textureLod(_MainTex, u_xlat1.xy, 0.0).x;
					        u_xlat2.xy = vs_TEXCOORD2.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(u_xlat2.x<vs_TEXCOORD4.y);
					#else
					            u_xlatb12 = u_xlat2.x<vs_TEXCOORD4.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb13 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb13 = u_xlat3.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.xz;
					        u_xlat2.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_12 = textureLod(_SearchTex, u_xlat2.xy, 0.0).w;
					        u_xlat16_12 = u_xlat16_12 * -2.00787401 + 3.25;
					        u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_12 + u_xlat3.y;
					        u_xlat1.xw = _MainTex_TexelSize.zz * u_xlat1.xz + (-vs_TEXCOORD1.xx);
					        u_xlat1.xw = roundEven(u_xlat1.xw);
					        u_xlat1.xw = sqrt(abs(u_xlat1.xw));
					        u_xlat5.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					        u_xlat0.z = textureLod(_MainTex, u_xlat5.xy, 0.0).x;
					        u_xlat0.xz = u_xlat0.xz * vec2(4.0, 4.0);
					        u_xlat0.xz = roundEven(u_xlat0.xz);
					        u_xlat0.xz = u_xlat0.xz * vec2(16.0, 16.0) + u_xlat1.xw;
					        u_xlat0.xz = u_xlat0.xz * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_0.xz = textureLod(_AreaTex, u_xlat0.xz, 0.0).xy;
					        SV_Target0.xy = u_xlat16_0.xz;
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    if(u_xlatb0.y){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(vs_TEXCOORD4.z<u_xlat0.y);
					#else
					            u_xlatb12 = vs_TEXCOORD4.z<u_xlat0.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(0.828100026<u_xlat0.z);
					#else
					            u_xlatb13 = 0.828100026<u_xlat0.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat1.x==0.0);
					#else
					            u_xlatb13 = u_xlat1.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat1.xy = textureLod(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0.x = textureLod(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0.x = u_xlat16_0.x * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0.x + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = textureLod(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(u_xlat2.y<vs_TEXCOORD4.w);
					#else
					            u_xlatb12 = u_xlat2.y<vs_TEXCOORD4.w;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb9 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb9 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb9 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb9 = u_xlat3.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat9.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_12 = textureLod(_SearchTex, u_xlat9.xy, 0.0).w;
					        u_xlat16_12 = u_xlat16_12 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_12 + u_xlat3.y;
					        u_xlat0.xw = _MainTex_TexelSize.ww * u_xlat0.xz + (-vs_TEXCOORD1.yy);
					        u_xlat0.xw = roundEven(u_xlat0.xw);
					        u_xlat0.xw = sqrt(abs(u_xlat0.xw));
					        u_xlat4.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = textureLod(_MainTex, u_xlat4.xy, 0.0).y;
					        u_xlat4.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat4.xy = roundEven(u_xlat4.xy);
					        u_xlat0.xy = u_xlat4.xy * vec2(16.0, 16.0) + u_xlat0.xw;
					        u_xlat0.xy = u_xlat0.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_0.xy = textureLod(_AreaTex, u_xlat0.xy, 0.0).xy;
					        SV_Target0.zw = u_xlat16_0.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					out highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.zzww;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-16.0, 16.0, -16.0, 16.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _SearchTex;
					uniform mediump sampler2D _AreaTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					in highp vec4 vs_TEXCOORD4;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump vec3 u_xlat16_0;
					bvec2 u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
					vec3 u_xlat3;
					vec2 u_xlat4;
					vec2 u_xlat5;
					bool u_xlatb8;
					vec2 u_xlat9;
					bool u_xlatb9;
					mediump float u_xlat16_12;
					bool u_xlatb12;
					bool u_xlatb13;
					void main()
					{
					    u_xlat0.xy = texture(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb0.xy = lessThan(vec4(0.0, 0.0, 0.0, 0.0), u_xlat0.yxyy).xy;
					    if(u_xlatb0.x){
					        u_xlat1.xy = vs_TEXCOORD2.xy;
					        u_xlat1.z = 1.0;
					        u_xlat2.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb0.x = !!(vs_TEXCOORD4.x<u_xlat1.x);
					#else
					            u_xlatb0.x = vs_TEXCOORD4.x<u_xlat1.x;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb8 = !!(0.828100026<u_xlat1.z);
					#else
					            u_xlatb8 = 0.828100026<u_xlat1.z;
					#endif
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb8 = !!(u_xlat2.x==0.0);
					#else
					            u_xlatb8 = u_xlat2.x==0.0;
					#endif
					            u_xlatb0.x = u_xlatb8 && u_xlatb0.x;
					            if(!u_xlatb0.x){break;}
					            u_xlat2.xy = textureLod(_MainTex, u_xlat1.xy, 0.0).xy;
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					            u_xlat1.z = u_xlat2.y;
					        }
					        u_xlat2.yz = u_xlat1.xz;
					        u_xlat0.xz = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0.x = textureLod(_SearchTex, u_xlat0.xz, 0.0).w;
					        u_xlat16_0.x = u_xlat16_0.x * -2.00787401 + 3.25;
					        u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_0.x + u_xlat2.y;
					        u_xlat1.y = vs_TEXCOORD3.y;
					        u_xlat0.x = textureLod(_MainTex, u_xlat1.xy, 0.0).x;
					        u_xlat2.xy = vs_TEXCOORD2.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(u_xlat2.x<vs_TEXCOORD4.y);
					#else
					            u_xlatb12 = u_xlat2.x<vs_TEXCOORD4.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb13 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb13 = u_xlat3.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.xz;
					        u_xlat2.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_12 = textureLod(_SearchTex, u_xlat2.xy, 0.0).w;
					        u_xlat16_12 = u_xlat16_12 * -2.00787401 + 3.25;
					        u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_12 + u_xlat3.y;
					        u_xlat1.xw = _MainTex_TexelSize.zz * u_xlat1.xz + (-vs_TEXCOORD1.xx);
					        u_xlat1.xw = roundEven(u_xlat1.xw);
					        u_xlat1.xw = sqrt(abs(u_xlat1.xw));
					        u_xlat5.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					        u_xlat0.z = textureLod(_MainTex, u_xlat5.xy, 0.0).x;
					        u_xlat0.xz = u_xlat0.xz * vec2(4.0, 4.0);
					        u_xlat0.xz = roundEven(u_xlat0.xz);
					        u_xlat0.xz = u_xlat0.xz * vec2(16.0, 16.0) + u_xlat1.xw;
					        u_xlat0.xz = u_xlat0.xz * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_0.xz = textureLod(_AreaTex, u_xlat0.xz, 0.0).xy;
					        SV_Target0.xy = u_xlat16_0.xz;
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    if(u_xlatb0.y){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(vs_TEXCOORD4.z<u_xlat0.y);
					#else
					            u_xlatb12 = vs_TEXCOORD4.z<u_xlat0.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(0.828100026<u_xlat0.z);
					#else
					            u_xlatb13 = 0.828100026<u_xlat0.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat1.x==0.0);
					#else
					            u_xlatb13 = u_xlat1.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb13;
					            if(!u_xlatb12){break;}
					            u_xlat1.xy = textureLod(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0.x = textureLod(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0.x = u_xlat16_0.x * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0.x + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = textureLod(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb12 = !!(u_xlat2.y<vs_TEXCOORD4.w);
					#else
					            u_xlatb12 = u_xlat2.y<vs_TEXCOORD4.w;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb9 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb9 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb9 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb9 = u_xlat3.x==0.0;
					#endif
					            u_xlatb12 = u_xlatb12 && u_xlatb9;
					            if(!u_xlatb12){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat9.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_12 = textureLod(_SearchTex, u_xlat9.xy, 0.0).w;
					        u_xlat16_12 = u_xlat16_12 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_12 + u_xlat3.y;
					        u_xlat0.xw = _MainTex_TexelSize.ww * u_xlat0.xz + (-vs_TEXCOORD1.yy);
					        u_xlat0.xw = roundEven(u_xlat0.xw);
					        u_xlat0.xw = sqrt(abs(u_xlat0.xw));
					        u_xlat4.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = textureLod(_MainTex, u_xlat4.xy, 0.0).y;
					        u_xlat4.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat4.xy = roundEven(u_xlat4.xy);
					        u_xlat0.xy = u_xlat4.xy * vec2(16.0, 16.0) + u_xlat0.xw;
					        u_xlat0.xy = u_xlat0.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_0.xy = textureLod(_AreaTex, u_xlat0.xy, 0.0).xy;
					        SV_Target0.zw = u_xlat16_0.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
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
			GpuProgramID 340593
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.xzyw;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-32.0, 32.0, -32.0, 32.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _AreaTex;
					uniform lowp sampler2D _SearchTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec4 u_xlat1;
					lowp vec2 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec2 u_xlat10_2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					lowp vec2 u_xlat10_3;
					bvec4 u_xlatb3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					lowp vec2 u_xlat10_5;
					vec3 u_xlat6;
					lowp float u_xlat10_6;
					bool u_xlatb6;
					vec3 u_xlat7;
					lowp vec3 u_xlat10_7;
					bvec3 u_xlatb7;
					vec3 u_xlat8;
					vec2 u_xlat13;
					mediump float u_xlat16_13;
					lowp float u_xlat10_13;
					bool u_xlatb13;
					vec2 u_xlat14;
					bool u_xlatb14;
					lowp vec2 u_xlat10_15;
					bool u_xlatb15;
					float u_xlat18;
					mediump float u_xlat16_18;
					lowp float u_xlat10_18;
					bool u_xlatb18;
					float u_xlat19;
					mediump float u_xlat16_19;
					bool u_xlatb19;
					float u_xlat20;
					bool u_xlatb21;
					float roundEven(float x) { float y = floor(x + 0.5); return (y - x == 0.5) ? floor(0.5*y) * 2.0 : y; }
					vec2 roundEven(vec2 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); return a; }
					vec3 roundEven(vec3 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); return a; }
					vec4 roundEven(vec4 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); a.w = roundEven(a.w); return a; }
					
					void main()
					{
					    u_xlat0.xy = texture2D(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb6 = 0.0<u_xlat0.y;
					    if(u_xlatb6){
					        u_xlatb6 = 0.0<u_xlat0.x;
					        if(u_xlatb6){
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-1.0, 1.0);
					            u_xlat1.z = 1.0;
					            u_xlat2.xy = vs_TEXCOORD0.xy;
					            u_xlat6.x = 0.0;
					            u_xlat2.z = -1.0;
					            u_xlat3.x = 1.0;
					            for(int u_xlati_while_true_0 = 0 ; u_xlati_while_true_0 < 0x7FFF ; u_xlati_while_true_0++){
					                u_xlatb18 = u_xlat2.z<7.0;
					                u_xlatb19 = 0.899999976<u_xlat3.x;
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                if(!u_xlatb18){break;}
					                u_xlat2.xyz = u_xlat1.xyz + u_xlat2.xyz;
					                u_xlat6.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).yx;
					                u_xlat3.x = dot(u_xlat6.yx, vec2(0.5, 0.5));
					            }
					            u_xlatb6 = 0.899999976<u_xlat6.x;
					            u_xlat6.x = u_xlatb6 ? 1.0 : float(0.0);
					            u_xlat1.x = u_xlat6.x + u_xlat2.z;
					        } else {
					            u_xlat1.x = 0.0;
					            u_xlat3.x = 0.0;
					        //ENDIF
					        }
					        u_xlat6.xy = _MainTex_TexelSize.xy * vec2(1.0, -1.0);
					        u_xlat6.z = 1.0;
					        u_xlat2.yz = vs_TEXCOORD0.xy;
					        u_xlat2.x = float(-1.0);
					        u_xlat20 = float(1.0);
					        for(int u_xlati_while_true_1 = 0 ; u_xlati_while_true_1 < 0x7FFF ; u_xlati_while_true_1++){
					            u_xlatb15 = u_xlat2.x<7.0;
					            u_xlatb21 = 0.899999976<u_xlat20;
					            u_xlatb15 = u_xlatb21 && u_xlatb15;
					            if(!u_xlatb15){break;}
					            u_xlat2.xyz = u_xlat6.zxy + u_xlat2.xyz;
					            u_xlat10_15.xy = texture2DLodEXT(_MainTex, u_xlat2.yz, 0.0).xy;
					            u_xlat20 = dot(u_xlat10_15.xy, vec2(0.5, 0.5));
					        }
					        u_xlat3.y = u_xlat20;
					        u_xlat6.x = u_xlat1.x + u_xlat2.x;
					        u_xlatb6 = 2.0<u_xlat6.x;
					        if(u_xlatb6){
					            u_xlat1.y = (-u_xlat1.x) + 0.25;
					            u_xlat1.zw = u_xlat2.xx * vec2(1.0, -1.0) + vec2(0.0, -0.25);
					            u_xlat2 = u_xlat1.yxzw * _MainTex_TexelSize.xyxy + vs_TEXCOORD0.xyxy;
					            u_xlat2 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + u_xlat2;
					            u_xlat6.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat10_7.xz = texture2DLodEXT(_MainTex, u_xlat2.zw, 0.0).xy;
					            u_xlat6.z = u_xlat10_7.x;
					            u_xlat2.xy = u_xlat6.xz * vec2(5.0, 5.0) + vec2(-3.75, -3.75);
					            u_xlat6.xz = u_xlat6.xz * abs(u_xlat2.xy);
					            u_xlat6.xz = roundEven(u_xlat6.xz);
					            u_xlat8.x = roundEven(u_xlat6.y);
					            u_xlat8.z = roundEven(u_xlat10_7.z);
					            u_xlat6.xy = u_xlat8.xz * vec2(2.0, 2.0) + u_xlat6.xz;
					            u_xlatb7.xz = greaterThanEqual(u_xlat3.xxyy, vec4(0.899999976, 0.0, 0.899999976, 0.899999976)).xz;
					            {
					                vec3 hlslcc_movcTemp = u_xlat6;
					                hlslcc_movcTemp.x = (u_xlatb7.x) ? float(0.0) : u_xlat6.x;
					                hlslcc_movcTemp.y = (u_xlatb7.z) ? float(0.0) : u_xlat6.y;
					                u_xlat6 = hlslcc_movcTemp;
					            }
					            u_xlat6.xy = u_xlat6.xy * vec2(20.0, 20.0) + u_xlat1.xz;
					            u_xlat6.xy = u_xlat6.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.503125012, 0.000892857148);
					            u_xlat6.xy = texture2DLodEXT(_AreaTex, u_xlat6.xy, 0.0).xy;
					        } else {
					            u_xlat6.x = float(0.0);
					            u_xlat6.y = float(0.0);
					        //ENDIF
					        }
					        u_xlat18 = _MainTex_TexelSize.x * 0.25 + vs_TEXCOORD0.x;
					        u_xlat1.xy = (-_MainTex_TexelSize.xy);
					        u_xlat1.z = 1.0;
					        u_xlat8.x = u_xlat18;
					        u_xlat8.y = vs_TEXCOORD0.y;
					        u_xlat2.x = float(1.0);
					        u_xlat8.z = float(-1.0);
					        for(int u_xlati_while_true_2 = 0 ; u_xlati_while_true_2 < 0x7FFF ; u_xlati_while_true_2++){
					            u_xlatb19 = u_xlat8.z<7.0;
					            u_xlatb3.x = 0.899999976<u_xlat2.x;
					            u_xlatb19 = u_xlatb19 && u_xlatb3.x;
					            if(!u_xlatb19){break;}
					            u_xlat8.xyz = u_xlat1.xyz + u_xlat8.xyz;
					            u_xlat10_3.xy = texture2DLodEXT(_MainTex, u_xlat8.xy, 0.0).xy;
					            u_xlat16_19 = u_xlat10_3.x * 5.0 + -3.75;
					            u_xlat19 = abs(u_xlat16_19) * u_xlat10_3.x;
					            u_xlat4.x = roundEven(u_xlat19);
					            u_xlat4.y = roundEven(u_xlat10_3.y);
					            u_xlat2.x = dot(u_xlat4.xy, vec2(0.5, 0.5));
					        }
					        u_xlat1.x = u_xlat8.z;
					        u_xlat14.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + vs_TEXCOORD0.xy;
					        u_xlat19 = texture2DLodEXT(_MainTex, u_xlat14.xy, 0.0).x;
					        u_xlatb19 = 0.0<u_xlat19;
					        if(u_xlatb19){
					            u_xlat3.xy = _MainTex_TexelSize.xy;
					            u_xlat3.z = 1.0;
					            u_xlat4.x = u_xlat18;
					            u_xlat4.y = vs_TEXCOORD0.y;
					            u_xlat4.z = -1.0;
					            u_xlat2.y = float(1.0);
					            u_xlat14.x = float(0.0);
					            for(int u_xlati_while_true_3 = 0 ; u_xlati_while_true_3 < 0x7FFF ; u_xlati_while_true_3++){
					                u_xlatb19 = u_xlat4.z<7.0;
					                u_xlatb21 = 0.899999976<u_xlat2.y;
					                u_xlatb19 = u_xlatb19 && u_xlatb21;
					                if(!u_xlatb19){break;}
					                u_xlat4.xyz = u_xlat3.xyz + u_xlat4.xyz;
					                u_xlat10_5.xy = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).xy;
					                u_xlat16_19 = u_xlat10_5.x * 5.0 + -3.75;
					                u_xlat19 = abs(u_xlat16_19) * u_xlat10_5.x;
					                u_xlat14.y = roundEven(u_xlat19);
					                u_xlat14.x = roundEven(u_xlat10_5.y);
					                u_xlat2.y = dot(u_xlat14.yx, vec2(0.5, 0.5));
					            }
					            u_xlatb18 = 0.899999976<u_xlat14.x;
					            u_xlat18 = u_xlatb18 ? 1.0 : float(0.0);
					            u_xlat1.z = u_xlat18 + u_xlat4.z;
					        } else {
					            u_xlat1.z = 0.0;
					            u_xlat2.y = 0.0;
					        //ENDIF
					        }
					        u_xlat18 = u_xlat1.z + u_xlat1.x;
					        u_xlatb18 = 2.0<u_xlat18;
					        if(u_xlatb18){
					            u_xlat1.y = (-u_xlat1.x);
					            u_xlat3 = u_xlat1.yyzz * _MainTex_TexelSize.xyxy + vs_TEXCOORD0.xyxy;
					            u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat3.xyxy;
					            u_xlat5.x = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).y;
					            u_xlat5.z = texture2DLodEXT(_MainTex, u_xlat4.zw, 0.0).x;
					            u_xlat7.xz = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat3.zw;
					            u_xlat5.yw = texture2DLodEXT(_MainTex, u_xlat7.xz, 0.0).yx;
					            u_xlat7.xz = u_xlat5.xy * vec2(2.0, 2.0) + u_xlat5.zw;
					            u_xlatb2.xy = greaterThanEqual(u_xlat2.xyxx, vec4(0.899999976, 0.899999976, 0.0, 0.0)).xy;
					            {
					                vec3 hlslcc_movcTemp = u_xlat7;
					                hlslcc_movcTemp.x = (u_xlatb2.x) ? float(0.0) : u_xlat7.x;
					                hlslcc_movcTemp.z = (u_xlatb2.y) ? float(0.0) : u_xlat7.z;
					                u_xlat7 = hlslcc_movcTemp;
					            }
					            u_xlat1.xy = u_xlat7.xz * vec2(20.0, 20.0) + u_xlat1.xz;
					            u_xlat1.xy = u_xlat1.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.503125012, 0.000892857148);
					            u_xlat10_1.xy = texture2DLodEXT(_AreaTex, u_xlat1.xy, 0.0).xy;
					            u_xlat6.xy = u_xlat6.xy + u_xlat10_1.yx;
					        //ENDIF
					        }
					        u_xlatb18 = (-u_xlat6.y)==u_xlat6.x;
					        if(u_xlatb18){
					            u_xlat1.xy = vs_TEXCOORD2.xy;
					            u_xlat1.z = 1.0;
					            u_xlat2.x = 0.0;
					            for(int u_xlati_while_true_4 = 0 ; u_xlati_while_true_4 < 0x7FFF ; u_xlati_while_true_4++){
					                u_xlatb18 = vs_TEXCOORD4.x<u_xlat1.x;
					                u_xlatb19 = 0.828100026<u_xlat1.z;
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                u_xlatb19 = u_xlat2.x==0.0;
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                if(!u_xlatb18){break;}
					                u_xlat2.xy = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).xy;
					                u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					                u_xlat1.z = u_xlat2.y;
					            }
					            u_xlat2.yz = u_xlat1.xz;
					            u_xlat1.xy = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					            u_xlat10_18 = texture2DLodEXT(_SearchTex, u_xlat1.xy, 0.0).w;
					            u_xlat16_18 = u_xlat10_18 * -2.00787401 + 3.25;
					            u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_18 + u_xlat2.y;
					            u_xlat1.y = vs_TEXCOORD3.y;
					            u_xlat2.x = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).x;
					            u_xlat3.xy = vs_TEXCOORD2.zw;
					            u_xlat3.z = 1.0;
					            u_xlat4.x = 0.0;
					            for(int u_xlati_while_true_5 = 0 ; u_xlati_while_true_5 < 0x7FFF ; u_xlati_while_true_5++){
					                u_xlatb18 = u_xlat3.x<vs_TEXCOORD4.y;
					                u_xlatb14 = 0.828100026<u_xlat3.z;
					                u_xlatb18 = u_xlatb18 && u_xlatb14;
					                u_xlatb14 = u_xlat4.x==0.0;
					                u_xlatb18 = u_xlatb18 && u_xlatb14;
					                if(!u_xlatb18){break;}
					                u_xlat4.xy = texture2DLodEXT(_MainTex, u_xlat3.xy, 0.0).xy;
					                u_xlat3.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat3.xy;
					                u_xlat3.z = u_xlat4.y;
					            }
					            u_xlat4.yz = u_xlat3.xz;
					            u_xlat14.xy = u_xlat4.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					            u_xlat10_18 = texture2DLodEXT(_SearchTex, u_xlat14.xy, 0.0).w;
					            u_xlat16_18 = u_xlat10_18 * -2.00787401 + 3.25;
					            u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_18 + u_xlat4.y;
					            u_xlat3 = _MainTex_TexelSize.zzzz * u_xlat1.zxzx + (-vs_TEXCOORD1.xxxx);
					            u_xlat3 = roundEven(u_xlat3);
					            u_xlat14.xy = sqrt(abs(u_xlat3.wz));
					            u_xlat4.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					            u_xlat2.y = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).x;
					            u_xlat2.xy = u_xlat2.xy * vec2(4.0, 4.0);
					            u_xlat2.xy = roundEven(u_xlat2.xy);
					            u_xlat2.xy = u_xlat2.xy * vec2(16.0, 16.0) + u_xlat14.xy;
					            u_xlat2.xy = u_xlat2.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					            u_xlat10_2.xy = texture2DLodEXT(_AreaTex, u_xlat2.xy, 0.0).xy;
					            u_xlatb3 = greaterThanEqual(abs(u_xlat3), abs(u_xlat3.wzwz));
					            u_xlat3 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 0.75, 0.75), vec4(u_xlatb3));
					            u_xlat18 = u_xlat3.y + u_xlat3.x;
					            u_xlat14.xy = u_xlat3.zw / vec2(u_xlat18);
					            u_xlat1.w = vs_TEXCOORD0.y;
					            u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat1.xw;
					            u_xlat10_18 = texture2DLodEXT(_MainTex, u_xlat3.xy, 0.0).x;
					            u_xlat18 = (-u_xlat14.x) * u_xlat10_18 + 1.0;
					            u_xlat3.xy = u_xlat1.zw + _MainTex_TexelSize.xy;
					            u_xlat10_7.x = texture2DLodEXT(_MainTex, u_xlat3.xy, 0.0).x;
					            u_xlat3.x = (-u_xlat14.y) * u_xlat10_7.x + u_xlat18;
					            u_xlat3.x = clamp(u_xlat3.x, 0.0, 1.0);
					            u_xlat1 = _MainTex_TexelSize.xyxy * vec4(0.0, -2.0, 1.0, -2.0) + u_xlat1.xwzw;
					            u_xlat10_18 = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).x;
					            u_xlat18 = (-u_xlat14.x) * u_xlat10_18 + 1.0;
					            u_xlat10_1.x = texture2DLodEXT(_MainTex, u_xlat1.zw, 0.0).x;
					            u_xlat3.y = (-u_xlat14.y) * u_xlat10_1.x + u_xlat18;
					            u_xlat3.y = clamp(u_xlat3.y, 0.0, 1.0);
					            SV_Target0.xy = u_xlat10_2.xy * u_xlat3.xy;
					        } else {
					            SV_Target0.xy = u_xlat6.xy;
					            u_xlat0.x = 0.0;
					        //ENDIF
					        }
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    u_xlatb0 = 0.0<u_xlat0.x;
					    if(u_xlatb0){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        for(int u_xlati_while_true_6 = 0 ; u_xlati_while_true_6 < 0x7FFF ; u_xlati_while_true_6++){
					            u_xlatb18 = vs_TEXCOORD4.z<u_xlat0.y;
					            u_xlatb19 = 0.828100026<u_xlat0.z;
					            u_xlatb18 = u_xlatb18 && u_xlatb19;
					            u_xlatb19 = u_xlat1.x==0.0;
					            u_xlatb18 = u_xlatb18 && u_xlatb19;
					            if(!u_xlatb18){break;}
					            u_xlat1.xy = texture2DLodEXT(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0 = texture2DLodEXT(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0 = u_xlat10_0 * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0 + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = texture2DLodEXT(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_7 = 0 ; u_xlati_while_true_7 < 0x7FFF ; u_xlati_while_true_7++){
					            u_xlatb13 = u_xlat2.y<vs_TEXCOORD4.w;
					            u_xlatb19 = 0.828100026<u_xlat2.z;
					            u_xlatb13 = u_xlatb19 && u_xlatb13;
					            u_xlatb19 = u_xlat3.x==0.0;
					            u_xlatb13 = u_xlatb19 && u_xlatb13;
					            if(!u_xlatb13){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat13.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_13 = texture2DLodEXT(_SearchTex, u_xlat13.xy, 0.0).w;
					        u_xlat16_13 = u_xlat10_13 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_13 + u_xlat3.y;
					        u_xlat2 = _MainTex_TexelSize.wwww * u_xlat0.zxzx + (-vs_TEXCOORD1.yyyy);
					        u_xlat2 = roundEven(u_xlat2);
					        u_xlat13.xy = sqrt(abs(u_xlat2.wz));
					        u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = texture2DLodEXT(_MainTex, u_xlat3.xy, 0.0).y;
					        u_xlat1.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat1.xy = roundEven(u_xlat1.xy);
					        u_xlat1.xy = u_xlat1.xy * vec2(16.0, 16.0) + u_xlat13.xy;
					        u_xlat1.xy = u_xlat1.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_1.xy = texture2DLodEXT(_AreaTex, u_xlat1.xy, 0.0).xy;
					        u_xlatb2 = greaterThanEqual(abs(u_xlat2), abs(u_xlat2.wzwz));
					        u_xlat2 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 0.75, 0.75), vec4(u_xlatb2));
					        u_xlat6.x = u_xlat2.y + u_xlat2.x;
					        u_xlat13.xy = u_xlat2.zw / u_xlat6.xx;
					        u_xlat0.w = vs_TEXCOORD0.x;
					        u_xlat2.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat0.wx;
					        u_xlat10_6 = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).y;
					        u_xlat6.x = (-u_xlat13.x) * u_xlat10_6 + 1.0;
					        u_xlat2.xy = u_xlat0.wz + _MainTex_TexelSize.xy;
					        u_xlat10_2.x = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).y;
					        u_xlat14.x = (-u_xlat13.y) * u_xlat10_2.x + u_xlat6.x;
					        u_xlat14.x = clamp(u_xlat14.x, 0.0, 1.0);
					        u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, -2.0, 1.0) + u_xlat0.wxwz;
					        u_xlat10_0 = texture2DLodEXT(_MainTex, u_xlat0.xy, 0.0).y;
					        u_xlat0.x = (-u_xlat13.x) * u_xlat10_0 + 1.0;
					        u_xlat10_6 = texture2DLodEXT(_MainTex, u_xlat0.zw, 0.0).y;
					        u_xlat14.y = (-u_xlat13.y) * u_xlat10_6 + u_xlat0.x;
					        u_xlat14.y = clamp(u_xlat14.y, 0.0, 1.0);
					        SV_Target0.zw = u_xlat10_1.xy * u_xlat14.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.xzyw;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-32.0, 32.0, -32.0, 32.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _AreaTex;
					uniform lowp sampler2D _SearchTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec4 u_xlat1;
					lowp vec2 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec2 u_xlat10_2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					lowp vec2 u_xlat10_3;
					bvec4 u_xlatb3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					lowp vec2 u_xlat10_5;
					vec3 u_xlat6;
					lowp float u_xlat10_6;
					bool u_xlatb6;
					vec3 u_xlat7;
					lowp vec3 u_xlat10_7;
					bvec3 u_xlatb7;
					vec3 u_xlat8;
					vec2 u_xlat13;
					mediump float u_xlat16_13;
					lowp float u_xlat10_13;
					bool u_xlatb13;
					vec2 u_xlat14;
					bool u_xlatb14;
					lowp vec2 u_xlat10_15;
					bool u_xlatb15;
					float u_xlat18;
					mediump float u_xlat16_18;
					lowp float u_xlat10_18;
					bool u_xlatb18;
					float u_xlat19;
					mediump float u_xlat16_19;
					bool u_xlatb19;
					float u_xlat20;
					bool u_xlatb21;
					float roundEven(float x) { float y = floor(x + 0.5); return (y - x == 0.5) ? floor(0.5*y) * 2.0 : y; }
					vec2 roundEven(vec2 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); return a; }
					vec3 roundEven(vec3 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); return a; }
					vec4 roundEven(vec4 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); a.w = roundEven(a.w); return a; }
					
					void main()
					{
					    u_xlat0.xy = texture2D(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb6 = 0.0<u_xlat0.y;
					    if(u_xlatb6){
					        u_xlatb6 = 0.0<u_xlat0.x;
					        if(u_xlatb6){
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-1.0, 1.0);
					            u_xlat1.z = 1.0;
					            u_xlat2.xy = vs_TEXCOORD0.xy;
					            u_xlat6.x = 0.0;
					            u_xlat2.z = -1.0;
					            u_xlat3.x = 1.0;
					            for(int u_xlati_while_true_0 = 0 ; u_xlati_while_true_0 < 0x7FFF ; u_xlati_while_true_0++){
					                u_xlatb18 = u_xlat2.z<7.0;
					                u_xlatb19 = 0.899999976<u_xlat3.x;
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                if(!u_xlatb18){break;}
					                u_xlat2.xyz = u_xlat1.xyz + u_xlat2.xyz;
					                u_xlat6.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).yx;
					                u_xlat3.x = dot(u_xlat6.yx, vec2(0.5, 0.5));
					            }
					            u_xlatb6 = 0.899999976<u_xlat6.x;
					            u_xlat6.x = u_xlatb6 ? 1.0 : float(0.0);
					            u_xlat1.x = u_xlat6.x + u_xlat2.z;
					        } else {
					            u_xlat1.x = 0.0;
					            u_xlat3.x = 0.0;
					        //ENDIF
					        }
					        u_xlat6.xy = _MainTex_TexelSize.xy * vec2(1.0, -1.0);
					        u_xlat6.z = 1.0;
					        u_xlat2.yz = vs_TEXCOORD0.xy;
					        u_xlat2.x = float(-1.0);
					        u_xlat20 = float(1.0);
					        for(int u_xlati_while_true_1 = 0 ; u_xlati_while_true_1 < 0x7FFF ; u_xlati_while_true_1++){
					            u_xlatb15 = u_xlat2.x<7.0;
					            u_xlatb21 = 0.899999976<u_xlat20;
					            u_xlatb15 = u_xlatb21 && u_xlatb15;
					            if(!u_xlatb15){break;}
					            u_xlat2.xyz = u_xlat6.zxy + u_xlat2.xyz;
					            u_xlat10_15.xy = texture2DLodEXT(_MainTex, u_xlat2.yz, 0.0).xy;
					            u_xlat20 = dot(u_xlat10_15.xy, vec2(0.5, 0.5));
					        }
					        u_xlat3.y = u_xlat20;
					        u_xlat6.x = u_xlat1.x + u_xlat2.x;
					        u_xlatb6 = 2.0<u_xlat6.x;
					        if(u_xlatb6){
					            u_xlat1.y = (-u_xlat1.x) + 0.25;
					            u_xlat1.zw = u_xlat2.xx * vec2(1.0, -1.0) + vec2(0.0, -0.25);
					            u_xlat2 = u_xlat1.yxzw * _MainTex_TexelSize.xyxy + vs_TEXCOORD0.xyxy;
					            u_xlat2 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + u_xlat2;
					            u_xlat6.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat10_7.xz = texture2DLodEXT(_MainTex, u_xlat2.zw, 0.0).xy;
					            u_xlat6.z = u_xlat10_7.x;
					            u_xlat2.xy = u_xlat6.xz * vec2(5.0, 5.0) + vec2(-3.75, -3.75);
					            u_xlat6.xz = u_xlat6.xz * abs(u_xlat2.xy);
					            u_xlat6.xz = roundEven(u_xlat6.xz);
					            u_xlat8.x = roundEven(u_xlat6.y);
					            u_xlat8.z = roundEven(u_xlat10_7.z);
					            u_xlat6.xy = u_xlat8.xz * vec2(2.0, 2.0) + u_xlat6.xz;
					            u_xlatb7.xz = greaterThanEqual(u_xlat3.xxyy, vec4(0.899999976, 0.0, 0.899999976, 0.899999976)).xz;
					            {
					                vec3 hlslcc_movcTemp = u_xlat6;
					                hlslcc_movcTemp.x = (u_xlatb7.x) ? float(0.0) : u_xlat6.x;
					                hlslcc_movcTemp.y = (u_xlatb7.z) ? float(0.0) : u_xlat6.y;
					                u_xlat6 = hlslcc_movcTemp;
					            }
					            u_xlat6.xy = u_xlat6.xy * vec2(20.0, 20.0) + u_xlat1.xz;
					            u_xlat6.xy = u_xlat6.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.503125012, 0.000892857148);
					            u_xlat6.xy = texture2DLodEXT(_AreaTex, u_xlat6.xy, 0.0).xy;
					        } else {
					            u_xlat6.x = float(0.0);
					            u_xlat6.y = float(0.0);
					        //ENDIF
					        }
					        u_xlat18 = _MainTex_TexelSize.x * 0.25 + vs_TEXCOORD0.x;
					        u_xlat1.xy = (-_MainTex_TexelSize.xy);
					        u_xlat1.z = 1.0;
					        u_xlat8.x = u_xlat18;
					        u_xlat8.y = vs_TEXCOORD0.y;
					        u_xlat2.x = float(1.0);
					        u_xlat8.z = float(-1.0);
					        for(int u_xlati_while_true_2 = 0 ; u_xlati_while_true_2 < 0x7FFF ; u_xlati_while_true_2++){
					            u_xlatb19 = u_xlat8.z<7.0;
					            u_xlatb3.x = 0.899999976<u_xlat2.x;
					            u_xlatb19 = u_xlatb19 && u_xlatb3.x;
					            if(!u_xlatb19){break;}
					            u_xlat8.xyz = u_xlat1.xyz + u_xlat8.xyz;
					            u_xlat10_3.xy = texture2DLodEXT(_MainTex, u_xlat8.xy, 0.0).xy;
					            u_xlat16_19 = u_xlat10_3.x * 5.0 + -3.75;
					            u_xlat19 = abs(u_xlat16_19) * u_xlat10_3.x;
					            u_xlat4.x = roundEven(u_xlat19);
					            u_xlat4.y = roundEven(u_xlat10_3.y);
					            u_xlat2.x = dot(u_xlat4.xy, vec2(0.5, 0.5));
					        }
					        u_xlat1.x = u_xlat8.z;
					        u_xlat14.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + vs_TEXCOORD0.xy;
					        u_xlat19 = texture2DLodEXT(_MainTex, u_xlat14.xy, 0.0).x;
					        u_xlatb19 = 0.0<u_xlat19;
					        if(u_xlatb19){
					            u_xlat3.xy = _MainTex_TexelSize.xy;
					            u_xlat3.z = 1.0;
					            u_xlat4.x = u_xlat18;
					            u_xlat4.y = vs_TEXCOORD0.y;
					            u_xlat4.z = -1.0;
					            u_xlat2.y = float(1.0);
					            u_xlat14.x = float(0.0);
					            for(int u_xlati_while_true_3 = 0 ; u_xlati_while_true_3 < 0x7FFF ; u_xlati_while_true_3++){
					                u_xlatb19 = u_xlat4.z<7.0;
					                u_xlatb21 = 0.899999976<u_xlat2.y;
					                u_xlatb19 = u_xlatb19 && u_xlatb21;
					                if(!u_xlatb19){break;}
					                u_xlat4.xyz = u_xlat3.xyz + u_xlat4.xyz;
					                u_xlat10_5.xy = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).xy;
					                u_xlat16_19 = u_xlat10_5.x * 5.0 + -3.75;
					                u_xlat19 = abs(u_xlat16_19) * u_xlat10_5.x;
					                u_xlat14.y = roundEven(u_xlat19);
					                u_xlat14.x = roundEven(u_xlat10_5.y);
					                u_xlat2.y = dot(u_xlat14.yx, vec2(0.5, 0.5));
					            }
					            u_xlatb18 = 0.899999976<u_xlat14.x;
					            u_xlat18 = u_xlatb18 ? 1.0 : float(0.0);
					            u_xlat1.z = u_xlat18 + u_xlat4.z;
					        } else {
					            u_xlat1.z = 0.0;
					            u_xlat2.y = 0.0;
					        //ENDIF
					        }
					        u_xlat18 = u_xlat1.z + u_xlat1.x;
					        u_xlatb18 = 2.0<u_xlat18;
					        if(u_xlatb18){
					            u_xlat1.y = (-u_xlat1.x);
					            u_xlat3 = u_xlat1.yyzz * _MainTex_TexelSize.xyxy + vs_TEXCOORD0.xyxy;
					            u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat3.xyxy;
					            u_xlat5.x = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).y;
					            u_xlat5.z = texture2DLodEXT(_MainTex, u_xlat4.zw, 0.0).x;
					            u_xlat7.xz = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat3.zw;
					            u_xlat5.yw = texture2DLodEXT(_MainTex, u_xlat7.xz, 0.0).yx;
					            u_xlat7.xz = u_xlat5.xy * vec2(2.0, 2.0) + u_xlat5.zw;
					            u_xlatb2.xy = greaterThanEqual(u_xlat2.xyxx, vec4(0.899999976, 0.899999976, 0.0, 0.0)).xy;
					            {
					                vec3 hlslcc_movcTemp = u_xlat7;
					                hlslcc_movcTemp.x = (u_xlatb2.x) ? float(0.0) : u_xlat7.x;
					                hlslcc_movcTemp.z = (u_xlatb2.y) ? float(0.0) : u_xlat7.z;
					                u_xlat7 = hlslcc_movcTemp;
					            }
					            u_xlat1.xy = u_xlat7.xz * vec2(20.0, 20.0) + u_xlat1.xz;
					            u_xlat1.xy = u_xlat1.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.503125012, 0.000892857148);
					            u_xlat10_1.xy = texture2DLodEXT(_AreaTex, u_xlat1.xy, 0.0).xy;
					            u_xlat6.xy = u_xlat6.xy + u_xlat10_1.yx;
					        //ENDIF
					        }
					        u_xlatb18 = (-u_xlat6.y)==u_xlat6.x;
					        if(u_xlatb18){
					            u_xlat1.xy = vs_TEXCOORD2.xy;
					            u_xlat1.z = 1.0;
					            u_xlat2.x = 0.0;
					            for(int u_xlati_while_true_4 = 0 ; u_xlati_while_true_4 < 0x7FFF ; u_xlati_while_true_4++){
					                u_xlatb18 = vs_TEXCOORD4.x<u_xlat1.x;
					                u_xlatb19 = 0.828100026<u_xlat1.z;
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                u_xlatb19 = u_xlat2.x==0.0;
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                if(!u_xlatb18){break;}
					                u_xlat2.xy = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).xy;
					                u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					                u_xlat1.z = u_xlat2.y;
					            }
					            u_xlat2.yz = u_xlat1.xz;
					            u_xlat1.xy = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					            u_xlat10_18 = texture2DLodEXT(_SearchTex, u_xlat1.xy, 0.0).w;
					            u_xlat16_18 = u_xlat10_18 * -2.00787401 + 3.25;
					            u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_18 + u_xlat2.y;
					            u_xlat1.y = vs_TEXCOORD3.y;
					            u_xlat2.x = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).x;
					            u_xlat3.xy = vs_TEXCOORD2.zw;
					            u_xlat3.z = 1.0;
					            u_xlat4.x = 0.0;
					            for(int u_xlati_while_true_5 = 0 ; u_xlati_while_true_5 < 0x7FFF ; u_xlati_while_true_5++){
					                u_xlatb18 = u_xlat3.x<vs_TEXCOORD4.y;
					                u_xlatb14 = 0.828100026<u_xlat3.z;
					                u_xlatb18 = u_xlatb18 && u_xlatb14;
					                u_xlatb14 = u_xlat4.x==0.0;
					                u_xlatb18 = u_xlatb18 && u_xlatb14;
					                if(!u_xlatb18){break;}
					                u_xlat4.xy = texture2DLodEXT(_MainTex, u_xlat3.xy, 0.0).xy;
					                u_xlat3.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat3.xy;
					                u_xlat3.z = u_xlat4.y;
					            }
					            u_xlat4.yz = u_xlat3.xz;
					            u_xlat14.xy = u_xlat4.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					            u_xlat10_18 = texture2DLodEXT(_SearchTex, u_xlat14.xy, 0.0).w;
					            u_xlat16_18 = u_xlat10_18 * -2.00787401 + 3.25;
					            u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_18 + u_xlat4.y;
					            u_xlat3 = _MainTex_TexelSize.zzzz * u_xlat1.zxzx + (-vs_TEXCOORD1.xxxx);
					            u_xlat3 = roundEven(u_xlat3);
					            u_xlat14.xy = sqrt(abs(u_xlat3.wz));
					            u_xlat4.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					            u_xlat2.y = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).x;
					            u_xlat2.xy = u_xlat2.xy * vec2(4.0, 4.0);
					            u_xlat2.xy = roundEven(u_xlat2.xy);
					            u_xlat2.xy = u_xlat2.xy * vec2(16.0, 16.0) + u_xlat14.xy;
					            u_xlat2.xy = u_xlat2.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					            u_xlat10_2.xy = texture2DLodEXT(_AreaTex, u_xlat2.xy, 0.0).xy;
					            u_xlatb3 = greaterThanEqual(abs(u_xlat3), abs(u_xlat3.wzwz));
					            u_xlat3 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 0.75, 0.75), vec4(u_xlatb3));
					            u_xlat18 = u_xlat3.y + u_xlat3.x;
					            u_xlat14.xy = u_xlat3.zw / vec2(u_xlat18);
					            u_xlat1.w = vs_TEXCOORD0.y;
					            u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat1.xw;
					            u_xlat10_18 = texture2DLodEXT(_MainTex, u_xlat3.xy, 0.0).x;
					            u_xlat18 = (-u_xlat14.x) * u_xlat10_18 + 1.0;
					            u_xlat3.xy = u_xlat1.zw + _MainTex_TexelSize.xy;
					            u_xlat10_7.x = texture2DLodEXT(_MainTex, u_xlat3.xy, 0.0).x;
					            u_xlat3.x = (-u_xlat14.y) * u_xlat10_7.x + u_xlat18;
					            u_xlat3.x = clamp(u_xlat3.x, 0.0, 1.0);
					            u_xlat1 = _MainTex_TexelSize.xyxy * vec4(0.0, -2.0, 1.0, -2.0) + u_xlat1.xwzw;
					            u_xlat10_18 = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).x;
					            u_xlat18 = (-u_xlat14.x) * u_xlat10_18 + 1.0;
					            u_xlat10_1.x = texture2DLodEXT(_MainTex, u_xlat1.zw, 0.0).x;
					            u_xlat3.y = (-u_xlat14.y) * u_xlat10_1.x + u_xlat18;
					            u_xlat3.y = clamp(u_xlat3.y, 0.0, 1.0);
					            SV_Target0.xy = u_xlat10_2.xy * u_xlat3.xy;
					        } else {
					            SV_Target0.xy = u_xlat6.xy;
					            u_xlat0.x = 0.0;
					        //ENDIF
					        }
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    u_xlatb0 = 0.0<u_xlat0.x;
					    if(u_xlatb0){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        for(int u_xlati_while_true_6 = 0 ; u_xlati_while_true_6 < 0x7FFF ; u_xlati_while_true_6++){
					            u_xlatb18 = vs_TEXCOORD4.z<u_xlat0.y;
					            u_xlatb19 = 0.828100026<u_xlat0.z;
					            u_xlatb18 = u_xlatb18 && u_xlatb19;
					            u_xlatb19 = u_xlat1.x==0.0;
					            u_xlatb18 = u_xlatb18 && u_xlatb19;
					            if(!u_xlatb18){break;}
					            u_xlat1.xy = texture2DLodEXT(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0 = texture2DLodEXT(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0 = u_xlat10_0 * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0 + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = texture2DLodEXT(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_7 = 0 ; u_xlati_while_true_7 < 0x7FFF ; u_xlati_while_true_7++){
					            u_xlatb13 = u_xlat2.y<vs_TEXCOORD4.w;
					            u_xlatb19 = 0.828100026<u_xlat2.z;
					            u_xlatb13 = u_xlatb19 && u_xlatb13;
					            u_xlatb19 = u_xlat3.x==0.0;
					            u_xlatb13 = u_xlatb19 && u_xlatb13;
					            if(!u_xlatb13){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat13.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_13 = texture2DLodEXT(_SearchTex, u_xlat13.xy, 0.0).w;
					        u_xlat16_13 = u_xlat10_13 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_13 + u_xlat3.y;
					        u_xlat2 = _MainTex_TexelSize.wwww * u_xlat0.zxzx + (-vs_TEXCOORD1.yyyy);
					        u_xlat2 = roundEven(u_xlat2);
					        u_xlat13.xy = sqrt(abs(u_xlat2.wz));
					        u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = texture2DLodEXT(_MainTex, u_xlat3.xy, 0.0).y;
					        u_xlat1.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat1.xy = roundEven(u_xlat1.xy);
					        u_xlat1.xy = u_xlat1.xy * vec2(16.0, 16.0) + u_xlat13.xy;
					        u_xlat1.xy = u_xlat1.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_1.xy = texture2DLodEXT(_AreaTex, u_xlat1.xy, 0.0).xy;
					        u_xlatb2 = greaterThanEqual(abs(u_xlat2), abs(u_xlat2.wzwz));
					        u_xlat2 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 0.75, 0.75), vec4(u_xlatb2));
					        u_xlat6.x = u_xlat2.y + u_xlat2.x;
					        u_xlat13.xy = u_xlat2.zw / u_xlat6.xx;
					        u_xlat0.w = vs_TEXCOORD0.x;
					        u_xlat2.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat0.wx;
					        u_xlat10_6 = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).y;
					        u_xlat6.x = (-u_xlat13.x) * u_xlat10_6 + 1.0;
					        u_xlat2.xy = u_xlat0.wz + _MainTex_TexelSize.xy;
					        u_xlat10_2.x = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).y;
					        u_xlat14.x = (-u_xlat13.y) * u_xlat10_2.x + u_xlat6.x;
					        u_xlat14.x = clamp(u_xlat14.x, 0.0, 1.0);
					        u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, -2.0, 1.0) + u_xlat0.wxwz;
					        u_xlat10_0 = texture2DLodEXT(_MainTex, u_xlat0.xy, 0.0).y;
					        u_xlat0.x = (-u_xlat13.x) * u_xlat10_0 + 1.0;
					        u_xlat10_6 = texture2DLodEXT(_MainTex, u_xlat0.zw, 0.0).y;
					        u_xlat14.y = (-u_xlat13.y) * u_xlat10_6 + u_xlat0.x;
					        u_xlat14.y = clamp(u_xlat14.y, 0.0, 1.0);
					        SV_Target0.zw = u_xlat10_1.xy * u_xlat14.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.xzyw;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-32.0, 32.0, -32.0, 32.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _MainTex;
					uniform lowp sampler2D _AreaTex;
					uniform lowp sampler2D _SearchTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec2 vs_TEXCOORD1;
					varying highp vec4 vs_TEXCOORD2;
					varying highp vec4 vs_TEXCOORD3;
					varying highp vec4 vs_TEXCOORD4;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					lowp float u_xlat10_0;
					bool u_xlatb0;
					vec4 u_xlat1;
					lowp vec2 u_xlat10_1;
					vec4 u_xlat2;
					lowp vec2 u_xlat10_2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					lowp vec2 u_xlat10_3;
					bvec4 u_xlatb3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					lowp vec2 u_xlat10_5;
					vec3 u_xlat6;
					lowp float u_xlat10_6;
					bool u_xlatb6;
					vec3 u_xlat7;
					lowp vec3 u_xlat10_7;
					bvec3 u_xlatb7;
					vec3 u_xlat8;
					vec2 u_xlat13;
					mediump float u_xlat16_13;
					lowp float u_xlat10_13;
					bool u_xlatb13;
					vec2 u_xlat14;
					bool u_xlatb14;
					lowp vec2 u_xlat10_15;
					bool u_xlatb15;
					float u_xlat18;
					mediump float u_xlat16_18;
					lowp float u_xlat10_18;
					bool u_xlatb18;
					float u_xlat19;
					mediump float u_xlat16_19;
					bool u_xlatb19;
					float u_xlat20;
					bool u_xlatb21;
					float roundEven(float x) { float y = floor(x + 0.5); return (y - x == 0.5) ? floor(0.5*y) * 2.0 : y; }
					vec2 roundEven(vec2 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); return a; }
					vec3 roundEven(vec3 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); return a; }
					vec4 roundEven(vec4 a) { a.x = roundEven(a.x); a.y = roundEven(a.y); a.z = roundEven(a.z); a.w = roundEven(a.w); return a; }
					
					void main()
					{
					    u_xlat0.xy = texture2D(_MainTex, vs_TEXCOORD0.xy).xy;
					    u_xlatb6 = 0.0<u_xlat0.y;
					    if(u_xlatb6){
					        u_xlatb6 = 0.0<u_xlat0.x;
					        if(u_xlatb6){
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-1.0, 1.0);
					            u_xlat1.z = 1.0;
					            u_xlat2.xy = vs_TEXCOORD0.xy;
					            u_xlat6.x = 0.0;
					            u_xlat2.z = -1.0;
					            u_xlat3.x = 1.0;
					            for(int u_xlati_while_true_0 = 0 ; u_xlati_while_true_0 < 0x7FFF ; u_xlati_while_true_0++){
					                u_xlatb18 = u_xlat2.z<7.0;
					                u_xlatb19 = 0.899999976<u_xlat3.x;
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                if(!u_xlatb18){break;}
					                u_xlat2.xyz = u_xlat1.xyz + u_xlat2.xyz;
					                u_xlat6.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).yx;
					                u_xlat3.x = dot(u_xlat6.yx, vec2(0.5, 0.5));
					            }
					            u_xlatb6 = 0.899999976<u_xlat6.x;
					            u_xlat6.x = u_xlatb6 ? 1.0 : float(0.0);
					            u_xlat1.x = u_xlat6.x + u_xlat2.z;
					        } else {
					            u_xlat1.x = 0.0;
					            u_xlat3.x = 0.0;
					        //ENDIF
					        }
					        u_xlat6.xy = _MainTex_TexelSize.xy * vec2(1.0, -1.0);
					        u_xlat6.z = 1.0;
					        u_xlat2.yz = vs_TEXCOORD0.xy;
					        u_xlat2.x = float(-1.0);
					        u_xlat20 = float(1.0);
					        for(int u_xlati_while_true_1 = 0 ; u_xlati_while_true_1 < 0x7FFF ; u_xlati_while_true_1++){
					            u_xlatb15 = u_xlat2.x<7.0;
					            u_xlatb21 = 0.899999976<u_xlat20;
					            u_xlatb15 = u_xlatb21 && u_xlatb15;
					            if(!u_xlatb15){break;}
					            u_xlat2.xyz = u_xlat6.zxy + u_xlat2.xyz;
					            u_xlat10_15.xy = texture2DLodEXT(_MainTex, u_xlat2.yz, 0.0).xy;
					            u_xlat20 = dot(u_xlat10_15.xy, vec2(0.5, 0.5));
					        }
					        u_xlat3.y = u_xlat20;
					        u_xlat6.x = u_xlat1.x + u_xlat2.x;
					        u_xlatb6 = 2.0<u_xlat6.x;
					        if(u_xlatb6){
					            u_xlat1.y = (-u_xlat1.x) + 0.25;
					            u_xlat1.zw = u_xlat2.xx * vec2(1.0, -1.0) + vec2(0.0, -0.25);
					            u_xlat2 = u_xlat1.yxzw * _MainTex_TexelSize.xyxy + vs_TEXCOORD0.xyxy;
					            u_xlat2 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + u_xlat2;
					            u_xlat6.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat10_7.xz = texture2DLodEXT(_MainTex, u_xlat2.zw, 0.0).xy;
					            u_xlat6.z = u_xlat10_7.x;
					            u_xlat2.xy = u_xlat6.xz * vec2(5.0, 5.0) + vec2(-3.75, -3.75);
					            u_xlat6.xz = u_xlat6.xz * abs(u_xlat2.xy);
					            u_xlat6.xz = roundEven(u_xlat6.xz);
					            u_xlat8.x = roundEven(u_xlat6.y);
					            u_xlat8.z = roundEven(u_xlat10_7.z);
					            u_xlat6.xy = u_xlat8.xz * vec2(2.0, 2.0) + u_xlat6.xz;
					            u_xlatb7.xz = greaterThanEqual(u_xlat3.xxyy, vec4(0.899999976, 0.0, 0.899999976, 0.899999976)).xz;
					            {
					                vec3 hlslcc_movcTemp = u_xlat6;
					                hlslcc_movcTemp.x = (u_xlatb7.x) ? float(0.0) : u_xlat6.x;
					                hlslcc_movcTemp.y = (u_xlatb7.z) ? float(0.0) : u_xlat6.y;
					                u_xlat6 = hlslcc_movcTemp;
					            }
					            u_xlat6.xy = u_xlat6.xy * vec2(20.0, 20.0) + u_xlat1.xz;
					            u_xlat6.xy = u_xlat6.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.503125012, 0.000892857148);
					            u_xlat6.xy = texture2DLodEXT(_AreaTex, u_xlat6.xy, 0.0).xy;
					        } else {
					            u_xlat6.x = float(0.0);
					            u_xlat6.y = float(0.0);
					        //ENDIF
					        }
					        u_xlat18 = _MainTex_TexelSize.x * 0.25 + vs_TEXCOORD0.x;
					        u_xlat1.xy = (-_MainTex_TexelSize.xy);
					        u_xlat1.z = 1.0;
					        u_xlat8.x = u_xlat18;
					        u_xlat8.y = vs_TEXCOORD0.y;
					        u_xlat2.x = float(1.0);
					        u_xlat8.z = float(-1.0);
					        for(int u_xlati_while_true_2 = 0 ; u_xlati_while_true_2 < 0x7FFF ; u_xlati_while_true_2++){
					            u_xlatb19 = u_xlat8.z<7.0;
					            u_xlatb3.x = 0.899999976<u_xlat2.x;
					            u_xlatb19 = u_xlatb19 && u_xlatb3.x;
					            if(!u_xlatb19){break;}
					            u_xlat8.xyz = u_xlat1.xyz + u_xlat8.xyz;
					            u_xlat10_3.xy = texture2DLodEXT(_MainTex, u_xlat8.xy, 0.0).xy;
					            u_xlat16_19 = u_xlat10_3.x * 5.0 + -3.75;
					            u_xlat19 = abs(u_xlat16_19) * u_xlat10_3.x;
					            u_xlat4.x = roundEven(u_xlat19);
					            u_xlat4.y = roundEven(u_xlat10_3.y);
					            u_xlat2.x = dot(u_xlat4.xy, vec2(0.5, 0.5));
					        }
					        u_xlat1.x = u_xlat8.z;
					        u_xlat14.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + vs_TEXCOORD0.xy;
					        u_xlat19 = texture2DLodEXT(_MainTex, u_xlat14.xy, 0.0).x;
					        u_xlatb19 = 0.0<u_xlat19;
					        if(u_xlatb19){
					            u_xlat3.xy = _MainTex_TexelSize.xy;
					            u_xlat3.z = 1.0;
					            u_xlat4.x = u_xlat18;
					            u_xlat4.y = vs_TEXCOORD0.y;
					            u_xlat4.z = -1.0;
					            u_xlat2.y = float(1.0);
					            u_xlat14.x = float(0.0);
					            for(int u_xlati_while_true_3 = 0 ; u_xlati_while_true_3 < 0x7FFF ; u_xlati_while_true_3++){
					                u_xlatb19 = u_xlat4.z<7.0;
					                u_xlatb21 = 0.899999976<u_xlat2.y;
					                u_xlatb19 = u_xlatb19 && u_xlatb21;
					                if(!u_xlatb19){break;}
					                u_xlat4.xyz = u_xlat3.xyz + u_xlat4.xyz;
					                u_xlat10_5.xy = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).xy;
					                u_xlat16_19 = u_xlat10_5.x * 5.0 + -3.75;
					                u_xlat19 = abs(u_xlat16_19) * u_xlat10_5.x;
					                u_xlat14.y = roundEven(u_xlat19);
					                u_xlat14.x = roundEven(u_xlat10_5.y);
					                u_xlat2.y = dot(u_xlat14.yx, vec2(0.5, 0.5));
					            }
					            u_xlatb18 = 0.899999976<u_xlat14.x;
					            u_xlat18 = u_xlatb18 ? 1.0 : float(0.0);
					            u_xlat1.z = u_xlat18 + u_xlat4.z;
					        } else {
					            u_xlat1.z = 0.0;
					            u_xlat2.y = 0.0;
					        //ENDIF
					        }
					        u_xlat18 = u_xlat1.z + u_xlat1.x;
					        u_xlatb18 = 2.0<u_xlat18;
					        if(u_xlatb18){
					            u_xlat1.y = (-u_xlat1.x);
					            u_xlat3 = u_xlat1.yyzz * _MainTex_TexelSize.xyxy + vs_TEXCOORD0.xyxy;
					            u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat3.xyxy;
					            u_xlat5.x = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).y;
					            u_xlat5.z = texture2DLodEXT(_MainTex, u_xlat4.zw, 0.0).x;
					            u_xlat7.xz = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat3.zw;
					            u_xlat5.yw = texture2DLodEXT(_MainTex, u_xlat7.xz, 0.0).yx;
					            u_xlat7.xz = u_xlat5.xy * vec2(2.0, 2.0) + u_xlat5.zw;
					            u_xlatb2.xy = greaterThanEqual(u_xlat2.xyxx, vec4(0.899999976, 0.899999976, 0.0, 0.0)).xy;
					            {
					                vec3 hlslcc_movcTemp = u_xlat7;
					                hlslcc_movcTemp.x = (u_xlatb2.x) ? float(0.0) : u_xlat7.x;
					                hlslcc_movcTemp.z = (u_xlatb2.y) ? float(0.0) : u_xlat7.z;
					                u_xlat7 = hlslcc_movcTemp;
					            }
					            u_xlat1.xy = u_xlat7.xz * vec2(20.0, 20.0) + u_xlat1.xz;
					            u_xlat1.xy = u_xlat1.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.503125012, 0.000892857148);
					            u_xlat10_1.xy = texture2DLodEXT(_AreaTex, u_xlat1.xy, 0.0).xy;
					            u_xlat6.xy = u_xlat6.xy + u_xlat10_1.yx;
					        //ENDIF
					        }
					        u_xlatb18 = (-u_xlat6.y)==u_xlat6.x;
					        if(u_xlatb18){
					            u_xlat1.xy = vs_TEXCOORD2.xy;
					            u_xlat1.z = 1.0;
					            u_xlat2.x = 0.0;
					            for(int u_xlati_while_true_4 = 0 ; u_xlati_while_true_4 < 0x7FFF ; u_xlati_while_true_4++){
					                u_xlatb18 = vs_TEXCOORD4.x<u_xlat1.x;
					                u_xlatb19 = 0.828100026<u_xlat1.z;
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                u_xlatb19 = u_xlat2.x==0.0;
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                if(!u_xlatb18){break;}
					                u_xlat2.xy = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).xy;
					                u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					                u_xlat1.z = u_xlat2.y;
					            }
					            u_xlat2.yz = u_xlat1.xz;
					            u_xlat1.xy = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					            u_xlat10_18 = texture2DLodEXT(_SearchTex, u_xlat1.xy, 0.0).w;
					            u_xlat16_18 = u_xlat10_18 * -2.00787401 + 3.25;
					            u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_18 + u_xlat2.y;
					            u_xlat1.y = vs_TEXCOORD3.y;
					            u_xlat2.x = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).x;
					            u_xlat3.xy = vs_TEXCOORD2.zw;
					            u_xlat3.z = 1.0;
					            u_xlat4.x = 0.0;
					            for(int u_xlati_while_true_5 = 0 ; u_xlati_while_true_5 < 0x7FFF ; u_xlati_while_true_5++){
					                u_xlatb18 = u_xlat3.x<vs_TEXCOORD4.y;
					                u_xlatb14 = 0.828100026<u_xlat3.z;
					                u_xlatb18 = u_xlatb18 && u_xlatb14;
					                u_xlatb14 = u_xlat4.x==0.0;
					                u_xlatb18 = u_xlatb18 && u_xlatb14;
					                if(!u_xlatb18){break;}
					                u_xlat4.xy = texture2DLodEXT(_MainTex, u_xlat3.xy, 0.0).xy;
					                u_xlat3.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat3.xy;
					                u_xlat3.z = u_xlat4.y;
					            }
					            u_xlat4.yz = u_xlat3.xz;
					            u_xlat14.xy = u_xlat4.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					            u_xlat10_18 = texture2DLodEXT(_SearchTex, u_xlat14.xy, 0.0).w;
					            u_xlat16_18 = u_xlat10_18 * -2.00787401 + 3.25;
					            u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_18 + u_xlat4.y;
					            u_xlat3 = _MainTex_TexelSize.zzzz * u_xlat1.zxzx + (-vs_TEXCOORD1.xxxx);
					            u_xlat3 = roundEven(u_xlat3);
					            u_xlat14.xy = sqrt(abs(u_xlat3.wz));
					            u_xlat4.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					            u_xlat2.y = texture2DLodEXT(_MainTex, u_xlat4.xy, 0.0).x;
					            u_xlat2.xy = u_xlat2.xy * vec2(4.0, 4.0);
					            u_xlat2.xy = roundEven(u_xlat2.xy);
					            u_xlat2.xy = u_xlat2.xy * vec2(16.0, 16.0) + u_xlat14.xy;
					            u_xlat2.xy = u_xlat2.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					            u_xlat10_2.xy = texture2DLodEXT(_AreaTex, u_xlat2.xy, 0.0).xy;
					            u_xlatb3 = greaterThanEqual(abs(u_xlat3), abs(u_xlat3.wzwz));
					            u_xlat3 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 0.75, 0.75), vec4(u_xlatb3));
					            u_xlat18 = u_xlat3.y + u_xlat3.x;
					            u_xlat14.xy = u_xlat3.zw / vec2(u_xlat18);
					            u_xlat1.w = vs_TEXCOORD0.y;
					            u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat1.xw;
					            u_xlat10_18 = texture2DLodEXT(_MainTex, u_xlat3.xy, 0.0).x;
					            u_xlat18 = (-u_xlat14.x) * u_xlat10_18 + 1.0;
					            u_xlat3.xy = u_xlat1.zw + _MainTex_TexelSize.xy;
					            u_xlat10_7.x = texture2DLodEXT(_MainTex, u_xlat3.xy, 0.0).x;
					            u_xlat3.x = (-u_xlat14.y) * u_xlat10_7.x + u_xlat18;
					            u_xlat3.x = clamp(u_xlat3.x, 0.0, 1.0);
					            u_xlat1 = _MainTex_TexelSize.xyxy * vec4(0.0, -2.0, 1.0, -2.0) + u_xlat1.xwzw;
					            u_xlat10_18 = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0).x;
					            u_xlat18 = (-u_xlat14.x) * u_xlat10_18 + 1.0;
					            u_xlat10_1.x = texture2DLodEXT(_MainTex, u_xlat1.zw, 0.0).x;
					            u_xlat3.y = (-u_xlat14.y) * u_xlat10_1.x + u_xlat18;
					            u_xlat3.y = clamp(u_xlat3.y, 0.0, 1.0);
					            SV_Target0.xy = u_xlat10_2.xy * u_xlat3.xy;
					        } else {
					            SV_Target0.xy = u_xlat6.xy;
					            u_xlat0.x = 0.0;
					        //ENDIF
					        }
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    u_xlatb0 = 0.0<u_xlat0.x;
					    if(u_xlatb0){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        for(int u_xlati_while_true_6 = 0 ; u_xlati_while_true_6 < 0x7FFF ; u_xlati_while_true_6++){
					            u_xlatb18 = vs_TEXCOORD4.z<u_xlat0.y;
					            u_xlatb19 = 0.828100026<u_xlat0.z;
					            u_xlatb18 = u_xlatb18 && u_xlatb19;
					            u_xlatb19 = u_xlat1.x==0.0;
					            u_xlatb18 = u_xlatb18 && u_xlatb19;
					            if(!u_xlatb18){break;}
					            u_xlat1.xy = texture2DLodEXT(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat10_0 = texture2DLodEXT(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0 = u_xlat10_0 * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0 + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = texture2DLodEXT(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        for(int u_xlati_while_true_7 = 0 ; u_xlati_while_true_7 < 0x7FFF ; u_xlati_while_true_7++){
					            u_xlatb13 = u_xlat2.y<vs_TEXCOORD4.w;
					            u_xlatb19 = 0.828100026<u_xlat2.z;
					            u_xlatb13 = u_xlatb19 && u_xlatb13;
					            u_xlatb19 = u_xlat3.x==0.0;
					            u_xlatb13 = u_xlatb19 && u_xlatb13;
					            if(!u_xlatb13){break;}
					            u_xlat3.xy = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat13.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat10_13 = texture2DLodEXT(_SearchTex, u_xlat13.xy, 0.0).w;
					        u_xlat16_13 = u_xlat10_13 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_13 + u_xlat3.y;
					        u_xlat2 = _MainTex_TexelSize.wwww * u_xlat0.zxzx + (-vs_TEXCOORD1.yyyy);
					        u_xlat2 = roundEven(u_xlat2);
					        u_xlat13.xy = sqrt(abs(u_xlat2.wz));
					        u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = texture2DLodEXT(_MainTex, u_xlat3.xy, 0.0).y;
					        u_xlat1.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat1.xy = roundEven(u_xlat1.xy);
					        u_xlat1.xy = u_xlat1.xy * vec2(16.0, 16.0) + u_xlat13.xy;
					        u_xlat1.xy = u_xlat1.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat10_1.xy = texture2DLodEXT(_AreaTex, u_xlat1.xy, 0.0).xy;
					        u_xlatb2 = greaterThanEqual(abs(u_xlat2), abs(u_xlat2.wzwz));
					        u_xlat2 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 0.75, 0.75), vec4(u_xlatb2));
					        u_xlat6.x = u_xlat2.y + u_xlat2.x;
					        u_xlat13.xy = u_xlat2.zw / u_xlat6.xx;
					        u_xlat0.w = vs_TEXCOORD0.x;
					        u_xlat2.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat0.wx;
					        u_xlat10_6 = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).y;
					        u_xlat6.x = (-u_xlat13.x) * u_xlat10_6 + 1.0;
					        u_xlat2.xy = u_xlat0.wz + _MainTex_TexelSize.xy;
					        u_xlat10_2.x = texture2DLodEXT(_MainTex, u_xlat2.xy, 0.0).y;
					        u_xlat14.x = (-u_xlat13.y) * u_xlat10_2.x + u_xlat6.x;
					        u_xlat14.x = clamp(u_xlat14.x, 0.0, 1.0);
					        u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, -2.0, 1.0) + u_xlat0.wxwz;
					        u_xlat10_0 = texture2DLodEXT(_MainTex, u_xlat0.xy, 0.0).y;
					        u_xlat0.x = (-u_xlat13.x) * u_xlat10_0 + 1.0;
					        u_xlat10_6 = texture2DLodEXT(_MainTex, u_xlat0.zw, 0.0).y;
					        u_xlat14.y = (-u_xlat13.y) * u_xlat10_6 + u_xlat0.x;
					        u_xlat14.y = clamp(u_xlat14.y, 0.0, 1.0);
					        SV_Target0.zw = u_xlat10_1.xy * u_xlat14.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					out highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.zzww;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-32.0, 32.0, -32.0, 32.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _AreaTex;
					uniform mediump sampler2D _SearchTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					in highp vec4 vs_TEXCOORD4;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec4 u_xlat1;
					mediump vec2 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec2 u_xlat16_2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					mediump vec2 u_xlat16_3;
					bvec4 u_xlatb3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					mediump vec2 u_xlat16_5;
					vec3 u_xlat6;
					mediump float u_xlat16_6;
					bool u_xlatb6;
					vec3 u_xlat7;
					mediump vec3 u_xlat16_7;
					bvec3 u_xlatb7;
					vec3 u_xlat8;
					vec2 u_xlat13;
					mediump float u_xlat16_13;
					bool u_xlatb13;
					vec2 u_xlat14;
					bool u_xlatb14;
					mediump vec2 u_xlat16_15;
					bool u_xlatb15;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					float u_xlat19;
					mediump float u_xlat16_19;
					bool u_xlatb19;
					float u_xlat20;
					bool u_xlatb21;
					void main()
					{
					    u_xlat0.xy = texture(_MainTex, vs_TEXCOORD0.xy).xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(0.0<u_xlat0.y);
					#else
					    u_xlatb6 = 0.0<u_xlat0.y;
					#endif
					    if(u_xlatb6){
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb6 = !!(0.0<u_xlat0.x);
					#else
					        u_xlatb6 = 0.0<u_xlat0.x;
					#endif
					        if(u_xlatb6){
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-1.0, 1.0);
					            u_xlat1.z = 1.0;
					            u_xlat2.xy = vs_TEXCOORD0.xy;
					            u_xlat6.x = 0.0;
					            u_xlat2.z = -1.0;
					            u_xlat3.x = 1.0;
					            while(true){
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb18 = !!(u_xlat2.z<7.0);
					#else
					                u_xlatb18 = u_xlat2.z<7.0;
					#endif
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb19 = !!(0.899999976<u_xlat3.x);
					#else
					                u_xlatb19 = 0.899999976<u_xlat3.x;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                if(!u_xlatb18){break;}
					                u_xlat2.xyz = u_xlat1.xyz + u_xlat2.xyz;
					                u_xlat6.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).yx;
					                u_xlat3.x = dot(u_xlat6.yx, vec2(0.5, 0.5));
					            }
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb6 = !!(0.899999976<u_xlat6.x);
					#else
					            u_xlatb6 = 0.899999976<u_xlat6.x;
					#endif
					            u_xlat6.x = u_xlatb6 ? 1.0 : float(0.0);
					            u_xlat1.x = u_xlat6.x + u_xlat2.z;
					        } else {
					            u_xlat1.x = 0.0;
					            u_xlat3.x = 0.0;
					        //ENDIF
					        }
					        u_xlat6.xy = _MainTex_TexelSize.xy * vec2(1.0, -1.0);
					        u_xlat6.z = 1.0;
					        u_xlat2.yz = vs_TEXCOORD0.xy;
					        u_xlat2.x = float(-1.0);
					        u_xlat20 = float(1.0);
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb15 = !!(u_xlat2.x<7.0);
					#else
					            u_xlatb15 = u_xlat2.x<7.0;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb21 = !!(0.899999976<u_xlat20);
					#else
					            u_xlatb21 = 0.899999976<u_xlat20;
					#endif
					            u_xlatb15 = u_xlatb21 && u_xlatb15;
					            if(!u_xlatb15){break;}
					            u_xlat2.xyz = u_xlat6.zxy + u_xlat2.xyz;
					            u_xlat16_15.xy = textureLod(_MainTex, u_xlat2.yz, 0.0).xy;
					            u_xlat20 = dot(u_xlat16_15.xy, vec2(0.5, 0.5));
					        }
					        u_xlat3.y = u_xlat20;
					        u_xlat6.x = u_xlat1.x + u_xlat2.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb6 = !!(2.0<u_xlat6.x);
					#else
					        u_xlatb6 = 2.0<u_xlat6.x;
					#endif
					        if(u_xlatb6){
					            u_xlat1.y = (-u_xlat1.x) + 0.25;
					            u_xlat1.zw = u_xlat2.xx * vec2(1.0, -1.0) + vec2(0.0, -0.25);
					            u_xlat2 = u_xlat1.yxzw * _MainTex_TexelSize.xyxy + vs_TEXCOORD0.xyxy;
					            u_xlat2 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + u_xlat2;
					            u_xlat6.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat16_7.xz = textureLod(_MainTex, u_xlat2.zw, 0.0).xy;
					            u_xlat6.z = u_xlat16_7.x;
					            u_xlat2.xy = u_xlat6.xz * vec2(5.0, 5.0) + vec2(-3.75, -3.75);
					            u_xlat6.xz = u_xlat6.xz * abs(u_xlat2.xy);
					            u_xlat6.xz = roundEven(u_xlat6.xz);
					            u_xlat8.x = roundEven(u_xlat6.y);
					            u_xlat8.z = roundEven(u_xlat16_7.z);
					            u_xlat6.xy = u_xlat8.xz * vec2(2.0, 2.0) + u_xlat6.xz;
					            u_xlatb7.xz = greaterThanEqual(u_xlat3.xxyy, vec4(0.899999976, 0.0, 0.899999976, 0.899999976)).xz;
					            {
					                vec3 hlslcc_movcTemp = u_xlat6;
					                hlslcc_movcTemp.x = (u_xlatb7.x) ? float(0.0) : u_xlat6.x;
					                hlslcc_movcTemp.y = (u_xlatb7.z) ? float(0.0) : u_xlat6.y;
					                u_xlat6 = hlslcc_movcTemp;
					            }
					            u_xlat6.xy = u_xlat6.xy * vec2(20.0, 20.0) + u_xlat1.xz;
					            u_xlat6.xy = u_xlat6.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.503125012, 0.000892857148);
					            u_xlat6.xy = textureLod(_AreaTex, u_xlat6.xy, 0.0).xy;
					        } else {
					            u_xlat6.x = float(0.0);
					            u_xlat6.y = float(0.0);
					        //ENDIF
					        }
					        u_xlat18 = _MainTex_TexelSize.x * 0.25 + vs_TEXCOORD0.x;
					        u_xlat1.xy = (-_MainTex_TexelSize.xy);
					        u_xlat1.z = 1.0;
					        u_xlat8.x = u_xlat18;
					        u_xlat8.y = vs_TEXCOORD0.y;
					        u_xlat2.x = float(1.0);
					        u_xlat8.z = float(-1.0);
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(u_xlat8.z<7.0);
					#else
					            u_xlatb19 = u_xlat8.z<7.0;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb3.x = !!(0.899999976<u_xlat2.x);
					#else
					            u_xlatb3.x = 0.899999976<u_xlat2.x;
					#endif
					            u_xlatb19 = u_xlatb19 && u_xlatb3.x;
					            if(!u_xlatb19){break;}
					            u_xlat8.xyz = u_xlat1.xyz + u_xlat8.xyz;
					            u_xlat16_3.xy = textureLod(_MainTex, u_xlat8.xy, 0.0).xy;
					            u_xlat16_19 = u_xlat16_3.x * 5.0 + -3.75;
					            u_xlat19 = abs(u_xlat16_19) * u_xlat16_3.x;
					            u_xlat4.x = roundEven(u_xlat19);
					            u_xlat4.y = roundEven(u_xlat16_3.y);
					            u_xlat2.x = dot(u_xlat4.xy, vec2(0.5, 0.5));
					        }
					        u_xlat1.x = u_xlat8.z;
					        u_xlat14.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + vs_TEXCOORD0.xy;
					        u_xlat19 = textureLod(_MainTex, u_xlat14.xy, 0.0).x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb19 = !!(0.0<u_xlat19);
					#else
					        u_xlatb19 = 0.0<u_xlat19;
					#endif
					        if(u_xlatb19){
					            u_xlat3.xy = _MainTex_TexelSize.xy;
					            u_xlat3.z = 1.0;
					            u_xlat4.x = u_xlat18;
					            u_xlat4.y = vs_TEXCOORD0.y;
					            u_xlat4.z = -1.0;
					            u_xlat2.y = float(1.0);
					            u_xlat14.x = float(0.0);
					            while(true){
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb19 = !!(u_xlat4.z<7.0);
					#else
					                u_xlatb19 = u_xlat4.z<7.0;
					#endif
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb21 = !!(0.899999976<u_xlat2.y);
					#else
					                u_xlatb21 = 0.899999976<u_xlat2.y;
					#endif
					                u_xlatb19 = u_xlatb19 && u_xlatb21;
					                if(!u_xlatb19){break;}
					                u_xlat4.xyz = u_xlat3.xyz + u_xlat4.xyz;
					                u_xlat16_5.xy = textureLod(_MainTex, u_xlat4.xy, 0.0).xy;
					                u_xlat16_19 = u_xlat16_5.x * 5.0 + -3.75;
					                u_xlat19 = abs(u_xlat16_19) * u_xlat16_5.x;
					                u_xlat14.y = roundEven(u_xlat19);
					                u_xlat14.x = roundEven(u_xlat16_5.y);
					                u_xlat2.y = dot(u_xlat14.yx, vec2(0.5, 0.5));
					            }
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb18 = !!(0.899999976<u_xlat14.x);
					#else
					            u_xlatb18 = 0.899999976<u_xlat14.x;
					#endif
					            u_xlat18 = u_xlatb18 ? 1.0 : float(0.0);
					            u_xlat1.z = u_xlat18 + u_xlat4.z;
					        } else {
					            u_xlat1.z = 0.0;
					            u_xlat2.y = 0.0;
					        //ENDIF
					        }
					        u_xlat18 = u_xlat1.z + u_xlat1.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb18 = !!(2.0<u_xlat18);
					#else
					        u_xlatb18 = 2.0<u_xlat18;
					#endif
					        if(u_xlatb18){
					            u_xlat1.y = (-u_xlat1.x);
					            u_xlat3 = u_xlat1.yyzz * _MainTex_TexelSize.xyxy + vs_TEXCOORD0.xyxy;
					            u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat3.xyxy;
					            u_xlat5.x = textureLod(_MainTex, u_xlat4.xy, 0.0).y;
					            u_xlat5.z = textureLod(_MainTex, u_xlat4.zw, 0.0).x;
					            u_xlat7.xz = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat3.zw;
					            u_xlat5.yw = textureLod(_MainTex, u_xlat7.xz, 0.0).yx;
					            u_xlat7.xz = u_xlat5.xy * vec2(2.0, 2.0) + u_xlat5.zw;
					            u_xlatb2.xy = greaterThanEqual(u_xlat2.xyxx, vec4(0.899999976, 0.899999976, 0.0, 0.0)).xy;
					            {
					                vec3 hlslcc_movcTemp = u_xlat7;
					                hlslcc_movcTemp.x = (u_xlatb2.x) ? float(0.0) : u_xlat7.x;
					                hlslcc_movcTemp.z = (u_xlatb2.y) ? float(0.0) : u_xlat7.z;
					                u_xlat7 = hlslcc_movcTemp;
					            }
					            u_xlat1.xy = u_xlat7.xz * vec2(20.0, 20.0) + u_xlat1.xz;
					            u_xlat1.xy = u_xlat1.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.503125012, 0.000892857148);
					            u_xlat16_1.xy = textureLod(_AreaTex, u_xlat1.xy, 0.0).xy;
					            u_xlat6.xy = u_xlat6.xy + u_xlat16_1.yx;
					        //ENDIF
					        }
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb18 = !!((-u_xlat6.y)==u_xlat6.x);
					#else
					        u_xlatb18 = (-u_xlat6.y)==u_xlat6.x;
					#endif
					        if(u_xlatb18){
					            u_xlat1.xy = vs_TEXCOORD2.xy;
					            u_xlat1.z = 1.0;
					            u_xlat2.x = 0.0;
					            while(true){
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb18 = !!(vs_TEXCOORD4.x<u_xlat1.x);
					#else
					                u_xlatb18 = vs_TEXCOORD4.x<u_xlat1.x;
					#endif
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb19 = !!(0.828100026<u_xlat1.z);
					#else
					                u_xlatb19 = 0.828100026<u_xlat1.z;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb19 = !!(u_xlat2.x==0.0);
					#else
					                u_xlatb19 = u_xlat2.x==0.0;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                if(!u_xlatb18){break;}
					                u_xlat2.xy = textureLod(_MainTex, u_xlat1.xy, 0.0).xy;
					                u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					                u_xlat1.z = u_xlat2.y;
					            }
					            u_xlat2.yz = u_xlat1.xz;
					            u_xlat1.xy = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					            u_xlat16_18 = textureLod(_SearchTex, u_xlat1.xy, 0.0).w;
					            u_xlat16_18 = u_xlat16_18 * -2.00787401 + 3.25;
					            u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_18 + u_xlat2.y;
					            u_xlat1.y = vs_TEXCOORD3.y;
					            u_xlat2.x = textureLod(_MainTex, u_xlat1.xy, 0.0).x;
					            u_xlat3.xy = vs_TEXCOORD2.zw;
					            u_xlat3.z = 1.0;
					            u_xlat4.x = 0.0;
					            while(true){
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb18 = !!(u_xlat3.x<vs_TEXCOORD4.y);
					#else
					                u_xlatb18 = u_xlat3.x<vs_TEXCOORD4.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb14 = !!(0.828100026<u_xlat3.z);
					#else
					                u_xlatb14 = 0.828100026<u_xlat3.z;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb14;
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb14 = !!(u_xlat4.x==0.0);
					#else
					                u_xlatb14 = u_xlat4.x==0.0;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb14;
					                if(!u_xlatb18){break;}
					                u_xlat4.xy = textureLod(_MainTex, u_xlat3.xy, 0.0).xy;
					                u_xlat3.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat3.xy;
					                u_xlat3.z = u_xlat4.y;
					            }
					            u_xlat4.yz = u_xlat3.xz;
					            u_xlat14.xy = u_xlat4.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					            u_xlat16_18 = textureLod(_SearchTex, u_xlat14.xy, 0.0).w;
					            u_xlat16_18 = u_xlat16_18 * -2.00787401 + 3.25;
					            u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_18 + u_xlat4.y;
					            u_xlat3 = _MainTex_TexelSize.zzzz * u_xlat1.zxzx + (-vs_TEXCOORD1.xxxx);
					            u_xlat3 = roundEven(u_xlat3);
					            u_xlat14.xy = sqrt(abs(u_xlat3.wz));
					            u_xlat4.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					            u_xlat2.y = textureLod(_MainTex, u_xlat4.xy, 0.0).x;
					            u_xlat2.xy = u_xlat2.xy * vec2(4.0, 4.0);
					            u_xlat2.xy = roundEven(u_xlat2.xy);
					            u_xlat2.xy = u_xlat2.xy * vec2(16.0, 16.0) + u_xlat14.xy;
					            u_xlat2.xy = u_xlat2.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					            u_xlat16_2.xy = textureLod(_AreaTex, u_xlat2.xy, 0.0).xy;
					            u_xlatb3 = greaterThanEqual(abs(u_xlat3), abs(u_xlat3.wzwz));
					            u_xlat3 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 0.75, 0.75), vec4(u_xlatb3));
					            u_xlat18 = u_xlat3.y + u_xlat3.x;
					            u_xlat14.xy = u_xlat3.zw / vec2(u_xlat18);
					            u_xlat1.w = vs_TEXCOORD0.y;
					            u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat1.xw;
					            u_xlat16_18 = textureLod(_MainTex, u_xlat3.xy, 0.0).x;
					            u_xlat18 = (-u_xlat14.x) * u_xlat16_18 + 1.0;
					            u_xlat3.xy = u_xlat1.zw + _MainTex_TexelSize.xy;
					            u_xlat16_7.x = textureLod(_MainTex, u_xlat3.xy, 0.0).x;
					            u_xlat3.x = (-u_xlat14.y) * u_xlat16_7.x + u_xlat18;
					#ifdef UNITY_ADRENO_ES3
					            u_xlat3.x = min(max(u_xlat3.x, 0.0), 1.0);
					#else
					            u_xlat3.x = clamp(u_xlat3.x, 0.0, 1.0);
					#endif
					            u_xlat1 = _MainTex_TexelSize.xyxy * vec4(0.0, -2.0, 1.0, -2.0) + u_xlat1.xwzw;
					            u_xlat16_18 = textureLod(_MainTex, u_xlat1.xy, 0.0).x;
					            u_xlat18 = (-u_xlat14.x) * u_xlat16_18 + 1.0;
					            u_xlat16_1.x = textureLod(_MainTex, u_xlat1.zw, 0.0).x;
					            u_xlat3.y = (-u_xlat14.y) * u_xlat16_1.x + u_xlat18;
					#ifdef UNITY_ADRENO_ES3
					            u_xlat3.y = min(max(u_xlat3.y, 0.0), 1.0);
					#else
					            u_xlat3.y = clamp(u_xlat3.y, 0.0, 1.0);
					#endif
					            SV_Target0.xy = u_xlat16_2.xy * u_xlat3.xy;
					        } else {
					            SV_Target0.xy = u_xlat6.xy;
					            u_xlat0.x = 0.0;
					        //ENDIF
					        }
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(0.0<u_xlat0.x);
					#else
					    u_xlatb0 = 0.0<u_xlat0.x;
					#endif
					    if(u_xlatb0){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb18 = !!(vs_TEXCOORD4.z<u_xlat0.y);
					#else
					            u_xlatb18 = vs_TEXCOORD4.z<u_xlat0.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(0.828100026<u_xlat0.z);
					#else
					            u_xlatb19 = 0.828100026<u_xlat0.z;
					#endif
					            u_xlatb18 = u_xlatb18 && u_xlatb19;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(u_xlat1.x==0.0);
					#else
					            u_xlatb19 = u_xlat1.x==0.0;
					#endif
					            u_xlatb18 = u_xlatb18 && u_xlatb19;
					            if(!u_xlatb18){break;}
					            u_xlat1.xy = textureLod(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0 = textureLod(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0 = u_xlat16_0 * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0 + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = textureLod(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat2.y<vs_TEXCOORD4.w);
					#else
					            u_xlatb13 = u_xlat2.y<vs_TEXCOORD4.w;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb19 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb13 = u_xlatb19 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb19 = u_xlat3.x==0.0;
					#endif
					            u_xlatb13 = u_xlatb19 && u_xlatb13;
					            if(!u_xlatb13){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat13.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_13 = textureLod(_SearchTex, u_xlat13.xy, 0.0).w;
					        u_xlat16_13 = u_xlat16_13 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_13 + u_xlat3.y;
					        u_xlat2 = _MainTex_TexelSize.wwww * u_xlat0.zxzx + (-vs_TEXCOORD1.yyyy);
					        u_xlat2 = roundEven(u_xlat2);
					        u_xlat13.xy = sqrt(abs(u_xlat2.wz));
					        u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = textureLod(_MainTex, u_xlat3.xy, 0.0).y;
					        u_xlat1.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat1.xy = roundEven(u_xlat1.xy);
					        u_xlat1.xy = u_xlat1.xy * vec2(16.0, 16.0) + u_xlat13.xy;
					        u_xlat1.xy = u_xlat1.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_1.xy = textureLod(_AreaTex, u_xlat1.xy, 0.0).xy;
					        u_xlatb2 = greaterThanEqual(abs(u_xlat2), abs(u_xlat2.wzwz));
					        u_xlat2 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 0.75, 0.75), vec4(u_xlatb2));
					        u_xlat6.x = u_xlat2.y + u_xlat2.x;
					        u_xlat13.xy = u_xlat2.zw / u_xlat6.xx;
					        u_xlat0.w = vs_TEXCOORD0.x;
					        u_xlat2.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat0.wx;
					        u_xlat16_6 = textureLod(_MainTex, u_xlat2.xy, 0.0).y;
					        u_xlat6.x = (-u_xlat13.x) * u_xlat16_6 + 1.0;
					        u_xlat2.xy = u_xlat0.wz + _MainTex_TexelSize.xy;
					        u_xlat16_2.x = textureLod(_MainTex, u_xlat2.xy, 0.0).y;
					        u_xlat14.x = (-u_xlat13.y) * u_xlat16_2.x + u_xlat6.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlat14.x = min(max(u_xlat14.x, 0.0), 1.0);
					#else
					        u_xlat14.x = clamp(u_xlat14.x, 0.0, 1.0);
					#endif
					        u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, -2.0, 1.0) + u_xlat0.wxwz;
					        u_xlat16_0 = textureLod(_MainTex, u_xlat0.xy, 0.0).y;
					        u_xlat0.x = (-u_xlat13.x) * u_xlat16_0 + 1.0;
					        u_xlat16_6 = textureLod(_MainTex, u_xlat0.zw, 0.0).y;
					        u_xlat14.y = (-u_xlat13.y) * u_xlat16_6 + u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlat14.y = min(max(u_xlat14.y, 0.0), 1.0);
					#else
					        u_xlat14.y = clamp(u_xlat14.y, 0.0, 1.0);
					#endif
					        SV_Target0.zw = u_xlat16_1.xy * u_xlat14.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					out highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.zzww;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-32.0, 32.0, -32.0, 32.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _AreaTex;
					uniform mediump sampler2D _SearchTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					in highp vec4 vs_TEXCOORD4;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec4 u_xlat1;
					mediump vec2 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec2 u_xlat16_2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					mediump vec2 u_xlat16_3;
					bvec4 u_xlatb3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					mediump vec2 u_xlat16_5;
					vec3 u_xlat6;
					mediump float u_xlat16_6;
					bool u_xlatb6;
					vec3 u_xlat7;
					mediump vec3 u_xlat16_7;
					bvec3 u_xlatb7;
					vec3 u_xlat8;
					vec2 u_xlat13;
					mediump float u_xlat16_13;
					bool u_xlatb13;
					vec2 u_xlat14;
					bool u_xlatb14;
					mediump vec2 u_xlat16_15;
					bool u_xlatb15;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					float u_xlat19;
					mediump float u_xlat16_19;
					bool u_xlatb19;
					float u_xlat20;
					bool u_xlatb21;
					void main()
					{
					    u_xlat0.xy = texture(_MainTex, vs_TEXCOORD0.xy).xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(0.0<u_xlat0.y);
					#else
					    u_xlatb6 = 0.0<u_xlat0.y;
					#endif
					    if(u_xlatb6){
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb6 = !!(0.0<u_xlat0.x);
					#else
					        u_xlatb6 = 0.0<u_xlat0.x;
					#endif
					        if(u_xlatb6){
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-1.0, 1.0);
					            u_xlat1.z = 1.0;
					            u_xlat2.xy = vs_TEXCOORD0.xy;
					            u_xlat6.x = 0.0;
					            u_xlat2.z = -1.0;
					            u_xlat3.x = 1.0;
					            while(true){
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb18 = !!(u_xlat2.z<7.0);
					#else
					                u_xlatb18 = u_xlat2.z<7.0;
					#endif
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb19 = !!(0.899999976<u_xlat3.x);
					#else
					                u_xlatb19 = 0.899999976<u_xlat3.x;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                if(!u_xlatb18){break;}
					                u_xlat2.xyz = u_xlat1.xyz + u_xlat2.xyz;
					                u_xlat6.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).yx;
					                u_xlat3.x = dot(u_xlat6.yx, vec2(0.5, 0.5));
					            }
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb6 = !!(0.899999976<u_xlat6.x);
					#else
					            u_xlatb6 = 0.899999976<u_xlat6.x;
					#endif
					            u_xlat6.x = u_xlatb6 ? 1.0 : float(0.0);
					            u_xlat1.x = u_xlat6.x + u_xlat2.z;
					        } else {
					            u_xlat1.x = 0.0;
					            u_xlat3.x = 0.0;
					        //ENDIF
					        }
					        u_xlat6.xy = _MainTex_TexelSize.xy * vec2(1.0, -1.0);
					        u_xlat6.z = 1.0;
					        u_xlat2.yz = vs_TEXCOORD0.xy;
					        u_xlat2.x = float(-1.0);
					        u_xlat20 = float(1.0);
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb15 = !!(u_xlat2.x<7.0);
					#else
					            u_xlatb15 = u_xlat2.x<7.0;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb21 = !!(0.899999976<u_xlat20);
					#else
					            u_xlatb21 = 0.899999976<u_xlat20;
					#endif
					            u_xlatb15 = u_xlatb21 && u_xlatb15;
					            if(!u_xlatb15){break;}
					            u_xlat2.xyz = u_xlat6.zxy + u_xlat2.xyz;
					            u_xlat16_15.xy = textureLod(_MainTex, u_xlat2.yz, 0.0).xy;
					            u_xlat20 = dot(u_xlat16_15.xy, vec2(0.5, 0.5));
					        }
					        u_xlat3.y = u_xlat20;
					        u_xlat6.x = u_xlat1.x + u_xlat2.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb6 = !!(2.0<u_xlat6.x);
					#else
					        u_xlatb6 = 2.0<u_xlat6.x;
					#endif
					        if(u_xlatb6){
					            u_xlat1.y = (-u_xlat1.x) + 0.25;
					            u_xlat1.zw = u_xlat2.xx * vec2(1.0, -1.0) + vec2(0.0, -0.25);
					            u_xlat2 = u_xlat1.yxzw * _MainTex_TexelSize.xyxy + vs_TEXCOORD0.xyxy;
					            u_xlat2 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + u_xlat2;
					            u_xlat6.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat16_7.xz = textureLod(_MainTex, u_xlat2.zw, 0.0).xy;
					            u_xlat6.z = u_xlat16_7.x;
					            u_xlat2.xy = u_xlat6.xz * vec2(5.0, 5.0) + vec2(-3.75, -3.75);
					            u_xlat6.xz = u_xlat6.xz * abs(u_xlat2.xy);
					            u_xlat6.xz = roundEven(u_xlat6.xz);
					            u_xlat8.x = roundEven(u_xlat6.y);
					            u_xlat8.z = roundEven(u_xlat16_7.z);
					            u_xlat6.xy = u_xlat8.xz * vec2(2.0, 2.0) + u_xlat6.xz;
					            u_xlatb7.xz = greaterThanEqual(u_xlat3.xxyy, vec4(0.899999976, 0.0, 0.899999976, 0.899999976)).xz;
					            {
					                vec3 hlslcc_movcTemp = u_xlat6;
					                hlslcc_movcTemp.x = (u_xlatb7.x) ? float(0.0) : u_xlat6.x;
					                hlslcc_movcTemp.y = (u_xlatb7.z) ? float(0.0) : u_xlat6.y;
					                u_xlat6 = hlslcc_movcTemp;
					            }
					            u_xlat6.xy = u_xlat6.xy * vec2(20.0, 20.0) + u_xlat1.xz;
					            u_xlat6.xy = u_xlat6.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.503125012, 0.000892857148);
					            u_xlat6.xy = textureLod(_AreaTex, u_xlat6.xy, 0.0).xy;
					        } else {
					            u_xlat6.x = float(0.0);
					            u_xlat6.y = float(0.0);
					        //ENDIF
					        }
					        u_xlat18 = _MainTex_TexelSize.x * 0.25 + vs_TEXCOORD0.x;
					        u_xlat1.xy = (-_MainTex_TexelSize.xy);
					        u_xlat1.z = 1.0;
					        u_xlat8.x = u_xlat18;
					        u_xlat8.y = vs_TEXCOORD0.y;
					        u_xlat2.x = float(1.0);
					        u_xlat8.z = float(-1.0);
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(u_xlat8.z<7.0);
					#else
					            u_xlatb19 = u_xlat8.z<7.0;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb3.x = !!(0.899999976<u_xlat2.x);
					#else
					            u_xlatb3.x = 0.899999976<u_xlat2.x;
					#endif
					            u_xlatb19 = u_xlatb19 && u_xlatb3.x;
					            if(!u_xlatb19){break;}
					            u_xlat8.xyz = u_xlat1.xyz + u_xlat8.xyz;
					            u_xlat16_3.xy = textureLod(_MainTex, u_xlat8.xy, 0.0).xy;
					            u_xlat16_19 = u_xlat16_3.x * 5.0 + -3.75;
					            u_xlat19 = abs(u_xlat16_19) * u_xlat16_3.x;
					            u_xlat4.x = roundEven(u_xlat19);
					            u_xlat4.y = roundEven(u_xlat16_3.y);
					            u_xlat2.x = dot(u_xlat4.xy, vec2(0.5, 0.5));
					        }
					        u_xlat1.x = u_xlat8.z;
					        u_xlat14.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + vs_TEXCOORD0.xy;
					        u_xlat19 = textureLod(_MainTex, u_xlat14.xy, 0.0).x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb19 = !!(0.0<u_xlat19);
					#else
					        u_xlatb19 = 0.0<u_xlat19;
					#endif
					        if(u_xlatb19){
					            u_xlat3.xy = _MainTex_TexelSize.xy;
					            u_xlat3.z = 1.0;
					            u_xlat4.x = u_xlat18;
					            u_xlat4.y = vs_TEXCOORD0.y;
					            u_xlat4.z = -1.0;
					            u_xlat2.y = float(1.0);
					            u_xlat14.x = float(0.0);
					            while(true){
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb19 = !!(u_xlat4.z<7.0);
					#else
					                u_xlatb19 = u_xlat4.z<7.0;
					#endif
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb21 = !!(0.899999976<u_xlat2.y);
					#else
					                u_xlatb21 = 0.899999976<u_xlat2.y;
					#endif
					                u_xlatb19 = u_xlatb19 && u_xlatb21;
					                if(!u_xlatb19){break;}
					                u_xlat4.xyz = u_xlat3.xyz + u_xlat4.xyz;
					                u_xlat16_5.xy = textureLod(_MainTex, u_xlat4.xy, 0.0).xy;
					                u_xlat16_19 = u_xlat16_5.x * 5.0 + -3.75;
					                u_xlat19 = abs(u_xlat16_19) * u_xlat16_5.x;
					                u_xlat14.y = roundEven(u_xlat19);
					                u_xlat14.x = roundEven(u_xlat16_5.y);
					                u_xlat2.y = dot(u_xlat14.yx, vec2(0.5, 0.5));
					            }
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb18 = !!(0.899999976<u_xlat14.x);
					#else
					            u_xlatb18 = 0.899999976<u_xlat14.x;
					#endif
					            u_xlat18 = u_xlatb18 ? 1.0 : float(0.0);
					            u_xlat1.z = u_xlat18 + u_xlat4.z;
					        } else {
					            u_xlat1.z = 0.0;
					            u_xlat2.y = 0.0;
					        //ENDIF
					        }
					        u_xlat18 = u_xlat1.z + u_xlat1.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb18 = !!(2.0<u_xlat18);
					#else
					        u_xlatb18 = 2.0<u_xlat18;
					#endif
					        if(u_xlatb18){
					            u_xlat1.y = (-u_xlat1.x);
					            u_xlat3 = u_xlat1.yyzz * _MainTex_TexelSize.xyxy + vs_TEXCOORD0.xyxy;
					            u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat3.xyxy;
					            u_xlat5.x = textureLod(_MainTex, u_xlat4.xy, 0.0).y;
					            u_xlat5.z = textureLod(_MainTex, u_xlat4.zw, 0.0).x;
					            u_xlat7.xz = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat3.zw;
					            u_xlat5.yw = textureLod(_MainTex, u_xlat7.xz, 0.0).yx;
					            u_xlat7.xz = u_xlat5.xy * vec2(2.0, 2.0) + u_xlat5.zw;
					            u_xlatb2.xy = greaterThanEqual(u_xlat2.xyxx, vec4(0.899999976, 0.899999976, 0.0, 0.0)).xy;
					            {
					                vec3 hlslcc_movcTemp = u_xlat7;
					                hlslcc_movcTemp.x = (u_xlatb2.x) ? float(0.0) : u_xlat7.x;
					                hlslcc_movcTemp.z = (u_xlatb2.y) ? float(0.0) : u_xlat7.z;
					                u_xlat7 = hlslcc_movcTemp;
					            }
					            u_xlat1.xy = u_xlat7.xz * vec2(20.0, 20.0) + u_xlat1.xz;
					            u_xlat1.xy = u_xlat1.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.503125012, 0.000892857148);
					            u_xlat16_1.xy = textureLod(_AreaTex, u_xlat1.xy, 0.0).xy;
					            u_xlat6.xy = u_xlat6.xy + u_xlat16_1.yx;
					        //ENDIF
					        }
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb18 = !!((-u_xlat6.y)==u_xlat6.x);
					#else
					        u_xlatb18 = (-u_xlat6.y)==u_xlat6.x;
					#endif
					        if(u_xlatb18){
					            u_xlat1.xy = vs_TEXCOORD2.xy;
					            u_xlat1.z = 1.0;
					            u_xlat2.x = 0.0;
					            while(true){
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb18 = !!(vs_TEXCOORD4.x<u_xlat1.x);
					#else
					                u_xlatb18 = vs_TEXCOORD4.x<u_xlat1.x;
					#endif
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb19 = !!(0.828100026<u_xlat1.z);
					#else
					                u_xlatb19 = 0.828100026<u_xlat1.z;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb19 = !!(u_xlat2.x==0.0);
					#else
					                u_xlatb19 = u_xlat2.x==0.0;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                if(!u_xlatb18){break;}
					                u_xlat2.xy = textureLod(_MainTex, u_xlat1.xy, 0.0).xy;
					                u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					                u_xlat1.z = u_xlat2.y;
					            }
					            u_xlat2.yz = u_xlat1.xz;
					            u_xlat1.xy = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					            u_xlat16_18 = textureLod(_SearchTex, u_xlat1.xy, 0.0).w;
					            u_xlat16_18 = u_xlat16_18 * -2.00787401 + 3.25;
					            u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_18 + u_xlat2.y;
					            u_xlat1.y = vs_TEXCOORD3.y;
					            u_xlat2.x = textureLod(_MainTex, u_xlat1.xy, 0.0).x;
					            u_xlat3.xy = vs_TEXCOORD2.zw;
					            u_xlat3.z = 1.0;
					            u_xlat4.x = 0.0;
					            while(true){
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb18 = !!(u_xlat3.x<vs_TEXCOORD4.y);
					#else
					                u_xlatb18 = u_xlat3.x<vs_TEXCOORD4.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb14 = !!(0.828100026<u_xlat3.z);
					#else
					                u_xlatb14 = 0.828100026<u_xlat3.z;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb14;
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb14 = !!(u_xlat4.x==0.0);
					#else
					                u_xlatb14 = u_xlat4.x==0.0;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb14;
					                if(!u_xlatb18){break;}
					                u_xlat4.xy = textureLod(_MainTex, u_xlat3.xy, 0.0).xy;
					                u_xlat3.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat3.xy;
					                u_xlat3.z = u_xlat4.y;
					            }
					            u_xlat4.yz = u_xlat3.xz;
					            u_xlat14.xy = u_xlat4.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					            u_xlat16_18 = textureLod(_SearchTex, u_xlat14.xy, 0.0).w;
					            u_xlat16_18 = u_xlat16_18 * -2.00787401 + 3.25;
					            u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_18 + u_xlat4.y;
					            u_xlat3 = _MainTex_TexelSize.zzzz * u_xlat1.zxzx + (-vs_TEXCOORD1.xxxx);
					            u_xlat3 = roundEven(u_xlat3);
					            u_xlat14.xy = sqrt(abs(u_xlat3.wz));
					            u_xlat4.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					            u_xlat2.y = textureLod(_MainTex, u_xlat4.xy, 0.0).x;
					            u_xlat2.xy = u_xlat2.xy * vec2(4.0, 4.0);
					            u_xlat2.xy = roundEven(u_xlat2.xy);
					            u_xlat2.xy = u_xlat2.xy * vec2(16.0, 16.0) + u_xlat14.xy;
					            u_xlat2.xy = u_xlat2.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					            u_xlat16_2.xy = textureLod(_AreaTex, u_xlat2.xy, 0.0).xy;
					            u_xlatb3 = greaterThanEqual(abs(u_xlat3), abs(u_xlat3.wzwz));
					            u_xlat3 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 0.75, 0.75), vec4(u_xlatb3));
					            u_xlat18 = u_xlat3.y + u_xlat3.x;
					            u_xlat14.xy = u_xlat3.zw / vec2(u_xlat18);
					            u_xlat1.w = vs_TEXCOORD0.y;
					            u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat1.xw;
					            u_xlat16_18 = textureLod(_MainTex, u_xlat3.xy, 0.0).x;
					            u_xlat18 = (-u_xlat14.x) * u_xlat16_18 + 1.0;
					            u_xlat3.xy = u_xlat1.zw + _MainTex_TexelSize.xy;
					            u_xlat16_7.x = textureLod(_MainTex, u_xlat3.xy, 0.0).x;
					            u_xlat3.x = (-u_xlat14.y) * u_xlat16_7.x + u_xlat18;
					#ifdef UNITY_ADRENO_ES3
					            u_xlat3.x = min(max(u_xlat3.x, 0.0), 1.0);
					#else
					            u_xlat3.x = clamp(u_xlat3.x, 0.0, 1.0);
					#endif
					            u_xlat1 = _MainTex_TexelSize.xyxy * vec4(0.0, -2.0, 1.0, -2.0) + u_xlat1.xwzw;
					            u_xlat16_18 = textureLod(_MainTex, u_xlat1.xy, 0.0).x;
					            u_xlat18 = (-u_xlat14.x) * u_xlat16_18 + 1.0;
					            u_xlat16_1.x = textureLod(_MainTex, u_xlat1.zw, 0.0).x;
					            u_xlat3.y = (-u_xlat14.y) * u_xlat16_1.x + u_xlat18;
					#ifdef UNITY_ADRENO_ES3
					            u_xlat3.y = min(max(u_xlat3.y, 0.0), 1.0);
					#else
					            u_xlat3.y = clamp(u_xlat3.y, 0.0, 1.0);
					#endif
					            SV_Target0.xy = u_xlat16_2.xy * u_xlat3.xy;
					        } else {
					            SV_Target0.xy = u_xlat6.xy;
					            u_xlat0.x = 0.0;
					        //ENDIF
					        }
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(0.0<u_xlat0.x);
					#else
					    u_xlatb0 = 0.0<u_xlat0.x;
					#endif
					    if(u_xlatb0){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb18 = !!(vs_TEXCOORD4.z<u_xlat0.y);
					#else
					            u_xlatb18 = vs_TEXCOORD4.z<u_xlat0.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(0.828100026<u_xlat0.z);
					#else
					            u_xlatb19 = 0.828100026<u_xlat0.z;
					#endif
					            u_xlatb18 = u_xlatb18 && u_xlatb19;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(u_xlat1.x==0.0);
					#else
					            u_xlatb19 = u_xlat1.x==0.0;
					#endif
					            u_xlatb18 = u_xlatb18 && u_xlatb19;
					            if(!u_xlatb18){break;}
					            u_xlat1.xy = textureLod(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0 = textureLod(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0 = u_xlat16_0 * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0 + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = textureLod(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat2.y<vs_TEXCOORD4.w);
					#else
					            u_xlatb13 = u_xlat2.y<vs_TEXCOORD4.w;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb19 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb13 = u_xlatb19 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb19 = u_xlat3.x==0.0;
					#endif
					            u_xlatb13 = u_xlatb19 && u_xlatb13;
					            if(!u_xlatb13){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat13.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_13 = textureLod(_SearchTex, u_xlat13.xy, 0.0).w;
					        u_xlat16_13 = u_xlat16_13 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_13 + u_xlat3.y;
					        u_xlat2 = _MainTex_TexelSize.wwww * u_xlat0.zxzx + (-vs_TEXCOORD1.yyyy);
					        u_xlat2 = roundEven(u_xlat2);
					        u_xlat13.xy = sqrt(abs(u_xlat2.wz));
					        u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = textureLod(_MainTex, u_xlat3.xy, 0.0).y;
					        u_xlat1.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat1.xy = roundEven(u_xlat1.xy);
					        u_xlat1.xy = u_xlat1.xy * vec2(16.0, 16.0) + u_xlat13.xy;
					        u_xlat1.xy = u_xlat1.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_1.xy = textureLod(_AreaTex, u_xlat1.xy, 0.0).xy;
					        u_xlatb2 = greaterThanEqual(abs(u_xlat2), abs(u_xlat2.wzwz));
					        u_xlat2 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 0.75, 0.75), vec4(u_xlatb2));
					        u_xlat6.x = u_xlat2.y + u_xlat2.x;
					        u_xlat13.xy = u_xlat2.zw / u_xlat6.xx;
					        u_xlat0.w = vs_TEXCOORD0.x;
					        u_xlat2.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat0.wx;
					        u_xlat16_6 = textureLod(_MainTex, u_xlat2.xy, 0.0).y;
					        u_xlat6.x = (-u_xlat13.x) * u_xlat16_6 + 1.0;
					        u_xlat2.xy = u_xlat0.wz + _MainTex_TexelSize.xy;
					        u_xlat16_2.x = textureLod(_MainTex, u_xlat2.xy, 0.0).y;
					        u_xlat14.x = (-u_xlat13.y) * u_xlat16_2.x + u_xlat6.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlat14.x = min(max(u_xlat14.x, 0.0), 1.0);
					#else
					        u_xlat14.x = clamp(u_xlat14.x, 0.0, 1.0);
					#endif
					        u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, -2.0, 1.0) + u_xlat0.wxwz;
					        u_xlat16_0 = textureLod(_MainTex, u_xlat0.xy, 0.0).y;
					        u_xlat0.x = (-u_xlat13.x) * u_xlat16_0 + 1.0;
					        u_xlat16_6 = textureLod(_MainTex, u_xlat0.zw, 0.0).y;
					        u_xlat14.y = (-u_xlat13.y) * u_xlat16_6 + u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlat14.y = min(max(u_xlat14.y, 0.0), 1.0);
					#else
					        u_xlat14.y = clamp(u_xlat14.y, 0.0, 1.0);
					#endif
					        SV_Target0.zw = u_xlat16_1.xy * u_xlat14.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec2 vs_TEXCOORD1;
					out highp vec4 vs_TEXCOORD2;
					out highp vec4 vs_TEXCOORD3;
					out highp vec4 vs_TEXCOORD4;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    vs_TEXCOORD0.xy = in_POSITION0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
					    u_xlat0 = in_POSITION0.xyxy + vec4(1.0, 1.0, 1.0, 1.0);
					    u_xlat0 = u_xlat0 * vec4(0.5, 0.5, 0.5, 0.5);
					    vs_TEXCOORD1.xy = u_xlat0.zw * _MainTex_TexelSize.zw;
					    u_xlat1 = _MainTex_TexelSize.xxyy * vec4(-0.25, 1.25, -0.125, -0.125) + u_xlat0.zzww;
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-0.125, -0.25, -0.125, 1.25) + u_xlat0;
					    vs_TEXCOORD2 = u_xlat1.xzyw;
					    vs_TEXCOORD3 = u_xlat0;
					    u_xlat1.zw = u_xlat0.yw;
					    vs_TEXCOORD4 = _MainTex_TexelSize.xxyy * vec4(-32.0, 32.0, -32.0, 32.0) + u_xlat1;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _MainTex;
					uniform mediump sampler2D _AreaTex;
					uniform mediump sampler2D _SearchTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec2 vs_TEXCOORD1;
					in highp vec4 vs_TEXCOORD2;
					in highp vec4 vs_TEXCOORD3;
					in highp vec4 vs_TEXCOORD4;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					mediump float u_xlat16_0;
					bool u_xlatb0;
					vec4 u_xlat1;
					mediump vec2 u_xlat16_1;
					vec4 u_xlat2;
					mediump vec2 u_xlat16_2;
					bvec4 u_xlatb2;
					vec4 u_xlat3;
					mediump vec2 u_xlat16_3;
					bvec4 u_xlatb3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					mediump vec2 u_xlat16_5;
					vec3 u_xlat6;
					mediump float u_xlat16_6;
					bool u_xlatb6;
					vec3 u_xlat7;
					mediump vec3 u_xlat16_7;
					bvec3 u_xlatb7;
					vec3 u_xlat8;
					vec2 u_xlat13;
					mediump float u_xlat16_13;
					bool u_xlatb13;
					vec2 u_xlat14;
					bool u_xlatb14;
					mediump vec2 u_xlat16_15;
					bool u_xlatb15;
					float u_xlat18;
					mediump float u_xlat16_18;
					bool u_xlatb18;
					float u_xlat19;
					mediump float u_xlat16_19;
					bool u_xlatb19;
					float u_xlat20;
					bool u_xlatb21;
					void main()
					{
					    u_xlat0.xy = texture(_MainTex, vs_TEXCOORD0.xy).xy;
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb6 = !!(0.0<u_xlat0.y);
					#else
					    u_xlatb6 = 0.0<u_xlat0.y;
					#endif
					    if(u_xlatb6){
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb6 = !!(0.0<u_xlat0.x);
					#else
					        u_xlatb6 = 0.0<u_xlat0.x;
					#endif
					        if(u_xlatb6){
					            u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-1.0, 1.0);
					            u_xlat1.z = 1.0;
					            u_xlat2.xy = vs_TEXCOORD0.xy;
					            u_xlat6.x = 0.0;
					            u_xlat2.z = -1.0;
					            u_xlat3.x = 1.0;
					            while(true){
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb18 = !!(u_xlat2.z<7.0);
					#else
					                u_xlatb18 = u_xlat2.z<7.0;
					#endif
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb19 = !!(0.899999976<u_xlat3.x);
					#else
					                u_xlatb19 = 0.899999976<u_xlat3.x;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                if(!u_xlatb18){break;}
					                u_xlat2.xyz = u_xlat1.xyz + u_xlat2.xyz;
					                u_xlat6.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).yx;
					                u_xlat3.x = dot(u_xlat6.yx, vec2(0.5, 0.5));
					            }
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb6 = !!(0.899999976<u_xlat6.x);
					#else
					            u_xlatb6 = 0.899999976<u_xlat6.x;
					#endif
					            u_xlat6.x = u_xlatb6 ? 1.0 : float(0.0);
					            u_xlat1.x = u_xlat6.x + u_xlat2.z;
					        } else {
					            u_xlat1.x = 0.0;
					            u_xlat3.x = 0.0;
					        //ENDIF
					        }
					        u_xlat6.xy = _MainTex_TexelSize.xy * vec2(1.0, -1.0);
					        u_xlat6.z = 1.0;
					        u_xlat2.yz = vs_TEXCOORD0.xy;
					        u_xlat2.x = float(-1.0);
					        u_xlat20 = float(1.0);
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb15 = !!(u_xlat2.x<7.0);
					#else
					            u_xlatb15 = u_xlat2.x<7.0;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb21 = !!(0.899999976<u_xlat20);
					#else
					            u_xlatb21 = 0.899999976<u_xlat20;
					#endif
					            u_xlatb15 = u_xlatb21 && u_xlatb15;
					            if(!u_xlatb15){break;}
					            u_xlat2.xyz = u_xlat6.zxy + u_xlat2.xyz;
					            u_xlat16_15.xy = textureLod(_MainTex, u_xlat2.yz, 0.0).xy;
					            u_xlat20 = dot(u_xlat16_15.xy, vec2(0.5, 0.5));
					        }
					        u_xlat3.y = u_xlat20;
					        u_xlat6.x = u_xlat1.x + u_xlat2.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb6 = !!(2.0<u_xlat6.x);
					#else
					        u_xlatb6 = 2.0<u_xlat6.x;
					#endif
					        if(u_xlatb6){
					            u_xlat1.y = (-u_xlat1.x) + 0.25;
					            u_xlat1.zw = u_xlat2.xx * vec2(1.0, -1.0) + vec2(0.0, -0.25);
					            u_xlat2 = u_xlat1.yxzw * _MainTex_TexelSize.xyxy + vs_TEXCOORD0.xyxy;
					            u_xlat2 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 1.0, 0.0) + u_xlat2;
					            u_xlat6.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).xy;
					            u_xlat16_7.xz = textureLod(_MainTex, u_xlat2.zw, 0.0).xy;
					            u_xlat6.z = u_xlat16_7.x;
					            u_xlat2.xy = u_xlat6.xz * vec2(5.0, 5.0) + vec2(-3.75, -3.75);
					            u_xlat6.xz = u_xlat6.xz * abs(u_xlat2.xy);
					            u_xlat6.xz = roundEven(u_xlat6.xz);
					            u_xlat8.x = roundEven(u_xlat6.y);
					            u_xlat8.z = roundEven(u_xlat16_7.z);
					            u_xlat6.xy = u_xlat8.xz * vec2(2.0, 2.0) + u_xlat6.xz;
					            u_xlatb7.xz = greaterThanEqual(u_xlat3.xxyy, vec4(0.899999976, 0.0, 0.899999976, 0.899999976)).xz;
					            {
					                vec3 hlslcc_movcTemp = u_xlat6;
					                hlslcc_movcTemp.x = (u_xlatb7.x) ? float(0.0) : u_xlat6.x;
					                hlslcc_movcTemp.y = (u_xlatb7.z) ? float(0.0) : u_xlat6.y;
					                u_xlat6 = hlslcc_movcTemp;
					            }
					            u_xlat6.xy = u_xlat6.xy * vec2(20.0, 20.0) + u_xlat1.xz;
					            u_xlat6.xy = u_xlat6.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.503125012, 0.000892857148);
					            u_xlat6.xy = textureLod(_AreaTex, u_xlat6.xy, 0.0).xy;
					        } else {
					            u_xlat6.x = float(0.0);
					            u_xlat6.y = float(0.0);
					        //ENDIF
					        }
					        u_xlat18 = _MainTex_TexelSize.x * 0.25 + vs_TEXCOORD0.x;
					        u_xlat1.xy = (-_MainTex_TexelSize.xy);
					        u_xlat1.z = 1.0;
					        u_xlat8.x = u_xlat18;
					        u_xlat8.y = vs_TEXCOORD0.y;
					        u_xlat2.x = float(1.0);
					        u_xlat8.z = float(-1.0);
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(u_xlat8.z<7.0);
					#else
					            u_xlatb19 = u_xlat8.z<7.0;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb3.x = !!(0.899999976<u_xlat2.x);
					#else
					            u_xlatb3.x = 0.899999976<u_xlat2.x;
					#endif
					            u_xlatb19 = u_xlatb19 && u_xlatb3.x;
					            if(!u_xlatb19){break;}
					            u_xlat8.xyz = u_xlat1.xyz + u_xlat8.xyz;
					            u_xlat16_3.xy = textureLod(_MainTex, u_xlat8.xy, 0.0).xy;
					            u_xlat16_19 = u_xlat16_3.x * 5.0 + -3.75;
					            u_xlat19 = abs(u_xlat16_19) * u_xlat16_3.x;
					            u_xlat4.x = roundEven(u_xlat19);
					            u_xlat4.y = roundEven(u_xlat16_3.y);
					            u_xlat2.x = dot(u_xlat4.xy, vec2(0.5, 0.5));
					        }
					        u_xlat1.x = u_xlat8.z;
					        u_xlat14.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + vs_TEXCOORD0.xy;
					        u_xlat19 = textureLod(_MainTex, u_xlat14.xy, 0.0).x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb19 = !!(0.0<u_xlat19);
					#else
					        u_xlatb19 = 0.0<u_xlat19;
					#endif
					        if(u_xlatb19){
					            u_xlat3.xy = _MainTex_TexelSize.xy;
					            u_xlat3.z = 1.0;
					            u_xlat4.x = u_xlat18;
					            u_xlat4.y = vs_TEXCOORD0.y;
					            u_xlat4.z = -1.0;
					            u_xlat2.y = float(1.0);
					            u_xlat14.x = float(0.0);
					            while(true){
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb19 = !!(u_xlat4.z<7.0);
					#else
					                u_xlatb19 = u_xlat4.z<7.0;
					#endif
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb21 = !!(0.899999976<u_xlat2.y);
					#else
					                u_xlatb21 = 0.899999976<u_xlat2.y;
					#endif
					                u_xlatb19 = u_xlatb19 && u_xlatb21;
					                if(!u_xlatb19){break;}
					                u_xlat4.xyz = u_xlat3.xyz + u_xlat4.xyz;
					                u_xlat16_5.xy = textureLod(_MainTex, u_xlat4.xy, 0.0).xy;
					                u_xlat16_19 = u_xlat16_5.x * 5.0 + -3.75;
					                u_xlat19 = abs(u_xlat16_19) * u_xlat16_5.x;
					                u_xlat14.y = roundEven(u_xlat19);
					                u_xlat14.x = roundEven(u_xlat16_5.y);
					                u_xlat2.y = dot(u_xlat14.yx, vec2(0.5, 0.5));
					            }
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb18 = !!(0.899999976<u_xlat14.x);
					#else
					            u_xlatb18 = 0.899999976<u_xlat14.x;
					#endif
					            u_xlat18 = u_xlatb18 ? 1.0 : float(0.0);
					            u_xlat1.z = u_xlat18 + u_xlat4.z;
					        } else {
					            u_xlat1.z = 0.0;
					            u_xlat2.y = 0.0;
					        //ENDIF
					        }
					        u_xlat18 = u_xlat1.z + u_xlat1.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb18 = !!(2.0<u_xlat18);
					#else
					        u_xlatb18 = 2.0<u_xlat18;
					#endif
					        if(u_xlatb18){
					            u_xlat1.y = (-u_xlat1.x);
					            u_xlat3 = u_xlat1.yyzz * _MainTex_TexelSize.xyxy + vs_TEXCOORD0.xyxy;
					            u_xlat4 = _MainTex_TexelSize.xyxy * vec4(-1.0, 0.0, 0.0, -1.0) + u_xlat3.xyxy;
					            u_xlat5.x = textureLod(_MainTex, u_xlat4.xy, 0.0).y;
					            u_xlat5.z = textureLod(_MainTex, u_xlat4.zw, 0.0).x;
					            u_xlat7.xz = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat3.zw;
					            u_xlat5.yw = textureLod(_MainTex, u_xlat7.xz, 0.0).yx;
					            u_xlat7.xz = u_xlat5.xy * vec2(2.0, 2.0) + u_xlat5.zw;
					            u_xlatb2.xy = greaterThanEqual(u_xlat2.xyxx, vec4(0.899999976, 0.899999976, 0.0, 0.0)).xy;
					            {
					                vec3 hlslcc_movcTemp = u_xlat7;
					                hlslcc_movcTemp.x = (u_xlatb2.x) ? float(0.0) : u_xlat7.x;
					                hlslcc_movcTemp.z = (u_xlatb2.y) ? float(0.0) : u_xlat7.z;
					                u_xlat7 = hlslcc_movcTemp;
					            }
					            u_xlat1.xy = u_xlat7.xz * vec2(20.0, 20.0) + u_xlat1.xz;
					            u_xlat1.xy = u_xlat1.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.503125012, 0.000892857148);
					            u_xlat16_1.xy = textureLod(_AreaTex, u_xlat1.xy, 0.0).xy;
					            u_xlat6.xy = u_xlat6.xy + u_xlat16_1.yx;
					        //ENDIF
					        }
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb18 = !!((-u_xlat6.y)==u_xlat6.x);
					#else
					        u_xlatb18 = (-u_xlat6.y)==u_xlat6.x;
					#endif
					        if(u_xlatb18){
					            u_xlat1.xy = vs_TEXCOORD2.xy;
					            u_xlat1.z = 1.0;
					            u_xlat2.x = 0.0;
					            while(true){
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb18 = !!(vs_TEXCOORD4.x<u_xlat1.x);
					#else
					                u_xlatb18 = vs_TEXCOORD4.x<u_xlat1.x;
					#endif
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb19 = !!(0.828100026<u_xlat1.z);
					#else
					                u_xlatb19 = 0.828100026<u_xlat1.z;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb19 = !!(u_xlat2.x==0.0);
					#else
					                u_xlatb19 = u_xlat2.x==0.0;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb19;
					                if(!u_xlatb18){break;}
					                u_xlat2.xy = textureLod(_MainTex, u_xlat1.xy, 0.0).xy;
					                u_xlat1.xy = _MainTex_TexelSize.xy * vec2(-2.0, -0.0) + u_xlat1.xy;
					                u_xlat1.z = u_xlat2.y;
					            }
					            u_xlat2.yz = u_xlat1.xz;
					            u_xlat1.xy = u_xlat2.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					            u_xlat16_18 = textureLod(_SearchTex, u_xlat1.xy, 0.0).w;
					            u_xlat16_18 = u_xlat16_18 * -2.00787401 + 3.25;
					            u_xlat1.x = _MainTex_TexelSize.x * u_xlat16_18 + u_xlat2.y;
					            u_xlat1.y = vs_TEXCOORD3.y;
					            u_xlat2.x = textureLod(_MainTex, u_xlat1.xy, 0.0).x;
					            u_xlat3.xy = vs_TEXCOORD2.zw;
					            u_xlat3.z = 1.0;
					            u_xlat4.x = 0.0;
					            while(true){
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb18 = !!(u_xlat3.x<vs_TEXCOORD4.y);
					#else
					                u_xlatb18 = u_xlat3.x<vs_TEXCOORD4.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb14 = !!(0.828100026<u_xlat3.z);
					#else
					                u_xlatb14 = 0.828100026<u_xlat3.z;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb14;
					#ifdef UNITY_ADRENO_ES3
					                u_xlatb14 = !!(u_xlat4.x==0.0);
					#else
					                u_xlatb14 = u_xlat4.x==0.0;
					#endif
					                u_xlatb18 = u_xlatb18 && u_xlatb14;
					                if(!u_xlatb18){break;}
					                u_xlat4.xy = textureLod(_MainTex, u_xlat3.xy, 0.0).xy;
					                u_xlat3.xy = _MainTex_TexelSize.xy * vec2(2.0, 0.0) + u_xlat3.xy;
					                u_xlat3.z = u_xlat4.y;
					            }
					            u_xlat4.yz = u_xlat3.xz;
					            u_xlat14.xy = u_xlat4.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					            u_xlat16_18 = textureLod(_SearchTex, u_xlat14.xy, 0.0).w;
					            u_xlat16_18 = u_xlat16_18 * -2.00787401 + 3.25;
					            u_xlat1.z = (-_MainTex_TexelSize.x) * u_xlat16_18 + u_xlat4.y;
					            u_xlat3 = _MainTex_TexelSize.zzzz * u_xlat1.zxzx + (-vs_TEXCOORD1.xxxx);
					            u_xlat3 = roundEven(u_xlat3);
					            u_xlat14.xy = sqrt(abs(u_xlat3.wz));
					            u_xlat4.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat1.zy;
					            u_xlat2.y = textureLod(_MainTex, u_xlat4.xy, 0.0).x;
					            u_xlat2.xy = u_xlat2.xy * vec2(4.0, 4.0);
					            u_xlat2.xy = roundEven(u_xlat2.xy);
					            u_xlat2.xy = u_xlat2.xy * vec2(16.0, 16.0) + u_xlat14.xy;
					            u_xlat2.xy = u_xlat2.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					            u_xlat16_2.xy = textureLod(_AreaTex, u_xlat2.xy, 0.0).xy;
					            u_xlatb3 = greaterThanEqual(abs(u_xlat3), abs(u_xlat3.wzwz));
					            u_xlat3 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 0.75, 0.75), vec4(u_xlatb3));
					            u_xlat18 = u_xlat3.y + u_xlat3.x;
					            u_xlat14.xy = u_xlat3.zw / vec2(u_xlat18);
					            u_xlat1.w = vs_TEXCOORD0.y;
					            u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat1.xw;
					            u_xlat16_18 = textureLod(_MainTex, u_xlat3.xy, 0.0).x;
					            u_xlat18 = (-u_xlat14.x) * u_xlat16_18 + 1.0;
					            u_xlat3.xy = u_xlat1.zw + _MainTex_TexelSize.xy;
					            u_xlat16_7.x = textureLod(_MainTex, u_xlat3.xy, 0.0).x;
					            u_xlat3.x = (-u_xlat14.y) * u_xlat16_7.x + u_xlat18;
					#ifdef UNITY_ADRENO_ES3
					            u_xlat3.x = min(max(u_xlat3.x, 0.0), 1.0);
					#else
					            u_xlat3.x = clamp(u_xlat3.x, 0.0, 1.0);
					#endif
					            u_xlat1 = _MainTex_TexelSize.xyxy * vec4(0.0, -2.0, 1.0, -2.0) + u_xlat1.xwzw;
					            u_xlat16_18 = textureLod(_MainTex, u_xlat1.xy, 0.0).x;
					            u_xlat18 = (-u_xlat14.x) * u_xlat16_18 + 1.0;
					            u_xlat16_1.x = textureLod(_MainTex, u_xlat1.zw, 0.0).x;
					            u_xlat3.y = (-u_xlat14.y) * u_xlat16_1.x + u_xlat18;
					#ifdef UNITY_ADRENO_ES3
					            u_xlat3.y = min(max(u_xlat3.y, 0.0), 1.0);
					#else
					            u_xlat3.y = clamp(u_xlat3.y, 0.0, 1.0);
					#endif
					            SV_Target0.xy = u_xlat16_2.xy * u_xlat3.xy;
					        } else {
					            SV_Target0.xy = u_xlat6.xy;
					            u_xlat0.x = 0.0;
					        //ENDIF
					        }
					    } else {
					        SV_Target0.xy = vec2(0.0, 0.0);
					    //ENDIF
					    }
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb0 = !!(0.0<u_xlat0.x);
					#else
					    u_xlatb0 = 0.0<u_xlat0.x;
					#endif
					    if(u_xlatb0){
					        u_xlat0.xy = vs_TEXCOORD3.xy;
					        u_xlat0.z = 1.0;
					        u_xlat1.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb18 = !!(vs_TEXCOORD4.z<u_xlat0.y);
					#else
					            u_xlatb18 = vs_TEXCOORD4.z<u_xlat0.y;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(0.828100026<u_xlat0.z);
					#else
					            u_xlatb19 = 0.828100026<u_xlat0.z;
					#endif
					            u_xlatb18 = u_xlatb18 && u_xlatb19;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(u_xlat1.x==0.0);
					#else
					            u_xlatb19 = u_xlat1.x==0.0;
					#endif
					            u_xlatb18 = u_xlatb18 && u_xlatb19;
					            if(!u_xlatb18){break;}
					            u_xlat1.xy = textureLod(_MainTex, u_xlat0.xy, 0.0).yx;
					            u_xlat0.xy = _MainTex_TexelSize.xy * vec2(-0.0, -2.0) + u_xlat0.xy;
					            u_xlat0.z = u_xlat1.y;
					        }
					        u_xlat1.yz = u_xlat0.yz;
					        u_xlat0.xy = u_xlat1.xz * vec2(0.5, -2.0) + vec2(0.0078125, 2.03125);
					        u_xlat16_0 = textureLod(_SearchTex, u_xlat0.xy, 0.0).w;
					        u_xlat16_0 = u_xlat16_0 * -2.00787401 + 3.25;
					        u_xlat0.x = _MainTex_TexelSize.y * u_xlat16_0 + u_xlat1.y;
					        u_xlat0.y = vs_TEXCOORD2.x;
					        u_xlat1.x = textureLod(_MainTex, u_xlat0.yx, 0.0).y;
					        u_xlat2.xy = vs_TEXCOORD3.zw;
					        u_xlat2.z = 1.0;
					        u_xlat3.x = 0.0;
					        while(true){
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb13 = !!(u_xlat2.y<vs_TEXCOORD4.w);
					#else
					            u_xlatb13 = u_xlat2.y<vs_TEXCOORD4.w;
					#endif
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(0.828100026<u_xlat2.z);
					#else
					            u_xlatb19 = 0.828100026<u_xlat2.z;
					#endif
					            u_xlatb13 = u_xlatb19 && u_xlatb13;
					#ifdef UNITY_ADRENO_ES3
					            u_xlatb19 = !!(u_xlat3.x==0.0);
					#else
					            u_xlatb19 = u_xlat3.x==0.0;
					#endif
					            u_xlatb13 = u_xlatb19 && u_xlatb13;
					            if(!u_xlatb13){break;}
					            u_xlat3.xy = textureLod(_MainTex, u_xlat2.xy, 0.0).yx;
					            u_xlat2.xy = _MainTex_TexelSize.xy * vec2(0.0, 2.0) + u_xlat2.xy;
					            u_xlat2.z = u_xlat3.y;
					        }
					        u_xlat3.yz = u_xlat2.yz;
					        u_xlat13.xy = u_xlat3.xz * vec2(0.5, -2.0) + vec2(0.5234375, 2.03125);
					        u_xlat16_13 = textureLod(_SearchTex, u_xlat13.xy, 0.0).w;
					        u_xlat16_13 = u_xlat16_13 * -2.00787401 + 3.25;
					        u_xlat0.z = (-_MainTex_TexelSize.y) * u_xlat16_13 + u_xlat3.y;
					        u_xlat2 = _MainTex_TexelSize.wwww * u_xlat0.zxzx + (-vs_TEXCOORD1.yyyy);
					        u_xlat2 = roundEven(u_xlat2);
					        u_xlat13.xy = sqrt(abs(u_xlat2.wz));
					        u_xlat3.xy = _MainTex_TexelSize.xy * vec2(0.0, 1.0) + u_xlat0.yz;
					        u_xlat1.y = textureLod(_MainTex, u_xlat3.xy, 0.0).y;
					        u_xlat1.xy = u_xlat1.xy * vec2(4.0, 4.0);
					        u_xlat1.xy = roundEven(u_xlat1.xy);
					        u_xlat1.xy = u_xlat1.xy * vec2(16.0, 16.0) + u_xlat13.xy;
					        u_xlat1.xy = u_xlat1.xy * vec2(0.00625000009, 0.0017857143) + vec2(0.00312500005, 0.000892857148);
					        u_xlat16_1.xy = textureLod(_AreaTex, u_xlat1.xy, 0.0).xy;
					        u_xlatb2 = greaterThanEqual(abs(u_xlat2), abs(u_xlat2.wzwz));
					        u_xlat2 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 0.75, 0.75), vec4(u_xlatb2));
					        u_xlat6.x = u_xlat2.y + u_xlat2.x;
					        u_xlat13.xy = u_xlat2.zw / u_xlat6.xx;
					        u_xlat0.w = vs_TEXCOORD0.x;
					        u_xlat2.xy = _MainTex_TexelSize.xy * vec2(1.0, 0.0) + u_xlat0.wx;
					        u_xlat16_6 = textureLod(_MainTex, u_xlat2.xy, 0.0).y;
					        u_xlat6.x = (-u_xlat13.x) * u_xlat16_6 + 1.0;
					        u_xlat2.xy = u_xlat0.wz + _MainTex_TexelSize.xy;
					        u_xlat16_2.x = textureLod(_MainTex, u_xlat2.xy, 0.0).y;
					        u_xlat14.x = (-u_xlat13.y) * u_xlat16_2.x + u_xlat6.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlat14.x = min(max(u_xlat14.x, 0.0), 1.0);
					#else
					        u_xlat14.x = clamp(u_xlat14.x, 0.0, 1.0);
					#endif
					        u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-2.0, 0.0, -2.0, 1.0) + u_xlat0.wxwz;
					        u_xlat16_0 = textureLod(_MainTex, u_xlat0.xy, 0.0).y;
					        u_xlat0.x = (-u_xlat13.x) * u_xlat16_0 + 1.0;
					        u_xlat16_6 = textureLod(_MainTex, u_xlat0.zw, 0.0).y;
					        u_xlat14.y = (-u_xlat13.y) * u_xlat16_6 + u_xlat0.x;
					#ifdef UNITY_ADRENO_ES3
					        u_xlat14.y = min(max(u_xlat14.y, 0.0), 1.0);
					#else
					        u_xlat14.y = clamp(u_xlat14.y, 0.0, 1.0);
					#endif
					        SV_Target0.zw = u_xlat16_1.xy * u_xlat14.xy;
					    } else {
					        SV_Target0.zw = vec2(0.0, 0.0);
					    //ENDIF
					    }
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
			GpuProgramID 426764
			Program "vp" {
				SubProgram "gles hw_tier00 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _BlendTex;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					lowp vec4 u_xlat10_1;
					bool u_xlatb1;
					vec4 u_xlat2;
					lowp vec4 u_xlat10_2;
					float u_xlat6;
					void main()
					{
					    u_xlat0.x = texture2D(_BlendTex, vs_TEXCOORD1.xy).w;
					    u_xlat0.y = texture2D(_BlendTex, vs_TEXCOORD1.zw).y;
					    u_xlat0.zw = texture2D(_BlendTex, vs_TEXCOORD0.xy).zx;
					    u_xlat1.x = dot(u_xlat0, vec4(1.0, 1.0, 1.0, 1.0));
					    u_xlatb1 = u_xlat1.x<9.99999975e-06;
					    if(u_xlatb1){
					        SV_Target0 = texture2DLodEXT(_MainTex, vs_TEXCOORD0.xy, 0.0);
					    } else {
					        u_xlat1.xy = max(u_xlat0.zw, u_xlat0.xy);
					        u_xlatb1 = u_xlat1.y<u_xlat1.x;
					        u_xlat2.xz = mix(vec2(0.0, 0.0), u_xlat0.xz, vec2(bvec2(u_xlatb1)));
					        u_xlat2.yw = (bool(u_xlatb1)) ? vec2(0.0, 0.0) : u_xlat0.yw;
					        u_xlat0.x = (u_xlatb1) ? u_xlat0.x : u_xlat0.y;
					        u_xlat0.y = (u_xlatb1) ? u_xlat0.z : u_xlat0.w;
					        u_xlat6 = dot(u_xlat0.xy, vec2(1.0, 1.0));
					        u_xlat0.xy = u_xlat0.xy / vec2(u_xlat6);
					        u_xlat1 = _MainTex_TexelSize.xyxy * vec4(1.0, 1.0, -1.0, -1.0);
					        u_xlat1 = u_xlat2 * u_xlat1 + vs_TEXCOORD0.xyxy;
					        u_xlat10_2 = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0);
					        u_xlat10_1 = texture2DLodEXT(_MainTex, u_xlat1.zw, 0.0);
					        u_xlat1 = u_xlat0.yyyy * u_xlat10_1;
					        SV_Target0 = u_xlat0.xxxx * u_xlat10_2 + u_xlat1;
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier01 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _BlendTex;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					lowp vec4 u_xlat10_1;
					bool u_xlatb1;
					vec4 u_xlat2;
					lowp vec4 u_xlat10_2;
					float u_xlat6;
					void main()
					{
					    u_xlat0.x = texture2D(_BlendTex, vs_TEXCOORD1.xy).w;
					    u_xlat0.y = texture2D(_BlendTex, vs_TEXCOORD1.zw).y;
					    u_xlat0.zw = texture2D(_BlendTex, vs_TEXCOORD0.xy).zx;
					    u_xlat1.x = dot(u_xlat0, vec4(1.0, 1.0, 1.0, 1.0));
					    u_xlatb1 = u_xlat1.x<9.99999975e-06;
					    if(u_xlatb1){
					        SV_Target0 = texture2DLodEXT(_MainTex, vs_TEXCOORD0.xy, 0.0);
					    } else {
					        u_xlat1.xy = max(u_xlat0.zw, u_xlat0.xy);
					        u_xlatb1 = u_xlat1.y<u_xlat1.x;
					        u_xlat2.xz = mix(vec2(0.0, 0.0), u_xlat0.xz, vec2(bvec2(u_xlatb1)));
					        u_xlat2.yw = (bool(u_xlatb1)) ? vec2(0.0, 0.0) : u_xlat0.yw;
					        u_xlat0.x = (u_xlatb1) ? u_xlat0.x : u_xlat0.y;
					        u_xlat0.y = (u_xlatb1) ? u_xlat0.z : u_xlat0.w;
					        u_xlat6 = dot(u_xlat0.xy, vec2(1.0, 1.0));
					        u_xlat0.xy = u_xlat0.xy / vec2(u_xlat6);
					        u_xlat1 = _MainTex_TexelSize.xyxy * vec4(1.0, 1.0, -1.0, -1.0);
					        u_xlat1 = u_xlat2 * u_xlat1 + vs_TEXCOORD0.xyxy;
					        u_xlat10_2 = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0);
					        u_xlat10_1 = texture2DLodEXT(_MainTex, u_xlat1.zw, 0.0);
					        u_xlat1 = u_xlat0.yyyy * u_xlat10_1;
					        SV_Target0 = u_xlat0.xxxx * u_xlat10_2 + u_xlat1;
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles hw_tier02 " {
					"!!GLES
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 100
					
					uniform 	vec4 _MainTex_TexelSize;
					attribute highp vec3 in_POSITION0;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform lowp sampler2D _BlendTex;
					uniform lowp sampler2D _MainTex;
					varying highp vec2 vs_TEXCOORD0;
					varying highp vec4 vs_TEXCOORD1;
					#define SV_Target0 gl_FragData[0]
					vec4 u_xlat0;
					vec4 u_xlat1;
					lowp vec4 u_xlat10_1;
					bool u_xlatb1;
					vec4 u_xlat2;
					lowp vec4 u_xlat10_2;
					float u_xlat6;
					void main()
					{
					    u_xlat0.x = texture2D(_BlendTex, vs_TEXCOORD1.xy).w;
					    u_xlat0.y = texture2D(_BlendTex, vs_TEXCOORD1.zw).y;
					    u_xlat0.zw = texture2D(_BlendTex, vs_TEXCOORD0.xy).zx;
					    u_xlat1.x = dot(u_xlat0, vec4(1.0, 1.0, 1.0, 1.0));
					    u_xlatb1 = u_xlat1.x<9.99999975e-06;
					    if(u_xlatb1){
					        SV_Target0 = texture2DLodEXT(_MainTex, vs_TEXCOORD0.xy, 0.0);
					    } else {
					        u_xlat1.xy = max(u_xlat0.zw, u_xlat0.xy);
					        u_xlatb1 = u_xlat1.y<u_xlat1.x;
					        u_xlat2.xz = mix(vec2(0.0, 0.0), u_xlat0.xz, vec2(bvec2(u_xlatb1)));
					        u_xlat2.yw = (bool(u_xlatb1)) ? vec2(0.0, 0.0) : u_xlat0.yw;
					        u_xlat0.x = (u_xlatb1) ? u_xlat0.x : u_xlat0.y;
					        u_xlat0.y = (u_xlatb1) ? u_xlat0.z : u_xlat0.w;
					        u_xlat6 = dot(u_xlat0.xy, vec2(1.0, 1.0));
					        u_xlat0.xy = u_xlat0.xy / vec2(u_xlat6);
					        u_xlat1 = _MainTex_TexelSize.xyxy * vec4(1.0, 1.0, -1.0, -1.0);
					        u_xlat1 = u_xlat2 * u_xlat1 + vs_TEXCOORD0.xyxy;
					        u_xlat10_2 = texture2DLodEXT(_MainTex, u_xlat1.xy, 0.0);
					        u_xlat10_1 = texture2DLodEXT(_MainTex, u_xlat1.zw, 0.0);
					        u_xlat1 = u_xlat0.yyyy * u_xlat10_1;
					        SV_Target0 = u_xlat0.xxxx * u_xlat10_2 + u_xlat1;
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier00 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _BlendTex;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					bool u_xlatb1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					float u_xlat6;
					void main()
					{
					    u_xlat0.x = texture(_BlendTex, vs_TEXCOORD1.xy).w;
					    u_xlat0.y = texture(_BlendTex, vs_TEXCOORD1.zw).y;
					    u_xlat0.zw = texture(_BlendTex, vs_TEXCOORD0.xy).zx;
					    u_xlat1.x = dot(u_xlat0, vec4(1.0, 1.0, 1.0, 1.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat1.x<9.99999975e-06);
					#else
					    u_xlatb1 = u_xlat1.x<9.99999975e-06;
					#endif
					    if(u_xlatb1){
					        SV_Target0 = textureLod(_MainTex, vs_TEXCOORD0.xy, 0.0);
					    } else {
					        u_xlat1.xy = max(u_xlat0.zw, u_xlat0.xy);
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb1 = !!(u_xlat1.y<u_xlat1.x);
					#else
					        u_xlatb1 = u_xlat1.y<u_xlat1.x;
					#endif
					        u_xlat2.xz = mix(vec2(0.0, 0.0), u_xlat0.xz, vec2(bvec2(u_xlatb1)));
					        u_xlat2.yw = (bool(u_xlatb1)) ? vec2(0.0, 0.0) : u_xlat0.yw;
					        u_xlat0.x = (u_xlatb1) ? u_xlat0.x : u_xlat0.y;
					        u_xlat0.y = (u_xlatb1) ? u_xlat0.z : u_xlat0.w;
					        u_xlat6 = dot(u_xlat0.xy, vec2(1.0, 1.0));
					        u_xlat0.xy = u_xlat0.xy / vec2(u_xlat6);
					        u_xlat1 = _MainTex_TexelSize.xyxy * vec4(1.0, 1.0, -1.0, -1.0);
					        u_xlat1 = u_xlat2 * u_xlat1 + vs_TEXCOORD0.xyxy;
					        u_xlat16_2 = textureLod(_MainTex, u_xlat1.xy, 0.0);
					        u_xlat16_1 = textureLod(_MainTex, u_xlat1.zw, 0.0);
					        u_xlat1 = u_xlat0.yyyy * u_xlat16_1;
					        SV_Target0 = u_xlat0.xxxx * u_xlat16_2 + u_xlat1;
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier01 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _BlendTex;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					bool u_xlatb1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					float u_xlat6;
					void main()
					{
					    u_xlat0.x = texture(_BlendTex, vs_TEXCOORD1.xy).w;
					    u_xlat0.y = texture(_BlendTex, vs_TEXCOORD1.zw).y;
					    u_xlat0.zw = texture(_BlendTex, vs_TEXCOORD0.xy).zx;
					    u_xlat1.x = dot(u_xlat0, vec4(1.0, 1.0, 1.0, 1.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat1.x<9.99999975e-06);
					#else
					    u_xlatb1 = u_xlat1.x<9.99999975e-06;
					#endif
					    if(u_xlatb1){
					        SV_Target0 = textureLod(_MainTex, vs_TEXCOORD0.xy, 0.0);
					    } else {
					        u_xlat1.xy = max(u_xlat0.zw, u_xlat0.xy);
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb1 = !!(u_xlat1.y<u_xlat1.x);
					#else
					        u_xlatb1 = u_xlat1.y<u_xlat1.x;
					#endif
					        u_xlat2.xz = mix(vec2(0.0, 0.0), u_xlat0.xz, vec2(bvec2(u_xlatb1)));
					        u_xlat2.yw = (bool(u_xlatb1)) ? vec2(0.0, 0.0) : u_xlat0.yw;
					        u_xlat0.x = (u_xlatb1) ? u_xlat0.x : u_xlat0.y;
					        u_xlat0.y = (u_xlatb1) ? u_xlat0.z : u_xlat0.w;
					        u_xlat6 = dot(u_xlat0.xy, vec2(1.0, 1.0));
					        u_xlat0.xy = u_xlat0.xy / vec2(u_xlat6);
					        u_xlat1 = _MainTex_TexelSize.xyxy * vec4(1.0, 1.0, -1.0, -1.0);
					        u_xlat1 = u_xlat2 * u_xlat1 + vs_TEXCOORD0.xyxy;
					        u_xlat16_2 = textureLod(_MainTex, u_xlat1.xy, 0.0);
					        u_xlat16_1 = textureLod(_MainTex, u_xlat1.zw, 0.0);
					        u_xlat1 = u_xlat0.yyyy * u_xlat16_1;
					        SV_Target0 = u_xlat0.xxxx * u_xlat16_2 + u_xlat1;
					    //ENDIF
					    }
					    return;
					}
					
					#endif"
				}
				SubProgram "gles3 hw_tier02 " {
					"!!GLES3
					//ShaderGLESExporter
					#ifdef VERTEX
					#version 300 es
					
					uniform 	vec4 _MainTex_TexelSize;
					in highp vec3 in_POSITION0;
					out highp vec2 vs_TEXCOORD0;
					out highp vec4 vs_TEXCOORD1;
					vec2 u_xlat0;
					void main()
					{
					    gl_Position.xy = in_POSITION0.xy;
					    gl_Position.zw = vec2(0.0, 1.0);
					    u_xlat0.xy = in_POSITION0.xy + vec2(1.0, 1.0);
					    u_xlat0.xy = u_xlat0.xy * vec2(0.5, 0.5);
					    vs_TEXCOORD0.xy = u_xlat0.xy;
					    vs_TEXCOORD1 = _MainTex_TexelSize.xyxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.xyxy;
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
					uniform 	vec4 _MainTex_TexelSize;
					uniform mediump sampler2D _BlendTex;
					uniform mediump sampler2D _MainTex;
					in highp vec2 vs_TEXCOORD0;
					in highp vec4 vs_TEXCOORD1;
					layout(location = 0) out highp vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					mediump vec4 u_xlat16_1;
					bool u_xlatb1;
					vec4 u_xlat2;
					mediump vec4 u_xlat16_2;
					float u_xlat6;
					void main()
					{
					    u_xlat0.x = texture(_BlendTex, vs_TEXCOORD1.xy).w;
					    u_xlat0.y = texture(_BlendTex, vs_TEXCOORD1.zw).y;
					    u_xlat0.zw = texture(_BlendTex, vs_TEXCOORD0.xy).zx;
					    u_xlat1.x = dot(u_xlat0, vec4(1.0, 1.0, 1.0, 1.0));
					#ifdef UNITY_ADRENO_ES3
					    u_xlatb1 = !!(u_xlat1.x<9.99999975e-06);
					#else
					    u_xlatb1 = u_xlat1.x<9.99999975e-06;
					#endif
					    if(u_xlatb1){
					        SV_Target0 = textureLod(_MainTex, vs_TEXCOORD0.xy, 0.0);
					    } else {
					        u_xlat1.xy = max(u_xlat0.zw, u_xlat0.xy);
					#ifdef UNITY_ADRENO_ES3
					        u_xlatb1 = !!(u_xlat1.y<u_xlat1.x);
					#else
					        u_xlatb1 = u_xlat1.y<u_xlat1.x;
					#endif
					        u_xlat2.xz = mix(vec2(0.0, 0.0), u_xlat0.xz, vec2(bvec2(u_xlatb1)));
					        u_xlat2.yw = (bool(u_xlatb1)) ? vec2(0.0, 0.0) : u_xlat0.yw;
					        u_xlat0.x = (u_xlatb1) ? u_xlat0.x : u_xlat0.y;
					        u_xlat0.y = (u_xlatb1) ? u_xlat0.z : u_xlat0.w;
					        u_xlat6 = dot(u_xlat0.xy, vec2(1.0, 1.0));
					        u_xlat0.xy = u_xlat0.xy / vec2(u_xlat6);
					        u_xlat1 = _MainTex_TexelSize.xyxy * vec4(1.0, 1.0, -1.0, -1.0);
					        u_xlat1 = u_xlat2 * u_xlat1 + vs_TEXCOORD0.xyxy;
					        u_xlat16_2 = textureLod(_MainTex, u_xlat1.xy, 0.0);
					        u_xlat16_1 = textureLod(_MainTex, u_xlat1.zw, 0.0);
					        u_xlat1 = u_xlat0.yyyy * u_xlat16_1;
					        SV_Target0 = u_xlat0.xxxx * u_xlat16_2 + u_xlat1;
					    //ENDIF
					    }
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