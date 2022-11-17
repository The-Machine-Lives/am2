using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "PostProcessAttribute", RVA = "0x818D5C", Offset = "0x818D5C")]
	public sealed class AmbientOcclusion : PostProcessEffectSettings
	{
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81960C", Offset = "0x81960C")]
		public AmbientOcclusionModeParameter mode;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x819644", Offset = "0x819644")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819644", Offset = "0x819644")]
		public FloatParameter intensity;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x819698", Offset = "0x819698")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819698", Offset = "0x819698")]
		public ColorParameter color;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8196E8", Offset = "0x8196E8")]
		public BoolParameter ambientOnly;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x819720", Offset = "0x819720")]
		public FloatParameter noiseFilterTolerance;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x819738", Offset = "0x819738")]
		public FloatParameter blurTolerance;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x819750", Offset = "0x819750")]
		public FloatParameter upsampleTolerance;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x819768", Offset = "0x819768")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819768", Offset = "0x819768")]
		public FloatParameter thicknessModifier;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8197BC", Offset = "0x8197BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8197BC", Offset = "0x8197BC")]
		public FloatParameter directLightingStrength;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819810", Offset = "0x819810")]
		public FloatParameter radius;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819848", Offset = "0x819848")]
		public AmbientOcclusionQualityParameter quality;

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xD732C8", Offset = "0xD732C8", VA = "0xD732C8", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xD73724", Offset = "0xD73724", VA = "0xD73724")]
		public AmbientOcclusion()
		{
		}
	}
}
