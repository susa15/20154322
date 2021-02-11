using System.Collections.Generic;
namespace BreakingBad.Data
{
    public class BBCharacter
    {
        public int char_id { get; set; }
        public string name { get; set; }
        public string birthday { get; set; }
        public List<string> occupation { get; set; }
        public string img { get; set; }
        public string status { get; set; }
        public string nickname { get; set; }
        // public List<int> appearance { get; set; }
        public string portrayed { get; set; }

    }
}
