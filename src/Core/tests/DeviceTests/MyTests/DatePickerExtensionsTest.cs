using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Maui.DeviceTests.MyCoreTests
{
	[Category(TestCategory.DatePickerCore)]
	public class DatePickerExtensionsTest
	{
		[Fact]
		public void DateTimeTest()
		{
			CalendarDatePickerExtensionsFake extensionsMock = new CalendarDatePickerExtensionsFake();
			string format = extensionsMock.ToDateFormatTest("yyyy/MM/dddd");
			Assert.Equal("{year.full}/{month.integer}/{dayofweek.full}", format);
			format = extensionsMock.ToDateFormatTest("yyyy/MM/dd");
			Assert.Equal("{year.full}/{month.integer}/{day.integer(2)}", format);
			format = extensionsMock.ToDateFormatTest("yy/MMM/dddd");
			Assert.Equal("{year.abbreviated}/{month.abbreviated}/{dayofweek.full}", format);
			format = extensionsMock.ToDateFormatTest("yyyy/MMMM/dddd");
			Assert.Equal("{year.full}/{month.full}/{dayofweek.full}", format);
			format = extensionsMock.ToDateFormatTest("dd/MM/yyyy");
			Assert.Equal("{day.integer(2)}/{month.integer}/{year.full}", format);
			format = extensionsMock.ToDateFormatTest("MM/ddd/yyyy");
			Assert.Equal("{month.integer}/{day dayofweek.abbreviated}/{year.full}", format);

			format = extensionsMock.ToDateFormatTest("MM/dd");
			Assert.Equal("{month.integer}/{day.integer(2)}", format);
			format = extensionsMock.ToDateFormatTest("yy/MM");
			Assert.Equal("{year.abbreviated}/{month.integer}", format);
			format = extensionsMock.ToDateFormatTest("yyyy/ddd");
			Assert.Equal("{year.full}/{day dayofweek.abbreviated}", format);

			format = extensionsMock.ToDateFormatTest("yyyy");
			Assert.Equal("{year.full}", format);
			format = extensionsMock.ToDateFormatTest("MM");
			Assert.Equal("{month.integer}", format);
			format = extensionsMock.ToDateFormatTest("dddd");
			Assert.Equal("{dayofweek.full}", format);
		}

		[Fact]
		public void DayDatePickerTest()
		{
			CalendarDatePickerExtensionsFake extensionsMock = new CalendarDatePickerExtensionsFake();
			string format = extensionsMock.GetDayFormatTest("ddd");
			Assert.Equal("{day dayofweek.abbreviated}", format);
			format = extensionsMock.GetDayFormatTest("dddd");
			Assert.Equal("{dayofweek.full}", format);
			format = extensionsMock.GetDayFormatTest("dd");
			Assert.Equal("{day.integer(2)}", format);
			format = extensionsMock.GetDayFormatTest("d");
			Assert.Equal("{day.integer}", format);
		}

		[Fact]
		public void MonthDatePickerTest()
		{
			CalendarDatePickerExtensionsFake extensionsMock = new CalendarDatePickerExtensionsFake();
			string format = extensionsMock.GetMonthFormatTest("MM");
			Assert.Equal("{month.integer}", format);
			format = extensionsMock.GetMonthFormatTest("MMM");
			Assert.Equal("{month.abbreviated}", format);
			format = extensionsMock.GetMonthFormatTest("MMMM");
			Assert.Equal("{month.full}", format);
		}

		[Fact]
		public void YearDatePickerTest()
		{
			CalendarDatePickerExtensionsFake extensionsMock = new CalendarDatePickerExtensionsFake();
			string format = extensionsMock.GetYearFormatTest("yy");
			Assert.Equal("{year.abbreviated}", format);
			format = extensionsMock.GetYearFormatTest("yyyy");
			Assert.Equal("{year.full}", format);
		}

		[Fact]
		public void DefaultDatePickerTest()
		{
			CalendarDatePickerExtensionsFake extensionsMock = new CalendarDatePickerExtensionsFake();
			string format = extensionsMock.GetYearFormatTest("D");
			Assert.Equal("{year.full}", format);
			format = extensionsMock.GetDayFormatTest("D");
			Assert.Equal("{dayofweek.full}", format);
			format = extensionsMock.GetMonthFormatTest("D");
			Assert.Equal("{month.full}", format);
		}
	}
}