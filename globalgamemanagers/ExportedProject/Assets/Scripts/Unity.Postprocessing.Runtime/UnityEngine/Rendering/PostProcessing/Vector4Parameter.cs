using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000046")]
	public sealed class Vector4Parameter : ParameterOverride<Vector4>
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1238930", Offset = "0x1238930", VA = "0x1238930", Slot = "9")]
		public override void Interp(Vector4 from, Vector4 to, float t)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1238970", Offset = "0x1238970", VA = "0x1238970")]
		public static implicit operator Vector2(Vector4Parameter prop)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1238A08", Offset = "0x1238A08", VA = "0x1238A08")]
		public static implicit operator Vector3(Vector4Parameter prop)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1238AA0", Offset = "0x1238AA0", VA = "0x1238AA0")]
		public Vector4Parameter()
		{
		}
	}
}
