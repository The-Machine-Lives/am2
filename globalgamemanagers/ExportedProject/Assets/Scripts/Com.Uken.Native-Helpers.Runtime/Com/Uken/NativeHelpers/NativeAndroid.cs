using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Com.Uken.NativeHelpers
{
	[Token(Token = "0x2000004")]
	public class NativeAndroid : INative
	{
		[Token(Token = "0x2000005")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80CC90", Offset = "0x80CC90")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x4000010")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NativeAndroid _003C_003E4__this;

			[Token(Token = "0x4000011")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<Dictionary<string, object>> onIdentifiersFetched;

			[Token(Token = "0x6000020")]
			[Address(RVA = "0x1818DBC", Offset = "0x1818DBC", VA = "0x1818DBC")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000021")]
			[Address(RVA = "0x1818E54", Offset = "0x1818E54", VA = "0x1818E54")]
			internal void _003CFetchAsyncIndentifiersIfNecessary_003Eb__0(string advertisingId, bool trackingEnabled, string error)
			{
			}
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string manufacturer;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string systemName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string systemVersion;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string deviceMachineType;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string jailBroken;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string localeIdentifier;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string localeTimeZone;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string localeTimeGMTOffsetString;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, string> identifiers;

		[Token(Token = "0x1700000E")]
		public string Platform
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x1818DC4", Offset = "0x1818DC4", VA = "0x1818DC4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public string Manufacturer
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x1818E0C", Offset = "0x1818E0C", VA = "0x1818E0C", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public string SystemName
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x1818E14", Offset = "0x1818E14", VA = "0x1818E14", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public string SystemVersion
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x1818E1C", Offset = "0x1818E1C", VA = "0x1818E1C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public string DeviceMachineType
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x1818E24", Offset = "0x1818E24", VA = "0x1818E24", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public string JailBroken
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x1818E2C", Offset = "0x1818E2C", VA = "0x1818E2C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public string LocaleIdentifier
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1818E34", Offset = "0x1818E34", VA = "0x1818E34", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public string LocaleTimeZone
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x1818E3C", Offset = "0x1818E3C", VA = "0x1818E3C", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public string LocaleTimeGMTOffsetString
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x1818E44", Offset = "0x1818E44", VA = "0x1818E44", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public Dictionary<string, string> Identifiers
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x1818E4C", Offset = "0x1818E4C", VA = "0x1818E4C", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x181823C", Offset = "0x181823C", VA = "0x181823C")]
		public NativeAndroid()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1818C30", Offset = "0x1818C30", VA = "0x1818C30", Slot = "14")]
		public void FetchAsyncIndentifiersIfNecessary([Optional] Action<Dictionary<string, object>> onIdentifiersFetched)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1818404", Offset = "0x1818404", VA = "0x1818404")]
		private void UpdateInfo()
		{
		}
	}
}
