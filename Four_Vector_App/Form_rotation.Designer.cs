namespace Four_Vector_App
{
    partial class Form_rotation
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
            this.label_boost3d_normalized = new System.Windows.Forms.Label();
            this.label_rotationvector = new System.Windows.Forms.Label();
            this.rotation_formula = new System.Windows.Forms.PictureBox();
            this.textBox_rotation_z = new System.Windows.Forms.TextBox();
            this.textBox_rotation_y = new System.Windows.Forms.TextBox();
            this.textBox_rotation_x = new System.Windows.Forms.TextBox();
            this.textBox_rotation_angle = new System.Windows.Forms.TextBox();
            this.label_rotation_angle = new System.Windows.Forms.Label();
            this.label_rotation_unitvector = new System.Windows.Forms.Label();
            this.button_rotate = new System.Windows.Forms.Button();
            this.rotated_fourvector = new System.Windows.Forms.Panel();
            this.button_updatefourvector = new System.Windows.Forms.Button();
            this.textBox_rotated_x3 = new System.Windows.Forms.TextBox();
            this.textBox_rotated_x2 = new System.Windows.Forms.TextBox();
            this.textBox_rotated_x1 = new System.Windows.Forms.TextBox();
            this.textBox_rotated_x0 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_rotation_norm_z = new System.Windows.Forms.TextBox();
            this.textBox_rotation_norm_y = new System.Windows.Forms.TextBox();
            this.textBox_rotation_norm_x = new System.Windows.Forms.TextBox();
            this.textBox_matrix_1_4 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_1_3 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_1_2 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_1_1 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_2_4 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_2_3 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_2_2 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_2_1 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_3_4 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_3_3 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_3_2 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_3_1 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_4_4 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_4_3 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_4_2 = new System.Windows.Forms.TextBox();
            this.textBox_matrix_4_1 = new System.Windows.Forms.TextBox();
            this.label_rotationmatrix = new System.Windows.Forms.Label();
            this.checkBox_autoupdate_fourvector = new System.Windows.Forms.CheckBox();
            this.panel_fourvector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_formula_fourvector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotation_formula)).BeginInit();
            this.rotated_fourvector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel_fourvector.TabIndex = 1;
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
            // label_boost3d_normalized
            // 
            this.label_boost3d_normalized.AutoSize = true;
            this.label_boost3d_normalized.Location = new System.Drawing.Point(180, 261);
            this.label_boost3d_normalized.Name = "label_boost3d_normalized";
            this.label_boost3d_normalized.Size = new System.Drawing.Size(57, 13);
            this.label_boost3d_normalized.TabIndex = 42;
            this.label_boost3d_normalized.Text = "normalized";
            // 
            // label_rotationvector
            // 
            this.label_rotationvector.AutoSize = true;
            this.label_rotationvector.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rotationvector.Location = new System.Drawing.Point(12, 284);
            this.label_rotationvector.Name = "label_rotationvector";
            this.label_rotationvector.Size = new System.Drawing.Size(215, 33);
            this.label_rotationvector.TabIndex = 41;
            this.label_rotationvector.Text = "Rotation Vector";
            // 
            // rotation_formula
            // 
            this.rotation_formula.Image = global::Four_Vector_App.Properties.Resources.rotation_formula;
            this.rotation_formula.Location = new System.Drawing.Point(14, 58);
            this.rotation_formula.Name = "rotation_formula";
            this.rotation_formula.Size = new System.Drawing.Size(548, 220);
            this.rotation_formula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rotation_formula.TabIndex = 43;
            this.rotation_formula.TabStop = false;
            // 
            // textBox_rotation_z
            // 
            this.textBox_rotation_z.Location = new System.Drawing.Point(462, 284);
            this.textBox_rotation_z.Name = "textBox_rotation_z";
            this.textBox_rotation_z.Size = new System.Drawing.Size(100, 20);
            this.textBox_rotation_z.TabIndex = 46;
            this.textBox_rotation_z.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numerical_KeyPress);
            // 
            // textBox_rotation_y
            // 
            this.textBox_rotation_y.Location = new System.Drawing.Point(356, 284);
            this.textBox_rotation_y.Name = "textBox_rotation_y";
            this.textBox_rotation_y.Size = new System.Drawing.Size(100, 20);
            this.textBox_rotation_y.TabIndex = 45;
            this.textBox_rotation_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numerical_KeyPress);
            // 
            // textBox_rotation_x
            // 
            this.textBox_rotation_x.Location = new System.Drawing.Point(250, 284);
            this.textBox_rotation_x.Name = "textBox_rotation_x";
            this.textBox_rotation_x.Size = new System.Drawing.Size(100, 20);
            this.textBox_rotation_x.TabIndex = 44;
            this.textBox_rotation_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numerical_KeyPress);
            // 
            // textBox_rotation_angle
            // 
            this.textBox_rotation_angle.Location = new System.Drawing.Point(462, 364);
            this.textBox_rotation_angle.Name = "textBox_rotation_angle";
            this.textBox_rotation_angle.Size = new System.Drawing.Size(100, 20);
            this.textBox_rotation_angle.TabIndex = 47;
            this.textBox_rotation_angle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numerical_KeyPress);
            // 
            // label_rotation_angle
            // 
            this.label_rotation_angle.AutoSize = true;
            this.label_rotation_angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rotation_angle.Location = new System.Drawing.Point(12, 351);
            this.label_rotation_angle.Name = "label_rotation_angle";
            this.label_rotation_angle.Size = new System.Drawing.Size(329, 33);
            this.label_rotation_angle.TabIndex = 48;
            this.label_rotation_angle.Text = "Rotation Angle (radians)";
            // 
            // label_rotation_unitvector
            // 
            this.label_rotation_unitvector.AutoSize = true;
            this.label_rotation_unitvector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rotation_unitvector.Location = new System.Drawing.Point(107, 321);
            this.label_rotation_unitvector.Name = "label_rotation_unitvector";
            this.label_rotation_unitvector.Size = new System.Drawing.Size(137, 16);
            this.label_rotation_unitvector.TabIndex = 52;
            this.label_rotation_unitvector.Text = "normalized unit vector";
            // 
            // button_rotate
            // 
            this.button_rotate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_rotate.Location = new System.Drawing.Point(587, 281);
            this.button_rotate.Name = "button_rotate";
            this.button_rotate.Size = new System.Drawing.Size(122, 60);
            this.button_rotate.TabIndex = 53;
            this.button_rotate.Text = "Rotate!";
            this.button_rotate.UseVisualStyleBackColor = false;
            this.button_rotate.Click += new System.EventHandler(this.button_rotate_Click);
            // 
            // rotated_fourvector
            // 
            this.rotated_fourvector.Controls.Add(this.button_updatefourvector);
            this.rotated_fourvector.Controls.Add(this.textBox_rotated_x3);
            this.rotated_fourvector.Controls.Add(this.textBox_rotated_x2);
            this.rotated_fourvector.Controls.Add(this.textBox_rotated_x1);
            this.rotated_fourvector.Controls.Add(this.textBox_rotated_x0);
            this.rotated_fourvector.Controls.Add(this.pictureBox2);
            this.rotated_fourvector.Location = new System.Drawing.Point(71, 399);
            this.rotated_fourvector.Name = "rotated_fourvector";
            this.rotated_fourvector.Size = new System.Drawing.Size(780, 51);
            this.rotated_fourvector.TabIndex = 5;
            // 
            // button_updatefourvector
            // 
            this.button_updatefourvector.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_updatefourvector.Location = new System.Drawing.Point(668, 3);
            this.button_updatefourvector.Name = "button_updatefourvector";
            this.button_updatefourvector.Size = new System.Drawing.Size(84, 38);
            this.button_updatefourvector.TabIndex = 36;
            this.button_updatefourvector.Text = "Update Four Vector";
            this.button_updatefourvector.UseVisualStyleBackColor = false;
            this.button_updatefourvector.Click += new System.EventHandler(this.button_updatefourvector_Click);
            // 
            // textBox_rotated_x3
            // 
            this.textBox_rotated_x3.Location = new System.Drawing.Point(523, 9);
            this.textBox_rotated_x3.Name = "textBox_rotated_x3";
            this.textBox_rotated_x3.ReadOnly = true;
            this.textBox_rotated_x3.Size = new System.Drawing.Size(100, 20);
            this.textBox_rotated_x3.TabIndex = 4;
            // 
            // textBox_rotated_x2
            // 
            this.textBox_rotated_x2.Location = new System.Drawing.Point(417, 9);
            this.textBox_rotated_x2.Name = "textBox_rotated_x2";
            this.textBox_rotated_x2.ReadOnly = true;
            this.textBox_rotated_x2.Size = new System.Drawing.Size(100, 20);
            this.textBox_rotated_x2.TabIndex = 3;
            // 
            // textBox_rotated_x1
            // 
            this.textBox_rotated_x1.Location = new System.Drawing.Point(311, 9);
            this.textBox_rotated_x1.Name = "textBox_rotated_x1";
            this.textBox_rotated_x1.ReadOnly = true;
            this.textBox_rotated_x1.Size = new System.Drawing.Size(100, 20);
            this.textBox_rotated_x1.TabIndex = 2;
            // 
            // textBox_rotated_x0
            // 
            this.textBox_rotated_x0.Location = new System.Drawing.Point(205, 9);
            this.textBox_rotated_x0.Name = "textBox_rotated_x0";
            this.textBox_rotated_x0.ReadOnly = true;
            this.textBox_rotated_x0.Size = new System.Drawing.Size(100, 20);
            this.textBox_rotated_x0.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::Four_Vector_App.Properties.Resources.Formula_four_vector;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_rotation_norm_z
            // 
            this.textBox_rotation_norm_z.Location = new System.Drawing.Point(462, 317);
            this.textBox_rotation_norm_z.Name = "textBox_rotation_norm_z";
            this.textBox_rotation_norm_z.ReadOnly = true;
            this.textBox_rotation_norm_z.Size = new System.Drawing.Size(100, 20);
            this.textBox_rotation_norm_z.TabIndex = 56;
            // 
            // textBox_rotation_norm_y
            // 
            this.textBox_rotation_norm_y.Location = new System.Drawing.Point(356, 317);
            this.textBox_rotation_norm_y.Name = "textBox_rotation_norm_y";
            this.textBox_rotation_norm_y.ReadOnly = true;
            this.textBox_rotation_norm_y.Size = new System.Drawing.Size(100, 20);
            this.textBox_rotation_norm_y.TabIndex = 55;
            // 
            // textBox_rotation_norm_x
            // 
            this.textBox_rotation_norm_x.Location = new System.Drawing.Point(250, 317);
            this.textBox_rotation_norm_x.Name = "textBox_rotation_norm_x";
            this.textBox_rotation_norm_x.ReadOnly = true;
            this.textBox_rotation_norm_x.Size = new System.Drawing.Size(100, 20);
            this.textBox_rotation_norm_x.TabIndex = 54;
            // 
            // textBox_matrix_1_4
            // 
            this.textBox_matrix_1_4.Location = new System.Drawing.Point(979, 103);
            this.textBox_matrix_1_4.Name = "textBox_matrix_1_4";
            this.textBox_matrix_1_4.ReadOnly = true;
            this.textBox_matrix_1_4.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_1_4.TabIndex = 8;
            // 
            // textBox_matrix_1_3
            // 
            this.textBox_matrix_1_3.Location = new System.Drawing.Point(873, 103);
            this.textBox_matrix_1_3.Name = "textBox_matrix_1_3";
            this.textBox_matrix_1_3.ReadOnly = true;
            this.textBox_matrix_1_3.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_1_3.TabIndex = 7;
            // 
            // textBox_matrix_1_2
            // 
            this.textBox_matrix_1_2.Location = new System.Drawing.Point(767, 103);
            this.textBox_matrix_1_2.Name = "textBox_matrix_1_2";
            this.textBox_matrix_1_2.ReadOnly = true;
            this.textBox_matrix_1_2.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_1_2.TabIndex = 6;
            // 
            // textBox_matrix_1_1
            // 
            this.textBox_matrix_1_1.Location = new System.Drawing.Point(661, 103);
            this.textBox_matrix_1_1.Name = "textBox_matrix_1_1";
            this.textBox_matrix_1_1.ReadOnly = true;
            this.textBox_matrix_1_1.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_1_1.TabIndex = 5;
            // 
            // textBox_matrix_2_4
            // 
            this.textBox_matrix_2_4.Location = new System.Drawing.Point(979, 143);
            this.textBox_matrix_2_4.Name = "textBox_matrix_2_4";
            this.textBox_matrix_2_4.ReadOnly = true;
            this.textBox_matrix_2_4.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_2_4.TabIndex = 60;
            // 
            // textBox_matrix_2_3
            // 
            this.textBox_matrix_2_3.Location = new System.Drawing.Point(873, 143);
            this.textBox_matrix_2_3.Name = "textBox_matrix_2_3";
            this.textBox_matrix_2_3.ReadOnly = true;
            this.textBox_matrix_2_3.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_2_3.TabIndex = 59;
            // 
            // textBox_matrix_2_2
            // 
            this.textBox_matrix_2_2.Location = new System.Drawing.Point(767, 143);
            this.textBox_matrix_2_2.Name = "textBox_matrix_2_2";
            this.textBox_matrix_2_2.ReadOnly = true;
            this.textBox_matrix_2_2.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_2_2.TabIndex = 58;
            // 
            // textBox_matrix_2_1
            // 
            this.textBox_matrix_2_1.Location = new System.Drawing.Point(661, 143);
            this.textBox_matrix_2_1.Name = "textBox_matrix_2_1";
            this.textBox_matrix_2_1.ReadOnly = true;
            this.textBox_matrix_2_1.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_2_1.TabIndex = 57;
            // 
            // textBox_matrix_3_4
            // 
            this.textBox_matrix_3_4.Location = new System.Drawing.Point(979, 183);
            this.textBox_matrix_3_4.Name = "textBox_matrix_3_4";
            this.textBox_matrix_3_4.ReadOnly = true;
            this.textBox_matrix_3_4.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_3_4.TabIndex = 64;
            // 
            // textBox_matrix_3_3
            // 
            this.textBox_matrix_3_3.Location = new System.Drawing.Point(873, 183);
            this.textBox_matrix_3_3.Name = "textBox_matrix_3_3";
            this.textBox_matrix_3_3.ReadOnly = true;
            this.textBox_matrix_3_3.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_3_3.TabIndex = 63;
            // 
            // textBox_matrix_3_2
            // 
            this.textBox_matrix_3_2.Location = new System.Drawing.Point(767, 183);
            this.textBox_matrix_3_2.Name = "textBox_matrix_3_2";
            this.textBox_matrix_3_2.ReadOnly = true;
            this.textBox_matrix_3_2.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_3_2.TabIndex = 62;
            // 
            // textBox_matrix_3_1
            // 
            this.textBox_matrix_3_1.Location = new System.Drawing.Point(661, 183);
            this.textBox_matrix_3_1.Name = "textBox_matrix_3_1";
            this.textBox_matrix_3_1.ReadOnly = true;
            this.textBox_matrix_3_1.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_3_1.TabIndex = 61;
            // 
            // textBox_matrix_4_4
            // 
            this.textBox_matrix_4_4.Location = new System.Drawing.Point(979, 223);
            this.textBox_matrix_4_4.Name = "textBox_matrix_4_4";
            this.textBox_matrix_4_4.ReadOnly = true;
            this.textBox_matrix_4_4.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_4_4.TabIndex = 68;
            // 
            // textBox_matrix_4_3
            // 
            this.textBox_matrix_4_3.Location = new System.Drawing.Point(873, 223);
            this.textBox_matrix_4_3.Name = "textBox_matrix_4_3";
            this.textBox_matrix_4_3.ReadOnly = true;
            this.textBox_matrix_4_3.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_4_3.TabIndex = 67;
            // 
            // textBox_matrix_4_2
            // 
            this.textBox_matrix_4_2.Location = new System.Drawing.Point(767, 223);
            this.textBox_matrix_4_2.Name = "textBox_matrix_4_2";
            this.textBox_matrix_4_2.ReadOnly = true;
            this.textBox_matrix_4_2.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_4_2.TabIndex = 66;
            // 
            // textBox_matrix_4_1
            // 
            this.textBox_matrix_4_1.Location = new System.Drawing.Point(661, 223);
            this.textBox_matrix_4_1.Name = "textBox_matrix_4_1";
            this.textBox_matrix_4_1.ReadOnly = true;
            this.textBox_matrix_4_1.Size = new System.Drawing.Size(100, 20);
            this.textBox_matrix_4_1.TabIndex = 65;
            // 
            // label_rotationmatrix
            // 
            this.label_rotationmatrix.AutoSize = true;
            this.label_rotationmatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rotationmatrix.Location = new System.Drawing.Point(655, 58);
            this.label_rotationmatrix.Name = "label_rotationmatrix";
            this.label_rotationmatrix.Size = new System.Drawing.Size(211, 33);
            this.label_rotationmatrix.TabIndex = 69;
            this.label_rotationmatrix.Text = "Rotation Matrix";
            // 
            // checkBox_autoupdate_fourvector
            // 
            this.checkBox_autoupdate_fourvector.AutoSize = true;
            this.checkBox_autoupdate_fourvector.Location = new System.Drawing.Point(661, 16);
            this.checkBox_autoupdate_fourvector.Name = "checkBox_autoupdate_fourvector";
            this.checkBox_autoupdate_fourvector.Size = new System.Drawing.Size(124, 30);
            this.checkBox_autoupdate_fourvector.TabIndex = 70;
            this.checkBox_autoupdate_fourvector.Text = "Automatically update\r\n four vector";
            this.checkBox_autoupdate_fourvector.UseVisualStyleBackColor = true;
            // 
            // Form_rotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 482);
            this.Controls.Add(this.checkBox_autoupdate_fourvector);
            this.Controls.Add(this.label_rotationmatrix);
            this.Controls.Add(this.textBox_matrix_4_4);
            this.Controls.Add(this.textBox_matrix_4_3);
            this.Controls.Add(this.textBox_matrix_4_2);
            this.Controls.Add(this.textBox_matrix_4_1);
            this.Controls.Add(this.textBox_matrix_3_4);
            this.Controls.Add(this.textBox_matrix_3_3);
            this.Controls.Add(this.textBox_matrix_3_2);
            this.Controls.Add(this.textBox_matrix_3_1);
            this.Controls.Add(this.textBox_matrix_2_4);
            this.Controls.Add(this.textBox_matrix_2_3);
            this.Controls.Add(this.textBox_matrix_2_2);
            this.Controls.Add(this.textBox_matrix_2_1);
            this.Controls.Add(this.textBox_matrix_1_4);
            this.Controls.Add(this.textBox_matrix_1_3);
            this.Controls.Add(this.textBox_matrix_1_2);
            this.Controls.Add(this.textBox_matrix_1_1);
            this.Controls.Add(this.textBox_rotation_norm_z);
            this.Controls.Add(this.textBox_rotation_norm_y);
            this.Controls.Add(this.textBox_rotation_norm_x);
            this.Controls.Add(this.rotated_fourvector);
            this.Controls.Add(this.button_rotate);
            this.Controls.Add(this.label_rotation_unitvector);
            this.Controls.Add(this.label_rotation_angle);
            this.Controls.Add(this.textBox_rotation_angle);
            this.Controls.Add(this.textBox_rotation_z);
            this.Controls.Add(this.textBox_rotation_y);
            this.Controls.Add(this.textBox_rotation_x);
            this.Controls.Add(this.rotation_formula);
            this.Controls.Add(this.label_boost3d_normalized);
            this.Controls.Add(this.label_rotationvector);
            this.Controls.Add(this.panel_fourvector);
            this.Name = "Form_rotation";
            this.Text = "Rotation of four vector";
            this.panel_fourvector.ResumeLayout(false);
            this.panel_fourvector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_formula_fourvector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotation_formula)).EndInit();
            this.rotated_fourvector.ResumeLayout(false);
            this.rotated_fourvector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_fourvector;
        private System.Windows.Forms.TextBox textBox_x3;
        private System.Windows.Forms.TextBox textBox_x2;
        private System.Windows.Forms.TextBox textBox_x1;
        private System.Windows.Forms.TextBox textBox_x0;
        private System.Windows.Forms.PictureBox pictureBox_formula_fourvector;
        private System.Windows.Forms.Label label_boost3d_normalized;
        private System.Windows.Forms.Label label_rotationvector;
        private System.Windows.Forms.PictureBox rotation_formula;
        private System.Windows.Forms.TextBox textBox_rotation_z;
        private System.Windows.Forms.TextBox textBox_rotation_y;
        private System.Windows.Forms.TextBox textBox_rotation_x;
        private System.Windows.Forms.TextBox textBox_rotation_angle;
        private System.Windows.Forms.Label label_rotation_angle;
        private System.Windows.Forms.Label label_rotation_unitvector;
        private System.Windows.Forms.Button button_rotate;
        private System.Windows.Forms.Panel rotated_fourvector;
        private System.Windows.Forms.TextBox textBox_rotated_x3;
        private System.Windows.Forms.TextBox textBox_rotated_x2;
        private System.Windows.Forms.TextBox textBox_rotated_x1;
        private System.Windows.Forms.TextBox textBox_rotated_x0;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_rotation_norm_z;
        private System.Windows.Forms.TextBox textBox_rotation_norm_y;
        private System.Windows.Forms.TextBox textBox_rotation_norm_x;
        private System.Windows.Forms.TextBox textBox_matrix_1_4;
        private System.Windows.Forms.TextBox textBox_matrix_1_3;
        private System.Windows.Forms.TextBox textBox_matrix_1_2;
        private System.Windows.Forms.TextBox textBox_matrix_1_1;
        private System.Windows.Forms.TextBox textBox_matrix_2_4;
        private System.Windows.Forms.TextBox textBox_matrix_2_3;
        private System.Windows.Forms.TextBox textBox_matrix_2_2;
        private System.Windows.Forms.TextBox textBox_matrix_2_1;
        private System.Windows.Forms.TextBox textBox_matrix_3_4;
        private System.Windows.Forms.TextBox textBox_matrix_3_3;
        private System.Windows.Forms.TextBox textBox_matrix_3_2;
        private System.Windows.Forms.TextBox textBox_matrix_3_1;
        private System.Windows.Forms.TextBox textBox_matrix_4_4;
        private System.Windows.Forms.TextBox textBox_matrix_4_3;
        private System.Windows.Forms.TextBox textBox_matrix_4_2;
        private System.Windows.Forms.TextBox textBox_matrix_4_1;
        private System.Windows.Forms.Label label_rotationmatrix;
        private System.Windows.Forms.Button button_updatefourvector;
        private System.Windows.Forms.CheckBox checkBox_autoupdate_fourvector;
    }
}