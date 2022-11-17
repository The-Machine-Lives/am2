using System;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Common.Api
{
	[Token(Token = "0x2000245")]
	public class Status : JavaObjWrapper, Result
	{
		[Token(Token = "0x4000CAA")]
		private const string CLASS_NAME = "com/google/android/gms/common/api/Status";

		[Token(Token = "0x17000262")]
		public static object CREATOR
		{
			[Token(Token = "0x6001062")]
			[Address(RVA = "0xA4DAA8", Offset = "0xA4DAA8", VA = "0xA4DAA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000263")]
		public static string NULL
		{
			[Token(Token = "0x6001063")]
			[Address(RVA = "0xA4DB14", Offset = "0xA4DB14", VA = "0xA4DB14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000264")]
		public static int CONTENTS_FILE_DESCRIPTOR
		{
			[Token(Token = "0x6001064")]
			[Address(RVA = "0xA4DB6C", Offset = "0xA4DB6C", VA = "0xA4DB6C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000265")]
		public static int PARCELABLE_WRITE_RETURN_VALUE
		{
			[Token(Token = "0x6001065")]
			[Address(RVA = "0xA4DBC4", Offset = "0xA4DBC4", VA = "0xA4DBC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6001061")]
		[Address(RVA = "0xA4DAA0", Offset = "0xA4DAA0", VA = "0xA4DAA0")]
		public Status(IntPtr ptr)
		{
		}

		[Token(Token = "0x6001066")]
		[Address(RVA = "0xA4DC1C", Offset = "0xA4DC1C", VA = "0xA4DC1C")]
		public Status(int arg_int_1, string arg_string_2, object arg_object_3)
		{
		}

		[Token(Token = "0x6001067")]
		[Address(RVA = "0xA4DDBC", Offset = "0xA4DDBC", VA = "0xA4DDBC")]
		public Status(int arg_int_1, string arg_string_2)
		{
		}

		[Token(Token = "0x6001068")]
		[Address(RVA = "0xA4DF10", Offset = "0xA4DF10", VA = "0xA4DF10")]
		public Status(int arg_int_1)
		{
		}

		[Token(Token = "0x6001069")]
		[Address(RVA = "0xA4E010", Offset = "0xA4E010", VA = "0xA4E010")]
		public bool equals(object arg_object_1)
		{
			return default(bool);
		}

		[Token(Token = "0x600106A")]
		[Address(RVA = "0xA4E0F4", Offset = "0xA4E0F4", VA = "0xA4E0F4")]
		public string toString()
		{
			return null;
		}

		[Token(Token = "0x600106B")]
		[Address(RVA = "0xA4E170", Offset = "0xA4E170", VA = "0xA4E170")]
		public int hashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600106C")]
		[Address(RVA = "0xA4E1EC", Offset = "0xA4E1EC", VA = "0xA4E1EC")]
		public bool isInterrupted()
		{
			return default(bool);
		}

		[Token(Token = "0x600106D")]
		[Address(RVA = "0xA4E268", Offset = "0xA4E268", VA = "0xA4E268", Slot = "5")]
		public Status getStatus()
		{
			return null;
		}

		[Token(Token = "0x600106E")]
		[Address(RVA = "0xA4E2E4", Offset = "0xA4E2E4", VA = "0xA4E2E4")]
		public bool isCanceled()
		{
			return default(bool);
		}

		[Token(Token = "0x600106F")]
		[Address(RVA = "0xA4E360", Offset = "0xA4E360", VA = "0xA4E360")]
		public int describeContents()
		{
			return default(int);
		}

		[Token(Token = "0x6001070")]
		[Address(RVA = "0xA4E3DC", Offset = "0xA4E3DC", VA = "0xA4E3DC")]
		public object getResolution()
		{
			return null;
		}

		[Token(Token = "0x6001071")]
		[Address(RVA = "0xA4E458", Offset = "0xA4E458", VA = "0xA4E458")]
		public int getStatusCode()
		{
			return default(int);
		}

		[Token(Token = "0x6001072")]
		[Address(RVA = "0xA4E4D4", Offset = "0xA4E4D4", VA = "0xA4E4D4")]
		public string getStatusMessage()
		{
			return null;
		}

		[Token(Token = "0x6001073")]
		[Address(RVA = "0xA4E550", Offset = "0xA4E550", VA = "0xA4E550")]
		public bool hasResolution()
		{
			return default(bool);
		}

		[Token(Token = "0x6001074")]
		[Address(RVA = "0xA4E5CC", Offset = "0xA4E5CC", VA = "0xA4E5CC")]
		public void startResolutionForResult(object arg_object_1, int arg_int_2)
		{
		}

		[Token(Token = "0x6001075")]
		[Address(RVA = "0xA4E71C", Offset = "0xA4E71C", VA = "0xA4E71C")]
		public void writeToParcel(object arg_object_1, int arg_int_2)
		{
		}

		[Token(Token = "0x6001076")]
		[Address(RVA = "0xA4E86C", Offset = "0xA4E86C", VA = "0xA4E86C")]
		public bool isSuccess()
		{
			return default(bool);
		}
	}
}
