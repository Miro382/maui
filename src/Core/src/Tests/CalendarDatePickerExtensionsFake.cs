using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Maui
{
	public class CalendarDatePickerExtensionsFake
	{

		public string ToDateFormatTest(string format)
		{
#if WINDOWS
			return format.ToDateFormat();
#else
			return "";
#endif

		}

		public string GetDayFormatTest(string format)
		{
#if WINDOWS
			return CalendarDatePickerExtensions.GetDayFormat(format);
#else
			return "";
#endif
		}

		public string GetMonthFormatTest(string format)
		{
#if WINDOWS
			return CalendarDatePickerExtensions.GetMonthFormat(format);
#else
			return "";
#endif
		}

		public string GetYearFormatTest(string format)
		{
#if WINDOWS
			return CalendarDatePickerExtensions.GetYearFormat(format);
#else
			return "";
#endif
		}


	}
}
