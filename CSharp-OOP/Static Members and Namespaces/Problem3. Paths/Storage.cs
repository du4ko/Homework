using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem3.Paths
{
    static class Storage
    {
        //Constructors

        public Storage(List<Path3D> paths)
        {
            this.Paths = paths;
        }

        //Properties

        public List<Path3D>Paths  {get; private set;}
        
        //Methods

        public void AddPaths(Path3D path)
        {
            this.Paths.Add(path);
        }

        public void RemovePaths(Path3D path)
        {
            this.Paths.Remove(path);
        }
        public void SaveStorage(string filePath)
        {
            using (StreamWriter writeSave = new StreamWriter(filePath))
            {
                //TODO
            }
        }
    }
}
