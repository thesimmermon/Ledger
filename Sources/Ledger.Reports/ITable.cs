using System;
using System.Collections.Generic;
using System.IO;

namespace Ledger.Reports
{
    public interface ITable
    {
        IList<ITableColumn> Columns
        {
            get;
        }

        IList<object> Rows
        {
            get;
        }

        void PrintText(TextWriter writer);
    }
}
