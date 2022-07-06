namespace QuizBS
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnPrievQuestion = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pnlAnswers = new System.Windows.Forms.Panel();
            this.cBoxD = new System.Windows.Forms.CheckBox();
            this.cBoxC = new System.Windows.Forms.CheckBox();
            this.cBoxB = new System.Windows.Forms.CheckBox();
            this.cBoxA = new System.Windows.Forms.CheckBox();
            this.questionBindingForms = new System.Windows.Forms.BindingSource(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlQuestion.SuspendLayout();
            this.pnlAnswers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingForms)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnNextQuestion);
            this.pnlHeader.Controls.Add(this.btnFinish);
            this.pnlHeader.Controls.Add(this.btnPrievQuestion);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(685, 40);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnNextQuestion.TabIndex = 5;
            this.btnNextQuestion.Text = ">";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(480, 38);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnPrievQuestion
            // 
            this.btnPrievQuestion.Location = new System.Drawing.Point(36, 38);
            this.btnPrievQuestion.Name = "btnPrievQuestion";
            this.btnPrievQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnPrievQuestion.TabIndex = 3;
            this.btnPrievQuestion.Text = "<";
            this.btnPrievQuestion.UseVisualStyleBackColor = true;
            this.btnPrievQuestion.Click += new System.EventHandler(this.btnPrievQuestion_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(342, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Test Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Controls.Add(this.lblId);
            this.pnlQuestion.Controls.Add(this.lblQuestion);
            this.pnlQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuestion.Location = new System.Drawing.Point(0, 100);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(800, 161);
            this.pnlQuestion.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(36, 19);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(55, 15);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            // 
            // pnlAnswers
            // 
            this.pnlAnswers.Controls.Add(this.cBoxD);
            this.pnlAnswers.Controls.Add(this.cBoxC);
            this.pnlAnswers.Controls.Add(this.cBoxB);
            this.pnlAnswers.Controls.Add(this.cBoxA);
            this.pnlAnswers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnswers.Location = new System.Drawing.Point(0, 261);
            this.pnlAnswers.Name = "pnlAnswers";
            this.pnlAnswers.Size = new System.Drawing.Size(800, 184);
            this.pnlAnswers.TabIndex = 2;
            // 
            // cBoxD
            // 
            this.cBoxD.AutoSize = true;
            this.cBoxD.Location = new System.Drawing.Point(12, 139);
            this.cBoxD.Name = "cBoxD";
            this.cBoxD.Size = new System.Drawing.Size(83, 19);
            this.cBoxD.TabIndex = 3;
            this.cBoxD.Text = "checkBox2";
            this.cBoxD.UseVisualStyleBackColor = true;
            // 
            // cBoxC
            // 
            this.cBoxC.AutoSize = true;
            this.cBoxC.Location = new System.Drawing.Point(12, 98);
            this.cBoxC.Name = "cBoxC";
            this.cBoxC.Size = new System.Drawing.Size(83, 19);
            this.cBoxC.TabIndex = 2;
            this.cBoxC.Text = "checkBox1";
            this.cBoxC.UseVisualStyleBackColor = true;
            // 
            // cBoxB
            // 
            this.cBoxB.AutoSize = true;
            this.cBoxB.Location = new System.Drawing.Point(12, 58);
            this.cBoxB.Name = "cBoxB";
            this.cBoxB.Size = new System.Drawing.Size(83, 19);
            this.cBoxB.TabIndex = 1;
            this.cBoxB.Text = "checkBox1";
            this.cBoxB.UseVisualStyleBackColor = true;
            // 
            // cBoxA
            // 
            this.cBoxA.AutoSize = true;
            this.cBoxA.Location = new System.Drawing.Point(12, 19);
            this.cBoxA.Name = "cBoxA";
            this.cBoxA.Size = new System.Drawing.Size(83, 19);
            this.cBoxA.TabIndex = 0;
            this.cBoxA.Text = "checkBox1";
            this.cBoxA.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAnswers);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.pnlHeader);
            this.Name = "MainView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            this.pnlAnswers.ResumeLayout(false);
            this.pnlAnswers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingForms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlQuestion;
        private Label lblQuestion;
        private Panel pnlAnswers;
        private CheckBox cBoxD;
        private CheckBox cBoxC;
        private CheckBox cBoxB;
        private CheckBox cBoxA;
        private BindingSource questionBindingForms;
        private Label lblId;
        private Button btnPrievQuestion;
        private Button btnFinish;
        private Button btnNextQuestion;
    }
}