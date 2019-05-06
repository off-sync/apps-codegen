using System;

using OffSync.Apps.Codegen.Application.Interfaces;
using OffSync.Apps.Practises.Executables;

namespace OffSync.Apps.Codegen.Application.ApplicationModels.Queries.ParseModel
{
    public sealed class ParseModelQuery :
        AbstractQuery<ParseModelModel, ParseModelResult>
    {
        private readonly IModelParser _modelParser;

        public ParseModelQuery(
            IModelParser modelParser)
        {
            _modelParser = modelParser ?? throw new ArgumentNullException(nameof(modelParser));
        }

        protected override ParseModelResult InternalExecute(
            ParseModelModel model)
        {
            var applicationModel = _modelParser.Parse(model.Input);

            return new ParseModelResult()
            {
                ApplicationModel = applicationModel,
            };
        }
    }
}
