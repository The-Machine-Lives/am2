using System.Collections.Generic;
using Il2CppDummyDll;

namespace com.adjust.sdk
{
	[Token(Token = "0x2000230")]
	public class AdjustSessionSuccess
	{
		[Token(Token = "0x4000C68")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826654", Offset = "0x826654")]
		private string _003CAdid_003Ek__BackingField;

		[Token(Token = "0x4000C69")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826664", Offset = "0x826664")]
		private string _003CMessage_003Ek__BackingField;

		[Token(Token = "0x4000C6A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826674", Offset = "0x826674")]
		private string _003CTimestamp_003Ek__BackingField;

		[Token(Token = "0x4000C6B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826684", Offset = "0x826684")]
		private Dictionary<string, object> _003CJsonResponse_003Ek__BackingField;

		[Token(Token = "0x17000212")]
		public string Adid
		{
			[Token(Token = "0x6000F89")]
			[Address(RVA = "0x177AFAC", Offset = "0x177AFAC", VA = "0x177AFAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835974", Offset = "0x835974")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F8A")]
			[Address(RVA = "0x1778760", Offset = "0x1778760", VA = "0x1778760")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835984", Offset = "0x835984")]
			set
			{
			}
		}

		[Token(Token = "0x17000213")]
		public string Message
		{
			[Token(Token = "0x6000F8B")]
			[Address(RVA = "0x177AFB4", Offset = "0x177AFB4", VA = "0x177AFB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835994", Offset = "0x835994")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F8C")]
			[Address(RVA = "0x1778768", Offset = "0x1778768", VA = "0x1778768")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8359A4", Offset = "0x8359A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000214")]
		public string Timestamp
		{
			[Token(Token = "0x6000F8D")]
			[Address(RVA = "0x177AFBC", Offset = "0x177AFBC", VA = "0x177AFBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8359B4", Offset = "0x8359B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F8E")]
			[Address(RVA = "0x1778770", Offset = "0x1778770", VA = "0x1778770")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8359C4", Offset = "0x8359C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000215")]
		public Dictionary<string, object> JsonResponse
		{
			[Token(Token = "0x6000F8F")]
			[Address(RVA = "0x177AFC4", Offset = "0x177AFC4", VA = "0x177AFC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8359D4", Offset = "0x8359D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F90")]
			[Address(RVA = "0x177AFCC", Offset = "0x177AFCC", VA = "0x177AFCC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8359E4", Offset = "0x8359E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000F91")]
		[Address(RVA = "0x1778758", Offset = "0x1778758", VA = "0x1778758")]
		public AdjustSessionSuccess()
		{
		}

		[Token(Token = "0x6000F92")]
		[Address(RVA = "0x177AFD4", Offset = "0x177AFD4", VA = "0x177AFD4")]
		public AdjustSessionSuccess(Dictionary<string, string> sessionSuccessDataMap)
		{
		}

		[Token(Token = "0x6000F93")]
		[Address(RVA = "0x177B164", Offset = "0x177B164", VA = "0x177B164")]
		public AdjustSessionSuccess(string jsonString)
		{
		}

		[Token(Token = "0x6000F94")]
		[Address(RVA = "0x1778778", Offset = "0x1778778", VA = "0x1778778")]
		public void BuildJsonResponseFromString(string jsonResponseString)
		{
		}

		[Token(Token = "0x6000F95")]
		[Address(RVA = "0x177B31C", Offset = "0x177B31C", VA = "0x177B31C")]
		public string GetJsonResponse()
		{
			return null;
		}
	}
}
