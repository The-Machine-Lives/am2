using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "PostProcessAttribute", RVA = "0x8191EC", Offset = "0x8191EC")]
	public sealed class MotionBlur : PostProcessEffectSettings
	{
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B458", Offset = "0x81B458")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B458", Offset = "0x81B458")]
		public FloatParameter shutterAngle;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B4B0", Offset = "0x81B4B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B4B0", Offset = "0x81B4B0")]
		public IntParameter sampleCount;

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xD83DA8", Offset = "0xD83DA8", VA = "0xD83DA8", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xD83E90", Offset = "0xD83E90", VA = "0xD83E90")]
		public MotionBlur()
		{
		}
	}
}
