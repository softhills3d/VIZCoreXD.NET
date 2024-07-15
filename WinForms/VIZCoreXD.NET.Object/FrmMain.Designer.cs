﻿namespace VIZCoreXD.NET.Sample
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
            this.btnDeleteWithModelEdge = new System.Windows.Forms.Button();
            this.btnOffsetMove = new System.Windows.Forms.Button();
            this.btnSamePosition = new System.Windows.Forms.Button();
            this.btnMirror = new System.Windows.Forms.Button();
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
            this.groupBox3.Controls.Add(this.btnDeleteWithModelEdge);
            this.groupBox3.Controls.Add(this.btnOffsetMove);
            this.groupBox3.Controls.Add(this.btnSamePosition);
            this.groupBox3.Controls.Add(this.btnMirror);
            this.groupBox3.Location = new System.Drawing.Point(12, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 141);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit";
            // 
            // btnDeleteWithModelEdge
            // 
            this.btnDeleteWithModelEdge.Location = new System.Drawing.Point(6, 107);
            this.btnDeleteWithModelEdge.Name = "btnDeleteWithModelEdge";
            this.btnDeleteWithModelEdge.Size = new System.Drawing.Size(265, 23);
            this.btnDeleteWithModelEdge.TabIndex = 5;
            this.btnDeleteWithModelEdge.Text = "Delete With Model Edge ";
            this.btnDeleteWithModelEdge.UseVisualStyleBackColor = true;
            this.btnDeleteWithModelEdge.Click += new System.EventHandler(this.btnDeleteWithModelEdge_Click);
            // 
            // btnOffsetMove
            // 
            this.btnOffsetMove.Location = new System.Drawing.Point(6, 78);
            this.btnOffsetMove.Name = "btnOffsetMove";
            this.btnOffsetMove.Size = new System.Drawing.Size(265, 23);
            this.btnOffsetMove.TabIndex = 2;
            this.btnOffsetMove.Text = "Move With Measure Model Offset Move";
            this.btnOffsetMove.UseVisualStyleBackColor = true;
            this.btnOffsetMove.Click += new System.EventHandler(this.btnOffsetMove_Click);
            // 
            // btnSamePosition
            // 
            this.btnSamePosition.Location = new System.Drawing.Point(6, 49);
            this.btnSamePosition.Name = "btnSamePosition";
            this.btnSamePosition.Size = new System.Drawing.Size(265, 23);
            this.btnSamePosition.TabIndex = 1;
            this.btnSamePosition.Text = "Move With Measure Model Same Position";
            this.btnSamePosition.UseVisualStyleBackColor = true;
            this.btnSamePosition.Click += new System.EventHandler(this.btnSamePosition_Click);
            // 
            // btnMirror
            // 
            this.btnMirror.Location = new System.Drawing.Point(6, 20);
            this.btnMirror.Name = "btnMirror";
            this.btnMirror.Size = new System.Drawing.Size(265, 23);
            this.btnMirror.TabIndex = 0;
            this.btnMirror.Text = "Mirror";
            this.btnMirror.UseVisualStyleBackColor = true;
            this.btnMirror.Click += new System.EventHandler(this.btnMirror_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteObj);
            this.groupBox2.Controls.Add(this.btnClearObj);
            this.groupBox2.Controls.Add(this.btnAddModel);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 57);
            this.groupBox2.TabIndex = 4;
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
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbViewMode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 57);
            this.groupBox1.TabIndex = 3;
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
            this.Text = "VIZCoreXD.NET.Object";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbViewMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteObj;
        private System.Windows.Forms.Button btnClearObj;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOffsetMove;
        private System.Windows.Forms.Button btnSamePosition;
        private System.Windows.Forms.Button btnMirror;
        private System.Windows.Forms.Button btnDeleteWithModelEdge;
    }
}

