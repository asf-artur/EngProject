using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using EngProject.Classes;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Text text = new Text();
            text.GetText();
        }
    }
}
