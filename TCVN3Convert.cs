using System;
using System.Collections.Generic;

namespace Utils
{
	// Token: 0x0200000A RID: 10
	public class TCVN3Converter : IFontConverter
	{
		// Token: 0x0600002C RID: 44 RVA: 0x0000476C File Offset: 0x0000296C
		static TCVN3Converter()
		{
			TCVN3Converter.tcvnchars = new char[]
			{
				'µ',
				'¸',
				'¶',
				'·',
				'¹',
				'¨',
				'»',
				'¾',
				'¼',
				'½',
				'Æ',
				'©',
				'Ç',
				'Ê',
				'È',
				'É',
				'Ë',
				'®',
				'Ì',
				'Ð',
				'Î',
				'Ï',
				'Ñ',
				'ª',
				'Ò',
				'Õ',
				'Ó',
				'Ô',
				'Ö',
				'×',
				'Ý',
				'Ø',
				'Ü',
				'Þ',
				'ß',
				'ã',
				'á',
				'â',
				'ä',
				'«',
				'å',
				'è',
				'æ',
				'ç',
				'é',
				'¬',
				'ê',
				'í',
				'ë',
				'ì',
				'î',
				'ï',
				'ó',
				'ñ',
				'ò',
				'ô',
				'­',
				'õ',
				'ø',
				'ö',
				'÷',
				'ù',
				'ú',
				'ý',
				'û',
				'ü',
				'þ',
				'¡',
				'¢',
				'§',
				'£',
				'¤',
				'¥',
				'¦'
			};
			TCVN3Converter.unichars = new char[]
			{
				'à',
				'á',
				'ả',
				'ã',
				'ạ',
				'ă',
				'ằ',
				'ắ',
				'ẳ',
				'ẵ',
				'ặ',
				'â',
				'ầ',
				'ấ',
				'ẩ',
				'ẫ',
				'ậ',
				'đ',
				'è',
				'é',
				'ẻ',
				'ẽ',
				'ẹ',
				'ê',
				'ề',
				'ế',
				'ể',
				'ễ',
				'ệ',
				'ì',
				'í',
				'ỉ',
				'ĩ',
				'ị',
				'ò',
				'ó',
				'ỏ',
				'õ',
				'ọ',
				'ô',
				'ồ',
				'ố',
				'ổ',
				'ỗ',
				'ộ',
				'ơ',
				'ờ',
				'ớ',
				'ở',
				'ỡ',
				'ợ',
				'ù',
				'ú',
				'ủ',
				'ũ',
				'ụ',
				'ư',
				'ừ',
				'ứ',
				'ử',
				'ữ',
				'ự',
				'ỳ',
				'ý',
				'ỷ',
				'ỹ',
				'ỵ',
				'Ă',
				'Â',
				'Đ',
				'Ê',
				'Ô',
				'Ơ',
				'Ư'
			};
			TCVN3Converter._converter = new TCVN3Converter();
			TCVN3Converter.unicodeConvertTable = new char[256];
			int num = TCVN3Converter.tcvnchars.Length;
			for (int i = 0; i < 256; i++)
			{
				TCVN3Converter.unicodeConvertTable[i] = (char)i;
			}
			for (int i = 0; i < num; i++)
			{
				TCVN3Converter.unicodeConvertTable[(int)TCVN3Converter.tcvnchars[i]] = TCVN3Converter.unichars[i];
			}
			TCVN3Converter.tcvnConvertTable = new Dictionary<char, char>();
			for (int i = 0; i < num; i++)
			{
				TCVN3Converter.tcvnConvertTable.Add(TCVN3Converter.unichars[i], TCVN3Converter.tcvnchars[i]);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004762 File Offset: 0x00002962
		private TCVN3Converter()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000048A8 File Offset: 0x00002AA8
		public string FromUnicode(string value)
		{
			char[] array = value.ToCharArray();
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				array[i] = (TCVN3Converter.tcvnConvertTable.ContainsKey(array[i]) ? TCVN3Converter.tcvnConvertTable[array[i]] : array[i]);
			}
			return new string(array);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004840 File Offset: 0x00002A40
		public static IFontConverter GetInstance()
		{
			return TCVN3Converter._converter;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004858 File Offset: 0x00002A58
		public string ToUnicode(string value)
		{
			char[] array = value.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = array[i] < 'Ā';
				if (flag)
				{
					array[i] = TCVN3Converter.unicodeConvertTable[(int)array[i]];
				}
			}
			return new string(array);
		}

		// Token: 0x0400006D RID: 109
		private static readonly char[] tcvnchars;

		// Token: 0x04000070 RID: 112
		private static readonly Dictionary<char, char> tcvnConvertTable;

		// Token: 0x0400006E RID: 110
		private static readonly char[] unichars;

		// Token: 0x0400006F RID: 111
		private static readonly char[] unicodeConvertTable;

		// Token: 0x04000071 RID: 113
		private static readonly IFontConverter _converter;
	}
}
