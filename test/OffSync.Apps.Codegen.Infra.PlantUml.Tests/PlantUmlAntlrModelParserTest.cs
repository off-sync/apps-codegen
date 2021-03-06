﻿using System.IO;

using NUnit.Framework;

namespace OffSync.Apps.Codegen.Infra.PlantUml.Tests
{
    [TestFixture]
    public class PlantUmlAntlrModelParserTest
    {
        private string _input;

        private PlantUmlAntlrModelParser _sut;

        [SetUp]
        public void SetUp()
        {
            _input = File.ReadAllText(Path.Combine(
                TestContext.CurrentContext.TestDirectory,
                "Example.wsd"));

            _sut = new PlantUmlAntlrModelParser();
        }

        [Test]
        public void Parse()
        {
            var application = _sut.Parse(_input);

            Assert.That(
                application.Namespace,
                Is.EqualTo("OffSync.Apps.CodeGen.Example"));
        }
    }
}
