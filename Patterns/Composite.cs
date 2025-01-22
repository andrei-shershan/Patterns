using System.Formats.Tar;

namespace Patterns.Patterns
{
    public interface IFileSystemItem
    {
        string Name { get; set; }

        long Size { get; }

        void GetInfo(int n = 0);
    }

    public class File : IFileSystemItem
    {
        private readonly string _data;

        public File(string data)
        {
            _data = data;
        }

        public string Name { get; set; }

        public long Size => _data?.Length ?? 0;

        public void GetInfo(int n = 0)
        {
            string tabs = new string('\t', n);
            System.Console.WriteLine($"{tabs}File: {Name}, size: {Size}");
        }
    }

    public class Directory : IFileSystemItem
    {
        private readonly ICollection<IFileSystemItem> _items = new List<IFileSystemItem>();
        public string Name { get; set; }

        public long Size => _items.Sum(i => i.Size);

        public void Add(IFileSystemItem item)
        {
            _items.Add(item);
        }

        public void Remove(IFileSystemItem item)
        {
            _items.Remove(item);
        }

        public void GetInfo(int n = 0)
        {
            string tabs = new string('\t', n);
            n++;
            System.Console.WriteLine($"{tabs}Directory: {Name}, size: {Size}");
            if(_items.Any())
            {
                foreach (var item in _items)
                {
                    item.GetInfo(n);
                }
            }
        }
    }
}
