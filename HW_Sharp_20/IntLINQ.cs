using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Sharp_20
{
    public partial class IntLINQ : Component
    {
        public IntLINQ()
        {
            InitializeComponent();
        }

        public IntLINQ(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
