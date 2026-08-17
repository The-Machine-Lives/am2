using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Core.IO
{
	[Token(Token = "0x20003DC")]
	public class WebPlayerCommunication : MonoBehaviour
	{
		[Token(Token = "0x4001212")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<string, Action<string>> pending;

		[Token(Token = "0x6001DCB")]
		[Address(RVA = "0xA1830C", Offset = "0xA1830C", VA = "0xA1830C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6001DCC")]
		[Address(RVA = "0xA18388", Offset = "0xA18388", VA = "0xA18388")]
		public void WaitForJSON(string key, Action<string> callback)
		{
		}

		[Token(Token = "0x6001DCD")]
		[Address(RVA = "0xA18424", Offset = "0xA18424", VA = "0xA18424")]
		public void ReceiveJSON(string param)
		{
		}

		[Token(Token = "0x6001DCE")]
		[Address(RVA = "0xA18660", Offset = "0xA18660", VA = "0xA18660")]
		public WebPlayerCommunication()
		{
		}
	}
}
