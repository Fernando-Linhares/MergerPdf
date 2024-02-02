namespace MergePdf;

public class Program
{
    public static void Main(string[] args)
    {
        string outputfile = args[0];

        var pdfs = new List<string>();

        for(var i = 1; i< args.Length; i++)
        {
            pdfs.Add(args[i]);

        }

        var record = new PdfRecord(pdfs);

        record.Merged = outputfile;

        record.Merge();

        record.Out();
    }
}
