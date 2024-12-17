namespace WindowsFormsApp1
{
    partial class lblResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblResult));
            this.lblFristOperand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfristoperand = new System.Windows.Forms.TextBox();
            this.txtsecoundOperand = new System.Windows.Forms.TextBox();
            this.listBoxOperation = new System.Windows.Forms.ListBox();
            this.radbtnAdd = new System.Windows.Forms.RadioButton();
            this.radbtnsub = new System.Windows.Forms.RadioButton();
            this.radbtnmul = new System.Windows.Forms.RadioButton();
            this.radbtndiv = new System.Windows.Forms.RadioButton();
            this.radbtnred = new System.Windows.Forms.RadioButton();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblExpression = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFristOperand
            // 
            resources.ApplyResources(this.lblFristOperand, "lblFristOperand");
            this.lblFristOperand.Name = "lblFristOperand";
            this.lblFristOperand.Tag = "lblfristoperand";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Tag = "lblSecoundOperand";
            // 
            // txtfristoperand
            // 
            resources.ApplyResources(this.txtfristoperand, "txtfristoperand");
            this.txtfristoperand.Name = "txtfristoperand";
            this.txtfristoperand.Tag = "txtfristoperand";
            // 
            // txtsecoundOperand
            // 
            resources.ApplyResources(this.txtsecoundOperand, "txtsecoundOperand");
            this.txtsecoundOperand.Name = "txtsecoundOperand";
            // 
            // listBoxOperation
            // 
            resources.ApplyResources(this.listBoxOperation, "listBoxOperation");
            this.listBoxOperation.FormattingEnabled = true;
            this.listBoxOperation.Name = "listBoxOperation";
            // 
            // radbtnAdd
            // 
            resources.ApplyResources(this.radbtnAdd, "radbtnAdd");
            this.radbtnAdd.Name = "radbtnAdd";
            this.radbtnAdd.TabStop = true;
            this.radbtnAdd.Tag = "radbtnAdd";
            this.radbtnAdd.UseVisualStyleBackColor = true;
            // 
            // radbtnsub
            // 
            resources.ApplyResources(this.radbtnsub, "radbtnsub");
            this.radbtnsub.Name = "radbtnsub";
            this.radbtnsub.TabStop = true;
            this.radbtnsub.Tag = "radbtnSub";
            this.radbtnsub.UseVisualStyleBackColor = true;
            // 
            // radbtnmul
            // 
            resources.ApplyResources(this.radbtnmul, "radbtnmul");
            this.radbtnmul.Name = "radbtnmul";
            this.radbtnmul.TabStop = true;
            this.radbtnmul.Tag = "radbtnmul";
            this.radbtnmul.UseVisualStyleBackColor = true;
            // 
            // radbtndiv
            // 
            resources.ApplyResources(this.radbtndiv, "radbtndiv");
            this.radbtndiv.Name = "radbtndiv";
            this.radbtndiv.TabStop = true;
            this.radbtndiv.Tag = "radbtndiv";
            this.radbtndiv.UseVisualStyleBackColor = true;
            // 
            // radbtnred
            // 
            resources.ApplyResources(this.radbtnred, "radbtnred");
            this.radbtnred.Name = "radbtnred";
            this.radbtnred.TabStop = true;
            this.radbtnred.Tag = "radbtnmod";
            this.radbtnred.UseVisualStyleBackColor = true;
            // 
            // BtnCalculate
            // 
            resources.ApplyResources(this.BtnCalculate, "BtnCalculate");
            this.BtnCalculate.ForeColor = System.Drawing.Color.Blue;
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Tag = "btncalculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Name = "button2";
            this.button2.Tag = "btnexit";
            this.button2.UseVisualStyleBackColor = true;
            //this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.Tag = "Txtexpression";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.Tag = "Txtresult";
            // 
            // lblExpression
            // 
            resources.ApplyResources(this.lblExpression, "lblExpression");
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Tag = "";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Tag = "lblResult";
            // 
            // lblResult
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.radbtnred);
            this.Controls.Add(this.radbtndiv);
            this.Controls.Add(this.radbtnmul);
            this.Controls.Add(this.radbtnsub);
            this.Controls.Add(this.radbtnAdd);
            this.Controls.Add(this.listBoxOperation);
            this.Controls.Add(this.txtsecoundOperand);
            this.Controls.Add(this.txtfristoperand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFristOperand);
            this.Name = "lblResult";
            this.Tag = "";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFristOperand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfristoperand;
        private System.Windows.Forms.TextBox txtsecoundOperand;
        private System.Windows.Forms.ListBox listBoxOperation;
        private System.Windows.Forms.RadioButton radbtnAdd;
        private System.Windows.Forms.RadioButton radbtnsub;
        private System.Windows.Forms.RadioButton radbtnmul;
        private System.Windows.Forms.RadioButton radbtndiv;
        private System.Windows.Forms.RadioButton radbtnred;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Label label4;
    }
}

