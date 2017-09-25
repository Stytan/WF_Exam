namespace WF_Exam
{
    partial class FormExamDesigner
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newExamToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewExam;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonCut;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonPaste;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControlQuestion;
        private System.Windows.Forms.TabPage tabPageQuestion;
        private System.Windows.Forms.TabPage tabPagePreview;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExamDesigner));
        	this.menuStripMain = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.newExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        	this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.examToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.newQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.newExamToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMain = new System.Windows.Forms.ToolStrip();
        	this.toolStripButtonNewExam = new System.Windows.Forms.ToolStripButton();
        	this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
        	this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
        	this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        	this.toolStripButtonCut = new System.Windows.Forms.ToolStripButton();
        	this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
        	this.toolStripButtonPaste = new System.Windows.Forms.ToolStripButton();
        	this.statusStripMain = new System.Windows.Forms.StatusStrip();
        	this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        	this.splitContainer2 = new System.Windows.Forms.SplitContainer();
        	this.tabControlQuestion = new System.Windows.Forms.TabControl();
        	this.tabPageQuestion = new System.Windows.Forms.TabPage();
        	this.tabPagePreview = new System.Windows.Forms.TabPage();
        	this.menuStripMain.SuspendLayout();
        	this.toolStripMain.SuspendLayout();
        	this.statusStripMain.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
        	this.splitContainer1.Panel1.SuspendLayout();
        	this.splitContainer1.Panel2.SuspendLayout();
        	this.splitContainer1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
        	this.splitContainer2.SuspendLayout();
        	this.tabControlQuestion.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// menuStripMain
        	// 
        	this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.editToolStripMenuItem,
			this.examToolStripMenuItem});
        	this.menuStripMain.Location = new System.Drawing.Point(0, 0);
        	this.menuStripMain.Name = "menuStripMain";
        	this.menuStripMain.Size = new System.Drawing.Size(984, 24);
        	this.menuStripMain.TabIndex = 0;
        	this.menuStripMain.Text = "menuStripMain";
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.newExamToolStripMenuItem,
			this.openToolStripMenuItem,
			this.closeToolStripMenuItem,
			this.toolStripSeparator1,
			this.saveToolStripMenuItem,
			this.saveAsToolStripMenuItem,
			this.toolStripSeparator2,
			this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem.Text = "File";
        	// 
        	// newExamToolStripMenuItem
        	// 
        	this.newExamToolStripMenuItem.Name = "newExamToolStripMenuItem";
        	this.newExamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.newExamToolStripMenuItem.Text = "New Exam";
        	// 
        	// openToolStripMenuItem
        	// 
        	this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        	this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.openToolStripMenuItem.Text = "Open";
        	// 
        	// closeToolStripMenuItem
        	// 
        	this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
        	this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.closeToolStripMenuItem.Text = "Close";
        	// 
        	// toolStripSeparator1
        	// 
        	this.toolStripSeparator1.Name = "toolStripSeparator1";
        	this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
        	// 
        	// saveToolStripMenuItem
        	// 
        	this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        	this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.saveToolStripMenuItem.Text = "Save";
        	// 
        	// saveAsToolStripMenuItem
        	// 
        	this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        	this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.saveAsToolStripMenuItem.Text = "Save As...";
        	// 
        	// toolStripSeparator2
        	// 
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.exitToolStripMenuItem.Text = "Exit";
        	// 
        	// editToolStripMenuItem
        	// 
        	this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cutToolStripMenuItem,
			this.copyToolStripMenuItem,
			this.pasteToolStripMenuItem,
			this.deleteToolStripMenuItem});
        	this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        	this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
        	this.editToolStripMenuItem.Text = "Edit";
        	// 
        	// cutToolStripMenuItem
        	// 
        	this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        	this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.cutToolStripMenuItem.Text = "Cut";
        	// 
        	// copyToolStripMenuItem
        	// 
        	this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        	this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.copyToolStripMenuItem.Text = "Copy";
        	// 
        	// pasteToolStripMenuItem
        	// 
        	this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        	this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.pasteToolStripMenuItem.Text = "Paste";
        	// 
        	// deleteToolStripMenuItem
        	// 
        	this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
        	this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.deleteToolStripMenuItem.Text = "Delete";
        	// 
        	// examToolStripMenuItem
        	// 
        	this.examToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.newQuestionToolStripMenuItem,
			this.newExamToolStripMenuItem1});
        	this.examToolStripMenuItem.Name = "examToolStripMenuItem";
        	this.examToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
        	this.examToolStripMenuItem.Text = "Exam";
        	// 
        	// newQuestionToolStripMenuItem
        	// 
        	this.newQuestionToolStripMenuItem.Name = "newQuestionToolStripMenuItem";
        	this.newQuestionToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
        	this.newQuestionToolStripMenuItem.Text = "New Question...";
        	// 
        	// newExamToolStripMenuItem1
        	// 
        	this.newExamToolStripMenuItem1.Name = "newExamToolStripMenuItem1";
        	this.newExamToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
        	this.newExamToolStripMenuItem1.Text = "New Exam";
        	// 
        	// toolStripMain
        	// 
        	this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripButtonNewExam,
			this.toolStripButtonOpen,
			this.toolStripButtonSave,
			this.toolStripSeparator3,
			this.toolStripButtonCut,
			this.toolStripButtonCopy,
			this.toolStripButtonPaste});
        	this.toolStripMain.Location = new System.Drawing.Point(0, 24);
        	this.toolStripMain.Name = "toolStripMain";
        	this.toolStripMain.Size = new System.Drawing.Size(984, 25);
        	this.toolStripMain.TabIndex = 1;
        	this.toolStripMain.Text = "toolStripMain";
        	// 
        	// toolStripButtonNewExam
        	// 
        	this.toolStripButtonNewExam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.toolStripButtonNewExam.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewExam.Image")));
        	this.toolStripButtonNewExam.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripButtonNewExam.Name = "toolStripButtonNewExam";
        	this.toolStripButtonNewExam.Size = new System.Drawing.Size(23, 22);
        	this.toolStripButtonNewExam.Text = "New Exam";
        	// 
        	// toolStripButtonOpen
        	// 
        	this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
        	this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripButtonOpen.Name = "toolStripButtonOpen";
        	this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
        	this.toolStripButtonOpen.Text = "Open";
        	// 
        	// toolStripButtonSave
        	// 
        	this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
        	this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripButtonSave.Name = "toolStripButtonSave";
        	this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
        	this.toolStripButtonSave.Text = "Save";
        	// 
        	// toolStripSeparator3
        	// 
        	this.toolStripSeparator3.Name = "toolStripSeparator3";
        	this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
        	// 
        	// toolStripButtonCut
        	// 
        	this.toolStripButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.toolStripButtonCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCut.Image")));
        	this.toolStripButtonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripButtonCut.Name = "toolStripButtonCut";
        	this.toolStripButtonCut.Size = new System.Drawing.Size(23, 22);
        	this.toolStripButtonCut.Text = "Cut";
        	// 
        	// toolStripButtonCopy
        	// 
        	this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.toolStripButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopy.Image")));
        	this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripButtonCopy.Name = "toolStripButtonCopy";
        	this.toolStripButtonCopy.Size = new System.Drawing.Size(23, 22);
        	this.toolStripButtonCopy.Text = "Copy";
        	// 
        	// toolStripButtonPaste
        	// 
        	this.toolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.toolStripButtonPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPaste.Image")));
        	this.toolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripButtonPaste.Name = "toolStripButtonPaste";
        	this.toolStripButtonPaste.Size = new System.Drawing.Size(23, 22);
        	this.toolStripButtonPaste.Text = "Paste";
        	// 
        	// statusStripMain
        	// 
        	this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel});
        	this.statusStripMain.Location = new System.Drawing.Point(0, 540);
        	this.statusStripMain.Name = "statusStripMain";
        	this.statusStripMain.Size = new System.Drawing.Size(984, 22);
        	this.statusStripMain.TabIndex = 2;
        	this.statusStripMain.Text = "statusStripMain";
        	// 
        	// toolStripStatusLabel
        	// 
        	this.toolStripStatusLabel.Name = "toolStripStatusLabel";
        	this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
        	this.toolStripStatusLabel.Text = "toolStripStatusLabel";
        	// 
        	// splitContainer1
        	// 
        	this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.splitContainer1.Location = new System.Drawing.Point(0, 49);
        	this.splitContainer1.Name = "splitContainer1";
        	// 
        	// splitContainer1.Panel1
        	// 
        	this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
        	// 
        	// splitContainer1.Panel2
        	// 
        	this.splitContainer1.Panel2.Controls.Add(this.tabControlQuestion);
        	this.splitContainer1.Size = new System.Drawing.Size(984, 491);
        	this.splitContainer1.SplitterDistance = 328;
        	this.splitContainer1.TabIndex = 3;
        	// 
        	// splitContainer2
        	// 
        	this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.splitContainer2.Location = new System.Drawing.Point(0, 0);
        	this.splitContainer2.Name = "splitContainer2";
        	this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
        	this.splitContainer2.Size = new System.Drawing.Size(328, 491);
        	this.splitContainer2.SplitterDistance = 290;
        	this.splitContainer2.TabIndex = 0;
        	// 
        	// tabControlQuestion
        	// 
        	this.tabControlQuestion.Alignment = System.Windows.Forms.TabAlignment.Bottom;
        	this.tabControlQuestion.Controls.Add(this.tabPageQuestion);
        	this.tabControlQuestion.Controls.Add(this.tabPagePreview);
        	this.tabControlQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tabControlQuestion.Location = new System.Drawing.Point(0, 0);
        	this.tabControlQuestion.Name = "tabControlQuestion";
        	this.tabControlQuestion.SelectedIndex = 0;
        	this.tabControlQuestion.Size = new System.Drawing.Size(652, 491);
        	this.tabControlQuestion.TabIndex = 0;
        	// 
        	// tabPageQuestion
        	// 
        	this.tabPageQuestion.Location = new System.Drawing.Point(4, 4);
        	this.tabPageQuestion.Name = "tabPageQuestion";
        	this.tabPageQuestion.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPageQuestion.Size = new System.Drawing.Size(644, 465);
        	this.tabPageQuestion.TabIndex = 0;
        	this.tabPageQuestion.Text = "Question";
        	this.tabPageQuestion.UseVisualStyleBackColor = true;
        	// 
        	// tabPagePreview
        	// 
        	this.tabPagePreview.Location = new System.Drawing.Point(4, 4);
        	this.tabPagePreview.Name = "tabPagePreview";
        	this.tabPagePreview.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPagePreview.Size = new System.Drawing.Size(644, 465);
        	this.tabPagePreview.TabIndex = 1;
        	this.tabPagePreview.Text = "Preview";
        	this.tabPagePreview.UseVisualStyleBackColor = true;
        	// 
        	// FormExamDesigner
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(984, 562);
        	this.Controls.Add(this.splitContainer1);
        	this.Controls.Add(this.statusStripMain);
        	this.Controls.Add(this.toolStripMain);
        	this.Controls.Add(this.menuStripMain);
        	this.IsMdiContainer = true;
        	this.MainMenuStrip = this.menuStripMain;
        	this.Name = "FormExamDesigner";
        	this.Text = "Exam Designer";
        	this.menuStripMain.ResumeLayout(false);
        	this.menuStripMain.PerformLayout();
        	this.toolStripMain.ResumeLayout(false);
        	this.toolStripMain.PerformLayout();
        	this.statusStripMain.ResumeLayout(false);
        	this.statusStripMain.PerformLayout();
        	this.splitContainer1.Panel1.ResumeLayout(false);
        	this.splitContainer1.Panel2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
        	this.splitContainer1.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
        	this.splitContainer2.ResumeLayout(false);
        	this.tabControlQuestion.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion
    }
}

