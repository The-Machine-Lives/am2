using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "PostProcessAttribute", RVA = "0x818E74", Offset = "0x818E74")]
	public sealed class Bloom : PostProcessEffectSettings
	{
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x819B60", Offset = "0x819B60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819B60", Offset = "0x819B60")]
		public FloatParameter intensity;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x819BB0", Offset = "0x819BB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819BB0", Offset = "0x819BB0")]
		public FloatParameter threshold;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x819C00", Offset = "0x819C00")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819C00", Offset = "0x819C00")]
		public FloatParameter softKnee;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819C54", Offset = "0x819C54")]
		public FloatParameter clamp;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x819C8C", Offset = "0x819C8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819C8C", Offset = "0x819C8C")]
		public FloatParameter diffusion;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x819CE0", Offset = "0x819CE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819CE0", Offset = "0x819CE0")]
		public FloatParameter anamorphicRatio;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x819D34", Offset = "0x819D34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819D34", Offset = "0x819D34")]
		public ColorParameter color;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x819D88", Offset = "0x819D88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819D88", Offset = "0x819D88")]
		public BoolParameter fastMode;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819DE8", Offset = "0x819DE8")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x819DE8", Offset = "0x819DE8")]
		public TextureParameter dirtTexture;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x819E48", Offset = "0x819E48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819E48", Offset = "0x819E48")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x819E48", Offset = "0x819E48")]
		public FloatParameter dirtIntensity;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xD75B24", Offset = "0xD75B24", VA = "0xD75B24", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xD75B7C", Offset = "0xD75B7C", VA = "0xD75B7C")]
		public Bloom()
		{
		}
	}
}
