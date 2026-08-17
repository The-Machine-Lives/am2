using System;
using Il2CppDummyDll;

namespace Uken.Library.Animation
{
	[Token(Token = "0x2000495")]
	public class UkenAnimFloat : UkenAnimBase
	{
		[Token(Token = "0x40014F8")]
		[FieldOffset(Offset = "0x48")]
		public Action<float> m_OnUpdate;

		[Token(Token = "0x40014F9")]
		[FieldOffset(Offset = "0x50")]
		private float m_result;

		[Token(Token = "0x40014FA")]
		[FieldOffset(Offset = "0x54")]
		private float m_startFloat;

		[Token(Token = "0x40014FB")]
		[FieldOffset(Offset = "0x58")]
		private float m_change;

		[Token(Token = "0x60021BF")]
		[Address(RVA = "0xAF0CB4", Offset = "0xAF0CB4", VA = "0xAF0CB4")]
		public UkenAnimFloat(float duration, float startDelay = 0f)
		{
		}

		[Token(Token = "0x60021C0")]
		[Address(RVA = "0xAF0CB8", Offset = "0xAF0CB8", VA = "0xAF0CB8")]
		public void SetFloats(float startFloat, float endFloat, Action<float> OnUpdate)
		{
		}

		[Token(Token = "0x60021C1")]
		[Address(RVA = "0xAF4A84", Offset = "0xAF4A84", VA = "0xAF4A84", Slot = "6")]
		public override bool Update(float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60021C2")]
		[Address(RVA = "0xAF4ABC", Offset = "0xAF4ABC", VA = "0xAF4ABC")]
		private void OnUpdate()
		{
		}
	}
}
