
using System.Collections.Generic;
using System.IO;

namespace ComponentsDataBaseService
{
    class FileManagement
    {
        //##### Propiedades #####
        //Private
        private FileStream file;

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
        }

        //Private
        public void addComponent(List<string> document)
        {
            Ocupado = true;
            // Aqui va el codigo.
            Ocupado = false;
        }
        public void deleteComponent()
        {

        }
        public bool updateComponent()
        {
            return true;
        }
        public Dictionary<string,string> search()
        {
            return new Dictionary<string, string>();
        }
    }
}