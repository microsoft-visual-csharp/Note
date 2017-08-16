namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1009, 517);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -3;
            this.lineShape2.X2 = 414;
            this.lineShape2.Y1 = 33;
            this.lineShape2.Y2 = 33;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 415;
            this.lineShape1.X2 = 416;
            this.lineShape1.Y1 = 0;
            this.lineShape1.Y2 = 519;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.textBox1.Location = new System.Drawing.Point(0, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnTextKeyPress);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Control;
            this.monthCalendar1.Location = new System.Drawing.Point(786, 9);
            this.monthCalendar1.MaximumSize = new System.Drawing.Size(300, 240);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.黑夜中的行者;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.黑夜中的行者;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.ForeColor = System.Drawing.Color.Green;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(-3, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(415, 466);
            this.listBox1.TabIndex = 3;
            this.listBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnListKeyUp);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.FillColor = System.Drawing.Color.Maroon;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(416, 3);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(366, 189);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.OnTimerColor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1009, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "小记";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer2;
    }
}

