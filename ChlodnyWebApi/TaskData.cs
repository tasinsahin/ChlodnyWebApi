using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChlodnyWebApi
{
    using System.IO;

    internal class TaskData
    {
        public Controllers.ValuesController.JsonPReturn JsonP { get; set; }

        public Stream Stream { get; set; }
    }
}
