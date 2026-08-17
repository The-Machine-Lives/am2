using System;
using System.Collections.Generic;
using Com.Uken.NativeHelpers;
using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Token(Token = "0x2000008")]
	public class AnalogAnalytics : SingletonMonoBehaviour<AnalogAnalytics>
	{
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x18")]
		private Analog analog;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x20")]
		private AnalogController analogController;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x28")]
		private App.EnvironmentName environmentName;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x2C")]
		private bool shouldLogValidationErrors;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x30")]
		private string analogEndpoint;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x38")]
		private string analogApiKey;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x40")]
		private App.GameName gameName;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x48")]
		private Com.Uken.NativeHelpers.Device device;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x50")]
		private ThirdParty thirdParty;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x58")]
		private bool initialized;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x60")]
		private Action onAnalogInitialized;

		[Token(Token = "0x17000006")]
		public Guid? SessionId
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x16D0180", Offset = "0x16D0180", VA = "0x16D0180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x16D021C", Offset = "0x16D021C", VA = "0x16D021C")]
		public void Init(App.EnvironmentName environmentName, string analogEndpoint, string analogApiKey, App.GameName gameName, UkenLogger.LogLevel logLevel, AutomaticEventConfig automaticEventConfig, float? thirdPartyFetchTimeout, Action onAnalogInitialized)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x16D0650", Offset = "0x16D0650", VA = "0x16D0650")]
		public void UpdateEventContext(Dictionary<string, object> contextData)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x16D0E64", Offset = "0x16D0E64", VA = "0x16D0E64")]
		public void Send(BaseEvent baseEvent)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x16D0EAC", Offset = "0x16D0EAC", VA = "0x16D0EAC")]
		public void SetMaxEventQueueSize(int size)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x16D0F00", Offset = "0x16D0F00", VA = "0x16D0F00")]
		public void SetMinimumSaveInterval(int secondsInterval)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x16D0F48", Offset = "0x16D0F48", VA = "0x16D0F48")]
		private void Update()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x16D0FB0", Offset = "0x16D0FB0", VA = "0x16D0FB0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x16D0FF0", Offset = "0x16D0FF0", VA = "0x16D0FF0")]
		private RuntimeContext CreateRuntimeContext()
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x16D0564", Offset = "0x16D0564", VA = "0x16D0564")]
		private Analog CreateAnalogInstance()
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x16D1204", Offset = "0x16D1204", VA = "0x16D1204")]
		private string GetDeviceIdentifierAsString(string deviceIdentifierName)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x16D14A0", Offset = "0x16D14A0", VA = "0x16D14A0")]
		private void DeployInstallLog()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x16D0610", Offset = "0x16D0610", VA = "0x16D0610")]
		private void FetchAsyncIdentifiersIfNecessary()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x16D16A0", Offset = "0x16D16A0", VA = "0x16D16A0")]
		private Action<Dictionary<string, object>> OnIdentifiersFetched()
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x16D1718", Offset = "0x16D1718", VA = "0x16D1718")]
		private void OnInitialized()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x16D1744", Offset = "0x16D1744", VA = "0x16D1744")]
		public AnalogAnalytics()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x16D1794", Offset = "0x16D1794", VA = "0x16D1794")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815710", Offset = "0x815710")]
		private void _003COnIdentifiersFetched_003Eb__25_0(Dictionary<string, object> dict)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x16D1850", Offset = "0x16D1850", VA = "0x16D1850")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815720", Offset = "0x815720")]
		private void _003COnIdentifiersFetched_003Eb__25_1(string adjustData)
		{
		}
	}
}
