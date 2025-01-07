namespace PDF_Print_Align
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            P_Dir = new Panel();
            P_pic = new Panel();
            P_PicBox = new Panel();
            pictureBox1 = new PictureBox();
            P_UpSpacing = new Panel();
            P_DownSpaceing = new Panel();
            label2 = new Label();
            label1 = new Label();
            Txtbx_SDir = new TextBox();
            P_Ctrl = new Panel();
            P_body = new Panel();
            DGV_FileName = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_Start = new Button();
            RB_portrait = new RadioButton();
            RB_landscape = new RadioButton();
            P_Dir.SuspendLayout();
            P_pic.SuspendLayout();
            P_PicBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            P_Ctrl.SuspendLayout();
            P_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_FileName).BeginInit();
            SuspendLayout();
            // 
            // P_Dir
            // 
            P_Dir.Controls.Add(P_pic);
            P_Dir.Controls.Add(label2);
            P_Dir.Controls.Add(label1);
            P_Dir.Controls.Add(Txtbx_SDir);
            P_Dir.Dock = DockStyle.Top;
            P_Dir.Location = new Point(0, 0);
            P_Dir.Name = "P_Dir";
            P_Dir.Size = new Size(980, 122);
            P_Dir.TabIndex = 1;
            // 
            // P_pic
            // 
            P_pic.Controls.Add(P_PicBox);
            P_pic.Controls.Add(P_UpSpacing);
            P_pic.Controls.Add(P_DownSpaceing);
            P_pic.Dock = DockStyle.Left;
            P_pic.Location = new Point(0, 0);
            P_pic.Name = "P_pic";
            P_pic.Size = new Size(149, 122);
            P_pic.TabIndex = 4;
            // 
            // P_PicBox
            // 
            P_PicBox.Controls.Add(pictureBox1);
            P_PicBox.Dock = DockStyle.Fill;
            P_PicBox.Location = new Point(0, 15);
            P_PicBox.Name = "P_PicBox";
            P_PicBox.Size = new Size(149, 95);
            P_PicBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 95);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // P_UpSpacing
            // 
            P_UpSpacing.Dock = DockStyle.Top;
            P_UpSpacing.Location = new Point(0, 0);
            P_UpSpacing.Name = "P_UpSpacing";
            P_UpSpacing.Size = new Size(149, 15);
            P_UpSpacing.TabIndex = 1;
            // 
            // P_DownSpaceing
            // 
            P_DownSpaceing.Dock = DockStyle.Bottom;
            P_DownSpaceing.Location = new Point(0, 110);
            P_DownSpaceing.Name = "P_DownSpaceing";
            P_DownSpaceing.Size = new Size(149, 12);
            P_DownSpaceing.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(155, 9);
            label2.Name = "label2";
            label2.Size = new Size(222, 30);
            label2.TabIndex = 3;
            label2.Text = "PDF Print Align";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 46);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 2;
            label1.Text = "Source Directory";
            // 
            // Txtbx_SDir
            // 
            Txtbx_SDir.Location = new Point(155, 64);
            Txtbx_SDir.Name = "Txtbx_SDir";
            Txtbx_SDir.Size = new Size(633, 23);
            Txtbx_SDir.TabIndex = 1;
            Txtbx_SDir.TextChanged += Txtbx_SDir_TextChanged;
            // 
            // P_Ctrl
            // 
            P_Ctrl.Controls.Add(RB_landscape);
            P_Ctrl.Controls.Add(RB_portrait);
            P_Ctrl.Controls.Add(btn_Start);
            P_Ctrl.Dock = DockStyle.Right;
            P_Ctrl.Location = new Point(833, 122);
            P_Ctrl.Name = "P_Ctrl";
            P_Ctrl.Size = new Size(147, 403);
            P_Ctrl.TabIndex = 2;
            // 
            // P_body
            // 
            P_body.Controls.Add(DGV_FileName);
            P_body.Controls.Add(panel1);
            P_body.Controls.Add(panel2);
            P_body.Dock = DockStyle.Fill;
            P_body.Location = new Point(0, 122);
            P_body.Name = "P_body";
            P_body.Size = new Size(833, 403);
            P_body.TabIndex = 3;
            // 
            // DGV_FileName
            // 
            DGV_FileName.AllowUserToAddRows = false;
            DGV_FileName.AllowUserToDeleteRows = false;
            DGV_FileName.AllowUserToResizeColumns = false;
            DGV_FileName.AllowUserToResizeRows = false;
            DGV_FileName.BackgroundColor = SystemColors.ButtonFace;
            DGV_FileName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_FileName.Dock = DockStyle.Fill;
            DGV_FileName.GridColor = Color.Gray;
            DGV_FileName.Location = new Point(36, 0);
            DGV_FileName.MultiSelect = false;
            DGV_FileName.Name = "DGV_FileName";
            DGV_FileName.ReadOnly = true;
            DGV_FileName.RowHeadersVisible = false;
            DGV_FileName.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DGV_FileName.ShowCellErrors = false;
            DGV_FileName.ShowCellToolTips = false;
            DGV_FileName.ShowEditingIcon = false;
            DGV_FileName.ShowRowErrors = false;
            DGV_FileName.Size = new Size(797, 369);
            DGV_FileName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(36, 369);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 369);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 34);
            panel2.TabIndex = 2;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(9, 95);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(129, 67);
            btn_Start.TabIndex = 0;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += start_Click;
            // 
            // RB_portrait
            // 
            RB_portrait.AutoSize = true;
            RB_portrait.Location = new Point(9, 25);
            RB_portrait.Name = "RB_portrait";
            RB_portrait.Size = new Size(64, 19);
            RB_portrait.TabIndex = 1;
            RB_portrait.TabStop = true;
            RB_portrait.Text = "Portrait";
            RB_portrait.UseVisualStyleBackColor = true;
            // 
            // RB_landscape
            // 
            RB_landscape.AutoSize = true;
            RB_landscape.Location = new Point(9, 50);
            RB_landscape.Name = "RB_landscape";
            RB_landscape.Size = new Size(81, 19);
            RB_landscape.TabIndex = 2;
            RB_landscape.TabStop = true;
            RB_landscape.Text = "Landscape";
            RB_landscape.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 525);
            Controls.Add(P_body);
            Controls.Add(P_Ctrl);
            Controls.Add(P_Dir);
            Name = "Form1";
            Text = "Form1";
            P_Dir.ResumeLayout(false);
            P_Dir.PerformLayout();
            P_pic.ResumeLayout(false);
            P_PicBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            P_Ctrl.ResumeLayout(false);
            P_Ctrl.PerformLayout();
            P_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_FileName).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel P_Dir;
        private Label label2;
        private Label label1;
        private TextBox Txtbx_SDir;
        private Panel P_Ctrl;
        private Panel P_body;
        private DataGridView DGV_FileName;
        private Panel P_pic;
        private Panel P_PicBox;
        private Panel P_UpSpacing;
        private Panel P_DownSpaceing;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private RadioButton RB_landscape;
        private RadioButton RB_portrait;
        private Button btn_Start;
    }
}
