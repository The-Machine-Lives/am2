using Il2CppDummyDll;

namespace Com.Uken.Analog
{
	[Token(Token = "0x2000051")]
	public static class EventValidator
	{
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x16D625C", Offset = "0x16D625C", VA = "0x16D625C")]
		public static bool IsBaseValid(BaseEvent anEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x16D4CF4", Offset = "0x16D4CF4", VA = "0x16D4CF4")]
		public static bool IsApplicationInstallValid(ApplicationInstall anEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x16D5C34", Offset = "0x16D5C34", VA = "0x16D5C34")]
		public static bool IsApplicationUpdateUserIdValid(ApplicationUpdateUserId anEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x16D5480", Offset = "0x16D5480", VA = "0x16D5480")]
		public static bool IsApplicationTagInstallSourceValid(ApplicationTagInstallSource anEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x16D5068", Offset = "0x16D5068", VA = "0x16D5068")]
		public static bool IsApplicationOpenValid(ApplicationOpen anEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x16D7C04", Offset = "0x16D7C04", VA = "0x16D7C04")]
		public static bool IsIAPRequestValid(IAPRequest anEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x16D7DE0", Offset = "0x16D7DE0", VA = "0x16D7DE0")]
		public static bool IsIAPResponseValid(IAPResponse anEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x16CE4F4", Offset = "0x16CE4F4", VA = "0x16CE4F4")]
		public static bool IsAdRequestValid(AdRequest anEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x16CEBF0", Offset = "0x16CEBF0", VA = "0x16CEBF0")]
		public static bool IsAdResponseValid(AdResponse anEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x16D6978", Offset = "0x16D6978", VA = "0x16D6978")]
		public static bool IsCurrencyTransactionValid(CurrencyTransaction anEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x16D7F8C", Offset = "0x16D7F8C", VA = "0x16D7F8C")]
		public static bool IsItemTransactionValid(ItemTransaction anEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x16CE01C", Offset = "0x16CE01C", VA = "0x16CE01C")]
		public static bool IsABJoinValid(ABJoin anEvent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x16D79FC", Offset = "0x16D79FC", VA = "0x16D79FC")]
		public static bool ValidateLanguage(string language, LogValidation validation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x16D7764", Offset = "0x16D7764", VA = "0x16D7764")]
		public static bool ValidatePositiveNumber(long number, LogValidation validation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x16D76E4", Offset = "0x16D76E4", VA = "0x16D76E4")]
		public static bool ValidatePositiveNumber(int number, LogValidation validation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x16D7D64", Offset = "0x16D7D64", VA = "0x16D7D64")]
		public static bool ValidatePositiveNumber(double number, LogValidation validation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x16D77EC", Offset = "0x16D77EC", VA = "0x16D77EC")]
		public static bool ValidateEventTypeOrName(string str, LogValidation validation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x16D7B80", Offset = "0x16D7B80", VA = "0x16D7B80")]
		public static bool ValidateStringNotEmpty(string value, LogValidation validation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x16D8130", Offset = "0x16D8130", VA = "0x16D8130")]
		public static string AsString(EventInfo eventInfo, string key)
		{
			return null;
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x16D81E8", Offset = "0x16D81E8", VA = "0x16D81E8")]
		public static int AsInt(EventInfo eventInfo, string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x16D82C0", Offset = "0x16D82C0", VA = "0x16D82C0")]
		public static double AsDouble(EventInfo eventInfo, string key)
		{
			return default(double);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x16D80EC", Offset = "0x16D80EC", VA = "0x16D80EC")]
		private static bool IsAlpha(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x16D8108", Offset = "0x16D8108", VA = "0x16D8108")]
		private static bool IsLowerAlpha(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x16D83D4", Offset = "0x16D83D4", VA = "0x16D83D4")]
		private static bool IsUpperAlpha(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x16D811C", Offset = "0x16D811C", VA = "0x16D811C")]
		private static bool IsNumbericalDigit(char c)
		{
			return default(bool);
		}
	}
}
