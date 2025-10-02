using SampleProjectForGit.Modules;
using System.Reflection.Metadata.Ecma335;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Boolean i = true;
            Assert.True(i, "True");
        }

        [Fact]
        public void Test2()
        {
            Boolean j = true;
            Class Func = new Class();
            int y = Func.add(1, 2);
            Boolean ans = false;
            if (y == 3) ans = true;
            Assert.True(ans, "True");
        }

    }
}