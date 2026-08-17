using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200050E")]
	public class Localizations : DepotController
	{
		[Token(Token = "0x40017BC")]
		[FieldOffset(Offset = "0x20")]
		private RDLocalization.LanguageKey activeLanguage;

		[Token(Token = "0x40017BD")]
		private const string mc_playerPrefsLegacyKey = "com.uken.framework.selected_culture";

		[Token(Token = "0x40017BE")]
		private const string mc_playerPrefsKey = "com.uken.framework.selected_culture_i";

		[Token(Token = "0x170006A0")]
		private DepotEntity<RDLocalization> m_localizations
		{
			[Token(Token = "0x6002695")]
			[Address(RVA = "0xA7303C", Offset = "0xA7303C", VA = "0xA7303C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002696")]
		[Address(RVA = "0xA731A4", Offset = "0xA731A4", VA = "0xA731A4")]
		public Localizations(DataStoreController controller)
		{
		}

		[Token(Token = "0x6002697")]
		[Address(RVA = "0xA731AC", Offset = "0xA731AC", VA = "0xA731AC", Slot = "5")]
		public override bool LoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6002698")]
		[Address(RVA = "0xA73278", Offset = "0xA73278", VA = "0xA73278")]
		public void SetCurrentLanguage(RDLocalization.LanguageKey langKey)
		{
		}

		[Token(Token = "0x6002699")]
		[Address(RVA = "0xA732DC", Offset = "0xA732DC", VA = "0xA732DC")]
		public string TranslateString(string reference, string fallback = "")
		{
			return null;
		}

		[Token(Token = "0x600269A")]
		[Address(RVA = "0xA73428", Offset = "0xA73428", VA = "0xA73428")]
		public string GetCultureCode()
		{
			return null;
		}

		[Token(Token = "0x600269B")]
		[Address(RVA = "0xA73490", Offset = "0xA73490", VA = "0xA73490")]
		public RDLocalization.LanguageKey GetLanguageFromCode(string cultureCode)
		{
			return default(RDLocalization.LanguageKey);
		}

		[Token(Token = "0x600269C")]
		[Address(RVA = "0xA731E0", Offset = "0xA731E0", VA = "0xA731E0")]
		private RDLocalization.LanguageKey GetCurrentLanguage()
		{
			return default(RDLocalization.LanguageKey);
		}

		[Token(Token = "0x600269D")]
		[Address(RVA = "0xA73778", Offset = "0xA73778", VA = "0xA73778")]
		private string GetSystemLanguage()
		{
			return null;
		}
	}
}
