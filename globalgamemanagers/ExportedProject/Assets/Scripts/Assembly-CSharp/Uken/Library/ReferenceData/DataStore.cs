using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x200046B")]
	public class DataStore<T> : BaseDataStore where T : StoreModel, new()
	{
		[Token(Token = "0x4001475")]
		[FieldOffset(Offset = "0x0")]
		private T m_DataStore;

		[Token(Token = "0x170005CF")]
		public T Data
		{
			[Token(Token = "0x60020D9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60020DA")]
		public DataStore()
		{
		}

		[Token(Token = "0x60020DB")]
		public override void RegisterController(DataStoreController parentController)
		{
		}

		[Token(Token = "0x60020DC")]
		public override StoreMetaData GetMetadata()
		{
			return default(StoreMetaData);
		}

		[Token(Token = "0x60020DD")]
		protected override bool LoadData(string rawData, bool isPartialResult, DataSource dataSource)
		{
			return default(bool);
		}

		[Token(Token = "0x60020DE")]
		public override void SaveData(string savePath)
		{
		}

		[Token(Token = "0x60020DF")]
		public override string GetJSON()
		{
			return null;
		}

		[Token(Token = "0x60020E0")]
		public override StoreModel GetBaseStoreData()
		{
			return null;
		}

		[Token(Token = "0x60020E1")]
		protected bool OnDatastoreUpdated(T newDataStore, DataSource dataSource)
		{
			return default(bool);
		}
	}
}
