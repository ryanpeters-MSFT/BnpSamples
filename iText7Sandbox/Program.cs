using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using iText.Layout;
using iText.Layout.Element;

CreatePageWithText();
MergeTwoPdfs();

// create a new PDF with a basic paragraph
void CreatePageWithText()
{
    var pdfFile = @"docs\newdoc.pdf";

    var writer = new PdfWriter(pdfFile);
    var pdfDocument = new PdfDocument(writer);
    var document = new Document(pdfDocument);

    document.Add(new Paragraph("hello!"));

    document.Close();
}

// merge 2 PDF documents together
void MergeTwoPdfs()
{
    var page1File = @"docs\page1.pdf";
    var page2File = @"docs\page2.pdf";
    var outputFile = @"docs\merged.pdf";

    var mergedDocument = new PdfDocument(new PdfWriter(outputFile));
    var merger = new PdfMerger(mergedDocument);

    var page1Document = new PdfDocument(new PdfReader(page1File));
    var page2Document = new PdfDocument(new PdfReader(page2File));

    merger.Merge(page1Document, 1, page1Document.GetNumberOfPages());
    merger.Merge(page2Document, 1, page2Document.GetNumberOfPages());

    mergedDocument.Close();
    merger.Close();
    page1Document.Close();
    page2Document.Close();
}