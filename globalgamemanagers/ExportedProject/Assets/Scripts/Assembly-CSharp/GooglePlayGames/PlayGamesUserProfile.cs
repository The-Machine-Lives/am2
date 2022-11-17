using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	[Token(Token = "0x2000250")]
	public class PlayGamesUserProfile : IUserProfile
	{
		[Token(Token = "0x200068E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8207E8", Offset = "0x8207E8")]
		private sealed class _003CLoadImage_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001FF6")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001FF7")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001FF8")]
			[FieldOffset(Offset = "0x20")]
			public PlayGamesUserProfile _003C_003E4__this;

			[Token(Token = "0x4001FF9")]
			[FieldOffset(Offset = "0x28")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x170007FF")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6002E45")]
				[Address(RVA = "0xE75ED0", Offset = "0xE75ED0", VA = "0xE75ED0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000800")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6002E47")]
				[Address(RVA = "0xE75F40", Offset = "0xE75F40", VA = "0xE75F40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6002E42")]
			[Address(RVA = "0xE75A64", Offset = "0xE75A64", VA = "0xE75A64")]
			[DebuggerHidden]
			public _003CLoadImage_003Ed__19(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6002E43")]
			[Address(RVA = "0xE75CAC", Offset = "0xE75CAC", VA = "0xE75CAC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6002E44")]
			[Address(RVA = "0xE75CB0", Offset = "0xE75CB0", VA = "0xE75CB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6002E46")]
			[Address(RVA = "0xE75ED8", Offset = "0xE75ED8", VA = "0xE75ED8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4000CE0")]
		[FieldOffset(Offset = "0x10")]
		private string mDisplayName;

		[Token(Token = "0x4000CE1")]
		[FieldOffset(Offset = "0x18")]
		private string mPlayerId;

		[Token(Token = "0x4000CE2")]
		[FieldOffset(Offset = "0x20")]
		private string mAvatarUrl;

		[Token(Token = "0x4000CE3")]
		[FieldOffset(Offset = "0x28")]
		private bool mImageLoading;

		[Token(Token = "0x4000CE4")]
		[FieldOffset(Offset = "0x30")]
		private Texture2D mImage;

		[Token(Token = "0x17000298")]
		public string userName
		{
			[Token(Token = "0x600111F")]
			[Address(RVA = "0xE70400", Offset = "0xE70400", VA = "0xE70400", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000299")]
		public string id
		{
			[Token(Token = "0x6001120")]
			[Address(RVA = "0xE70754", Offset = "0xE70754", VA = "0xE70754", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700029A")]
		public bool isFriend
		{
			[Token(Token = "0x6001121")]
			[Address(RVA = "0xE758B0", Offset = "0xE758B0", VA = "0xE758B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700029B")]
		public UserState state
		{
			[Token(Token = "0x6001122")]
			[Address(RVA = "0xE758B8", Offset = "0xE758B8", VA = "0xE758B8", Slot = "7")]
			get
			{
				return default(UserState);
			}
		}

		[Token(Token = "0x1700029C")]
		public Texture2D image
		{
			[Token(Token = "0x6001123")]
			[Address(RVA = "0xE758C0", Offset = "0xE758C0", VA = "0xE758C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700029D")]
		public string AvatarURL
		{
			[Token(Token = "0x6001124")]
			[Address(RVA = "0xE759E8", Offset = "0xE759E8", VA = "0xE759E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600111D")]
		[Address(RVA = "0xE6F9FC", Offset = "0xE6F9FC", VA = "0xE6F9FC")]
		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl)
		{
		}

		[Token(Token = "0x600111E")]
		[Address(RVA = "0xE70618", Offset = "0xE70618", VA = "0xE70618")]
		protected void ResetIdentity(string displayName, string playerId, string avatarUrl)
		{
		}

		[Token(Token = "0x6001125")]
		[Address(RVA = "0xE759F0", Offset = "0xE759F0", VA = "0xE759F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x835B94", Offset = "0x835B94")]
		internal IEnumerator LoadImage()
		{
			return null;
		}

		[Token(Token = "0x6001126")]
		[Address(RVA = "0xE75A90", Offset = "0xE75A90", VA = "0xE75A90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6001127")]
		[Address(RVA = "0xE75B9C", Offset = "0xE75B9C", VA = "0xE75B9C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6001128")]
		[Address(RVA = "0xE75C58", Offset = "0xE75C58", VA = "0xE75C58", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
