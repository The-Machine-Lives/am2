using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000271")]
	internal class NativeAchievement : BaseReferenceHolder
	{
		[Token(Token = "0x4000D1F")]
		private const ulong MinusOne = ulong.MaxValue;

		[Token(Token = "0x6001280")]
		[Address(RVA = "0xC71BE4", Offset = "0xC71BE4", VA = "0xC71BE4")]
		internal NativeAchievement(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001281")]
		[Address(RVA = "0xC782F8", Offset = "0xC782F8", VA = "0xC782F8")]
		internal uint CurrentSteps()
		{
			return default(uint);
		}

		[Token(Token = "0x6001282")]
		[Address(RVA = "0xC78310", Offset = "0xC78310", VA = "0xC78310")]
		internal string Description()
		{
			return null;
		}

		[Token(Token = "0x6001283")]
		[Address(RVA = "0xC783A4", Offset = "0xC783A4", VA = "0xC783A4")]
		internal string Id()
		{
			return null;
		}

		[Token(Token = "0x6001284")]
		[Address(RVA = "0xC78438", Offset = "0xC78438", VA = "0xC78438")]
		internal string Name()
		{
			return null;
		}

		[Token(Token = "0x6001285")]
		[Address(RVA = "0xC784CC", Offset = "0xC784CC", VA = "0xC784CC")]
		internal Types.AchievementState State()
		{
			return default(Types.AchievementState);
		}

		[Token(Token = "0x6001286")]
		[Address(RVA = "0xC784E4", Offset = "0xC784E4", VA = "0xC784E4")]
		internal uint TotalSteps()
		{
			return default(uint);
		}

		[Token(Token = "0x6001287")]
		[Address(RVA = "0xC784FC", Offset = "0xC784FC", VA = "0xC784FC")]
		internal Types.AchievementType Type()
		{
			return default(Types.AchievementType);
		}

		[Token(Token = "0x6001288")]
		[Address(RVA = "0xC78514", Offset = "0xC78514", VA = "0xC78514")]
		internal ulong LastModifiedTime()
		{
			return default(ulong);
		}

		[Token(Token = "0x6001289")]
		[Address(RVA = "0xC7855C", Offset = "0xC7855C", VA = "0xC7855C")]
		internal ulong getXP()
		{
			return default(ulong);
		}

		[Token(Token = "0x600128A")]
		[Address(RVA = "0xC78574", Offset = "0xC78574", VA = "0xC78574")]
		internal string getRevealedImageUrl()
		{
			return null;
		}

		[Token(Token = "0x600128B")]
		[Address(RVA = "0xC78608", Offset = "0xC78608", VA = "0xC78608")]
		internal string getUnlockedImageUrl()
		{
			return null;
		}

		[Token(Token = "0x600128C")]
		[Address(RVA = "0xC7869C", Offset = "0xC7869C", VA = "0xC7869C", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x600128D")]
		[Address(RVA = "0xC786AC", Offset = "0xC786AC", VA = "0xC786AC")]
		internal GooglePlayGames.BasicApi.Achievement AsAchievement()
		{
			return null;
		}

		[Token(Token = "0x600128E")]
		[Address(RVA = "0xC789AC", Offset = "0xC789AC", VA = "0xC789AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836244", Offset = "0x836244")]
		private UIntPtr _003CDescription_003Eb__3_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x600128F")]
		[Address(RVA = "0xC789DC", Offset = "0xC789DC", VA = "0xC789DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836254", Offset = "0x836254")]
		private UIntPtr _003CId_003Eb__4_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x6001290")]
		[Address(RVA = "0xC78A0C", Offset = "0xC78A0C", VA = "0xC78A0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836264", Offset = "0x836264")]
		private UIntPtr _003CName_003Eb__5_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x6001291")]
		[Address(RVA = "0xC78A3C", Offset = "0xC78A3C", VA = "0xC78A3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836274", Offset = "0x836274")]
		private UIntPtr _003CgetRevealedImageUrl_003Eb__11_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x6001292")]
		[Address(RVA = "0xC78A6C", Offset = "0xC78A6C", VA = "0xC78A6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836284", Offset = "0x836284")]
		private UIntPtr _003CgetUnlockedImageUrl_003Eb__12_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}
	}
}
