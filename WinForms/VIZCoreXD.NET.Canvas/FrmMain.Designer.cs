﻿namespace VIZCoreXD.NET.VIEW
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCanvasSize = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnCanvasBackgoundReverse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCanvasIndex = new System.Windows.Forms.ComboBox();
            this.btnCanvasFit = new System.Windows.Forms.Button();
            this.btnCanvasRemove = new System.Windows.Forms.Button();
            this.btnCanvasAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteObj = new System.Windows.Forms.Button();
            this.btnClearObj = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbViewMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCanvasSize);
            this.groupBox3.Controls.Add(this.txtHeight);
            this.groupBox3.Controls.Add(this.txtWidth);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label);
            this.groupBox3.Controls.Add(this.btnCanvasBackgoundReverse);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbCanvasIndex);
            this.groupBox3.Controls.Add(this.btnCanvasFit);
            this.groupBox3.Controls.Add(this.btnCanvasRemove);
            this.groupBox3.Controls.Add(this.btnCanvasAdd);
            this.groupBox3.Location = new System.Drawing.Point(12, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 216);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Canvas";
            // 
            // btnCanvasSize
            // 
            this.btnCanvasSize.Location = new System.Drawing.Point(6, 113);
            this.btnCanvasSize.Name = "btnCanvasSize";
            this.btnCanvasSize.Size = new System.Drawing.Size(265, 23);
            this.btnCanvasSize.TabIndex = 11;
            this.btnCanvasSize.Text = "Setting Canvas Size";
            this.btnCanvasSize.UseVisualStyleBackColor = true;
            this.btnCanvasSize.Click += new System.EventHandler(this.btnCanvasSize_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(68, 86);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(203, 21);
            this.txtHeight.TabIndex = 10;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(68, 61);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(203, 21);
            this.txtWidth.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Height :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 64);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(47, 12);
            this.label.TabIndex = 7;
            this.label.Text = "Width : ";
            // 
            // btnCanvasBackgoundReverse
            // 
            this.btnCanvasBackgoundReverse.Location = new System.Drawing.Point(5, 152);
            this.btnCanvasBackgoundReverse.Name = "btnCanvasBackgoundReverse";
            this.btnCanvasBackgoundReverse.Size = new System.Drawing.Size(170, 23);
            this.btnCanvasBackgoundReverse.TabIndex = 6;
            this.btnCanvasBackgoundReverse.Text = "Backgound Reverse";
            this.btnCanvasBackgoundReverse.UseVisualStyleBackColor = true;
            this.btnCanvasBackgoundReverse.Click += new System.EventHandler(this.btnCanvasBackgoundReverse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Canvas Index";
            // 
            // cbCanvasIndex
            // 
            this.cbCanvasIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCanvasIndex.FormattingEnabled = true;
            this.cbCanvasIndex.Items.AddRange(new object[] {
            "3D",
            "3D / 2D",
            "2D"});
            this.cbCanvasIndex.Location = new System.Drawing.Point(181, 20);
            this.cbCanvasIndex.Name = "cbCanvasIndex";
            this.cbCanvasIndex.Size = new System.Drawing.Size(90, 20);
            this.cbCanvasIndex.TabIndex = 5;
            this.cbCanvasIndex.SelectedIndexChanged += new System.EventHandler(this.cbCanvasIndex_SelectedIndexChanged);
            // 
            // btnCanvasFit
            // 
            this.btnCanvasFit.Location = new System.Drawing.Point(5, 181);
            this.btnCanvasFit.Name = "btnCanvasFit";
            this.btnCanvasFit.Size = new System.Drawing.Size(75, 23);
            this.btnCanvasFit.TabIndex = 2;
            this.btnCanvasFit.Text = "Fit View";
            this.btnCanvasFit.UseVisualStyleBackColor = true;
            this.btnCanvasFit.Click += new System.EventHandler(this.btnCanvasFit_Click);
            // 
            // btnCanvasRemove
            // 
            this.btnCanvasRemove.Location = new System.Drawing.Point(181, 152);
            this.btnCanvasRemove.Name = "btnCanvasRemove";
            this.btnCanvasRemove.Size = new System.Drawing.Size(75, 23);
            this.btnCanvasRemove.TabIndex = 1;
            this.btnCanvasRemove.Text = "Remove";
            this.btnCanvasRemove.UseVisualStyleBackColor = true;
            this.btnCanvasRemove.Click += new System.EventHandler(this.btnCanvasRemove_Click);
            // 
            // btnCanvasAdd
            // 
            this.btnCanvasAdd.Location = new System.Drawing.Point(6, 20);
            this.btnCanvasAdd.Name = "btnCanvasAdd";
            this.btnCanvasAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCanvasAdd.TabIndex = 0;
            this.btnCanvasAdd.Text = "Add";
            this.btnCanvasAdd.UseVisualStyleBackColor = true;
            this.btnCanvasAdd.Click += new System.EventHandler(this.btnCanvasAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteObj);
            this.groupBox2.Controls.Add(this.btnClearObj);
            this.groupBox2.Controls.Add(this.btnAddModel);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 57);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Object";
            // 
            // btnDeleteObj
            // 
            this.btnDeleteObj.Location = new System.Drawing.Point(101, 20);
            this.btnDeleteObj.Name = "btnDeleteObj";
            this.btnDeleteObj.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteObj.TabIndex = 2;
            this.btnDeleteObj.Text = "Delete";
            this.btnDeleteObj.UseVisualStyleBackColor = true;
            this.btnDeleteObj.Click += new System.EventHandler(this.btnDeleteObj_Click);
            // 
            // btnClearObj
            // 
            this.btnClearObj.Location = new System.Drawing.Point(196, 20);
            this.btnClearObj.Name = "btnClearObj";
            this.btnClearObj.Size = new System.Drawing.Size(75, 23);
            this.btnClearObj.TabIndex = 1;
            this.btnClearObj.Text = "Clear";
            this.btnClearObj.UseVisualStyleBackColor = true;
            this.btnClearObj.Click += new System.EventHandler(this.btnClearObj_Click);
            // 
            // btnAddModel
            // 
            this.btnAddModel.Location = new System.Drawing.Point(6, 20);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(75, 23);
            this.btnAddModel.TabIndex = 0;
            this.btnAddModel.Text = "Model";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddObject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbViewMode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // cbViewMode
            // 
            this.cbViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbViewMode.FormattingEnabled = true;
            this.cbViewMode.Items.AddRange(new object[] {
            "3D",
            "3D / 2D",
            "2D"});
            this.cbViewMode.Location = new System.Drawing.Point(181, 22);
            this.cbViewMode.Name = "cbViewMode";
            this.cbViewMode.Size = new System.Drawing.Size(90, 20);
            this.cbViewMode.TabIndex = 3;
            this.cbViewMode.SelectedIndexChanged += new System.EventHandler(this.cbViewMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Mode";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 20);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "VIZCoreXD.NET.Canvas";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.ComboBox cbViewMode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCanvasAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteObj;
        private System.Windows.Forms.Button btnClearObj;
        private System.Windows.Forms.Button btnCanvasFit;
        private System.Windows.Forms.Button btnCanvasRemove;
        private System.Windows.Forms.ComboBox cbCanvasIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCanvasBackgoundReverse;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnCanvasSize;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label3;
    }
}

