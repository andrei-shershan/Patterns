namespace Patterns.Patterns
{
    namespace Memento
    {
        public class Cooridate
        {
            public long X { get; set; }

            public long Y { get; set; }
        }

        public class DummyObject
        {
            private List<DummyMemento> _history = new List<DummyMemento>();

            public string Name { get; private set; }

            public Cooridate Cooridate { get; private set; }

            public DummyObject(string name)
            {
                Name = name;
                Cooridate = new Cooridate();
            }

            public void Rename(string newName)
            {
                Name = newName;
            }

            public void Move(long x, long y)
            {
                Cooridate.X += x;
                Cooridate.Y += y;
            }

            public void GetStatus()
            {
                Console.WriteLine($"{Name} is on position x={Cooridate.X}, y={Cooridate.Y}");
            }

            public void SaveState()
            {
                _history.Add(new DummyMemento(this));
            }

            public void Restore()
            {
                var last = _history.LastOrDefault();
                if(last != null)
                {
                    Name = last.Name;
                    Cooridate = new Cooridate
                    {
                        X = last.Cooridate.X,
                        Y = last.Cooridate.Y
                    };
                }
            }
        }

        public class DummyMemento
        {
            public string Name { get; private set; }

            public Cooridate Cooridate { get; private set; }

            public DummyMemento(DummyObject dummyObject)
            {
                Name = dummyObject.Name;
                Cooridate = new Cooridate
                {
                    X = dummyObject.Cooridate.X,
                    Y = dummyObject.Cooridate.Y
                };
            }
        }
    }
}
