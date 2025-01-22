using composite = Patterns.Patterns;

namespace Patterns.UseCases
{
    public class CompositeCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(CompositeCase));

            // rootFolder
            //  - firstLevelFolder1
            //      - file1
            //      - file2
            //  - firstLevelFolder2
            //      - secondLevelFolder1
            //          - file3

            var rootFolder = new composite.Directory { Name = "Root" };

            var firstLevelFolder1 = new composite.Directory { Name = "FirstLevelFolder1" };
            var firstLevelFolder2 = new composite.Directory { Name = "FirstLevelFolder2" };
            var secondLevelFolder1 = new composite.Directory { Name = "SecondLevelFolder1" };

            var file1 = new composite.File("file1");
            var file2 = new composite.File("file2");
            var file3 = new composite.File("file3");

            rootFolder.Add(firstLevelFolder1);
            rootFolder.Add(firstLevelFolder2);

            firstLevelFolder1.Add(file1);
            firstLevelFolder1.Add(file2);

            firstLevelFolder2.Add(secondLevelFolder1);

            secondLevelFolder1.Add(file3);

            rootFolder.GetInfo();
        }
    }
}
