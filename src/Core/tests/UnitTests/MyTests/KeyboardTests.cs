using System.Reflection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.UnitTests;
using Xunit;
using FactAttribute = Xunit.FactAttribute;

namespace Core.UnitTests.MyTests
{
	[Category(TestCategory.Core)]
	public class KeyboardTests
	{
		[Fact]
		public void CreateKeyboardsTest()
		{
			Keyboard kb = Keyboard.Default;
			Assert.NotNull(kb);
			Assert.IsType<Keyboard>(kb);

			kb = Keyboard.Chat;
			Assert.NotNull(kb);
			Assert.IsType<ChatKeyboard>(kb);

			kb = Keyboard.Numeric;
			Assert.NotNull(kb);
			Assert.IsType<NumericKeyboard>(kb);

			kb = Keyboard.Email;
			Assert.NotNull(kb);
			Assert.IsType<EmailKeyboard>(kb);

			kb = Keyboard.Url;
			Assert.NotNull(kb);
			Assert.IsType<UrlKeyboard>(kb);

			kb = Keyboard.Plain;
			Assert.NotNull(kb);
			Assert.IsType<CustomKeyboard>(kb);

			kb = Keyboard.Telephone;
			Assert.NotNull(kb);
			Assert.IsType<TelephoneKeyboard>(kb);

			kb = Keyboard.Text;
			Assert.NotNull(kb);
			Assert.IsType<TextKeyboard>(kb);
		}

		[Fact]
		public void CreateCustomKeyboardsTest()
		{
			CustomKeyboard kb = (CustomKeyboard)Keyboard.Create(KeyboardFlags.CapitalizeSentence);
			Assert.NotNull(kb);
			Assert.IsType<CustomKeyboard>(kb);
			Assert.True(kb.Flags.HasFlag(KeyboardFlags.CapitalizeSentence));

			kb = (CustomKeyboard)Keyboard.Create(KeyboardFlags.Spellcheck | KeyboardFlags.Suggestions);
			Assert.NotNull(kb);
			Assert.IsType<CustomKeyboard>(kb);
			Assert.True(kb.Flags.HasFlag(KeyboardFlags.Spellcheck));
			Assert.True(kb.Flags.HasFlag(KeyboardFlags.Suggestions));
			Assert.False(kb.Flags.HasFlag(KeyboardFlags.CapitalizeCharacter));


			kb = (CustomKeyboard)Keyboard.Create(KeyboardFlags.CapitalizeCharacter | KeyboardFlags.Spellcheck | KeyboardFlags.Suggestions);
			Assert.NotNull(kb);
			Assert.IsType<CustomKeyboard>(kb);
			Assert.True(kb.Flags.HasFlag(KeyboardFlags.Spellcheck));
			Assert.True(kb.Flags.HasFlag(KeyboardFlags.Suggestions));
			Assert.True(kb.Flags.HasFlag(KeyboardFlags.CapitalizeCharacter));
		}
	}
}
