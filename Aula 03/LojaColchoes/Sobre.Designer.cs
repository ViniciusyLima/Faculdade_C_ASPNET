namespace LojaColchoes
{
    partial class Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobre));
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(301, 304);
            label1.TabIndex = 0;
            label1.Text = "Loja São Miguel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(71, 261);
            label3.Name = "label3";
            label3.Size = new Size(219, 25);
            label3.TabIndex = 2;
            label3.Text = "A melhor opção na região";
            // 
            // Sobre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 390);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Sobre";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sobre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
    }
}