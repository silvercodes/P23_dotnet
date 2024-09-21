using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor.Renaming.Generation;

internal class IncrementRuleHandler : IRuleHandler, IWithOptions
{
    public string OptionsString { get ; set ; }

    public string GetValue()
    {
        throw new NotImplementedException();
    }
}
