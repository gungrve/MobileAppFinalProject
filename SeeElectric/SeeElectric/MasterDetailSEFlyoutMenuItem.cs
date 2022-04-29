using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeElectric
{
    public class MasterDetailSEFlyoutMenuItem
    {
        public MasterDetailSEFlyoutMenuItem()
        {
            TargetType = typeof(MasterDetailSEFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}