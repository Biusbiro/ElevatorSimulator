
namespace Elevator_Simulator
{
    partial class Principal
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
            this.pbxBuilding = new System.Windows.Forms.PictureBox();
            this.pbxControl = new System.Windows.Forms.PictureBox();
            this.pbxElevator = new System.Windows.Forms.PictureBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuilding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxElevator)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxBuilding
            // 
            this.pbxBuilding.Image = global::Elevator_Simulator.Properties.Resources.Building;
            this.pbxBuilding.Location = new System.Drawing.Point(413, 14);
            this.pbxBuilding.Name = "pbxBuilding";
            this.pbxBuilding.Size = new System.Drawing.Size(345, 526);
            this.pbxBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBuilding.TabIndex = 0;
            this.pbxBuilding.TabStop = false;
            // 
            // pbxControl
            // 
            this.pbxControl.Image = global::Elevator_Simulator.Properties.Resources.control;
            this.pbxControl.Location = new System.Drawing.Point(29, 14);
            this.pbxControl.Name = "pbxControl";
            this.pbxControl.Size = new System.Drawing.Size(345, 526);
            this.pbxControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxControl.TabIndex = 1;
            this.pbxControl.TabStop = false;
            // 
            // pbxElevator
            // 
            this.pbxElevator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxElevator.Image = global::Elevator_Simulator.Properties.Resources.Elevator;
            this.pbxElevator.Location = new System.Drawing.Point(552, 370);
            this.pbxElevator.Name = "pbxElevator";
            this.pbxElevator.Size = new System.Drawing.Size(42, 50);
            this.pbxElevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxElevator.TabIndex = 2;
            this.pbxElevator.TabStop = false;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(332, 23);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(332, 52);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.pbxElevator);
            this.Controls.Add(this.pbxControl);
            this.Controls.Add(this.pbxBuilding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuilding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxElevator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBuilding;
        private System.Windows.Forms.PictureBox pbxControl;
        private System.Windows.Forms.PictureBox pbxElevator;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
    }
}

