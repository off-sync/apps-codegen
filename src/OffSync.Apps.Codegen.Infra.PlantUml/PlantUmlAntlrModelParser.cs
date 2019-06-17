using OffSync.Apps.Codegen.Application.Interfaces;
using OffSync.Apps.Codegen.Domain.ApplicationModels;
using OffSync.Apps.Codegen.Infra.PlantUml.Common;

namespace OffSync.Apps.Codegen.Infra.PlantUml
{
    public class PlantUmlAntlrModelParser :
        IModelParser
    {
        private readonly ApplicationContextMapper _applicationContextMapper = new ApplicationContextMapper();

        public ApplicationModel Parse(
            string input)
        {
            var context = AntlrUtil.Parse(input);

            return _applicationContextMapper.Map(context);
        }
    }
}
