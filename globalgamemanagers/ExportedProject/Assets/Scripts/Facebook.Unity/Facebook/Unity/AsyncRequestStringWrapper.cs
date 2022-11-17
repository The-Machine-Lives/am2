using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity
{
	[Token(Token = "0x2000059")]
	internal class AsyncRequestStringWrapper : IAsyncRequestStringWrapper
	{
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xCC995C", Offset = "0xCC995C", VA = "0xCC995C", Slot = "4")]
		public void Request(Uri url, HttpMethod method, [Optional] WWWForm query, [Optional] FacebookDelegate<IGraphResult> callback)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xCC9970", Offset = "0xCC9970", VA = "0xCC9970", Slot = "5")]
		public void Request(Uri url, HttpMethod method, [Optional] IDictionary<string, string> formData, [Optional] FacebookDelegate<IGraphResult> callback)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xCC9984", Offset = "0xCC9984", VA = "0xCC9984")]
		public AsyncRequestStringWrapper()
		{
		}
	}
}
