using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000022")]
	[Preserve]
	public sealed class FastApproximateAntialiasing
	{
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x81AF88", Offset = "0x81AF88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81AF88", Offset = "0x81AF88")]
		public bool fastMode;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81AFE8", Offset = "0x81AFE8")]
		public bool keepAlpha;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xD7FE10", Offset = "0xD7FE10", VA = "0xD7FE10")]
		public FastApproximateAntialiasing()
		{
		}
	}
}
