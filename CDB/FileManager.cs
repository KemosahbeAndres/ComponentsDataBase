using System.Collections.Generic;
using System.IO;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace CDB
{
    public static class FileManager
    {
        private static readonly string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"/";
        private const string localPath = @"./";
        private const string configPath = @"ComponentsDB/";
        private const string dbPath = @"db/";
        private const string imgPath = @"img/";
        private const string indexFile = @"dbi.json";
        private static readonly string indexPath = appDataPath + configPath + dbPath + indexFile;
        private static List<string> pathFiles;

        private static void save(Componente documento)
        {
            string path = appDataPath + configPath + dbPath + documento.Codigo + ".cdb";
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

        //OBSOLETO 14-12-2018 - DESDE HOY YA NO SE USARA EL ARCHIVO DE REGISTRO.
        //private static void register(string uuid)
        //{
        //    if (!Directory.Exists(appDataPath + configPath)) Directory.CreateDirectory(appDataPath + configPath);
        //    if (!Directory.Exists(appDataPath + configPath + dbPath)) Directory.CreateDirectory(appDataPath + configPath + dbPath);
        //    bool exist = false;
        //    //Si existe el archivo indice continuo con el proceso de registro.
        //    if (File.Exists(indexPath))
        //    {
        //        // Leo el archivo de registro como texto en la variable index.
        //        string index = File.ReadAllText(indexPath);
        //        //Deserializo el texto de la variable index en un objeto tipo lista (pathFiles)
        //        //para poder agregar o quitar los registros.
        //        pathFiles = JsonConvert.DeserializeObject<List<string>>(index);
        //        //bucle para recorrer las entradas de registro en la lista
        //        foreach(var a in pathFiles)
        //        {
        //            //cuando encuentra el archivo del componente significa que
        //            //ya existe y no es necesario agregar. Por lo tanto se levanta la 
        //            //bandera <exist> local para que el resto del programa lo sepa.
        //            if(a == uuid + ".json")
        //            {
        //                exist = true; // bandera <exist>
        //                break; // se rompe el bucle, es innecesario seguir.
        //            }
        //        }
        //        // Ahora si el registro del archivo no existe, pos se agrega el registro y
        //        //se guarda el archivo indice.
        //        if (!exist)
        //        {
        //            //Agrega el registro a la lista indice <pathFiles>.
        //            pathFiles.Add( uuid + ".json");
        //            //Escribo el archvio indice Serializando la variable
        //            // tipo Lista <pathFiles>.
        //            File.WriteAllText(
        //                indexPath,
        //                JsonConvert.SerializeObject(pathFiles));
        //        }
        //        else
        //        {
        //            //Si el registro existe, aviso al usuario.
        //            //OJO. CAMBIAR EL MENSAJE POR UNA EXCEPCION.
        //            throw new Exception("El documento que intenta registrar ya existe.");
        //        }
        //    }
        //    else
        //    {
        //        //Si no existe el archivo indice. se crea.
        //        File.WriteAllText(
        //            indexPath,
        //            JsonConvert.SerializeObject(new List<string>()));
        //        // y vuelvo a llamar a register para completar el registro.
        //        register(uuid);
        //    }
        //}

        public static void initFileManager()
        {
            //Verificar si existe la carpeta de aplicacion
            if (!Directory.Exists(appDataPath + configPath)) Directory.CreateDirectory(appDataPath + configPath);
            //Verificar si existe la carpeta de base de datos
            if (!Directory.Exists(appDataPath + configPath + dbPath)) Directory.CreateDirectory(appDataPath + configPath + dbPath);
            //Verificar si existe la carpeta de imagenes.
            if (!Directory.Exists(appDataPath + configPath + imgPath)) Directory.CreateDirectory(appDataPath + configPath + imgPath);

            //OBSOLETO
            //if (!File.Exists(indexPath))
            //{
            //    File.WriteAllText(
            //        indexPath,
            //        JsonConvert.SerializeObject(new List<string>()));
            //}
            //else
            //{
            //    pathFiles = JsonConvert.DeserializeObject<List<string>>(
            //        File.ReadAllText(indexPath));
            //}
        }

        public static bool Exist(string path)
        {
            bool flag = true;
            try
            {
                if (!File.Exists(path))
                {
                    flag = false;
                }
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public static void AddDocument(Componente documento)
        {
            if (documento == null) throw new Exception("[NULL EXCEPTION] No se aceptan argumentos nulos.");
            documento.FechaIngreso = DateTime.Now;
            try
            {
                save(documento);
            }
            catch (Exception e)
            {
                throw new Exception("[SAVE FILE ERROR] " + e.Message);
            }
            //OBSOLETO
            //try
            //{
            //    register(documento.Codigo);
            //}catch(Exception e)
            //{
            //    throw new Exception("[REGISTER ERROR] "+e.Message);
            //}
        }
        public static List<Componente> SearchDocuments(string criterio = null)
        {
            List<Componente> coms = null;
            if (criterio == null)
            {
                string filesPath = appDataPath + configPath + dbPath;
                string[] files = Directory.GetFiles(filesPath);
                
                //string a = "";
                //foreach(var b in files)
                //{
                //    a += b + " | ";
                //}
                //throw new Exception("Archivos: " + a);

                if (files.Length > 0)
                {
                    coms = new List<Componente>();
                    foreach (var doc in files)
                    {
                        if (!doc.EndsWith(".cdb")) continue;
                        var file = File.ReadAllText(doc);
                        coms.Add(JsonConvert.DeserializeObject<Componente>(file));
                    }
                }
                else
                {
                    return null;
                }
                
                return coms;
            }
            else
            {

            }
            return null;
        } 
        public static void DeleteDocument()
        {

        }

        public static void addImg(string path, string name)
        {
            if (File.Exists(path) || path != null)
            {
                File.Copy(path, appDataPath + configPath + imgPath + name + ".jpg");
            }
            else
            {
                throw new Exception("El archivo no existe.");
            }
        }
        
    }
}
