namespace Pluvet.Replace
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnToAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.lbTo = new System.Windows.Forms.ListBox();
            this.btnFromAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.lbFrom = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnFromUp = new System.Windows.Forms.Button();
            this.btnFromDown = new System.Windows.Forms.Button();
            this.btnFromDel = new System.Windows.Forms.Button();
            this.btnToDel = new System.Windows.Forms.Button();
            this.btnToDown = new System.Windows.Forms.Button();
            this.btnToUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToAdd
            // 
            this.btnToAdd.Location = new System.Drawing.Point(674, 269);
            this.btnToAdd.Name = "btnToAdd";
            this.btnToAdd.Size = new System.Drawing.Size(42, 23);
            this.btnToAdd.TabIndex = 19;
            this.btnToAdd.Text = "添加";
            this.btnToAdd.UseVisualStyleBackColor = true;
            this.btnToAdd.Click += new System.EventHandler(this.BtnToAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "替换规则";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(596, 270);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(72, 21);
            this.tbTo.TabIndex = 17;
            // 
            // lbTo
            // 
            this.lbTo.FormattingEnabled = true;
            this.lbTo.ItemHeight = 12;
            this.lbTo.Location = new System.Drawing.Point(596, 176);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(120, 88);
            this.lbTo.TabIndex = 16;
            // 
            // btnFromAdd
            // 
            this.btnFromAdd.Location = new System.Drawing.Point(674, 130);
            this.btnFromAdd.Name = "btnFromAdd";
            this.btnFromAdd.Size = new System.Drawing.Size(42, 23);
            this.btnFromAdd.TabIndex = 15;
            this.btnFromAdd.Text = "添加";
            this.btnFromAdd.UseVisualStyleBackColor = true;
            this.btnFromAdd.Click += new System.EventHandler(this.BtnFromAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "查找规则";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(596, 131);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(72, 21);
            this.tbFrom.TabIndex = 13;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(12, 37);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(578, 309);
            this.tbContent.TabIndex = 12;
            this.tbContent.TextChanged += new System.EventHandler(this.TbContent_TextChanged);
            // 
            // lbFrom
            // 
            this.lbFrom.FormattingEnabled = true;
            this.lbFrom.ItemHeight = 12;
            this.lbFrom.Location = new System.Drawing.Point(596, 37);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(120, 88);
            this.lbFrom.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "正文";
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(596, 323);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(120, 23);
            this.btnDo.TabIndex = 19;
            this.btnDo.Text = "执行";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.BtnDo_Click);
            // 
            // btnFromUp
            // 
            this.btnFromUp.Location = new System.Drawing.Point(722, 35);
            this.btnFromUp.Name = "btnFromUp";
            this.btnFromUp.Size = new System.Drawing.Size(42, 23);
            this.btnFromUp.TabIndex = 20;
            this.btnFromUp.Text = "↑";
            this.btnFromUp.UseVisualStyleBackColor = true;
            this.btnFromUp.Click += new System.EventHandler(this.BtnFromUp_Click);
            // 
            // btnFromDown
            // 
            this.btnFromDown.Location = new System.Drawing.Point(722, 64);
            this.btnFromDown.Name = "btnFromDown";
            this.btnFromDown.Size = new System.Drawing.Size(42, 23);
            this.btnFromDown.TabIndex = 20;
            this.btnFromDown.Text = "↓";
            this.btnFromDown.UseVisualStyleBackColor = true;
            this.btnFromDown.Click += new System.EventHandler(this.BtnFromDown_Click);
            // 
            // btnFromDel
            // 
            this.btnFromDel.Location = new System.Drawing.Point(722, 93);
            this.btnFromDel.Name = "btnFromDel";
            this.btnFromDel.Size = new System.Drawing.Size(42, 23);
            this.btnFromDel.TabIndex = 20;
            this.btnFromDel.Text = "╳";
            this.btnFromDel.UseVisualStyleBackColor = true;
            this.btnFromDel.Click += new System.EventHandler(this.BtnFromDel_Click);
            // 
            // btnToDel
            // 
            this.btnToDel.Location = new System.Drawing.Point(722, 234);
            this.btnToDel.Name = "btnToDel";
            this.btnToDel.Size = new System.Drawing.Size(42, 23);
            this.btnToDel.TabIndex = 21;
            this.btnToDel.Text = "╳";
            this.btnToDel.UseVisualStyleBackColor = true;
            this.btnToDel.Click += new System.EventHandler(this.BtnToDel_Click);
            // 
            // btnToDown
            // 
            this.btnToDown.Location = new System.Drawing.Point(722, 205);
            this.btnToDown.Name = "btnToDown";
            this.btnToDown.Size = new System.Drawing.Size(42, 23);
            this.btnToDown.TabIndex = 22;
            this.btnToDown.Text = "↓";
            this.btnToDown.UseVisualStyleBackColor = true;
            this.btnToDown.Click += new System.EventHandler(this.BtnToDown_Click);
            // 
            // btnToUp
            // 
            this.btnToUp.Location = new System.Drawing.Point(722, 176);
            this.btnToUp.Name = "btnToUp";
            this.btnToUp.Size = new System.Drawing.Size(42, 23);
            this.btnToUp.TabIndex = 23;
            this.btnToUp.Text = "↑";
            this.btnToUp.UseVisualStyleBackColor = true;
            this.btnToUp.Click += new System.EventHandler(this.BtnToUp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 375);
            this.Controls.Add(this.btnToDel);
            this.Controls.Add(this.btnToDown);
            this.Controls.Add(this.btnToUp);
            this.Controls.Add(this.btnFromDel);
            this.Controls.Add(this.btnFromDown);
            this.Controls.Add(this.btnFromUp);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnToAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.btnFromAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "Pluvet.Replace 批量正则替换工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.ListBox lbTo;
        private System.Windows.Forms.Button btnFromAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.ListBox lbFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnFromUp;
        private System.Windows.Forms.Button btnFromDown;
        private System.Windows.Forms.Button btnFromDel;
        private System.Windows.Forms.Button btnToDel;
        private System.Windows.Forms.Button btnToDown;
        private System.Windows.Forms.Button btnToUp;
    }
}

