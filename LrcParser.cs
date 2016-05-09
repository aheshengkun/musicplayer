using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MusicPlayer
{
    class LrcParser
    {
        public string m_Album { get; set; }
        public string m_Artist { get; set; }
        public string m_By { get; set; }
        public string m_Title { get; set; }
        public string m_Version { get; set; }
        public int m_Offset { get; set; }
        public List<LyricEntry> m_Lyrics { get; set; }

        public void Release()
        {
            m_Lyrics.Clear();
        }

        public LrcParser()
        {
            m_Lyrics = new List<LyricEntry>();
        }

        public bool Initialize(String fileName)
        {
            if (File.Exists(fileName))
            {
                //读取文件
                FileStream fsRead = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                int fsLen = (int)fsRead.Length;
                byte[] heByte = new byte[fsLen];
                int ret = fsRead.Read(heByte, 0, heByte.Length);
                fsRead.Flush();
                fsRead.Position = 0;
                //判断文件编码类型
                Encoding r = EncodingType.GetType(fsRead);
                fsRead.Close();
                string text = "";
                //如果不是 Unicode 就转为unicode
                if (Encoding.Unicode != r)
                {
                    byte[] retByte = Encoding.Convert(r, Encoding.Unicode, heByte);
                    text = Encoding.Unicode.GetString(retByte);
                }
                else
                {
                    text = Encoding.Unicode.GetString(heByte);
                }
                LoadLyricComponet(text);
            }
            return true;
        }

        private bool LoadLyricComponet(string text)
        {
            char[] bufContent = text.ToCharArray();
            int indexBegin = 0;
            int indexEnd = 0;
            int sync = 0;
            string syncTime = "00:00";
            if (bufContent == null)
            {
                return false;
            }

            while (true)
            {
                indexBegin = wcschr(bufContent, indexBegin, '[');
                if (indexBegin == -1)
                {
                    break;
                }
                indexEnd = wcschr(bufContent, indexBegin, ']');
                if (indexEnd == -1)
                {
                    break;
                }
                // ie [00:33.91]It′s my life
                if (bufContent[indexBegin + 1] >= '0' && bufContent[indexBegin + 1] <= '9')
                {
                    sync = 0;
                    indexBegin = ParseSyncTime(bufContent, indexBegin + 1, ref sync, ref syncTime);
                    if (indexBegin == -1)
                    {
                        break;
                    }
                    // line
                    indexEnd = wcschr(bufContent, indexBegin, '\n');
                    if (indexEnd == -1)
                    {
                        break;
                    }
                    // here in windows \n equals CR, so we need to 
                    // zero the LF mark
                    //if(*(pEnd-1) == 0x000d)
                    if (bufContent[indexEnd - 1] == '\r')
                    {
                        bufContent[indexEnd - 1] = '\0';
                        bufContent[indexEnd] = '\0';
                    }
                    LyricEntry entry = new LyricEntry();
                    entry.offset = sync;
                    entry.time = syncTime;
                    entry.lyric = wstring(bufContent, indexBegin, indexEnd);
                    m_Lyrics.Add(entry);
                    indexBegin = indexEnd + 1;

                }
                else if (wcsncmp(bufContent, indexBegin + 1, "al", 2) == 0)
                {
                    m_Album = wstring(bufContent, indexBegin + 4, indexEnd);
                    indexBegin = indexEnd + 1;
                }
                else if (wcsncmp(bufContent, indexBegin + 1, "ar", 2) == 0)
                {
                    m_Album = wstring(bufContent, indexBegin + 4, indexEnd);
                    indexBegin = indexEnd + 1;
                }
                else if (wcsncmp(bufContent, indexBegin + 1, "by", 2) == 0)
                {
                    m_Album = wstring(bufContent, indexBegin + 4, indexEnd);
                    indexBegin = indexEnd + 1;
                }
                else if (wcsncmp(bufContent, indexBegin + 1, "ti", 2) == 0)
                {
                    m_Album = wstring(bufContent, indexBegin + 4, indexEnd);
                    indexBegin = indexEnd + 1;
                }
                else if (wcsncmp(bufContent, indexBegin + 1, "ve", 2) == 0)
                {
                    m_Album = wstring(bufContent, indexBegin + 4, indexEnd);
                    indexBegin = indexEnd + 1;
                }
                else if (wcsncmp(bufContent, indexBegin + 1, "offset", 6) == 0)
                {
                    m_Album = wstring(bufContent, indexBegin + 8, indexEnd);
                    indexBegin = indexEnd + 1;
                }
                else
                {
                    // ignore all other tags, and go to next tag
                    indexBegin = indexEnd + 1;
                }
            }
            return true;
        }

        private int ParseSyncTime(char[] buf, int index, ref int ptime, ref string strTime)
        {
            int time = 0;
            int beginIndex = index;
            int indexEnd = 0;
            int indexBound = 0;
            int timeTmp = 0;
            string tmpStr = "";
            indexBound = wcschr(buf, beginIndex, ']');
            if (indexBound == -1)
            {
                return -1;
            }
            indexEnd = wcschr(buf, beginIndex, ':');
            if (indexEnd != -1)
            {
                tmpStr = wstring(buf, beginIndex, indexEnd);
                strTime = tmpStr;
                timeTmp = int.Parse(tmpStr);
                time += timeTmp * 60000;
                beginIndex = indexEnd + 1;
                // now pBegin points to the first char after ':'
                indexEnd = wcschr(buf, beginIndex, '.');
                // this indicates that whether the time mark contains milliseconds
                // found L'.' and it's before pBound 
                if (indexEnd < indexBound && indexEnd != -1)
                {
                    tmpStr = wstring(buf, beginIndex, indexEnd);
                    strTime = strTime + ":" + tmpStr;
                    timeTmp = int.Parse(tmpStr);
                    time += timeTmp * 1000;
                    beginIndex = indexEnd + 1;
                    // now that pBegin points to the first char after '.'
                    indexEnd = indexBound;
                    timeTmp = int.Parse(wstring(buf, beginIndex, indexEnd));
                    time += timeTmp;
                    beginIndex = indexEnd + 1;
                }
                // found L'.' but after pBound or cannot find it
                else
                {
                    indexEnd = indexBound;
                    time += Convert.ToInt32(buf[beginIndex]) * 1000;
                    beginIndex = indexEnd + 1;
                }
            }
            ptime = time;
            return beginIndex;
        }

        private string wstring(char[] buf, int index, int endIndex)
        {
            int len = endIndex - index;
            if (len < 1) return "";
            char[] newBuf = new char[len];
            for (int i = index, k = 0; i < endIndex; i++, k++)
            {
                newBuf[k] = buf[i];
            }
            string result = new string(newBuf);
            return result;
        }

        private int wcsncmp(char[] buf, int index, string cmpStr, int count)
        {
            int result = 1;
            char[] cmpBuf = cmpStr.ToCharArray();
            for (int i = 0, j = index; i < count; i++, j++)
            {
                if (cmpBuf[0] != buf[j])
                {
                    result = -1;
                    break;
                }
            }
            return result;
        }

        private int wcschr(char[] bufContent, int index, char c)
        {
            int result = -1;
            for (int i = index; i < bufContent.Length; i++)
            {
                if (bufContent[i] == c)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
