using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000023")]
	[Preserve]
	public sealed class Fog
	{
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B020", Offset = "0x81B020")]
		public bool enabled;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B058", Offset = "0x81B058")]
		public bool excludeSkybox;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xD7FE2C", Offset = "0xD7FE2C", VA = "0xD7FE2C")]
		internal DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xD7FE34", Offset = "0xD7FE34", VA = "0xD7FE34")]
		internal bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xD7FFBC", Offset = "0xD7FFBC", VA = "0xD7FFBC")]
		internal void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xD8045C", Offset = "0xD8045C", VA = "0xD8045C")]
		public Fog()
		{
		}
	}
}
