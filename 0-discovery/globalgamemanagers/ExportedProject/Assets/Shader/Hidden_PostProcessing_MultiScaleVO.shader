Shader "Hidden/PostProcessing/MultiScaleVO" {
	Properties {
	}
	SubShader {
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 38580
		}
		0 {
			Blend Zero OneMinusSrcColor, Zero OneMinusSrcAlpha
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 92442
		}
		0 {
			Blend Zero OneMinusSrcColor, Zero OneMinusSrcAlpha
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 147485
		}
		0 {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 200548
		}
	}
}