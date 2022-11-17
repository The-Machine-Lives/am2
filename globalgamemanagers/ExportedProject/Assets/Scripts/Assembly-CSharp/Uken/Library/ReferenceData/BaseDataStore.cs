using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.ReferenceData.DataProviders;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x200046C")]
	public abstract class BaseDataStore : UkenController
	{
		[Token(Token = "0x2000811")]
		public delegate Dictionary<string, string> GetTestGroupsFunc();

		[Token(Token = "0x2000812")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821298", Offset = "0x821298")]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			[Token(Token = "0x4002342")]
			[FieldOffset(Offset = "0x10")]
			public BaseDataStore _003C_003E4__this;

			[Token(Token = "0x4002343")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> onDataLoaded;

			[Token(Token = "0x60032DA")]
			[Address(RVA = "0xB33B40", Offset = "0xB33B40", VA = "0xB33B40")]
			public _003C_003Ec__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60032DB")]
			[Address(RVA = "0xB340F0", Offset = "0xB340F0", VA = "0xB340F0")]
			internal void _003CQueryNetwork_003Eb__0(bool success, BaseProvider provider, bool isPartialResult)
			{
			}
		}

		[Token(Token = "0x2000813")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8212A8", Offset = "0x8212A8")]
		private sealed class _003C_003Ec__DisplayClass26_0
		{
			[Token(Token = "0x4002344")]
			[FieldOffset(Offset = "0x10")]
			public BaseDataStore _003C_003E4__this;

			[Token(Token = "0x4002345")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> onDataLoaded;

			[Token(Token = "0x60032DC")]
			[Address(RVA = "0xB33CAC", Offset = "0xB33CAC", VA = "0xB33CAC")]
			public _003C_003Ec__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60032DD")]
			[Address(RVA = "0xB34238", Offset = "0xB34238", VA = "0xB34238")]
			internal void _003CLoadDefaults_003Eb__0(bool success, BaseProvider provider, bool isPartialResult)
			{
			}
		}

		[Token(Token = "0x2000814")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8212B8", Offset = "0x8212B8")]
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			[Token(Token = "0x4002346")]
			[FieldOffset(Offset = "0x10")]
			public BaseDataStore _003C_003E4__this;

			[Token(Token = "0x4002347")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool, BaseProvider> onComplete;

			[Token(Token = "0x60032DE")]
			[Address(RVA = "0xB33E78", Offset = "0xB33E78", VA = "0xB33E78")]
			public _003C_003Ec__DisplayClass28_0()
			{
			}

			[Token(Token = "0x60032DF")]
			[Address(RVA = "0xB3435C", Offset = "0xB3435C", VA = "0xB3435C")]
			internal void _003CLoadProviderData_003Eb__0(bool success, BaseProvider provider, bool isPartialResult)
			{
			}
		}

		[Token(Token = "0x4001476")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string FileName_ReferenceData;

		[Token(Token = "0x4001477")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string FilePath_ReferenceData;

		[Token(Token = "0x4001478")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string FileName_UnitTestReferenceData;

		[Token(Token = "0x4001479")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string FilePath_UnitTestReferenceData;

		[Token(Token = "0x400147A")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string FolderName_RefdataDeprecated;

		[Token(Token = "0x400147B")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string VERSION_FILE;

		[Token(Token = "0x400147C")]
		[FieldOffset(Offset = "0x30")]
		public static readonly int VERSIONSTAMP_UNSET;

		[Token(Token = "0x400147D")]
		[FieldOffset(Offset = "0x14")]
		public int versionStamp;

		[Token(Token = "0x400147E")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E758", Offset = "0x82E758")]
		private DataStoreController _003Cm_parentController_003Ek__BackingField;

		[Token(Token = "0x400147F")]
		[FieldOffset(Offset = "0x20")]
		protected GetTestGroupsFunc m_getTestGroups;

		[Token(Token = "0x4001480")]
		[FieldOffset(Offset = "0x28")]
		private BaseProvider m_defaultProvider;

		[Token(Token = "0x4001481")]
		[FieldOffset(Offset = "0x30")]
		private BaseProvider m_networkProvider;

		[Token(Token = "0x4001482")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, BaseProvider> m_dataProviders;

		[Token(Token = "0x4001483")]
		[FieldOffset(Offset = "0x40")]
		private int m_updatesInProgress;

		[Token(Token = "0x170005D0")]
		public DataStoreController m_parentController
		{
			[Token(Token = "0x60020E2")]
			[Address(RVA = "0xB337C0", Offset = "0xB337C0", VA = "0xB337C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839374", Offset = "0x839374")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020E3")]
			[Address(RVA = "0xB337C8", Offset = "0xB337C8", VA = "0xB337C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839384", Offset = "0x839384")]
			private set
			{
			}
		}

		[Token(Token = "0x60020E4")]
		[Address(RVA = "0xB337D0", Offset = "0xB337D0", VA = "0xB337D0")]
		public BaseDataStore()
		{
		}

		[Token(Token = "0x60020E5")]
		[Address(RVA = "0xB33870", Offset = "0xB33870", VA = "0xB33870", Slot = "10")]
		public virtual void RegisterController(DataStoreController parentController)
		{
		}

		[Token(Token = "0x60020E6")]
		[Address(RVA = "0xB33878", Offset = "0xB33878", VA = "0xB33878")]
		public void SetDefaultProvider(BaseProvider dataProvider)
		{
		}

		[Token(Token = "0x60020E7")]
		[Address(RVA = "0xB338AC", Offset = "0xB338AC", VA = "0xB338AC")]
		public void SetNetworkProvider(BaseProvider networkProvider)
		{
		}

		[Token(Token = "0x60020E8")]
		public abstract StoreModel GetBaseStoreData();

		[Token(Token = "0x60020E9")]
		[Address(RVA = "0xB338E0", Offset = "0xB338E0", VA = "0xB338E0")]
		public int AddDataProvider(BaseProvider dataProvider, int providerID = -1)
		{
			return default(int);
		}

		[Token(Token = "0x60020EA")]
		public abstract StoreMetaData GetMetadata();

		[Token(Token = "0x60020EB")]
		[Address(RVA = "0xB33A14", Offset = "0xB33A14", VA = "0xB33A14")]
		public bool QueryNetwork(Action<bool> onDataLoaded)
		{
			return default(bool);
		}

		[Token(Token = "0x60020EC")]
		[Address(RVA = "0xB33B68", Offset = "0xB33B68", VA = "0xB33B68")]
		public bool LoadDefaults(Action<bool> onDataLoaded, bool asyncLoad)
		{
			return default(bool);
		}

		[Token(Token = "0x60020ED")]
		[Address(RVA = "0xB33CB4", Offset = "0xB33CB4", VA = "0xB33CB4")]
		public bool AreUpdatesInProgress()
		{
			return default(bool);
		}

		[Token(Token = "0x60020EE")]
		[Address(RVA = "0xB33CC4", Offset = "0xB33CC4", VA = "0xB33CC4")]
		public bool LoadProviderData(int providerID, Action<bool, BaseProvider> onComplete, bool async = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60020EF")]
		protected abstract bool LoadData(string rawData, bool isPartialResult, DataSource dataSource);

		[Token(Token = "0x60020F0")]
		[Address(RVA = "0xB33E80", Offset = "0xB33E80", VA = "0xB33E80", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60020F1")]
		[Address(RVA = "0xB33E88", Offset = "0xB33E88", VA = "0xB33E88", Slot = "5")]
		public override bool LoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x60020F2")]
		[Address(RVA = "0xB33F44", Offset = "0xB33F44", VA = "0xB33F44")]
		protected bool ValidateJsonData(string rawData)
		{
			return default(bool);
		}

		[Token(Token = "0x60020F3")]
		[Address(RVA = "0xB33F4C", Offset = "0xB33F4C", VA = "0xB33F4C", Slot = "14")]
		public virtual void SetTestGroupCallback(GetTestGroupsFunc getTestGroups)
		{
		}

		[Token(Token = "0x60020F4")]
		public abstract void SaveData(string path);

		[Token(Token = "0x60020F5")]
		public abstract string GetJSON();

		[Token(Token = "0x60020F7")]
		[Address(RVA = "0xB3405C", Offset = "0xB3405C", VA = "0xB3405C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839394", Offset = "0x839394")]
		private void _003CLoadContent_003Eb__31_0(bool success, BaseProvider provider, bool isPartialResult)
		{
		}
	}
}
