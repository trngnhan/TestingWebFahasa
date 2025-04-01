
namespace SquareAreA_44_Nhan
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
            this.btnCalculate_44_Nhan = new System.Windows.Forms.Button();
            this.txtSideLength_44_Nhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult_44_Nhan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate_44_Nhan
            // 
            this.btnCalculate_44_Nhan.Location = new System.Drawing.Point(285, 219);
            this.btnCalculate_44_Nhan.Name = "btnCalculate_44_Nhan";
            this.btnCalculate_44_Nhan.Size = new System.Drawing.Size(194, 92);
            this.btnCalculate_44_Nhan.TabIndex = 0;
            this.btnCalculate_44_Nhan.Text = "Tính Diện Tích Hình Vuông";
            this.btnCalculate_44_Nhan.UseVisualStyleBackColor = true;
            this.btnCalculate_44_Nhan.Click += new System.EventHandler(this.btnCalculate_44_Nhan_Click);
            // 
            // txtSideLength_44_Nhan
            // 
            this.txtSideLength_44_Nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSideLength_44_Nhan.Location = new System.Drawing.Point(268, 144);
            this.txtSideLength_44_Nhan.Name = "txtSideLength_44_Nhan";
            this.txtSideLength_44_Nhan.Size = new System.Drawing.Size(194, 38);
            this.txtSideLength_44_Nhan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập cạnh:";
            // 
            // lblResult_44_Nhan
            // 
            this.lblResult_44_Nhan.AutoSize = true;
            this.lblResult_44_Nhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult_44_Nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult_44_Nhan.Location = new System.Drawing.Point(262, 356);
            this.lblResult_44_Nhan.Name = "lblResult_44_Nhan";
            this.lblResult_44_Nhan.Size = new System.Drawing.Size(147, 32);
            this.lblResult_44_Nhan.TabIndex = 3;
            this.lblResult_44_Nhan.Text = "LBLResult";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult_44_Nhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSideLength_44_Nhan);
            this.Controls.Add(this.btnCalculate_44_Nhan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate_44_Nhan;
        private System.Windows.Forms.TextBox txtSideLength_44_Nhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult_44_Nhan;
    }
}

