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
	public class FontFileTests
	{
		[Fact]
		public void FontFileFromNameTest()
		{
			FontFile fontFile = FontFile.FromString("TestFont-Regular#TestFont");
			Assert.NotNull(fontFile);
			Assert.Equal("TestFont-Regular", fontFile.FileName);
			Assert.Equal("TestFont", fontFile.PostScriptName);
			Assert.Null(fontFile.Extension);
			Assert.Equal("TestFont-Regular", fontFile.FileNameWithExtension());
			Assert.Equal("Test Font", fontFile.GetPostScriptNameWithSpaces());
		}

		[Fact]
		public void FontFileFromFileTest()
		{
			FontFile fontFile = FontFile.FromString("TestFont.ttf");
			Assert.NotNull(fontFile);
			Assert.Equal("TestFont", fontFile.FileName);
			Assert.Equal("TestFont.ttf", fontFile.PostScriptName);
			Assert.Equal(".ttf", fontFile.Extension);
			Assert.Equal("TestFont.ttf", fontFile.FileNameWithExtension());
			Assert.Equal("Test Font.ttf", fontFile.GetPostScriptNameWithSpaces());
		}

		[Fact]
		public void FontFileSpaces()
		{
			FontFile fontFile = FontFile.FromString("Test Font Space.ttf");
			Assert.NotNull(fontFile);
			Assert.Equal("Test Font Space", fontFile.FileName);
			Assert.Equal("Test Font Space.ttf", fontFile.PostScriptName);
			Assert.Equal(".ttf", fontFile.Extension);
			Assert.Equal("Test Font Space.ttf", fontFile.FileNameWithExtension());
			Assert.Equal("Test Font Space.ttf", fontFile.GetPostScriptNameWithSpaces());

			fontFile = FontFile.FromString("TestFont Regular#Test Font");
			Assert.NotNull(fontFile);
			Assert.Equal("TestFont Regular", fontFile.FileName);
			Assert.Equal("TestFont", fontFile.PostScriptName);
			Assert.Null(fontFile.Extension);
			Assert.Equal("TestFont Regular", fontFile.FileNameWithExtension());
			Assert.Equal("Test Font", fontFile.GetPostScriptNameWithSpaces());
		}
	}
}
