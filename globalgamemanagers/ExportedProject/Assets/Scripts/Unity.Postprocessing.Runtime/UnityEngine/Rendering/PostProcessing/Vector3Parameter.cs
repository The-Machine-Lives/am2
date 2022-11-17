using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000045")]
	public sealed class Vector3Parameter : ParameterOverride<Vector3>
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1238788", Offset = "0x1238788", VA = "0x1238788", Slot = "9")]
		public override void Interp(Vector3 from, Vector3 to, float t)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x12387B8", Offset = "0x12387B8", VA = "0x12387B8")]
		public static implicit operator Vector2(Vector3Parameter prop)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x123884C", Offset = "0x123884C", VA = "0x123884C")]
		public static implicit operator Vector4(Vector3Parameter prop)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x12388E0", Offset = "0x12388E0", VA = "0x12388E0")]
		public Vector3Parameter()
		{
		}
	}
}
