using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi.Events;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x2000277")]
	internal class NativeEvent : BaseReferenceHolder, IEvent
	{
		[Token(Token = "0x1700029F")]
		public string Id
		{
			[Token(Token = "0x60012BD")]
			[Address(RVA = "0xC79EF4", Offset = "0xC79EF4", VA = "0xC79EF4", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A0")]
		public string Name
		{
			[Token(Token = "0x60012BE")]
			[Address(RVA = "0xC79F88", Offset = "0xC79F88", VA = "0xC79F88", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A1")]
		public string Description
		{
			[Token(Token = "0x60012BF")]
			[Address(RVA = "0xC7A01C", Offset = "0xC7A01C", VA = "0xC7A01C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A2")]
		public string ImageUrl
		{
			[Token(Token = "0x60012C0")]
			[Address(RVA = "0xC7A0B0", Offset = "0xC7A0B0", VA = "0xC7A0B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A3")]
		public ulong CurrentCount
		{
			[Token(Token = "0x60012C1")]
			[Address(RVA = "0xC7A144", Offset = "0xC7A144", VA = "0xC7A144", Slot = "10")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x170002A4")]
		public EventVisibility Visibility
		{
			[Token(Token = "0x60012C2")]
			[Address(RVA = "0xC7A15C", Offset = "0xC7A15C", VA = "0xC7A15C", Slot = "11")]
			get
			{
				return default(EventVisibility);
			}
		}

		[Token(Token = "0x60012BC")]
		[Address(RVA = "0xC73D20", Offset = "0xC73D20", VA = "0xC73D20")]
		internal NativeEvent(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x60012C3")]
		[Address(RVA = "0xC7A240", Offset = "0xC7A240", VA = "0xC7A240", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60012C4")]
		[Address(RVA = "0xC7A250", Offset = "0xC7A250", VA = "0xC7A250", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60012C5")]
		[Address(RVA = "0xC7A52C", Offset = "0xC7A52C", VA = "0xC7A52C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8363EC", Offset = "0x8363EC")]
		private UIntPtr _003Cget_Id_003Eb__2_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x60012C6")]
		[Address(RVA = "0xC7A55C", Offset = "0xC7A55C", VA = "0xC7A55C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8363FC", Offset = "0x8363FC")]
		private UIntPtr _003Cget_Name_003Eb__4_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x60012C7")]
		[Address(RVA = "0xC7A58C", Offset = "0xC7A58C", VA = "0xC7A58C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83640C", Offset = "0x83640C")]
		private UIntPtr _003Cget_Description_003Eb__6_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}

		[Token(Token = "0x60012C8")]
		[Address(RVA = "0xC7A5BC", Offset = "0xC7A5BC", VA = "0xC7A5BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x83641C", Offset = "0x83641C")]
		private UIntPtr _003Cget_ImageUrl_003Eb__8_0(byte[] out_string, UIntPtr out_size)
		{
			return default(UIntPtr);
		}
	}
}
