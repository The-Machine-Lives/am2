using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity
{
	[Token(Token = "0x2000008")]
	internal class ComponentFactory
	{
		[Token(Token = "0x2000009")]
		internal enum IfNotExist
		{
			[Token(Token = "0x400001C")]
			AddNew = 0,
			[Token(Token = "0x400001D")]
			ReturnNull = 1
		}

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x0")]
		private static GameObject facebookGameObject;

		[Token(Token = "0x1700000C")]
		private static GameObject FacebookGameObject
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0xCD2664", Offset = "0xCD2664", VA = "0xCD2664")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000030")]
		public static T GetComponent<T>(IfNotExist ifNotExist = IfNotExist.AddNew) where T : MonoBehaviour
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		public static T AddComponent<T>() where T : MonoBehaviour
		{
			return null;
		}
	}
}
