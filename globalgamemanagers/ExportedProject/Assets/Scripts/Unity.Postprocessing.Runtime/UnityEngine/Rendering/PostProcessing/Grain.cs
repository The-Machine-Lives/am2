using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "PostProcessAttribute", RVA = "0x8190D4", Offset = "0x8190D4")]
	public sealed class Grain : PostProcessEffectSettings
	{
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B090", Offset = "0x81B090")]
		public BoolParameter colored;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B0C8", Offset = "0x81B0C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B0C8", Offset = "0x81B0C8")]
		public FloatParameter intensity;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B11C", Offset = "0x81B11C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B11C", Offset = "0x81B11C")]
		public FloatParameter size;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B174", Offset = "0x81B174")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81B174", Offset = "0x81B174")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B174", Offset = "0x81B174")]
		public FloatParameter lumContrib;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xD8046C", Offset = "0xD8046C", VA = "0xD8046C", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xD804C4", Offset = "0xD804C4", VA = "0xD804C4")]
		public Grain()
		{
		}
	}
}
