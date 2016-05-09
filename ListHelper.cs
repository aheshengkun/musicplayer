using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MusicPlayer
{
    class ListHelper
    {
        public static void WriteObjectToFile(string fileName, Object obj)
        {
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            BinaryFormatter binFormat = new BinaryFormatter();//创建二进制序列化器
            binFormat.Serialize(fStream, obj);
            fStream.Close();
        }

        public static Object readObjectFromFile(string fileName)
        {
            Object obj = null;
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter binFormat = new BinaryFormatter();//创建二进制序列化器
            try
            {
                obj = binFormat.Deserialize(fStream);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            fStream.Close();
            return obj;
        }
        public static void WriteListItem(ListBox listBoxPlayList)
        {
            String fileName = ConstantParams.sysFilePath + "\\" + ConstantParams.playListSerializeFile;
            List<PlayList> tmpList = new List<PlayList>();
            foreach (object obj in listBoxPlayList.Items)
            {
                tmpList.Add((PlayList)obj);
            }
            WriteObjectToFile(fileName, tmpList);
        }

        public static void WriteMusicItem(ListBox listBoxMusics, string fileName)
        {
            List<Music> tmpList = new List<Music>();
            foreach (object obj in listBoxMusics.Items)
            {
                tmpList.Add((Music)obj);
            }
            WriteObjectToFile(fileName, tmpList);
        }
    }
}
