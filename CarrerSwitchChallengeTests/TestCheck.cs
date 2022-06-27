using NUnit.Framework;
using CareerSwitchChallenge.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CarrerSwitchChallengeTests
{
    [TestClass]
    public class TestsChecker
    {
        [Test]
        public void TestCheck()
        {
            List<string> unordered_Blocks = new List<string>
                {
                      "asdw",
                      "weqs",
                      "qwes",
                      "qweo",
                      "wexs",
                      "plkj",
                      "tfok",
                      "dofk",
                      "xpkg"
                };
            List<string> correct_blockstr = new List<string>
            {
                      "asdw",
                      "xpkg",
                      "dofk",
                      "tfok",
                      "wexs",
                      "plkj",
                      "qweo",
                      "qwes",
                      "weqs"
            };
            List<string> orderer_blocks = Checker.MockCheck(unordered_Blocks, correct_blockstr);
            NUnit.Framework.Assert.AreEqual(orderer_blocks, correct_blockstr);
        }
    }
}