using System;
using System.Diagnostics;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Image = System.Drawing.Image;
using Rectangle = iTextSharp.text.Rectangle;


namespace PDF_Print_Align
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDGV_FileName();
            string startupDirectory = Application.StartupPath;
            string imagePath = System.IO.Path.Combine(startupDirectory, "logo.PNG");

            if (System.IO.File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void InitializeDGV_FileName()
        {
            DGV_FileName.DataSource = null;
            DGV_FileName.Rows.Clear();

            if (DGV_FileName.Columns.Count == 0)
            {
                DGV_FileName.Columns.Add("PDFNAME", "PDF Name");

            }
            ResizeDataGridView(DGV_FileName);
        }
        private void Txtbx_SDir_TextChanged(object sender, EventArgs e)
        {
            InitializeDGV_FileName();
            LoadDGV_FileName();
        }
        private void LoadDGV_FileName()
        {
            string ResultPath = Path.Combine(Txtbx_SDir.Text, "Result");
            if (Directory.Exists(ResultPath))
            {
                DeleteFolderContents(ResultPath);
            }
            DGV_FileName.Rows.Clear();
            string sourcePath = Txtbx_SDir.Text;
            string[] pdfFiles;
            if (Directory.Exists(sourcePath))
            {
                pdfFiles = Directory.GetFiles(sourcePath, "*.pdf", SearchOption.AllDirectories);

                foreach (string filePath in pdfFiles)
                {
                    string fileName = Path.GetFileName(filePath);
                    DGV_FileName.Rows.Add(fileName);
                }
                ResizeDataGridView(DGV_FileName);
            }
        }
        private void ResizeDataGridView(DataGridView dgv)
        {
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            int totalWidth = dgv.Columns.Cast<DataGridViewColumn>().Sum(col => col.Width);
            int availableWidth = dgv.ClientSize.Width;
            if (availableWidth > totalWidth)
            {
                float scaleFactor = (float)availableWidth / totalWidth;
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.Width = (int)(column.Width * scaleFactor);
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (RB_portrait.Checked || RB_landscape.Checked)
            {
                string ResultPath = Path.Combine(Txtbx_SDir.Text, "Result");
                string sourcePath = Txtbx_SDir.Text;
                string[] pdfFiles;
                if (!Directory.Exists(ResultPath)) {
                    Directory.CreateDirectory(ResultPath);
                }
                pdfFiles = Directory.GetFiles(sourcePath, "*.pdf", SearchOption.AllDirectories);

                foreach (string filePath in pdfFiles)
                {
                    string fileName = Path.GetFileName(filePath);
                    string outFile = Path.Combine(ResultPath, fileName);
                    RotatePDF(filePath, outFile);

                }
            }
        }
        private void RotatePDF(string inputFilePath, string outputFilePath)
        {
            using (PdfReader reader = new PdfReader(inputFilePath))
            {
                using (FileStream fs = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                {
                    using (PdfStamper stamper = new PdfStamper(reader, fs))
                    {
                        int pageCount = reader.NumberOfPages;
                        for (int i = 1; i <= pageCount; i++)
                        {
                            Rectangle pageSize = reader.GetPageSizeWithRotation(i);
                            if (RB_portrait.Checked)
                            {
                                if (pageSize.Width > pageSize.Height) // Check if the page is landscape
                                {
                                    PdfDictionary page = reader.GetPageN(i);
                                    PdfNumber rotate = page.GetAsNumber(PdfName.ROTATE);
                                    int rotation = rotate == null ? 0 : rotate.IntValue;
                                    page.Put(PdfName.ROTATE, new PdfNumber((rotation + 90) % 360)); // Rotate 90 degrees
                                }
                            }else
                            {
                                if (pageSize.Width < pageSize.Height) // Check if the page is portrait
                                {
                                    PdfDictionary page = reader.GetPageN(i);
                                    PdfNumber rotate = page.GetAsNumber(PdfName.ROTATE);
                                    int rotation = rotate == null ? 0 : rotate.IntValue;
                                    page.Put(PdfName.ROTATE, new PdfNumber((rotation + 270) % 360)); // Rotate 90 degrees
                                }
                            }
                        }
                    }
                }
            }
        }
        private void DeleteFolderContents(string folderPath)
        {
            try
            {
                if (Directory.Exists(folderPath)) { 
                    foreach (string filePath in Directory.GetFiles(folderPath))
                    {
                        File.Delete(filePath);
                    }
                    foreach (string subDirPath in Directory.GetDirectories(folderPath))
                    {
                        DeleteFolderContents(subDirPath); // Recursive call
                        Directory.Delete(subDirPath);
                    }

                    Debug.WriteLine($"Contents of folder '{folderPath}' deleted successfully.");
                }
                else
                {
                    Debug.WriteLine($"Folder '{folderPath}' does not exist.");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Debug.WriteLine($"UnauthorizedAccessException: {ex.Message}. Check permissions or file locking issues.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error deleting contents of folder '{folderPath}': {ex.Message}");
            }
        }
    }
}
