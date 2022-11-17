using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000033")]
	[Preserve]
	public sealed class TemporalAntialiasing
	{
		[Token(Token = "0x2000075")]
		private enum Pass
		{
			[Token(Token = "0x4000296")]
			SolverDilate = 0,
			[Token(Token = "0x4000297")]
			SolverNoDilate = 1
		}

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B740", Offset = "0x81B740")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B740", Offset = "0x81B740")]
		public float jitterSpread;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B798", Offset = "0x81B798")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B798", Offset = "0x81B798")]
		public float sharpness;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B7EC", Offset = "0x81B7EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B7EC", Offset = "0x81B7EC")]
		public float stationaryBlending;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B844", Offset = "0x81B844")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B844", Offset = "0x81B844")]
		public float motionBlending;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x20")]
		public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81B89C", Offset = "0x81B89C")]
		private Vector2 _003Cjitter_003Ek__BackingField;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x30")]
		private readonly RenderTargetIdentifier[] m_Mrt;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x38")]
		private bool m_ResetHistory;

		[Token(Token = "0x40000CA")]
		private const int k_SampleCount = 8;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81B8AC", Offset = "0x81B8AC")]
		private int _003CsampleIndex_003Ek__BackingField;

		[Token(Token = "0x40000CC")]
		private const int k_NumEyes = 2;

		[Token(Token = "0x40000CD")]
		private const int k_NumHistoryTextures = 2;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x40")]
		private readonly RenderTexture[][] m_HistoryTextures;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x48")]
		private readonly int[] m_HistoryPingPong;

		[Token(Token = "0x17000001")]
		public Vector2 jitter
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x1234118", Offset = "0x1234118", VA = "0x1234118")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BFF0", Offset = "0x81BFF0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x1234120", Offset = "0x1234120", VA = "0x1234120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C000", Offset = "0x81C000")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public int sampleIndex
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x1234128", Offset = "0x1234128", VA = "0x1234128")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C010", Offset = "0x81C010")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x1234130", Offset = "0x1234130", VA = "0x1234130")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C020", Offset = "0x81C020")]
			private set
			{
			}
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1228C00", Offset = "0x1228C00", VA = "0x1228C00")]
		public bool IsSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1234138", Offset = "0x1234138", VA = "0x1234138")]
		internal DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1234140", Offset = "0x1234140", VA = "0x1234140")]
		internal void ResetHistory()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x123414C", Offset = "0x123414C", VA = "0x123414C")]
		private Vector2 GenerateRandomOffset()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x12341E8", Offset = "0x12341E8", VA = "0x12341E8")]
		public Matrix4x4 GetJitteredProjectionMatrix(Camera camera)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1234414", Offset = "0x1234414", VA = "0x1234414")]
		public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x123452C", Offset = "0x123452C", VA = "0x123452C")]
		public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1234740", Offset = "0x1234740", VA = "0x1234740")]
		private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x123486C", Offset = "0x123486C", VA = "0x123486C")]
		private RenderTexture CheckHistory(int id, PostProcessRenderContext context)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1234E50", Offset = "0x1234E50", VA = "0x1234E50")]
		internal void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x123534C", Offset = "0x123534C", VA = "0x123534C")]
		internal void Release()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1235598", Offset = "0x1235598", VA = "0x1235598")]
		public TemporalAntialiasing()
		{
		}
	}
}
