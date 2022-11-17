using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000014")]
	[Preserve]
	internal sealed class BloomRenderer : PostProcessEffectRenderer<Bloom>
	{
		[Token(Token = "0x2000069")]
		private enum Pass
		{
			[Token(Token = "0x400024E")]
			Prefilter13 = 0,
			[Token(Token = "0x400024F")]
			Prefilter4 = 1,
			[Token(Token = "0x4000250")]
			Downsample13 = 2,
			[Token(Token = "0x4000251")]
			Downsample4 = 3,
			[Token(Token = "0x4000252")]
			UpsampleTent = 4,
			[Token(Token = "0x4000253")]
			UpsampleBox = 5,
			[Token(Token = "0x4000254")]
			DebugOverlayThreshold = 6,
			[Token(Token = "0x4000255")]
			DebugOverlayTent = 7,
			[Token(Token = "0x4000256")]
			DebugOverlayBox = 8
		}

		[Token(Token = "0x200006A")]
		private struct Level
		{
			[Token(Token = "0x4000257")]
			[FieldOffset(Offset = "0x0")]
			internal int down;

			[Token(Token = "0x4000258")]
			[FieldOffset(Offset = "0x4")]
			internal int up;
		}

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x20")]
		private Level[] m_Pyramid;

		[Token(Token = "0x400003B")]
		private const int k_MaxPyramidSize = 16;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xD75D94", Offset = "0xD75D94", VA = "0xD75D94", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xD75ED8", Offset = "0xD75ED8", VA = "0xD75ED8", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xD772B0", Offset = "0xD772B0", VA = "0xD772B0")]
		public BloomRenderer()
		{
		}
	}
}
