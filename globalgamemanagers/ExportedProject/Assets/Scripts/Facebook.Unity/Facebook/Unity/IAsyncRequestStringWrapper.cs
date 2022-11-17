using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity
{
	[Token(Token = "0x200005A")]
	internal interface IAsyncRequestStringWrapper
	{
		[Token(Token = "0x60001AB")]
		void Request(Uri url, HttpMethod method, [Optional] WWWForm query, [Optional] FacebookDelegate<IGraphResult> callback);

		[Token(Token = "0x60001AC")]
		void Request(Uri url, HttpMethod method, [Optional] IDictionary<string, string> formData, [Optional] FacebookDelegate<IGraphResult> callback);
	}
}
