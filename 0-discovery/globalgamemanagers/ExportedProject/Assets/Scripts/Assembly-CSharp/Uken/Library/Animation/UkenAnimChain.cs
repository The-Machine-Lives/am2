using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Animation
{
	[Token(Token = "0x2000492")]
	public class UkenAnimChain : UkenAnimBase
	{
		[Token(Token = "0x40014DE")]
		[FieldOffset(Offset = "0x48")]
		private List<UkenAnimBase> chain;

		[Token(Token = "0x40014DF")]
		[FieldOffset(Offset = "0x50")]
		private int index;

		[Token(Token = "0x60021A1")]
		[Address(RVA = "0xAEEB98", Offset = "0xAEEB98", VA = "0xAEEB98")]
		public UkenAnimChain(float duration, float startDelay = 0f)
		{
		}

		[Token(Token = "0x60021A2")]
		[Address(RVA = "0xAF3670", Offset = "0xAF3670", VA = "0xAF3670")]
		public void Append(UkenAnimBase anim)
		{
		}

		[Token(Token = "0x60021A3")]
		[Address(RVA = "0xAEEDC0", Offset = "0xAEEDC0", VA = "0xAEEDC0")]
		public void Append(params UkenAnimBase[] anims)
		{
		}

		[Token(Token = "0x60021A4")]
		[Address(RVA = "0xAF3724", Offset = "0xAF3724", VA = "0xAF3724", Slot = "6")]
		public override bool Update(float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60021A5")]
		[Address(RVA = "0xAF39FC", Offset = "0xAF39FC", VA = "0xAF39FC", Slot = "7")]
		protected override void OnFinalize()
		{
		}
	}
}
