using Seek.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Seek.Scrape
{
    internal class AnalyseGenerate
    {
        private readonly Jobs jobs = new Jobs() { };

        private static void Main(string[] args)
        {



            WriteClassesToFile();


            Console.ReadKey();
        }

        public static void WriteClassesToFile()
        {
            IEnumerable<Jobs> jobsList = Jobs.CreateList();
            string location = @"C:\Users\Odin\Desktop\Output";
            string filename = "output";
            int i = 0;

            foreach (Jobs job in jobsList)
            {
                string temp = "";
                string jobname = RemoveAllWhiteSpace(job.Name);

                using (TextWriter writer = new StreamWriter(Path.Combine(location, jobname + ".cs")))
                {
                    string tempfilename = filename + ".txt" + i.ToString();
                    string file = Path.Combine(location, tempfilename);
                    int lines = File.ReadAllLines(file).Length;

                    using (TextReader reader = new StreamReader(file))
                    {
                        for (int x = 0; x < lines; x += 2)
                        {
                            string name = reader.ReadLine();
                            string Uri = reader.ReadLine();
                            temp += VarTemplate(jobname, name, Uri);
                        }
                    }
                    writer.Write(ClassTemplate(jobname) + temp + EndTemplate());
                    ++i;
                }
                Console.WriteLine(jobname + " done.");
            }
        }

        public static string RemoveAllWhiteSpace(string text)
        {
            string temp = Regex.Replace(text, @"[^a-zA-Z0-9 -]", "");
            return Regex.Replace(temp, @"\s+", "");
        }

        public static string ClassTemplate(string className)
        {
            return "using System.Collections.Generic;\n\nnamespace SeekData.SubJobs\n{\n\tpublic class " + className + "\n\t{\n\t\tpublic string Name { get; set; }\n\t\tpublic string Uri { get; set; }\n\n\t\tpublic static List<" + className + "> CreateList()\n\t\t{\n\t\t\treturn new List<" + className + ">\n\t\t\t{\n";
        }

        public static string VarTemplate(string className, string Name, string Uri)
        {
            return "\t\t\t\tnew " + className + " { Name = \"" + Name + "\"," + " Uri=\"" + Uri + "\" },\n";
        }

        public static string EndTemplate()
        {
            return "\t\t\t};\n\t\t}\n\t}\n}";
        }


        public static void GetSubJobData()
        {
            string location = @"C:\Users\Odin\Desktop\Output";
            string filename = "output";

            IEnumerable<Jobs> jobsList = Jobs.CreateList();
            WebClient client = new WebClient();

            int i = 0;
            foreach (Jobs item in jobsList)
            {
                string html = client.DownloadString("https://www.seek.com.au" + item.Uri);
                WriteTextAndToConsole(html, location, filename + i.ToString() + ".txt");
                ++i;
            }
        }

        public static void WriteTextAndToConsole(string html, string location, string filename)
        {
            using (TextWriter writer = new StreamWriter(Path.Combine(location, filename)))
            {
                foreach (LinkItem link in LinkFinder.Find(html))
                {
                    Console.WriteLine(link);
                    writer.WriteLine(link);
                }
            }
        }

        public static void WriteText(List<string> text, string location, string filename)
        {
            using (TextWriter writer = new StreamWriter(Path.Combine(location, filename)))
            {
                foreach (string item in text)
                {
                    writer.WriteLine(text);
                }
            }
        }

        public static string GetLinkString(string text)
        {
            try
            {
                string FirstString = "<a href=\"";
                string LastString = "\" rel=\"";

                int Pos1 = text.IndexOf(FirstString) + FirstString.Length;
                int Pos2 = text.IndexOf(LastString);
                return text.Substring(Pos1, Pos2 - Pos1);
            }
            catch (Exception)
            {
                Console.Write("");
                return null;
            }
        }

        public static string GetLabelString(string text)
        {
            try
            {
                string FirstString = "aria-label=\"";
                string LastString = " \" class=";

                int Pos1 = text.IndexOf(FirstString) + FirstString.Length;
                int Pos2 = text.IndexOf(LastString);
                return text.Substring(Pos1, Pos2 - Pos1);
            }
            catch (Exception)
            {
                Console.Write("");
                return null;
            }
        }

        public static string RemoveString(string text)
        {
            try
            {
                string removeString = " &amp;";
                int index = text.IndexOf(removeString);
                return (index < 0) ? text : text.Remove(index, text.Length);
            }
            catch (Exception)
            {
                Console.Write("");
                return null;
            }
        }
    }
}



