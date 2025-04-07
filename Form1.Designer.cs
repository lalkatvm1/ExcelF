namespace ExcelF
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
            CmdButton = new Button();
            SelectFile = new Button();
            textBox1 = new TextBox();
            StatusLabelConst = new Label();
            StatusLabel = new Label();
            OldStandartCSV = new RadioButton();
            NewStandart = new RadioButton();
            SaveToButton = new Button();
            SaveToTB = new TextBox();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // CmdButton
            // 
            CmdButton.Location = new Point(362, 99);
            CmdButton.Name = "CmdButton";
            CmdButton.Size = new Size(75, 44);
            CmdButton.TabIndex = 0;
            CmdButton.Text = "Convert";
            CmdButton.UseVisualStyleBackColor = true;
            CmdButton.Click += button1_Click;
            // 
            // SelectFile
            // 
            SelectFile.Location = new Point(362, 12);
            SelectFile.Name = "SelectFile";
            SelectFile.Size = new Size(75, 23);
            SelectFile.TabIndex = 1;
            SelectFile.Text = "File";
            SelectFile.UseVisualStyleBackColor = true;
            SelectFile.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Choose file for convertation";
            // 
            // StatusLabelConst
            // 
            StatusLabelConst.AutoSize = true;
            StatusLabelConst.Location = new Point(14, 56);
            StatusLabelConst.Name = "StatusLabelConst";
            StatusLabelConst.Size = new Size(45, 15);
            StatusLabelConst.TabIndex = 3;
            StatusLabelConst.Text = "Status: ";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.ForeColor = Color.Red;
            StatusLabel.Location = new Point(52, 56);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(89, 15);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "no secected file";
            // 
            // OldStandartCSV
            // 
            OldStandartCSV.AutoSize = true;
            OldStandartCSV.Location = new Point(178, 99);
            OldStandartCSV.Name = "OldStandartCSV";
            OldStandartCSV.Size = new Size(110, 19);
            OldStandartCSV.TabIndex = 5;
            OldStandartCSV.TabStop = true;
            OldStandartCSV.Text = "Old standart csv";
            OldStandartCSV.UseVisualStyleBackColor = true;
            // 
            // NewStandart
            // 
            NewStandart.AutoSize = true;
            NewStandart.Location = new Point(178, 124);
            NewStandart.Name = "NewStandart";
            NewStandart.Size = new Size(115, 19);
            NewStandart.TabIndex = 6;
            NewStandart.TabStop = true;
            NewStandart.Text = "New standart csv";
            NewStandart.UseVisualStyleBackColor = true;
            // 
            // SaveToButton
            // 
            SaveToButton.Location = new Point(362, 180);
            SaveToButton.Name = "SaveToButton";
            SaveToButton.Size = new Size(75, 23);
            SaveToButton.TabIndex = 7;
            SaveToButton.Text = "Save to";
            SaveToButton.UseVisualStyleBackColor = true;
            SaveToButton.Click += SaveToButton_Click;
            // 
            // SaveToTB
            // 
            SaveToTB.Location = new Point(14, 180);
            SaveToTB.Name = "SaveToTB";
            SaveToTB.Size = new Size(342, 23);
            SaveToTB.TabIndex = 8;
            SaveToTB.Text = "Select the directory";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(362, 209);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 280);
            Controls.Add(SaveButton);
            Controls.Add(SaveToTB);
            Controls.Add(SaveToButton);
            Controls.Add(NewStandart);
            Controls.Add(OldStandartCSV);
            Controls.Add(StatusLabel);
            Controls.Add(StatusLabelConst);
            Controls.Add(textBox1);
            Controls.Add(SelectFile);
            Controls.Add(CmdButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "FileBuilder";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdButton;
        private Button SelectFile;
        private TextBox textBox1;
        private Label StatusLabelConst;
        private Label StatusLabel;
        private RadioButton OldStandartCSV;
        private RadioButton NewStandart;
        private Button SaveToButton;
        private TextBox SaveToTB;
        private Button SaveButton;
    }
}
