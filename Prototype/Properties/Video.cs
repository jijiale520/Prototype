using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Prototype.Properties
{
    [Serializable]
    public class Vision
    {
        public int vision;

        public Vision(int _vision)
        {
            this.vision = _vision;
        }
    }
    
    [Serializable]
    public class Video
    {
        private string name;
        private DateTime dateTime;
        private Vision visionNum = new Vision(0);
        public Video ShallowCopy()
        {
            Video obj = (Video)this.MemberwiseClone();
            return obj;
        }

        public Video DeepCopy()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                formatter.Serialize(ms, this);
                ms.Position = 0;
                return (Video)formatter.Deserialize(ms);
            }
        }

        public Video XMLDeepCopy()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Video));
            using (MemoryStream ms = new MemoryStream()) //创建内存流
            {
                //将对象序列化到内存中
                xml.Serialize(ms, this);
                ms.Position = 0; //将内存流的位置设为0
                return (Video) xml.Deserialize(ms); //继续反序列化
            }
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string _name)
        {
            this.name = _name;
        }

        public DateTime GetDateTime()
        {
            return dateTime;
        }

        public void SetDateTime(DateTime _date)
        {
            this.dateTime = _date;
        }

        public int GetVisionNum()
        {
            return this.visionNum.vision;
        }

        public void SetVisionNum(int _vision)
        {
            this.visionNum.vision = _vision;
        }
    }
}