using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class StringHelper
    {
        /// <summary>
        /// 文件是否存在
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Boolean FileExists(string fileName)
        {
            if (File.Exists(fileName))
            {
                //存在
                return true;
            }
            else
            {
                //不存在
                return false;
            }
        }
        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="dirName"></param>
        public static void CreateFileDirectory(string dirName)
        {
            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }
        }
        public static void CreateFile(string fileName)
        {
            if (!FileExists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                fs.Flush();
                fs.Close();
            }
        }
        /// <summary>
        /// 读取整个文件
        /// </summary>
        /// <param name="path"></param>
        public static string ReadToEnd(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string text = sr.ReadLine();
            sr.Close();
            return text;
        }
        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="text"></param>
        public static void Write(string path, string text)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            //获得字节数组
            byte[] data = System.Text.Encoding.Default.GetBytes(text);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
        public static void DeleteFile(string fileName)
        {
            if (FileExists(fileName))
            {
                File.Delete(fileName);
            }
        }
        public static Boolean ChangeFileName(string srcFile, string desFile)
        {
            try
            {
                if(File.Exists(srcFile))
                {
                    File.Move(srcFile, desFile);
                    DeleteFile(srcFile);
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string readFileAllText(string fileName)
        {
            return File.ReadAllText(fileName);
        }
    }
}
