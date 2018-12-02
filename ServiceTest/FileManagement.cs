using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ServiceTest
{
    class FileManagement
    {
        //##### Propiedades #####
        //Private
        private const string dataPath = @".\data\";
        private const string dbPath = @".\data\db\";
        //private const string configPath = @".\data\config\";
        private const string dbiFile = @"dbi.json";
        private Dictionary<string, string> Index { get; set; }
        private string Document { get; set; }

        //Public
        //public delegate void StatusProccess(int status);
        //public event StatusProccess OnError;
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
                if (!Directory.Exists(dataPath) || !Directory.Exists(dbPath))
                {
                    Directory.CreateDirectory(dataPath);
                    Directory.CreateDirectory(dbPath);
                }
                File.Create(dataPath + dbiFile);
                Index = new Dictionary<string, string>();
            }
            else
            {
                Index = JsonConvert.DeserializeObject<Dictionary<string, string>>(
                    File.ReadAllText(dbPath + dbiFile));
            }
        }

        //Public
        public void addComponent(string document)
        {
            Ocupado = true;
            Document = document;
            
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