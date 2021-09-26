using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AiWitnessBaseLibrary
{
    public class Video
    {
        private string _filePath;
        
        public Video() { }
        public Video(string filePath){ FilePath = filePath; }
        public Video(string filePath, bool loadData)
        {
            FilePath = filePath;
            
            if (loadData)
                LoadData();
        }

        private byte[] DataInByte { get; set; }

        private string FilePath {
            get { return _filePath; }
            
            set {

                if (File.Exists(value))
                {
                    _filePath = value;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
        }

        public void LoadData()
        {
            DataInByte = File.ReadAllBytes(FilePath);
            if(DataInByte.Length == 0)
            {
                throw new FileLoadException();
            }
        }

        public byte[] GetByteData()
        {
            return DataInByte;
        }

        virtual protected long GetDuration()
        {
            return 0;
        }
    }
}
