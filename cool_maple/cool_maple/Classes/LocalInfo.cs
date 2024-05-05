using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cool_maple.Classes
{
    public class ChracterInfo
    {
        [JsonProperty("name")]
        public string CharacterName { get; set; }
    }
    public class LocalInfo
    {
        public static LocalInfo instance;

        LocalInfo()
        {
            Load();
        }

        private ChracterInfo _characterInfo = new();
        public ChracterInfo ChracterInfo
        {
            get { return _characterInfo; }
        }
        private string DefaultDirectory = ConfigurationManager.AppSettings.Get("DefaultDirectory") + "GH\\";

        #region 싱글톤
        public static void init()
        {
            if (instance == null)
            {
                instance = new();
            }
        }
        #endregion
        private void Save()
        {
            var json = JsonConvert.SerializeObject(_characterInfo);
            if (!Directory.Exists(DefaultDirectory))
                Directory.CreateDirectory(DefaultDirectory);
            File.WriteAllText(DefaultDirectory + "info.json", json);
        }
        private void Load()
        {
            if (!Directory.Exists(DefaultDirectory))
                Directory.CreateDirectory(DefaultDirectory);
            if (!File.Exists(DefaultDirectory + "info.json"))
                File.WriteAllText(DefaultDirectory + "info.json", JsonConvert.SerializeObject(new { }));
            string json = File.ReadAllText(DefaultDirectory + "info.json");
            _characterInfo = JsonConvert.DeserializeObject<ChracterInfo>(json);
        }

        public void setCharacterName(string name)
        {
            _characterInfo.CharacterName = name;
            Save();
        }
    }
}
