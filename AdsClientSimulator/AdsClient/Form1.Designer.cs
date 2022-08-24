namespace AdsClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ch_gp_ch_checks_disable_sdp = new System.Windows.Forms.TextBox();
            this.ch_gp_ct_no_production_cnt = new System.Windows.Forms.TextBox();
            this.ch_motor_stack_level_error_counter_cnt = new System.Windows.Forms.TextBox();
            this.ch_motor_slow_phase_ifl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(453, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "ch_gp_ch_checks_disable_sdp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(453, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "ch_gp_ct_no_production_cnt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(453, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "ch_motor_stack_level_error_counter_cnt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(51, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(453, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "ch_motor_slow_phase_ifl";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ch_gp_ch_checks_disable_sdp
            // 
            this.ch_gp_ch_checks_disable_sdp.Location = new System.Drawing.Point(544, 69);
            this.ch_gp_ch_checks_disable_sdp.Name = "ch_gp_ch_checks_disable_sdp";
            this.ch_gp_ch_checks_disable_sdp.Size = new System.Drawing.Size(374, 39);
            this.ch_gp_ch_checks_disable_sdp.TabIndex = 5;
            // 
            // ch_gp_ct_no_production_cnt
            // 
            this.ch_gp_ct_no_production_cnt.Location = new System.Drawing.Point(544, 140);
            this.ch_gp_ct_no_production_cnt.Name = "ch_gp_ct_no_production_cnt";
            this.ch_gp_ct_no_production_cnt.Size = new System.Drawing.Size(374, 39);
            this.ch_gp_ct_no_production_cnt.TabIndex = 6;
            // 
            // ch_motor_stack_level_error_counter_cnt
            // 
            this.ch_motor_stack_level_error_counter_cnt.Location = new System.Drawing.Point(544, 212);
            this.ch_motor_stack_level_error_counter_cnt.Name = "ch_motor_stack_level_error_counter_cnt";
            this.ch_motor_stack_level_error_counter_cnt.Size = new System.Drawing.Size(374, 39);
            this.ch_motor_stack_level_error_counter_cnt.TabIndex = 7;
            // 
            // ch_motor_slow_phase_ifl
            // 
            this.ch_motor_slow_phase_ifl.Location = new System.Drawing.Point(544, 289);
            this.ch_motor_slow_phase_ifl.Name = "ch_motor_slow_phase_ifl";
            this.ch_motor_slow_phase_ifl.Size = new System.Drawing.Size(374, 39);
            this.ch_motor_slow_phase_ifl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 592);
            this.Controls.Add(this.ch_motor_slow_phase_ifl);
            this.Controls.Add(this.ch_motor_stack_level_error_counter_cnt);
            this.Controls.Add(this.ch_gp_ct_no_production_cnt);
            this.Controls.Add(this.ch_gp_ch_checks_disable_sdp);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox ch_gp_ch_checks_disable_sdp;
        private TextBox ch_gp_ct_no_production_cnt;
        private TextBox ch_motor_stack_level_error_counter_cnt;
        private TextBox ch_motor_slow_phase_ifl;
    }
}