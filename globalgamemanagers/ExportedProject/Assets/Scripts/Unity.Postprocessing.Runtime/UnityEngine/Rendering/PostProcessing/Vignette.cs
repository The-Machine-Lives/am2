using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "PostProcessAttribute", RVA = "0x819344", Offset = "0x819344")]
	public sealed class Vignette : PostProcessEffectSettings
	{
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B8BC", Offset = "0x81B8BC")]
		public VignetteModeParameter mode;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B8F4", Offset = "0x81B8F4")]
		public ColorParameter color;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B92C", Offset = "0x81B92C")]
		public Vector2Parameter center;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B964", Offset = "0x81B964")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B964", Offset = "0x81B964")]
		public FloatParameter intensity;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B9B8", Offset = "0x81B9B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B9B8", Offset = "0x81B9B8")]
		public FloatParameter smoothness;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81BA10", Offset = "0x81BA10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81BA10", Offset = "0x81BA10")]
		public FloatParameter roundness;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81BA64", Offset = "0x81BA64")]
		public BoolParameter rounded;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81BA9C", Offset = "0x81BA9C")]
		public TextureParameter mask;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81BAD4", Offset = "0x81BAD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81BAD4", Offset = "0x81BAD4")]
		public FloatParameter opacity;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x12391A0", Offset = "0x12391A0", VA = "0x12391A0", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x12392BC", Offset = "0x12392BC", VA = "0x12392BC")]
		public Vignette()
		{
		}
	}
}
