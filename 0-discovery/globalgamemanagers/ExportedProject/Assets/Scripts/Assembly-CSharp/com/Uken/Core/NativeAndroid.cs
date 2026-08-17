using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Com.Uken.Core
{
	[Token(Token = "0x2000236")]
	public class NativeAndroid : INative
	{
		[Token(Token = "0x200067E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820708", Offset = "0x820708")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x4001FD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NativeAndroid _003C_003E4__this;

			[Token(Token = "0x4001FDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<Dictionary<string, object>> onIdentifiersFetched;

			[Token(Token = "0x6002E0F")]
			[Address(RVA = "0x9BD5C0", Offset = "0x9BD5C0", VA = "0x9BD5C0")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6002E10")]
			[Address(RVA = "0x9BD658", Offset = "0x9BD658", VA = "0x9BD658")]
			internal void _003CFetchAsyncIndentifiersIfNecessary_003Eb__0(string advertisingId, bool trackingEnabled, string error)
			{
			}
		}

		[Token(Token = "0x4000C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string manufacturer;

		[Token(Token = "0x4000C99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string systemName;

		[Token(Token = "0x4000C9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string systemVersion;

		[Token(Token = "0x4000C9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string deviceMachineType;

		[Token(Token = "0x4000C9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string jailBroken;

		[Token(Token = "0x4000C9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string localeIdentifier;

		[Token(Token = "0x4000C9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string localeTimeZone;

		[Token(Token = "0x4000C9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string localeTimeGMTOffsetString;

		[Token(Token = "0x4000CA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, string> identifiers;

		[Token(Token = "0x1700022E")]
		public string Platform
		{
			[Token(Token = "0x6000FD3")]
			[Address(RVA = "0x9BD5C8", Offset = "0x9BD5C8", VA = "0x9BD5C8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700022F")]
		public string Manufacturer
		{
			[Token(Token = "0x6000FD4")]
			[Address(RVA = "0x9BD610", Offset = "0x9BD610", VA = "0x9BD610", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000230")]
		public string SystemName
		{
			[Token(Token = "0x6000FD5")]
			[Address(RVA = "0x9BD618", Offset = "0x9BD618", VA = "0x9BD618", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000231")]
		public string SystemVersion
		{
			[Token(Token = "0x6000FD6")]
			[Address(RVA = "0x9BD620", Offset = "0x9BD620", VA = "0x9BD620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000232")]
		public string DeviceMachineType
		{
			[Token(Token = "0x6000FD7")]
			[Address(RVA = "0x9BD628", Offset = "0x9BD628", VA = "0x9BD628", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000233")]
		public string JailBroken
		{
			[Token(Token = "0x6000FD8")]
			[Address(RVA = "0x9BD630", Offset = "0x9BD630", VA = "0x9BD630", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000234")]
		public string LocaleIdentifier
		{
			[Token(Token = "0x6000FD9")]
			[Address(RVA = "0x9BD638", Offset = "0x9BD638", VA = "0x9BD638", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000235")]
		public string LocaleTimeZone
		{
			[Token(Token = "0x6000FDA")]
			[Address(RVA = "0x9BD640", Offset = "0x9BD640", VA = "0x9BD640", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000236")]
		public string LocaleTimeGMTOffsetString
		{
			[Token(Token = "0x6000FDB")]
			[Address(RVA = "0x9BD648", Offset = "0x9BD648", VA = "0x9BD648", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000237")]
		public Dictionary<string, string> Identifiers
		{
			[Token(Token = "0x6000FDC")]
			[Address(RVA = "0x9BD650", Offset = "0x9BD650", VA = "0x9BD650", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x9BCBDC", Offset = "0x9BCBDC", VA = "0x9BCBDC")]
		public NativeAndroid()
		{
		}

		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x9BD430", Offset = "0x9BD430", VA = "0x9BD430")]
		public void ForceUpdateInfo()
		{
		}

		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x9BD434", Offset = "0x9BD434", VA = "0x9BD434", Slot = "14")]
		public void FetchAsyncIndentifiersIfNecessary([Optional] Action<Dictionary<string, object>> onIdentifiersFetched)
		{
		}

		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x9BCC04", Offset = "0x9BCC04", VA = "0x9BCC04")]
		private void UpdateInfo()
		{
		}
	}
}
