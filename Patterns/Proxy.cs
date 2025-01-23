namespace Patterns.Patterns
{
    public interface IDataService
    {
        string GetData();
    }

    public class DatalService : IDataService
    {
        public string GetData()
        {
            return "Data from the server...";
        }
    }

    public class CachedData
    {
        public string Value { get; set; }
        public DateTime ExpirationDate { get; set; }
    }


    public class ProxyDataService : IDataService
    {
        private DatalService _dataService;
        private readonly CachedData _cachedData = new CachedData();

        private Dictionary<DateTime, string> _cacheEmulator = new Dictionary<DateTime, string>();

        public string GetData()
        {
            var useCache = _cachedData.ExpirationDate > DateTime.Now;
            if (useCache)
            {
                Console.WriteLine("Use cached value...");
                return _cachedData.Value;
            }
            else
            {
                Console.WriteLine("Use real data...");
                if (_dataService == null)
                {
                    _dataService = new DatalService();
                }

                var data = _dataService.GetData();

                _cachedData.Value = data;
                _cachedData.ExpirationDate = DateTime.Now.AddSeconds(3);

                return data;
            }
        }
    }
}
