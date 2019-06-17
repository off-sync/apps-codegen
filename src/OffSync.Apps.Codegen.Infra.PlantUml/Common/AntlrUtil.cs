using Antlr4.Runtime;

using OffSync.Apps.Codegen.Infra.PlantUml.Antlr;

using static OffSync.Apps.Codegen.Infra.PlantUml.Antlr.ApplicationsParser;

namespace OffSync.Apps.Codegen.Infra.PlantUml.Common
{
    public static class AntlrUtil
    {
        public static ApplicationContext Parse(
            string input)
        {
            var stream = CharStreams.fromstring(input);

            var lexer = new ApplicationsLexer(stream);

            var tokens = new CommonTokenStream(lexer);

            var parser = new ApplicationsParser(tokens)
            {
                BuildParseTree = true
            };

            return parser.application();
        }
    }
}
