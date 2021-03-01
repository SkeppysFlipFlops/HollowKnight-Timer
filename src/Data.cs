using System;

namespace HKTimer
{
    [Serializable]
    public class Settings
    {
        public string pause = "[1]";
        public string reset = "[0]";
        public string reload_settings = "[5]";
        public string set_start = "[7]";
        public string set_end = "[8]";
        public string load_triggers = "[9]";
        public string save_triggers = "[6]";
    }

    [Serializable]
    public class Triggers
    {
        public string startScene;
        public float startX;
        public float startY;
        public string endScene;
        public float endX;
        public float endY;
    }
}