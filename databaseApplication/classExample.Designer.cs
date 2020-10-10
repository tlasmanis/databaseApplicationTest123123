namespace databaseApplication
{
    partial class classExample
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
            this.panSettings = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbDatabaseName = new System.Windows.Forms.TextBox();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.panSQL = new System.Windows.Forms.Panel();
            this.dgDBOut = new System.Windows.Forms.DataGridView();
            this.btRead = new System.Windows.Forms.Button();
            this.btWriteComplex = new System.Windows.Forms.Button();
            this.btWriteSimple = new System.Windows.Forms.Button();
            this.tbCreatePostcode = new System.Windows.Forms.TextBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.tbReadName = new System.Windows.Forms.TextBox();
            this.tbCreateName = new System.Windows.Forms.TextBox();
            this.tbCreateNameOnly = new System.Windows.Forms.TextBox();
            this.panSettings.SuspendLayout();
            this.panSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDBOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panSettings
            // 
            this.panSettings.Controls.Add(this.btLogin);
            this.panSettings.Controls.Add(this.tbPassword);
            this.panSettings.Controls.Add(this.tbUsername);
            this.panSettings.Controls.Add(this.tbDatabaseName);
            this.panSettings.Controls.Add(this.tbDatabase);
            this.panSettings.Location = new System.Drawing.Point(12, 12);
            this.panSettings.Name = "panSettings";
            this.panSettings.Size = new System.Drawing.Size(530, 591);
            this.panSettings.TabIndex = 0;
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(3, 167);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(524, 41);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "LOGIN";
            this.btLogin.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(3, 126);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(524, 35);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Text = "tbPassword";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(3, 85);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(524, 35);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.Text = "tbUsername";
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            // 
            // tbDatabaseName
            // 
            this.tbDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatabaseName.Location = new System.Drawing.Point(3, 44);
            this.tbDatabaseName.Name = "tbDatabaseName";
            this.tbDatabaseName.Size = new System.Drawing.Size(524, 35);
            this.tbDatabaseName.TabIndex = 1;
            this.tbDatabaseName.Text = "tbDatabaseName";
            this.tbDatabaseName.Enter += new System.EventHandler(this.tbDatabaseName_Enter);
            // 
            // tbDatabase
            // 
            this.tbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatabase.Location = new System.Drawing.Point(3, 3);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(524, 35);
            this.tbDatabase.TabIndex = 0;
            this.tbDatabase.Text = "tbDatabase";
            this.tbDatabase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbDatabase_MouseDown);
            // 
            // panSQL
            // 
            this.panSQL.Controls.Add(this.dgDBOut);
            this.panSQL.Controls.Add(this.btRead);
            this.panSQL.Controls.Add(this.btWriteComplex);
            this.panSQL.Controls.Add(this.btWriteSimple);
            this.panSQL.Controls.Add(this.tbCreatePostcode);
            this.panSQL.Controls.Add(this.btRefresh);
            this.panSQL.Controls.Add(this.tbReadName);
            this.panSQL.Controls.Add(this.tbCreateName);
            this.panSQL.Controls.Add(this.tbCreateNameOnly);
            this.panSQL.Location = new System.Drawing.Point(585, 12);
            this.panSQL.Name = "panSQL";
            this.panSQL.Size = new System.Drawing.Size(530, 591);
            this.panSQL.TabIndex = 1;
            // 
            // dgDBOut
            // 
            this.dgDBOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDBOut.Location = new System.Drawing.Point(3, 173);
            this.dgDBOut.Name = "dgDBOut";
            this.dgDBOut.Size = new System.Drawing.Size(524, 415);
            this.dgDBOut.TabIndex = 11;
            // 
            // btRead
            // 
            this.btRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRead.Location = new System.Drawing.Point(404, 85);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(115, 35);
            this.btRead.TabIndex = 10;
            this.btRead.Text = "Read ID";
            this.btRead.UseVisualStyleBackColor = true;
            // 
            // btWriteComplex
            // 
            this.btWriteComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWriteComplex.Location = new System.Drawing.Point(404, 44);
            this.btWriteComplex.Name = "btWriteComplex";
            this.btWriteComplex.Size = new System.Drawing.Size(115, 35);
            this.btWriteComplex.TabIndex = 9;
            this.btWriteComplex.Text = "Write Complex";
            this.btWriteComplex.UseVisualStyleBackColor = true;
            // 
            // btWriteSimple
            // 
            this.btWriteSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWriteSimple.Location = new System.Drawing.Point(404, 3);
            this.btWriteSimple.Name = "btWriteSimple";
            this.btWriteSimple.Size = new System.Drawing.Size(115, 35);
            this.btWriteSimple.TabIndex = 8;
            this.btWriteSimple.Text = "Write Simple";
            this.btWriteSimple.UseVisualStyleBackColor = true;
            // 
            // tbCreatePostcode
            // 
            this.tbCreatePostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCreatePostcode.Location = new System.Drawing.Point(217, 44);
            this.tbCreatePostcode.Name = "tbCreatePostcode";
            this.tbCreatePostcode.Size = new System.Drawing.Size(181, 35);
            this.tbCreatePostcode.TabIndex = 7;
            this.tbCreatePostcode.Text = "tbCreatePostcode";
            // 
            // btRefresh
            // 
            this.btRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.Location = new System.Drawing.Point(3, 126);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(524, 41);
            this.btRefresh.TabIndex = 5;
            this.btRefresh.Text = "Refresh Database";
            this.btRefresh.UseVisualStyleBackColor = true;
            // 
            // tbReadName
            // 
            this.tbReadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReadName.Location = new System.Drawing.Point(3, 85);
            this.tbReadName.Name = "tbReadName";
            this.tbReadName.Size = new System.Drawing.Size(395, 35);
            this.tbReadName.TabIndex = 6;
            this.tbReadName.Text = "tbReadName";
            // 
            // tbCreateName
            // 
            this.tbCreateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCreateName.Location = new System.Drawing.Point(3, 44);
            this.tbCreateName.Name = "tbCreateName";
            this.tbCreateName.Size = new System.Drawing.Size(208, 35);
            this.tbCreateName.TabIndex = 5;
            this.tbCreateName.Text = "tbCreateName";
            // 
            // tbCreateNameOnly
            // 
            this.tbCreateNameOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCreateNameOnly.Location = new System.Drawing.Point(3, 3);
            this.tbCreateNameOnly.Name = "tbCreateNameOnly";
            this.tbCreateNameOnly.Size = new System.Drawing.Size(395, 35);
            this.tbCreateNameOnly.TabIndex = 4;
            this.tbCreateNameOnly.Text = "tbCreateNameOnly";
            // 
            // classExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 615);
            this.Controls.Add(this.panSQL);
            this.Controls.Add(this.panSettings);
            this.Name = "classExample";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.classExample_Load);
            this.panSettings.ResumeLayout(false);
            this.panSettings.PerformLayout();
            this.panSQL.ResumeLayout(false);
            this.panSQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDBOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSettings;
        private System.Windows.Forms.Panel panSQL;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbDatabaseName;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.TextBox tbReadName;
        private System.Windows.Forms.TextBox tbCreateName;
        private System.Windows.Forms.TextBox tbCreateNameOnly;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.DataGridView dgDBOut;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btWriteComplex;
        private System.Windows.Forms.Button btWriteSimple;
        private System.Windows.Forms.TextBox tbCreatePostcode;
        private System.Windows.Forms.Button btRefresh;
    }
}

