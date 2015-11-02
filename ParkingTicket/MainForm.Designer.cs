namespace ParkingTicket
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonParkCar = new System.Windows.Forms.Button();
            this.buttonPurTime = new System.Windows.Forms.Button();
            this.buttonElapse = new System.Windows.Forms.Button();
            this.buttonInspection = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parking Ticket App";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(60, 218);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Make:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Plate #:";
            // 
            // buttonParkCar
            // 
            this.buttonParkCar.Location = new System.Drawing.Point(33, 274);
            this.buttonParkCar.Name = "buttonParkCar";
            this.buttonParkCar.Size = new System.Drawing.Size(106, 23);
            this.buttonParkCar.TabIndex = 9;
            this.buttonParkCar.Text = "Park Car";
            this.buttonParkCar.UseVisualStyleBackColor = true;
            // 
            // buttonPurTime
            // 
            this.buttonPurTime.Location = new System.Drawing.Point(33, 329);
            this.buttonPurTime.Name = "buttonPurTime";
            this.buttonPurTime.Size = new System.Drawing.Size(106, 23);
            this.buttonPurTime.TabIndex = 10;
            this.buttonPurTime.Text = "Purchase Time";
            this.buttonPurTime.UseVisualStyleBackColor = true;
            // 
            // buttonElapse
            // 
            this.buttonElapse.Location = new System.Drawing.Point(33, 389);
            this.buttonElapse.Name = "buttonElapse";
            this.buttonElapse.Size = new System.Drawing.Size(106, 23);
            this.buttonElapse.TabIndex = 11;
            this.buttonElapse.Text = "Elapse Time";
            this.buttonElapse.UseVisualStyleBackColor = true;
            // 
            // buttonInspection
            // 
            this.buttonInspection.Location = new System.Drawing.Point(33, 450);
            this.buttonInspection.Name = "buttonInspection";
            this.buttonInspection.Size = new System.Drawing.Size(106, 23);
            this.buttonInspection.TabIndex = 12;
            this.buttonInspection.Text = "Inspection";
            this.buttonInspection.UseVisualStyleBackColor = true;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(246, 126);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(167, 42);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "labelTime";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Time Purchased in hours";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(624, 556);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonInspection);
            this.Controls.Add(this.buttonElapse);
            this.Controls.Add(this.buttonPurTime);
            this.Controls.Add(this.buttonParkCar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonParkCar;
        private System.Windows.Forms.Button buttonPurTime;
        private System.Windows.Forms.Button buttonElapse;
        private System.Windows.Forms.Button buttonInspection;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label7;
    }
}

