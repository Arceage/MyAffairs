using MyAffairs.MyFolder;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyAffairs.Services
{
    class FileSaver
    {
        private readonly string path;

        public FileSaver(string path)
        {
            this.path = path;
        }

        public BindingList<AffairsModel> LoadInfo()
        {
            bool FileExists = File.Exists(path);
            if (!FileExists)
            {
                File.CreateText(path).Dispose();
                return new BindingList<AffairsModel>();
            }
            using (StreamReader reader = File.OpenText(path))
            {
                var filetext = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<AffairsModel>>(filetext);
            }
        }

        public void SaveInfo(object modellist)
        {
            using (StreamWriter Writer = File.CreateText(path))
            {
                string readyinfo = JsonConvert.SerializeObject(modellist);
                Writer.Write(readyinfo);
            }
        }
    }
}
