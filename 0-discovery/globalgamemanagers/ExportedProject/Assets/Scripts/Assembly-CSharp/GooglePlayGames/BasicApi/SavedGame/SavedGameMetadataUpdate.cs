using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	[Token(Token = "0x20002F1")]
	public struct SavedGameMetadataUpdate
	{
		[Token(Token = "0x200079D")]
		public struct Builder
		{
			[Token(Token = "0x4002217")]
			[FieldOffset(Offset = "0x0")]
			internal bool mDescriptionUpdated;

			[Token(Token = "0x4002218")]
			[FieldOffset(Offset = "0x8")]
			internal string mNewDescription;

			[Token(Token = "0x4002219")]
			[FieldOffset(Offset = "0x10")]
			internal bool mCoverImageUpdated;

			[Token(Token = "0x400221A")]
			[FieldOffset(Offset = "0x18")]
			internal byte[] mNewPngCoverImage;

			[Token(Token = "0x400221B")]
			[FieldOffset(Offset = "0x20")]
			internal TimeSpan? mNewPlayedTime;

			[Token(Token = "0x6003198")]
			[Address(RVA = "0x8B454C", Offset = "0x8B454C", VA = "0x8B454C")]
			public Builder WithUpdatedDescription(string description)
			{
				return default(Builder);
			}

			[Token(Token = "0x6003199")]
			[Address(RVA = "0x8B4554", Offset = "0x8B4554", VA = "0x8B4554")]
			public Builder WithUpdatedPngCoverImage(byte[] newPngCoverImage)
			{
				return default(Builder);
			}

			[Token(Token = "0x600319A")]
			[Address(RVA = "0x8B457C", Offset = "0x8B457C", VA = "0x8B457C")]
			public Builder WithUpdatedPlayedTime(TimeSpan newPlayedTime)
			{
				return default(Builder);
			}

			[Token(Token = "0x600319B")]
			[Address(RVA = "0x8B4584", Offset = "0x8B4584", VA = "0x8B4584")]
			public SavedGameMetadataUpdate Build()
			{
				return default(SavedGameMetadataUpdate);
			}
		}

		[Token(Token = "0x4000DDB")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool mDescriptionUpdated;

		[Token(Token = "0x4000DDC")]
		[FieldOffset(Offset = "0x8")]
		private readonly string mNewDescription;

		[Token(Token = "0x4000DDD")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool mCoverImageUpdated;

		[Token(Token = "0x4000DDE")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] mNewPngCoverImage;

		[Token(Token = "0x4000DDF")]
		[FieldOffset(Offset = "0x20")]
		private readonly TimeSpan? mNewPlayedTime;

		[Token(Token = "0x170002EE")]
		public bool IsDescriptionUpdated
		{
			[Token(Token = "0x600171A")]
			[Address(RVA = "0x8B44CC", Offset = "0x8B44CC", VA = "0x8B44CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002EF")]
		public string UpdatedDescription
		{
			[Token(Token = "0x600171B")]
			[Address(RVA = "0x8B44D4", Offset = "0x8B44D4", VA = "0x8B44D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F0")]
		public bool IsCoverImageUpdated
		{
			[Token(Token = "0x600171C")]
			[Address(RVA = "0x8B44DC", Offset = "0x8B44DC", VA = "0x8B44DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002F1")]
		public byte[] UpdatedPngCoverImage
		{
			[Token(Token = "0x600171D")]
			[Address(RVA = "0x8B44E4", Offset = "0x8B44E4", VA = "0x8B44E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F2")]
		public bool IsPlayedTimeUpdated
		{
			[Token(Token = "0x600171E")]
			[Address(RVA = "0x8B44EC", Offset = "0x8B44EC", VA = "0x8B44EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002F3")]
		public TimeSpan? UpdatedPlayedTime
		{
			[Token(Token = "0x600171F")]
			[Address(RVA = "0x8B44F4", Offset = "0x8B44F4", VA = "0x8B44F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001719")]
		[Address(RVA = "0x8B4490", Offset = "0x8B4490", VA = "0x8B4490")]
		private SavedGameMetadataUpdate(Builder builder)
		{
		}
	}
}
