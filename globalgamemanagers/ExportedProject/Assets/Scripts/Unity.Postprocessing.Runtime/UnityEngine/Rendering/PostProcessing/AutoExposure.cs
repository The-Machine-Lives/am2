using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "PostProcessAttribute", RVA = "0x818DE8", Offset = "0x818DE8")]
	public sealed class AutoExposure : PostProcessEffectSettings
	{
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x819880", Offset = "0x819880")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x819880", Offset = "0x819880")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819880", Offset = "0x819880")]
		public Vector2Parameter filtering;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8198FC", Offset = "0x8198FC")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x8198FC", Offset = "0x8198FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8198FC", Offset = "0x8198FC")]
		public FloatParameter minLuminance;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x819974", Offset = "0x819974")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x819974", Offset = "0x819974")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819974", Offset = "0x819974")]
		public FloatParameter maxLuminance;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x8199EC", Offset = "0x8199EC")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x8199EC", Offset = "0x8199EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8199EC", Offset = "0x8199EC")]
		public FloatParameter keyValue;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x819A60", Offset = "0x819A60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819A60", Offset = "0x819A60")]
		public EyeAdaptationParameter eyeAdaptation;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x819AC0", Offset = "0x819AC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819AC0", Offset = "0x819AC0")]
		public FloatParameter speedUp;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x819B10", Offset = "0x819B10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819B10", Offset = "0x819B10")]
		public FloatParameter speedDown;

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xD74620", Offset = "0xD74620", VA = "0xD74620", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xD747C0", Offset = "0xD747C0", VA = "0xD747C0")]
		public AutoExposure()
		{
		}
	}
}
