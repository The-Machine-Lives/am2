using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000043")]
	public sealed class ColorParameter : ParameterOverride<Color>
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xD7DD3C", Offset = "0xD7DD3C", VA = "0xD7DD3C", Slot = "9")]
		public override void Interp(Color from, Color to, float t)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xD7DD7C", Offset = "0xD7DD7C", VA = "0xD7DD7C")]
		public static implicit operator Vector4(ColorParameter prop)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xD73A10", Offset = "0xD73A10", VA = "0xD73A10")]
		public ColorParameter()
		{
		}
	}
}
