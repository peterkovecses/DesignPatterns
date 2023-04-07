namespace Structural.Composite
{
    public abstract class FileSystemItem
    {
        public string Name { get; set; }

        public FileSystemItem(string name)
        {
            Name = name;
        }

        public abstract void Display(int level);
    }

    public class Folder : FileSystemItem
    {
        private List<FileSystemItem> _children = new List<FileSystemItem>();

        public Folder(string name) : base(name) { }

        public void Add(FileSystemItem item)
        {
            _children.Add(item);
        }

        public override void Display(int level = 1)
        {
            Console.WriteLine(new String('-', level) + Name);

            foreach (var item in _children)
            {
                item.Display(level + 1);
            }
        }
    }

    public class File : FileSystemItem
    {
        public File(string name) : base(name) { }

        public override void Display(int level)
        {
            Console.WriteLine(new String('-', level) + Name);
        }
    }
    
    public class Test
    {
        public static void UsePattern()
        {
            Folder root = new Folder("Root");
            Folder documents = new Folder("Documents");
            Folder pictures = new Folder("Pictures");
            File file1 = new File("file1.txt");
            File file2 = new File("file2.txt");
            File picture1 = new File("picture1.jpg");

            root.Add(documents);
            documents.Add(file1);
            documents.Add(file2);
            root.Add(pictures);
            pictures.Add(picture1);

            root.Display();

            // Eredmény
            //-Root
            //--Documents
            //---file1.txt
            //---file2.txt
            //--Pictures
            //---picture1.jpg
        }
    }
}
