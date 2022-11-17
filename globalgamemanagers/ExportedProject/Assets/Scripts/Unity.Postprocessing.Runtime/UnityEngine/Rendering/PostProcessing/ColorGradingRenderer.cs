using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x200001C")]
	[Preserve]
	internal sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading>
	{
		[Token(Token = "0x200006B")]
		private enum Pass
		{
			[Token(Token = "0x400025A")]
			LutGenLDRFromScratch = 0,
			[Token(Token = "0x400025B")]
			LutGenLDR = 1,
			[Token(Token = "0x400025C")]
			LutGenHDR2D = 2
		}

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x20")]
		private Texture2D m_GradingCurves;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x28")]
		private readonly Color[] m_Pixels;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture m_InternalLdrLut;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x38")]
		private RenderTexture m_InternalLogLut;

		[Token(Token = "0x4000074")]
		private const int k_Lut2DSize = 32;

		[Token(Token = "0x4000075")]
		private const int k_Lut3DSize = 33;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x40")]
		private readonly HableCurve m_HableCurve;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xD787FC", Offset = "0xD787FC", VA = "0xD787FC", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xD78994", Offset = "0xD78994", VA = "0xD78994")]
		private void RenderExternalPipeline3D(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xD78CC4", Offset = "0xD78CC4", VA = "0xD78CC4")]
		private void RenderHDRPipeline3D(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xD79E38", Offset = "0xD79E38", VA = "0xD79E38")]
		private void RenderHDRPipeline2D(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xD7B264", Offset = "0xD7B264", VA = "0xD7B264")]
		private void RenderLDRPipeline2D(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xD7C348", Offset = "0xD7C348", VA = "0xD7C348")]
		private void CheckInternalLogLut()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xD7D7BC", Offset = "0xD7D7BC", VA = "0xD7D7BC")]
		private void CheckInternalStripLut()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xD7CA04", Offset = "0xD7CA04", VA = "0xD7CA04")]
		private Texture2D GetCurveTexture(bool hdr)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xD7DA94", Offset = "0xD7DA94", VA = "0xD7DA94")]
		private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format)
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xD7DA20", Offset = "0xD7DA20", VA = "0xD7DA20")]
		private static RenderTextureFormat GetLutFormat()
		{
			return default(RenderTextureFormat);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xD7DA60", Offset = "0xD7DA60", VA = "0xD7DA60")]
		private static TextureFormat GetCurveFormat()
		{
			return default(TextureFormat);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xD7DAFC", Offset = "0xD7DAFC", VA = "0xD7DAFC", Slot = "7")]
		public override void Release()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xD7DB90", Offset = "0xD7DB90", VA = "0xD7DB90")]
		public ColorGradingRenderer()
		{
		}
	}
}
