using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupRestore
{
    public class BackupInfo
    {
        public int position { get; set; }

        public string description { get; set; }

        public DateTime backupDateTime { get; set; }

        public string userBackup { get; set; }
    }
}
