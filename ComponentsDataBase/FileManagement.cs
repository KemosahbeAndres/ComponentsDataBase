using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ComponentsDataBaseService
{
    class FileManagement
    {
        //##### Propiedades #####
        //Private
        private const string dataPath = @".\data\";
        private const string dbPath = @".\data\db\";
        //private const string configPath = @".\data\config\";
        private const string dbiFile = @"dbi.json";
        private Dictionary<string, string> dbIndex;
        private string dbDocument { get; set; }

        //Public
        public delegate void StatusProccess(int status);
        public event StatusProccess OnError;
        public static bool Ocupado { get; private set; }
        public enum FileManagementError{ }
        public FileManagementError ErrorCode { get; private set; }

        //##### Metodos #####
        //Public
        public FileManagement()
        {
            Ocupado = false;
            if (!File.Exists(dbPath + dbiFile))
            {
                File.Create(dataPath + dbiFile);
                dbIndex = new Dictionary<string, string>();
            }
            else
            {
                dbIndex = JsonConvert.DeserializeObject<Dictionary<string, string>>(
                    File.ReadAllText(dbPath + dbiFile));
            }
        }

        //Private
        public void addComponent(string document)
        {
            Ocupado = true;
            dbDocument = document;
            
            Ocupado = false;
        }
        public void deleteComponent()
        {
            Ocupado = true;
            // Aqui va el codigo.
            Ocupado = false;
        }
        public bool updateComponent()
        {
            Ocupado = true;
            // Aqui va el codigo.
            Ocupado = false;
            return true;
        }
        public string searchAll()
        {
            Ocupado = true;
            // Aqui va el codigo.
            Ocupado = false;
            return string.Empty;
        }
    }
}