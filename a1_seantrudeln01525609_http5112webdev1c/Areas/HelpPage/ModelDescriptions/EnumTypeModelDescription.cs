using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace a1_seantrudeln01525609_http5112webdev1c.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}