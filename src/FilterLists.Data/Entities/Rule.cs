using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class Rule : BaseEntity
    {
        public string Raw { get; set; }
        public uint? RuleSyntaxId { get; set; }
        public RuleSyntax RuleSyntax { get; set; }
        public ICollection<SnapshotRule> SnapshotRules { get; set; }
    }
}