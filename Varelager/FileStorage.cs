using System.IO;

namespace Varelager
{
    public class FileStorage : MemoryStorage
    {
        public static FileStorage LoadFromFile(string path)
        {
            var storage = new FileStorage(path);
            if (!File.Exists(path)) return storage;
            
            using (var reader = File.OpenText(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var item = ParseItem(line);
                    storage.Items.Add(item);
                }
            }

            return storage;
        }

        private static Item ParseItem(string line)
        {
            var parts = line.Split(',');

            var amount = int.Parse(parts[0]);
            var name = parts[1];

            return new Item(name, amount);
        }

        private static string SerializeItem(Item item)
        {
            return $"{item.Amount},{item.Name}";
        }

        private readonly string _path;

        public FileStorage(string path)
        {
            _path = path;
        }
        
        public override void AddItem(Item item)
        {
            base.AddItem(item);
            using (var writer = File.AppendText(_path))
                writer.WriteLine(SerializeItem(item));
        }
    }
}