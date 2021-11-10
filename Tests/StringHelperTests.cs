using RobinSkaCrasha;
using System;
using Xunit;

namespace Tests
{
    public class StringHelperTests
    {
        public StringHelperTests()
        {

        }
        [Fact]
        public void GetWordInputsEmptyTextAndIndexOne()
        {
            //Arrange
            var text = "";
            int x = 1;
            //Act
            var sut = new StringHelper();
            var result = sut.GetWord(text, x);
            //Assert
        }
        [Fact]
        public void GetWordInputsHelloWorldAndMinusOne()
        {
            //Arrange
            var text = "Hello World!";
            int x = -1;
            //Act
            var sut = new StringHelper();
            var result = sut.GetWord(text, x);
            //Assert
        }
        [Fact]
        public void GetWordInputsHelloWorldAndHundred()
        {
            //Arrange
            var text = "Hello World!";
            int x = 100;
            //Act
            var sut = new StringHelper();
            var result = sut.GetWord(text, x);
            //Assert
        }
        [Fact]
        public void GetWordInputsEmptyAndZero()
        {
            //Arrange
            var text = "";
            int x = 0;
            //Act
            var sut = new StringHelper();
            var result = sut.GetWord(text, x);
            //Assert
        }
        
            [Fact]
        public void StringToListInputsEmptyText()
        {
            //Arrange
            var text = "";
            //Act
            var sut = new StringHelper();
            var result = sut.StringToList(text);
            //Assert
        }
        [Fact]
        public void StringToListInputsTextAndNonExistingSeparator()
        {
            //Arrange
            var text = "This is a text woooo";
            char seperator = 'ö';
            //Act
            var sut = new StringHelper();
            var result = sut.StringToList(text, seperator);
            //Assert
        }

        [Fact]
        public void RemoveWordHelloWorldWithWorld()
        {
            //Arrange
            var text = "Hello world!";
            string word = "world";
            //Act
            var sut = new StringHelper();
            var result = sut.RemoveWord(text, word);
            //Assert
        }

        [Fact]
        public void RemoveWordEmptyStringWithWorld()
        {
            //Arrange
            var text = "";
            string word = "world";
            //Act
            var sut = new StringHelper();
            var result = sut.RemoveWord(text, word);
            //Assert
        }
        [Fact]
        public void RemoveWordHelloWorldWithSpace()
        {
            //Arrange
            var text = "Hello world!";
            string word = " ";
            //Act
            var sut = new StringHelper();
            var result = sut.RemoveWord(text, word);
            //Assert
        }

        [Fact]
        public void RemoveWordAtACatInAHatAndIndexTwo()
        {
            //Arrange
            var text = "A cat in a hat";
            int x = 2;
            //Act
            var sut = new StringHelper();
            var result = sut.RemoveWordAt(text, x);
            //Assert
        }
        [Fact]
        public void RemoveWordAtACatInAHatAndIndexMinusOne()
        {
            //Arrange
            var text = "A cat in a hat";
            int x = -1;
            //Act
            var sut = new StringHelper();
            var result = sut.RemoveWordAt(text, x);
            //Assert
        }
        [Fact]
        public void RemoveWordAtACatInAHatAndIndexTwentyFive()
        {
            //Arrange
            var text = "A cat in a hat";
            int x = 25;
            //Act
            var sut = new StringHelper();
            var result = sut.RemoveWordAt(text, x);
            //Assert
        }

        [Fact]
        public void RemoveWordAtEmptyStringAndIndexZero()
        {
            //Arrange
            var text = "";
            int x = 0;
            //Act
            var sut = new StringHelper();
            var result = sut.RemoveWordAt(text, x);
            //Assert
        }
        [Fact]
        public void InsertWordAfterACatInAHatAfterAAddAHuge()
        {
            //Arrange
            var text = "A cat in a hat";
            var after = "a";
            var add = "a huge";
            //Act
            var sut = new StringHelper();
            var result = sut.InsertWordAfter(text, after, add);
            //Assert
        }
        [Fact]
        public void InsertWordafterForceAddCat()
        {
            //Arrange
            var text = "Trust the force";
            var after = "force";
            var add = "cat";
            //Act
            var sut = new StringHelper();
            var result = sut.InsertWordAfter(text, after, add);
            //Assert
        }

        [Fact]
        public void InsertWordafterEmptyAddMeow()
        {
            //Arrange
            var text = "Trust the force";
            var after = "";
            var add = "meow";
            //Act
            var sut = new StringHelper();
            var result = sut.InsertWordAfter(text, after, add);
            //Assert
        }

        [Fact]
        public void SwapWordsOneAndThree()
        {
            //Arrange
            var text = "Its not wise to upset a wookie";
            int word1 = 1;
            int word2 = 3;
            
            //Act
            var sut = new StringHelper();
            var result = sut.SwapWords(text, word1, word2);
            //Assert
        }

        [Fact]
        public void SwapWordsMinusOneAndFour()
        {
            //Arrange
            var text = "Its not wise to upset a wookie";
            int word1 = -1;
            int word2 = 4;

            //Act
            var sut = new StringHelper();
            var result = sut.SwapWords(text, word1, word2);
            //Assert
        }

        [Fact]
        public void SwapWordsOneAndOnhundredtwentyfour()
        {
            //Arrange
            var text = "Its not wise to upset a wookie";
            int word1 = 1;
            int word2 = 124;

            //Act
            var sut = new StringHelper();
            var result = sut.SwapWords(text, word1, word2);
            //Assert
        }

        [Fact]
        public void SwapWordsOneandOne()
        {
            //Arrange
            var text = "Its not wise to upset a wookie";
            int word1 = 1;
            int word2 = 1;

            //Act
            var sut = new StringHelper();
            var result = sut.SwapWords(text, word1, word2);
            //Assert
        }

    }
}
