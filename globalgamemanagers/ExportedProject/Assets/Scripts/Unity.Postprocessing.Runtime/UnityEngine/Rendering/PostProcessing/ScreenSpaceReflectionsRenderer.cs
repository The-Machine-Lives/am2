using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000031")]
	[Preserve]
	internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections>
	{
		[Token(Token = "0x2000071")]
		private class QualityPreset
		{
			[Token(Token = "0x4000285")]
			[FieldOffset(Offset = "0x10")]
			public int maximumIterationCount;

			[Token(Token = "0x4000286")]
			[FieldOffset(Offset = "0x14")]
			public float thickness;

			[Token(Token = "0x4000287")]
			[FieldOffset(Offset = "0x18")]
			public ScreenSpaceReflectionResolution downsampling;

			[Token(Token = "0x600021F")]
			[Address(RVA = "0x1232198", Offset = "0x1232198", VA = "0x1232198")]
			public QualityPreset()
			{
			}
		}

		[Token(Token = "0x2000072")]
		private enum Pass
		{
			[Token(Token = "0x4000289")]
			Test = 0,
			[Token(Token = "0x400028A")]
			Resolve = 1,
			[Token(Token = "0x400028B")]
			Reproject = 2,
			[Token(Token = "0x400028C")]
			Composite = 3
		}

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture m_Resolve;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture m_History;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x30")]
		private int[] m_MipIDs;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x38")]
		private readonly QualityPreset[] m_Presets;

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x12301D0", Offset = "0x12301D0", VA = "0x12301D0", Slot = "5")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x12301D8", Offset = "0x12301D8", VA = "0x12301D8")]
		internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1230490", Offset = "0x1230490", VA = "0x1230490", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1231C08", Offset = "0x1231C08", VA = "0x1231C08", Slot = "7")]
		public override void Release()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1231C8C", Offset = "0x1231C8C", VA = "0x1231C8C")]
		public ScreenSpaceReflectionsRenderer()
		{
		}
	}
}
