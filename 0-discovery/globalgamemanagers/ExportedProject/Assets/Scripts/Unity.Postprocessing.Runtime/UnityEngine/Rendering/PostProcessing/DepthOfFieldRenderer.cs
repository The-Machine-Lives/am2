using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000020")]
	[Preserve]
	internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField>
	{
		[Token(Token = "0x200006C")]
		private enum Pass
		{
			[Token(Token = "0x400025E")]
			CoCCalculation = 0,
			[Token(Token = "0x400025F")]
			CoCTemporalFilter = 1,
			[Token(Token = "0x4000260")]
			DownsampleAndPrefilter = 2,
			[Token(Token = "0x4000261")]
			BokehSmallKernel = 3,
			[Token(Token = "0x4000262")]
			BokehMediumKernel = 4,
			[Token(Token = "0x4000263")]
			BokehLargeKernel = 5,
			[Token(Token = "0x4000264")]
			BokehVeryLargeKernel = 6,
			[Token(Token = "0x4000265")]
			PostFilter = 7,
			[Token(Token = "0x4000266")]
			Combine = 8,
			[Token(Token = "0x4000267")]
			DebugOverlay = 9
		}

		[Token(Token = "0x4000080")]
		private const int k_NumEyes = 2;

		[Token(Token = "0x4000081")]
		private const int k_NumCoCHistoryTextures = 2;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x20")]
		private readonly RenderTexture[][] m_CoCHistoryTextures;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x28")]
		private int[] m_HistoryPingPong;

		[Token(Token = "0x4000084")]
		private const float k_FilmHeight = 0.024f;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xD7E26C", Offset = "0xD7E26C", VA = "0xD7E26C")]
		public DepthOfFieldRenderer()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xD7E3C0", Offset = "0xD7E3C0", VA = "0xD7E3C0", Slot = "5")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xD7E3C8", Offset = "0xD7E3C8", VA = "0xD7E3C8")]
		private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
		{
			return default(RenderTextureFormat);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xD7E47C", Offset = "0xD7E47C", VA = "0xD7E47C")]
		private float CalculateMaxCoCRadius(int screenHeight)
		{
			return default(float);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xD7E54C", Offset = "0xD7E54C", VA = "0xD7E54C")]
		private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xD7E9C4", Offset = "0xD7E9C4", VA = "0xD7E9C4", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xD7F948", Offset = "0xD7F948", VA = "0xD7F948", Slot = "7")]
		public override void Release()
		{
		}
	}
}
