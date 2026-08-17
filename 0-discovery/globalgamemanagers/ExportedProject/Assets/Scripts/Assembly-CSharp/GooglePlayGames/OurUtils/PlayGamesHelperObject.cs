using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.OurUtils
{
	[Token(Token = "0x20002D0")]
	public class PlayGamesHelperObject : MonoBehaviour
	{
		[Token(Token = "0x200079A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F48", Offset = "0x820F48")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x4002209")]
			[FieldOffset(Offset = "0x10")]
			public IEnumerator action;

			[Token(Token = "0x600317D")]
			[Address(RVA = "0xE6CCCC", Offset = "0xE6CCCC", VA = "0xE6CCCC")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600317E")]
			[Address(RVA = "0xE6D8A0", Offset = "0xE6D8A0", VA = "0xE6D8A0")]
			internal void _003CRunCoroutine_003Eb__0()
			{
			}
		}

		[Token(Token = "0x4000D39")]
		[FieldOffset(Offset = "0x0")]
		private static PlayGamesHelperObject instance;

		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x8")]
		private static bool sIsDummy;

		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x10")]
		private static List<Action> sQueue;

		[Token(Token = "0x4000D3C")]
		[FieldOffset(Offset = "0x18")]
		private List<Action> localQueue;

		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x18")]
		private static bool sQueueEmpty;

		[Token(Token = "0x4000D3E")]
		[FieldOffset(Offset = "0x20")]
		private static List<Action<bool>> sPauseCallbackList;

		[Token(Token = "0x4000D3F")]
		[FieldOffset(Offset = "0x28")]
		private static List<Action<bool>> sFocusCallbackList;

		[Token(Token = "0x6001630")]
		[Address(RVA = "0xE6C84C", Offset = "0xE6C84C", VA = "0xE6C84C")]
		public static void CreateObject()
		{
		}

		[Token(Token = "0x6001631")]
		[Address(RVA = "0xE6CA50", Offset = "0xE6CA50", VA = "0xE6CA50")]
		public void Awake()
		{
		}

		[Token(Token = "0x6001632")]
		[Address(RVA = "0xE6CACC", Offset = "0xE6CACC", VA = "0xE6CACC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6001633")]
		[Address(RVA = "0xE6CB9C", Offset = "0xE6CB9C", VA = "0xE6CB9C")]
		public static void RunCoroutine(IEnumerator action)
		{
		}

		[Token(Token = "0x6001634")]
		[Address(RVA = "0xE6BB2C", Offset = "0xE6BB2C", VA = "0xE6BB2C")]
		public static void RunOnGameThread(Action action)
		{
		}

		[Token(Token = "0x6001635")]
		[Address(RVA = "0xE6CCD4", Offset = "0xE6CCD4", VA = "0xE6CCD4")]
		public void Update()
		{
		}

		[Token(Token = "0x6001636")]
		[Address(RVA = "0xE6CF50", Offset = "0xE6CF50", VA = "0xE6CF50")]
		public void OnApplicationFocus(bool focused)
		{
		}

		[Token(Token = "0x6001637")]
		[Address(RVA = "0xE6D200", Offset = "0xE6D200", VA = "0xE6D200")]
		public void OnApplicationPause(bool paused)
		{
		}

		[Token(Token = "0x6001638")]
		[Address(RVA = "0xE6D4B0", Offset = "0xE6D4B0", VA = "0xE6D4B0")]
		public static void AddFocusCallback(Action<bool> callback)
		{
		}

		[Token(Token = "0x6001639")]
		[Address(RVA = "0xE6D5A0", Offset = "0xE6D5A0", VA = "0xE6D5A0")]
		public static bool RemoveFocusCallback(Action<bool> callback)
		{
			return default(bool);
		}

		[Token(Token = "0x600163A")]
		[Address(RVA = "0xE6D62C", Offset = "0xE6D62C", VA = "0xE6D62C")]
		public static void AddPauseCallback(Action<bool> callback)
		{
		}

		[Token(Token = "0x600163B")]
		[Address(RVA = "0xE6D71C", Offset = "0xE6D71C", VA = "0xE6D71C")]
		public static bool RemovePauseCallback(Action<bool> callback)
		{
			return default(bool);
		}

		[Token(Token = "0x600163C")]
		[Address(RVA = "0xE6C9E0", Offset = "0xE6C9E0", VA = "0xE6C9E0")]
		public PlayGamesHelperObject()
		{
		}
	}
}
