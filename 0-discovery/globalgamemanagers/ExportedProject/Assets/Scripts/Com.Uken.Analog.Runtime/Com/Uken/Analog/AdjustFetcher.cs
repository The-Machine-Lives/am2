using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Token(Token = "0x2000006")]
	public class AdjustFetcher : SingletonMonoBehaviour<AdjustFetcher>
	{
		[Token(Token = "0x4000007")]
		private const string EDITOR_ADJUST_ID = "EditorAdjustId";

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Type adjustType;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float timeSinceLastFetch;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action<string> onDataFetched;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813DB8", Offset = "0x813DB8")]
		private static float _003CFetchPeriod_003Ek__BackingField;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813DC8", Offset = "0x813DC8")]
		private static string _003CFetchedAdjustId_003Ek__BackingField;

		[Token(Token = "0x17000002")]
		public static float FetchPeriod
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x16CF0A0", Offset = "0x16CF0A0", VA = "0x16CF0A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8156D0", Offset = "0x8156D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x16CF108", Offset = "0x16CF108", VA = "0x16CF108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8156E0", Offset = "0x8156E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public static string FetchedAdjustId
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x16CF17C", Offset = "0x16CF17C", VA = "0x16CF17C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8156F0", Offset = "0x8156F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x16CF1E4", Offset = "0x16CF1E4", VA = "0x16CF1E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815700", Offset = "0x815700")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public static bool ValidAdjustIdPresent
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x16CF250", Offset = "0x16CF250", VA = "0x16CF250")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x16CF2C0", Offset = "0x16CF2C0", VA = "0x16CF2C0")]
		public void Initialize(float fetchPeriod = 1f, [Optional] Action<string> onDataFetched)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x16CF344", Offset = "0x16CF344", VA = "0x16CF344")]
		private static string GetAdjustData()
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x16CF518", Offset = "0x16CF518", VA = "0x16CF518")]
		private static Type GetType(string typeName)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x16CF6C4", Offset = "0x16CF6C4", VA = "0x16CF6C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x16CF7DC", Offset = "0x16CF7DC", VA = "0x16CF7DC")]
		public AdjustFetcher()
		{
		}
	}
}
