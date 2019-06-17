using System.IO;

using Antlr4.Runtime;

using NUnit.Framework;

using OffSync.Apps.Codegen.Infra.PlantUml.Antlr;

namespace OffSync.Apps.Codegen.Infra.PlantUml.Tests.Antlr
{
    [TestFixture]
    public class ApplicationsParserTest
    {
        [Test]
        public void ParsesPlantUml()
        {
            var plantUmlPath = Path.Combine(
                TestContext.CurrentContext.TestDirectory,
                "Example.wsd");

            using (var fs = File.OpenRead(plantUmlPath))
            {
                var stream = CharStreams.fromStream(fs);

                var lexer = new ApplicationsLexer(stream);

                var tokens = new CommonTokenStream(lexer);

                var parser = new ApplicationsParser(tokens)
                {
                    BuildParseTree = true
                };

                var app = parser.application();

                Assert.That(
                    app.AggregateRoots,
                    Has.Exactly(1).Items);
            }
        }
    }
}
