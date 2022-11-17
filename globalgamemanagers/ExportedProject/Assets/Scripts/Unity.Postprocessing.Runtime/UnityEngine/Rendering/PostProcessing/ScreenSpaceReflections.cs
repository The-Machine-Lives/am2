using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "PostProcessAttribute", RVA = "0x819298", Offset = "0x819298")]
	public sealed class ScreenSpaceReflections : PostProcessEffectSettings
	{
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B508", Offset = "0x81B508")]
		public ScreenSpaceReflectionPresetParameter preset;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B540", Offset = "0x81B540")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B540", Offset = "0x81B540")]
		public IntParameter maximumIterationCount;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B598", Offset = "0x81B598")]
		public ScreenSpaceReflectionResolutionParameter resolution;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B5D0", Offset = "0x81B5D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B5D0", Offset = "0x81B5D0")]
		public FloatParameter thickness;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B628", Offset = "0x81B628")]
		public FloatParameter maximumMarchDistance;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B660", Offset = "0x81B660")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B660", Offset = "0x81B660")]
		public FloatParameter distanceFade;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81B6B4", Offset = "0x81B6B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B6B4", Offset = "0x81B6B4")]
		public FloatParameter vignette;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x122FE94", Offset = "0x122FE94", VA = "0x122FE94", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x123003C", Offset = "0x123003C", VA = "0x123003C")]
		public ScreenSpaceReflections()
		{
		}
	}
}
