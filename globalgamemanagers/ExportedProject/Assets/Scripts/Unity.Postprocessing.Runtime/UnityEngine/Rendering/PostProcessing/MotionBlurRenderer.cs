using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000029")]
	[Preserve]
	internal sealed class MotionBlurRenderer : PostProcessEffectRenderer<MotionBlur>
	{
		[Token(Token = "0x200006D")]
		private enum Pass
		{
			[Token(Token = "0x4000269")]
			VelocitySetup = 0,
			[Token(Token = "0x400026A")]
			TileMax1 = 1,
			[Token(Token = "0x400026B")]
			TileMax2 = 2,
			[Token(Token = "0x400026C")]
			TileMaxV = 3,
			[Token(Token = "0x400026D")]
			NeighborMax = 4,
			[Token(Token = "0x400026E")]
			Reconstruction = 5
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xD83F34", Offset = "0xD83F34", VA = "0xD83F34", Slot = "5")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xD83F3C", Offset = "0xD83F3C", VA = "0xD83F3C")]
		private void CreateTemporaryRT(PostProcessRenderContext context, int nameID, int width, int height, RenderTextureFormat RTFormat)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xD84114", Offset = "0xD84114", VA = "0xD84114", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xD84E64", Offset = "0xD84E64", VA = "0xD84E64")]
		public MotionBlurRenderer()
		{
		}
	}
}
