using System;

namespace Prototype.Properties
{
    public class Vision
    {
        public int vision;

        public Vision(int _vision)
        {
            this.vision = _vision;
        }
    }
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