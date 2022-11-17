using Il2CppDummyDll;
using UnityEngine;

namespace Com.Uken.ApiClient
{
	[Token(Token = "0x2000009")]
	public class CoroutineStarter : MonoBehaviour
	{
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x0")]
		private static CoroutineStarter instance;

		[Token(Token = "0x17000004")]
		public static CoroutineStarter Instance
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x17FC268", Offset = "0x17FC268", VA = "0x17FC268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x17FC384", Offset = "0x17FC384", VA = "0x17FC384")]
		public CoroutineStarter()
		{
		}
	}
}
