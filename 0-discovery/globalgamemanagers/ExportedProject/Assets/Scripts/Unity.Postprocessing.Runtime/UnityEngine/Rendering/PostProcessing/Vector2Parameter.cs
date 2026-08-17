using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000044")]
	public sealed class Vector2Parameter : ParameterOverride<Vector2>
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1238610", Offset = "0x1238610", VA = "0x1238610", Slot = "9")]
		public override void Interp(Vector2 from, Vector2 to, float t)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1238630", Offset = "0x1238630", VA = "0x1238630")]
		public static implicit operator Vector3(Vector2Parameter prop)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x12386B4", Offset = "0x12386B4", VA = "0x12386B4")]
		public static implicit operator Vector4(Vector2Parameter prop)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1238738", Offset = "0x1238738", VA = "0x1238738")]
		public Vector2Parameter()
		{
		}
	}
}
