using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace XNewwordPadCS
{
    partial class WordPad        
    {
        public bool Save(String fullName )
        {
            FileStream f = new FileStream(fullName, FileMode.Create, FileAccess.Write, FileShare.Write);
            
            BinaryWriter bw = new BinaryWriter(f);
            UTF8Encoding encoding = new UTF8Encoding();

            try
            {
                foreach( NewWordItem wordItem in m_words )
                {                
                    byte[] utf8Bytes = encoding.GetBytes(wordItem.Name);
                    UInt16 len = Convert.ToUInt16(utf8Bytes.Length);
                    bw.Write(len);
                    bw.Write(utf8Bytes);

                    utf8Bytes = encoding.GetBytes(wordItem.Annoucement);
                    len = Convert.ToUInt16(utf8Bytes.Length);
                    bw.Write(len);
                    bw.Write(utf8Bytes);

                    utf8Bytes = encoding.GetBytes(wordItem.Meaning);
                    len = Convert.ToUInt16(utf8Bytes.Length);
                    bw.Write(len);
                    bw.Write(utf8Bytes);

                    bw.Write(wordItem.AddTime.ToBinary());

                    bw.Write(Convert.ToByte(wordItem.Proficiency));
                }

                // very important!!! otherwise the file will be really written very late
                bw.Flush();
                f.Flush();
                bw.Close();
                f.Close();                
            }
            catch (System.IO.IOException )
            {                
               f.Close();
               bw.Close();
            }
            
            return true;
        }

        public bool Load(String fileName)
        {
            if (!File.Exists(fileName))
                return false;

            FileStream f = new FileStream(fileName, FileMode.Open, FileAccess.Read); ;
            BinaryReader br = new BinaryReader(f);

            UInt16 len = 0;
            
            try
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                while (!f.Position.Equals(System.IO.SeekOrigin.End))
                {
                    len = br.ReadUInt16();
                    if (len <= 0)
                        break;

                    // 词名必须不为空
                    byte[] buffer = new byte[len];
                    br.Read(buffer, 0, len);

                    NewWordItem wordItem = new NewWordItem();
                    wordItem.Name = utf8.GetString(buffer);

                    len = br.ReadUInt16();
                    if ( len > 0 )
                    {
                        buffer = new byte[len];
                        br.Read(buffer, 0, len);

                        wordItem.Annoucement = utf8.GetString(buffer);
                    }
                    
                    len = br.ReadUInt16();
                    if ( len > 0 )
                    {
                        buffer = new byte[len];
                        br.Read(buffer, 0, len);
                        wordItem.Meaning = utf8.GetString(buffer);
                    }                    

                    Int64 addTime = br.ReadInt64();
                    wordItem.AddTime = DateTime.FromBinary(addTime);

                    byte proficiency = br.ReadByte();                    
                    wordItem.Proficiency = (NewWordItem.ProficiencyLevel)proficiency;

                    AddWord(wordItem);
                }
            }
            catch( System.IO.EndOfStreamException )
            {
                f.Close();
                br.Close();
                return true;
            }            

            return true;
        }

        
        public bool LoadFromKingsoftWordpad(String fileName, bool append )
        {
            /*
             * +vermilion
                #adj.朱红色的; 鲜红色的
                #n.朱红色; 鲜红色
                &vəˈmiljən
                $1
             */
            if (!File.Exists(fileName))
                return false;

            try
            {
                StreamReader sr = File.OpenText(fileName);
                // unicode file header                

                if (!append)
                {
                    m_words.Clear();
                    m_lookupTable.Clear();
                }

                while (!sr.EndOfStream)
                {
                    NewWordItem wordItem = new NewWordItem();
                    wordItem.Name = sr.ReadLine().Substring(1);

                    char meaningTag = (char)sr.Read();
                    while (meaningTag == '#' && !sr.EndOfStream)
                    {
                        wordItem.Meaning += sr.ReadLine() + "\r\n";
                        meaningTag = (char)sr.Read();
                    }

                    if (meaningTag == '&')
                        wordItem.Annoucement = sr.ReadLine();

                    char proficiencyTag = (char)sr.Read();
                    if (proficiencyTag == '$')
                        wordItem.Proficiency = (NewWordItem.ProficiencyLevel)Convert.ToInt32(sr.ReadLine());

                    AddWord(wordItem);
                }
            }
            catch (System.Exception)
            {
                return true;
            }

            return true;
        }      
    }
}
