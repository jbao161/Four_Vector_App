namespace Four_Vector_App
{
    partial class Main_window
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
            this.panel_fourvector = new System.Windows.Forms.Panel();
            this.textBox_x3 = new System.Windows.Forms.TextBox();
            this.textBox_x2 = new System.Windows.Forms.TextBox();
            this.textBox_x1 = new System.Windows.Forms.TextBox();
            this.textBox_x0 = new System.Windows.Forms.TextBox();
            this.pictureBox_formula_fourvector = new System.Windows.Forms.PictureBox();
            this.panel_lorentzresult = new System.Windows.Forms.Panel();
            this.button_lorentzboost = new System.Windows.Forms.Button();
            this.groupBox_boostdirection = new System.Windows.Forms.GroupBox();
            this.radioButton_boostz = new System.Windows.Forms.RadioButton();
            this.radioButton_boostx = new System.Windows.Forms.RadioButton();
            this.radioButton_boosty = new System.Windows.Forms.RadioButton();
            this.label_boostdirection = new System.Windows.Forms.Label();
            this.textBox_gamma = new System.Windows.Forms.TextBox();
            this.label_gamma = new System.Windows.Forms.Label();
            this.label_beta = new System.Windows.Forms.Label();
            this.textBox_beta = new System.Windows.Forms.TextBox();
            this.pictureBox_lorentzresult = new System.Windows.Forms.PictureBox();
            this.label_lorentz = new System.Windows.Forms.Label();
            this.pictureBox_lorentzmatrix = new System.Windows.Forms.PictureBox();
            this.panel_fourvector_boosted = new System.Windows.Forms.Panel();
            this.textBox_x3_boosted = new System.Windows.Forms.TextBox();
            this.textBox_x2_boosted = new System.Windows.Forms.TextBox();
            this.textBox_x1_boosted = new System.Windows.Forms.TextBox();
            this.textBox_x0_boosted = new System.Windows.Forms.TextBox();
            this.pictureBox_fourvector_boosted = new System.Windows.Forms.PictureBox();
            this.label_betadescription = new System.Windows.Forms.Label();
            this.label_gammadescription = new System.Windows.Forms.Label();
            this.label_betarange = new System.Windows.Forms.Label();
            this.linkLabel_lorentz_reference = new System.Windows.Forms.LinkLabel();
            this.panel_fourvector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_formula_fourvector)).BeginInit();
            this.panel_lorentzresult.SuspendLayout();
            this.groupBox_boostdirection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lorentzresult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lorentzmatrix)).BeginInit();
            this.panel_fourvector_boosted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fourvector_boosted)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_fourvector
            // 
            this.panel_fourvector.Controls.Add(this.textBox_x3);
            this.panel_fourvector.Controls.Add(this.textBox_x2);
            this.panel_fourvector.Controls.Add(this.textBox_x1);
            this.panel_fourvector.Controls.Add(this.textBox_x0);
            this.panel_fourvector.Controls.Add(this.pictureBox_formula_fourvector);
            this.panel_fourvector.Location = new System.Drawing.Point(12, 12);
            this.panel_fourvector.Name = "panel_fourvector";
            this.panel_fourvector.Size = new System.Drawing.Size(638, 39);
            this.panel_fourvector.TabIndex = 0;
            // 
            // textBox_x3
            // 
            this.textBox_x3.Location = new System.Drawing.Point(523, 9);
            this.textBox_x3.Name = "textBox_x3";
            this.textBox_x3.Size = new System.Drawing.Size(100, 20);
            this.textBox_x3.TabIndex = 4;
            this.textBox_x3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numerical_KeyPress);
            // 
            // textBox_x2
            // 
            this.textBox_x2.Location = new System.Drawing.Point(417, 9);
            this.textBox_x2.Name = "textBox_x2";
            this.textBox_x2.Size = new System.Drawing.Size(100, 20);
            this.textBox_x2.TabIndex = 3;
            this.textBox_x2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numerical_KeyPress);
            // 
            // textBox_x1
            // 
            this.textBox_x1.Location = new System.Drawing.Point(311, 9);
            this.textBox_x1.Name = "textBox_x1";
            this.textBox_x1.Size = new System.Drawing.Size(100, 20);
            this.textBox_x1.TabIndex = 2;
            this.textBox_x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numerical_KeyPress);
            // 
            // textBox_x0
            // 
            this.textBox_x0.Location = new System.Drawing.Point(205, 9);
            this.textBox_x0.Name = "textBox_x0";
            this.textBox_x0.Size = new System.Drawing.Size(100, 20);
            this.textBox_x0.TabIndex = 1;
            this.textBox_x0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numerical_KeyPress);
            // 
            // pictureBox_formula_fourvector
            // 
            this.pictureBox_formula_fourvector.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_formula_fourvector.Image = global::Four_Vector_App.Properties.Resources.Formula_four_vector;
            this.pictureBox_formula_fourvector.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_formula_fourvector.Name = "pictureBox_formula_fourvector";
            this.pictureBox_formula_fourvector.Size = new System.Drawing.Size(199, 39);
            this.pictureBox_formula_fourvector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_formula_fourvector.TabIndex = 0;
            this.pictureBox_formula_fourvector.TabStop = false;
            // 
            // panel_lorentzresult
            // 
            this.panel_lorentzresult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_lorentzresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_lorentzresult.Controls.Add(this.linkLabel_lorentz_reference);
            this.panel_lorentzresult.Controls.Add(this.label_betarange);
            this.panel_lorentzresult.Controls.Add(this.label_gammadescription);
            this.panel_lorentzresult.Controls.Add(this.label_betadescription);
            this.panel_lorentzresult.Controls.Add(this.panel_fourvector_boosted);
            this.panel_lorentzresult.Controls.Add(this.button_lorentzboost);
            this.panel_lorentzresult.Controls.Add(this.groupBox_boostdirection);
            this.panel_lorentzresult.Controls.Add(this.label_boostdirection);
            this.panel_lorentzresult.Controls.Add(this.textBox_gamma);
            this.panel_lorentzresult.Controls.Add(this.label_gamma);
            this.panel_lorentzresult.Controls.Add(this.label_beta);
            this.panel_lorentzresult.Controls.Add(this.textBox_beta);
            this.panel_lorentzresult.Controls.Add(this.pictureBox_lorentzresult);
            this.panel_lorentzresult.Controls.Add(this.label_lorentz);
            this.panel_lorentzresult.Controls.Add(this.pictureBox_lorentzmatrix);
            this.panel_lorentzresult.Location = new System.Drawing.Point(27, 81);
            this.panel_lorentzresult.Name = "panel_lorentzresult";
            this.panel_lorentzresult.Size = new System.Drawing.Size(996, 335);
            this.panel_lorentzresult.TabIndex = 1;
            // 
            // button_lorentzboost
            // 
            this.button_lorentzboost.BackColor = System.Drawing.SystemColors.Window;
            this.button_lorentzboost.Location = new System.Drawing.Point(420, 230);
            this.button_lorentzboost.Name = "button_lorentzboost";
            this.button_lorentzboost.Size = new System.Drawing.Size(241, 36);
            this.button_lorentzboost.TabIndex = 12;
            this.button_lorentzboost.Text = "Boost!";
            this.button_lorentzboost.UseVisualStyleBackColor = false;
            this.button_lorentzboost.Click += new System.EventHandler(this.button_lorentzboost_Click);
            // 
            // groupBox_boostdirection
            // 
            this.groupBox_boostdirection.Controls.Add(this.radioButton_boostz);
            this.groupBox_boostdirection.Controls.Add(this.radioButton_boostx);
            this.groupBox_boostdirection.Controls.Add(this.radioButton_boosty);
            this.groupBox_boostdirection.Location = new System.Drawing.Point(279, 211);
            this.groupBox_boostdirection.Name = "groupBox_boostdirection";
            this.groupBox_boostdirection.Size = new System.Drawing.Size(135, 32);
            this.groupBox_boostdirection.TabIndex = 11;
            this.groupBox_boostdirection.TabStop = false;
            // 
            // radioButton_boostz
            // 
            this.radioButton_boostz.AutoSize = true;
            this.radioButton_boostz.Location = new System.Drawing.Point(82, 9);
            this.radioButton_boostz.Name = "radioButton_boostz";
            this.radioButton_boostz.Size = new System.Drawing.Size(32, 17);
            this.radioButton_boostz.TabIndex = 10;
            this.radioButton_boostz.TabStop = true;
            this.radioButton_boostz.Text = "Z";
            this.radioButton_boostz.UseVisualStyleBackColor = true;
            // 
            // radioButton_boostx
            // 
            this.radioButton_boostx.AutoSize = true;
            this.radioButton_boostx.Checked = true;
            this.radioButton_boostx.Location = new System.Drawing.Point(6, 9);
            this.radioButton_boostx.Name = "radioButton_boostx";
            this.radioButton_boostx.Size = new System.Drawing.Size(32, 17);
            this.radioButton_boostx.TabIndex = 8;
            this.radioButton_boostx.TabStop = true;
            this.radioButton_boostx.Text = "X";
            this.radioButton_boostx.UseVisualStyleBackColor = true;
            // 
            // radioButton_boosty
            // 
            this.radioButton_boosty.AutoSize = true;
            this.radioButton_boosty.Location = new System.Drawing.Point(44, 9);
            this.radioButton_boosty.Name = "radioButton_boosty";
            this.radioButton_boosty.Size = new System.Drawing.Size(32, 17);
            this.radioButton_boosty.TabIndex = 9;
            this.radioButton_boosty.TabStop = true;
            this.radioButton_boosty.Text = "Y";
            this.radioButton_boosty.UseVisualStyleBackColor = true;
            // 
            // label_boostdirection
            // 
            this.label_boostdirection.AutoSize = true;
            this.label_boostdirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_boostdirection.Location = new System.Drawing.Point(11, 206);
            this.label_boostdirection.Name = "label_boostdirection";
            this.label_boostdirection.Size = new System.Drawing.Size(234, 37);
            this.label_boostdirection.TabIndex = 7;
            this.label_boostdirection.Text = "Boost Direction";
            // 
            // textBox_gamma
            // 
            this.textBox_gamma.Location = new System.Drawing.Point(342, 171);
            this.textBox_gamma.Multiline = true;
            this.textBox_gamma.Name = "textBox_gamma";
            this.textBox_gamma.ReadOnly = true;
            this.textBox_gamma.Size = new System.Drawing.Size(65, 20);
            this.textBox_gamma.TabIndex = 6;
            this.textBox_gamma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numerical_KeyPress);
            // 
            // label_gamma
            // 
            this.label_gamma.AutoSize = true;
            this.label_gamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gamma.Location = new System.Drawing.Point(303, 154);
            this.label_gamma.Name = "label_gamma";
            this.label_gamma.Size = new System.Drawing.Size(38, 37);
            this.label_gamma.TabIndex = 5;
            this.label_gamma.Text = "Ɣ";
            // 
            // label_beta
            // 
            this.label_beta.AutoSize = true;
            this.label_beta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_beta.Location = new System.Drawing.Point(301, 98);
            this.label_beta.Name = "label_beta";
            this.label_beta.Size = new System.Drawing.Size(35, 37);
            this.label_beta.TabIndex = 4;
            this.label_beta.Text = "β";
            // 
            // textBox_beta
            // 
            this.textBox_beta.Location = new System.Drawing.Point(342, 98);
            this.textBox_beta.Multiline = true;
            this.textBox_beta.Name = "textBox_beta";
            this.textBox_beta.Size = new System.Drawing.Size(65, 20);
            this.textBox_beta.TabIndex = 3;
            this.textBox_beta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_beta_KeyDown);
            this.textBox_beta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numerical_KeyPress);
            // 
            // pictureBox_lorentzresult
            // 
            this.pictureBox_lorentzresult.Image = global::Four_Vector_App.Properties.Resources.lorentz_transform;
            this.pictureBox_lorentzresult.Location = new System.Drawing.Point(420, 8);
            this.pictureBox_lorentzresult.Name = "pictureBox_lorentzresult";
            this.pictureBox_lorentzresult.Size = new System.Drawing.Size(563, 216);
            this.pictureBox_lorentzresult.TabIndex = 2;
            this.pictureBox_lorentzresult.TabStop = false;
            // 
            // label_lorentz
            // 
            this.label_lorentz.AutoSize = true;
            this.label_lorentz.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lorentz.Location = new System.Drawing.Point(11, 8);
            this.label_lorentz.Name = "label_lorentz";
            this.label_lorentz.Size = new System.Drawing.Size(403, 42);
            this.label_lorentz.TabIndex = 1;
            this.label_lorentz.Text = "Lorentz Transformation";
            // 
            // pictureBox_lorentzmatrix
            // 
            this.pictureBox_lorentzmatrix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox_lorentzmatrix.Image = global::Four_Vector_App.Properties.Resources.lorentz_transform_matrix;
            this.pictureBox_lorentzmatrix.Location = new System.Drawing.Point(16, 62);
            this.pictureBox_lorentzmatrix.Name = "pictureBox_lorentzmatrix";
            this.pictureBox_lorentzmatrix.Size = new System.Drawing.Size(271, 129);
            this.pictureBox_lorentzmatrix.TabIndex = 0;
            this.pictureBox_lorentzmatrix.TabStop = false;
            // 
            // panel_fourvector_boosted
            // 
            this.panel_fourvector_boosted.Controls.Add(this.textBox_x3_boosted);
            this.panel_fourvector_boosted.Controls.Add(this.textBox_x2_boosted);
            this.panel_fourvector_boosted.Controls.Add(this.textBox_x1_boosted);
            this.panel_fourvector_boosted.Controls.Add(this.textBox_x0_boosted);
            this.panel_fourvector_boosted.Controls.Add(this.pictureBox_fourvector_boosted);
            this.panel_fourvector_boosted.Location = new System.Drawing.Point(18, 272);
            this.panel_fourvector_boosted.Name = "panel_fourvector_boosted";
            this.panel_fourvector_boosted.Size = new System.Drawing.Size(638, 39);
            this.panel_fourvector_boosted.TabIndex = 13;
            // 
            // textBox_x3_boosted
            // 
            this.textBox_x3_boosted.Location = new System.Drawing.Point(523, 9);
            this.textBox_x3_boosted.Name = "textBox_x3_boosted";
            this.textBox_x3_boosted.ReadOnly = true;
            this.textBox_x3_boosted.Size = new System.Drawing.Size(100, 20);
            this.textBox_x3_boosted.TabIndex = 4;
            // 
            // textBox_x2_boosted
            // 
            this.textBox_x2_boosted.Location = new System.Drawing.Point(417, 9);
            this.textBox_x2_boosted.Name = "textBox_x2_boosted";
            this.textBox_x2_boosted.ReadOnly = true;
            this.textBox_x2_boosted.Size = new System.Drawing.Size(100, 20);
            this.textBox_x2_boosted.TabIndex = 3;
            // 
            // textBox_x1_boosted
            // 
            this.textBox_x1_boosted.Location = new System.Drawing.Point(311, 9);
            this.textBox_x1_boosted.Name = "textBox_x1_boosted";
            this.textBox_x1_boosted.ReadOnly = true;
            this.textBox_x1_boosted.Size = new System.Drawing.Size(100, 20);
            this.textBox_x1_boosted.TabIndex = 2;
            // 
            // textBox_x0_boosted
            // 
            this.textBox_x0_boosted.Location = new System.Drawing.Point(205, 9);
            this.textBox_x0_boosted.Name = "textBox_x0_boosted";
            this.textBox_x0_boosted.ReadOnly = true;
            this.textBox_x0_boosted.Size = new System.Drawing.Size(100, 20);
            this.textBox_x0_boosted.TabIndex = 1;
            // 
            // pictureBox_fourvector_boosted
            // 
            this.pictureBox_fourvector_boosted.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_fourvector_boosted.Image = global::Four_Vector_App.Properties.Resources.Formula_four_vector;
            this.pictureBox_fourvector_boosted.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_fourvector_boosted.Name = "pictureBox_fourvector_boosted";
            this.pictureBox_fourvector_boosted.Size = new System.Drawing.Size(199, 39);
            this.pictureBox_fourvector_boosted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_fourvector_boosted.TabIndex = 0;
            this.pictureBox_fourvector_boosted.TabStop = false;
            // 
            // label_betadescription
            // 
            this.label_betadescription.AutoSize = true;
            this.label_betadescription.Location = new System.Drawing.Point(295, 62);
            this.label_betadescription.Name = "label_betadescription";
            this.label_betadescription.Size = new System.Drawing.Size(120, 26);
            this.label_betadescription.TabIndex = 14;
            this.label_betadescription.Text = "Ratio of relative velocity\r\n to speed of light";
            this.label_betadescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_gammadescription
            // 
            this.label_gammadescription.AutoSize = true;
            this.label_gammadescription.Location = new System.Drawing.Point(339, 156);
            this.label_gammadescription.Name = "label_gammadescription";
            this.label_gammadescription.Size = new System.Drawing.Size(72, 13);
            this.label_gammadescription.TabIndex = 15;
            this.label_gammadescription.Text = "Lorentz factor";
            // 
            // label_betarange
            // 
            this.label_betarange.AutoSize = true;
            this.label_betarange.Location = new System.Drawing.Point(344, 124);
            this.label_betarange.Name = "label_betarange";
            this.label_betarange.Size = new System.Drawing.Size(58, 13);
            this.label_betarange.TabIndex = 16;
            this.label_betarange.Text = "(-1 < β < 1)";
            // 
            // linkLabel_lorentz_reference
            // 
            this.linkLabel_lorentz_reference.AutoSize = true;
            this.linkLabel_lorentz_reference.Location = new System.Drawing.Point(680, 227);
            this.linkLabel_lorentz_reference.Name = "linkLabel_lorentz_reference";
            this.linkLabel_lorentz_reference.Size = new System.Drawing.Size(303, 13);
            this.linkLabel_lorentz_reference.TabIndex = 17;
            this.linkLabel_lorentz_reference.TabStop = true;
            this.linkLabel_lorentz_reference.Text = "http://hyperphysics.phy-astr.gsu.edu/hbase/Relativ/vec4.html";
            this.linkLabel_lorentz_reference.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_lorentz_reference_LinkClicked);
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 539);
            this.Controls.Add(this.panel_lorentzresult);
            this.Controls.Add(this.panel_fourvector);
            this.Name = "Main_window";
            this.Text = "Four Vector App";
            this.panel_fourvector.ResumeLayout(false);
            this.panel_fourvector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_formula_fourvector)).EndInit();
            this.panel_lorentzresult.ResumeLayout(false);
            this.panel_lorentzresult.PerformLayout();
            this.groupBox_boostdirection.ResumeLayout(false);
            this.groupBox_boostdirection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lorentzresult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lorentzmatrix)).EndInit();
            this.panel_fourvector_boosted.ResumeLayout(false);
            this.panel_fourvector_boosted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fourvector_boosted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_fourvector;
        private System.Windows.Forms.TextBox textBox_x3;
        private System.Windows.Forms.TextBox textBox_x2;
        private System.Windows.Forms.TextBox textBox_x1;
        private System.Windows.Forms.TextBox textBox_x0;
        private System.Windows.Forms.PictureBox pictureBox_formula_fourvector;
        private System.Windows.Forms.Panel panel_lorentzresult;
        private System.Windows.Forms.PictureBox pictureBox_lorentzmatrix;
        private System.Windows.Forms.PictureBox pictureBox_lorentzresult;
        private System.Windows.Forms.Label label_lorentz;
        private System.Windows.Forms.TextBox textBox_gamma;
        private System.Windows.Forms.Label label_gamma;
        private System.Windows.Forms.Label label_beta;
        private System.Windows.Forms.TextBox textBox_beta;
        private System.Windows.Forms.GroupBox groupBox_boostdirection;
        private System.Windows.Forms.RadioButton radioButton_boostz;
        private System.Windows.Forms.RadioButton radioButton_boostx;
        private System.Windows.Forms.RadioButton radioButton_boosty;
        private System.Windows.Forms.Label label_boostdirection;
        private System.Windows.Forms.Button button_lorentzboost;
        private System.Windows.Forms.Panel panel_fourvector_boosted;
        private System.Windows.Forms.TextBox textBox_x3_boosted;
        private System.Windows.Forms.TextBox textBox_x2_boosted;
        private System.Windows.Forms.TextBox textBox_x1_boosted;
        private System.Windows.Forms.TextBox textBox_x0_boosted;
        private System.Windows.Forms.PictureBox pictureBox_fourvector_boosted;
        private System.Windows.Forms.Label label_betarange;
        private System.Windows.Forms.Label label_gammadescription;
        private System.Windows.Forms.Label label_betadescription;
        private System.Windows.Forms.LinkLabel linkLabel_lorentz_reference;
    }
}

