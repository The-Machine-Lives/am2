using Il2CppDummyDll;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000463")]
	public interface IBaseDepotEntity
	{
		[Token(Token = "0x170005CC")]
		string ClassName
		{
			[Token(Token = "0x60020BD")]
			get;
		}

		[Token(Token = "0x60020BC")]
		BaseEntityDocument GetBaseEntityDocument(string reference);

		[Token(Token = "0x60020BE")]
		void SetDataSource(DataSource dataSource);

		[Token(Token = "0x60020BF")]
		void PostProcessData();
	}
}
