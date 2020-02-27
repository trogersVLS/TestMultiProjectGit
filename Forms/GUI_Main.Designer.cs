namespace BlowerConfigUpdate
{
    partial class GUI_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Main));
            this.Button_Run = new System.Windows.Forms.Button();
            this.Field_SerialNumber = new System.Windows.Forms.TextBox();
            this.label_serialNumber = new System.Windows.Forms.Label();
            this.console_debugOutput = new System.Windows.Forms.RichTextBox();
            this.StatusBar = new System.Windows.Forms.ProgressBar();
            this.Label_User = new System.Windows.Forms.Label();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Check_LogToDatabase = new System.Windows.Forms.CheckBox();
            this.Check_Program = new System.Windows.Forms.CheckBox();
            this.Logo_VLS = new System.Windows.Forms.PictureBox();
            this.Button_GPIO = new System.Windows.Forms.Button();
            this.Label_Telnet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_VLS)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Run
            // 
            this.Button_Run.Location = new System.Drawing.Point(1136, 246);
            this.Button_Run.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(274, 101);
            this.Button_Run.TabIndex = 1;
            this.Button_Run.Text = "Run";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // Field_SerialNumber
            // 
            this.Field_SerialNumber.BackColor = System.Drawing.SystemColors.Window;
            this.Field_SerialNumber.Location = new System.Drawing.Point(232, 234);
            this.Field_SerialNumber.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Field_SerialNumber.Name = "Field_SerialNumber";
            this.Field_SerialNumber.Size = new System.Drawing.Size(882, 38);
            this.Field_SerialNumber.TabIndex = 3;
            this.Field_SerialNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Field_SerialNumber_KeyUp);
            // 
            // label_serialNumber
            // 
            this.label_serialNumber.AutoSize = true;
            this.label_serialNumber.Location = new System.Drawing.Point(24, 240);
            this.label_serialNumber.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_serialNumber.Name = "label_serialNumber";
            this.label_serialNumber.Size = new System.Drawing.Size(196, 32);
            this.label_serialNumber.TabIndex = 4;
            this.label_serialNumber.Text = "Serial Number";
            // 
            // console_debugOutput
            // 
            this.console_debugOutput.Location = new System.Drawing.Point(22, 430);
            this.console_debugOutput.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.console_debugOutput.Name = "console_debugOutput";
            this.console_debugOutput.ReadOnly = true;
            this.console_debugOutput.Size = new System.Drawing.Size(1382, 1065);
            this.console_debugOutput.TabIndex = 9;
            this.console_debugOutput.Text = "";
            this.console_debugOutput.TextChanged += new System.EventHandler(this.Console_debugOutput_TextChanged);
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(22, 360);
            this.StatusBar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1390, 54);
            this.StatusBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.StatusBar.TabIndex = 12;
            // 
            // Label_User
            // 
            this.Label_User.AutoSize = true;
            this.Label_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_User.Location = new System.Drawing.Point(14, 2);
            this.Label_User.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label_User.Name = "Label_User";
            this.Label_User.Size = new System.Drawing.Size(87, 32);
            this.Label_User.TabIndex = 16;
            this.Label_User.Text = "User:";
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Location = new System.Drawing.Point(96, 2);
            this.Label_Username.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(106, 32);
            this.Label_Username.TabIndex = 17;
            this.Label_Username.Text = "<User>";
            // 
            // Check_LogToDatabase
            // 
            this.Check_LogToDatabase.AutoSize = true;
            this.Check_LogToDatabase.Checked = true;
            this.Check_LogToDatabase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_LogToDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Check_LogToDatabase.Location = new System.Drawing.Point(22, 41);
            this.Check_LogToDatabase.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Check_LogToDatabase.Name = "Check_LogToDatabase";
            this.Check_LogToDatabase.Size = new System.Drawing.Size(257, 36);
            this.Check_LogToDatabase.TabIndex = 18;
            this.Check_LogToDatabase.Text = "Log to database";
            this.Check_LogToDatabase.UseVisualStyleBackColor = true;
            this.Check_LogToDatabase.CheckedChanged += new System.EventHandler(this.Check_LogToDatabase_CheckedChanged);
            // 
            // Check_Program
            // 
            this.Check_Program.AutoSize = true;
            this.Check_Program.Location = new System.Drawing.Point(32, 306);
            this.Check_Program.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Check_Program.Name = "Check_Program";
            this.Check_Program.Size = new System.Drawing.Size(161, 36);
            this.Check_Program.TabIndex = 7;
            this.Check_Program.Text = "Program";
            this.Check_Program.UseVisualStyleBackColor = true;
            // 
            // Logo_VLS
            // 
            this.Logo_VLS.Image = ((System.Drawing.Image)(resources.GetObject("Logo_VLS.Image")));
            this.Logo_VLS.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo_VLS.InitialImage")));
            this.Logo_VLS.Location = new System.Drawing.Point(670, 14);
            this.Logo_VLS.Margin = new System.Windows.Forms.Padding(26, 23, 26, 23);
            this.Logo_VLS.Name = "Logo_VLS";
            this.Logo_VLS.Size = new System.Drawing.Size(742, 207);
            this.Logo_VLS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_VLS.TabIndex = 26;
            this.Logo_VLS.TabStop = false;
            // 
            // Button_GPIO
            // 
            this.Button_GPIO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_GPIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Button_GPIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_GPIO.Location = new System.Drawing.Point(22, 164);
            this.Button_GPIO.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Button_GPIO.Name = "Button_GPIO";
            this.Button_GPIO.Size = new System.Drawing.Size(274, 54);
            this.Button_GPIO.TabIndex = 32;
            this.Button_GPIO.Text = "GPIO";
            this.Button_GPIO.UseVisualStyleBackColor = false;
            this.Button_GPIO.Click += new System.EventHandler(this.Button_GPIO_Click);
            // 
            // Label_Telnet
            // 
            this.Label_Telnet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Label_Telnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Label_Telnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Telnet.Location = new System.Drawing.Point(362, 164);
            this.Label_Telnet.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Label_Telnet.Name = "Label_Telnet";
            this.Label_Telnet.Size = new System.Drawing.Size(274, 54);
            this.Label_Telnet.TabIndex = 33;
            this.Label_Telnet.Text = "Telnet";
            this.Label_Telnet.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(96, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "Rev:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GUI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(222)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1432, 1512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Telnet);
            this.Controls.Add(this.Button_GPIO);
            this.Controls.Add(this.Logo_VLS);
            this.Controls.Add(this.Check_LogToDatabase);
            this.Controls.Add(this.Label_Username);
            this.Controls.Add(this.Label_User);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.label_serialNumber);
            this.Controls.Add(this.console_debugOutput);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.Field_SerialNumber);
            this.Controls.Add(this.Check_Program);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaximumSize = new System.Drawing.Size(1464, 1600);
            this.MinimumSize = new System.Drawing.Size(1464, 1600);
            this.Name = "GUI_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MFG-00536";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Logo_VLS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Run;
        private System.Windows.Forms.TextBox Field_SerialNumber;
        private System.Windows.Forms.Label label_serialNumber;
        private System.Windows.Forms.RichTextBox console_debugOutput;
        private System.Windows.Forms.ProgressBar StatusBar;
        private System.Windows.Forms.Label Label_User;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.CheckBox Check_LogToDatabase;
        private System.Windows.Forms.CheckBox Check_Program;
        private System.Windows.Forms.PictureBox Logo_VLS;
        private System.Windows.Forms.Button Button_GPIO;
        private System.Windows.Forms.Button Label_Telnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

