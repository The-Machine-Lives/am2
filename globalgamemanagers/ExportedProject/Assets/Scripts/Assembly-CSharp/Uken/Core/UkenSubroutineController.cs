using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003D1")]
	public class UkenSubroutineController : UkenController
	{
		[Token(Token = "0x40011FA")]
		[FieldOffset(Offset = "0x0")]
		private static UkenSubroutineController _self;

		[Token(Token = "0x40011FB")]
		[FieldOffset(Offset = "0x18")]
		private List<UkenSubroutine> activeSubroutines;

		[Token(Token = "0x6001D8A")]
		[Address(RVA = "0xA1C940", Offset = "0xA1C940", VA = "0xA1C940")]
		private static UkenSubroutineController Get()
		{
			return null;
		}

		[Token(Token = "0x6001D8B")]
		[Address(RVA = "0xA1C990", Offset = "0xA1C990", VA = "0xA1C990")]
		public static bool IsAvailable()
		{
			return default(bool);
		}

		[Token(Token = "0x6001D8C")]
		[Address(RVA = "0xA1A4FC", Offset = "0xA1A4FC", VA = "0xA1A4FC")]
		public UkenSubroutineController()
		{
		}

		[Token(Token = "0x6001D8D")]
		[Address(RVA = "0xA1C9E8", Offset = "0xA1C9E8", VA = "0xA1C9E8")]
		public void Start(IEnumerator subroutine)
		{
		}

		[Token(Token = "0x6001D8E")]
		[Address(RVA = "0xA1CA78", Offset = "0xA1CA78", VA = "0xA1CA78")]
		public static void StartCoroutine(IEnumerator subroutine)
		{
		}

		[Token(Token = "0x6001D8F")]
		[Address(RVA = "0xA1CB34", Offset = "0xA1CB34", VA = "0xA1CB34", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6001D90")]
		[Address(RVA = "0xA1CD00", Offset = "0xA1CD00", VA = "0xA1CD00", Slot = "8")]
		public override void Cleanup()
		{
		}
	}
}
