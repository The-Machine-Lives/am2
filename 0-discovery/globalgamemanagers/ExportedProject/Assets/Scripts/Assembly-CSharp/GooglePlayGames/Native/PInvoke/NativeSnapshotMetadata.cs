using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.SavedGame;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000282")]
	internal class NativeSnapshotMetadata : BaseReferenceHolder, ISavedGameMetadata
	{
		[Token(Token = "0x170002A5")]
		public bool IsOpen
		{
			[Token(Token = "0x6001321")]
			[Address(RVA = "0xE5C924", Offset = "0xE5C924", VA = "0xE5C924", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002A6")]
		public string Filename
		{
			[Token(Token = "0x6001322")]
			[Address(RVA = "0xE5C940", Offset = "0xE5C940", VA = "0xE5C940", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A7")]
		public string Description
		{
			[Token(Token = "0x6001323")]
			[Address(RVA = "0xE5C9D0", Offset = "0xE5C9D0", VA = "0xE5C9D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A8")]
		public string CoverImageURL
		{
			[Token(Token = "0x6001324")]
			[Address(RVA = "0xE5CA60", Offset = "0xE5CA60", VA = "0xE5CA60", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A9")]
		public TimeSpan TotalTimePlayed
		{
			[Token(Token = "0x6001325")]
			[Address(RVA = "0xE5CAF0", Offset = "0xE5CAF0", VA = "0xE5CAF0", Slot = "10")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x170002AA")]
		public DateTime LastModifiedTimestamp
		{
			[Token(Token = "0x6001326")]
			[Address(RVA = "0xE5CBA0", Offset = "0xE5CBA0", VA = "0xE5CBA0", Slot = "11")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x6001320")]
		[Address(RVA = "0xE5C8AC", Offset = "0xE5C8AC", VA = "0xE5C8AC")]
		internal NativeSnapshotMetadata(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x6001327")]
		[Address(RVA = "0xE5CCD8", Offset = "0xE5CCD8", VA = "0xE5CCD8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6001328")]
		[Address(RVA = "0xE5CFDC", Offset = "0xE5CFDC", VA = "0xE5CFDC", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x6001329")]
		[Address(RVA = "0xE5CFF8", Offset = "0xE5CFF8", VA = "0xE5CFF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x836594", Offset = "0x836594")]
		private UIntPtr _003Cget_Filename_003Eb__4_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x600132A")]
		[Address(RVA = "0xE5D02C", Offset = "0xE5D02C", VA = "0xE5D02C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8365A4", Offset = "0x8365A4")]
		private UIntPtr _003Cget_Description_003Eb__6_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x600132B")]
		[Address(RVA = "0xE5D060", Offset = "0xE5D060", VA = "0xE5D060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8365B4", Offset = "0x8365B4")]
		private UIntPtr _003Cget_CoverImageURL_003Eb__8_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}
	}
}
