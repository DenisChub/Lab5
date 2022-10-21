using System.Text;

namespace DocumentWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            DocumentWorker documentWorker = null;

            Dictionary<string, string> keys = new Dictionary<string, string>()
            {
                {"exp", 12345678.ToString()}, {"pro", 87654321.ToString()}
            };

            while (true)
            {
                Console.WriteLine("Введіть ліцензійний ключ - [exp/pro] ********");

                string[] message = Console.ReadLine().Split(" ");

                if (message.Length == 2)
                {
                    string value;
                    if (!keys.TryGetValue(message[0], out value))
                    {
                        documentWorker = new DocumentWorker();
                        break;
                    }

                    if (message[1] != value)
                        continue;

                    if (message[0] == "exp")
                    {
                        documentWorker = new ExpertDocumentWorker();
                    }
                    else if (message[0] == "pro")
                    {
                        documentWorker = new ProDocumentWorker();
                    }
                }
                else
                    documentWorker = new DocumentWorker();

                break;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine(documentWorker.Mode);
                Console.WriteLine("Поточний буфер: " + documentWorker.Doc);
                Console.WriteLine("open/edit/save");

                string[] msg = Console.ReadLine().Split(" ");

                if (msg[0] == "open")
                {
                    documentWorker.OpenDocument();
                }
                else if (msg[0] == "edit")
                {
                    documentWorker.EditDocument();
                }
                else if (msg[0] == "save")
                {
                    documentWorker.SaveDocument();
                }

                Console.ReadLine();
            }
        }
    }
}