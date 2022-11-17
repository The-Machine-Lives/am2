using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Firebase.Platform
{
	[Token(Token = "0x2000002")]
	internal sealed class FirebaseEditorDispatcher
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8077FC", Offset = "0x8077FC")]
		private static Action _003C_003Ef__mg_0024cache0;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80780C", Offset = "0x80780C")]
		private static Action _003C_003Ef__mg_0024cache1;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80781C", Offset = "0x80781C")]
		private static Action _003C_003Ef__mg_0024cache2;

		[Token(Token = "0x17000001")]
		private static Type EditorApplicationType
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x17CFF04", Offset = "0x17CFF04", VA = "0x17CFF04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public static bool EditorIsPlaying
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x17CFF9C", Offset = "0x17CFF9C", VA = "0x17CFF9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000003")]
		public static bool EditorIsPlayingOrWillChangePlaymode
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x17D0034", Offset = "0x17D0034", VA = "0x17D0034")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x17D00CC", Offset = "0x17D00CC", VA = "0x17D00CC")]
		public static void StartEditorUpdate()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x17D039C", Offset = "0x17D039C", VA = "0x17D039C")]
		public static void StopEditorUpdate()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x17D0478", Offset = "0x17D0478", VA = "0x17D0478")]
		public static void Update()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x17D06F8", Offset = "0x17D06F8", VA = "0x17D06F8")]
		public static void ListenToPlayState(bool start = true)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x17D09B4", Offset = "0x17D09B4", VA = "0x17D09B4")]
		private static void PlayModeStateChanged()
		{
		}

		[Token(Token = "0x6000009")]
		private static void PlayModeStateChangedWithArg<T>(T t)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x17D01B4", Offset = "0x17D01B4", VA = "0x17D01B4")]
		private static void AddRemoveCallbackToField(FieldInfo eventField, Action callback, [Optional] object target, bool add = true, [Optional] string errorMessage)
		{
		}
	}
}
