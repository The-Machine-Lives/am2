using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x200000E")]
	[Preserve]
	internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion>
	{
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x20")]
		private IAmbientOcclusionMethod[] m_Methods;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xD73B9C", Offset = "0xD73B9C", VA = "0xD73B9C", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xD740C4", Offset = "0xD740C4", VA = "0xD740C4")]
		public bool IsAmbientOnly(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xD741AC", Offset = "0xD741AC", VA = "0xD741AC")]
		public IAmbientOcclusionMethod Get()
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xD74254", Offset = "0xD74254", VA = "0xD74254", Slot = "5")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xD7430C", Offset = "0xD7430C", VA = "0xD7430C", Slot = "7")]
		public override void Release()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xD74418", Offset = "0xD74418", VA = "0xD74418")]
		public ScalableAO GetScalableAO()
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xD744F0", Offset = "0xD744F0", VA = "0xD744F0")]
		public MultiScaleVO GetMultiScaleVO()
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xD745CC", Offset = "0xD745CC", VA = "0xD745CC", Slot = "8")]
		public override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xD745D0", Offset = "0xD745D0", VA = "0xD745D0")]
		public AmbientOcclusionRenderer()
		{
		}
	}
}
