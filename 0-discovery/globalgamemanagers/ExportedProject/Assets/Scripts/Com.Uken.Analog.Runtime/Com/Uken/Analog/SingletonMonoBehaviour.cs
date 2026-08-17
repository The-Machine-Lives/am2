using Il2CppDummyDll;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Token(Token = "0x2000052")]
	public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : Component
	{
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x0")]
		private static T instance_;

		[Token(Token = "0x17000094")]
		public static T Instance
		{
			[Token(Token = "0x600025D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025E")]
		protected SingletonMonoBehaviour()
		{
		}
	}
}
