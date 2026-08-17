using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "PostProcessAttribute", RVA = "0x819160", Offset = "0x819160")]
	public sealed class LensDistortion : PostProcessEffectSettings
	{
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B1EC", Offset = "0x81B1EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B1EC", Offset = "0x81B1EC")]
		public FloatParameter intensity;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B248", Offset = "0x81B248")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81B248", Offset = "0x81B248")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B248", Offset = "0x81B248")]
		public FloatParameter intensityX;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B2C0", Offset = "0x81B2C0")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81B2C0", Offset = "0x81B2C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B2C0", Offset = "0x81B2C0")]
		public FloatParameter intensityY;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x81B338", Offset = "0x81B338")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B338", Offset = "0x81B338")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B338", Offset = "0x81B338")]
		public FloatParameter centerX;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B39C", Offset = "0x81B39C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B39C", Offset = "0x81B39C")]
		public FloatParameter centerY;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x81B3F0", Offset = "0x81B3F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B3F0", Offset = "0x81B3F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B3F0", Offset = "0x81B3F0")]
		public FloatParameter scale;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xD824B4", Offset = "0xD824B4", VA = "0xD824B4", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xD825C0", Offset = "0xD825C0", VA = "0xD825C0")]
		public LensDistortion()
		{
		}
	}
}
