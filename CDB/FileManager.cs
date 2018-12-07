using System.Collections.Generic;
using System.IO;
using System;
using Newtonsoft.Json;

namespace CDB
{
    public class FileManager
    {
        private const string localPath = @"./";
        private const string dataPath = localPath+@"data/";
        private const string dbPath = @"db/";
        private const string indexFile = @"dbi.json";
        private const string indexPath = dataPath + dbPath + indexFile;
        private List<string> pathFiles;

        private void save(Componente documento)
        {
            string path = dataPath + dbPath + documento.codigo + ".json";
            if (!File.Exists(path))
            {
                File.WriteAllText(
                    path,
                    JsonConvert.SerializeObject(documento));
            }
            else
            {
                throw new Exception("El componente ya esta ingresado en las Base de Datos.");
            }
        }

        private void register(string uuid)
        {
            bool exist = false;
            //Si existe el archivo indice continuo con el proceso de registro.
            if (File.Exists(indexPath)){
                // Leo el archivo de registro como texto en la variable index.
                string index = File.ReadAllText(indexPath);
                //Deserializo el texto de la variable index en un objeto tipo lista (pathFiles)
                //para poder agregar o quitar los registros.
                this.pathFiles = JsonConvert.DeserializeObject<List<string>>(index);
                //bucle para recorrer las entradas de registro en la lista
                foreach(var a in this.pathFiles)
                {
                    //cuando encuentra el archivo del componente significa que
                    //ya existe y no es necesario agregar. Por lo tanto se levanta la 
                    //bandera <exist> local para que el resto del programa lo sepa.
                    if(a == dataPath + dbPath + uuid + ".json")
                    {
                        exist = true; // bandera <exist>
                        break; // se rompe el bucle, es innecesario seguir.
                    }
                }
                // Ahora si el registro del archivo no existe, pos se agrega el registro y
                //se guarda el archivo indice.
                if (!exist)
                {
                    //Agrega el registro a la lista indice <pathFiles>.
                    this.pathFiles.Add(dataPath + dbPath + uuid + ".json");
                    //Escribo el archvio indice Serializando la variable
                    // tipo Lista <pathFiles>.
                    File.WriteAllText(
                        indexPath,
                        JsonConvert.SerializeObject(this.pathFiles));
                }
                else
                {
                    //Si el registro existe, aviso al usuario.
                    //OJO. CAMBIAR EL MENSAJE POR UNA EXCEPCION.
                    throw new Exception("El documento que intenta registrar ya existe.");
                }
            }
        }

        public FileManager()
        {
            if (!Directory.Exists(dataPath)) Directory.CreateDirectory(dataPath);
            if (!Directory.Exists(dataPath + dbPath)) Directory.CreateDirectory(dataPath + dbPath);
            if (!File.Exists(dataPath + dbPath + indexFile))
            {
                File.WriteAllText(
                    dataPath + dbPath + indexFile,
                    JsonConvert.SerializeObject(new List<string>()));
            }
            else
            {
                this.pathFiles = JsonConvert.DeserializeObject<List<string>>(
                    File.ReadAllText(dataPath+dbPath+indexFile));
            }
        }

        public void AddDocument(Componente documento)
        {
            Guid uuid = Guid.NewGuid();
            //MessageBox.Show(uuid.ToString());
            documento.ID = uuid.ToString();
            documento.fecha = DateTime.Now;
            register(documento.codigo);
            save(documento);
        }
        public Componente[] SearchDocuments(string criterio = null)
        {
            Componente[] coms;
            if (criterio == null)
            {
                if (File.Exists(indexPath))
                {
                    string index = File.ReadAllText(indexPath);
                    this.pathFiles = JsonConvert.DeserializeObject<List<string>>(index);
                    coms = new Componente[this.pathFiles.Count];
                }
                else
                {
                    throw new Exception("No se encuentra el archivo de registro.");
                }
                var i = 0;
                foreach(var doc in this.pathFiles)
                {
                    var file = File.ReadAllText(doc);
                    coms[i] = JsonConvert.DeserializeObject<Componente>(file);
                    i++;
                }
                return coms;
            }
            else
            {

            }
            return null;
        } 
        public void DeleteDocument()
        {

        }
        
    }
}
