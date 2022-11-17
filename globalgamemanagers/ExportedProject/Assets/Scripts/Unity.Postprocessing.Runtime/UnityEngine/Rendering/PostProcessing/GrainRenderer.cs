using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000025")]
	[Preserve]
	internal sealed class GrainRenderer : PostProcessEffectRenderer<Grain>
	{
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture m_GrainLookupRT;

		[Token(Token = "0x4000090")]
		private const int k_SampleCount = 1024;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x28")]
		private int m_SampleIndex;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xD805C0", Offset = "0xD805C0", VA = "0xD805C0", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xD80FD4", Offset = "0xD80FD4", VA = "0xD80FD4")]
		private RenderTextureFormat GetLookupFormat()
		{
			return default(RenderTextureFormat);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xD81048", Offset = "0xD81048", VA = "0xD81048", Slot = "7")]
		public override void Release()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xD810C0", Offset = "0xD810C0", VA = "0xD810C0")]
		public GrainRenderer()
		{
		}
	}
}
