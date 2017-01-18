namespace UI_WF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxHeight = new System.Windows.Forms.TextBox();
            this.txtboxWidth = new System.Windows.Forms.TextBox();
            this.btnCreateWorld = new System.Windows.Forms.Button();
            this.btnSaveWorld = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxHeight
            // 
            this.txtboxHeight.Location = new System.Drawing.Point(29, 13);
            this.txtboxHeight.Name = "txtboxHeight";
            this.txtboxHeight.Size = new System.Drawing.Size(100, 20);
            this.txtboxHeight.TabIndex = 0;
            this.txtboxHeight.Text = "1";
            // 
            // txtboxWidth
            // 
            this.txtboxWidth.Location = new System.Drawing.Point(152, 13);
            this.txtboxWidth.Name = "txtboxWidth";
            this.txtboxWidth.Size = new System.Drawing.Size(100, 20);
            this.txtboxWidth.TabIndex = 1;
            this.txtboxWidth.Text = "1";
            // 
            // btnCreateWorld
            // 
            this.btnCreateWorld.Location = new System.Drawing.Point(29, 226);
            this.btnCreateWorld.Name = "btnCreateWorld";
            this.btnCreateWorld.Size = new System.Drawing.Size(75, 23);
            this.btnCreateWorld.TabIndex = 2;
            this.btnCreateWorld.Text = "Create world";
            this.btnCreateWorld.UseVisualStyleBackColor = true;
            this.btnCreateWorld.Click += new System.EventHandler(this.btnCreateWorld_Click);
            // 
            // btnSaveWorld
            // 
            this.btnSaveWorld.Location = new System.Drawing.Point(177, 226);
            this.btnSaveWorld.Name = "btnSaveWorld";
            this.btnSaveWorld.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWorld.TabIndex = 3;
            this.btnSaveWorld.Text = "Save world";
            this.btnSaveWorld.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(30, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 177);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 24);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveWorld);
            this.Controls.Add(this.btnCreateWorld);
            this.Controls.Add(this.txtboxWidth);
            this.Controls.Add(this.txtboxHeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxHeight;
        private System.Windows.Forms.TextBox txtboxWidth;
        private System.Windows.Forms.Button btnCreateWorld;
        private System.Windows.Forms.Button btnSaveWorld;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

