using SmartFace.ODataClient.Default;
using SmartFace.ODataClient.SmartFace.Data.Models.Core;

namespace SmartFace.Cli.Core.Domain.DataSelector.Impl
{
    public class GroupingODataSelector : ODataSelector<Grouping>, IQueryDataSelector<Grouping>
    {
        public GroupingODataSelector(Container container) : base(container.Groupings)
        {
        }
    }
}