using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000039")]
	public sealed class LightMeterMonitor : Monitor
	{
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x1C")]
		public int width;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x20")]
		public int height;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x24")]
		public bool showCurves;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xD82B44", Offset = "0xD82B44", VA = "0xD82B44", Slot = "4")]
		internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xD82C48", Offset = "0xD82C48", VA = "0xD82C48", Slot = "8")]
		internal override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xD83264", Offset = "0xD83264", VA = "0xD83264")]
		public LightMeterMonitor()
		{
		}
	}
}
