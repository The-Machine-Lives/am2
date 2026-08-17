using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003CA")]
	public class NativeAndroid : INative
	{
		[Token(Token = "0x40011E7")]
		[FieldOffset(Offset = "0x10")]
		private string manufacturer;

		[Token(Token = "0x40011E8")]
		[FieldOffset(Offset = "0x18")]
		private string systemName;

		[Token(Token = "0x40011E9")]
		[FieldOffset(Offset = "0x20")]
		private string systemVersion;

		[Token(Token = "0x40011EA")]
		[FieldOffset(Offset = "0x28")]
		private string deviceMachineType;

		[Token(Token = "0x40011EB")]
		[FieldOffset(Offset = "0x30")]
		private string jailBroken;

		[Token(Token = "0x40011EC")]
		[FieldOffset(Offset = "0x38")]
		private string localeIdentifier;

		[Token(Token = "0x40011ED")]
		[FieldOffset(Offset = "0x40")]
		private string localeTimeZone;

		[Token(Token = "0x40011EE")]
		[FieldOffset(Offset = "0x48")]
		private string localeTimeGMTOffsetString;

		[Token(Token = "0x40011EF")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, string> identifiers;

		[Token(Token = "0x17000574")]
		public string Platform
		{
			[Token(Token = "0x6001D50")]
			[Address(RVA = "0xA19F40", Offset = "0xA19F40", VA = "0xA19F40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000575")]
		public string Manufacturer
		{
			[Token(Token = "0x6001D51")]
			[Address(RVA = "0xA19FAC", Offset = "0xA19FAC", VA = "0xA19FAC", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000576")]
		public string SystemName
		{
			[Token(Token = "0x6001D52")]
			[Address(RVA = "0xA19FB4", Offset = "0xA19FB4", VA = "0xA19FB4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000577")]
		public string SystemVersion
		{
			[Token(Token = "0x6001D53")]
			[Address(RVA = "0xA19FBC", Offset = "0xA19FBC", VA = "0xA19FBC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000578")]
		public string DeviceMachineType
		{
			[Token(Token = "0x6001D54")]
			[Address(RVA = "0xA19FC4", Offset = "0xA19FC4", VA = "0xA19FC4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000579")]
		public string JailBroken
		{
			[Token(Token = "0x6001D55")]
			[Address(RVA = "0xA19FCC", Offset = "0xA19FCC", VA = "0xA19FCC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057A")]
		public string LocaleIdentifier
		{
			[Token(Token = "0x6001D56")]
			[Address(RVA = "0xA19FD4", Offset = "0xA19FD4", VA = "0xA19FD4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057B")]
		public string LocaleTimeZone
		{
			[Token(Token = "0x6001D57")]
			[Address(RVA = "0xA19FDC", Offset = "0xA19FDC", VA = "0xA19FDC", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057C")]
		public string LocaleTimeGMTOffsetString
		{
			[Token(Token = "0x6001D58")]
			[Address(RVA = "0xA19FE4", Offset = "0xA19FE4", VA = "0xA19FE4", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057D")]
		public Dictionary<string, string> Identifiers
		{
			[Token(Token = "0x6001D59")]
			[Address(RVA = "0xA19FEC", Offset = "0xA19FEC", VA = "0xA19FEC", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001D4D")]
		[Address(RVA = "0xA198E4", Offset = "0xA198E4", VA = "0xA198E4")]
		public NativeAndroid()
		{
		}

		[Token(Token = "0x6001D4E")]
		[Address(RVA = "0xA19F3C", Offset = "0xA19F3C", VA = "0xA19F3C")]
		public void ForceUpdateInfo()
		{
		}

		[Token(Token = "0x6001D4F")]
		[Address(RVA = "0xA1990C", Offset = "0xA1990C", VA = "0xA1990C")]
		private void UpdateInfo()
		{
		}

		[Token(Token = "0x6001D5A")]
		[Address(RVA = "0xA19FF4", Offset = "0xA19FF4", VA = "0xA19FF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838838", Offset = "0x838838")]
		private void _003CUpdateInfo_003Eb__11_0(string advertisingId, bool trackingEnabled, string error)
		{
		}
	}
}
