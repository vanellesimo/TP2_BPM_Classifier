using System.Collections.Generic;

namespace MouseGestureRecognition.BLL
{
    public class Database
    {
        public List<string> Classes { get; private set; }
        public List<Sequence> Samples { get; private set; }

        public Database()
        {
            Classes = new List<string>();
            Samples = new List<Sequence>();
        }

        public void Add(Sequence sequence, string classLabel)
        {
            if (sequence == null || sequence.Length == 0)
                return;

            if (!Classes.Contains(classLabel))
                Classes.Add(classLabel);
            
            int classIndex = Classes.IndexOf(classLabel);
            sequence.Output = classIndex;
            Samples.Add(sequence);
        }

        public void Clear()
        {
            Classes.Clear();
            Samples.Clear();
        }

        public string MapResult(int classIndex)
        {
            if (classIndex < 0) return "None";
            return Classes[classIndex];
        }
    }
}
