using Library;
using Xunit;

namespace TestApp
{
    public class LibraryTests
    {
        // A stupid test class which assets that 19 + 23 is 42, via
        // the Thing classes Get method
        [Fact]
        public void TestThing() {
            Assert.Equal(42, new Thing().Get(19, 23));
        }
    }
}