using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "PostProcessAttribute", RVA = "0x818F00", Offset = "0x818F00")]
	public sealed class ChromaticAberration : PostProcessEffectSettings
	{
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819EBC", Offset = "0x819EBC")]
		public TextureParameter spectralLut;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x819EF4", Offset = "0x819EF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819EF4", Offset = "0x819EF4")]
		public FloatParameter intensity;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x819F48", Offset = "0x819F48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x819F48", Offset = "0x819F48")]
		public BoolParameter fastMode;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xD77300", Offset = "0xD77300", VA = "0xD77300", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xD77358", Offset = "0xD77358", VA = "0xD77358")]
		public ChromaticAberration()
		{
		}
	}
}
