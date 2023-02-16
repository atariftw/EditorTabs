
namespace EditorTabs
{
    partial class Interface
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
            this.EditorTabs = new System.Windows.Forms.TabControl();
            this.RemoveTabButton = new System.Windows.Forms.Button();
            this.AddTabButton = new System.Windows.Forms.Button();
            this.Execute = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.ExecuteFile = new System.Windows.Forms.Button();
            this.Attach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditorTabs
            // 
            this.EditorTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.EditorTabs.Location = new System.Drawing.Point(12, 12);
            this.EditorTabs.Name = "EditorTabs";
            this.EditorTabs.SelectedIndex = 0;
            this.EditorTabs.Size = new System.Drawing.Size(590, 262);
            this.EditorTabs.TabIndex = 0;
            // 
            // RemoveTabButton
            // 
            this.RemoveTabButton.Location = new System.Drawing.Point(523, 11);
            this.RemoveTabButton.Name = "RemoveTabButton";
            this.RemoveTabButton.Size = new System.Drawing.Size(77, 20);
            this.RemoveTabButton.TabIndex = 1;
            this.RemoveTabButton.Text = "Remove Tab";
            this.RemoveTabButton.UseVisualStyleBackColor = true;
            this.RemoveTabButton.Click += new System.EventHandler(this.RemoveTabButton_Click);
            // 
            // AddTabButton
            // 
            this.AddTabButton.Location = new System.Drawing.Point(465, 11);
            this.AddTabButton.Name = "AddTabButton";
            this.AddTabButton.Size = new System.Drawing.Size(56, 20);
            this.AddTabButton.TabIndex = 2;
            this.AddTabButton.Text = "Add Tab";
            this.AddTabButton.UseVisualStyleBackColor = true;
            this.AddTabButton.Click += new System.EventHandler(this.AddTabButton_Click);
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(12, 280);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(81, 35);
            this.Execute.TabIndex = 3;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.ExecutionHandler);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(99, 280);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(81, 35);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.ExecutionHandler);
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(186, 280);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(81, 35);
            this.OpenFile.TabIndex = 5;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.ExecutionHandler);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(273, 280);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(81, 35);
            this.SaveFile.TabIndex = 6;
            this.SaveFile.Text = "Save File";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.ExecutionHandler);
            // 
            // ExecuteFile
            // 
            this.ExecuteFile.Location = new System.Drawing.Point(360, 280);
            this.ExecuteFile.Name = "ExecuteFile";
            this.ExecuteFile.Size = new System.Drawing.Size(81, 35);
            this.ExecuteFile.TabIndex = 7;
            this.ExecuteFile.Text = "Execute File";
            this.ExecuteFile.UseVisualStyleBackColor = true;
            this.ExecuteFile.Click += new System.EventHandler(this.ExecutionHandler);
            // 
            // Attach
            // 
            this.Attach.Location = new System.Drawing.Point(519, 280);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(81, 35);
            this.Attach.TabIndex = 8;
            this.Attach.Text = "Attach";
            this.Attach.UseVisualStyleBackColor = true;
            this.Attach.Click += new System.EventHandler(this.ExecutionHandler);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 327);
            this.Controls.Add(this.Attach);
            this.Controls.Add(this.ExecuteFile);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.AddTabButton);
            this.Controls.Add(this.RemoveTabButton);
            this.Controls.Add(this.EditorTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorTabs";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EditorTabs;
        private System.Windows.Forms.Button RemoveTabButton;
        private System.Windows.Forms.Button AddTabButton;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button ExecuteFile;
        private System.Windows.Forms.Button Attach;
    }
}

