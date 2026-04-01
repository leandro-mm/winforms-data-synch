namespace RealTimeWinFormsApp
{
    partial class FormSecondary
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
            lblDataSecondaryView = new Label();
            SuspendLayout();
            // 
            // lblDataSecondaryView
            // 
            lblDataSecondaryView.AutoSize = true;
            lblDataSecondaryView.Location = new Point(12, 20);
            lblDataSecondaryView.Name = "lblDataSecondaryView";
            lblDataSecondaryView.Size = new Size(101, 15);
            lblDataSecondaryView.TabIndex = 0;
            lblDataSecondaryView.Text = "Waiting for data...";
            // 
            // SecondaryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 105);
            Controls.Add(lblDataSecondaryView);
            Name = "SecondaryView";
            Text = "SecondaryView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDataSecondaryView;
    }
}