using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000041")]
	public sealed class IntParameter : ParameterOverride<int>
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xD82444", Offset = "0xD82444", VA = "0xD82444", Slot = "9")]
		public override void Interp(int from, int to, float t)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xD82464", Offset = "0xD82464", VA = "0xD82464")]
		public IntParameter()
		{
		}
	}
}
