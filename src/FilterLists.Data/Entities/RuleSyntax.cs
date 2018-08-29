using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Data.Entities
{
    [UsedImplicitly]
    public class RuleSyntax : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Rule> Rules { get; set; }
    }
}