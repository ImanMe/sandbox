using SandBox.Basics.StringPlay;
using Xunit;

namespace Sandbox.Basics.Test
{
    public class StringPlay
    {
        [Fact]
        public void ShouldReverseString1()
        {
            var sut = new ReverseThings();

            var reversedString = sut.ReverseString1("iman");

            Assert.Equal("nami", reversedString);
        }

        //[Fact]
        //public void ShouldReverseString2()
        //{
        //    var sut = new ReverseThings();

        //    var reversedString = sut.ReverseString2("iman");

        //    Assert.Equal("nami", reversedString);
        //}

        //[Fact]
        //public void ShouldReverseString3()
        //{
        //    var sut = new ReverseThings();

        //    var reversedString = sut.ReverseString3("iman");

        //    Assert.Equal("nami", reversedString);
        //}

        //[Fact]
        //public void ShouldReverseString4()
        //{
        //    var sut = new ReverseThings();

        //    var reversedString = sut.ReverseString4("iman");

        //    Assert.Equal("nami", reversedString);
        //}
    }
}
