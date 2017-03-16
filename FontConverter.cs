using System;
using System.Diagnostics;

namespace Converters
{
	// Token: 0x02000007 RID: 7
	public class FontConverter
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002220 File Offset: 0x00000620
		[DebuggerNonUserCode]
		public FontConverter()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000025A8 File Offset: 0x000009A8
		public static string AbcToUni(string sString)
		{
			return FontConverter.StringToString("¸µ¶·¹¨¾»¼½Æ©ÊÇÈÉËÐÌÎÏÑªÕÒÓÔÖÝ×ØÜÞãßáâä«èåæçé¬íêëìîóïñòô­øõö÷ùýúûüþ®¸µ¶·¹¡¡¡¡¡¡¢¢¢¢¢¢ÐÌÎÏÑ££££££Ý×ØÜÞãßáâä¤¤¤¤¤¤¥¥¥¥¥¥óïñòô¦¦¦¦¦¦ýúûüþ§", "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ", sString);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000022BC File Offset: 0x000006BC
		public static string AbcToVni(string sString)
		{
			string text = "";
			int arg_11_0 = 1;
			int num = Strings.Len(sString);
			int num2 = arg_11_0;
			checked
			{
				while (true)
				{
					int arg_80_0 = num2;
					int num3 = num;
					if (arg_80_0 > num3)
					{
						break;
					}
					string text2 = Strings.Mid(sString, num2, 1);
					int num4 = Strings.InStr("¸µ¶·¹¨¾»¼½Æ©ÊÇÈÉËÐÌÎÏÑªÕÒÓÔÖÝ×ØÜÞãßáâä«èåæçé¬íêëìîóïñòô­øõö÷ùýúûüþ®¸µ¶·¹¡¡¡¡¡¡¢¢¢¢¢¢ÐÌÎÏÑ££££££Ý×ØÜÞãßáâä¤¤¤¤¤¤¥¥¥¥¥¥óïñòô¦¦¦¦¦¦ýúûüþ§", text2, CompareMethod.Binary);
					bool flag = num4 <= 0;
					if (flag)
					{
						text += text2;
					}
					else
					{
						text += Strings.Trim(Strings.Mid("aaaaaaaaaaaaaaaaaeeeeeeeeeee     ooooooooooo ôôôôôuuuuu öööööyyyy  AAAAAAAAAAAAAAAAAEEEEEEEEEEE     OOOOOOOOOOO ÔÔÔÔÔUUUUU ÖÖÖÖÖYYYY  ", num4, 1));
						text += Strings.Mid("ùøûõïêéèúüëâáàåãäùøûõïâáàåãäíìæóòùøûõïâáàåãäôùøûõïùøûõïöùøûõïùøûõîñÙØÛÕÏÊÉÈÚÜËÂÁÀÅÃÄÙØÛÕÏÂÁÀÅÃÄÍÌÆÓÒÙØÛÕÏÂÁÀÅÃÄÔÙØÛÕÏÙØÛÕÏÖÙØÛÕÏÙØÛÕÎÑ", num4, 1);
					}
					num2++;
				}
				return text;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002638 File Offset: 0x00000A38
		public static string ClearAccent(string st)
		{
			string text = "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ";
			string text2 = "aaaaaaaaaaaaaaaaaeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuyyyyydAAAAAAAAAAAAAAAAAEEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOOOUUUUUUUUUUUYYYYYD";
			string text3 = "";
			int i = 0;
			int length = st.Length;
			checked
			{
				while (i < length)
				{
					char value = st[i];
					bool flag = text.Contains(Conversions.ToString(value));
					if (flag)
					{
						text3 += Conversions.ToString(text2[text.IndexOf(value)]);
					}
					else
					{
						text3 += Conversions.ToString(value);
					}
					i++;
				}
				return text3;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000025C8 File Offset: 0x000009C8
		private static string StringToString(string Vowel1, string Vowel2, string st)
		{
			string text = "";
			int arg_10_0 = 1;
			int num = Strings.Len(st);
			int num2 = arg_10_0;
			checked
			{
				while (true)
				{
					int arg_59_0 = num2;
					int num3 = num;
					if (arg_59_0 > num3)
					{
						break;
					}
					string text2 = Strings.Mid(st, num2, 1);
					int num4 = Strings.InStr(Vowel1, text2, CompareMethod.Binary);
					bool flag = num4 <= 0;
					if (flag)
					{
						text += text2;
					}
					else
					{
						text += Strings.Mid(Vowel2, num4, 1);
					}
					num2++;
				}
				return text;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002588 File Offset: 0x00000988
		public static string UniToAbc(string sString)
		{
			return FontConverter.StringToString("áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ", "¸µ¶·¹¨¾»¼½Æ©ÊÇÈÉËÐÌÎÏÑªÕÒÓÔÖÝ×ØÜÞãßáâä«èåæçé¬íêëìîóïñòô­øõö÷ùýúûüþ®¸µ¶·¹¡¡¡¡¡¡¢¢¢¢¢¢ÐÌÎÏÑ££££££Ý×ØÜÞãßáâä¤¤¤¤¤¤¥¥¥¥¥¥óïñòô¦¦¦¦¦¦ýúûüþ§", sString);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000222C File Offset: 0x0000062C
		public static string UniToVni(string sString)
		{
			string text = "";
			int arg_10_0 = 1;
			int num = Strings.Len(sString);
			int num2 = arg_10_0;
			checked
			{
				while (true)
				{
					int arg_79_0 = num2;
					int num3 = num;
					if (arg_79_0 > num3)
					{
						break;
					}
					string text2 = Strings.Mid(sString, num2, 1);
					int num4 = Strings.InStr("áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ", text2, CompareMethod.Binary);
					bool flag = num4 <= 0;
					if (flag)
					{
						text += text2;
					}
					else
					{
						text += Strings.Trim(Strings.Mid("aaaaaaaaaaaaaaaaaeeeeeeeeeee     ooooooooooo ôôôôôuuuuu öööööyyyy  AAAAAAAAAAAAAAAAAEEEEEEEEEEE     OOOOOOOOOOO ÔÔÔÔÔUUUUU ÖÖÖÖÖYYYY  ", num4, 1));
						text += Strings.Mid("ùøûõïêéèúüëâáàåãäùøûõïâáàåãäíìæóòùøûõïâáàåãäôùøûõïùøûõïöùøûõïùøûõîñÙØÛÕÏÊÉÈÚÜËÂÁÀÅÃÄÙØÛÕÏÂÁÀÅÃÄÍÌÆÓÒÙØÛÕÏÂÁÀÅÃÄÔÙØÛÕÏÙØÛÕÏÖÙØÛÕÏÙØÛÕÎÑ", num4, 1);
					}
					num2++;
				}
				return text;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002350 File Offset: 0x00000750
		public static string VniToAbc(string sString)
		{
			string text = "";
			int num = Strings.Len(sString);
			checked
			{
				while (true)
				{
					int arg_104_0 = num;
					int num2 = 1;
					if (arg_104_0 < num2)
					{
						break;
					}
					string text2 = Strings.Mid(sString, num, 1);
					int num3 = Strings.InStr("ùøûõïêéèúüëâáàåãäùøûõïâáàåãäíìæóòùøûõïâáàåãäôùøûõïùøûõïöùøûõïùøûõîñÙØÛÕÏÊÉÈÚÜËÂÁÀÅÃÄÙØÛÕÏÂÁÀÅÃÄÍÌÆÓÒÙØÛÕÏÂÁÀÅÃÄÔÙØÛÕÏÙØÛÕÏÖÙØÛÕÏÙØÛÕÎÑ", text2, CompareMethod.Binary);
					bool flag = num3 <= 0;
					if (flag)
					{
						text = text2 + text;
					}
					else
					{
						while (!(Operators.CompareString(text2, Strings.Mid("ùøûõïêéèúüëâáàåãäùøûõïâáàåãäíìæóòùøûõïâáàåãäôùøûõïùøûõïöùøûõïùøûõîñÙØÛÕÏÊÉÈÚÜËÂÁÀÅÃÄÙØÛÕÏÂÁÀÅÃÄÍÌÆÓÒÙØÛÕÏÂÁÀÅÃÄÔÙØÛÕÏÙØÛÕÏÖÙØÛÕÏÙØÛÕÎÑ", num3, 1), false) == 0 & (Operators.CompareString(Strings.Trim(Strings.Mid("aaaaaaaaaaaaaaaaaeeeeeeeeeee     ooooooooooo ôôôôôuuuuu öööööyyyy  AAAAAAAAAAAAAAAAAEEEEEEEEEEE     OOOOOOOOOOO ÔÔÔÔÔUUUUU ÖÖÖÖÖYYYY  ", num3, 1)), Strings.Mid(sString, num - 1, 1), false) == 0 | Operators.CompareString(Strings.Mid("aaaaaaaaaaaaaaaaaeeeeeeeeeee     ooooooooooo ôôôôôuuuuu öööööyyyy  AAAAAAAAAAAAAAAAAEEEEEEEEEEE     OOOOOOOOOOO ÔÔÔÔÔUUUUU ÖÖÖÖÖYYYY  ", num3, 1), " ", false) == 0)))
						{
							num3 = Strings.InStr(Strings.Mid("ùøûõïêéèúüëâáàåãäùøûõïâáàåãäíìæóòùøûõïâáàåãäôùøûõïùøûõïöùøûõïùøûõîñÙØÛÕÏÊÉÈÚÜËÂÁÀÅÃÄÙØÛÕÏÂÁÀÅÃÄÍÌÆÓÒÙØÛÕÏÂÁÀÅÃÄÔÙØÛÕÏÙØÛÕÏÖÙØÛÕÏÙØÛÕÎÑ", num3 + 1), text2, CompareMethod.Binary) + num3;
						}
						flag = (Operators.CompareString(Strings.Mid("aaaaaaaaaaaaaaaaaeeeeeeeeeee     ooooooooooo ôôôôôuuuuu öööööyyyy  AAAAAAAAAAAAAAAAAEEEEEEEEEEE     OOOOOOOOOOO ÔÔÔÔÔUUUUU ÖÖÖÖÖYYYY  ", num3, 1), " ", false) != 0);
						if (flag)
						{
							num--;
						}
						text = Strings.Mid("¸µ¶·¹¨¾»¼½Æ©ÊÇÈÉËÐÌÎÏÑªÕÒÓÔÖÝ×ØÜÞãßáâä«èåæçé¬íêëìîóïñòô­øõö÷ùýúûüþ®¸µ¶·¹¡¡¡¡¡¡¢¢¢¢¢¢ÐÌÎÏÑ££££££Ý×ØÜÞãßáâä¤¤¤¤¤¤¥¥¥¥¥¥óïñòô¦¦¦¦¦¦ýúûüþ§", num3, 1) + text;
					}
					num += -1;
				}
				return text;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000246C File Offset: 0x0000086C
		public static string VniToUni(string sString)
		{
			string text = "";
			int num = Strings.Len(sString);
			checked
			{
				while (true)
				{
					int arg_104_0 = num;
					int num2 = 1;
					if (arg_104_0 < num2)
					{
						break;
					}
					string text2 = Strings.Mid(sString, num, 1);
					int num3 = Strings.InStr("ùøûõïêéèúüëâáàåãäùøûõïâáàåãäíìæóòùøûõïâáàåãäôùøûõïùøûõïöùøûõïùøûõîñÙØÛÕÏÊÉÈÚÜËÂÁÀÅÃÄÙØÛÕÏÂÁÀÅÃÄÍÌÆÓÒÙØÛÕÏÂÁÀÅÃÄÔÙØÛÕÏÙØÛÕÏÖÙØÛÕÏÙØÛÕÎÑ", text2, CompareMethod.Binary);
					bool flag = num3 <= 0;
					if (flag)
					{
						text = text2 + text;
					}
					else
					{
						while (!(Operators.CompareString(text2, Strings.Mid("ùøûõïêéèúüëâáàåãäùøûõïâáàåãäíìæóòùøûõïâáàåãäôùøûõïùøûõïöùøûõïùøûõîñÙØÛÕÏÊÉÈÚÜËÂÁÀÅÃÄÙØÛÕÏÂÁÀÅÃÄÍÌÆÓÒÙØÛÕÏÂÁÀÅÃÄÔÙØÛÕÏÙØÛÕÏÖÙØÛÕÏÙØÛÕÎÑ", num3, 1), false) == 0 & (Operators.CompareString(Strings.Trim(Strings.Mid("aaaaaaaaaaaaaaaaaeeeeeeeeeee     ooooooooooo ôôôôôuuuuu öööööyyyy  AAAAAAAAAAAAAAAAAEEEEEEEEEEE     OOOOOOOOOOO ÔÔÔÔÔUUUUU ÖÖÖÖÖYYYY  ", num3, 1)), Strings.Mid(sString, num - 1, 1), false) == 0 | Operators.CompareString(Strings.Mid("aaaaaaaaaaaaaaaaaeeeeeeeeeee     ooooooooooo ôôôôôuuuuu öööööyyyy  AAAAAAAAAAAAAAAAAEEEEEEEEEEE     OOOOOOOOOOO ÔÔÔÔÔUUUUU ÖÖÖÖÖYYYY  ", num3, 1), " ", false) == 0)))
						{
							num3 = Strings.InStr(Strings.Mid("ùøûõïêéèúüëâáàåãäùøûõïâáàåãäíìæóòùøûõïâáàåãäôùøûõïùøûõïöùøûõïùøûõîñÙØÛÕÏÊÉÈÚÜËÂÁÀÅÃÄÙØÛÕÏÂÁÀÅÃÄÍÌÆÓÒÙØÛÕÏÂÁÀÅÃÄÔÙØÛÕÏÙØÛÕÏÖÙØÛÕÏÙØÛÕÎÑ", num3 + 1), text2, CompareMethod.Binary) + num3;
						}
						flag = (Operators.CompareString(Strings.Mid("aaaaaaaaaaaaaaaaaeeeeeeeeeee     ooooooooooo ôôôôôuuuuu öööööyyyy  AAAAAAAAAAAAAAAAAEEEEEEEEEEE     OOOOOOOOOOO ÔÔÔÔÔUUUUU ÖÖÖÖÖYYYY  ", num3, 1), " ", false) != 0);
						if (flag)
						{
							num--;
						}
						text = Strings.Mid("áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ", num3, 1) + text;
					}
					num += -1;
				}
				return text;
			}
		}

		// Token: 0x04000009 RID: 9
		public const string sAbc = "¸µ¶·¹¨¾»¼½Æ©ÊÇÈÉËÐÌÎÏÑªÕÒÓÔÖÝ×ØÜÞãßáâä«èåæçé¬íêëìîóïñòô­øõö÷ùýúûüþ®¸µ¶·¹¡¡¡¡¡¡¢¢¢¢¢¢ÐÌÎÏÑ££££££Ý×ØÜÞãßáâä¤¤¤¤¤¤¥¥¥¥¥¥óïñòô¦¦¦¦¦¦ýúûüþ§";

		// Token: 0x04000008 RID: 8
		public const string sUni = "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ";

		// Token: 0x04000006 RID: 6
		public const string sVni = "ùøûõïêéèúüëâáàåãäùøûõïâáàåãäíìæóòùøûõïâáàåãäôùøûõïùøûõïöùøûõïùøûõîñÙØÛÕÏÊÉÈÚÜËÂÁÀÅÃÄÙØÛÕÏÂÁÀÅÃÄÍÌÆÓÒÙØÛÕÏÂÁÀÅÃÄÔÙØÛÕÏÙØÛÕÏÖÙØÛÕÏÙØÛÕÎÑ";

		// Token: 0x04000007 RID: 7
		public const string sVnigoc = "aaaaaaaaaaaaaaaaaeeeeeeeeeee     ooooooooooo ôôôôôuuuuu öööööyyyy  AAAAAAAAAAAAAAAAAEEEEEEEEEEE     OOOOOOOOOOO ÔÔÔÔÔUUUUU ÖÖÖÖÖYYYY  ";
	}
}
