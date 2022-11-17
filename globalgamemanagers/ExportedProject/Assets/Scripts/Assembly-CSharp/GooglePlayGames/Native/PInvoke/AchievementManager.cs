using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000263")]
	internal class AchievementManager
	{
		[Token(Token = "0x20006FB")]
		internal class FetchResponse : BaseReferenceHolder
		{
			[Token(Token = "0x6002F91")]
			[Address(RVA = "0xC71DD4", Offset = "0xC71DD4", VA = "0xC71DD4")]
			internal FetchResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6002F92")]
			[Address(RVA = "0xC71E48", Offset = "0xC71E48", VA = "0xC71E48")]
			internal CommonErrorStatus.ResponseStatus Status()
			{
				return default(CommonErrorStatus.ResponseStatus);
			}

			[Token(Token = "0x6002F93")]
			[Address(RVA = "0xC71E60", Offset = "0xC71E60", VA = "0xC71E60")]
			internal NativeAchievement Achievement()
			{
				return null;
			}

			[Token(Token = "0x6002F94")]
			[Address(RVA = "0xC71ED8", Offset = "0xC71ED8", VA = "0xC71ED8", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6002F95")]
			[Address(RVA = "0xC71EE8", Offset = "0xC71EE8", VA = "0xC71EE8")]
			internal static FetchResponse FromPointer(IntPtr pointer)
			{
				return null;
			}
		}

		[Token(Token = "0x20006FC")]
		internal class FetchAllResponse : BaseReferenceHolder, IEnumerable<NativeAchievement>, IEnumerable
		{
			[Token(Token = "0x6002F96")]
			[Address(RVA = "0xC7190C", Offset = "0xC7190C", VA = "0xC7190C")]
			internal FetchAllResponse(IntPtr selfPointer)
			{
			}

			[Token(Token = "0x6002F97")]
			[Address(RVA = "0xC71A28", Offset = "0xC71A28", VA = "0xC71A28")]
			internal CommonErrorStatus.ResponseStatus Status()
			{
				return default(CommonErrorStatus.ResponseStatus);
			}

			[Token(Token = "0x6002F98")]
			[Address(RVA = "0xC71AD4", Offset = "0xC71AD4", VA = "0xC71AD4")]
			internal UIntPtr Length()
			{
				return default(UIntPtr);
			}

			[Token(Token = "0x6002F99")]
			[Address(RVA = "0xC71AEC", Offset = "0xC71AEC", VA = "0xC71AEC")]
			private NativeAchievement GetElement(UIntPtr index)
			{
				return null;
			}

			[Token(Token = "0x6002F9A")]
			[Address(RVA = "0xC71C58", Offset = "0xC71C58", VA = "0xC71C58", Slot = "6")]
			public IEnumerator<NativeAchievement> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6002F9B")]
			[Address(RVA = "0xC71D20", Offset = "0xC71D20", VA = "0xC71D20", Slot = "7")]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6002F9C")]
			[Address(RVA = "0xC71D24", Offset = "0xC71D24", VA = "0xC71D24", Slot = "5")]
			protected override void CallDispose(HandleRef selfPointer)
			{
			}

			[Token(Token = "0x6002F9D")]
			[Address(RVA = "0xC71D34", Offset = "0xC71D34", VA = "0xC71D34")]
			internal static FetchAllResponse FromPointer(IntPtr pointer)
			{
				return null;
			}

			[Token(Token = "0x6002F9E")]
			[Address(RVA = "0xC71DD0", Offset = "0xC71DD0", VA = "0xC71DD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83B66C", Offset = "0x83B66C")]
			private NativeAchievement _003CGetEnumerator_003Eb__4_0(UIntPtr index)
			{
				return null;
			}
		}

		[Token(Token = "0x4000D18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly GameServices mServices;

		[Token(Token = "0x60011FB")]
		[Address(RVA = "0xC70F80", Offset = "0xC70F80", VA = "0xC70F80")]
		internal AchievementManager(GameServices services)
		{
		}

		[Token(Token = "0x60011FC")]
		[Address(RVA = "0xC70FF0", Offset = "0xC70FF0", VA = "0xC70FF0")]
		internal void ShowAllUI(Action<CommonErrorStatus.UIStatus> callback)
		{
		}

		[Token(Token = "0x60011FD")]
		[Address(RVA = "0xC71144", Offset = "0xC71144", VA = "0xC71144")]
		internal void FetchAll(Action<FetchAllResponse> callback)
		{
		}

		[Token(Token = "0x60011FE")]
		[Address(RVA = "0xC70E78", Offset = "0xC70E78", VA = "0xC70E78")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x835C9C", Offset = "0x835C9C")]
		private static void InternalFetchAllCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x60011FF")]
		[Address(RVA = "0xC715A8", Offset = "0xC715A8", VA = "0xC715A8")]
		internal void Fetch(string achId, Action<FetchResponse> callback)
		{
		}

		[Token(Token = "0x6001200")]
		[Address(RVA = "0xC70EFC", Offset = "0xC70EFC", VA = "0xC70EFC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x835D00", Offset = "0x835D00")]
		private static void InternalFetchCallback(IntPtr response, IntPtr data)
		{
		}

		[Token(Token = "0x6001201")]
		[Address(RVA = "0xC716FC", Offset = "0xC716FC", VA = "0xC716FC")]
		internal void Increment(string achievementId, uint numSteps)
		{
		}

		[Token(Token = "0x6001202")]
		[Address(RVA = "0xC71784", Offset = "0xC71784", VA = "0xC71784")]
		internal void SetStepsAtLeast(string achivementId, uint numSteps)
		{
		}

		[Token(Token = "0x6001203")]
		[Address(RVA = "0xC7180C", Offset = "0xC7180C", VA = "0xC7180C")]
		internal void Reveal(string achievementId)
		{
		}

		[Token(Token = "0x6001204")]
		[Address(RVA = "0xC7188C", Offset = "0xC7188C", VA = "0xC7188C")]
		internal void Unlock(string achievementId)
		{
		}
	}
}
