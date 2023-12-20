namespace Dictionary_Practice_04__Windows_Forms_
{
    partial class FrmContadorPalabras
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
            rtxtContadorPalabras = new RichTextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // rtxtContadorPalabras
            // 
            rtxtContadorPalabras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtxtContadorPalabras.Location = new Point(6, 6);
            rtxtContadorPalabras.Name = "rtxtContadorPalabras";
            rtxtContadorPalabras.Size = new Size(1046, 952);
            rtxtContadorPalabras.TabIndex = 0;
            rtxtContadorPalabras.Text = "";
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCalcular.Location = new Point(625, 978);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(427, 79);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // FrmContadorPalabras
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 1069);
            Controls.Add(btnCalcular);
            Controls.Add(rtxtContadorPalabras);
            Name = "FrmContadorPalabras";
            Text = "Contador de Palabras";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtxtContadorPalabras;
        private Button btnCalcular;
    }
}
