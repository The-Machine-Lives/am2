using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "PostProcessAttribute", RVA = "0x819018", Offset = "0x819018")]
	public sealed class DepthOfField : PostProcessEffectSettings
	{
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x81AE20", Offset = "0x81AE20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81AE20", Offset = "0x81AE20")]
		public FloatParameter focusDistance;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81AE74", Offset = "0x81AE74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81AE74", Offset = "0x81AE74")]
		public FloatParameter aperture;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81AED0", Offset = "0x81AED0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81AED0", Offset = "0x81AED0")]
		public FloatParameter focalLength;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x81AF28", Offset = "0x81AF28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81AF28", Offset = "0x81AF28")]
		public KernelSizeParameter kernelSize;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xD7E0D4", Offset = "0xD7E0D4", VA = "0xD7E0D4", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xD7E11C", Offset = "0xD7E11C", VA = "0xD7E11C")]
		public DepthOfField()
		{
		}
	}
}
