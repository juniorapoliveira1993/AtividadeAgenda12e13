using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgenda12e13.Models
{
    class SaveData
    {
        private readonly String KEY = "HOSTING_HISTORY";
        private List<HostingData> hostingHistory = [];

        public List<HostingData> HostingHistory => [.. hostingHistory];

        public SaveData()
        {
            string a = Preferences.Get(KEY, "");

            if (string.IsNullOrEmpty(a)) return;

            string[] b = a.Split("\n");
            foreach(var h in b) 
            {
                hostingHistory.Add(new HostingData(h));
            }
        }

        public void Save(HostingData h)
        {
            hostingHistory.Add(h);
            StringBuilder sb = new StringBuilder();
            foreach (var item in hostingHistory)
            {
                sb.Append(item.StringData).Append("\n");
            }
            sb.Remove(sb.Length - 1, 1);
            Preferences.Set(KEY, sb.ToString());
        }
    }
}
