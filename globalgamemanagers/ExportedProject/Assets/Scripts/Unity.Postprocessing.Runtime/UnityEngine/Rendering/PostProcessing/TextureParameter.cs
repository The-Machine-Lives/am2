using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000049")]
	public sealed class TextureParameter : ParameterOverride<Texture>
	{
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x20")]
		public TextureParameterDefault defaultState;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1238064", Offset = "0x1238064", VA = "0x1238064", Slot = "9")]
		public override void Interp(Texture from, Texture to, float t)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x123853C", Offset = "0x123853C", VA = "0x123853C")]
		public TextureParameter()
		{
		}
	}
}
