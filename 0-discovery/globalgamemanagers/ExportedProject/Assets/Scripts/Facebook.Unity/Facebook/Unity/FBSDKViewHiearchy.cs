using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity
{
	[Token(Token = "0x2000063")]
	public class FBSDKViewHiearchy
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xCD2304", Offset = "0xCD2304", VA = "0xCD2304")]
		public static bool CheckGameObjectMatchPath(GameObject go, List<FBSDKCodelessPathComponent> path)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xCDC4A0", Offset = "0xCDC4A0", VA = "0xCDC4A0")]
		public static bool CheckPathMatchPath(List<FBSDKCodelessPathComponent> goPath, List<FBSDKCodelessPathComponent> path)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xCDC498", Offset = "0xCDC498", VA = "0xCDC498")]
		public static List<FBSDKCodelessPathComponent> GetPath(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xCDC64C", Offset = "0xCDC64C", VA = "0xCDC64C")]
		public static List<FBSDKCodelessPathComponent> GetPath(GameObject go, int limit)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xCDC860", Offset = "0xCDC860", VA = "0xCDC860")]
		public static GameObject GetParent(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xCDC930", Offset = "0xCDC930", VA = "0xCDC930")]
		public static Dictionary<string, object> GetAttribute(GameObject obj, GameObject parent)
		{
			return null;
		}
	}
}
