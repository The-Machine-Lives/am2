using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000016")]
	[Preserve]
	internal sealed class ChromaticAberrationRenderer : PostProcessEffectRenderer<ChromaticAberration>
	{
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x20")]
		private Texture2D m_InternalSpectralLut;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xD77424", Offset = "0xD77424", VA = "0xD77424", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xD778EC", Offset = "0xD778EC", VA = "0xD778EC", Slot = "7")]
		public override void Release()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xD77960", Offset = "0xD77960", VA = "0xD77960")]
		public ChromaticAberrationRenderer()
		{
		}
	}
}
