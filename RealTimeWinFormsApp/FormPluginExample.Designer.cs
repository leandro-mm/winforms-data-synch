namespace RealTimeWinFormsApp
{
    partial class FormPluginExample
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
            label1Plugin = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1Plugin
            // 
            label1Plugin.AutoSize = true;
            label1Plugin.Location = new Point(28, 26);
            label1Plugin.Name = "label1Plugin";
            label1Plugin.Size = new Size(0, 15);
            label1Plugin.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 11);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 1;
            label2.Text = "Changing Counter";
            // 
            // FormPluginExample
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 128);
            Controls.Add(label2);
            Controls.Add(label1Plugin);
            Name = "FormPluginExample";
            Text = "FormPluginExample";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1Plugin;
        private Label label2;
    }
}