namespace ClubMembershipGraphics
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
            this.listBox_members = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_read = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_members
            // 
            this.listBox_members.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_members.FormattingEnabled = true;
            this.listBox_members.Location = new System.Drawing.Point(0, 0);
            this.listBox_members.Name = "listBox_members";
            this.listBox_members.Size = new System.Drawing.Size(309, 450);
            this.listBox_members.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(309, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 297);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox_member";
            // 
            // button_read
            // 
            this.button_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_read.Location = new System.Drawing.Point(446, 355);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(101, 40);
            this.button_read.TabIndex = 2;
            this.button_read.Text = "Read";
            this.button_read.UseVisualStyleBackColor = true;
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_edit.Location = new System.Drawing.Point(567, 355);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(101, 40);
            this.button_edit.TabIndex = 2;
            this.button_edit.Text = "Submit";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // button_new
            // 
            this.button_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_new.Location = new System.Drawing.Point(324, 355);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(101, 40);
            this.button_new.TabIndex = 2;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete.Location = new System.Drawing.Point(687, 355);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(101, 40);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_members);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_members;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_delete;
    }
}

