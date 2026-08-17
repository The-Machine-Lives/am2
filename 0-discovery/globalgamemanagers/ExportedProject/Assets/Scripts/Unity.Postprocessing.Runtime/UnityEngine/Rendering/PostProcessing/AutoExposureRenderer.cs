using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000012")]
	[Preserve]
	internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure>
	{
		[Token(Token = "0x400002B")]
		private const int k_NumEyes = 2;

		[Token(Token = "0x400002C")]
		private const int k_NumAutoExposureTextures = 2;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x20")]
		private readonly RenderTexture[][] m_AutoExposurePool;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x28")]
		private int[] m_AutoExposurePingPong;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture m_CurrentAutoExposure;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xD749A8", Offset = "0xD749A8", VA = "0xD749A8")]
		public AutoExposureRenderer()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xD74AFC", Offset = "0xD74AFC", VA = "0xD74AFC")]
		private void CheckTexture(int eye, int id)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xD74DE8", Offset = "0xD74DE8", VA = "0xD74DE8", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xD75A14", Offset = "0xD75A14", VA = "0xD75A14", Slot = "7")]
		public override void Release()
		{
		}
	}
}
